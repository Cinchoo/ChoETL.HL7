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
    /// CSR: Clinical Study Registration
    /// </summary>
    public class CSR : ChoHL7Segment
    {
        [Description("Sponsor Study ID")]
        [Required]
        [MaxLength(60)]
        public EI SponsorStudyID
        {
            get { return GetValueAt<EI>(0); }
        }
        [Description("Alternate Study ID")]
        [MaxLength(60)]
        public EI AlternateStudyID
        {
            get { return GetValueAt<EI>(1); }
        }
        [Description("Institution Registering the Patient")]
        [MaxLength(60)]
        public CE InstitutionRegisteringThePatient
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Sponsor Patient ID")]
        [Required]
        [MaxLength(30)]
        public CX SponsorPatientID
        {
            get { return GetValueAt<CX>(3); }
        }
        [Description("Alternate Patient ID")]
        [MaxLength(30)]
        public CX AlternatePatientID
        {
            get { return GetValueAt<CX>(4); }
        }
        [Description("Date/Time of Patient Study Registration")]
        [MaxLength(26)]
        public TS DateTimeofPatientStudyRegistration
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Person Performing Study Registration")]
        [MaxLength(60)]
        public XCN PersonPerformingStudyRegistration
        {
            get { return GetValueAt<XCN>(6); }
        }
        [Description("Study Authorizing Provider")]
        [Required]
        [MaxLength(60)]
        public XCN StudyAuthorizingProvider
        {
            get { return GetValueAt<XCN>(7); }
        }
        [Description("Date/time Patient Study Consent Signed")]
        [MaxLength(26)]
        public TS DateTimePatientStudyConsentSigned
        {
            get { return GetValueAt<TS>(8); }
        }
        [Description("Patient Study Eligibility Status")]
        [MaxLength(60)]
        public CE PatientStudyEligibilityStatus
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Study Randomization Date/time")]
        [MaxLength(26)]
        public TS[] StudyRandomizationDateTime
        {
            get { return GetValuesAt<TS>(10); }
        }
        [Description("Study Randomized Arm")]
        [MaxLength(200)]
        public CE[] StudyRandomizedArm
        {
            get { return GetValuesAt<CE>(11); }
        }
        [Description("Stratum for Study Randomization")]
        [MaxLength(200)]
        public CE[] StratumForStudyRandomization
        {
            get { return GetValuesAt<CE>(12); }
        }
        [Description("Patient Evaluability Status")]
        [MaxLength(60)]
        public CE PatientEvaluabilityStatus
        {
            get { return GetValueAt<CE>(13); }
        }
        [Description("Date/time Ended Study")]
        [MaxLength(26)]
        public TS DateTimeEndedStudy
        {
            get { return GetValueAt<TS>(14); }
        }
        [Description("Reason Ended Study")]
        [MaxLength(60)]
        public CE ReasonEndedStudy
        {
            get { return GetValueAt<CE>(15); }
        }
    }
}
