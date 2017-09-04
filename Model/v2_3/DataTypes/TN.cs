using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("TN: Telephone Number")]
    public class TN : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public TN(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public TN(ChoHL7Field field) : base(field)
        {
            Value = field.ToString();
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(TN d)
        {
            return d.Value;
        }
        public static implicit operator TN(string d)
        {
            return new TN(d);
        }
    }
}
