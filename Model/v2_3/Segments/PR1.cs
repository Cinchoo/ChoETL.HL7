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
    /// PR1: Procedures
    /// </summary>
    public class PR1 : ChoHL7Segment
    {
        [Description("ID")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Procedure Coding Method")]
        [Required]
        [MaxLength(2)]
        public SI ProcedureCodingMethod
        {
            get { return GetValueAt<SI>(1); }
        }
        [Description("Procedure Code")]
        [MaxLength(80)]
        public CE ProcedureCode
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Procedure Description")]
        [Required]
        [MaxLength(40)]
        public ST ProcedureDescription
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Procedure Date/Time")]
        [MaxLength(26)]
        public TS ProcedureDateTime
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Procedure Type")]
        [Required]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(ProcedureType))]
        public ID ProcedureType
        {
            get { return GetValueAt<ID>(5); }
        }
        [Description("Procedure Minutes")]
        [MaxLength(4)]
        public NM ProcedureMinutes
        {
            get { return GetValueAt<NM>(6); }
        }
        [Description("Anesthesiologist")]
        [MaxLength(120)]
        public XCN[] Anesthesiologist
        {
            get { return GetValuesAt<XCN>(7); }
        }
        [Description("Anesthesia Code")]
        [MaxLength(2)]
        public IS AnesthesiaCode
        {
            get { return GetValueAt<IS>(8); }
        }
        [Description("Anesthesia Minutes")]
        [MaxLength(4)]
        public NM AnesthesiaMinutes
        {
            get { return GetValueAt<NM>(9); }
        }
        [Description("Surgeon")]
        [MaxLength(120)]
        public XCN[] Surgeon
        {
            get { return GetValuesAt<XCN>(10); }
        }
        [Description("Procedure Practitioner")]
        [MaxLength(230)]
        public XCN[] ProcedurePractitioner
        {
            get { return GetValuesAt<XCN>(11); }
        }
        [Description("Consent Code")]
        [MaxLength(60)]
        public CE ConsentCode
        {
            get { return GetValueAt<CE>(12); }
        }
        [Description("Procedure Priority")]
        [MaxLength(2)]
        public NM ProcedurePriority
        {
            get { return GetValueAt<NM>(13); }
        }
        [Description("Associated Diagnosis Code")]
        [MaxLength(80)]
        public CE AssociatedDiagnosisCode
        {
            get { return GetValueAt<CE>(14); }
        }
    }
}
