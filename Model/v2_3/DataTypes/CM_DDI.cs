using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_DDI: Daily Deductible")]
    public class CM_DDI : ChoHL7AbstractField
    {
        public NM DelayDays
        {
            get { return GetValueAt<NM>(0); }
        }
        public NM Amount
        {
            get { return GetValueAt<NM>(1); }
        }
        public NM NumberOfDays
        {
            get { return GetValueAt<NM>(2); }
        }

        public CM_DDI(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_DDI(ChoHL7Field field) : base(field)
        {
        }
    }
}
