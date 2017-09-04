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
    /// PD1: Patient Demographic
    /// </summary>
    public class PD1 : ChoHL7Segment
    {
        [Description("Living Dependency")]
        [MaxLength(2)]
        public IS LivingDependency
        {
            get { return GetValueAt<IS>(0); }
        }
        [Description("Living Arrangement")]
        [MaxLength(2)]
        public IS LivingArrangement
        {
            get { return GetValueAt<IS>(1); }
        }
        [Description("Patient Primary Facility")]
        [MaxLength(90)]
        public XON[] PatientPrimaryFacility
        {
            get { return GetValuesAt<XON>(2); }
        }
        [Description("Patient Primary Care Provider Name & ID No.")]
        [MaxLength(90)]
        public XCN[] PatientPrimaryCareProviderNameAndIDNo
        {
            get { return GetValuesAt<XCN>(3); }
        }
        [Description("Student Indicator")]
        [MaxLength(2)]
        public IS StudentIndicator
        {
            get { return GetValueAt<IS>(4); }
        }
        [Description("Handicap")]
        [MaxLength(2)]
        public IS Handicap
        {
            get { return GetValueAt<IS>(5); }
        }
        [Description("Living Will")]
        [MaxLength(2)]
        public IS LivingWill
        {
            get { return GetValueAt<IS>(6); }
        }
        [Description("Organ Donor")]
        [MaxLength(2)]
        public IS OrganDonor
        {
            get { return GetValueAt<IS>(7); }
        }
        [Description("Separate Bill")]
        [MaxLength(2)]
        public ID SeparateBill
        {
            get { return GetValueAt<ID>(8); }
        }
        [Description("Duplicate Patient")]
        [MaxLength(2)]
        public CX[] DuplicatePatient
        {
            get { return GetValuesAt<CX>(9); }
        }
        [Description("Publicity Indicator")]
        [MaxLength(1)]
        public CE PublicityIndicator
        {
            get { return GetValueAt<CE>(10); }
        }
        [Description("Protection Indicator")]
        [MaxLength(1)]
        public ID ProtectionIndicator
        {
            get { return GetValueAt<ID>(11); }
        }
    }
}
