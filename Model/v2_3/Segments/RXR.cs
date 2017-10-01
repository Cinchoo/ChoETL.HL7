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
    /// RXR: Pharmacy route segment
    /// </summary>
    public class RXR : ChoHL7Segment
    {
        [Description("Route")]
        [Required]
        [MaxLength(60)]
        public CE Route
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Site")]
        [MaxLength(60)]
        public CE Site
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Administration Device")]
        [MaxLength(60)]
        public CE AdministrationDevice
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Administration Method")]
        [MaxLength(60)]
        public CE AdministrationMethod
        {
            get { return GetValueAt<CE>(3); }
        }
    }
}
