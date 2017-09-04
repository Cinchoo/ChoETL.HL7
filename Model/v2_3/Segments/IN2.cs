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
    /// IN2: Insurance additional info
    /// </summary>
    public class IN2 : ChoHL7Segment
    {
        [Description("Insured's Employee ID")]
        [MaxLength(59)]
        public CX InsuredsEmployeeID
        {
            get { return GetValueAt<CX>(0); }
        }
        [Description("Insured's Social Security Number")]
        [MaxLength(11)]
        public ST InsuredsSocialSecurityNumber
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Insured's Employer Name")]
        [MaxLength(130)]
        public XCN InsuredsEmployerName
        {
            get { return GetValueAt<XCN>(2); }
        }
        [Description("Employer Information Data")]
        [MaxLength(1)]
        public IS EmployerInformationData
        {
            get { return GetValueAt<IS>(3); }
        }
        [Description("Mail Claim Party")]
        [MaxLength(1)]
        public IS MailClaimParty
        {
            get { return GetValueAt<IS>(4); }
        }
        [Description("Medicare Health Ins Card Number")]
        [MaxLength(15)]
        public ST MedicareHealthInsCardNumber
        {
            get { return GetValueAt<ST>(5); }
        }
        [Description("Medicaid Case Name")]
        [MaxLength(48)]
        public XPN MedicaidCaseName
        {
            get { return GetValueAt<XPN>(6); }
        }
        [Description("Medicaid Case Number")]
        [MaxLength(15)]
        public ST MedicaidCaseNumber
        {
            get { return GetValueAt<ST>(7); }
        }
        [Description("Champus Sponsor Name")]
        [MaxLength(48)]
        public XPN ChampusSponsorName
        {
            get { return GetValueAt<XPN>(8); }
        }
        [Description("Champus ID Number")]
        [MaxLength(20)]
        public ST ChampusIDNumber
        {
            get { return GetValueAt<ST>(9); }
        }
        [Description("Dependent of Champus Recipient")]
        [MaxLength(80)]
        public CE DependentOfChampusRecipient
        {
            get { return GetValueAt<CE>(10); }
        }
        [Description("Champus Organization")]
        [MaxLength(25)]
        public ST ChampusOrganization
        {
            get { return GetValueAt<ST>(11); }
        }
        [Description("Champus Station")]
        [MaxLength(25)]
        public ST ChampusStation
        {
            get { return GetValueAt<ST>(12); }
        }
        [Description("Champus Service")]
        [MaxLength(14)]
        public IS ChampusService
        {
            get { return GetValueAt<IS>(13); }
        }
        [Description("Champus Rank/Grade")]
        [MaxLength(2)]
        public IS ChampusRankGrade
        {
            get { return GetValueAt<IS>(14); }
        }
        [Description("Champus Status")]
        [MaxLength(3)]
        public IS ChampusStatus
        {
            get { return GetValueAt<IS>(15); }
        }
        [Description("Champus Retire Date")]
        [MaxLength(8)]
        public DT ChampusRetireDate
        {
            get { return GetValueAt<DT>(16); }
        }
        [Description("Champus Non-Avail Cert on File")]
        [MaxLength(1)]
        public ID ChampusNonAvailCertOnFile
        {
            get { return GetValueAt<ID>(17); }
        }
        [Description("Baby Coverage")]
        [MaxLength(1)]
        public ID BabyCoverage
        {
            get { return GetValueAt<ID>(18); }
        }
        [Description("Combine Baby Bill")]
        [MaxLength(1)]
        public ID CombineBabyBill
        {
            get { return GetValueAt<ID>(19); }
        }
        [Description("Blood Deductible")]
        [MaxLength(1)]
        public ST BloodDeductible
        {
            get { return GetValueAt<ST>(20); }
        }
        [Description("Special Coverage Approval Name")]
        [MaxLength(48)]
        public XPN SpecialCoverageApprovalName
        {
            get { return GetValueAt<XPN>(21); }
        }
        [Description("Special Coverage Approval Title")]
        [MaxLength(30)]
        public ST SpecialCoverageApprovalTitle
        {
            get { return GetValueAt<ST>(22); }
        }
        [Description("Non-Covered Insurance Code")]
        [MaxLength(8)]
        public ST[] NonCoveredInsuranceCode
        {
            get { return GetValuesAt<ST>(23); }
        }
        [Description("Payor ID")]
        [MaxLength(59)]
        public CX PayorID
        {
            get { return GetValueAt<CX>(24); }
        }
        [Description("Payor Subscriber ID")]
        [MaxLength(59)]
        public CX PayorSubscriberID
        {
            get { return GetValueAt<CX>(25); }
        }
        [Description("Eligibility Source")]
        [MaxLength(1)]
        public IS EligibilitySource
        {
            get { return GetValueAt<IS>(26); }
        }
        [Description("Room Coverage Type/Amount")]
        [MaxLength(25)]
        public CM_RMC[] RoomCoverageTypeAmount
        {
            get { return GetValuesAt<CM_RMC>(27); }
        }
        [Description("Policy Type/Amount")]
        [MaxLength(25)]
        public CM_PTA[] PolicyTypeAmount
        {
            get { return GetValuesAt<CM_PTA>(28); }
        }
        [Description("Daily Deductible")]
        [MaxLength(60)]
        public CM_DDI DailyDeductible
        {
            get { return GetValueAt<CM_DDI>(29); }
        }
        [Description("Living Dependency")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(LivingDependency))]
        public IS LivingDependency
        {
            get { return GetValueAt<IS>(30); }
        }
        [Description("Ambulatory Status")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AmbulatoryStatus))]
        public IS AmbulatoryStatus
        {
            get { return GetValueAt<IS>(31); }
        }
        [Description("Citizenship")]
        [MaxLength(4)]
        public IS Citizenship
        {
            get { return GetValueAt<IS>(32); }
        }
        [Description("Primary Language")]
        [MaxLength(60)]
        public CE PrimaryLanguage
        {
            get { return GetValueAt<CE>(33); }
        }
        [Description("Living Arrangement")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(LivingArrangement))]
        public IS LivingArrangement
        {
            get { return GetValueAt<IS>(34); }
        }
        [Description("Publicity Indicator")]
        [MaxLength(1)]
        public CE PublicityIndicator
        {
            get { return GetValueAt<CE>(35); }
        }
        [Description("Protection Indicator")]
        [MaxLength(1)]
        public ID ProtectionIndicator
        {
            get { return GetValueAt<ID>(36); }
        }
        [Description("Student Indicator")]
        [MaxLength(2)]
        public IS StudentIndicator
        {
            get { return GetValueAt<IS>(37); }
        }
        [Description("Religion")]
        [MaxLength(3)]
        public IS Religion
        {
            get { return GetValueAt<IS>(38); }
        }
        [Description("Mother's Maiden Name")]
        [MaxLength(48)]
        public XPN MothersMaidenName
        {
            get { return GetValueAt<XPN>(39); }
        }
        [Description("Nationality Code")]
        [MaxLength(80)]
        public CE NationalityCode
        {
            get { return GetValueAt<CE>(40); }
        }
        [Description("Ethnic Group")]
        [MaxLength(1)]
        public IS EthnicGroup
        {
            get { return GetValueAt<IS>(41); }
        }
        [Description("Marital Status")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(MaritalStatus))]
        public IS[] MaritalStatus
        {
            get { return GetValuesAt<IS>(42); }
        }
        [Description("Employment Start Date")]
        [MaxLength(8)]
        public DT EmploymentStartDate
        {
            get { return GetValueAt<DT>(43); }
        }
        [Description("Employment Stop Date")]
        [MaxLength(8)]
        public DT EmploymentStopDate
        {
            get { return GetValueAt<DT>(44); }
        }
        [Description("Job Title")]
        [MaxLength(20)]
        public ST JobTitle
        {
            get { return GetValueAt<ST>(45); }
        }
        [Description("Job Code/Class")]
        [MaxLength(20)]
        public JCC JobCode
        {
            get { return GetValueAt<JCC>(46); }
        }
        [Description("Job Status")]
        [MaxLength(2)]
        public IS JobStatus
        {
            get { return GetValueAt<IS>(47); }
        }
        [Description("Employer Contact Person Name")]
        [MaxLength(48)]
        public XPN[] EmployerContactPersonName
        {
            get { return GetValuesAt<XPN>(48); }
        }
        [Description("Employer Contact Person Phone Number")]
        [MaxLength(48)]
        public XTN[] EmployerContactPersonPhoneNumber
        {
            get { return GetValuesAt<XTN>(49); }
        }
        [Description("Employer Contact Reason")]
        [MaxLength(2)]
        public IS EmployerContactReason
        {
            get { return GetValueAt<IS>(50); }
        }
        [Description("Insured's Contact Person's Name")]
        [MaxLength(48)]
        public XPN[] InsuredsContactPersonsName
        {
            get { return GetValuesAt<XPN>(51); }
        }
        [Description("Insured's Contact Person Telephone Number")]
        [MaxLength(40)]
        public XTN[] InsuredsContactPersonTelephoneNumber
        {
            get { return GetValuesAt<XTN>(52); }
        }
        [Description("Insured's Contact Person Reason")]
        [MaxLength(2)]
        public IS[] InsuredsContactPersonsReason
        {
            get { return GetValuesAt<IS>(53); }
        }
        [Description("Relationship To The Patient Start Date")]
        [MaxLength(8)]
        public DT RelationshipToThePatientStartDate
        {
            get { return GetValueAt<DT>(54); }
        }
        [Description("Relationship To The Patient Stop Date")]
        [MaxLength(8)]
        public DT[] RelationshipToThePatientStopDate
        {
            get { return GetValuesAt<DT>(55); }
        }
        [Description("Insurance Company Contact Reason")]
        [MaxLength(2)]
        public IS InsuranceCompanyContactReason
        {
            get { return GetValueAt<IS>(56); }
        }
        [Description("Insurance Company Contact Phone Number")]
        [MaxLength(40)]
        public XTN InsuranceCompanyContactPhoneNumber
        {
            get { return GetValueAt<XTN>(57); }
        }
        [Description("Policy Scope")]
        [MaxLength(2)]
        public IS PolicyScope
        {
            get { return GetValueAt<IS>(58); }
        }
        [Description("Policy Source")]
        [MaxLength(2)]
        public IS PolicySource
        {
            get { return GetValueAt<IS>(59); }
        }
        [Description("Patient Member Number")]
        [MaxLength(60)]
        public CX PatientMemberNumber
        {
            get { return GetValueAt<CX>(60); }
        }
        [Description("Guarantor's Relationship To Insured")]
        [MaxLength(2)]
        public IS GuarantorsRelationshipToInsured
        {
            get { return GetValueAt<IS>(61); }
        }
        [Description("Insured's Telephone Number - Home")]
        [MaxLength(40)]
        public XTN[] InsuredsHomeTelephoneNumber
        {
            get { return GetValuesAt<XTN>(62); }
        }
        [Description("Insured's Employer Telephone Number")]
        [MaxLength(40)]
        public XTN[] InsuredsEmployerTelephoneNumber
        {
            get { return GetValuesAt<XTN>(63); }
        }
        [Description("Military Handicapped Program")]
        [MaxLength(2)]
        public CE MilitaryHandicappedProgram
        {
            get { return GetValueAt<CE>(64); }
        }
        [Description("Suspend Flag")]
        [MaxLength(2)]
        public ID SuspendFlag
        {
            get { return GetValueAt<ID>(65); }
        }
        [Description("Co-pay Limit Flag")]
        [MaxLength(2)]
        public ID CopayLimitFlag
        {
            get { return GetValueAt<ID>(66); }
        }
        [Description("Stoploss Limit Flag")]
        [MaxLength(2)]
        public ID StoplossLimitFlag
        {
            get { return GetValueAt<ID>(67); }
        }
        [Description("Insured Organization Name And ID")]
        [MaxLength(130)]
        public XON[] InsuredOrganizationNameAndID
        {
            get { return GetValuesAt<XON>(68); }
        }
        [Description("Insured Employer Organization Name And ID")]
        [MaxLength(130)]
        public XON[] InsuredEmployerOrganizationNameAndID
        {
            get { return GetValuesAt<XON>(69); }
        }
        [Description("Race")]
        [MaxLength(1)]
        public IS Race
        {
            get { return GetValueAt<IS>(70); }
        }
        [Description("Patient Relationship to Insured")]
        [MaxLength(1)]
        public ID PatientRelationshipToInsured
        {
            get { return GetValueAt<ID>(71); }
        }
    }
}
