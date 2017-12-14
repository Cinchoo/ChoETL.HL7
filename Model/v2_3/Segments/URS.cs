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
    /// URS: Unsolicited selection segment
    /// </summary>
    public class URS : ChoHL7Segment
    {
        [Description("R/U What Subject Definition")]
        [MaxLength(20)]
        [Required]
        public ST[] RUWhatSubjectDefinition
        {
            get { return GetValuesAt<ST>(0); }
        }
        [Description("R/U When Data Start Date/Time")]
        [MaxLength(26)]
        public TS RUWhenDataStartDateTime
        {
            get { return GetValueAt<TS>(1); }
        }
        [Description("R/U When Data End Date/Time")]
        [MaxLength(26)]
        public TS RUWhenDataEndDateTime
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("R/U What User Qualifier")]
        [MaxLength(20)]
        public ST[] RUWhatUserQualifier
        {
            get { return GetValuesAt<ST>(3); }
        }
        [Description("R/U Other Results Subject Definition")]
        [MaxLength(20)]
        public CE RUOtherResultsSubjectDefinition
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("R/U Display/Print Locations")]
        [MaxLength(20)]
        public ST[] RUDisplayPrintLocations
        {
            get { return GetValuesAt<ST>(5); }
        }
        [Description("R/U Results Level")]
        [MaxLength(1)]
        public ID RUResultsLevel
        {
            get { return GetValueAt<ID>(6); }
        }
    }
}
