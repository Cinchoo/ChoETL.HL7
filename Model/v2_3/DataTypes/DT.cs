using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// DT: Date
    /// </summary>
    [Description("DT: Date")]
    public class DT : ChoHL7AbstractField
    {
        public DateTime Value
        {
            get;
            private set;
        }

        public DT(string value, ChoHL7Configuration config) : base((string)null, null)
        {
            Value = value.IsNullOrEmpty() ? DateTime.Today : DateTime.ParseExact(value, "yyyyMMddHHmmss", null);
        }

        public DT(DateTime? value = null) : base((string)null, null)
        {
            Value = value == null ? DateTime.Today : value.Value;
        }

        public DT(ChoHL7Field field) : base(field)
        {
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator DateTime(DT d)
        {
            return d.Value;
        }

        public static implicit operator DT(DateTime d)
        {
            return new DT(d);
        }
    }
}
