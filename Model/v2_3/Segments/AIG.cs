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
    /// AIG: Appointment Information - General Resource
    /// </summary>
    public class AIG : ChoHL7Segment
    {
        [Description("Set ID - AIG")]
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
        [Description("Resource ID")]
        [MaxLength(200)]
        public CE ResourceID
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Resource Type")]
        [Required]
        [MaxLength(200)]
        public CE ResourceType
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Resource Group")]
        [MaxLength(200)]
        public CE[] ResourceGroup
        {
            get { return GetValuesAt<CE>(4); }
        }
        [Description("Resource Quantity")]
        [MaxLength(5)]
        public NM ResourceQuantity
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Resource Quantity Units")]
        [MaxLength(200)]
        public CE ResourceQuantityUnits
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Start Date/Time")]
        [MaxLength(26)]
        public TS StartDateTime
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Start Date/Time Offset")]
        [MaxLength(20)]
        public NM StartDateTimeOffset
        {
            get { return GetValueAt<NM>(8); }
        }
        [Description("Start Date/Time Offset Units")]
        [MaxLength(200)]
        public CE StartDateTimeOffsetUnits
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Duration")]
        [MaxLength(20)]
        public NM Duration
        {
            get { return GetValueAt<NM>(10); }
        }
        [Description("Duration Units")]
        [MaxLength(200)]
        public CE DurationUnits
        {
            get { return GetValueAt<CE>(11); }
        }
        [Description("Allow Substitution Code")]
        [MaxLength(10)]
        [ChoHL7EnumType(typeof(AllowSubstitutionCodes))]
        public IS AllowSubstitutionCode
        {
            get { return GetValueAt<IS>(12); }
        }
        [Description("Filler Status Code")]
        [MaxLength(200)]
        [ChoHL7EnumType(typeof(FillerStatusCode))]
        public CE FillerStatusCode
        {
            get { return GetValueAt<CE>(13); }
        }
    }
}
