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
    /// RDT: Table Row Data
    /// </summary>
    public class RDT : ChoHL7Segment
    {
        [Description("Column value")]
        [Required]
        public VARIES ColumnValue
        {
            get { return GetValueAt<VARIES>(0); }
        }
    }
}
