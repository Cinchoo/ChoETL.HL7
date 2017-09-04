using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CK: Composite ID With Check Digit")]
    public class CK : ChoHL7AbstractField
    {
        public NM ID
        {
            get { return GetValueAt<NM>(0); }
        }
        public ST CheckDigit
        {
            get { return GetDefaultOrValueAt<ST>(1); }
        }
        public ID CodeIdentifyingTheCheckDigitSchemeEmployed
        {
            get { return GetValueAt<ID>(2); }
        }
        public HD AssigningAuthority
        {
            get { return GetValueAt<HD>(3); }
        }

        public CK(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CK(ChoHL7Field field) : base(field)
        {
        }
    }
}