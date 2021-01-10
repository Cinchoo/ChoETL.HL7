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
    /// SCH: Schedule Activity Information
    /// </summary>
    public class SCH : ChoHL7Segment
    {
        [Description("Placer Appointment ID")]
        [Required]
        [MaxLength(22)]
        public EI PlacerAppointmentID
        {
            get { return GetValueAt<EI>(0); }
        }
        [Description("Filler Appointment ID")]
        [MaxLength(22)]
        public EI FillerAppointmentID
        {
            get { return GetValueAt<EI>(1); }
        }
        [Description("Occurrence Number")]
        [MaxLength(5)]
        public NM OccurrenceNumber
        {
            get { return GetValueAt<NM>(2); }
        }
        [Description("Placer Group Number")]
        [MaxLength(37)]
        public EI PlacerGroupNumber
        {
            get { return GetValueAt<EI>(3); }
        }
        [Description("Schedule ID")]
        [MaxLength(200)]
        public CE ScheduleID
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Event Reason")]
        [MaxLength(200)]
        [Required]
        public CE EventReason
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Appointment Reason")]
        [MaxLength(200)]
        public CE AppointmentReason
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Appointment Type")]
        [MaxLength(200)]
        public CE AppointmentType
        {
            get { return GetValueAt<CE>(7); }
        }
        [Description("Appointment Duration")]
        [MaxLength(20)]
        public NM AppointmentDuration
        {
            get { return GetValueAt<NM>(8); }
        }
        [Description("Appointment Duration Units")]
        [MaxLength(200)]
        public CE AppointmentDurationUnits
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Appointment Timing Quantity")]
        [MaxLength(200)]
        [Required]
        public TQ[] AppointmentTimingQuantity
        {
            get { return GetValuesAt<TQ>(10); }
        }
        [Description("Placer Contact Person")]
        [MaxLength(48)]
        public XCN PlacerContactPerson
        {
            get { return GetValueAt<XCN>(11); }
        }
        [Description("Placer Contact Phone Number")]
        [MaxLength(40)]
        public XTN PlacerContactPhoneNumber
        {
            get { return GetValueAt<XTN>(12); }
        }
        [Description("Placer Contact Address")]
        [MaxLength(106)]
        public XAD PlacerContactAddress
        {
            get { return GetValueAt<XAD>(13); }
        }
        [Description("Placer Contact Location")]
        [MaxLength(80)]
        public PL PlacerContactLocation
        {
            get { return GetValueAt<PL>(14); }
        }
        [Description("Filler Contact Person")]
        [MaxLength(38)]
        [Required]
        public XCN FillerContactPerson
        {
            get { return GetValueAt<XCN>(15); }
        }
        [Description("Filler Contact Phone Number")]
        [MaxLength(40)]
        public XTN FillerContactPhoneNumber
        {
            get { return GetValueAt<XTN>(16); }
        }
        [Description("Filler Contact Address")]
        [MaxLength(106)]
        public XAD FillerContactAddress
        {
            get { return GetValueAt<XAD>(17); }
        }
        [Description("Filler Contact Location")]
        [MaxLength(80)]
        public PL FillerContactLocation
        {
            get { return GetValueAt<PL>(18); }
        }
        [Description("Entered By Person")]
        [MaxLength(48)]
        [Required]
        public XCN EnteredByPerson
        {
            get { return GetValueAt<XCN>(19); }
        }
        [Description("Entered By Phone Number")]
        [MaxLength(40)]
        public XTN[] EnteredByPhoneNumber
        {
            get { return GetValuesAt<XTN>(20); }
        }
        [Description("Entered By Location")]
        [MaxLength(25)]
        public PL EnteredByLocation
        {
            get { return GetValueAt<PL>(21); }
        }
        [Description("Parent Placer Appointment ID")]
        [MaxLength(75)]
        public EI ParentPlacerAppointmentID
        {
            get { return GetValueAt<EI>(22); }
        }
        [Description("Parent Filler Appointment ID")]
        [MaxLength(75)]
        public EI ParentFillerAppointmentID
        {
            get { return GetValueAt<EI>(23); }
        }
        [Description("Filler Status Code")]
        [MaxLength(200)]
        public CE FillerStatusCode
        {
            get { return GetValueAt<CE>(24); }
        }
    }
}
