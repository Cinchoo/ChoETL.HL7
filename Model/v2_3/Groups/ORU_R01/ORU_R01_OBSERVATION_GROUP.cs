using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(1, typeof(OBX))]
    [ChoHL7Segment(2, typeof(NTE), Optional = true, Repeatable = true)]
    public class ORU_R01_OBSERVATION_GROUP : ChoHL7AbstractGroup
    {
    }
}
