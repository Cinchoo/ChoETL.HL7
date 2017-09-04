using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(1, typeof(IN1))]
    [ChoHL7Segment(1, typeof(IN2), Optional = true)]
    [ChoHL7Segment(1, typeof(IN3), Optional = true)]
    public class ADT_A01_INSURANCE : ChoHL7AbstractGroup
    {
    }
}
