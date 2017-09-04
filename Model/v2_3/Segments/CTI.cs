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
    /// CTI: Clinical Trial Identification
    /// </summary>
    public class CTI : ChoHL7Segment
    {
        [Description("Sponsor Study ID")]
        [Required]
        [MaxLength(60)]
        public EI SponsorStudyID
        {
            get { return GetValueAt<EI>(0); }
        }
        [Description("Study Phase Identifier")]
        [MaxLength(60)]
        public CE StudyPhaseIdentifier
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Study Scheduled Time Point")]
        [MaxLength(60)]
        public CE StudyScheduledTimePoint
        {
            get { return GetValueAt<CE>(2); }
        }
    }
}
