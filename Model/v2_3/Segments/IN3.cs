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
    /// IN3: Insurance additional info - certification
    /// </summary>
    public class IN3 : ChoHL7Segment
    {
        [Description("ID")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Certification Number")]
        [MaxLength(59)]
        public CX CertificationNumber
        {
            get { return GetValueAt<CX>(1); }
        }
        [Description("Certified By")]
        [MaxLength(60)]
        public XCN[] CertifiedBy
        {
            get { return GetValuesAt<XCN>(2); }
        }
        [Description("Certification Required")]
        [MaxLength(1)]
        public ID CertificationRequired
        {
            get { return GetValueAt<ID>(3); }
        }
        [Description("Penalty")]
        [MaxLength(10)]
        public CM_PEN Penalty
        {
            get { return GetValueAt<CM_PEN>(4); }
        }
        [Description("Certification DateTime")]
        [MaxLength(26)]
        public TS CertificationDateTime
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Certification Modify DateTime")]
        [MaxLength(26)]
        public TS CertificationModifyDateTime
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Operator")]
        [MaxLength(60)]
        public XCN[] Operator
        {
            get { return GetValuesAt<XCN>(7); }
        }
        [Description("Certification Begin Date")]
        [MaxLength(8)]
        public DT CertificationBeginDate
        {
            get { return GetValueAt<DT>(8); }
        }
        [Description("Certification End Date")]
        [MaxLength(8)]
        public TS CertificationEndDate
        {
            get { return GetValueAt<TS>(9); }
        }
        [Description("Days")]
        [MaxLength(3)]
        public CM_DTN Days
        {
            get { return GetValueAt<CM_DTN>(10); }
        }
        [Description("Non-Concur Code/Description")]
        [MaxLength(60)]
        public CE NonConcurCodeDescription
        {
            get { return GetValueAt<CE>(11); }
        }
        [Description("Non-Concur Effective Date/Time")]
        [MaxLength(26)]
        public TS NonConcurEffectiveDateTime
        {
            get { return GetValueAt<TS>(12); }
        }
        [Description("Physician Reviewer")]
        [MaxLength(60)]
        public XCN[] PhysicianReviewer
        {
            get { return GetValuesAt<XCN>(13); }
        }
        [Description("Certification Contact")]
        [MaxLength(48)]
        public ST CertificationContact
        {
            get { return GetValueAt<ST>(14); }
        }
        [Description("Certification Contact Phone Number")]
        [MaxLength(40)]
        public XTN[] CertificationContactPhoneNumber
        {
            get { return GetValuesAt<XTN>(15); }
        }
        [Description("Appeal Reason")]
        [MaxLength(60)]
        public CE AppealReason
        {
            get { return GetValueAt<CE>(16); }
        }
        [Description("Certification Agency")]
        [MaxLength(60)]
        public CE CertificationAgency
        {
            get { return GetValueAt<CE>(17); }
        }
        [Description("Certification Agency Phone Number")]
        [MaxLength(40)]
        public XTN[] CertificationAgencyPhoneNumber
        {
            get { return GetValuesAt<XTN>(18); }
        }
        [Description("Pre-Certification required/Window")]
        [MaxLength(40)]
        public CM_PCF[] PreCertificationRequiredWindow
        {
            get { return GetValuesAt<CM_PCF>(19); }
        }
        [Description("Case Manager")]
        [MaxLength(48)]
        public ST CaseManager
        {
            get { return GetValueAt<ST>(20); }
        }
        [Description("Second Opinion Date")]
        [MaxLength(8)]
        public DT SecondOpinionDate
        {
            get { return GetValueAt<DT>(21); }
        }
        [Description("Second Opinion Status")]
        [MaxLength(1)]
        public IS SecondOpinionStatus
        {
            get { return GetValueAt<IS>(22); }
        }
        [Description("Second Opinion Documentation Received")]
        [MaxLength(1)]
        public IS[] SecondOpinionDocumentationReceived
        {
            get { return GetValuesAt<IS>(23); }
        }
        [Description("Second Opinion Physician")]
        [MaxLength(60)]
        public XCN[] RptOfEigibilityCode
        {
            get { return GetValuesAt<XCN>(24); }
        }
    }
}
