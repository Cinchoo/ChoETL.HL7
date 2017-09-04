using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// CE: Coded Element
    /// </summary>
    [Description("CE: Coded Element")]
    public class CE : ChoHL7AbstractField
    {
        public ID Identifier
        {
            get { return GetValueAt<ID>(0); }
        }
        public ST Text
        {
            get { return GetDefaultOrValueAt<ST>(1); }
        }
        public ST NameOfCodingSystem
        {
            get { return GetValueAt<ST>(2); }
        }
        public ID AlternateIdentifier
        {
            get { return GetValueAt<ID>(3); }
        }
        public ST AlternateText
        {
            get { return GetValueAt<ST>(4); }
        }
        public ST NameOfAlternateCodingSystem
        {
            get { return GetValueAt<ST>(5); }
        }

        public CE(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CE(ChoHL7Field field) : base(field)
        {
        }
    }
}
