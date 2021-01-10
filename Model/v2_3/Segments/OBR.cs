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
    /// OBR: Observation request segment
    /// </summary>
    public class OBR : ChoHL7Segment
    {
        [Description("Set ID - Observation Request")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Placer Order Number")]
        [MaxLength(22)]
        public EI[] PlacerOrderNumber
        {
            get { return GetValuesAt<EI>(1); }
        }
        [Description("Filler Order Number")]
        [MaxLength(22)]
        public EI FillerOrderNumber
        {
            get { return GetValueAt<EI>(2); }
        }
        [Description("Universal Service Identifier")]
        [Required]
        [MaxLength(200)]
        public CE UniversalServiceIdentifier
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Priority")]
        [MaxLength(2)]
        public ID Priority
        {
            get { return GetValueAt<ID>(4); }
        }
        [Description("Requested Date/Time")]
        [MaxLength(26)]
        public TS RequestedDateTime
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Observation Date/Time")]
        [MaxLength(26)]
        public TS ObservationDateTime
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Observation End Date/Time")]
        [MaxLength(26)]
        public TS ObservationEndDateTime
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Collection Volume")]
        [MaxLength(20)]
        public CQ CollectionVolume
        {
            get { return GetValueAt<CQ>(8); }
        }
        [Description("Collector Identifier")]
        [MaxLength(60)]
        public XCN[] CollectorIdentifier
        {
            get { return GetValuesAt<XCN>(9); }
        }
        [Description("Specimen Action Code")]
        [MaxLength(1)]
        public ID SpecimenActionCode
        {
            get { return GetValueAt<ID>(10); }
        }
        [Description("Danger Code")]
        [MaxLength(60)]
        public CE DangerCode
        {
            get { return GetValueAt<CE>(11); }
        }
        [Description("Relevant Clinical Information")]
        [MaxLength(300)]
        public ST RelevantClinicalInformation
        {
            get { return GetValueAt<ST>(12); }
        }
        [Description("Specimen Received Date/Time")]
        [MaxLength(26)]
        public TS SpecimenReceivedDateTime
        {
            get { return GetValueAt<TS>(13); }
        }
        [Description("Specimen Source")]
        [MaxLength(300)]
        public CM_SPS SpecimenSource
        {
            get { return GetValueAt<CM_SPS>(14); }
        }
        [Description("Ordering Provider")]
        [MaxLength(120)]
        public XCN[] OrderingProvider
        {
            get { return GetValuesAt<XCN>(15); }
        }
        [Description("Order Callback Phone Number")]
        [MaxLength(40)]
        [ChoHL7MaxCount(2)]
        public XTN[] OrderCallbackPhoneNumber
        {
            get { return GetValuesAt<XTN>(16); }
        }
        [Description("Placer Field 1")]
        [MaxLength(60)]
        public ST PlacerField1
        {
            get { return GetValueAt<ST>(17); }
        }
        [Description("Placer Field 2")]
        [MaxLength(60)]
        public ST PlacerField2
        {
            get { return GetValueAt<ST>(18); }
        }
        [Description("Filler Field 1")]
        [MaxLength(60)]
        public ST FillerField1
        {
            get { return GetValueAt<ST>(19); }
        }
        [Description("Filler Field 2")]
        [MaxLength(60)]
        public ST FillerField2
        {
            get { return GetValueAt<ST>(20); }
        }
        [Description("Results Rpt/Status Chng - Date/Time")]
        [MaxLength(26)]
        public TS ResultsRptStatusChngDateTime
        {
            get { return GetValueAt<TS>(21); }
        }
        [Description("Charge To Practice")]
        [MaxLength(40)]
        public CM_MOC ChargeToPractice
        {
            get { return GetValueAt<CM_MOC>(22); }
        }
        [Description("Diagnostic Service Section ID")]
        [MaxLength(10)]
        public ID DiagnosticServiceSectionID
        {
            get { return GetValueAt<ID>(23); }
        }
        [Description("Result Status")]
        [MaxLength(1)]
        public ID ResultStatus
        {
            get { return GetValueAt<ID>(24); }
        }
        [Description("Parent Result")]
        [MaxLength(200)]
        public CM_PRL ParentResult
        {
            get { return GetValueAt<CM_PRL>(25); }
        }
        [Description("Quantity/Timing")]
        [MaxLength(200)]
        public TQ QuantityTiming
        {
            get { return GetValueAt<TQ>(26); }
        }
        [Description("Result Copies To")]
        [MaxLength(150)]
        [ChoHL7MaxCount(5)]
        public XCN ResultCopiesTo
        {
            get { return GetValueAt<XCN>(27); }
        }
        [Description("Parent Number")]
        [MaxLength(150)]
        public CM_EIP ParentNumber
        {
            get { return GetValueAt<CM_EIP>(28); }
        }
        [Description("Transportation Mode")]
        [MaxLength(20)]
        public ID TransportationMode
        {
            get { return GetValueAt<ID>(29); }
        }
        [Description("Reason For Study")]
        [MaxLength(300)]
        public CE[] ReasonForStudy
        {
            get { return GetValuesAt<CE>(30); }
        }
        [Description("Principal Result Interpreter")]
        [MaxLength(200)]
        public CM_NDL PrincipalResultInterpreter
        {
            get { return GetValueAt<CM_NDL>(31); }
        }
        [Description("Assistant  Result Interpreter")]
        [MaxLength(200)]
        public CM_NDL[] AssistantResultInterpreter
        {
            get { return GetValuesAt<CM_NDL>(32); }
        }
        [Description("Technician")]
        [MaxLength(200)]
        public CM_NDL[] Technician
        {
            get { return GetValuesAt<CM_NDL>(33); }
        }
        [Description("Transcriptionist")]
        [MaxLength(200)]
        public CM_NDL[] Transcriptionist
        {
            get { return GetValuesAt<CM_NDL>(34); }
        }
        [Description("Scheduled Date/Time")]
        [MaxLength(26)]
        public TS ScheduledDateTime
        {
            get { return GetValueAt<TS>(35); }
        }
        [Description("Number Of Sample Containers")]
        [MaxLength(4)]
        public NM NumberOfSampleContainers
        {
            get { return GetValueAt<NM>(36); }
        }
        [Description("Transport Logistics Of Collected Sample")]
        [MaxLength(60)]
        public CE[] TransportLogisticsOfCollectedSample
        {
            get { return GetValuesAt<CE>(37); }
        }
        [Description("Collector s Comment")]
        [MaxLength(200)]
        public CE[] CollectorsComment
        {
            get { return GetValuesAt<CE>(38); }
        }
        [Description("Transport Arrangement Responsibility")]
        [MaxLength(60)]
        public CE TransportArrangementResponsibility
        {
            get { return GetValueAt<CE>(39); }
        }
        [Description("Transport Arranged")]
        [MaxLength(30)]
        public ID TransportArranged
        {
            get { return GetValueAt<ID>(40); }
        }
        [Description("Escort Required")]
        [MaxLength(1)]
        public ID EscortRequired
        {
            get { return GetValueAt<ID>(41); }
        }
        [Description("Planned Patient Transport Comment")]
        [MaxLength(200)]
        public CE[] PlannedPatientTransportComment
        {
            get { return GetValuesAt<CE>(42); }
        }
    }

}
