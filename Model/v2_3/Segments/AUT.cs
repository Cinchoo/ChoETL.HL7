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
    /// AUT: Authorization Information
    /// </summary>
    public class AUT : ChoHL7Segment
    {
        [Description("Authorizing Payer, Plan Code")]
        [MaxLength(200)]
        public CE AuthorizingPayerPlanCode
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Authorizing Payer, Company ID")]
        [Required]
        [MaxLength(200)]
        public CE AuthorizingPayerCompanyID
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Authorizing Payer, Company Name")]
        [MaxLength(45)]
        public ST AuthorizingPayerCompanyName
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Authorization Effective Date")]
        [MaxLength(26)]
        public TS AuthorizationEffectiveDate
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Authorization Expiration Date")]
        [MaxLength(26)]
        public TS AuthorizationExpirationDate
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Authorization Identifier")]
        [MaxLength(30)]
        public EI AuthorizationIdentifier
        {
            get { return GetValueAt<EI>(5); }
        }
        [Description("Reimbursement Limit")]
        [MaxLength(25)]
        public CP ReimbursementLimit
        {
            get { return GetValueAt<CP>(6); }
        }
        [Description("Requested Number of Treatments")]
        [MaxLength(2)]
        public NM RequestedNumberofTreatments
        {
            get { return GetValueAt<NM>(7); }
        }
        [Description("Authorized Number of Treatments")]
        [MaxLength(2)]
        public NM AuthorizedNumberofTreatments
        {
            get { return GetValueAt<NM>(8); }
        }
        [Description("Process Date")]
        [MaxLength(26)]
        public TS ProcessDate
        {
            get { return GetValueAt<TS>(9); }
        }
    }
}
