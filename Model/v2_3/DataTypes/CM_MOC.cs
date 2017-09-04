using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_MOC: Charge To Practise")]
    public class CM_MOC : ChoHL7AbstractField
    {
        public MO DollarAmount
        {
            get { return GetValueAt<MO>(0); }
        }
        public CE ChargeCode
        {
            get { return GetValueAt<CE>(1); }
        }

        public CM_MOC(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_MOC(ChoHL7Field field) : base(field)
        {
        }
    }
}
