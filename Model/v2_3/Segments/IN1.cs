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
    /// IN1: Insurance
    /// </summary>
    public class IN1 : ChoHL7Segment
    {
        [Description("ID")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Insurance Plan ID")]
        [MaxLength(8)]
        public CE InsurancePlanID
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Insurance Company ID")]
        [Required]
        [MaxLength(59)]
        public CX InsuranceCompanyID
        {
            get { return GetValueAt<CX>(2); }
        }
        [Description("Insurance Company Name")]
        [MaxLength(130)]
        public XON InsuranceCompanyName
        {
            get { return GetValueAt<XON>(3); }
        }
        [Description("Insurance Company Address")]
        [MaxLength(106)]
        public XAD InsuranceCompanyAddress
        {
            get { return GetValueAt<XAD>(4); }
        }
        [Description("Insurance Company Contact Papers")]
        [MaxLength(48)]
        public XAD InsuranceCompanyContactPapers
        {
            get { return GetValueAt<XAD>(5); }
        }
        [Description("Insurance Company Phone Number")]
        [MaxLength(40)]
        [ChoHL7MaxCount(3)]
        public XTN[] InsuranceCompanyPhoneNumber
        {
            get { return GetValuesAt<XTN>(6); }
        }
        [Description("Group Number")]
        [MaxLength(12)]
        public ST GroupNumber
        {
            get { return GetValueAt<ST>(7); }
        }
        [Description("Group Name")]
        [MaxLength(130)]
        public XON GroupName
        {
            get { return GetValueAt<XON>(8); }
        }
        [Description("Insured's group employer ID")]
        [MaxLength(12)]
        public CX InsuredsGroupEmployerID
        {
            get { return GetValueAt<CX>(9); }
        }
        [Description("Insured's Group Employer Name")]
        [MaxLength(130)]
        public XON InsuredsGroupEmployerName
        {
            get { return GetValueAt<XON>(10); }
        }
        [Description("Plan Effective Date")]
        [MaxLength(8)]
        public DT PlanEffectiveDate
        {
            get { return GetValueAt<DT>(11); }
        }
        [Description("Plan Expiration Date")]
        [MaxLength(8)]
        public DT PlanExpirationDate
        {
            get { return GetValueAt<DT>(12); }
        }
        [Description("Authorization Information")]
        [MaxLength(55)]
        public CM_AUI AuthorizationInformation
        {
            get { return GetValueAt<CM_AUI>(13); }
        }
        [Description("Plan Type")]
        [MaxLength(3)]
        public IS PlanType
        {
            get { return GetValueAt<IS>(14); }
        }
        [Description("Name of Insured")]
        [MaxLength(48)]
        public XPN NameOfInsured
        {
            get { return GetValueAt<XPN>(15); }
        }
        [Description("Insured's Relationship to Patient")]
        [MaxLength(2)]
        public IS InsuredsRelationshipToPatient
        {
            get { return GetValueAt<IS>(16); }
        }
        [Description("Insured's Date of Birth")]
        [MaxLength(26)]
        public TS InsuredsDateOfBirth
        {
            get { return GetValueAt<TS>(17); }
        }
        [Description("Insured's Address")]
        [MaxLength(106)]
        public XAD InsuredsAddress
        {
            get { return GetValueAt<XAD>(18); }
        }
        [Description("Assignment of Benefits")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AssignmentOfBenefits))]
        public IS AssignmentOfBenefits
        {
            get { return GetValueAt<IS>(19); }
        }
        [Description("Coordination of Benefits")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(CoordinationOfBenefits))]
        public IS CoordinationOfBenefits
        {
            get { return GetValueAt<IS>(20); }
        }
        [Description("Coordination of Benefits Priority")]
        [MaxLength(2)]
        public ST CoordinationOfBenefitsPriority
        {
            get { return GetValueAt<ST>(21); }
        }
        [Description("Notice of Admission Code")]
        [MaxLength(2)]
        public ID NoticeOfAdmissionCode
        {
            get { return GetValueAt<ID>(22); }
        }
        [Description("Notice of Admission Date")]
        [MaxLength(8)]
        public DT NoticeOfAdmissionDate
        {
            get { return GetValueAt<DT>(23); }
        }
        [Description("Rpt of Eigibility Code")]
        [MaxLength(2)]
        public ID RptOfEigibilityCode
        {
            get { return GetValueAt<ID>(24); }
        }
        [Description("Rpt of Eligibility Date")]
        [MaxLength(8)]
        public DT RptOfEligibilityDate
        {
            get { return GetValueAt<DT>(25); }
        }
        [Description("Release Information Code")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(ReleaseInformation))]
        public IS ReleaseInformationCode
        {
            get { return GetValueAt<IS>(26); }
        }
        [Description("Pre-Admit Cert")]
        [MaxLength(15)]
        public ST PreAdmitCert
        {
            get { return GetValueAt<ST>(27); }
        }
        [Description("Verification Date/Time")]
        [MaxLength(26)]
        public TS VerificationDateTime
        {
            get { return GetValueAt<TS>(28); }
        }
        [Description("Verification By")]
        [MaxLength(60)]
        public XPN VerificationBy
        {
            get { return GetValueAt<XPN>(29); }
        }
        [Description("Type of Agreement Code")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(TypeOfAgreement))]
        public IS TypeOfAgreementCode
        {
            get { return GetValueAt<IS>(30); }
        }
        [Description("Billing Status")]
        [MaxLength(2)]
        public IS BillingStatus
        {
            get { return GetValueAt<IS>(31); }
        }
        [Description("Lifetime Reserve Days")]
        [MaxLength(4)]
        public NM LifetimeReserveDays
        {
            get { return GetValueAt<NM>(32); }
        }
        [Description("Delay before lifetime reserve days")]
        [MaxLength(4)]
        public NM DelayBeforeLifetimeReserveDays
        {
            get { return GetValueAt<NM>(33); }
        }
        [Description("Company Plan Code")]
        [MaxLength(2)]
        public IS CompanyPlanCode
        {
            get { return GetValueAt<IS>(34); }
        }
        [Description("Policy Number")]
        [MaxLength(15)]
        public ST PolicyNumber
        {
            get { return GetValueAt<ST>(35); }
        }
        [Description("Policy Deductible")]
        [MaxLength(12)]
        public CP PolicyDeductible
        {
            get { return GetValueAt<CP>(36); }
        }
        [Description("Policy Limit - Amount")]
        [MaxLength(12)]
        public CP PolicyLimitAmount
        {
            get { return GetValueAt<CP>(37); }
        }
        [Description("Policy Limit - Days")]
        [MaxLength(4)]
        public NM PolicyLimitDays
        {
            get { return GetValueAt<NM>(38); }
        }
        [Description("Room Rate - Semi-Private")]
        [MaxLength(12)]
        public CP RoomRateSemiPrivate
        {
            get { return GetValueAt<CP>(39); }
        }
        [Description("Room Rate - Private")]
        [MaxLength(12)]
        public CP RoomRatePrivate
        {
            get { return GetValueAt<CP>(40); }
        }
        [Description("Insured's Employment Status")]
        [MaxLength(60)]
        public CE InsuredsEmploymentStatus
        {
            get { return GetValueAt<CE>(41); }
        }
        [Description("Sex")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(Sex))]
        public IS Sex
        {
            get { return GetValueAt<IS>(42); }
        }
        [Description("Insured's Employer Address")]
        [MaxLength(106)]
        public XAD InsuredsEmployerAddress
        {
            get { return GetValueAt<XAD>(43); }
        }
        [Description("Verification Status")]
        [MaxLength(2)]
        public ST VerificationStatus
        {
            get { return GetValueAt<ST>(44); }
        }
        [Description("Prior Insurance Plan ID")]
        [MaxLength(8)]
        public IS PriorInsurancePlanID
        {
            get { return GetValueAt<IS>(45); }
        }
        [Description("Coverage Type")]
        [MaxLength(3)]
        [ChoHL7EnumType(typeof(CoverageType))]
        public IS CoverageType
        {
            get { return GetValueAt<IS>(46); }
        }
        [Description("Handicap")]
        [MaxLength(2)]
        public IS Handicap
        {
            get { return GetValueAt<IS>(47); }
        }
        [Description("Insured's ID Number")]
        [MaxLength(12)]
        public CX InsuredsIDNumber
        {
            get { return GetValueAt<CX>(48); }
        }
    }
}
