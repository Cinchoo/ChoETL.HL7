using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_PRL: Parent Result Link")]
    public class CM_PRL : ChoHL7AbstractField
    {
        public CE OBX3ObservationIdentifierOfParentResult
        {
            get { return GetValueAt<CE>(0); }
        }
        public ST OBX4SubIDOfParentResult
        {
            get { return GetValueAt<ST>(1); }
        }
        public TX PartOfOBX5ObservationResultFromParent
        {
            get { return GetValueAt<TX>(2); }
        }

        public CM_PRL(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_PRL(ChoHL7Field field) : base(field)
        {
        }
    }
}
