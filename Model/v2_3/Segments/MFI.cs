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
    /// MFI: Master file identification segment
    /// </summary>
    public class MFI : ChoHL7Segment
    {
        [Description("Master File Identifier")]
        [Required]
        [MaxLength(60)]
        public CE MasterFileIdentifier
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Master File Application Identifier")]
        [MaxLength(180)]
        public HD MasterFileApplicationIdentifier
        {
            get { return GetValueAt<HD>(1); }
        }
        [Description("File-Level Event Code")]
        [MaxLength(3)]
        [Required]
        public ID FileLevelEventCode
        {
            get { return GetValueAt<ID>(2); }
        }
        [Description("Entered Date/Time")]
        [MaxLength(26)]
        public TS EnteredDateTime
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Effective Date/Time")]
        [MaxLength(26)]
        public TS EffectiveDateTime
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Response Level Code")]
        [Required]
        [MaxLength(2)]
        public ID ResponseLevelCode
        {
            get { return GetValueAt<ID>(5); }
        }
    }
}
