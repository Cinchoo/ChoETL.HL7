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
    /// NK1: Next of kin
    /// </summary>
    public class NK1 : ChoHL7Segment
    {
        [Description("ID")]
        [MaxLength(4)]
        [Required]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Name")]
        [MaxLength(48)]
        public XPN[] Name
        {
            get { return GetValuesAt<XPN>(1); }
        }
        [Description("Relationship")]
        [MaxLength(60)]
        public CE Relationship
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Address")]
        [MaxLength(106)]
        public XAD[] Address
        {
            get { return GetValuesAt<XAD>(3); }
        }
        [Description("Phone Number")]
        [MaxLength(40)]
        public XTN[] PhoneNumber
        {
            get { return GetValuesAt<XTN>(4); }
        }
        [Description("Business Phone Number")]
        [MaxLength(40)]
        public XTN[] BusinessPhoneNumber
        {
            get { return GetValuesAt<XTN>(5); }
        }
        [Description("Contact Role")]
        [MaxLength(60)]
        [Required]
        public CE ContactRole
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Start Date")]
        [MaxLength(60)]
        public DT StartDate
        {
            get { return GetValueAt<DT>(7); }
        }
        [Description("End Date")]
        [MaxLength(60)]
        public DT EndDate
        {
            get { return GetValueAt<DT>(8); }
        }
        [Description("Next of Kin/Associated Parties Job Title")]
        [MaxLength(60)]
        public ST JobTitle
        {
            get { return GetValueAt<ST>(9); }
        }
        [Description("Next of Kin Job/Associated Parties Code/Class")]
        [MaxLength(20)]
        public JCC JobCode
        {
            get { return GetValueAt<JCC>(10); }
        }
        [Description("Next of Kin/Associated Parties Employee Number")]
        [MaxLength(20)]
        public CX EmployeeNumber
        {
            get { return GetValueAt<CX>(11); }
        }
        [Description("Organization Name")]
        [MaxLength(60)]
        public XON[] OrganizationName
        {
            get { return GetValuesAt<XON>(12); }
        }
        [Description("Marital Status")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(MaritalStatus))]
        public IS[] MaritalStatus
        {
            get { return GetValuesAt<IS>(13); }
        }
        [Description("Sex")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(Sex))]
        public IS Sex
        {
            get { return GetValueAt<IS>(14); }
        }
        [Description("Date Of Birth")]
        [MaxLength(26)]
        public TS DateOfBirth
        {
            get { return GetValueAt<TS>(15); }
        }
        [Description("Living Dependency")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(LivingDependency))]
        public IS LivingDependency
        {
            get { return GetValueAt<IS>(16); }
        }
        [Description("Ambulatory Status")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AmbulatoryStatus))]
        public IS AmbulatoryStatus
        {
            get { return GetValueAt<IS>(17); }
        }
        [Description("Citizenship")]
        [MaxLength(4)]
        public IS Citizenship
        {
            get { return GetValueAt<IS>(18); }
        }
        [Description("Primary Language")]
        [MaxLength(60)]
        public CE PrimaryLanguage
        {
            get { return GetValueAt<CE>(19); }
        }
        [Description("Living Arrangement")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(LivingArrangement))]
        public IS LivingArrangement
        {
            get { return GetValueAt<IS>(20); }
        }
        [Description("Publicity Indicator")]
        [MaxLength(1)]
        public CE PublicityIndicator
        {
            get { return GetValueAt<CE>(21); }
        }
        [Description("Protection Indicator")]
        [MaxLength(1)]
        public ID ProtectionIndicator
        {
            get { return GetValueAt<ID>(22); }
        }
        [Description("Student Indicator")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(StudentIndicator))]
        public IS StudentIndicator
        {
            get { return GetValueAt<IS>(23); }
        }
        [Description("Religion")]
        [MaxLength(3)]
        public IS Religion
        {
            get { return GetValueAt<IS>(24); }
        }
        [Description("Mother's Maiden Name")]
        [MaxLength(48)]
        public XPN MothersMaidenName
        {
            get { return GetValueAt<XPN>(25); }
        }
        [Description("Nationality Code")]
        [MaxLength(80)]
        public CE NationalityCode
        {
            get { return GetValueAt<CE>(26); }
        }
        [Description("Ethnic Group")]
        [MaxLength(1)]
        public IS EthnicGroup
        {
            get { return GetValueAt<IS>(27); }
        }
        [Description("Contact Reason")]
        [MaxLength(2)]
        public CE ContactReason
        {
            get { return GetValueAt<CE>(28); }
        }
        [Description("Contact Person Name")]
        [MaxLength(48)]
        public XPN[] ContactPersonName
        {
            get { return GetValuesAt<XPN>(29); }
        }
        [Description("Contact Person Telephone Number")]
        [MaxLength(40)]
        public XTN[] ContactPersonTelephoneNumber
        {
            get { return GetValuesAt<XTN>(30); }
        }
        [Description("Contact Person Address")]
        [MaxLength(106)]
        public XAD[] ContactPersonAddress
        {
            get { return GetValuesAt<XAD>(31); }
        }
        [Description("Associated Party's Identifiers")]
        [MaxLength(32)]
        public CX[] AssociatedPartysIdentifiers
        {
            get { return GetValuesAt<CX>(32); }
        }
        [Description("Job Status")]
        [MaxLength(2)]
        public IS JobStatus
        {
            get { return GetValueAt<IS>(33); }
        }
        [Description("Race")]
        [MaxLength(2)]
        public IS Race
        {
            get { return GetValueAt<IS>(34); }
        }
        [Description("Handicap")]
        [MaxLength(2)]
        public IS Handicap
        {
            get { return GetValueAt<IS>(35); }
        }
        [Description("Contact Person Social Security Number")]
        [MaxLength(16)]
        public ST ContactPersonSSN
        {
            get { return GetValueAt<ST>(36); }
        }
    }
}
