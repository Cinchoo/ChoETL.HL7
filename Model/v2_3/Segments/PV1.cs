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
    /// PV1: Patient visit
    /// </summary>
    public class PV1 : ChoHL7Segment
    {
        [Description("Set ID - Patient Visit")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Patient Class")]
        [Required]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(PatientClass))]
        public ID PatientClass
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Assigned Patient Location")]
        [MaxLength(12)]
        public PL AssignedPatientLocation
        {
            get { return GetValueAt<PL>(2); }
        }
        [Description("Admission Type")]
        [Required]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AdmissionType))]
        public ID AdmissionType
        {
            get { return GetValueAt<ID>(3); }
        }
        [Description("Preadmit Number")]
        [MaxLength(20)]
        public CX PreadmitNumber
        {
            get { return GetValueAt<CX>(4); }
        }
        [Description("Prior Patient Location")]
        [MaxLength(12)]
        public PL PriorPatientLocation
        {
            get { return GetValueAt<PL>(5); }
        }
        [Description("Attending Doctor")]
        [MaxLength(60)]
        public XCN AttendingDoctor
        {
            get { return GetValueAt<XCN>(6); }
        }
        [Description("Referring Doctor")]
        [MaxLength(60)]
        public XCN ReferringDoctor
        {
            get { return GetValueAt<XCN>(7); }
        }
        [Description("Consulting Doctor")]
        [MaxLength(60)]
        public XCN[] ConsultingDoctor
        {
            get { return GetValuesAt<XCN>(8); }
        }
        [Description("Hospital Service")]
        [MaxLength(3)]
        public ID HospitalService
        {
            get { return GetValueAt<ID>(9); }
        }
        [Description("Temporary Location")]
        [MaxLength(12)]
        public PL TemporaryLocation
        {
            get { return GetValueAt<PL>(10); }
        }
        [Description("Preadmit Test Indicator")]
        [MaxLength(2)]
        public ID PreadmitTestIndicator
        {
            get { return GetValueAt<ID>(11); }
        }
        [Description("Readmission Indicator")]
        [MaxLength(2)]
        public ID ReadmissionIndicator
        {
            get { return GetValueAt<ID>(12); }
        }
        [Description("Admit Source")]
        [MaxLength(3)]
        [ChoHL7EnumType(typeof(AdmitSource))]
        public ID AdmitSource
        {
            get { return GetValueAt<ID>(13); }
        }
        [Description("Ambulatory Status")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AmbulatoryStatus))]
        public IS AmbulatoryStatus
        {
            get { return GetValueAt<IS>(14); }
        }
        [Description("VIP Indicator")]
        [MaxLength(2)]
        public ID VIPIndicator
        {
            get { return GetValueAt<ID>(15); }
        }
        [Description("Admitting Doctor")]
        [MaxLength(60)]
        public XCN AdmittingDoctor
        {
            get { return GetValueAt<XCN>(16); }
        }
        [Description("Patient Type")]
        [MaxLength(2)]
        public ID PatientType
        {
            get { return GetValueAt<ID>(17); }
        }
        [Description("Visit Number")]
        [MaxLength(15)]
        public CX VisitNumber
        {
            get { return GetValueAt<CX>(18); }
        }
        [Description("Financial Class")]
        [MaxLength(50)]
        public FC[] FinancialClass
        {
            get { return GetValuesAt<FC>(19); }
        }
        [Description("Charge Price Indicator")]
        [MaxLength(2)]
        public ID ChargePriceIndicator
        {
            get { return GetValueAt<ID>(20); }
        }
        [Description("Courtesy Code")]
        [MaxLength(2)]
        public ID CourtesyCode
        {
            get { return GetValueAt<ID>(21); }
        }
        [Description("Credit Rating")]
        [MaxLength(2)]
        public ID CreditRating
        {
            get { return GetValueAt<ID>(22); }
        }
        [Description("Contract Code")]
        [MaxLength(2)]
        public ID[] ContractCode
        {
            get { return GetValuesAt<ID>(23); }
        }
        [Description("Contract Effective Date")]
        [MaxLength(8)]
        public DT[] ContractEffectiveDate
        {
            get { return GetValuesAt<DT>(24); }
        }
    }
}
