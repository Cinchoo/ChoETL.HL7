using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_OCD: Occurrence")]
    public class CM_OCD : ChoHL7AbstractField
    {
        public CE OccurrenceCode
        {
            get { return GetValueAt<CE>(0); }
        }
        public DT OccurrenceDate
        {
            get { return GetValueAt<DT>(1); }
        }

        public CM_OCD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_OCD(ChoHL7Field field) : base(field)
        {
        }
    }
}
