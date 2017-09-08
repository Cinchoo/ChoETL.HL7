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
    /// EQL: Embedded Query Language
    /// </summary>
    public class EQL : ChoHL7Segment
    {
        [Description("Query tag")]
        [MaxLength(32)]
        public ST QueryTag
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("Query/ Response Format Code")]
        [Required]
        [MaxLength(1)]
        public ID QueryResponseFormatCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("EQL Query Name")]
        [Required]
        [MaxLength(60)]
        public CE EQLQueryName
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("EQL Query Statement")]
        [Required]
        [MaxLength(4096)]
        public ST EQLQueryStatement
        {
            get { return GetValueAt<ST>(3); }
        }
    }
}
