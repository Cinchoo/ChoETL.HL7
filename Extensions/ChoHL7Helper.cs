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
    public static class ChoHL7Helper
    {
        public static void CheckForValidEnumValue(this PropertyInfo pi, string propValueText)
        {
            if (propValueText.IsNullOrEmpty())
                return;

            ChoHL7EnumTypeAttribute enumAttribute = ChoTypeDescriptor.GetPropetyAttributes<ChoHL7EnumTypeAttribute>(ChoTypeDescriptor.GetProperty(pi.DeclaringType, pi.Name)).FirstOrDefault();
            if (enumAttribute != null)
            {
                Type enumType = enumAttribute.EnumType;
                if (!enumType.IsEnum)
                    throw new ChoHL7Exception("'{0}' is not an enum type defined in '{1}' member.".FormatString(enumType.FullName, pi.FullName()));

                if (!propValueText.IsNullOrWhiteSpace())
                {
                    string[] enumTxts = GetEnumValues(enumType);
                    string[] splEnumTxts = GetSplEnumValues(enumType);
                    if (enumTxts.Length > 0 && !enumTxts.Contains(propValueText, StringComparer.CurrentCultureIgnoreCase))
                    {
                        if (splEnumTxts.Length > 0)
                        {
                            bool found = false;
                            foreach (var splEnumTxt in splEnumTxts)
                            {
                                if (propValueText.StartsWith(splEnumTxt))
                                {
                                    found = true;
                                    break;
                                }
                            }
                            if (!found)
                                throw new ChoHL7Exception("Incorrect '{0}' value found for '{1}' member.".FormatString(propValueText, pi.FullName()));
                        }
                        else
                            //char enumChar = propValueText[0];
                            //if (!Enum.IsDefined(enumType, (int)enumChar))
                            throw new ChoHL7Exception("Incorrect '{0}' value found for '{1}' member.".FormatString(propValueText, pi.FullName()));
                    }
                }
            }
        }

        public static void CheckRequired(this PropertyInfo pi, object propValue)
        {
            if (propValue is string && ((string)propValue).IsNullOrEmpty() && ChoTypeDescriptor.GetPropetyAttributes<RequiredAttribute>(ChoTypeDescriptor.GetProperty<RequiredAttribute>(pi.DeclaringType, pi.Name)).Any())
                throw new ChoHL7Exception("'{0}' member is required.".FormatString(pi.FullName()));
            else if (propValue == null && ChoTypeDescriptor.GetPropetyAttributes<RequiredAttribute>(ChoTypeDescriptor.GetProperty<RequiredAttribute>(pi.DeclaringType, pi.Name)).Any())
                throw new ChoHL7Exception("'{0}' member is required.".FormatString(pi.FullName()));
        }

        public static string ToString(IEnumerable<ValidationResult> results)
        {
            StringBuilder msg = new StringBuilder();
            foreach (var validationResult in results)
            {
                msg.AppendLine(validationResult.ErrorMessage);

                if (validationResult is CompositeValidationResult)
                    msg.AppendLine(ToString(((CompositeValidationResult)validationResult).Results).Indent());
            }

            return msg.ToString();
        }

        private static readonly Dictionary<Type, string[]> _enumCache = new Dictionary<Type, string[]>();
        private static readonly Dictionary<Type, string[]> _splEnumCache = new Dictionary<Type, string[]>();
        private static readonly object _padLock = new object();

        private static string[] GetSplEnumValues(Type type)
        {
            if (_splEnumCache.ContainsKey(type))
                return _splEnumCache[type];

            lock (_padLock)
            {
                if (_splEnumCache.ContainsKey(type))
                    return _splEnumCache[type];

                GetEnumValues(type);

                return _splEnumCache[type];
            }
        }

        private static string[] GetEnumValues(Type type)
        {
            if (_enumCache.ContainsKey(type))
                return _enumCache[type];

            lock (_padLock)
            {
                if (_enumCache.ContainsKey(type))
                    return _enumCache[type];

                var descs = new List<string>();
                var splDescs = new List<string>();
                var names = Enum.GetNames(type);
                var values = Enum.GetValues(type);
                foreach (var value in values)
                {
                    descs.Add(Convert.ToChar(((int)value)).ToString());
                }
                foreach (var name in names)
                {
                    var field = type.GetField(name);
                    var fds = field.GetCustomAttributes(typeof(DescriptionAttribute), true);
                    foreach (DescriptionAttribute fd in fds)
                    {
                        foreach (var v in fd.Description.SplitNTrim())
                        {
                            if (v.Contains("."))
                                splDescs.Add(v.Replace(".", String.Empty));
                            else
                                descs.Add(v);
                        }
                    }
                }
                _enumCache.Add(type, descs.ToArray());
                _splEnumCache.Add(type, splDescs.ToArray());

                return _enumCache[type];
            }
        }
    }
}
