using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_PCF: Pre-certification Required")]
    public class CM_PCF : ChoHL7AbstractField
    {
        public IS PreCertificationPatientType
        {
            get { return GetValueAt<IS>(0); }
        }
        public ID PreCertificationRequired
        {
            get { return GetValueAt<ID>(1); }
        }
        public TS PreCertificationWindow
        {
            get { return GetValueAt<TS>(2); }
        }

        public CM_PCF(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_PCF(ChoHL7Field field) : base(field)
        {
        }
    }
}
