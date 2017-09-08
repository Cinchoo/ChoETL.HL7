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
    /// DG1: Diagnosis
    /// </summary>
    public class DG1 : ChoHL7Segment
    {
        [Description("Set ID - Diagnosis")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Diagnosis Coding Method")]
        [MaxLength(2)]
        public ID DiagnosisCodingMethod
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Diagnosis Code")]
        [MaxLength(60)]
        public CX DiagnosisCode
        {
            get { return GetValueAt<CX>(2); }
        }
        [Description("Diagnosis Description")]
        [MaxLength(40)]
        public ST DiagnosisDescription
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Diagnosis Date/Time")]
        [MaxLength(26)]
        public TS DiagnosisDateTime
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Diagnosis Type")]
        [Required]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(DiagnosisType))]
        public IS DiagnosisType
        {
            get { return GetValueAt<IS>(5); }
        }
        [Description("Major Diagnostic Category")]
        [MaxLength(60)]
        public CE MajorDiagnosticCategory
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Diagnostic Related Group")]
        [MaxLength(60)]
        public CE DiagnosticRelatedGroup
        {
            get { return GetValueAt<CE>(7); }
        }
        [Description("DRG Approval Indicator")]
        [MaxLength(2)]
        public ID DRGApprovalIndicator
        {
            get { return GetValueAt<ID>(8); }
        }
        [Description("DRG Grouper Review Code")]
        [MaxLength(2)]
        public IS DRGGrouperReviewCode
        {
            get { return GetValueAt<IS>(9); }
        }
        [Description("Outlier Type")]
        [MaxLength(60)]
        [ChoHL7EnumType(typeof(OutlierType))]
        public CE OutlierType
        {
            get { return GetValueAt<CE>(10); }
        }
        [Description("Outlier Days")]
        [MaxLength(3)]
        public NM OutlierDays
        {
            get { return GetValueAt<NM>(11); }
        }
        [Description("Outlier Cost")]
        [MaxLength(12)]
        public CP OutlierCost
        {
            get { return GetValueAt<CP>(12); }
        }
        [Description("Grouper Version and Type")]
        [MaxLength(4)]
        public ST GrouperVersionAndType
        {
            get { return GetValueAt<ST>(13); }
        }
        [Description("Diagnosis Priority")]
        [MaxLength(2)]
        public NM DiagnosisPriority
        {
            get { return GetValueAt<NM>(14); }
        }
        [Description("Diagnosing Clinician")]
        [MaxLength(60)]
        public XCN[] DiagnosingClinician
        {
            get { return GetValuesAt<XCN>(15); }
        }
        [Description("Diagnosis Classification")]
        [MaxLength(3)]
        [ChoHL7EnumType(typeof(DiagnosisClassification))]
        public IS DiagnosisClassification
        {
            get { return GetValueAt<IS>(16); }
        }
        [Description("Confidential Indicator")]
        [MaxLength(1)]
        public ID ConfidentialIndicator
        {
            get { return GetValueAt<ID>(17); }
        }
        [Description("Attestation Date/Time")]
        [MaxLength(26)]
        public TS AttestationDateTime
        {
            get { return GetValueAt<TS>(18); }
        }
    }
}
