using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("QSC: Query Selection Criteria")]
    public class QSC : ChoHL7AbstractField
    {
        public ST NameOfField
        {
            get { return GetValueAt<ST>(0); }
        }
        public ID RelationalOperator
        {
            get { return GetValueAt<ID>(1); }
        }
        public ST Value
        {
            get { return GetValueAt<ST>(2); }
        }
        public ID RelationalConjunction
        {
            get { return GetValueAt<ID>(3); }
        }

        public QSC(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public QSC(ChoHL7Field field) : base(field)
        {
        }
    }
}
