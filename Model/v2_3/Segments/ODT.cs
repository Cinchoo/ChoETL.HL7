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
    /// ODT: Diet tray instructions segment
    /// </summary>
    public class ODT : ChoHL7Segment
    {
        [Description("Tray Type")]
        [Required]
        [MaxLength(60)]
        public CE TrayType
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Service Period")]
        [MaxLength(60)]
        [ChoHL7MaxCount(10)]
        public CE[] ServicePeriod
        {
            get { return GetValuesAt<CE>(1); }
        }
        [Description("Text Instruction")]
        [Required]
        [MaxLength(80)]
        public ST TextInstruction
        {
            get { return GetValueAt<ST>(2); }
        }
    }
}
