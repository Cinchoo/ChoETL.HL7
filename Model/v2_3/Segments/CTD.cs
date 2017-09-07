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
    /// CTD: Contact Data
    /// </summary>
    public class CTD : ChoHL7Segment
    {
        [Description("Contact Role")]
        [Required]
        [MaxLength(60)]
        public CE[] ContactRole
        {
            get { return GetValuesAt<CE>(0); }
        }
        [Description("Contact Name")]
        [MaxLength(106)]
        public XPN[] ContactName
        {
            get { return GetValuesAt<XPN>(1); }
        }
        [Description("Contact Address")]
        [MaxLength(60)]
        public XAD[] ContactAddress
        {
            get { return GetValuesAt<XAD>(2); }
        }
        [Description("Contact Location")]
        [MaxLength(60)]
        public PL ContactLocation
        {
            get { return GetValueAt<PL>(3); }
        }
        [Description("Contact Communication Information")]
        [MaxLength(20)]
        public XTN[] ContactCommunicationInformation
        {
            get { return GetValuesAt<XTN>(4); }
        }
        [Description("Preferred Method of Contact")]
        [MaxLength(200)]
        public CE PreferredMethodofContact
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Contact Identifiers")]
        [MaxLength(100)]
        public CM_PI ContactIdentifiers
        {
            get { return GetValueAt<CM_PI>(6); }
        }
    }
}
