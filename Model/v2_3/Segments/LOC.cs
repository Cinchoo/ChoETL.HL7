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
    /// LOC: Location Identification
    /// </summary>
    public class LOC : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(20)]
        public PL PrimaryKeyValue
        {
            get { return GetValueAt<PL>(0); }
        }
        [Description("Location Description")]
        [MaxLength(48)]
        public ST LocationDescription
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Location Type")]
        [Required]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(PatientLocationType))]
        public IS[] LocationType
        {
            get { return GetValuesAt<IS>(2); }
        }
        [Description("Organization Name")]
        [MaxLength(90)]
        public XON OrganizationName
        {
            get { return GetValueAt<XON>(3); }
        }
        [Description("Location Address")]
        [MaxLength(106)]
        public XAD LocationAddress
        {
            get { return GetValueAt<XAD>(4); }
        }
        [Description("Location Phone")]
        [MaxLength(40)]
        public XTN[] LocationPhone
        {
            get { return GetValuesAt<XTN>(5); }
        }
        [Description("License Number")]
        [MaxLength(60)]
        public CE[] LicenseNumber
        {
            get { return GetValuesAt<CE>(6); }
        }
        [Description("Location Equipment")]
        [MaxLength(3)]
        [ChoHL7EnumType(typeof(LocationEquipment))]
        public ID[] LocationEquipment
        {
            get { return GetValuesAt<ID>(7); }
        }
    }
}
