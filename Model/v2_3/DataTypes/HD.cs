using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// HD: Hierarchic Designator
    /// </summary>
    public class HD : ChoHL7AbstractField
    {
        public IS NamespaceID
        {
            get { return GetValueAt<IS>(0); }
        }
        public ST UniversalID
        {
            get { return HasValueAt(1) ? GetValueAt<ST>(1) : GetDefaultValue<ST>(); }
        }
        public ID UniversalIDType
        {
            get { return GetValueAt<ID>(2); }
        }

        public HD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public HD(ChoHL7Field field) : base(field)
        {
        }
    }
}
