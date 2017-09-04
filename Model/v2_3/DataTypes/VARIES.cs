using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("VARIES: Variable Datatype")]
    public class VARIES : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public VARIES(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public VARIES(ChoHL7Field field) : base(field)
        {
            Value = field.ToString();
        }

        public override string ToString()
        {
            return Value;
        }

        public static implicit operator string(VARIES d)
        {
            return d.Value;
        }
        public static implicit operator VARIES(string d)
        {
            return new VARIES(d);
        }
    }
}
