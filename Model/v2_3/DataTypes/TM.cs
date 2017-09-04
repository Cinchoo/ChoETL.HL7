using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("TM: Time")]
    public class TM : ChoHL7AbstractField
    {
        public DateTime Value
        {
            get;
            private set;
        }

        public TM(string value, ChoHL7Configuration config) : base((string)null, null)
        {
            Value = value.IsNullOrEmpty() ? DateTime.Now : DateTime.ParseExact(value, "HHmmss", null);
        }

        public TM(DateTime? value = null) : base((string)null, null)
        {
            Value = value == null ? DateTime.Now : value.Value;
        }

        public TM(ChoHL7Field field) : base(field)
        {
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator DateTime(TM d)
        {
            return d.Value;
        }

        public static implicit operator TM(DateTime d)
        {
            return new TM(d);
        }
    }
}
