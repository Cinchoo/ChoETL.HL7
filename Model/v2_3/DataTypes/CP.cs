using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// CP: Composite Price
    /// </summary>
    [Description("CP: Composite Price")]
    public class CP : ChoHL7AbstractField
    {
        public MO Price
        {
            get { return GetValueAt<MO>(0); }
        }
        public ID PriceType
        {
            get { return GetValueAt<ID>(1); }
        }
        public NM FromValue
        {
            get { return GetValueAt<NM>(2); }
        }
        public NM ToValue
        {
            get { return GetValueAt<NM>(3); }
        }
        public CE RangeUnits
        {
            get { return GetValueAt<CE>(4); }
        }
        public ID RangeType
        {
            get { return GetValueAt<ID>(5); }
        }

        public CP(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CP(ChoHL7Field field) : base(field)
        {
        }
    }
}
