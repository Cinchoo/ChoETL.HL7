using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("NA: Numeric Array")]
    public class NA : ChoHL7AbstractField
    {
        public NM Value1
        {
            get { return GetValueAt<NM>(0); }
        }
        public NM Value2
        {
            get { return GetValueAt<NM>(1); }
        }
        public NM Value3
        {
            get { return GetValueAt<NM>(2); }
        }
        public NM Value4
        {
            get { return GetValueAt<NM>(3); }
        }

        public NA(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public NA(ChoHL7Field field) : base(field)
        {
        }
    }
}
