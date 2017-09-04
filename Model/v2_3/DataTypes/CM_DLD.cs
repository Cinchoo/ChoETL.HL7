using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_DLD: Discharge Location")]
    public class CM_DLD : ChoHL7AbstractField
    {
        public ID DischargeLocation
        {
            get { return GetValueAt<ID>(0); }
        }
        public TS EffectiveDate
        {
            get { return GetValueAt<TS>(1); }
        }

        public CM_DLD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_DLD(ChoHL7Field field) : base(field)
        {
        }
    }
}
