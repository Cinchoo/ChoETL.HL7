using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_RFR: Reference Range")]
    public class CM_RFR : ChoHL7AbstractField
    {
        public CM_RANGE ReferenceRange
        {
            get { return GetValueAt<CM_RANGE>(0); }
        }
        public IS Sex
        {
            get { return GetValueAt<IS>(1); }
        }
        public CM_RANGE AgeRange
        {
            get { return GetValueAt<CM_RANGE>(2); }
        }
        public CM_RANGE AgeGestation
        {
            get { return GetValueAt<CM_RANGE>(3); }
        }
        public TX Species
        {
            get { return GetValueAt<TX>(4); }
        }
        public ST Race
        {
            get { return GetValueAt<ST>(5); }
        }

        public TX Conditions
        {
            get { return GetValueAt<TX>(6); }
        }


        public CM_RFR(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_RFR(ChoHL7Field field) : base(field)
        {
        }
    }
}
