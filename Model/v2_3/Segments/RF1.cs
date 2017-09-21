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
    /// RF1: Referral Information Segment
    /// </summary>
    public class RF1 : ChoHL7Segment
    {
        [Description("Referral Status")]
        [MaxLength(200)]
        public CE ReferralStatus
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Referral Priority")]
        [MaxLength(200)]
        public CE ReferralPriority
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Referral Type")]
        [MaxLength(200)]
        public CE ReferralType
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Referral Disposition")]
        [MaxLength(200)]
        public CE[] ReferralDisposition
        {
            get { return GetValuesAt<CE>(3); }
        }
        [Description("Referral Category")]
        [MaxLength(200)]
        public CE ReferralCategory
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Originating Referral Identifier")]
        [Required]
        [MaxLength(30)]
        public EI OriginatingReferralIdentifier
        {
            get { return GetValueAt<EI>(5); }
        }
        [Description("Effective Date")]
        [MaxLength(12)]
        public TS EffectiveDate
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Expiration Date")]
        [MaxLength(26)]
        public TS ExpirationDate
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Process Date")]
        [MaxLength(26)]
        public TS ProcessDate
        {
            get { return GetValueAt<TS>(8); }
        }
        [Description("Referral Reason")]
        [MaxLength(200)]
        public CE[] ReferralReason
        {
            get { return GetValuesAt<CE>(9); }
        }
        [Description("External Referral Identifier")]
        [MaxLength(30)]
        public EI[] ExternalReferralIdentifier
        {
            get { return GetValuesAt<EI>(10); }
        }
    }
}
