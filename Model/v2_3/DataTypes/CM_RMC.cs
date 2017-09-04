using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_RMC: Room Coverage")]
    public class CM_RMC : ChoHL7AbstractField
    {
        [ChoHL7EnumType(typeof(RoomType))]
        public IS RoomType
        {
            get { return GetValueAt<IS>(0); }
        }
        public IS AmountType
        {
            get { return GetValueAt<IS>(1); }
        }
        public NM CoverageAmount
        {
            get { return GetValueAt<NM>(2); }
        }
        public CM_RMC(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_RMC(ChoHL7Field field) : base(field)
        {
        }
    }
}
