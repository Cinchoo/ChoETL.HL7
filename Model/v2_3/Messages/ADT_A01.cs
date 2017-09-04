using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(01, typeof(MSH))]
    [ChoHL7Segment(02, typeof(EVN))]
    [ChoHL7Segment(03, typeof(PID))]
    [ChoHL7Segment(04, typeof(PD1), Optional = true)]
    [ChoHL7Segment(05, typeof(NK1), Optional = true, Repeatable = true)]
    [ChoHL7Segment(06, typeof(PV1))]
    [ChoHL7Segment(07, typeof(PV2), Optional = true)]
    [ChoHL7Segment(08, typeof(DB1), Optional = true, Repeatable = true)]
    [ChoHL7Segment(09, typeof(OBX), Optional = true, Repeatable = true)]
    [ChoHL7Segment(10, typeof(AL1), Optional = true, Repeatable = true)]
    [ChoHL7Segment(11, typeof(DG1), Optional = true, Repeatable = true)]
    [ChoHL7Segment(12, typeof(DRG), Optional = true)]
    [ChoHL7Group(13, typeof(ADT_A01_PROCEDURE), Optional = true, Repeatable = true)]
    [ChoHL7Segment(14, typeof(GT1), Optional = true, Repeatable = true)]
    [ChoHL7Group(15, typeof(ADT_A01_INSURANCE), Optional = true, Repeatable = true)]
    [ChoHL7Segment(16, typeof(ACC), Optional = true)]
    [ChoHL7Segment(17, typeof(UB1), Optional = true)]
    [ChoHL7Segment(18, typeof(UB2), Optional = true)]
    public class ADT_A01 : ChoHL7Message
    {
    }
}
