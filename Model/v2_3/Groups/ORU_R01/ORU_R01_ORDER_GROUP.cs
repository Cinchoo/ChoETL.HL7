using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(1, typeof(ORC), Optional = true)]
    [ChoHL7Segment(2, typeof(OBR))]
    [ChoHL7Segment(3, typeof(NTE), Optional = true, Repeatable = true)]
    [ChoHL7Segment(4, typeof(ORU_R01_OBSERVATION_GROUP), Repeatable = true)]
    [ChoHL7Segment(5, typeof(CTI), Optional = true, Repeatable = true)]
    public class ORU_R01_ORDER_GROUP : ChoHL7AbstractGroup
    {
    }
}
