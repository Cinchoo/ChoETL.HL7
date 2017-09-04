using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("JCC: Job Code Class")]
    public class JCC : ChoHL7AbstractField
    {
        public IS JobCode
        {
            get { return GetValueAt<IS>(0); }
        }
        public IS JobClass
        {
            get { return GetValueAt<IS>(1); }
        }

        public JCC(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public JCC(ChoHL7Field field) : base(field)
        {
        }
    }
}
