using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// XON: Extended Composite Name And ID For Organizations
    /// </summary>
    [Description("XON: Extended Composite Name And ID For Organizations")]
    public class XON : ChoHL7AbstractField
    {
        public ST OrganizationName
        {
            get { return GetValueAt<ST>(0); }
        }
        public IS OrganizationNameTypeCode
        {
            get { return GetValueAt<IS>(1); }
        }
        public NM IDNumber
        {
            get { return GetValueAt<NM>(2); }
        }
        public ST CheckDigit
        {
            get { return GetValueAt<ST>(3); }
        }
        public ST CheckDigitSchemeEmployedCode
        {
            get { return GetValueAt<ST>(4); }
        }
        public HD AssigningAuthority
        {
            get { return GetValueAt<HD>(5); }
        }
        public IS IdentifierTypeCode
        {
            get { return GetValueAt<IS>(6); }
        }
        public HD AssigningFacilityID
        {
            get { return GetValueAt<HD>(7); }
        }

        public XON(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public XON(ChoHL7Field field) : base(field)
        {
        }
    }
}
