using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public abstract class ChoHL7ObjectAttribute : Attribute
    {
        private static readonly Dictionary<Type, string> segmentTypeCache = new Dictionary<Type, string>();
        private static readonly Dictionary<Type, IChoHL7Group> groupObjCache = new Dictionary<Type, IChoHL7Group>();

        public int Order
        {
            get;
            private set;
        }

        public bool Optional
        {
            get;
            set;
        }

        public bool Repeatable
        {
            get;
            set;
        }
        public Type GroupOrSegmentType
        {
            get;
            private set;
        }
        internal string Name
        {
            get
            {
                return IsGroup ? GroupOrSegmentType.Name : GetSegmentTypeName();
            }
        }

        internal bool IsGroup
        {
            get { return typeof(IChoHL7Group).IsAssignableFrom(GroupOrSegmentType); }
        }

        public ChoHL7ObjectAttribute(int order, Type groupOrSegmentType)
        {
            ChoGuard.ArgumentNotNullOrEmpty(groupOrSegmentType, nameof(groupOrSegmentType));

            Order = order;
            GroupOrSegmentType = groupOrSegmentType;
        }

        internal IChoHL7Group GetGroupObject()
        {
            if (IsGroup)
            {
                if (!groupObjCache.ContainsKey(GroupOrSegmentType))
                {
                    groupObjCache.Add(GroupOrSegmentType, Activator.CreateInstance(GroupOrSegmentType) as IChoHL7Group);
                    if (groupObjCache[GroupOrSegmentType] == null)
                        throw new ChoHL7Exception("'{0}' is not a group object.".FormatString(GroupOrSegmentType.FullName));

                }
                return groupObjCache[GroupOrSegmentType];
            }
            else
                throw new ChoHL7Exception("'{0}' is not a group.".FormatString(Name));
        }

        private string GetSegmentTypeName()
        {
            Type groupOrSegmentType = GroupOrSegmentType;
            if (!segmentTypeCache.ContainsKey(groupOrSegmentType))
            {
                ChoHL7Segment segment = Activator.CreateInstance(groupOrSegmentType) as ChoHL7Segment;
                if (segment == null)
                    throw new ChoHL7Exception("'{0}' is not a segment object.".FormatString(groupOrSegmentType.FullName));

                segmentTypeCache.Add(groupOrSegmentType, segment.TargetType);
            }

            return segmentTypeCache[groupOrSegmentType];
        }
    }

    public class ChoHL7GroupAttribute : ChoHL7ObjectAttribute
    {
        public ChoHL7GroupAttribute(int order, Type groupType) : base(order, groupType)
        {
        }
    }

    public class ChoHL7SegmentAttribute : ChoHL7ObjectAttribute
    {
        public ChoHL7SegmentAttribute(int order, Type segmentType) : base(order, segmentType)
        {
        }
    }

}
