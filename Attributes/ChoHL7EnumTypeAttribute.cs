using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ChoHL7EnumTypeAttribute : Attribute
    {
        public Type EnumType
        {
            get;
            private set;
        }

        public ChoHL7EnumTypeAttribute(Type enumType)
        {
            ChoGuard.ArgumentNotNull(enumType, nameof(enumType));

            EnumType = enumType;
        }
    }
}
