using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_RI: Interval")]
    public class CM_RI : ChoHL7AbstractField
    {
        public IS RepeatPattern
        {
            get { return GetValueAt<IS>(0); }
        }
        public ST ExplicitTimeInterval
        {
            get { return GetValueAt<ST>(1); }
        }

        public CM_RI(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_RI(ChoHL7Field field) : base(field)
        {
        }
    }
}
