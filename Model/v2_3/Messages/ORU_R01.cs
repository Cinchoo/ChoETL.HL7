using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(1, typeof(MSH))]
    [ChoHL7Group(2, typeof(ORU_R01_RESULTS_GROUP), Repeatable = true)]
    [ChoHL7Segment(3, typeof(DSC), Optional = true)]
    public class ORU_R01 : ChoHL7Message
    {
    }
}
