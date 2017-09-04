using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_VR: Value Qualifier")]
    public class CM_VR : ChoHL7AbstractField
    {
        public ST FirstDataCodeValue
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST LastDataCodeCalue
        {
            get { return GetValueAt<ST>(1); }
        }

        public CM_VR(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_VR(ChoHL7Field field) : base(field)
        {
        }
    }
}
