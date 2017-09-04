using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public enum ChoHL7Version
    {
        [Description("2.1")]
        v2_1,
        [Description("2.2")]
        v2_2,
        [Description("2.3")]
        v2_3
    }
}
