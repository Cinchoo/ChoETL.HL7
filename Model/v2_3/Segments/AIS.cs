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
    /// AIS: Appointment Information - Service
    /// </summary>
    public class AIS : ChoHL7Segment
    {
        [Description("Set ID - AIS")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Segment Action Code")]
        [MaxLength(3)]
        public ID SegmentActionCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Universal Service Identifier")]
        [Required]
        [MaxLength(200)]
        public CE UniversalServiceIdentifier
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Start Date/Time")]
        [MaxLength(26)]
        public TS StartDateTime
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Start Date/Time Offset")]
        [MaxLength(20)]
        public NM StartDateTimeOffset
        {
            get { return GetValueAt<NM>(4); }
        }
        [Description("Start Date/Time Offset Units")]
        [MaxLength(200)]
        public CE StartDateTimeOffsetUnits
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Duration")]
        [MaxLength(20)]
        public NM Duration
        {
            get { return GetValueAt<NM>(6); }
        }
        [Description("Duration Units")]
        [MaxLength(200)]
        public CE DurationUnits
        {
            get { return GetValueAt<CE>(7); }
        }
        [Description("Allow Substitution Code")]
        [MaxLength(10)]
        [ChoHL7EnumType(typeof(AllowSubstitutionCodes))]
        public IS AllowSubstitutionCode
        {
            get { return GetValueAt<IS>(8); }
        }
        [Description("Filler Status Code")]
        [MaxLength(200)]
        [ChoHL7EnumType(typeof(FillerStatusCode))]
        public CE FillerStatusCode
        {
            get { return GetValueAt<CE>(9); }
        }
    }
}
