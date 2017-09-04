using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("SN: Structured Numeric")]
    public class SN : ChoHL7AbstractField
    {
        public ST Comparator
        {
            get { return GetValueAt<ST>(0); }
        }
        public NM Num1
        {
            get { return GetValueAt<NM>(1); }
        }
        public ST SeparatorOrSuffix
        {
            get { return GetValueAt<ST>(2); }
        }
        public NM Num2
        {
            get { return GetValueAt<NM>(3); }
        }

        public SN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public SN(ChoHL7Field field) : base(field)
        {
        }
    }
}
