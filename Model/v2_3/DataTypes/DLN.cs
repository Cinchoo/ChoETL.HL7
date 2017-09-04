using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// DLN: Driver's License Number
    /// </summary>
    [Description("DLN: Driver's License Number")]
    public class DLN : ChoHL7AbstractField
    {
        public ST DriversLicenseNumber
        {
            get { return GetDefaultOrValueAt<ST>(0); }
        }
        public IS IssuingStateOrProvinceOrCountry
        {
            get { return GetValueAt<IS>(1); }
        }
        public DT ExpirationDate
        {
            get { return GetValueAt<DT>(2); }
        }

        public DLN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public DLN(ChoHL7Field field) : base(field)
        {
        }
    }
}
