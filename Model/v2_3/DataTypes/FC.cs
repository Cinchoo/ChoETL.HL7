using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// FC: Entity Identifier
    /// </summary>
    [Description("FC: Financial Class")]
    public class FC : ChoHL7AbstractField
    {
        public IS FinancialClass
        {
            get { return GetDefaultOrValueAt<IS>(0); }
        }
        public TS EffectiveDate
        {
            get { return GetValueAt<TS>(1); }
        }

        public FC(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public FC(ChoHL7Field field) : base(field)
        {
        }
    }
}
