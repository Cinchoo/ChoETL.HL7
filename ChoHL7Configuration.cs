using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    [DataContract]
    public class ChoHL7Configuration
    {
        public static ChoHL7Configuration Instance = new ChoHL7Configuration();

        public TraceSwitch TraceSwitch = ChoETLFramework.TraceSwitch;
        public char SegmentSeperator = ChoCharEx.CarriageReturn;
        public char FieldSeparator = '|';
        public char SubcomponentSeparator = '&';
        public char ComponentSeparator = '^';
        public char RepeatSeparator = '~';
        [DataMember]
        public string[] Comments
        {
            get;
            set;
        }
        [DataMember]
        public bool DisableEnumChecks
        {
            get;
            set;
        }
        [DataMember]
        public bool IgnoreEmptyLine
        {
            get;
            set;
        }
        public bool DisableValueInErrorMessage
        {
            get;
            set;
        }
        [DataMember]
        public int EncodingPage
        {
            get { return Encoding != null ? Encoding.CodePage : 0; }
            set
            {
                if (value > 0)
                    Encoding = Encoding.GetEncoding(value);
            }
        }
        private Encoding _encoding;
        public Encoding Encoding
        {
            get { return _encoding != null ? _encoding : Encoding.UTF8; }
            set { _encoding = value; }
        }
        [DataMember]
        public int BufferSize
        {
            get;
            set;
        }
        [DataMember]
        public long NotifyAfter { get; set; }
        [DataMember]
        public ChoObjectValidationMode ObjectValidationMode
        {
            get;
            set;
        }
        [DataMember]
        public ChoErrorMode ErrorMode
        {
            get;
            set;
        }
        [DataMember]
        public string DateFormat => "yyyyMMdd";

        public ChoHL7Configuration(ChoHL7MessageType? messageType = null, ChoHL7Version? version = null)
        {
            BufferSize = 4096;
            LoadWithMessageType = messageType;
            LoadWithVersion = version;
        }

        public string Encode(string txt)
        {
            return txt;
        }

        public string Decode(string txt)
        {
            return txt;
        }

        internal ChoHL7Version? LoadWithVersion
        {
            get;
            set;
        }
        public ChoHL7Version Version
        {
            get;
            private set;
        }

        internal ChoHL7MessageType? LoadWithMessageType
        {
            get;
            set;
        }

        public ChoHL7MessageType MessageType
        {
            get;
            private set;
        }

        public Encoding GetEncoding(Stream inStream)
        {
            if (_encoding == null)
            {
                try
                {
                    ChoETLLog.Info("Determining file encoding...");
                    Encoding = ChoFile.GetEncodingFromStream(inStream);
                    ChoETLLog.Info("Found {0} encoding in file.".FormatString(Encoding));
                }
                catch (Exception ex)
                {
                    Encoding = Encoding.UTF8;
                    ChoETLLog.Error("Error finding encoding in file. Default to UTF8.");
                    ChoETLLog.Error(ex.Message);
                }
            }

            return Encoding;
        }

        public Encoding GetEncoding(string fileName)
        {
            if (_encoding == null)
            {
                try
                {
                    ChoETLLog.Info("Determining '{0}' file encoding...".FormatString(fileName));
                    Encoding = ChoFile.GetEncodingFromFile(fileName);
                    ChoETLLog.Info("Found '{1}' encoding in '{0}' file.".FormatString(fileName, Encoding));
                }
                catch (Exception ex)
                {
                    Encoding = Encoding.UTF8;
                    ChoETLLog.Error("Error finding encoding in '{0}' file. Default to UTF8.".FormatString(fileName));
                    ChoETLLog.Error(ex.Message);
                }
            }

            return Encoding;
        }

        internal void Validate(string line)
        {
            if (line.IsNullOrWhiteSpace())
                throw new ChoHL7Exception("Empty line found.");

            if (!line.StartsWith("MSH"))
                throw new ChoHL7Exception("Missing Message Header (MSH) record.");
            if (line.Length <= 3 || line[3] == ChoCharEx.NUL)
                throw new ChoHL7Exception("Missing or NULL Field Separator found.");
            else
                FieldSeparator = line[3];

            if (FieldSeparator.ToString().IsAlphaNumeric())
                throw new ChoHL7Exception("Invalid '{0}' field separator found.".FormatString(FieldSeparator));

            if (line.Length <= 8)
                throw new ChoHL7Exception("Missing encoding characters.");
            else
            {
                var encodingChars = line.Substring(4, 4);
                if (encodingChars != @"^~\&")
                    throw new ChoHL7Exception("Invalid encoding characters found.");
                if (encodingChars.Where(c => c == ChoCharEx.NUL).Any())
                    throw new ChoHL7Exception("NULL encoding characters found.");
            }

            string[] fields = line.Split(FieldSeparator);

            if (fields.Length < 11 || fields[11].IsNullOrWhiteSpace())
                throw new ChoHL7Exception("Missing version.");

            string versionTxt = fields[11];
            var v = versionTxt.ToEnum(typeof(ChoHL7Version));
            if (v == null)
                throw new ChoHL7Exception("'{0}' version not supported.".FormatString(versionTxt));

            if (LoadWithVersion == null)
            {
                Version = (ChoHL7Version)v;
                ChoETLLog.Info("Version found in message: {0}".FormatString(Version));
            }
            else
            {
                ChoETLLog.Info("Version found in message: {0}".FormatString((ChoHL7Version)v));
                Version = LoadWithVersion.Value;
                ChoETLLog.Info("But loading message with version: {0}".FormatString(Version));
            }

            if (fields[8].IsNullOrWhiteSpace())
                throw new ChoHL7Exception("Missing Message Type.");
            string mtText = fields[8];
            var mtEnumTxt = mtText.ToEnum(typeof(ChoHL7MessageType));
            if (mtEnumTxt == null)
                throw new ChoHL7Exception("'{0}' Message Type not supported.".FormatString(mtText));

            if (LoadWithMessageType == null)
            {
                MessageType = (ChoHL7MessageType)mtEnumTxt;
                ChoETLLog.Info("MessageType found in message: {0}".FormatString(MessageType));
            }
            else
            {
                ChoETLLog.Info("MessageType found in message: {0}".FormatString((ChoHL7MessageType)mtEnumTxt));
                MessageType = LoadWithMessageType.Value;
                ChoETLLog.Info("But loading message with MessageType: {0}".FormatString(MessageType));
            }
        }
    }
}
