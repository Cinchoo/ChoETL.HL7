using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// XPN: Coded Element
    /// </summary>
    [Description("XPN: Coded Element")]
    public class XPN : ChoHL7AbstractField
    {
        public ST FamilyName
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST GivenName
        {
            get { return HasValueAt(1) ? GetValueAt<ST>(1) : GetDefaultValue<ST>(); }
        }
        public ST MiddleInitial
        {
            get { return GetValueAt<ST>(2); }
        }
        public ST Suffix
        {
            get { return GetValueAt<ST>(3); }
        }
        public ST Prefix
        {
            get { return GetValueAt<ST>(4); }
        }
        public ID NameTypeCode
        {
            get { return GetValueAt<ID>(5); }
        }
        public ID NameRepresentationCode
        {
            get { return GetValueAt<ID>(6); }
        }

        public XPN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public XPN(ChoHL7Field field) : base(field)
        {
        }
    }
}
