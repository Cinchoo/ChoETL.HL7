using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ChoHL7MaxCountAttribute : Attribute
    {
        public int Count
        {
            get;
            private set;
        }

        public ChoHL7MaxCountAttribute(int count)
        {
            Count = count;
        }
    }
}
