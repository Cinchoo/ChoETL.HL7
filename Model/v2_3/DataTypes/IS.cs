using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// IS: Coded value for user-defined tables
    /// </summary>
    [Description("IS: Coded value for user-defined tables")]
    public class IS : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public IS(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public IS(ChoHL7Field field) : base(field)
        {
            Value = field.ToString();
        }

        public override string ToString()
        {
            return Value.ToNString();
        }

        public static implicit operator string(IS d)
        {
            return d.Value;
        }
        public static implicit operator IS(string d)
        {
            return new IS(d);
        }


        /*
        public int? Value
        {
            get;
            private set;
        }

        public IS(int value) : base(null)
        {
            Value = value;
        }
        public IS(string value) : base(null)
        {
            if (!value.IsNullOrEmpty())
                Value = Int32.Parse(value);
        }

        public IS(ChoHL7Field field) : base(field)
        {
            if (!field.ToString().IsNullOrEmpty())
                Value = Int32.Parse(field.ToString());
        }

        public override string ToString()
        {
            return Value.ToString();
        }
        public static implicit operator int(IS d)
        {
            return d.Value == null ? 0 : d.Value.Value;
        }
        public static implicit operator IS(int d)
        {
            return new IS(d);
        } */
    }
}
