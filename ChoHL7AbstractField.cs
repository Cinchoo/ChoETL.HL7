using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public abstract class ChoHL7AbstractField
    {
        public ChoHL7Configuration Configuration
        {
            get;
            private set;
        }

        public ChoHL7Field Field
        {
            get;
            private set;
        }

        public ChoHL7AbstractField(string value, ChoHL7Configuration config)
        {
            Configuration = config;
            if (value != null)
                Field = ChoHL7Field.Parse(value, config);
        }

        public ChoHL7AbstractField(ChoHL7Field field)
        {
            Field = field;
            Configuration = field != null ? field.Configuration : null;
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
                try
                {
                    propValueText = propValue.ToNString();
                }
                catch (Exception ex)
                {
                    throw new ChoHL7Exception("Failed to validate '{0}' member.".FormatString(pi.FullName()), ex);
                }

                pi.CheckRequired(propValue);
                if (Field != null && Field.Configuration != null && !Field.Configuration.DisableEnumChecks)
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

        protected bool HasValueAt(int index)
        {
            if (Field != null && index < Field.Components.Count)
                return true;
            else
                return false;
        }

        protected T GetDefaultValue<T>()
        {
            return ChoHL7Message.CreateElementInstance<T>(Field.Configuration, Field.Value, Field.Configuration);
        }

        protected T GetDefaultOrValueAt<T>(int index)
        {
            if (HasValueAt(index))
                return GetValueAt<T>(index);
            else
                return GetDefaultValue<T>();
        }

        protected T GetValueAt<T>(int index)
        {
            if (Field != null && index < Field.Components.Count)
            {
                if (typeof(ChoHL7AbstractField).IsAssignableFrom(typeof(T)))
                    return ChoHL7Message.CreateElementInstance<T>(Field.Configuration, Field.Components[index].ToNString(), Field.Configuration);
                else
                    return Field.Components[index].ToNString().CastTo<T>();
            }
            else
            {
                return default(T);
            }
        }

        protected void AppendToMsg(StringBuilder msg, object obj)
        {
            string txt = obj.ToNString();
            if (txt.IsNullOrEmpty())
                return;

            if (msg.Length == 0)
                msg.Append(txt);
            else
                msg.AppendFormat("{0}{1}", Field.Configuration.ComponentSeparator, txt);
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            foreach (PropertyInfo pi in GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                AppendToMsg(msg, ChoType.GetMemberValue(this, pi).ToNString());
            }
            return msg.ToString();
        }

    }
}
