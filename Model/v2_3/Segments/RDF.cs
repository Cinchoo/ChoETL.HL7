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
    /// RDF: Table Row Definition
    /// </summary>
    public class RDF : ChoHL7Segment
    {
        [Description("Number of Columns per Row")]
        [Required]
        [MaxLength(3)]
        public NM NumberofColumnsperRow
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("Column Description")]
        [MaxLength(40)]
        public RCD[] ColumnDescription
        {
            get { return GetValuesAt<RCD>(1); }
        }
    }
}
