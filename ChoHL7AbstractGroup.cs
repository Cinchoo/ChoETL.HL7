using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public abstract class ChoHL7AbstractGroup : ChoHL7AbstractMessage, IChoHL7Group
    {
        public bool IsGroupStart(ChoPeekEnumerator<ChoHL7Segment> segments)
        {
            var attr = GetType().GetCustomAttributes(true).OfType<ChoHL7ObjectAttribute>().OrderBy(a => a.Order).FirstOrDefault();

            if (attr == null)
                return false;

            if (attr.IsGroup)
            {
                IChoHL7Group groupObj = attr.GetGroupObject();
                return groupObj.IsGroupStart(segments);
            }
            else
            {
                if (segments.Peek == null)
                    return false;

                ChoHL7Segment segment1 = segments.Peek;
                return segment1.Type == attr.Name;
            }
        }
    }
}
