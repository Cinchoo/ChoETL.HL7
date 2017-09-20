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
    /// OM1: General - fields that apply to most observations
    /// </summary>
    public class OM1 : ChoHL7Segment
    {
        [Description("Sequence Number - Test/ Observation Master File")]
        [MaxLength(4)]
        public NM SequenceNumber
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("Producer's Test/Observation ID")]
        [Required]
        [MaxLength(200)]
        public CE ObservationID
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Permitted Data Types")]
        [MaxLength(12)]
        public ID[] PermittedDataTypes
        {
            get { return GetValuesAt<ID>(2); }
        }
        [Description("Address")]
        [Required]
        [MaxLength(1)]
        public ID SpecimenRequired
        {
            get { return GetValueAt<ID>(3); }
        }
        [Description("Producer ID")]
        [Required]
        [MaxLength(200)]
        public CE ProducerID
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Observation Description")]
        [MaxLength(200)]
        public CE ObservationDescription
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Other Test/Observation IDs for the Observation")]
        [MaxLength(200)]
        public CE OtherTestObservationIDs
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Other Names")]
        [MaxLength(200)]
        [Required]
        public ST[] OtherNames
        {
            get { return GetValuesAt<ST>(7); }
        }
        [Description("Preferred Report Name for the Observation")]
        [MaxLength(30)]
        public ST PreferredReportName
        {
            get { return GetValueAt<ST>(8); }
        }
        [Description("Preferred Short Name or Mnemonic for Observation")]
        [MaxLength(8)]
        public ST PreferredShortName
        {
            get { return GetValueAt<ST>(9); }
        }
        [Description("Preferred Long Name for the Observation")]
        [MaxLength(200)]
        public ST PreferredLongName
        {
            get { return GetValueAt<ST>(10); }
        }
        [Description("Orderability")]
        [MaxLength(1)]
        public ID Orderability
        {
            get { return GetValueAt<ID>(11); }
        }
        [Description("Identity of Instrument Used to Perform this Study")]
        [MaxLength(60)]
        public CE[] IdentityofInstrumentUsedtoPerformthisStudy
        {
            get { return GetValuesAt<CE>(12); }
        }
        [Description("Coded Representation of Method")]
        [MaxLength(200)]
        public CE CodedRepresentationofMethod
        {
            get { return GetValueAt<CE>(13); }
        }
        [Description("Portable")]
        [MaxLength(1)]
        public ID Portable
        {
            get { return GetValueAt<ID>(14); }
        }
        [Description("Observation Producing Department/Section")]
        [MaxLength(26)]
        public CE[] ObservationProducingDepartment
        {
            get { return GetValuesAt<CE>(15); }
        }
        [Description("Telephone Number of Section")]
        [MaxLength(40)]
        public TN TelephoneNumberofSection
        {
            get { return GetValueAt<TN>(16); }
        }
        [Description("Nature of Test/Observation")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(NatureOfTestObservation))]
        public ID NatureofTest
        {
            get { return GetValueAt<ID>(17); }
        }
        [Description("Report Subheader")]
        [MaxLength(200)]
        public CE ReportSubheader
        {
            get { return GetValueAt<CE>(18); }
        }
        [Description("Report Display Order")]
        [MaxLength(20)]
        public ST ReportDisplayOrder
        {
            get { return GetValueAt<ST>(19); }
        }
        [Description("Date/Time Stamp for any change in Def Attri for Obs")]
        [MaxLength(26)]
        public TS DateTimeStampforanychange
        {
            get { return GetValueAt<TS>(20); }
        }
        [Description("Effective Date/Time of Change in Test Proc. that make Results Non-Comparable")]
        [MaxLength(26)]
        public TS EffectiveDateTimeStampforanychange
        {
            get { return GetValueAt<TS>(21); }
        }
        [Description("Typical Turn-Around Time")]
        [MaxLength(20)]
        public NM TypicalTurnAroundTime
        {
            get { return GetValueAt<NM>(22); }
        }
        [Description("Processing Time")]
        [MaxLength(20)]
        public NM ProcessingTime
        {
            get { return GetValueAt<NM>(23); }
        }
        [Description("Processing Priority")]
        [MaxLength(40)]
        public ID[] ProcessingPriority
        {
            get { return GetValuesAt<ID>(24); }
        }
        [Description("Reporting Priority")]
        [MaxLength(5)]
        public ID ReportingPriority
        {
            get { return GetValueAt<ID>(25); }
        }
        [Description("Outside Site")]
        [MaxLength(200)]
        public CE[] OutsideSite
        {
            get { return GetValuesAt<CE>(26); }
        }
        [Description("Address of Outside Site")]
        [MaxLength(1000)]
        public AD AddressofOutsideSite
        {
            get { return GetValueAt<AD>(27); }
        }
        [Description("Phone Number of Outside Site")]
        [MaxLength(400)]
        public TN PhoneNumberofOutsideSite
        {
            get { return GetValueAt<TN>(28); }
        }
        [Description("Confidentiality Code")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(ConfidentialityCode))]
        public ID ConfidentialityCode
        {
            get { return GetValueAt<ID>(29); }
        }
        [Description("Observations Required to Interpret the Observation")]
        [MaxLength(200)]
        public CE ObservationsRequiredtoInterprettheObservation
        {
            get { return GetValueAt<CE>(30); }
        }
        [Description("Interpretation of Observations")]
        [MaxLength(65536)]
        public TX InterpretationofObservations
        {
            get { return GetValueAt<TX>(31); }
        }
        [Description("Contraindications to Observations")]
        [MaxLength(65536)]
        public CX ContraindicationstoObservations
        {
            get { return GetValueAt<CX>(32); }
        }
        [Description("Reflex Tests/Observations")]
        [MaxLength(200)]
        public CE[] ReflexTests
        {
            get { return GetValuesAt<CE>(33); }
        }
        [Description("Rules that Trigger Reflex Testing")]
        [MaxLength(80)]
        public ST RulesthatTriggerReflexTesting
        {
            get { return GetValueAt<ST>(34); }
        }
        [Description("Fixed Canned Message")]
        [MaxLength(65536)]
        public CE FixedCannedMessage
        {
            get { return GetValueAt<CE>(35); }
        }
        [Description("Patient Preparation")]
        [MaxLength(200)]
        public TX PatientPreparation
        {
            get { return GetValueAt<TX>(36); }
        }

        [Description("Procedure Medication")]
        [MaxLength(200)]
        public CE ProcedureMedication
        {
            get { return GetValueAt<CE>(37); }
        }
        [Description("Factors that may Effect the Observation")]
        [MaxLength(200)]
        public TX FactorsthatmayEffecttheObservation
        {
            get { return GetValueAt<TX>(38); }
        }
        [Description("Test/Observation Performance Schedule")]
        [MaxLength(60)]
        public ST[] ObservationPerformanceSchedule
        {
            get { return GetValuesAt<ST>(39); }
        }
        [Description("Description of Test Methods")]
        [MaxLength(65536)]
        public TX DescriptionofTestMethods
        {
            get { return GetValueAt<TX>(40); }
        }
        [Description("Kind of Quantity Observed")]
        [MaxLength(60)]
        public CE KindofQuantityObserved
        {
            get { return GetValueAt<CE>(41); }
        }
        [Description("Point versus Interval")]
        [MaxLength(60)]
        public CE PointversusInterval
        {
            get { return GetValueAt<CE>(42); }
        }
        [Description("Challenge information")]
        [MaxLength(200)]
        public TX Challengeinformation
        {
            get { return GetValueAt<TX>(43); }
        }
        [Description("Relationship modifier")]
        [MaxLength(200)]
        public CE RelationshipModifier
        {
            get { return GetValueAt<CE>(44); }
        }
        [Description("Target anatomic site of test")]
        [MaxLength(200)]
        public CE TargetAnatomicSiteofTest
        {
            get { return GetValueAt<CE>(45); }
        }
        [Description("Modality of imaging measurement")]
        [MaxLength(200)]
        public CE ModalityofImagingMeasurement
        {
            get { return GetValueAt<CE>(46); }
        }

    }
}
