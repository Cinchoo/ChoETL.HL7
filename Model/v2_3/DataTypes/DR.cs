using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// DR: Composite Price
    /// </summary>
    [Description("DR: Date Time Range")]
    public class DR : ChoHL7AbstractField
    {
        public TS RangeStartDatetime
        {
            get { return GetValueAt<TS>(0); }
        }
        public TS RangeEndDatetime
        {
            get { return GetValueAt<TS>(1); }
        }

        public DR(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public DR(ChoHL7Field field) : base(field)
        {
        }
    }
}
