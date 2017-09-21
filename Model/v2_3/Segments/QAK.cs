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
    /// QAK: Query Acknowledgement
    /// </summary>
    public class QAK : ChoHL7Segment
    {
        [Description("Query tag")]
        [MaxLength(32)]
        public ST Querytag
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("Query response status")]
        [MaxLength(2)]
        public ID QueryResponseStatus
        {
            get { return GetValueAt<ID>(1); }
        }
    }
}
