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
    /// NCK – System Clock
    /// </summary>
    public class NCK : ChoHL7Segment
    {
        [Description("System Date/Time")]
        [MaxLength(26)]
        public TS SystemDateTime
        {
            get { return GetValueAt<TS>(0); }
        }
    }
}
