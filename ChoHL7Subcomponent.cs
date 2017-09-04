using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public class ChoHL7Subcomponent
    {
        public string Value
        {
            get;
            private set;
        }
        private ChoHL7Configuration _configuration;

        public ChoHL7Subcomponent(string value = null, ChoHL7Configuration configuration = null)
        {
            _configuration = configuration = configuration ?? ChoHL7Configuration.Instance;
            Value = configuration.Decode(value);
        }

        public override string ToString()
        {
            return _configuration.Encode(Value.ToNString());
        }

        internal static ChoHL7Subcomponent Parse(string line, ChoHL7Configuration configuration = null)
        {
            configuration = configuration ?? ChoHL7Configuration.Instance;
            return new ChoHL7Subcomponent(line, configuration);
        }
    }
}
