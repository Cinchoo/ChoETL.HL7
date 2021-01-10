using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public enum ChoHL7MessageType
    {
        [Description("ORU^R01")]
        ORU_R01,
        [Description("ADT^A01")]
        ADT_A01,
        [Description("ORM^O01")]
        ORM_O01
    }
}
