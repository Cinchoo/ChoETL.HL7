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
    /// DSC: Continuation pointer segment
    /// </summary>
    public class DSC : ChoHL7Segment
    {
        [Description("Continuation Pointer")]
        [Required]
        [MaxLength(180)]
        public ST ContinuationPointer
        {
            get { return GetValueAt<ST>(0); }
        }
    }
}
