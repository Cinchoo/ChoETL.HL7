using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// XCN: Extended Composite ID Number And Name
    /// </summary>
    [Description("XCN: Extended Composite ID Number And Name")]
    public class XCN : ChoHL7AbstractField
    {
        public ID ID
        {
            get { return GetValueAt<ID>(0); }
        }
        public ST FamilyName
        {
            get { return GetValueAt<ST>(1); }
        }
        public ST GivenName
        {
            get { return GetValueAt<ST>(2); }
        }
        public ST MiddleInitial
        {
            get { return GetValueAt<ST>(3); }
        }
        public ST Suffix
        {
            get { return GetValueAt<ST>(4); }
        }
        public ST Prefix
        {
            get { return GetValueAt<ST>(5); }
        }
        public ST Degree
        {
            get { return GetValueAt<ST>(6); }
        }
        public ID SourceTable
        {
            get { return GetValueAt<ID>(7); }
        }
        public HD AssigningAuthority
        {
            get { return GetValueAt<HD>(8); }
        }
        public ID NameType
        {
            get { return GetValueAt<ID>(9); }
        }
        public ST IdentifierCheckDigit
        {
            get { return GetValueAt<ST>(10); }
        }
        public ST CheckDigitSchemeEmployedCode
        {
            get { return GetValueAt<ST>(11); }
        }
        public IS IdentifierTypeCode
        {
            get { return GetValueAt<IS>(12); }
        }
        public HD AssigningFacilityID
        {
            get { return GetValueAt<HD>(13); }
        }

        public XCN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public XCN(ChoHL7Field field) : base(field)
        {
        }
    }
}
