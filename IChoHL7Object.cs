using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7
{
    public interface IChoHL7Object
    {
        ChoHL7Configuration Configuration
        {
            get;
            set;
        }

        void Validate();
    }
}
