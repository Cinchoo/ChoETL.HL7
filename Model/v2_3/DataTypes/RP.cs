using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("RP: Reference Pointer")]
    public class RP : ChoHL7AbstractField
    {
        public ST Pointer
        {
            get { return GetValueAt<ST>(0); }
        }
        public HD ApplicationID
        {
            get { return GetValueAt<HD>(1); }
        }
        public ID TypeOfData
        {
            get { return GetValueAt<ID>(2); }
        }
        public ID Subtype
        {
            get { return GetValueAt<ID>(3); }
        }

        public RP(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public RP(ChoHL7Field field) : base(field)
        {
        }
    }
}
