using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// CN: Composite ID Number And Name
    /// </summary>
    [Description("CN: Composite ID Number And Name")]
    public class CN : ChoHL7AbstractField
    {
        public ST ID
        {
            get { return GetValueAt<ST>(0); }
        }
        public ST FamilyName
        {
            get { return GetValueAt<ST>(1); }
        }
        public ST GivenName
        {
            get { return GetValueAt<ST>(2); }
        }
        public ST MiddleInitial
        {
            get { return GetValueAt<ST>(3); }
        }
        public ST Suffix
        {
            get { return GetValueAt<ST>(4); }
        }
        public ST Prefix
        {
            get { return GetValueAt<ST>(5); }
        }
        public ST Degree
        {
            get { return GetValueAt<ST>(6); }
        }
        public ID SourceTable
        {
            get { return GetValueAt<ID>(7); }
        }
        public ST AssigningAuthority
        {
            get { return GetValueAt<ST>(8); }
        }

        public CN(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CN(ChoHL7Field field) : base(field)
        {
        }
    }
}
