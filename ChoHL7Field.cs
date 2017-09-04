using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public class ChoHL7Field : IChoHL7Object
    {
        public string Value
        {
            get;
            private set;
        }
        private readonly List<ChoHL7Component> _components = new List<ChoHL7Component>();
        public List<ChoHL7Component> Components
        {
            get { return _components; }
        }
        private readonly List<ChoHL7Field> _repeats = new List<ChoHL7Field>();
        public List<ChoHL7Field> Repeats
        {
            get { return _repeats; }
        }

        public ChoHL7Configuration Configuration
        {
            get;
            set;
        }

        public ChoHL7Field(string value = null, ChoHL7Configuration configuration = null)
        {
            Configuration = configuration = configuration ?? ChoHL7Configuration.Instance;
            Value = configuration.Decode(value);
        }

        public override string ToString()
        {
            if (Repeats.Count > 0)
            {
                StringBuilder msg = new StringBuilder();
                foreach (var sc in Repeats)
                {
                    if (msg.Length == 0)
                        msg.Append(sc.ToString());
                    else
                        msg.Append("{0}{1}".FormatString(ChoHL7Configuration.Instance.RepeatSeparator, sc.ToString()));
                }
                return msg.ToString();
            }
            else if (Components.Count > 0)
            {
                StringBuilder msg = new StringBuilder();
                foreach (var sc in Components)
                {
                    if (msg.Length == 0)
                        msg.Append(sc.ToString());
                    else
                        msg.Append("{0}{1}".FormatString(ChoHL7Configuration.Instance.ComponentSeparator, sc.ToString()));
                }
                return msg.ToString();
            }
            else
                return Configuration.Encode(Value.ToNString());
        }

        internal static ChoHL7Field Parse(string line, ChoHL7Configuration configuration = null)
        {
            configuration = configuration ?? ChoHL7Configuration.Instance;
            if (line.IsNullOrWhiteSpace() || line.IndexOf(configuration.ComponentSeparator) < 0)
                return new ChoHL7Field(line, configuration);
            else
            {
                ChoHL7Field rec = new ChoHL7Field(null, configuration);

                var components = line.Split(configuration.ComponentSeparator);
                foreach (var comp in components)
                {
                    rec.Components.Add(ChoHL7Component.Parse(comp, configuration));
                }
                return rec;
            }
        }

        public void Validate()
        {
        }
    }
}
