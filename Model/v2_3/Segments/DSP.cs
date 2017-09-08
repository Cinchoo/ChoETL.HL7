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
    /// DSP: Display data segment
    /// </summary>
    public class DSP : ChoHL7Segment
    {
        [Description("Set ID - Display Data")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Display Level")]
        [MaxLength(4)]
        public SI DisplayLevel
        {
            get { return GetValueAt<SI>(1); }
        }
        [Description("Data Line")]
        [Required]
        [MaxLength(300)]
        public TX DataLine
        {
            get { return GetValueAt<TX>(2); }
        }
        [Description("Logical Break Point")]
        [MaxLength(2)]
        public ST LogicalBreakPoint
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Result ID")]
        [MaxLength(20)]
        public TX ResultID
        {
            get { return GetValueAt<TX>(4); }
        }
    }
}
