using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_LA1: Location With Address Information")]
    public class CM_LA1 : ChoHL7AbstractField
    {
        public ST PointOfCare
        {
            get { return GetValueAt<ST>(0); }
        }
        public IS Room
        {
            get { return GetValueAt<IS>(1); }
        }
        public IS Bed
        {
            get { return GetValueAt<IS>(2); }
        }
        public HD Facility
        {
            get { return GetValueAt<HD>(3); }
        }
        public IS LocationStatus
        {
            get { return GetValueAt<IS>(4); }
        }
        public IS PersonLocationType
        {
            get { return GetValueAt<IS>(5); }
        }
        public IS Building
        {
            get { return GetValueAt<IS>(6); }
        }
        public ST Floor
        {
            get { return GetValueAt<ST>(7); }
        }
        public ST StreetAddress
        {
            get { return GetValueAt<ST>(8); }
        }
        public ST OtherDesignation
        {
            get { return GetValueAt<ST>(9); }
        }
        public ST City
        {
            get { return GetValueAt<ST>(10); }
        }
        public ST State
        {
            get { return GetValueAt<ST>(11); }
        }
        public ST Zip
        {
            get { return GetValueAt<ST>(12); }
        }
        public ID Country
        {
            get { return GetValueAt<ID>(13); }
        }
        public ID AddressType
        {
            get { return GetValueAt<ID>(14); }
        }
        public ST OtherGeographicDesignation
        {
            get { return GetValueAt<ST>(15); }
        }

        public CM_LA1(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_LA1(ChoHL7Field field) : base(field)
        {
        }
    }
}
