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
    /// ADD: Addendum
    /// </summary>
    public class ADD : ChoHL7Segment
    {
        [Description("Addendum Continuation Pointer")]
        [MaxLength(65536)]
        public ST AddendumContinuationPointer
        {
            get { return GetValueAt<ST>(0); }
        }
    }
}
