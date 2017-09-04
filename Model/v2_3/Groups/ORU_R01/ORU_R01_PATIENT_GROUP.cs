using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(1, typeof(PID))]
    [ChoHL7Segment(2, typeof(PD1), Optional = true)]
    [ChoHL7Segment(3, typeof(NTE), Optional = true, Repeatable = true)]
    [ChoHL7Group(4, typeof(ORU_R01_PATIENT_VISIT_GROUP), Optional = true)]
    public class ORU_R01_PATIENT_GROUP : ChoHL7AbstractGroup
    {
    }
}
