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
    /// APR: Appointment Preferences
    /// </summary>
    public class APR : ChoHL7Segment
    {
        [Description("Time Selection Criteria")]
        [MaxLength(80)]
        public SCV[] TimeSelectionCriteria
        {
            get { return GetValuesAt<SCV>(0); }
        }
        [Description("Resource Selection Criteria")]
        [MaxLength(80)]
        public SCV[] ResourceSelectionCriteria
        {
            get { return GetValuesAt<SCV>(1); }
        }
        [Description("Location Selection Criteria")]
        [MaxLength(80)]
        public SCV[] LocationSelectionCriteria
        {
            get { return GetValuesAt<SCV>(2); }
        }
        [Description("Slot Spacing Criteria")]
        [MaxLength(5)]
        public NM SlotSpacingCriteria
        {
            get { return GetValueAt<NM>(3); }
        }
        [Description("Filler Override Criteria")]
        [MaxLength(80)]
        public SCV[] FillerOverrideCriteria
        {
            get { return GetValuesAt<SCV>(4); }
        }
    }
}
