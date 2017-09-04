using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// ED: Entity Identifier
    /// </summary>
    [Description("ED: Encapsulated Data")]
    public class ED : ChoHL7AbstractField
    {
        public HD SourceApplication
        {
            get { return GetValueAt<HD>(0); }
        }
        public ID TypeOfData
        {
            get { return GetValueAt<ID>(1); }
        }
        public ID DataSubtype
        {
            get { return GetValueAt<ID>(2); }
        }
        public ID Encoding
        {
            get { return GetValueAt<ID>(3); }
        }
        public ST Data
        {
            get { return GetValueAt<ST>(4); }
        }

        public ED(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public ED(ChoHL7Field field) : base(field)
        {
        }
    }
}
