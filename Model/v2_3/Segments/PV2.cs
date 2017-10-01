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
    /// PV2: Patient visit - additional information
    /// </summary>
    public class PV2 : ChoHL7Segment
    {
        [Description("Prior Pending Location")]
        [MaxLength(12)]
        public PL PriorPendingLocation
        {
            get { return GetValueAt<PL>(0); }
        }
        [Description("Accommodation Code")]
        [MaxLength(60)]
        public CE AccommodationCode
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Admit Reason")]
        [MaxLength(60)]
        public CE AdmitReason
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Transfer Reason")]
        [MaxLength(60)]
        public CE TransferReason
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Patient Valuables")]
        [MaxLength(25)]
        public ST[] PatientValuables
        {
            get { return GetValuesAt<ST>(4); }
        }
        [Description("Patient Valuables Location")]
        [MaxLength(25)]
        public ST PatientValuablesLocation
        {
            get { return GetValueAt<ST>(5); }
        }
        [Description("Visit User Code")]
        [MaxLength(2)]
        public IS VisitUserCode
        {
            get { return GetValueAt<IS>(6); }
        }
        [Description("Expected Admit Date")]
        [MaxLength(8)]
        public TS ExpectedAdmitDate
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Expected Discharge Date")]
        [MaxLength(8)]
        public TS ExpectedDischargeDate
        {
            get { return GetValueAt<TS>(8); }
        }
        [Description("Estimated Length of Inpatient Stay")]
        [MaxLength(3)]
        public NM EstimatedLengthofInpatientStay
        {
            get { return GetValueAt<NM>(9); }
        }
        [Description("Actual Length of Inpatient Stay")]
        [MaxLength(3)]
        public NM ActualLengthofInpatientStay
        {
            get { return GetValueAt<NM>(10); }
        }
        [Description("Visit Description")]
        [MaxLength(50)]
        public ST VisitDescription
        {
            get { return GetValueAt<ST>(11); }
        }
        [Description("Referral Source Code")]
        [MaxLength(90)]
        public XCN ReferralSourceCode
        {
            get { return GetValueAt<XCN>(12); }
        }
        [Description("Previous Service Date")]
        [MaxLength(8)]
        public DT PreviousServiceDate
        {
            get { return GetValueAt<DT>(13); }
        }
        [Description("Employment Illness Related Indicator")]
        [MaxLength(1)]
        public ID EmploymentIllnessRelatedIndicator
        {
            get { return GetValueAt<ID>(14); }
        }
        [Description("Purge Status Code")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(PurgeStatus))]
        public IS PurgeStatusCode
        {
            get { return GetValueAt<IS>(15); }
        }
        [Description("Purge Status Date")]
        [MaxLength(8)]
        public DT PurgeStatusDate
        {
            get { return GetValueAt<DT>(16); }
        }
        [Description("Special Program Code")]
        [MaxLength(2)]
        public IS SpecialProgramCode
        {
            get { return GetValueAt<IS>(17); }
        }
        [Description("Retention Indicator")]
        [MaxLength(1)]
        public ID RetentionIndicator
        {
            get { return GetValueAt<ID>(18); }
        }
        [Description("Expected Number of Insurance Plans")]
        [MaxLength(1)]
        public NM ExpectedNumberofInsurancePlans
        {
            get { return GetValueAt<NM>(19); }
        }
        [Description("Visit Publicity Code")]
        [MaxLength(1)]
        public IS VisitPublicityCodee
        {
            get { return GetValueAt<IS>(20); }
        }
        [Description("Visit Protection Indicator")]
        [MaxLength(1)]
        public ID VisitProtectionIndicator
        {
            get { return GetValueAt<ID>(21); }
        }
        [Description("Clinic Organization Name")]
        [MaxLength(90)]
        public XON[] ClinicOrganizationName
        {
            get { return GetValuesAt<XON>(22); }
        }
        [Description("Patient Status Code")]
        [MaxLength(2)]
        public IS PatientStatusCode
        {
            get { return GetValueAt<IS>(23); }
        }
        [Description("Visit Priority Code")]
        [MaxLength(1)]
        public IS VisitPriorityCode
        {
            get { return GetValueAt<IS>(24); }
        }


        [Description("Previous Treatment Date")]
        [MaxLength(8)]
        public DT PreviousTreatmentDate
        {
            get { return GetValueAt<DT>(25); }
        }
        [Description("Expected Discharge Disposition")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(DischargeDisposition))]
        public IS ExpectedDischargeDisposition
        {
            get { return GetValueAt<IS>(26); }
        }
        [Description("Signature on File Date")]
        [MaxLength(8)]
        public DT SignatureonFileDate
        {
            get { return GetValueAt<DT>(27); }
        }
        [Description("First Similar Illness Date")]
        [MaxLength(8)]
        public DT FirstSimilarIllnessDate
        {
            get { return GetValueAt<DT>(28); }
        }
        [Description("Patient Charge Adjustment Codee")]
        [MaxLength(3)]
        public IS PatientChargeAdjustmentCode
        {
            get { return GetValueAt<IS>(29); }
        }
        [Description("Recurring Service Code")]
        [MaxLength(2)]
        public IS RecurringServiceCode
        {
            get { return GetValueAt<IS>(30); }
        }
        [Description("Billing Media Code")]
        [MaxLength(1)]
        public ID BillingMediaCode
        {
            get { return GetValueAt<ID>(31); }
        }
        [Description("Expected Surgery Date & Time")]
        [MaxLength(26)]
        public TS ExpectedSurgeryDateTime
        {
            get { return GetValueAt<TS>(32); }
        }
        [Description("Military Partnership Code")]
        [MaxLength(2)]
        public ID MilitaryPartnershipCode
        {
            get { return GetValueAt<ID>(33); }
        }
        [Description("Military Non-Availability Code")]
        [MaxLength(2)]
        public ID MilitaryNonAvailabilityCode
        {
            get { return GetValueAt<ID>(34); }
        }
        [Description("Newborn Baby Indicator")]
        [MaxLength(1)]
        public ID NewbornBabyIndicator
        {
            get { return GetValueAt<ID>(35); }
        }
        [Description("Baby Detained Indicator")]
        [MaxLength(1)]
        public ID BabyDetainedIndicator
        {
            get { return GetValueAt<ID>(36); }
        }
    }
}
