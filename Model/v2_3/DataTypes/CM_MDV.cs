using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_MDV: Minimum/maximum Data Values")]
    public class CM_MDV : ChoHL7AbstractField
    {
        public NM MinimumValue
        {
            get { return GetValueAt<NM>(0); }
        }
        public NM MaximumValue
        {
            get { return GetValueAt<NM>(1); }
        }

        public CM_MDV(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_MDV(ChoHL7Field field) : base(field)
        {
        }
    }
}
