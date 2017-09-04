using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// SI: Sequence ID
    /// </summary>
    [Description("SI: Sequence ID")]
    public class SI : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public SI(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public SI(ChoHL7Field field) : base(field)
        {
            Value = field.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
        public static implicit operator string(SI d)
        {
            return d.Value;
        }
        public static implicit operator SI(string d)
        {
            return new SI(d);
        }
    }
}
