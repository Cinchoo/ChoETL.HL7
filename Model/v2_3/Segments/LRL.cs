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
    /// LRL: Location Relationship
    /// </summary>
    public class LRL : ChoHL7Segment
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
        [Description("Location Relationship ID")]
        [MaxLength(80)]
        public CE LocationRelationshipID
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Organizational Location Relationship Value")]
        public XON OrganizationalLocationRelationshipValue
        {
            get { return GetValueAt<XON>(4); }
        }
        [Description("Patient Location Relationship Value")]
        [MaxLength(80)]
        public PL PatientLocationRelationshipValue
        {
            get { return GetValueAt<PL>(5); }
        }
    }
}
