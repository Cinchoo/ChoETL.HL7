using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_WVI: Channel Identifier")]
    public class CM_VWI : ChoHL7AbstractField
    {
        public NM ChannelNumber
        {
            get { return GetValueAt<NM>(0); }
        }
        public ST ChannelName
        {
            get { return GetValueAt<ST>(1); }
        }

        public CM_VWI(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_VWI(ChoHL7Field field) : base(field)
        {
        }
    }
}
