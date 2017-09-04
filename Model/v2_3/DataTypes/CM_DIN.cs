using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_DIN: Activation Date")]
    public class CM_DIN : ChoHL7AbstractField
    {
        public TS Date
        {
            get { return GetValueAt<TS>(0); }
        }
        public CE InstitutionName
        {
            get { return GetValueAt<CE>(1); }
        }

        public CM_DIN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_DIN(ChoHL7Field field) : base(field)
        {
        }
    }
}
