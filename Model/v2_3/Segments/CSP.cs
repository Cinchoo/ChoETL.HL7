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
    /// CSP: Clinical Study Phase
    /// </summary>
    public class CSP : ChoHL7Segment
    {
        [Description("Study Phase Identifier")]
        [Required]
        [MaxLength(60)]
        public CE StudyPhaseIdentifier
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Date/time Study Phase Began")]
        [Required]
        [MaxLength(26)]
        public TS DatetimeStudyPhaseBegan
        {
            get { return GetValueAt<TS>(1); }
        }
        [Description("Date/time Study Phase Ended")]
        [MaxLength(26)]
        public TS DatetimeStudyPhaseEnded
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("Study Phase Evaluability")]
        [MaxLength(60)]
        public CE StudyPhaseEvaluability
        {
            get { return GetValueAt<CE>(3); }
        }
    }
}
