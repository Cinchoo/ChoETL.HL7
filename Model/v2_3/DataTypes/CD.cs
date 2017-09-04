using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// CD: Channel Definition
    /// </summary>
    [Description("CD: Channel Definition")]
    public class CD : ChoHL7AbstractField
    {
        public CM_VWI ChannelIdentifier
        {
            get { return GetValueAt<CM_VWI>(0); }
        }
        public CM_CD_ELECTRODE ElectrodeNames
        {
            get { return GetValueAt<CM_CD_ELECTRODE>(1); }
        }
        public CM_CSU ChannelSensitivity
        {
            get { return GetValueAt<CM_CSU>(2); }
        }
        public CM_CCP CalibrationParameters
        {
            get { return GetValueAt<CM_CCP>(3); }
        }
        public NM SamplingFrequency
        {
            get { return GetValueAt<NM>(4); }
        }
        public CM_MDV MinimumMaximumDataValues
        {
            get { return GetValueAt<CM_MDV>(5); }
        }

        public CD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CD(ChoHL7Field field) : base(field)
        {
        }
    }
}
