using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoETL;
using System.IO;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.ComponentModel;
using ChoETL.HL7.Model;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace ChoETL.HL7
{
    public class ChoHL7Message : ChoHL7AbstractMessage
    {
        public ChoHL7Version Version
        {
            get;
            private set;
        }
        public ChoHL7MessageType MessageType
        {
            get;
            private set;
        }

        public bool IsValid
        {
            get;
            private set;
        }

        public string ErrorMsg
        {
            get;
            private set;
        }

        public string ErrorDetail
        {
            get;
            private set;
        }

        private readonly List<ChoHL7Segment> _segments = new List<ChoHL7Segment>();
        protected List<ChoHL7Segment> Segments
        {
            get { return _segments; }
        }

        public ChoHL7Message()
        {
            IsValid = true;
        }

        internal void SetError(Exception ex)
        {
            IsValid = false;
            ErrorMsg = ex.Message;
            ErrorDetail = ChoException.ToString(ex);
        }

        internal void SetError(string errMsg)
        {
            IsValid = false;
            ErrorMsg = errMsg;
            ErrorDetail = errMsg;
        }

        //public override string ToString()
        //{
        //    if (Segments != null)
        //    {
        //        StringBuilder msg = new StringBuilder();
        //        foreach (var sc in Segments)
        //        {
        //            if (msg.Length == 0)
        //                msg.Append(sc.ToString());
        //            else
        //                msg.Append("{0}{1}".FormatString(ChoHL7Configuration.Instance.SegmentSeperator, sc.ToString()));
        //        }
        //        return msg.ToString();
        //    }
        //    else
        //        return String.Empty;
        //}

        protected override bool GetPropertyValue(string name, out object result)
        {
            if (IsValid)
                return base.GetPropertyValue(name, out result);
            else
                throw new ChoHL7Exception(ErrorMsg);
        }

        public static ChoHL7Message Parse(string filePath, ChoHL7Configuration configuration = null)
        {
            configuration = configuration ?? ChoHL7Configuration.Instance;
            return Parse(new StreamReader(ChoPath.GetFullPath(filePath), configuration.GetEncoding(filePath), false, configuration.BufferSize), configuration);
        }
        public static ChoHL7Message Parse(Stream inStream, ChoHL7Configuration configuration = null)
        {
            configuration = configuration ?? ChoHL7Configuration.Instance;
            if (inStream is MemoryStream)
                return Parse(new StreamReader(inStream), configuration);
            else
                return Parse(new StreamReader(inStream, configuration.GetEncoding(inStream), false, configuration.BufferSize), configuration);
        }
        public static ChoHL7Message ParseText(string inputText, Encoding encoding = null, ChoHL7Configuration configuration = null)
        {
            return Parse(inputText.ToStream(encoding));
        }
        public static ChoHL7Message Parse(TextReader textReader, ChoHL7Configuration configuration = null)
        {
            ChoHL7Message msg = null;
            configuration = configuration ?? ChoHL7Configuration.Instance;
            bool _configCheckDone = false;
            bool? skip = false;
            string[] commentTokens = configuration.Comments;
            using (ChoPeekEnumerator<Tuple<long, string>> e = new ChoPeekEnumerator<Tuple<long, string>>(
                new ChoIndexedEnumerator<string>(textReader.ReadLines(configuration.SegmentSeperator.ToString(), ChoCharEx.NUL, false)).ToEnumerable(),
                (pair) =>
                {
                    //bool isStateAvail = IsStateAvail();
                    skip = false;

                    //if (isStateAvail)
                    //{
                    //    if (!IsStateMatches(item))
                    //    {
                    //        skip = filterFunc != null ? filterFunc(item) : false;
                    //    }
                    //    else
                    //        skip = true;
                    //}
                    //else
                    //    skip = filterFunc != null ? filterFunc(item) : false;

                    if (skip == null)
                        return null;

                    if (configuration.TraceSwitch.TraceVerbose)
                    {
                        //ChoETLFramework.WriteLog(configuration.TraceSwitch.TraceVerbose, Environment.NewLine);

                        if (!skip.Value)
                            ChoETLFramework.WriteLog(configuration.TraceSwitch.TraceVerbose, "Loading line [{0}]...".FormatString(pair.Item1));
                        else
                            ChoETLFramework.WriteLog(configuration.TraceSwitch.TraceVerbose, "Skipping line [{0}]...".FormatString(pair.Item1));
                    }

                    if (skip.Value)
                        return skip;

                    if (pair.Item2.IsNullOrWhiteSpace())
                    {
                        if (!configuration.IgnoreEmptyLine)
                            throw new ChoHL7Exception("Empty line found at [{0}] location.".FormatString(pair.Item1));
                        else
                        {
                            if (configuration.TraceSwitch.TraceVerbose)
                                ChoETLFramework.WriteLog(configuration.TraceSwitch.TraceVerbose, "Ignoring empty line found at [{0}].".FormatString(pair.Item1));
                            return true;
                        }
                    }

                    if (commentTokens != null && commentTokens.Length > 0)
                    {
                        foreach (string comment in commentTokens)
                        {
                            if (!pair.Item2.IsNull() && pair.Item2.StartsWith(comment, StringComparison.Ordinal)) //, true, Configuration.Culture))
                            {
                                if (configuration.TraceSwitch.TraceVerbose)
                                    ChoETLFramework.WriteLog(configuration.TraceSwitch.TraceVerbose, "Comment line found at [{0}]...".FormatString(pair.Item1));
                                return true;
                            }
                        }
                    }

                    if (!_configCheckDone)
                    {
                        configuration.Validate(pair.Item2);
                        msg = CreateInstance(configuration);

                        _configCheckDone = true;
                    }

                    return false;
                }))
            {
                while (true)
                {
                    Tuple<long, string> pair = e.Peek;
                    if (pair == null)
                        break;

                    try
                    {
                        var segment = ChoHL7Segment.Parse(pair.Item2, configuration);
                        msg.Segments.Add(segment);
                    }
                    catch (Exception ex)
                    {
                        msg.SetError(ex);
                        break;
                    }

                    e.MoveNext();
                }
            }
            var iter = new ChoPeekEnumerator<ChoHL7Segment>(msg.Segments);

            try
            {
                if (msg.IsValid)
                {
                    msg.Construct(iter);
                    msg.IsValid = iter.Peek == null;
                    if (iter.Peek != null)
                        msg.SetError("Unrecognized '{0}' segment found in message.".FormatString(iter.Peek.Type));
                }
            }
            catch (Exception ex)
            {
                msg.SetError(ex);
            }

            return msg;
        }

        private static ChoHL7Message CreateInstance(ChoHL7Configuration configuration)
        {
            ChoHL7MessageType mt = configuration.MessageType;
            ChoHL7Version version = configuration.Version;

            ChoHL7Message msg = null;

            string messageTypeName = "ChoETL.HL7.Model.{0}.{1}".FormatString(version.ToString(), mt.ToString());
            if (!ChoHL7MessageCache.Instance.HL7MessageDict.ContainsKey(messageTypeName))
                throw new ChoHL7Exception("Can't find '{0}' HL7 Message type.".FormatString(messageTypeName));

            msg = CreateInstance(ChoHL7MessageCache.Instance.HL7MessageDict[messageTypeName]) as ChoHL7Message;
            msg.Version = version;
            msg.MessageType = mt;
            return msg;
        }

        public static bool TryParse(string line, ChoHL7Configuration configuration, out ChoHL7Message rec, out string errMsg)
        {
            rec = null;
            errMsg = null;
            try
            {
                rec = Parse(line, configuration);
                return true;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return false;
            }
        }

        public static T CreateElementInstance<T>(ChoHL7Configuration configuration, params object[] args)
        {
            ChoHL7Version version = configuration.Version;

            string fieldTypeName = "ChoETL.HL7.Model.{0}.{1}".FormatString(version.ToString(), typeof(T).Name);
            if (!ChoHL7MessageCache.Instance.HL7FieldTypeDict.ContainsKey(fieldTypeName))
                throw new ChoHL7Exception("Can't find '{0}' HL7 field type.".FormatString(fieldTypeName));

            return (T)CreateInstance(ChoHL7MessageCache.Instance.HL7FieldTypeDict[fieldTypeName], args);
        }

        private static object CreateInstance(Type type, params object[] args)
        {
            try
            {
                return ChoActivator.CreateInstance(type, args);
            }
            catch (Exception ex)
            {
                throw new ChoHL7Exception("Failed to create '{0}' object.".FormatString(type.FullName), ex);
            }
        }
    }
}
