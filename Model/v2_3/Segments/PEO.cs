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
    /// PEO: Product Experience Observation
    /// </summary>
    public class PEO : ChoHL7Segment
    {
        [Description("Event Identifiers Used")]
        [MaxLength(60)]
        public CE[] EventIdentifiersUsed
        {
            get { return GetValuesAt<CE>(0); }
        }
        [Description("Event Symptom/Diagnosis Code")]
        [MaxLength(60)]
        public CE[] EventSymptomDiagnosisCode
        {
            get { return GetValuesAt<CE>(1); }
        }
        [Description("Event Onset Date/Time")]
        [Required]
        [MaxLength(26)]
        public TS EventOnsetDateTime
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("Event Exacerbation Date/Time")]
        [MaxLength(26)]
        public TS EventExacerbationDateTime
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Event Improved Date/Time")]
        [MaxLength(26)]
        public TS EventImprovedDateTime
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Event Ended Data/Time")]
        [MaxLength(26)]
        public TS EventEndedDataTime
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Event Location Occurred Address")]
        [MaxLength(106)]
        public XAD EventLocationOccurredAddress
        {
            get { return GetValueAt<XAD>(6); }
        }
        [Description("Event Qualification")]
        [MaxLength(1)]
        public ID[] EventQualification
        {
            get { return GetValuesAt<ID>(7); }
        }
        [Description("Event Serious")]
        [MaxLength(1)]
        public ID EventSerious
        {
            get { return GetValueAt<ID>(8); }
        }
        [Description("Event Expected")]
        [MaxLength(1)]
        public ID EventExpected
        {
            get { return GetValueAt<ID>(9); }
        }
        [Description("Event Outcome")]
        [MaxLength(1)]
        public ID[] EventOutcome
        {
            get { return GetValuesAt<ID>(10); }
        }
        [Description("Patient Outcome")]
        [MaxLength(1)]
        public ID PatientOutcome
        {
            get { return GetValueAt<ID>(11); }
        }
        [Description("Event Description From Others")]
        [MaxLength(600)]
        public FT[] EventDescriptionFromOthers
        {
            get { return GetValuesAt<FT>(12); }
        }
        [Description("Event From Original Reporter")]
        [MaxLength(600)]
        public FT[] EventFromOriginalReporter
        {
            get { return GetValuesAt<FT>(13); }
        }
        [Description("Event Description From Patient")]
        [MaxLength(600)]
        public FT[] ProductEvaluationStatus
        {
            get { return GetValuesAt<FT>(14); }
        }
        [Description("Event Description From Practitioner")]
        [MaxLength(600)]
        public FT[] EventDescriptionFromPractitioner
        {
            get { return GetValuesAt<FT>(15); }
        }
        [Description("Event Description From Autopsy")]
        [MaxLength(600)]
        public FT[] EventDescriptionFromAutopsy
        {
            get { return GetValuesAt<FT>(16); }
        }
        [Description("Cause Of Death")]
        [MaxLength(30)]
        public CE[] CauseOfDeath
        {
            get { return GetValuesAt<CE>(17); }
        }
        [Description("Primary Observer Name")]
        [MaxLength(46)]
        public XPN PrimaryObserverName
        {
            get { return GetValueAt<XPN>(18); }
        }
        [Description("Primary Observer Address")]
        [MaxLength(106)]
        public XAD[] PrimaryObserverAddress
        {
            get { return GetValuesAt<XAD>(19); }
        }
        [Description("Primary Observer Telephone")]
        [MaxLength(40)]
        public XTN[] PrimaryObserverTelephone
        {
            get { return GetValuesAt<XTN>(20); }
        }
        [Description("Primary Observer's Qualification")]
        [MaxLength(1)]
        public ID PrimaryObserversQualification
        {
            get { return GetValueAt<ID>(21); }
        }
        [Description("Confirmation Provided By")]
        [MaxLength(1)]
        public ID ConfirmationProvidedBy
        {
            get { return GetValueAt<ID>(22); }
        }
        [Description("Primary Observer Aware Date/Time")]
        [MaxLength(26)]
        public TS PrimaryObserverAwareDateTime
        {
            get { return GetValueAt<TS>(23); }
        }
        [Description("Primary Observer's Identity May Be Divulged")]
        [MaxLength(1)]
        public ID PrimaryObserversIdentityMayBeDivulged
        {
            get { return GetValueAt<ID>(24); }
        }
    }
}
