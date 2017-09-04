using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_EIP: Parent Order")]
    public class CM_EIP : ChoHL7AbstractField
    {
        public EI ParentsPlacerOrderNumber
        {
            get { return GetValueAt<EI>(0); }
        }
        public EI ParentsFillerOrderNumber
        {
            get { return GetValueAt<EI>(1); }
        }

        public CM_EIP(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_EIP(ChoHL7Field field) : base(field)
        {
        }
    }
}
