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
    /// RGS: Resource Group
    /// </summary>
    public class RGS : ChoHL7Segment
    {
        [Description("Referral Status")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Segment Action Code")]
        [MaxLength(3)]
        public ID SegmentActionCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Resource Group ID")]
        [MaxLength(200)]
        public CE ResourceGroupID
        {
            get { return GetValueAt<CE>(2); }
        }
    }
}
