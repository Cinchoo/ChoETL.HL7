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
    /// NTE: Notes and comments segmen
    /// </summary>
    public class NTE : ChoHL7Segment
    {
        [Description("Set ID - Notes and Comments")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Source of Comment")]
        [MaxLength(8)]
        public ID SourceofComment
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Comment")]
        [MaxLength(65536)]
        public FT[] Comment
        {
            get { return GetValuesAt<FT>(2); }
        }
    }
}
