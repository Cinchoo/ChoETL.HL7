using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// CM_AUI: Authorization Information
    /// </summary>
    [Description("CM_AUI: Authorization Information")]
    public class CM_AUI : ChoHL7AbstractField
    {
        public ST AuthorizationNumber
        {
            get { return GetValueAt<ST>(0); }
        }
        public TS Date
        {
            get { return GetValueAt<TS>(1); }
        }
        public ST Source
        {
            get { return GetValueAt<ST>(2); }
        }

        public CM_AUI(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_AUI(ChoHL7Field field) : base(field)
        {
        }
    }
}
