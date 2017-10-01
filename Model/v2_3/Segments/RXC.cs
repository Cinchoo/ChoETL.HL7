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
    /// RXC: Pharmacy component order segment
    /// </summary>
    public class RXC : ChoHL7Segment
    {
        [Description("RX Component Type")]
        [Required]
        [MaxLength(1)]
        public ID RXComponentType
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Component Code")]
        [Required]
        [MaxLength(100)]
        public CE ComponentCode
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("ComponentAmount")]
        [Required]
        [MaxLength(20)]
        public NM ComponentAmount
        {
            get { return GetValueAt<NM>(2); }
        }
        [Description("Component Units")]
        [Required]
        [MaxLength(60)]
        public TS ComponentUnits
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Component Strength")]
        [MaxLength(20)]
        public NM ComponentStrength
        {
            get { return GetValueAt<NM>(4); }
        }
        [Description("Component Strength Units")]
        [MaxLength(60)]
        public CE ComponentStrengthUnits
        {
            get { return GetValueAt<CE>(5); }
        }
    }
}
