using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(1, typeof(PV1))]
    [ChoHL7Segment(2, typeof(PV2), Optional = true)]
    public class ORU_R01_PATIENT_VISIT_GROUP : ChoHL7AbstractGroup
    {
    }
}
