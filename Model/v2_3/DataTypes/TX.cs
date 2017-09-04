using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("TX: Text Data")]
    public class TX : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public TX(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public TX(ChoHL7Field field) : base(field)
        {
            Value = field.ToString();
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(TX d)
        {
            return d.Value;
        }
        public static implicit operator TX(string d)
        {
            return new TX(d);
        }
    }
}
