using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    [Serializable]
    public class ChoHL7Exception : ApplicationException
    {
        public ChoHL7Exception()
            : base()
        {
        }

        public ChoHL7Exception(string message)
            : base(message)
        {
        }

        public ChoHL7Exception(string message, Exception e)
            : base(message, e)
        {
        }

        protected ChoHL7Exception(SerializationInfo si, StreamingContext sc)
            : base(si, sc)
        {
        }
    }
}
