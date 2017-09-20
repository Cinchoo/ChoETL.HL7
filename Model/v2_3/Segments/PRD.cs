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
    /// PRD: Provider Data
    /// </summary>
    public class PRD : ChoHL7Segment
    {
        [Description("Role")]
        [Required]
        [MaxLength(200)]
        public CE Role
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Provider Name")]
        [MaxLength(106)]
        public XPN[] ProviderName
        {
            get { return GetValuesAt<XPN>(1); }
        }
        [Description("Provider Address")]
        [MaxLength(60)]
        public XAD ProviderAddress
        {
            get { return GetValueAt<XAD>(2); }
        }
        [Description("Provider Location")]
        [MaxLength(60)]
        public PL ProviderLocation
        {
            get { return GetValueAt<PL>(3); }
        }
        [Description("Provider Communication Information")]
        [MaxLength(20)]
        public XTN[] ProviderCommunicationInformation
        {
            get { return GetValuesAt<XTN>(4); }
        }
        [Description("Preferred Method of Contact")]
        [MaxLength(200)]
        public CE PreferredMethodofContact
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Provider Identifiers")]
        [MaxLength(100)]
        public CM_PI[] ProviderIdentifiers
        {
            get { return GetValuesAt<CM_PI>(6); }
        }
        [Description("Effective Start Date of Role")]
        [MaxLength(26)]
        public TS EffectiveStartDateofRole
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Effective End Date of Role")]
        [MaxLength(26)]
        public TS EffectiveEndDateofRole
        {
            get { return GetValueAt<TS>(8); }
        }
    }
}
