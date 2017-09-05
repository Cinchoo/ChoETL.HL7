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
    /// AIL: Appointment Information - Location
    /// </summary>
    public class AIL : ChoHL7Segment
    {
        [Description("Set ID - AIL")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Segment Action Code")]
        [MaxLength(1)]
        public ID SegmentActionCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Location Resource ID")]
        [Required]
        [MaxLength(80)]
        public PL LocationResourceID
        {
            get { return GetValueAt<PL>(2); }
        }
        [Description("Location Type")]
        [MaxLength(200)]
        public CE LocationType
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Location Group")]
        [MaxLength(200)]
        public CE[] LocationGroup
        {
            get { return GetValuesAt<CE>(4); }
        }
        [Description("Start Date/Time")]
        [MaxLength(26)]
        public TS StartDateTime
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Start Date/Time Offset")]
        [MaxLength(20)]
        public NM StartDateTimeOffset
        {
            get { return GetValueAt<NM>(6); }
        }
        [Description("Start Date/Time Offset Units")]
        [MaxLength(200)]
        public CE StartDateTimeOffsetUnits
        {
            get { return GetValueAt<CE>(7); }
        }
        [Description("Duration")]
        [MaxLength(20)]
        public NM Duration
        {
            get { return GetValueAt<NM>(8); }
        }
        [Description("Duration Units")]
        [MaxLength(200)]
        public CE DurationUnits
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Allow Substitution Code")]
        [MaxLength(10)]
        [ChoHL7EnumType(typeof(AllowSubstitutionCodes))]
        public IS AllowSubstitutionCode
        {
            get { return GetValueAt<IS>(10); }
        }
        [Description("Filler Status Code")]
        [MaxLength(200)]
        [ChoHL7EnumType(typeof(FillerStatusCode))]
        public CE FillerStatusCode
        {
            get { return GetValueAt<CE>(11); }
        }
    }
}
