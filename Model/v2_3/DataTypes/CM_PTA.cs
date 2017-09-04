using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_PTA: Policy Type")]
    public class CM_PTA : ChoHL7AbstractField
    {
        public IS PolicyType
        {
            get { return GetValueAt<IS>(0); }
        }
        public IS AmountClass
        {
            get { return GetValueAt<IS>(1); }
        }
        public NM Amount
        {
            get { return GetValueAt<NM>(2); }
        }

        public CM_PTA(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_PTA(ChoHL7Field field) : base(field)
        {
        }
    }
}
