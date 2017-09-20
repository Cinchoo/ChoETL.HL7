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
    /// PES: Product Experience Sender
    /// </summary>
    public class PES : ChoHL7Segment
    {
        [Description("Sender Organization Name")]
        [MaxLength(80)]
        public XON SenderOrganizationName
        {
            get { return GetValueAt<XON>(0); }
        }
        [Description("Sender Individual Name")]
        [MaxLength(60)]
        public XCN[] SenderIndividualName
        {
            get { return GetValuesAt<XCN>(1); }
        }
        [Description("Sender Address")]
        [MaxLength(200)]
        public XAD[] SenderAddress
        {
            get { return GetValuesAt<XAD>(2); }
        }
        [Description("Sender Telephone")]
        [MaxLength(44)]
        public XTN[] SenderTelephone
        {
            get { return GetValuesAt<XTN>(3); }
        }
        [Description("Sender Event Identifier")]
        [MaxLength(30)]
        public EI SenderEventIdentifier
        {
            get { return GetValueAt<EI>(4); }
        }
        [Description("Sender Sequence Number")]
        [MaxLength(2)]
        public NM SenderSequenceNumber
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Sender Event Description")]
        [MaxLength(600)]
        public FT[] SenderEventDescription
        {
            get { return GetValuesAt<FT>(6); }
        }
        [Description("Sender Comment")]
        [MaxLength(600)]
        public FT SenderComment
        {
            get { return GetValueAt<FT>(7); }
        }
        [Description("Sender Aware Date/Time")]
        [MaxLength(26)]
        public TS SenderAwareDateTime
        {
            get { return GetValueAt<TS>(8); }
        }
        [Description("Event Report Date")]
        [MaxLength(26)]
        [Required]
        public TS EventReportDate
        {
            get { return GetValueAt<TS>(9); }
        }
        [Description("Event Report Timing/Type")]
        [MaxLength(3)]
        [ChoHL7MaxCount(2)]
        public ID[] EventReportTimingType
        {
            get { return GetValuesAt<ID>(10); }
        }
        [Description("Event Report Source")]
        [MaxLength(1)]
        public ID EventReportSource
        {
            get { return GetValueAt<ID>(11); }
        }
        [Description("Event Reported To")]
        [MaxLength(1)]
        public ID[] EventReportedTo
        {
            get { return GetValuesAt<ID>(12); }
        }
    }
}
