using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("MO: Money")]
    public class MO : ChoHL7AbstractField
    {
        public NM Quantity
        {
            get { return GetValueAt<NM>(0); }
        }
        public ID Denomination
        {
            get { return GetValueAt<ID>(1); }
        }

        public MO(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public MO(ChoHL7Field field) : base(field)
        {
        }
    }
}
