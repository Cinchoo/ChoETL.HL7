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
    /// ERR: Error segment
    /// </summary>
    public class ERR : ChoHL7Segment
    {
        [Description("Error Code and Location")]
        [MaxLength(80)]
        public CM_ELD[] ErrorCodeAndLocation
        {
            get { return GetValuesAt<CM_ELD>(0); }
        }
    }
}
