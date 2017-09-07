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
    /// CM1: Clinical Study Phase Master
    /// </summary>
    public class CM1 : ChoHL7Segment
    {
        [Description("CM1 - Set ID")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Study Phase Identifier")]
        [Required]
        [MaxLength(60)]
        public CE StudyPhaseIdentifier
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Description of Study Phase")]
        [Required]
        [MaxLength(300)]
        public ST DescriptionofStudyPhase
        {
            get { return GetValueAt<ST>(2); }
        }
    }
}
