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
    /// PTH: Pathway
    /// </summary>
    public class PTH : ChoHL7Segment
    {
        [Description("Action Code")]
        [Required]
        [MaxLength(2)]
        public ID ActionCode
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Pathway ID")]
        [Required]
        [MaxLength(80)]
        public CE PathwayID
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Pathway Instance ID")]
        [Required]
        [MaxLength(60)]
        public EI PathwayInstanceID
        {
            get { return GetValueAt<EI>(2); }
        }
        [Description("Pathway Established Date/Time")]
        [Required]
        [MaxLength(26)]
        public TS PathwayEstablishedDateTime
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Pathway Lifecycle Status")]
        [MaxLength(80)]
        public CE PathwayLifecycleStatus
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Change Pathway Lifecycle Status Date/Time")]
        [MaxLength(26)]
        public TS ChangePathwayLifecycleStatusDateTime
        {
            get { return GetValueAt<TS>(5); }
        }
    }
}
