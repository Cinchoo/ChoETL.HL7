using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// EVN: Event type
    /// </summary>
    public class EVN : ChoHL7Segment
    {
        [Description("Event Type Code")]
        [Required]
        [MaxLength(3)]
        public ID EventTypeCode
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Recorded Date/Time")]
        [MaxLength(26)]
        public TS RecordedDateTime
        {
            get { return GetValueAt<TS>(1); }
        }
        [Description("Date/Time Planned Event")]
        [MaxLength(26)]
        public TS PlannedEventDateTime
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("Event Reason Code")]
        [MaxLength(3)]
        public ID EventReasonCode
        {
            get { return GetValueAt<ID>(3); }
        }
        [Description("Operator ID")]
        [MaxLength(60)]
        public CN OperatorID
        {
            get { return GetValueAt<CN>(4); }
        }
        [Description("Event Occurred")]
        [MaxLength(26)]
        public TS EventOccurred
        {
            get { return GetValueAt<TS>(5); }
        }
    }
}
