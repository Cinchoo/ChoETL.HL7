using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_MSG: Message Type")]
    public class CM_MSG : ChoHL7AbstractField
    {
        [Required]
        public ID MessageType
        {
            get { return GetValueAt<ID>(0); }
        }
        [Required]
        public ID TriggerEvent
        {
            get { return GetValueAt<ID>(1); }
        }

        public CM_MSG(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_MSG(ChoHL7Field field) : base(field)
        {
        }
    }
}
