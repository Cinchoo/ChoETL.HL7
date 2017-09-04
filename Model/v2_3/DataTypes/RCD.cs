using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("RCD: Row Column Definition")]
    public class RCD : ChoHL7AbstractField
    {
        public ST HL7ItemNumber
        {
            get { return GetValueAt<ST>(0); }
        }
        public ID HL7DateType
        {
            get { return GetValueAt<ID>(1); }
        }
        public NM MaximumColumnWidth
        {
            get { return GetValueAt<NM>(2); }
        }

        public RCD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public RCD(ChoHL7Field field) : base(field)
        {
        }
    }
}
