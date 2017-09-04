using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_CSU: Channel Sensitivity/units")]
    public class CM_CSU : ChoHL7AbstractField
    {
        public NM Sensitivity
        {
            get { return GetValueAt<NM>(0); }
        }
        public ID UnitsIdentifier
        {
            get { return GetValueAt<ID>(1); }
        }
        public ST UnitsText
        {
            get { return GetValueAt<ST>(2); }
        }
        public ST UnitsNameOfCodingSystem
        {
            get { return GetValueAt<ST>(3); }
        }
        public ID UnitsAlternateIdentifier
        {
            get { return GetValueAt<ID>(4); }
        }
        public ST UnitsAlternateText
        {
            get { return GetValueAt<ST>(5); }
        }
        public ST UnitsNameOfAlternateCodingSystem
        {
            get { return GetValueAt<ST>(6); }
        }

        public CM_CSU(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_CSU(ChoHL7Field field) : base(field)
        {
        }
    }
}
