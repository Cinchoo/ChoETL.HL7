using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public class ChoHL7Segment : IChoHL7Object
    {
        public string Type
        {
            get;
            private set;
        }

        private readonly List<ChoHL7Field[]> _fields = new List<ChoHL7Field[]>();
        protected List<ChoHL7Field[]> Fields
        {
            get { return _fields; }
        }

        public ChoHL7Configuration Configuration
        {
            get;
            set;
        }

        public ChoHL7Segment()
        {
            Type = GetType().Name;
        }

        public ChoHL7Segment(string type, ChoHL7Segment segment = null)
        {
            ChoGuard.ArgumentNotNullOrEmpty(type, nameof(type));
            Type = type;

            if (segment != null && segment._fields != null)
                _fields = new List<ChoHL7Field[]>(segment._fields);
        }

        public override string ToString()
        {
            if (Fields.Count > 0)
            {
                StringBuilder msg = new StringBuilder(Type);

                foreach (var sc in Fields)
                {
                    bool first = true;
                    msg.Append(ChoHL7Configuration.Instance.FieldSeparator);
                    foreach (var sc1 in sc)
                    {
                        if (first)
                        {
                            msg.Append(sc1.ToString());
                            first = false;
                        }
                        else
                            msg.Append("{0}{1}".FormatString(ChoHL7Configuration.Instance.RepeatSeparator, sc1.ToString()));
                    }
                }

                return msg.ToString();
            }
            else
                return String.Empty;
        }

        public virtual void Validate()
        {
            string propName = null;
            object propValue = null;
            string propValueText = null;
            var results = new List<ValidationResult>();
            foreach (PropertyInfo pi in ChoType.GetProperties(GetType()))
            {
                propName = pi.Name;

                results.Clear();
                try
                {
                    propValue = ChoType.GetPropertyValue(this, pi);
                }
                catch (Exception ex)
                {
                    throw new ChoHL7Exception("Failed to validate '{0}' member.".FormatString(pi.FullName()), ex);
                }

                if (propValue is Array)
                {
                    Array arr = (Array)propValue;
                    if (arr.Length == 0 && ChoTypeDescriptor.GetPropetyAttributes<RequiredAttribute>(ChoTypeDescriptor.GetProperty<RequiredAttribute>(GetType(), pi.Name)).Any())
                        throw new ChoHL7Exception("'{0}' member is required.".FormatString(pi.FullName()));

                    var maxCountAttr = ChoTypeDescriptor.GetPropetyAttributes<ChoHL7MaxCountAttribute>(ChoTypeDescriptor.GetProperty<ChoHL7MaxCountAttribute>(GetType(), pi.Name)).FirstOrDefault();
                    if (maxCountAttr != null)
                    {
                        if (arr.Length > maxCountAttr.Count)
                            throw new ChoHL7Exception("Incorrect number of elements found in '{0}' member. [Expected: {1}, Found: {2}]".FormatString(pi.FullName(), maxCountAttr.Count, arr.Length));
                    }

                    foreach (ChoHL7AbstractField arrValue in arr)
                    {
                        try
                        {
                            propValueText = arrValue.ToNString();
                        }
                        catch (Exception ex)
                        {
                            throw new ChoHL7Exception("Failed to validate '{0}' member.".FormatString(pi.FullName()), ex);
                        }
                        pi.CheckRequired(propValueText);
                        if (Configuration != null && !Configuration.DisableEnumChecks)
                            pi.CheckForValidEnumValue(propValueText);

                        var context = new ValidationContext(propValueText, null, null);
                        context.MemberName = pi.Name;

                        Validator.TryValidateValue(propValueText, context, results, ChoTypeDescriptor.GetPropetyAttributes<ValidationAttribute>(ChoTypeDescriptor.GetProperty<ValidationAttribute>(GetType(), pi.Name)));
                        if (results.Count > 0)
                        {
                            throw new ChoHL7Exception("Failed to validate '{0}' member. {2}{1}".FormatString(pi.FullName(), ChoHL7Helper.ToString(results), Environment.NewLine));
                        }

                        try
                        {
                            if (arrValue is ChoHL7AbstractField)
                            {
                                ((ChoHL7AbstractField)arrValue).Validate();
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new ChoHL7Exception("Failed to validate '{0}' member.".FormatString(pi.FullName()), ex);
                        }
                    }
                }
                else
                {
                    try
                    {
                        propValueText = propValue.ToNString();
                    }
                    catch (Exception ex)
                    {
                        throw new ChoHL7Exception("Failed to validate '{0}' member.".FormatString(pi.FullName()), ex);
                    }

                    pi.CheckRequired(propValueText);
                    if (Configuration != null && !Configuration.DisableEnumChecks)
                        pi.CheckForValidEnumValue(propValueText);

                    var context = new ValidationContext(propValueText, null, null);
                    context.MemberName = pi.Name;

                    Validator.TryValidateValue(propValueText, context, results, ChoTypeDescriptor.GetPropetyAttributes<ValidationAttribute>(ChoTypeDescriptor.GetProperty<ValidationAttribute>(GetType(), pi.Name)));
                    if (results.Count > 0)
                    {
                        throw new ChoHL7Exception("Failed to validate '{0}' member. {2}{1}".FormatString(pi.FullName(), ChoHL7Helper.ToString(results), Environment.NewLine));
                    }

                    try
                    {
                        if (propValue is ChoHL7AbstractField)
                        {
                            ((ChoHL7AbstractField)propValue).Validate();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ChoHL7Exception("Failed to validate '{0}' member.".FormatString(pi.FullName()), ex);
                    }
                }
            }
        }

        internal static ChoHL7Segment Parse(string line, ChoHL7Configuration configuration = null)
        {
            configuration = configuration ?? ChoHL7Configuration.Instance;
            if (line.IsNullOrWhiteSpace())
                throw new ChoHL7Exception("Empty line is found.");

            string[] fields = line.Split(configuration.FieldSeparator);
            if (fields.Length == 0)
                throw new ChoHL7Exception("No Segment type found.");

            string segmentType = fields[0];
            if (segmentType.IsNullOrWhiteSpace() || segmentType.Length != 3)
                throw new ChoHL7Exception("Invalid '{0}' Segment type found.".FormatString(segmentType));

            int index = 0;
            ChoHL7Segment rec = CreateInstance(configuration, segmentType); //new ChoHL7Segment(segmentType);
            rec.Configuration = configuration;

            foreach (var field in fields.Skip(1))
            {
                if (segmentType == "MSH" && (index == 0/* || index == 7*/))
                {
                    //if (index == 0)
                    //    rec.Fields.Add(new ChoHL7Field[] { new ChoHL7Field(configuration.FieldSeparator.ToString()) });

                    rec.Fields.Add(new ChoHL7Field[] { new ChoHL7Field(field) });
                }
                else
                {
                    List<ChoHL7Field> fieldRepeats = new List<ChoHL7Field>();
                    foreach (var fieldRepeat in field.Split(configuration.RepeatSeparator))
                        fieldRepeats.Add(ChoHL7Field.Parse(fieldRepeat, configuration));

                    rec.Fields.Add(fieldRepeats.ToArray());
                }
                index++;
            }

            rec.Validate();
            return rec;
        }

        private static ChoHL7Segment CreateInstance(ChoHL7Configuration configuration, string segmentType)
        {
            ChoHL7Version version = configuration.Version;
            ChoHL7Segment msg = null;

            string segmentTypeName = "ChoETL.HL7.Model.{0}.{1}".FormatString(version.ToString(), segmentType);
            if (!ChoHL7MessageCache.Instance.HL7SegmentDict.ContainsKey(segmentTypeName))
                throw new ChoHL7Exception("Can't find '{0}' HL7 Segment type.".FormatString(segmentTypeName));

            msg = Activator.CreateInstance(ChoHL7MessageCache.Instance.HL7SegmentDict[segmentTypeName]) as ChoHL7Segment;
            return msg;
        }

        internal static bool TryParse(string line, ChoHL7Configuration configuration, out ChoHL7Segment rec, out string errMsg)
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

        protected T[] GetValuesAt<T>(int index)
        {
            if (index < Fields.Count)
            {
                if (typeof(ChoHL7AbstractField).IsAssignableFrom(typeof(T)))
                {
                    List<T> list = new List<T>();
                    foreach (var field in Fields[index])
                        list.Add(ChoHL7Message.CreateElementInstance<T>(Configuration, field));
                    return list.ToArray();
                }
                else
                    return new T[] { };
            }
            else
                return new T[] { };
        }

        protected T GetValueAt<T>(int index)
        {
            if (index < Fields.Count)
            {
                if (typeof(ChoHL7AbstractField).IsAssignableFrom(typeof(T)))
                    return ChoHL7Message.CreateElementInstance<T>(Configuration, Fields[index].FirstOrDefault());
                else
                    return Fields[index].FirstOrDefault().ToNString().CastTo<T>();
            }
            else
                return default(T);
        }
    }
}
