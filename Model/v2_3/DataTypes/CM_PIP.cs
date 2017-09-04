using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_PIP: Privileges")]
    public class CM_PIP : ChoHL7AbstractField
    {
        public CE Privilege
        {
            get { return GetValueAt<CE>(0); }
        }
        public CE PrivilegeClass
        {
            get { return GetValueAt<CE>(1); }
        }
        public DT ExpirationDate
        {
            get { return GetValueAt<DT>(2); }
        }
        public DT ActivationDate
        {
            get { return GetValueAt<DT>(3); }
        }

        public CM_PIP(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_PIP(ChoHL7Field field) : base(field)
        {
        }
    }
}
