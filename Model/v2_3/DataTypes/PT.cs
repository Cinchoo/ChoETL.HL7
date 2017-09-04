using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// PT: Processing Type
    /// </summary>
    [Description("PT: Processing Type")]
    public class PT : ChoHL7AbstractField
    {
        public ST ProcessingID
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST ProcessingType
        {
            get { return GetDefaultOrValueAt<ST>(1); }
        }

        public PT(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public PT(ChoHL7Field field) : base(field)
        {
        }
    }
}
