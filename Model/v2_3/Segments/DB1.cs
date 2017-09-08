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
    /// DB1: Disability Segment
    /// </summary>
    public class DB1 : ChoHL7Segment
    {
        [Description("Set ID - DB1")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Disabled person code")]
        [MaxLength(2)]
        public IS DisabledPersonCode
        {
            get { return GetValueAt<IS>(1); }
        }
        [Description("Disabled person identifier")]
        [MaxLength(32)]
        public CX[] DisabledPersonIdentifier
        {
            get { return GetValuesAt<CX>(2); }
        }
        [Description("Disabled Indicator")]
        [MaxLength(1)]
        public ID DisabledIndicator
        {
            get { return GetValueAt<ID>(3); }
        }
        [Description("Disability start date")]
        [MaxLength(8)]
        public DT DisabilityStartDate
        {
            get { return GetValueAt<DT>(4); }
        }
        [Description("Disability end date")]
        [MaxLength(8)]
        public DT DisabilityEndDate
        {
            get { return GetValueAt<DT>(5); }
        }
        [Description("Disability return to work date")]
        [MaxLength(8)]
        public DT DisabilityReturnToWorkDate
        {
            get { return GetValueAt<DT>(6); }
        }
        [Description("Disability unable to work date")]
        [MaxLength(8)]
        public DT DisabilityUnableToWorkDate
        {
            get { return GetValueAt<DT>(7); }
        }
    }
}
