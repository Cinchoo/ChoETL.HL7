using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("FT: Formatted Text Data")]
    public class FT : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public FT(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public FT(ChoHL7Field field) : base(field)
        {
            Value = field.ToString();
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(FT d)
        {
            return d.Value;
        }
        public static implicit operator FT(string d)
        {
            return new FT(d);
        }
    }
}
