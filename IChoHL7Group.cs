using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public interface IChoHL7Group
    {
        bool IsGroupStart(ChoPeekEnumerator<ChoHL7Segment> segments);
    }
}
