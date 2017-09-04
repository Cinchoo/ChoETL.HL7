using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// XAD: Extended Address
    /// </summary>
    [Description("XAD: Extended Address")]
    public class XAD : ChoHL7AbstractField
    {
        public ST StreetAddress
        {
            get { return GetDefaultOrValueAt<ST>(0); }
        }
        public ST OtherDesignation
        {
            get { return GetValueAt<ST>(1); }
        }
        public ST City
        {
            get { return GetValueAt<ST>(2); }
        }
        public ST State
        {
            get { return GetValueAt<ST>(3); }
        }
        public ST ZipCode
        {
            get { return GetValueAt<ST>(4); }
        }
        public ID Country
        {
            get { return GetValueAt<ID>(5); }
        }
        public ID AddressType
        {
            get { return GetValueAt<ID>(6); }
        }
        public ST OtherGeographicDesignation
        {
            get { return GetValueAt<ST>(7); }
        }
        public IS CountyCode
        {
            get { return GetValueAt<IS>(8); }
        }
        public IS CensusTract
        {
            get { return GetValueAt<IS>(9); }
        }

        public XAD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public XAD(ChoHL7Field field) : base(field)
        {
        }
    }
}
