using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [ChoHL7Segment(1, typeof(PR1))]
    [ChoHL7Segment(2, typeof(ROL), Optional = true, Repeatable = true)]
    public class ADT_A01_PROCEDURE : ChoHL7AbstractGroup
    {
    }
}
