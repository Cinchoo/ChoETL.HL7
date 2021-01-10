using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    internal class ChoHL7RecordReader : ChoRecordReader
    {
        private IChoNotifyRecordRead _callbackRecord;
        //private bool _headerFound = false;
        //private bool _excelSeparatorFound = false;
        //private string[] _fieldNames = null;
        private bool _configCheckDone = false;
        //private Dictionary<string, string> fieldNameValues = null;
        internal ChoReader Reader = null;

        public ChoHL7Configuration Configuration
        {
            get;
            private set;
        }

        public ChoHL7RecordReader(Type recordType, ChoHL7Configuration configuration) : base(recordType)
        {
            ChoGuard.ArgumentNotNull(configuration, "Configuration");
            Configuration = configuration;
            _callbackRecord = ChoMetadataObjectCache.CreateMetadataObject<IChoNotifyRecordRead>(recordType);
            //Configuration.Validate();
        }

        public override IEnumerable<object> AsEnumerable(object source, Func<object, bool?> filterFunc = null)
        {
            return AsEnumerable(source, TraceSwitch, filterFunc);
        }

        private IEnumerable<object> AsEnumerable(object source, TraceSwitch traceSwitch, Func<object, bool?> filterFunc = null)
        {
            TraceSwitch = traceSwitch;

            TextReader sr = source as TextReader;
            ChoGuard.ArgumentNotNull(sr, "TextReader");

            if (sr is StreamReader)
                ((StreamReader)sr).Seek(0, SeekOrigin.Begin);

            if (!RaiseBeginLoad(sr))
                yield break;

            string[] commentTokens = new string[] { };
            bool? skip = false;
            bool abortRequested = false;
            long runningCount = 0;

            using (ChoPeekEnumerator<Tuple<long, string>> e = new ChoPeekEnumerator<Tuple<long, string>>(
                new ChoIndexedEnumerator<string>(sr.ReadLines(Configuration.SegmentSeperator.ToString(), ChoCharEx.NUL, false)).ToEnumerable(),
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


                    if (TraceSwitch.TraceVerbose)
                    {
                        ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, Environment.NewLine);

                        if (!skip.Value)
                            ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, "Loading line [{0}]...".FormatString(pair.Item1));
                        else
                            ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, "Skipping line [{0}]...".FormatString(pair.Item1));
                    }

                    if (skip.Value)
                        return skip;

                    //if (!(sr.BaseStream is MemoryStream))
                    //    ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, ChoETLFramework.Switch.TraceVerbose, "Loading line [{0}]...".FormatString(item.Item1));

                    //if (Task != null)
                    //    return !IsStateNOTExistsOrNOTMatch(item);

                    if (pair.Item2.IsNullOrWhiteSpace())
                    {
                        if (!Configuration.IgnoreEmptyLine)
                            throw new ChoHL7Exception("Empty line found at [{0}] location.".FormatString(pair.Item1));
                        else
                        {
                            if (TraceSwitch.TraceVerbose)
                                ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, "Ignoring empty line found at [{0}].".FormatString(pair.Item1));
                            return true;
                        }
                    }

                    if (commentTokens != null && commentTokens.Length > 0)
                    {
                        foreach (string comment in commentTokens)
                        {
                            if (!pair.Item2.IsNull() && pair.Item2.StartsWith(comment, StringComparison.Ordinal)) //, true, Configuration.Culture))
                            {
                                if (TraceSwitch.TraceVerbose)
                                    ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, "Comment line found at [{0}]...".FormatString(pair.Item1));
                                return true;
                            }
                        }
                    }

                    if (!_configCheckDone)
                    {
                        //ChoHL7Version version;
                        //ChoHL7MessageType mt;
                        Configuration.Validate(pair.Item2);
                        _configCheckDone = true;
                    }

                    return false;
                }))
            {
                while (true)
                {
                    Tuple<long, string> pair = e.Peek;
                    if (pair == null)
                    {
                        if (!abortRequested)
                            RaisedRowsLoaded(runningCount);

                        RaiseEndLoad(sr);
                        yield break;
                    }
                    runningCount = pair.Item1;

                    object rec = null; // Configuration.IsDynamicObject ? new ExpandoObject() : Activator.CreateInstance(RecordType);
                    if (!LoadLine(pair, ref rec))
                        yield break;

                    //StoreState(e.Current, rec != null);

                    e.MoveNext();

                    if (rec == null)
                        continue;

                    yield return rec;

                    if (Configuration.NotifyAfter > 0 && pair.Item1 % Configuration.NotifyAfter == 0)
                    {
                        if (RaisedRowsLoaded(pair.Item1))
                        {
                            ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, "Abort requested.");
                            abortRequested = true;
                            yield break;
                        }
                    }
                }
            }
        }

        private bool LoadLine(Tuple<long, string> pair, ref object rec)
        {
            try
            {
                if (!RaiseBeforeRecordLoad(rec, ref pair))
                {
                    ChoETLFramework.WriteLog(TraceSwitch.TraceVerbose, "Skipping...");
                    rec = null;
                    return true;
                }

                if (pair.Item2 == null)
                {
                    rec = null;
                    return true;
                }
                else if (pair.Item2 == String.Empty)
                    return true;

                if (!pair.Item2.IsNullOrWhiteSpace())
                {
                    if (!FillRecord(rec, pair))
                        return false;

                    //if ((Configuration.ObjectValidationMode & ChoObjectValidationMode.ObjectLevel) == ChoObjectValidationMode.ObjectLevel)
                    //    rec.DoObjectLevelValidation(Configuration, Configuration.CSVRecordFieldConfigurations);
                }

                bool skip = false;
                if (!RaiseAfterRecordLoad(rec, pair, ref skip))
                    return false;
                else if (skip)
                {
                    rec = null;
                    return true;
                }
            }
            catch (ChoHL7Exception)
            {
                throw;
            }
            catch (ChoMissingRecordFieldException)
            {
                throw;
            }
            catch (Exception ex)
            {
                ChoETLFramework.HandleException(ref ex);
                if (Configuration.ErrorMode == ChoErrorMode.IgnoreAndContinue)
                {
                    rec = null;
                }
                else if (Configuration.ErrorMode == ChoErrorMode.ReportAndContinue)
                {
                    if (!RaiseRecordLoadError(rec, pair, ex))
                        throw;
                }
                else
                    throw;

                return true;
            }

            return true;
        }

        private bool FillRecord(object rec, Tuple<long, string> pair)
        {
            //long lineNo;
            //string line;

            //lineNo = pair.Item1;
            //line = pair.Item2;

            //string[] fieldValues = line.Split(Configuration.Delimiter, Configuration.StringSplitOptions, Configuration.QuoteChar);
            //if (Configuration.ColumnCountStrict)
            //{
            //    if (fieldValues.Length != Configuration.CSVRecordFieldConfigurations.Count)
            //        throw new ChoHL7Exception("Incorrect number of field values found at line [{2}]. Expected [{0}] field values. Found [{1}] field values.".FormatString(Configuration.CSVRecordFieldConfigurations.Count, fieldValues.Length, pair.Item1));
            //}

            //if (_fieldNames != null) //Configuration.FileHeaderConfiguration.HasHeaderRecord && Configuration.ColumnOrderStrict)
            //{
            //    if (this.fieldNameValues == null)
            //        this.fieldNameValues = InitFieldNameValuesDict();
            //    ToFieldNameValues(fieldNameValues, fieldValues);
            //}
            //ValidateLine(pair.Item1, fieldValues);

            //object fieldValue = null;
            //ChoCSVRecordFieldConfiguration fieldConfig = null;
            //PropertyInfo pi = null;
            //foreach (KeyValuePair<string, ChoCSVRecordFieldConfiguration> kvp in Configuration.FCArray)
            //{
            //    fieldValue = null;
            //    fieldConfig = kvp.Value;
            //    if (Configuration.PIDict != null)
            //        Configuration.PIDict.TryGetValue(kvp.Key, out pi);

            //    if (fieldNameValues != null)
            //    {
            //        if (fieldNameValues.ContainsKey(fieldConfig.FieldName))
            //            fieldValue = fieldNameValues[fieldConfig.FieldName];
            //        else
            //        {
            //            if (Configuration.ColumnOrderStrict)
            //                throw new ChoHL7Exception("No matching '{0}' field header found.".FormatString(fieldConfig.FieldName));
            //        }
            //    }
            //    else
            //    {
            //        if (fieldConfig.FieldPosition - 1 < fieldValues.Length)
            //            fieldValue = fieldValues[fieldConfig.FieldPosition - 1];
            //        else
            //            throw new ChoHL7Exception("Missing field value for '{0}' [Position: {1}] field.".FormatString(fieldConfig.FieldName, fieldConfig.FieldPosition));
            //    }

            //    //if (Configuration.FileHeaderConfiguration.HasHeaderRecord && Configuration.ColumnOrderStrict)
            //    //{
            //    //    if (fieldNameValues.ContainsKey(fieldConfig.FieldName))
            //    //        fieldValue = fieldNameValues[fieldConfig.FieldName];
            //    //    else if (Configuration.ColumnCountStrict)
            //    //        throw new ChoHL7Exception("No matching '{0}' field header found.".FormatString(fieldConfig.FieldName));
            //    //}
            //    //else
            //    //{
            //    //    if (fieldConfig.FieldPosition - 1 < fieldValues.Length)
            //    //        fieldValue = fieldValues[fieldConfig.FieldPosition - 1];
            //    //    else if (Configuration.ColumnCountStrict)
            //    //        throw new ChoHL7Exception("Missing field value for '{0}' [Position: {1}] field.".FormatString(fieldConfig.FieldName, fieldConfig.FieldPosition));
            //    //}

            //    if (Configuration.IsDynamicObject)
            //    {
            //        if (kvp.Value.FieldType == null)
            //            kvp.Value.FieldType = typeof(string);
            //    }
            //    else
            //    {
            //        if (pi != null)
            //            kvp.Value.FieldType = pi.PropertyType;
            //        else
            //            kvp.Value.FieldType = typeof(string);
            //    }

            //    fieldValue = CleanFieldValue(fieldConfig, kvp.Value.FieldType, fieldValue as string);

            //    if (!RaiseBeforeRecordFieldLoad(rec, pair.Item1, kvp.Key, ref fieldValue))
            //        continue;

            //    try
            //    {
            //        bool ignoreFieldValue = fieldConfig.IgnoreFieldValue(fieldValue);
            //        if (ignoreFieldValue)
            //            fieldValue = fieldConfig.IsDefaultValueSpecified ? fieldConfig.DefaultValue : null;

            //        if (Configuration.IsDynamicObject)
            //        {
            //            var dict = rec as IDictionary<string, Object>;

            //            dict.ConvertNSetMemberValue(kvp.Key, kvp.Value, ref fieldValue, Configuration.Culture);

            //            if ((Configuration.ObjectValidationMode & ChoObjectValidationMode.MemberLevel) == ChoObjectValidationMode.MemberLevel)
            //                dict.DoMemberLevelValidation(kvp.Key, kvp.Value, Configuration.ObjectValidationMode);
            //        }
            //        else
            //        {
            //            if (pi != null)
            //                rec.ConvertNSetMemberValue(kvp.Key, kvp.Value, ref fieldValue, Configuration.Culture);
            //            else
            //                throw new ChoMissingRecordFieldException("Missing '{0}' property in {1} type.".FormatString(kvp.Key, ChoType.GetTypeName(rec)));

            //            if ((Configuration.ObjectValidationMode & ChoObjectValidationMode.MemberLevel) == ChoObjectValidationMode.MemberLevel)
            //                rec.DoMemberLevelValidation(kvp.Key, kvp.Value, Configuration.ObjectValidationMode);
            //        }

            //        if (!RaiseAfterRecordFieldLoad(rec, pair.Item1, kvp.Key, fieldValue))
            //            return false;
            //    }
            //    catch (ChoHL7Exception)
            //    {
            //        throw;
            //    }
            //    catch (ChoMissingRecordFieldException)
            //    {
            //        if (Configuration.ThrowAndStopOnMissingField)
            //            throw;
            //    }
            //    catch (Exception ex)
            //    {
            //        ChoETLFramework.HandleException(ex);

            //        if (fieldConfig.ErrorMode == ChoErrorMode.ThrowAndStop)
            //            throw;

            //        try
            //        {
            //            if (Configuration.IsDynamicObject)
            //            {
            //                var dict = rec as IDictionary<string, Object>;

            //                if (dict.SetFallbackValue(kvp.Key, kvp.Value, Configuration.Culture, ref fieldValue))
            //                    dict.DoMemberLevelValidation(kvp.Key, kvp.Value, Configuration.ObjectValidationMode);
            //                else if (dict.SetDefaultValue(kvp.Key, kvp.Value, Configuration.Culture))
            //                    dict.DoMemberLevelValidation(kvp.Key, kvp.Value, Configuration.ObjectValidationMode);
            //                else
            //                    throw new ChoReaderException($"Failed to parse '{fieldValue}' value for '{fieldConfig.FieldName}' field.", ex);
            //            }
            //            else if (pi != null)
            //            {
            //                if (rec.SetFallbackValue(kvp.Key, kvp.Value, Configuration.Culture))
            //                    rec.DoMemberLevelValidation(kvp.Key, kvp.Value, Configuration.ObjectValidationMode);
            //                else if (rec.SetDefaultValue(kvp.Key, kvp.Value, Configuration.Culture))
            //                    rec.DoMemberLevelValidation(kvp.Key, kvp.Value, Configuration.ObjectValidationMode);
            //                else
            //                    throw new ChoReaderException($"Failed to parse '{fieldValue}' value for '{fieldConfig.FieldName}' field.", ex);
            //            }
            //            else
            //                throw new ChoReaderException($"Failed to parse '{fieldValue}' value for '{fieldConfig.FieldName}' field.", ex);
            //        }
            //        catch (Exception innerEx)
            //        {
            //            if (ex == innerEx.InnerException)
            //            {
            //                if (fieldConfig.ErrorMode == ChoErrorMode.IgnoreAndContinue)
            //                {
            //                    continue;
            //                }
            //                else
            //                {
            //                    if (!RaiseRecordFieldLoadError(rec, pair.Item1, kvp.Key, fieldValue, ex))
            //                        throw new ChoReaderException($"Failed to parse '{fieldValue}' value for '{fieldConfig.FieldName}' field.", ex);
            //                }
            //            }
            //            else
            //            {
            //                throw new ChoReaderException("Failed to assign '{0}' fallback value to '{1}' field.".FormatString(fieldValue, fieldConfig.FieldName), innerEx);
            //            }
            //        }
            //    }
            //}

            return true;
        }

        private string CleanFieldValue(ChoCSVRecordFieldConfiguration config, Type fieldType, string fieldValue)
        {
            if (fieldValue == null) return fieldValue;

            ChoFieldValueTrimOption fieldValueTrimOption = ChoFieldValueTrimOption.Trim;

            if (config.FieldValueTrimOption == null)
            {
                //if (fieldType == typeof(string))
                //    fieldValueTrimOption = ChoFieldValueTrimOption.None;
            }
            else
                fieldValueTrimOption = config.FieldValueTrimOption.Value;

            switch (fieldValueTrimOption)
            {
                case ChoFieldValueTrimOption.Trim:
                    fieldValue = fieldValue.Trim();
                    break;
                case ChoFieldValueTrimOption.TrimStart:
                    fieldValue = fieldValue.TrimStart();
                    break;
                case ChoFieldValueTrimOption.TrimEnd:
                    fieldValue = fieldValue.TrimEnd();
                    break;
            }

            if (config.Size != null)
            {
                if (fieldValue.Length > config.Size.Value)
                {
                    if (!config.Truncate)
                        throw new ChoHL7Exception("Incorrect field value length found for '{0}' member [Expected: {1}, Actual: {2}].".FormatString(config.FieldName, config.Size.Value, fieldValue.Length));
                    else
                        fieldValue = fieldValue.Substring(0, config.Size.Value);
                }
            }

            //char startChar;
            //char endChar;

            //quotes are quoted and doubled (excel) i.e. 15" -> field1,"15""",field3
            //if (fieldValue.Contains(Configuration.DoubleQuoteChar))
            //    fieldValue = fieldValue.Replace(Configuration.DoubleQuoteChar, Configuration.QuoteChar.ToString());
            //if (fieldValue.Contains(Configuration.BackslashQuote))
            //    fieldValue = fieldValue.Replace(Configuration.BackslashQuote, Configuration.QuoteChar.ToString());

            //if (fieldValue.Length >= 2)
            //{
            //    startChar = fieldValue[0];
            //    endChar = fieldValue[fieldValue.Length - 1];

            //    if (config.QuoteField != null && config.QuoteField.Value && startChar == Configuration.QuoteChar && endChar == Configuration.QuoteChar)
            //        return fieldValue.Substring(1, fieldValue.Length - 2);
            //    else if (startChar == Configuration.QuoteChar && endChar == Configuration.QuoteChar &&
            //        (fieldValue.Contains(Configuration.Delimiter)
            //        || fieldValue.Contains(Configuration.EOLDelimiter)))
            //        return fieldValue.Substring(1, fieldValue.Length - 2);

            //}
            return fieldValue;
        }

        private void ValidateLine(long lineNo, string[] fieldValues)
        {
            //int maxPos = Configuration.MaxFieldPosition;

            //if (Configuration.ColumnCountStrict)
            //{
            //    if (fieldValues.Length != maxPos)
            //        throw new ChoReaderException("Mismatched number of fields found at {0} line. [Expected: {1}, Found: {2}].".FormatString(
            //            lineNo, maxPos, fieldValues.Length));
            //}

            //ChoCSVRecordFieldAttribute attr = null;
            //foreach (Tuple<MemberInfo, ChoOrderedAttribute> member in _members)
            //{
            //    if (attr.Position > fields.Length)
            //        throw new ApplicationException("Record Member '{0}' has incorrect Position specified.".FormatString(ChoType.GetMemberName(member.Item1)));
            //}
        }

        #region Event Raisers

        private bool RaiseBeginLoad(object state)
        {
            if (_callbackRecord != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => _callbackRecord.BeginLoad(state), true);
            }
            else if (Reader != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => Reader.RaiseBeginLoad(state), true);
            }
            return true;
        }

        private void RaiseEndLoad(object state)
        {
            if (_callbackRecord != null)
            {
                ChoActionEx.RunWithIgnoreError(() => _callbackRecord.EndLoad(state));
            }
            else if (Reader != null)
            {
                ChoActionEx.RunWithIgnoreError(() => Reader.RaiseEndLoad(state));
            }
        }

        private bool RaiseBeforeRecordLoad(object target, ref Tuple<long, string> pair)
        {
            if (_callbackRecord != null)
            {
                long index = pair.Item1;
                object state = pair.Item2;
                bool retValue = ChoFuncEx.RunWithIgnoreError(() => _callbackRecord.BeforeRecordLoad(target, index, ref state), true);

                if (retValue)
                    pair = new Tuple<long, string>(index, state as string);

                return retValue;
            }
            else if (Reader != null)
            {
                long index = pair.Item1;
                object state = pair.Item2;
                bool retValue = ChoFuncEx.RunWithIgnoreError(() => Reader.RaiseBeforeRecordLoad(target, index, ref state), true);

                if (retValue)
                    pair = new Tuple<long, string>(index, state as string);

                return retValue;
            }
            return true;
        }

        private bool RaiseAfterRecordLoad(object target, Tuple<long, string> pair, ref bool skip)
        {
            bool ret = true;
            bool sp = false;
            if (_callbackRecord != null)
            {
                ret = ChoFuncEx.RunWithIgnoreError(() => _callbackRecord.AfterRecordLoad(target, pair.Item1, pair.Item2, ref sp), true);
            }
            else if (Reader != null)
            {
                ret = ChoFuncEx.RunWithIgnoreError(() => Reader.RaiseAfterRecordLoad(target, pair.Item1, pair.Item2, ref sp), true);
            }
            skip = sp;
            return ret;
        }

        private bool RaiseRecordLoadError(object target, Tuple<long, string> pair, Exception ex)
        {
            if (_callbackRecord != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => _callbackRecord.RecordLoadError(target, pair.Item1, pair.Item2, ex), false);
            }
            else if (Reader != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => Reader.RaiseRecordLoadError(target, pair.Item1, pair.Item2, ex), false);
            }
            return true;
        }

        private bool RaiseBeforeRecordFieldLoad(object target, long index, string propName, ref object value)
        {
            if (_callbackRecord != null)
            {
                object state = value;
                bool retValue = ChoFuncEx.RunWithIgnoreError(() => _callbackRecord.BeforeRecordFieldLoad(target, index, propName, ref state), true);

                if (retValue)
                    value = state;

                return retValue;
            }
            else if (Reader != null)
            {
                object state = value;
                bool retValue = ChoFuncEx.RunWithIgnoreError(() => Reader.RaiseBeforeRecordFieldLoad(target, index, propName, ref state), true);

                if (retValue)
                    value = state;

                return retValue;
            }
            return true;
        }

        private bool RaiseAfterRecordFieldLoad(object target, long index, string propName, object value)
        {
            if (_callbackRecord != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => _callbackRecord.AfterRecordFieldLoad(target, index, propName, value), true);
            }
            else if (Reader != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => Reader.RaiseAfterRecordFieldLoad(target, index, propName, value), true);
            }
            return true;
        }

        private bool RaiseRecordFieldLoadError(object target, long index, string propName, object value, Exception ex)
        {
            if (_callbackRecord != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => _callbackRecord.RecordFieldLoadError(target, index, propName, value, ex), true);
            }
            else if (Reader != null)
            {
                return ChoFuncEx.RunWithIgnoreError(() => Reader.RaiseRecordFieldLoadError(target, index, propName, value, ex), true);
            }
            return true;
        }

        #endregion Event Raisers
    }
}
