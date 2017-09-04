using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_PI: Person Identifier")]
    public class CM_PI : ChoHL7AbstractField
    {
        public ST ID
        {
            get { return GetValueAt<ST>(0); }
        }
        public IS TypeOfID
        {
            get { return GetValueAt<IS>(1); }
        }
        public ST OtherQualifyingInfo
        {
            get { return GetValueAt<ST>(2); }
        }

        public CM_PI(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_PI(ChoHL7Field field) : base(field)
        {
        }
    }
}
