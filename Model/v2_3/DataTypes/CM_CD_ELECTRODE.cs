using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_CD_ELECTRODE: Electrode Paramete")]
    public class CM_CD_ELECTRODE : ChoHL7AbstractField
    {
        public ST SourceName1
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST SourceName2
        {
            get { return GetValueAt<ST>(1); }
        }

        public CM_CD_ELECTRODE(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_CD_ELECTRODE(ChoHL7Field field) : base(field)
        {
        }
    }
}
