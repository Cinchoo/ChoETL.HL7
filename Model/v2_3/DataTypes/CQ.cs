using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// CQ: Composite Price
    /// </summary>
    [Description("CQ: Composite Quantity With Units")]
    public class CQ : ChoHL7AbstractField
    {
        public NM Quantity
        {
            get { return GetValueAt<NM>(0); }
        }
        public ST Units
        {
            get { return GetValueAt<ST>(1); }
        }

        public CQ(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CQ(ChoHL7Field field) : base(field)
        {
        }
    }
}
