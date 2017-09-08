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
    /// FAC: Facility
    /// </summary>
    public class FAC : ChoHL7Segment
    {
        [Description("Facility ID")]
        [Required]
        [MaxLength(60)]
        public EI[] FacilityID
        {
            get { return GetValuesAt<EI>(0); }
        }
        [Description("Facility Type")]
        [MaxLength(1)]
        public ID FacilityType
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Facility Address")]
        [Required]
        [MaxLength(200)]
        public XAD FacilityAddress
        {
            get { return GetValueAt<XAD>(2); }
        }
        [Description("Facility Telecommunication")]
        [Required]
        [MaxLength(44)]
        public XTN FacilityTelecommunication
        {
            get { return GetValueAt<XTN>(3); }
        }
        [Description("Operator ID")]
        [MaxLength(60)]
        public XCN[] ContactPerson
        {
            get { return GetValuesAt<XCN>(4); }
        }
        [Description("Contact Title")]
        [MaxLength(60)]
        public ST[] ContactTitle
        {
            get { return GetValuesAt<ST>(5); }
        }
        [Description("Contact Address")]
        [MaxLength(60)]
        public XAD[] ContactAddress
        {
            get { return GetValuesAt<XAD>(6); }
        }
        [Description("Contact Telecommunication")]
        [MaxLength(44)]
        public XTN[] ContactTelecommunication
        {
            get { return GetValuesAt<XTN>(7); }
        }
        [Description("Signature Authority")]
        [Required]
        [MaxLength(60)]
        public XCN SignatureAuthority
        {
            get { return GetValueAt<XCN>(8); }
        }
        [Description("Signature Authority Title")]
        [MaxLength(60)]
        public ST SignatureAuthorityTitle
        {
            get { return GetValueAt<ST>(9); }
        }
        [Description("Signature Authority Address")]
        [MaxLength(200)]
        public XAD SignatureAuthorityAddress
        {
            get { return GetValueAt<XAD>(10); }
        }
        [Description("Signature Authority Telecommunication")]
        [MaxLength(44)]
        public XTN SignatureAuthorityTelecommunication
        {
            get { return GetValueAt<XTN>(11); }
        }
    }
}
