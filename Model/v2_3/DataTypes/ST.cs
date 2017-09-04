using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("ST: String Data")]
    public class ST : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public ST(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public ST(ChoHL7Field field) : base(field)
        {
            Value = field.ToString();
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(ST d)
        {
            return d.Value;
        }
        public static implicit operator ST(string d)
        {
            return new ST(d);
        }
    }
}
