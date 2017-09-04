using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public class ChoHL7Component
    {
        public string Value
        {
            get;
            private set;
        }
        private readonly List<ChoHL7Subcomponent> _subcomponents = new List<ChoHL7Subcomponent>();
        public List<ChoHL7Subcomponent> Subcomponents
        {
            get { return _subcomponents; }
        }
        private ChoHL7Configuration _configuration;

        public ChoHL7Component(string value = null, ChoHL7Configuration configuration = null)
        {
            _configuration = configuration = configuration ?? ChoHL7Configuration.Instance;
            Value = configuration.Decode(value);
        }

        public override string ToString()
        {
            if (Subcomponents.Count > 0)
            {
                StringBuilder msg = new StringBuilder();
                foreach (var sc in Subcomponents)
                {
                    if (msg.Length == 0)
                        msg.Append(sc.ToString());
                    else
                        msg.Append("{0}{1}".FormatString(ChoHL7Configuration.Instance.SubcomponentSeparator, sc.ToString()));
                }
                return msg.ToString();
            }
            else
                return _configuration.Encode(Value.ToNString());
        }

        internal static ChoHL7Component Parse(string line, ChoHL7Configuration configuration = null)
        {
            configuration = configuration ?? ChoHL7Configuration.Instance;
            if (line.IsNullOrWhiteSpace() || line.IndexOf(configuration.SubcomponentSeparator) < 0)
                return new ChoHL7Component(line, configuration);
            else
            {
                ChoHL7Component rec = new ChoHL7Component(null, configuration);

                var subComponents = line.Split(configuration.SubcomponentSeparator);
                foreach (var comp in subComponents)
                {
                    rec.Subcomponents.Add(ChoHL7Subcomponent.Parse(comp, configuration));
                }
                return rec;
            }
        }
    }
}
