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
    /// NPU – Bed status update
    /// </summary>
    public class NPU : ChoHL7Segment
    {
        [Description("Bed Location")]
        [Required]
        [MaxLength(12)]
        public PL BedLocation
        {
            get { return GetValueAt<PL>(0); }
        }
        [Description("Bed Status")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(BedStatus))]
        public IS BedStatus
        {
            get { return GetValueAt<IS>(1); }
        }
    }
}
