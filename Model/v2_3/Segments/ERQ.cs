using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// ERQ: Event Replay Query Segment
    /// </summary>
    public class ERQ : ChoHL7Segment
    {
        [Description("Query tag")]
        [MaxLength(32)]
        public ST QueryTag
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("Event identifier")]
        [Required]
        [MaxLength(60)]
        public CE EventIdentifier
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Input parameter list")]
        [Required]
        [MaxLength(256)]
        public QIP[] InputParameterList
        {
            get { return GetValuesAt<QIP>(2); }
        }
    }
}
