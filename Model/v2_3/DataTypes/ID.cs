using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// ID: Coded values for HL7 tables
    /// </summary>
    [Description("ID: Coded values for HL7 tables")]
    public class ID : ChoHL7AbstractField
    {
        public string Value
        {
            get;
            private set;
        }

        public ID(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            Value = value;
        }

        public ID(ChoHL7Field field) : base(field)
        {
            Value = field.Value;
        }

        public override string ToString()
        {
            return Value.ToNString();
        }
        public static implicit operator string(ID d)
        {
            return d.Value;
        }
        public static implicit operator ID(string d)
        {
            return new ID(d);
        }
    }
}
