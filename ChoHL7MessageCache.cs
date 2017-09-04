using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    internal class ChoHL7MessageCache
    {
        public static readonly ChoHL7MessageCache Instance = new ChoHL7MessageCache();

        public readonly Dictionary<string, Type> HL7MessageDict = new Dictionary<string, Type>();
        public readonly Dictionary<string, Type> HL7SegmentDict = new Dictionary<string, Type>();
        public readonly Dictionary<string, Type> HL7FieldTypeDict = new Dictionary<string, Type>();

        public ChoHL7MessageCache()
        {
            HL7MessageDict = GetType().Assembly.GetTypes().Where(t => typeof(ChoHL7Message).IsAssignableFrom(t)).ToDictionary(kvp => kvp.FullName);
            HL7SegmentDict = GetType().Assembly.GetTypes().Where(t => typeof(ChoHL7Segment).IsAssignableFrom(t)).ToDictionary(kvp => kvp.FullName);
            HL7FieldTypeDict = GetType().Assembly.GetTypes().Where(t => typeof(ChoHL7AbstractField).IsAssignableFrom(t)).ToDictionary(kvp => kvp.FullName);
        }
    }
}
