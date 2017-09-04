using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CNE: Coded with No Exceptions")]
    public class CNE : ChoHL7AbstractField
    {
        public ST ID
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST Text
        {
            get { return GetValueAt<ST>(1); }
        }
        public ID NameofCodingSystem
        {
            get { return GetValueAt<ID>(2); }
        }
        public ST AlternateID
        {
            get { return GetValueAt<ST>(3); }
        }
        public ST AlternateText
        {
            get { return GetValueAt<ST>(4); }
        }
        public ID NameofAlternateCodingSystem
        {
            get { return GetValueAt<ID>(5); }
        }
        public ST CodingSystemVersionID
        {
            get { return GetValueAt<ST>(6); }
        }
        public ST AlternativeCodingSystemVersionID
        {
            get { return GetValueAt<ST>(7); }
        }
        public ST OriginalText
        {
            get { return GetValueAt<ST>(8); }
        }

        public CNE(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CNE(ChoHL7Field field) : base(field)
        {
        }
    }
}
