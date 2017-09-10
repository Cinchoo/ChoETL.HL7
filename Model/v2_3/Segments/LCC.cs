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
    /// LCC: Location Charge Code
    /// </summary>
    public class LCC : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(200)]
        public PL PrimaryKeyValue
        {
            get { return GetValueAt<PL>(0); }
        }
        [Description("Location Department")]
        [Required]
        [MaxLength(10)]
        public IS LocationDepartment
        {
            get { return GetValueAt<IS>(1); }
        }
        [Description("Accommodation Type")]
        [MaxLength(60)]
        public CE[] AccommodationType
        {
            get { return GetValuesAt<CE>(2); }
        }
        [Description("Charge Code")]
        [MaxLength(60)]
        [Required]
        public CE[] ChargeCode
        {
            get { return GetValuesAt<CE>(3); }
        }
    }
}
