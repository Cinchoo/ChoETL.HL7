//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ChoETL.HL7.Model.v2_3
//{
//    /// <summary>
//    /// AUT: Authorization Information
//    /// </summary>
//    public class AUT : ChoHL7Segment
//    {
//        [Description("Authorizing Payer, Plan Code")]
//        [MaxLength(200)]
//        public CE AuthorizingPayerPlanCode
//        {
//            get { return GetValueAt<CE>(0); }
//        }
//        [Description("Authorizing Payer, Company ID")]
//        [MaxLength(200)]
//        public CE AuthorizingPayerPlanCode
//        {
//            get { return GetValueAt<CE>(0); }
//        }
//        [Description("Occurrence Number")]
//        [Required]
//        [MaxLength(5)]
//        public NM OccurrenceNumber
//        {
//            get { return GetValueAt<NM>(2); }
//        }
//        [Description("Placer Group Number")]
//        [MaxLength(75)]
//        public EI PlacerGroupNumber
//        {
//            get { return GetValueAt<EI>(3); }
//        }
//        [Description("Schedule ID")]
//        [MaxLength(200)]
//        public CE ScheduleID
//        {
//            get { return GetValueAt<CE>(4); }
//        }
//        [Description("Request Event Reason")]
//        [MaxLength(200)]
//        public CE RequestEventReason
//        {
//            get { return GetValueAt<CE>(5); }
//        }
//        [Description("Appointment Reason")]
//        [MaxLength(200)]
//        [ChoHL7EnumType(typeof(AppointmentReasonCodes))]
//        public CE AppointmentReason
//        {
//            get { return GetValueAt<CE>(6); }
//        }
//        [Description("Appointment Type")]
//        [MaxLength(200)]
//        [ChoHL7EnumType(typeof(AppointmentTypeCodes))]
//        public CE AppointmentType
//        {
//            get { return GetValueAt<CE>(7); }
//        }
//        [Description("Appointment Duration")]
//        [MaxLength(20)]
//        public NM AppointmentDuration
//        {
//            get { return GetValueAt<NM>(8); }
//        }
//        [Description("Appointment Duration Units")]
//        [MaxLength(200)]
//        public CE AppointmentDurationUnits
//        {
//            get { return GetValueAt<CE>(9); }
//        }
//        [Description("Requested Start Date/Time Range")]
//        [MaxLength(53)]
//        public DR[] RequestedStartDateTimeRange
//        {
//            get { return GetValuesAt<DR>(10); }
//        }
//        [Description("Priority")]
//        [MaxLength(5)]
//        public ST Priority
//        {
//            get { return GetValueAt<ST>(11); }
//        }
//        [Description("Repeating Interval")]
//        [MaxLength(100)]
//        public RI RepeatingInterval
//        {
//            get { return GetValueAt<RI>(12); }
//        }
//        [Description("Repeating Interval Duration")]
//        [MaxLength(5)]
//        public ST RepeatingIntervalDuration
//        {
//            get { return GetValueAt<ST>(13); }
//        }
//        [Description("Placer Contact Person")]
//        [MaxLength(48)]
//        [Required]
//        public XCN PlacerContactPerson
//        {
//            get { return GetValueAt<XCN>(14); }
//        }
//        [Description("Placer Contact Phone Number")]
//        [MaxLength(40)]
//        public XTN[] PlacerContactPhoneNumber
//        {
//            get { return GetValuesAt<XTN>(15); }
//        }
//        [Description("Placer Contact Address")]
//        [MaxLength(106)]
//        public XAD PlacerContactAddress
//        {
//            get { return GetValueAt<XAD>(16); }
//        }
//        [Description("Placer Contact Location")]
//        [MaxLength(80)]
//        public PL PlacerContactLocation
//        {
//            get { return GetValueAt<PL>(17); }
//        }
//        [Description("Entered By Person")]
//        [MaxLength(48)]
//        [Required]
//        public XCN EnteredByPerson
//        {
//            get { return GetValueAt<XCN>(18); }
//        }
//        [Description("Entered By Phone Number")]
//        [MaxLength(40)]
//        public XTN[] EnteredByPhoneNumber
//        {
//            get { return GetValuesAt<XTN>(19); }
//        }
//        [Description("Entered By Location")]
//        [MaxLength(80)]
//        public PL EnteredByLocation
//        {
//            get { return GetValueAt<PL>(20); }
//        }
//        [Description("Parent Placer Appointment ID")]
//        [MaxLength(75)]
//        public EI ParentPlacerAppointmentID
//        {
//            get { return GetValueAt<EI>(21); }
//        }
//        [Description("Parent Filler Appointment ID")]
//        [MaxLength(75)]
//        public EI ParentFillerAppointmentID
//        {
//            get { return GetValueAt<EI>(22); }
//        }
//    }
//}
