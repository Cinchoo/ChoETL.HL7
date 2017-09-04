using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_DLT: Delta Check")]
    public class CM_DLT : ChoHL7AbstractField
    {
        public CM_RANGE Range
        {
            get { return GetValueAt<CM_RANGE>(0); }
        }
        public NM NumericThreshold
        {
            get { return GetValueAt<NM>(1); }
        }
        public ST Change
        {
            get { return GetValueAt<ST>(2); }
        }
        public NM LengthOfTimedays
        {
            get { return GetValueAt<NM>(3); }
        }

        public CM_DLT(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_DLT(ChoHL7Field field) : base(field)
        {
        }
    }
}
