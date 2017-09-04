using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// XTN: Extended Telecommunication Number
    /// </summary>
    [Description("XTN: Extended Telecommunication Number")]
    public class XTN : ChoHL7AbstractField
    {
        public TN TelephoneNumber
        {
            get { return GetDefaultOrValueAt<TN>(0); }
        }
        public ID TelecommunicationUseCode
        {
            get { return GetValueAt<ID>(1); }
        }
        public ID TelecommunicationEquipmentCode
        {
            get { return GetValueAt<ID>(2); }
        }
        public ST EMailAddress
        {
            get { return GetValueAt<ST>(3); }
        }
        public NM CountryCode
        {
            get { return GetValueAt<NM>(4); }
        }
        public NM AreaCode
        {
            get { return GetValueAt<NM>(5); }
        }
        public NM PhoneNumber
        {
            get { return GetValueAt<NM>(6); }
        }
        public NM Extension
        {
            get { return GetValueAt<NM>(7); }
        }
        public ST AnyText
        {
            get { return GetValueAt<ST>(8); }
        }

        public XTN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public XTN(ChoHL7Field field) : base(field)
        {
        }
    }
}
