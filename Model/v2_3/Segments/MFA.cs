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
    /// MFA: Master file acknowledgment segment
    /// </summary>
    public class MFA : ChoHL7Segment
    {
        [Description("Record-Level Event Code")]
        [Required]
        [MaxLength(3)]
        public ID RecordLevelEventCode
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("MFN Control ID")]
        [MaxLength(20)]
        public ST MFNControlID
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Event Completion Date/Time")]
        [MaxLength(26)]
        public TS EventCompletionDateTime
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("Error Return Code and/or Text")]
        [Required]
        [MaxLength(60)]
        public CE ErrorReturnCodeText
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(60)]
        public CE[] PrimaryKeyValue
        {
            get { return GetValuesAt<CE>(4); }
        }
    }
}
