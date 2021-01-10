using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// TS: Time Stamp
    /// </summary>
    [Description("TS: Time Stamp")]
    public class TS : ChoHL7AbstractField
    {
        public ST TimeOfEvent
        {
            get;
            private set;
        }

        public TS(string value, ChoHL7Configuration config = null) : base((string)null, config)
        {
            TimeOfEvent = value.IsNullOrEmpty() ? new ST(DateTime.Now.ToString("yyyyMMddHHmmss")) : new ST(DateTime.ParseExact(value, "yyyyMMddHHmmss", null).ToString("yyyyMMddHHmmss"));
        }

        public TS(DateTime? ts = null) : base((string)null, null)
        {
            TimeOfEvent = ts == null ? new ST(DateTime.Now.ToString("yyyyMMddHHmmss")) : new ST(ts.Value.ToString("yyyyMMddHHmmss"));
        }

        public TS(ChoHL7Field field) : base(field)
        {
            TimeOfEvent = new ST(field.ToString());
        }

        public override string ToString()
        {
            return TimeOfEvent.ToString();
        }

        public static implicit operator DateTime(TS d)
        {
            return DateTime.ParseExact(d.TimeOfEvent.ToString(), "yyyyMMddHHmmss", null);
        }

        public static implicit operator TS(DateTime d)
        {
            return new TS(d);
        }
    }
}
