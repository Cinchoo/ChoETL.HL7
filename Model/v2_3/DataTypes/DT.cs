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
        private string DateFormat = "yyyyMMdd";

        public DateTime Value
        {
            get;
            private set;
        }

        public DT(string value, ChoHL7Configuration config) : base((string)null, config)
        {
            if (config != null && !config.DateFormat.IsNullOrWhiteSpace())
                DateFormat = config.DateFormat;

            Value = value.IsNullOrEmpty() ? DateTime.Today : DateTime.ParseExact(value, DateFormat, null);
        }

        public DT(DateTime? value = null) : base((string)null, null)
        {
            Value = value == null ? DateTime.Today : value.Value;
        }

        public DT(ChoHL7Field field) : base(field)
        {
            if (Configuration != null && !Configuration.DateFormat.IsNullOrWhiteSpace())
                DateFormat = Configuration.DateFormat;
        }

        public override string ToString()
        {
            return Value.ToString(DateFormat);
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
