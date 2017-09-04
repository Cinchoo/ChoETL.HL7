using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_PEN: Penalty")]
    public class CM_PEN : ChoHL7AbstractField
    {
        public IS PenaltyType
        {
            get { return GetValueAt<IS>(0); }
        }
        public NM PenaltyAmount
        {
            get { return GetValueAt<NM>(1); }
        }

        public CM_PEN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_PEN(ChoHL7Field field) : base(field)
        {
        }
    }
}
