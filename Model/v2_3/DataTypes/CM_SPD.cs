using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_SPD: Specialty")]
    public class CM_SPD : ChoHL7AbstractField
    {
        public ST SpecialtyName
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST GoverningBoard
        {
            get { return GetValueAt<ST>(1); }
        }
        public ID Certified
        {
            get { return GetValueAt<ID>(2); }
        }
        public DT DateOfCertification
        {
            get { return GetValueAt<DT>(3); }
        }

        public CM_SPD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_SPD(ChoHL7Field field) : base(field)
        {
        }
    }
}
