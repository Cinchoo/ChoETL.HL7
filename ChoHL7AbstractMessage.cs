using ChoETL.Dynamic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public abstract class ChoHL7AbstractMessage : ChoDynamicObject, IChoHL7Object
    {
        protected readonly Dictionary<string, ChoHL7Segment> _segmentCache = new Dictionary<string, ChoHL7Segment>(StringComparer.CurrentCultureIgnoreCase);
        protected readonly Dictionary<string, List<ChoHL7Segment>> _repeatableSegmentCache = new Dictionary<string, List<ChoHL7Segment>>(StringComparer.CurrentCultureIgnoreCase);
        protected readonly Dictionary<string, bool> _segmentRepeatableCache = new Dictionary<string, bool>(StringComparer.CurrentCultureIgnoreCase);
        protected readonly Dictionary<string, List<IChoHL7Group>> _groupCache = new Dictionary<string, List<IChoHL7Group>>(StringComparer.CurrentCultureIgnoreCase);

        public ChoHL7Configuration Configuration
        {
            get;
            set;
        }

        public override string ToString()
        {
            StringBuilder msg = new StringBuilder();
            foreach (var hl7Attr in GetType().GetCustomAttributes(true).OfType<ChoHL7ObjectAttribute>().OrderBy(a => a.Order))
            {
                if (hl7Attr.IsGroup)
                {
                    if (_groupCache.ContainsKey(hl7Attr.Name))
                    {
                        foreach (var item in _groupCache[hl7Attr.Name])
                            msg.Append(item.ToString());
                    }
                }
                else
                {
                    if (_segmentCache.ContainsKey(hl7Attr.Name))
                    {
                        msg.AppendLine(_segmentCache[hl7Attr.Name].ToString());
                    }
                    else if (_repeatableSegmentCache.ContainsKey(hl7Attr.Name))
                    {
                        foreach (var item in _repeatableSegmentCache[hl7Attr.Name])
                            msg.AppendLine(item.ToString());
                    }
                }
            }

            return msg.ToString();
        }

        protected virtual bool Construct(ChoPeekEnumerator<ChoHL7Segment> segments)
        {
            //Verify first element is a required segment
            //var attr = GetType().GetCustomAttributes(true).OfType<ChoHL7ObjectAttribute>().OrderBy(a => a.Order).FirstOrDefault();
            var hasRequiredSegment = GetType().GetCustomAttributes(true).OfType<ChoHL7ObjectAttribute>().Where(s => !s.Optional).Any();
            if (!hasRequiredSegment)
                throw new ChoHL7Exception("Group must have at least one required segment.");

            //Check for any duplicate orders
            var dupDict = GetType().GetCustomAttributes(true).OfType<ChoHL7ObjectAttribute>().GroupBy(i => i.Order).Where(g => g.Count() > 1).ToDictionary(x => x.Key, y => y.Count());
            if (dupDict.Count > 0)
                throw new ChoHL7Exception("Found segments/group defined with [{1}] duplicate order(s) in '{0}'.".FormatString(GetType().Name, String.Join(",", dupDict.Keys.ToArray())));

            foreach (var hl7Attr in GetType().GetCustomAttributes(true).OfType<ChoHL7ObjectAttribute>().OrderBy(a => a.Order))
            {
                if (hl7Attr.IsGroup)
                {
                    while (true)
                    {
                        ChoHL7AbstractMessage groupObj = Activator.CreateInstance(hl7Attr.GroupOrSegmentType) as ChoHL7AbstractMessage;
                        if (groupObj == null)
                            throw new ChoHL7Exception("'{0}' is not a group object.".FormatString(hl7Attr.GroupOrSegmentType.FullName));
                        IChoHL7Group group = groupObj as IChoHL7Group;

                        if (group.IsGroupStart(segments))
                        {
                            if (groupObj.Construct(segments))
                            {
                                AddOrUpdateGroupCache(group);

                                //repeatable
                                if (!hl7Attr.Repeatable)
                                    break;
                            }
                            else
                            {
                            }
                        }
                        else
                            break;
                    }
                }
                else
                {
                    string segmmentType = hl7Attr.Name;

                    ChoHL7Segment segment1 = segments.Peek;
                    if (segment1 == null)
                        return true;

                    if (!hl7Attr.Optional && segment1.TargetType != segmmentType)
                        throw new ChoHL7Exception("Missing '{0}' segment in '{1}' message.".FormatString(segmmentType, GetType().Name));
                    else
                    {
                        if (segment1.TargetType == segmmentType)
                        {
                            AddOrUpdateSegmentCache(segment1, hl7Attr.Repeatable);
                            segments.MoveNext();


                            //repeatable
                            if (hl7Attr.Repeatable)
                            {
                                bool canContinue = false;
                                while (segments.Peek != null)
                                {
                                    segment1 = segments.Peek;
                                    if (segment1.TargetType == segmmentType)
                                    {
                                        AddOrUpdateSegmentCache(segment1, hl7Attr.Repeatable);
                                        segments.MoveNext();
                                    }
                                    else
                                    {
                                        canContinue = true;
                                        break;
                                    }
                                }

                                if (!canContinue)
                                    return true;
                            }
                        }
                        else
                        {

                        }
                    }
                }
            }

            return true;
        }

        protected override bool GetPropertyValue(string name, out object result)
        {
            result = null;
            if (_groupCache.ContainsKey(name))
            {
                result = _groupCache[name].ToArray();
            }
            else if (_segmentCache.ContainsKey(name))
            {
                result = _segmentCache[name];
            }
            else if (_repeatableSegmentCache.ContainsKey(name))
            {
                result = _repeatableSegmentCache[name].ToArray();
            }
            else
                return false;

            return true;
        }

        private void AddOrUpdateSegmentCache(ChoHL7Segment segment, bool isRepeatable)
        {
            Console.WriteLine("Group: " + GetType().Name + " Segment: " + segment.TargetType);

            segment.Validate();

            if (isRepeatable)
            {
                if (!_repeatableSegmentCache.ContainsKey(segment.TargetType))
                    _repeatableSegmentCache.Add(segment.TargetType, new List<ChoHL7Segment>());

                _repeatableSegmentCache[segment.TargetType].Add(segment);
            }
            else
            {
                if (!_segmentCache.ContainsKey(segment.TargetType))
                    _segmentCache.Add(segment.TargetType, segment);
            }
        }
        private void AddOrUpdateGroupCache(IChoHL7Group group)
        {
            ((ChoHL7AbstractGroup)group).Validate();
            if (!_groupCache.ContainsKey(group.GetType().Name))
                _groupCache.Add(group.GetType().Name, new List<IChoHL7Group>());

            _groupCache[group.GetType().Name].Add(group);
        }

        public virtual void Validate()
        {
        }
    }
}
