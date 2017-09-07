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
    /// CSS: Clinical Study Data Schedule
    /// </summary>
    public class CSS : ChoHL7Segment
    {
        [Description("Study Scheduled Time Point")]
        [MaxLength(60)]
        public CE StudyScheduledTimePoint
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Study Scheduled Patient Time Point")]
        [MaxLength(26)]
        public TS StudyScheduledPatientTimePoint
        {
            get { return GetValueAt<TS>(1); }
        }
        [Description("Study Quality Control Codes")]
        [MaxLength(60)]
        public CE StudyQualityControlCodes
        {
            get { return GetValueAt<CE>(2); }
        }
    }
}
