using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_RANGE: Wertebereich")]
    public class CM_RANGE : ChoHL7AbstractField
    {
        public ST LowValue
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST HighValue
        {
            get { return GetValueAt<ST>(1); }
        }

        public CM_RANGE(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_RANGE(ChoHL7Field field) : base(field)
        {
        }
    }
}
