using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_ABS_RANGE: Absolute Range")]
    public class CM_ABS_RANGE : ChoHL7AbstractField
    {
        public CM_RANGE Range
        {
            get { return GetValueAt<CM_RANGE>(0); }
        }
        public NM NumericChange
        {
            get { return GetValueAt<NM>(1); }
        }
        public NM PercentPerChange
        {
            get { return GetValueAt<NM>(2); }
        }
        public NM Days
        {
            get { return GetValueAt<NM>(3); }
        }

        public CM_ABS_RANGE(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_ABS_RANGE(ChoHL7Field field) : base(field)
        {
        }
    }
}
