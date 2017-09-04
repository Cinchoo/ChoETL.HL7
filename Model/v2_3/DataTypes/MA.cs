using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("MA: Multiplexed Array")]
    public class MA : ChoHL7AbstractField
    {
        public NM Sample1FromChannel1
        {
            get { return GetValueAt<NM>(0); }
        }
        public NM Sample1FromChannel2
        {
            get { return GetValueAt<NM>(1); }
        }
        public NM Sample1FromChannel3
        {
            get { return GetValueAt<NM>(2); }
        }
        public NM Sample2FromChannel1
        {
            get { return GetValueAt<NM>(3); }
        }
        public NM Sample2FromChannel2
        {
            get { return GetValueAt<NM>(4); }
        }
        public NM Sample2FromChannel3
        {
            get { return GetValueAt<NM>(5); }
        }

        public MA(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public MA(ChoHL7Field field) : base(field)
        {
        }
    }
}
