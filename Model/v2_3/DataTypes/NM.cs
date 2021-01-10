using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// NM: Numeric
    /// </summary>
    [Description("NM: Numeric")]
    public class NM : ChoHL7AbstractField
    {
        private string _value;
        public string Value
        {
            get { return _value; }
            private set
            {
                if (!value.IsNullOrEmpty() && !value.IsNumber())
                    throw new ChoHL7Exception("Value is not numeric.");

                _value = value;
            }
        }

        public NM(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public NM(ChoHL7Field field) : base(field)
        {
            Value = field.ToString();
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(NM d)
        {
            return d.Value;
        }

        public static implicit operator NM(string d)
        {
            return new NM(d);
        }
    }
}
