using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_PLN: Practitioner ID Numbers")]
    public class CM_PLN : ChoHL7AbstractField
    {
        public ST ID
        {
            get { return GetValueAt<ST>(0); }
        }
        public IS TypeOfID
        {
            get { return GetValueAt<IS>(1); }
        }
        public ST StateOtherQualifyingInfo
        {
            get { return GetValueAt<ST>(2); }
        }
        public DT ExpirationDate
        {
            get { return GetValueAt<DT>(3); }
        }

        public CM_PLN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_PLN(ChoHL7Field field) : base(field)
        {
        }
    }
}
