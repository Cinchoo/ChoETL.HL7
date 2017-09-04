using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_OSP: Occurence Span")]
    public class CM_OSP : ChoHL7AbstractField
    {
        public CE OccurrenceSpanCode
        {
            get { return GetValueAt<CE>(0); }
        }
        public DT OccurrenceSpanStartDate
        {
            get { return GetValueAt<DT>(1); }
        }
        public DT OccurrenceSpanStopDate
        {
            get { return GetValueAt<DT>(2); }
        }

        public CM_OSP(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_OSP(ChoHL7Field field) : base(field)
        {
        }
    }
}
