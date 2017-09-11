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
    /// NST: Statistics
    /// </summary>
    public class NST : ChoHL7Segment
    {
        [Description("Statistics Available")]
        [MaxLength(1)]
        public ID StatisticsAvailable
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Source Identifier")]
        [MaxLength(30)]
        public ST SourceIdentifier
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Source Type")]
        [MaxLength(3)]
        public ID SourceType
        {
            get { return GetValueAt<ID>(2); }
        }
        [Description("Statistics Start")]
        [MaxLength(26)]
        public TS StatisticsStart
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Statistics End")]
        [MaxLength(26)]
        public TS StatisticsEnd
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Receive Character Count")]
        [MaxLength(10)]
        public NM ReceiveCharacterCount
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Send Character Count")]
        [MaxLength(10)]
        public NM SendCharacterCount
        {
            get { return GetValueAt<NM>(6); }
        }
        [Description("Messages Received")]
        [MaxLength(10)]
        public NM MessagesReceived
        {
            get { return GetValueAt<NM>(7); }
        }
        [Description("Messages Sent")]
        [MaxLength(10)]
        public NM MessagesSent
        {
            get { return GetValueAt<NM>(8); }
        }
        [Description("Checksum Errors Received")]
        [MaxLength(10)]
        public NM ChecksumErrorsReceived
        {
            get { return GetValueAt<NM>(9); }
        }
        [Description("Length Errors Received")]
        [MaxLength(10)]
        public NM LengthErrorsReceived
        {
            get { return GetValueAt<NM>(10); }
        }
        [Description("Other Errors Received")]
        [MaxLength(10)]
        public NM OtherErrorsReceived
        {
            get { return GetValueAt<NM>(11); }
        }
        [Description("Connect Timeouts")]
        [MaxLength(10)]
        public NM ConnectTimeouts
        {
            get { return GetValueAt<NM>(12); }
        }
        [Description("Receive Timeouts")]
        [MaxLength(10)]
        public NM ReceiveTimeouts
        {
            get { return GetValueAt<NM>(13); }
        }
        [Description("Network Errors")]
        [MaxLength(10)]
        public NM NetworkErrors
        {
            get { return GetValueAt<NM>(14); }
        }
    }
}
