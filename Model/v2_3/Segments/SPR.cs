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
    /// SPR: Stored Procedure Request Definition
    /// </summary>
    public class SPR : ChoHL7Segment
    {
        [Description("Query tag")]
        [MaxLength(32)]
        public ST Querytag
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("Query/ Response Format Code")]
        [MaxLength(1)]
        [Required]
        public ID QueryResponseFormatCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Stored procedure name")]
        [MaxLength(60)]
        [Required]
        public CE StoredProcedureName
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Input parameter list")]
        [MaxLength(256)]
        public QIP InputParameterList
        {
            get { return GetValueAt<QIP>(3); }
        }
    }
}
