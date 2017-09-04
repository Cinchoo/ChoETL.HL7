using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("SCV: Scheduling Class Value Pair")]
    public class SCV : ChoHL7AbstractField
    {
        public IS ParameterClass
        {
            get { return GetValueAt<IS>(0); }
        }
        public ST ParameterValue
        {
            get { return GetValueAt<ST>(1); }
        }

        public SCV(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public SCV(ChoHL7Field field) : base(field)
        {
        }
    }
}
