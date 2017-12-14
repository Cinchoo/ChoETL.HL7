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
    /// URD: Results/update definition segment
    /// </summary>
    public class URD : ChoHL7Segment
    {
        [Description("R/U Date/Time")]
        [MaxLength(26)]
        public TS RUDateTime
        {
            get { return GetValueAt<TS>(0); }
        }
        [Description("Report Priority")]
        [MaxLength(1)]
        public ID ReportPriority
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("R/U Who Subject Definition")]
        [MaxLength(60)]
        [Required]
        public XCN[] RUWhoSubjectDefinition
        {
            get { return GetValuesAt<XCN>(2); }
        }
        [Description("R/U What Subject Definition")]
        [MaxLength(60)]
        public CE RUWhatSubjectDefinition
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("R/U What Department Code")]
        [MaxLength(60)]
        public CE RUWhatDepartmentCode
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
