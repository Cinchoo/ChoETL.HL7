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
    /// MSA: Message Acknowledgment
    /// </summary>
    public class MSA : ChoHL7Segment
    {
        [Description("Acknowledgment Code")]
        [Required]
        [MaxLength(2)]
        public ID AcknowledgmentCode
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Message Control ID")]
        [Required]
        [MaxLength(20)]
        public ST MessageControlID
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Text Message")]
        [MaxLength(80)]
        public ST TextMessage
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Expected Sequence Number")]
        [MaxLength(15)]
        public NM ExpectedSequenceNumber
        {
            get { return GetValueAt<NM>(3); }
        }
        [Description("Delayed Acknowledgment Type")]
        [MaxLength(1)]
        public ID DelayedAcknowledgmentType
        {
            get { return GetValueAt<ID>(4); }
        }
        [Description("Error Condition")]
        [MaxLength(100)]
        public CE ErrorCondition
        {
            get { return GetValueAt<CE>(5); }
        }
    }
}
