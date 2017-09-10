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
    /// LDP: Location Department
    /// </summary>
    public class LDP : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(20)]
        public PL PrimaryKeyValue
        {
            get { return GetValueAt<PL>(0); }
        }
        [Description("Location Department")]
        [Required]
        [MaxLength(10)]
        public IS LocationDepartment
        {
            get { return GetValueAt<IS>(1); }
        }
        [Description("Location Service")]
        [MaxLength(3)]
        public IS[] LocationService
        {
            get { return GetValuesAt<IS>(2); }
        }
        [Description("Specialty Type")]
        [MaxLength(60)]
        public CE[] SpecialtyType
        {
            get { return GetValuesAt<CE>(3); }
        }
        [Description("Valid Patient Classes")]
        [Required]
        [MaxLength(1)]
        public ID[] ValidPatientClasses
        {
            get { return GetValuesAt<ID>(4); }
        }
        [Description("Active/Inactive Flag")]
        [Required]
        [MaxLength(1)]
        public ID ActiveInactiveFlag
        {
            get { return GetValueAt<ID>(5); }
        }
        [Description("Activation Date")]
        [MaxLength(19)]
        public TS ActivationDate
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Inactivation Date")]
        [MaxLength(19)]
        public TS InactivationDate
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Inactivated Reason")]
        [MaxLength(80)]
        public ST InactivatedReason
        {
            get { return GetValueAt<ST>(8); }
        }
        [Description("Visiting Hours")]
        [MaxLength(80)]
        public VH[] VisitingHours
        {
            get { return GetValuesAt<VH>(9); }
        }
        [Description("Contact Phone")]
        [MaxLength(40)]
        public XTN ContactPhone
        {
            get { return GetValueAt<XTN>(10); }
        }
    }
}
