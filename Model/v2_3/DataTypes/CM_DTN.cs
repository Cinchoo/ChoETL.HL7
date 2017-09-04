using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_DTN: Day Type And Number")]
    public class CM_DTN : ChoHL7AbstractField
    {
        public IS DayType
        {
            get { return GetValueAt<IS>(0); }
        }
        public NM NumberOfDays
        {
            get { return GetValueAt<NM>(1); }
        }

        public CM_DTN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_DTN(ChoHL7Field field) : base(field)
        {
        }
    }
}
