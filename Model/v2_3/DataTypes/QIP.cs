using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("QIP: Query Input Parameter List")]
    public class QIP : ChoHL7AbstractField
    {
        public ST FieldName
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST Value1AndValueAndValue3
        {
            get { return GetValueAt<ST>(1); }
        }

        public QIP(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public QIP(ChoHL7Field field) : base(field)
        {
        }
    }
}
