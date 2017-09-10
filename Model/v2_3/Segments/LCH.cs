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
    /// LCH: Location Characteristic
    /// </summary>
    public class LCH : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(20)]
        public PL PrimaryKeyValue
        {
            get { return GetValueAt<PL>(0); }
        }
        [Description("Segment Action Code")]
        [MaxLength(3)]
        public ID SegmentActionCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Segment Unique Key")]
        [MaxLength(80)]
        public EI SegmentUniqueKey
        {
            get { return GetValueAt<EI>(2); }
        }
        [Description("Location Characteristic ID")]
        [MaxLength(80)]
        [Required]
        public CE LocationCharacteristicID
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Location Characteristic Value")]
        [MaxLength(80)]
        [Required]
        public CE LocationCharacteristicValue
        {
            get { return GetValueAt<CE>(4); }
        }
    }
}
