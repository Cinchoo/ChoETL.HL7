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
    /// FT1: Financial transaction
    /// </summary>
    public class FT1 : ChoHL7Segment
    {
        [Description("Set ID - Financial Transaction")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Transaction ID")]
        [MaxLength(12)]
        public ST TransactionID
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Transaction Batch ID")]
        [MaxLength(10)]
        public ST TransactionBatchID
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Transaction Date")]
        [Required]
        [MaxLength(26)]
        public TS TransactionDate
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Transaction Posting Date")]
        [MaxLength(26)]
        public TS TransactionPostingDate
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Transaction Type")]
        [Required]
        [MaxLength(8)]
        [ChoHL7EnumType(typeof(TransactionType))]
        public ID TransactionType
        {
            get { return GetValueAt<ID>(5); }
        }
        [Description("Transaction Code")]
        [Required]
        [MaxLength(80)]
        public CE TransactionCode
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Transaction Description")]
        [MaxLength(40)]
        public ST TransactionDescription
        {
            get { return GetValueAt<ST>(7); }
        }
        [Description("Transaction Description - alternate")]
        [MaxLength(40)]
        public ST AlternateTransactionDescription
        {
            get { return GetValueAt<ST>(8); }
        }
        [Description("Transaction Quantity")]
        [MaxLength(6)]
        public NM TransactionQuantity
        {
            get { return GetValueAt<NM>(9); }
        }
        [Description("Transaction Amount - Extended")]
        [MaxLength(12)]
        public CP ExtendedTransactionAmount
        {
            get { return GetValueAt<CP>(10); }
        }
        [Description("Transaction Amount - Unit")]
        [MaxLength(12)]
        public CP TransactionAmountUnit
        {
            get { return GetValueAt<CP>(11); }
        }

        [Description("Department Code")]
        [MaxLength(60)]
        public CE DepartmentCode
        {
            get { return GetValueAt<CE>(12); }
        }
        [Description("Insurance Plan ID")]
        [MaxLength(8)]
        public CE InsurancePlanID
        {
            get { return GetValueAt<CE>(13); }
        }
        [Description("Insurance Amount")]
        [MaxLength(12)]
        public CP InsuranceAmount
        {
            get { return GetValueAt<CP>(14); }
        }
        [Description("Assigned Patient Location")]
        [MaxLength(12)]
        public PL AssignedPatientLocation
        {
            get { return GetValueAt<PL>(15); }
        }
        [Description("Fee Schedule")]
        [MaxLength(1)]
        public ID FeeSchedule
        {
            get { return GetValueAt<ID>(16); }
        }
        [Description("Patient Type")]
        [MaxLength(2)]
        public ID PatientType
        {
            get { return GetValueAt<ID>(17); }
        }
        [Description("Diagnosis Code")]
        [MaxLength(60)]
        public CE[] DiagnosisCode
        {
            get { return GetValuesAt<CE>(18); }
        }
        [Description("Performed By Code")]
        [MaxLength(120)]
        public XCN PerformedByCode
        {
            get { return GetValueAt<XCN>(19); }
        }
        [Description("Ordered By Code")]
        [MaxLength(120)]
        public XCN OrderedByCode
        {
            get { return GetValueAt<XCN>(20); }
        }
        [Description("Unit Cost")]
        [MaxLength(12)]
        public NM UnitCost
        {
            get { return GetValueAt<NM>(21); }
        }
        [Description("Filler Order Number")]
        [MaxLength(22)]
        public EI FillerOrderNumber
        {
            get { return GetValueAt<EI>(22); }
        }
        [Description("Entered By Code")]
        [MaxLength(120)]
        public XCN EnteredByCode
        {
            get { return GetValueAt<XCN>(23); }
        }
        [Description("Procedure Code")]
        [MaxLength(80)]
        public CE ProcedureCode
        {
            get { return GetValueAt<CE>(24); }
        }
    }
}
