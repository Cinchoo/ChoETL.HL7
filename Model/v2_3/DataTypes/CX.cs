using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// CX: Hierarchic Designator
    /// </summary>
    [Description("CX: Hierarchic Designator")]
    public class CX : ChoHL7AbstractField
    {
        public ST ID
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST CheckDigit
        {
            get { return GetDefaultOrValueAt<ST>(1); }
        }
        public ID CheckDigitCode
        {
            get { return GetValueAt<ID>(2); }
        }
        public HD AssigningAuthority
        {
            get { return GetValueAt<HD>(3); }
        }
        public IS IdentifierTypeCode
        {
            get { return GetValueAt<IS>(4); }
        }
        public HD AssigningFacility
        {
            get { return GetValueAt<HD>(5); }
        }

        public CX(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CX(ChoHL7Field field) : base(field)
        {
        }
    }
}
