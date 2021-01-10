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
            foreach (var attr in GetType().GetCustomAttributes(true).OfType<ChoHL7ObjectAttribute>().OrderBy(a => a.Order))
            {
                if (attr.IsGroup)
                {
                    IChoHL7Group groupObj = attr.GetGroupObject();
                    if (groupObj.IsGroupStart(segments))
                        return true;
                }
                else
                {
                    if (segments.Peek == null)
                        return false;

                    ChoHL7Segment segment1 = segments.Peek;
                    if (segment1.TargetType == attr.Name)
                        return true;
                    else
                    {
                        if (attr.Optional)
                            continue;
                        else
                            return false;
                    }
                }
            }

            return false;
        }

        public bool IsGroupStart1(ChoPeekEnumerator<ChoHL7Segment> segments)
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
                return segment1.TargetType == attr.Name;
            }
        }
    }
}
