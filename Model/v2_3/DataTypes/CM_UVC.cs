using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_UVC: Value Code And Amount")]
    public class CM_UVC : ChoHL7AbstractField
    {
        public IS ValueCode
        {
            get { return GetValueAt<IS>(0); }
        }
        public NM ValueAmount
        {
            get { return GetValueAt<NM>(1); }
        }

        public CM_UVC(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_UVC(ChoHL7Field field) : base(field)
        {
        }
    }
}
