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
    /// DRG: Diagnosis Related Group
    /// </summary>
    public class DRG : ChoHL7Segment
    {
        [Description("Diagnostic Related Group")]
        [MaxLength(4)]
        public CE DiagnosticRelatedGroup
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("DRG Assigned Date/Time")]
        [MaxLength(26)]
        public TS DRGAssignedDateTime
        {
            get { return GetValueAt<TS>(1); }
        }
        [Description("DRG Approval Indicator")]
        [MaxLength(2)]
        public ID DRGApprovalIndicator
        {
            get { return GetValueAt<ID>(2); }
        }
        [Description("DRG Grouper Review Code")]
        [MaxLength(2)]
        public IS DRGGrouperReviewCode
        {
            get { return GetValueAt<IS>(3); }
        }
        [Description("Outlier Type")]
        [MaxLength(60)]
        public CE OutlierType
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Outlier Days")]
        [MaxLength(3)]
        public NM OutlierDays
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Outlier Cost")]
        [MaxLength(12)]
        public CP OutlierCost
        {
            get { return GetValueAt<CP>(6); }
        }
        [Description("DRG Payor")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(DRGPayor))]
        public IS DRGPayor
        {
            get { return GetValueAt<IS>(7); }
        }
        [Description("Outlier Reimbursement")]
        [MaxLength(9)]
        public CP OutlierReimbursement
        {
            get { return GetValueAt<CP>(8); }
        }
        [Description("Confidential Indicator")]
        [MaxLength(1)]
        public ID ConfidentialIndicator
        {
            get { return GetValueAt<ID>(9); }
        }
    }
}
