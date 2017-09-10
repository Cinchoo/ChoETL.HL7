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
    /// GT1: Guarantor
    /// </summary>
    public class GT1 : ChoHL7Segment
    {
        [Description("Set ID - Guarantor")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Guarantor Number")]
        [MaxLength(59)]
        public CX[] GuarantorNumber
        {
            get { return GetValuesAt<CX>(1); }
        }
        [Description("Guarantor Name")]
        [Required]
        [MaxLength(48)]
        public XPN[] GuarantorName
        {
            get { return GetValuesAt<XPN>(2); }
        }
        [Description("Guarantor Spouse Name")]
        [MaxLength(48)]
        public XPN[] GuarantorSpouseName
        {
            get { return GetValuesAt<XPN>(3); }
        }
        [Description("Guarantor Address")]
        [MaxLength(106)]
        public XAD[] GuarantorAddress
        {
            get { return GetValuesAt<XAD>(4); }
        }
        [Description("Guarantor Ph Num- Home")]
        [MaxLength(40)]
        public XTN[] GuarantorHomePhoneNumber
        {
            get { return GetValuesAt<XTN>(5); }
        }
        [Description("Guarantor Ph Num- Business")]
        [MaxLength(40)]
        public XTN[] GuarantorBusinessPhoneNumber
        {
            get { return GetValuesAt<XTN>(6); }
        }
        [Description("Guarantor Date/Time of Birth")]
        [MaxLength(26)]
        public IS GuarantorDateofBirth
        {
            get { return GetValueAt<IS>(7); }
        }
        [Description("Guarantor Sex")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(Sex))]
        public IS GuarantorSex
        {
            get { return GetValueAt<IS>(8); }
        }
        [Description("Guarantor Type")]
        [MaxLength(2)]
        public IS GuarantorType
        {
            get { return GetValueAt<IS>(9); }
        }
        [Description("Guarantor Relationship")]
        [MaxLength(2)]
        public IS GuarantorRelationship
        {
            get { return GetValueAt<IS>(10); }
        }
        [Description("Guarantor SSN")]
        [MaxLength(11)]
        public ST GuarantorSSN
        {
            get { return GetValueAt<ST>(11); }
        }
        [Description("Guarantor Date - Begin")]
        [MaxLength(8)]
        public DT GuarantorDateBegin
        {
            get { return GetValueAt<DT>(12); }
        }
        [Description("Guarantor Date - End")]
        [MaxLength(8)]
        public DT GuarantorDateEnd
        {
            get { return GetValueAt<DT>(13); }
        }
        [Description("Guarantor Priority")]
        [MaxLength(2)]
        public NM GuarantorPriority
        {
            get { return GetValueAt<NM>(14); }
        }
        [Description("Guarantor Employer Name")]
        [MaxLength(130)]
        public XPN[] GuarantorEmployerName
        {
            get { return GetValuesAt<XPN>(15); }
        }
        [Description("Guarantor Employer Address")]
        [MaxLength(106)]
        public XAD[] GuarantorEmployerAddress
        {
            get { return GetValuesAt<XAD>(16); }
        }
        [Description("Guarantor Employ Phone Number")]
        [MaxLength(40)]
        public XTN[] GuarantorEmployPhoneNumber
        {
            get { return GetValuesAt<XTN>(17); }
        }
        [Description("Guarantor Employee ID Number")]
        [MaxLength(20)]
        public CX[] GuarantorEmployeeIDNumber
        {
            get { return GetValuesAt<CX>(18); }
        }
        [Description("Guarantor Employment Status")]
        [MaxLength(120)]
        public IS GuarantorEmploymentStatus
        {
            get { return GetValueAt<IS>(19); }
        }
        [Description("Guarantor Organization")]
        [MaxLength(130)]
        public XON[] GuarantorOrganization
        {
            get { return GetValuesAt<XON>(20); }
        }
        [Description("Guarantor Billing Hold Flag")]
        [MaxLength(1)]
        public ID GuarantorBillingHoldFlag
        {
            get { return GetValueAt<ID>(21); }
        }
        [Description("Guarantor Credit Rating Code")]
        [MaxLength(80)]
        public CE GuarantorCreditRatingCode
        {
            get { return GetValueAt<CE>(22); }
        }
        [Description("Guarantor Death Date And Time")]
        [MaxLength(26)]
        public TS GuarantorDeathDateAndTime
        {
            get { return GetValueAt<TS>(23); }
        }
        [Description("Guarantor Death Flag")]
        [MaxLength(1)]
        public ID GuarantorDeathFlag
        {
            get { return GetValueAt<ID>(24); }
        }

        [Description("Guarantor Charge Adjustment Code")]
        [MaxLength(80)]
        public CE GuarantorChargeAdjustmentCode
        {
            get { return GetValueAt<CE>(25); }
        }
        [Description("Guarantor Household Annual Income")]
        [MaxLength(10)]
        public CP GuarantorHouseholdAnnualIncome
        {
            get { return GetValueAt<CP>(26); }
        }
        [Description("Guarantor Household Size")]
        [Required]
        [MaxLength(3)]
        public NM GuarantorHouseholdSize
        {
            get { return GetValueAt<NM>(27); }
        }
        [Description("Guarantor Employer ID Number")]
        [MaxLength(20)]
        public CX[] GuarantorEmployerIDNumber
        {
            get { return GetValuesAt<CX>(28); }
        }
        [Description("Guarantor Marital Status Code")]
        [MaxLength(1)]
        public IS GuarantorMaritalStatusCode
        {
            get { return GetValueAt<IS>(29); }
        }
        [Description("Guarantor Hire Effective Date")]
        [MaxLength(8)]
        public DT GuarantorHireEffectiveDate
        {
            get { return GetValueAt<DT>(30); }
        }
        [Description("Employment Stop Date")]
        [MaxLength(8)]
        public DT EmploymentStopDate
        {
            get { return GetValueAt<DT>(31); }
        }
        [Description("Living Dependency")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(LivingDependency))]
        public IS LivingDependency
        {
            get { return GetValueAt<IS>(32); }
        }
        [Description("Ambulatory Status")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AmbulatoryStatus))]
        public IS AmbulatoryStatus
        {
            get { return GetValueAt<IS>(33); }
        }
        [Description("Citizenship")]
        [MaxLength(2)]
        public IS Citizenship
        {
            get { return GetValueAt<IS>(34); }
        }
        [Description("Primary Language")]
        [MaxLength(60)]
        public CE PrimaryLanguage
        {
            get { return GetValueAt<CE>(35); }
        }
        [Description("Living Arrangement")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(LivingArrangement))]
        public IS LivingArrangement
        {
            get { return GetValueAt<IS>(36); }
        }
        [Description("Publicity Indicator")]
        [MaxLength(1)]
        public CE PublicityIndicator
        {
            get { return GetValueAt<CE>(37); }
        }
        [Description("Protection Indicator")]
        [MaxLength(1)]
        public ID ProtectionIndicator
        {
            get { return GetValueAt<ID>(38); }
        }
        [Description("Student Indicator")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(StudentIndicator))]
        public IS StudentIndicator
        {
            get { return GetValueAt<IS>(39); }
        }
        [Description("Religion")]
        [MaxLength(3)]
        public IS Religion
        {
            get { return GetValueAt<IS>(40); }
        }
        [Description("Mother's Maiden Name")]
        [MaxLength(48)]
        public XPN MothersMaidenName
        {
            get { return GetValueAt<XPN>(41); }
        }
        [Description("Nationality Code")]
        [MaxLength(80)]
        public CE NationalityCode
        {
            get { return GetValueAt<CE>(42); }
        }
        [Description("Ethnic Group")]
        [MaxLength(1)]
        public IS EthnicGroup
        {
            get { return GetValueAt<IS>(43); }
        }
        [Description("Contact Person's Name")]
        [MaxLength(48)]
        public XPN ContactPersonName
        {
            get { return GetValueAt<XPN>(44); }
        }
        [Description("Contact Person s Telephone Number")]
        [MaxLength(40)]
        public XTN ContactPersonTelephoneNumber
        {
            get { return GetValueAt<XTN>(45); }
        }
        [Description("Contact Reason")]
        [MaxLength(2)]
        public CE ContactReason
        {
            get { return GetValueAt<CE>(46); }
        }
        [Description("Guarantor Credit Rating Code")]
        [MaxLength(2)]
        public IS ContactRelationshipCode
        {
            get { return GetValueAt<IS>(47); }
        }
        [Description("Job Title")]
        [MaxLength(20)]
        public ST JobTitle
        {
            get { return GetValueAt<ST>(48); }
        }
        [Description("Job Code")]
        [MaxLength(20)]
        public JCC JobCode
        {
            get { return GetValueAt<JCC>(49); }
        }
        [Description("Guarantor Employer's Organization Name")]
        [MaxLength(130)]
        public XON[] GuarantorEmployerOrganizationName
        {
            get { return GetValuesAt<XON>(50); }
        }
        [Description("Handicap")]
        [MaxLength(2)]
        public IS Handicap
        {
            get { return GetValueAt<IS>(51); }
        }
        [Description("JobStatus")]
        [MaxLength(2)]
        public IS JobStatus
        {
            get { return GetValueAt<IS>(52); }
        }
        [Description("Guarantor Financial Class")]
        [MaxLength(50)]
        public FC GuarantorFinancialClass
        {
            get { return GetValueAt<FC>(53); }
        }
        [Description("Guarantor Race")]
        [MaxLength(1)]
        public IS GuarantorRace
        {
            get { return GetValueAt<IS>(54); }
        }
    }
}
