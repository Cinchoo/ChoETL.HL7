using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_CCD: Charge Time")]
    public class CM_CCD : ChoHL7AbstractField
    {
        public ID WhenToChargeCode
        {
            get { return GetValueAt<ID>(0); }
        }
        public TS DateTime
        {
            get { return GetValueAt<TS>(1); }
        }

        public CM_CCD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_CCD(ChoHL7Field field) : base(field)
        {
        }
    }
}
