using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// EI: Entity Identifier
    /// </summary>
    [Description("EI: Entity Identifier")]
    public class EI : ChoHL7AbstractField
    {
        public ST EntityIdentifier
        {
            get { return GetDefaultOrValueAt<ST>(0); }
        }
        public IS NamespaceID
        {
            get { return GetValueAt<IS>(1); }
        }
        public ST UniversalID
        {
            get { return GetValueAt<ST>(2); }
        }
        public ID UniversalIDType
        {
            get { return GetValueAt<ID>(3); }
        }

        public EI(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public EI(ChoHL7Field field) : base(field)
        {
        }
    }
}
