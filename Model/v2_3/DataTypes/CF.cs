using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CF: Coded Element With Formatted Values")]
    public class CF : ChoHL7AbstractField
    {
        public ID Identifier
        {
            get { return GetValueAt<ID>(0); }
        }
        public FT FormattedText
        {
            get { return GetDefaultOrValueAt<FT>(1); }
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

        public CF(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CF(ChoHL7Field field) : base(field)
        {
        }
    }
}