using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// AD: Address
    /// </summary>
    [Description("AD: Address")]
    public class AD : ChoHL7AbstractField
    {
        public ST StreetAddress
        {
            get { return GetValueAt<ST>(0); }
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
        public ST Zip
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

        public AD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public AD(ChoHL7Field field) : base(field)
        {
        }
    }
}
