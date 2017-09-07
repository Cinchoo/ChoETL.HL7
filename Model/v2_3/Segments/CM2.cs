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
    /// CM2: Clinical Study Schedule Master
    /// </summary>
    public class CM2 : ChoHL7Segment
    {
        [Description("CM2 - Set ID")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Scheduled Time Point")]
        [Required]
        [MaxLength(60)]
        public CE ScheduledTimePoint
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Description of Time Point")]
        [Required]
        [MaxLength(300)]
        public ST DescriptionofTimePoint
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Events Scheduled This Time Point")]
        [Required]
        [MaxLength(60)]
        public CE[] EventsScheduledThisTimePoint
        {
            get { return GetValuesAt<CE>(3); }
        }
    }
}
