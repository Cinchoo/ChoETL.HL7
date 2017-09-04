using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_CCP: Channel Calibration Parameters")]
    public class CM_CCP : ChoHL7AbstractField
    {
        public NM SensitivityCorrectionFactor
        {
            get { return GetValueAt<NM>(0); }
        }
        public NM Baseline
        {
            get { return GetValueAt<NM>(1); }
        }
        public NM TimeSkew
        {
            get { return GetValueAt<NM>(2); }
        }

        public CM_CCP(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_CCP(ChoHL7Field field) : base(field)
        {
        }
    }
}
