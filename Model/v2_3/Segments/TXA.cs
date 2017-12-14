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
    /// TXA: Document notification segment
    /// </summary>
    public class TXA : ChoHL7Segment
    {
        [Description("Set ID")]
        [Required]
        [MaxLength(4)]
        public SI SetID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("DocumentType")]
        [MaxLength(30)]
        [ChoHL7EnumType(typeof(DocumentType))]
        public IS DocumentType
        {
            get { return GetValueAt<IS>(1); }
        }
        [Description("Document Content Presentation")]
        [MaxLength(2)]
        public ID DocumentContentPresentation
        {
            get { return GetValueAt<ID>(2); }
        }
        [Description("Activity Date/Time")]
        [MaxLength(26)]
        public TS ActivityDateTime
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Primary Activity Provider Code/Name")]
        [MaxLength(60)]
        public XCN PrimaryActivityProviderCodeName
        {
            get { return GetValueAt<XCN>(4); }
        }
        [Description("Origination Date/Time")]
        [MaxLength(26)]
        public TS OriginationDateTime
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Transcription Date/Time")]
        [MaxLength(26)]
        public TS TranscriptionDateTime
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Edit Date/Time")]
        [MaxLength(26)]
        public TS[] EditDateTime
        {
            get { return GetValuesAt<TS>(7); }
        }
        [Description("Originator Code/Name")]
        [MaxLength(60)]
        public XCN OriginatorCodeName
        {
            get { return GetValueAt<XCN>(8); }
        }
        [Description("Assigned Document Authenticator")]
        [MaxLength(60)]
        public XCN[] AssignedDocumentAuthenticator
        {
            get { return GetValuesAt<XCN>(9); }
        }
        [Description("Transcriptionist Code/Name")]
        [MaxLength(48)]
        public XCN TranscriptionistCodeName
        {
            get { return GetValueAt<XCN>(10); }
        }
        [Description("Unique Document Number")]
        [MaxLength(30)]
        [Required]
        public EI UniqueDocumentNumber
        {
            get { return GetValueAt<EI>(11); }
        }
        [Description("Parent Document Number")]
        [MaxLength(30)]
        public EI ParentDocumentNumber
        {
            get { return GetValueAt<EI>(12); }
        }
        [Description("Placer Order Number")]
        [MaxLength(22)]
        public EI[] PlacerOrderNumber
        {
            get { return GetValuesAt<EI>(13); }
        }
        [Description("Filler Order Number")]
        [MaxLength(22)]
        public EI FillerOrderNumber
        {
            get { return GetValueAt<EI>(14); }
        }
        [Description("Unique Document File Name")]
        [MaxLength(30)]
        public ST UniqueDocumentFileName
        {
            get { return GetValueAt<ST>(15); }
        }
        [Description("Document Completion Status")]
        [MaxLength(2)]
        [Required]
        public ID[] DocumentCompletionStatus
        {
            get { return GetValuesAt<ID>(16); }
        }
        [Description("Document Confidentiality Status")]
        [MaxLength(2)]
        public ID DocumentConfidentialityStatus
        {
            get { return GetValueAt<ID>(17); }
        }
        [Description("Document Availability Status")]
        [MaxLength(2)]
        public ID DocumentAvailabilityStatus
        {
            get { return GetValueAt<ID>(18); }
        }
        [Description("Document Storage Status")]
        [MaxLength(2)]
        public ID DocumentStorageStatus
        {
            get { return GetValueAt<ID>(19); }
        }
        [Description("Document Change Reason")]
        [MaxLength(30)]
        public ST DocumentChangeReason
        {
            get { return GetValueAt<ST>(20); }
        }
        [Description("Authentication Person, Time Stamp")]
        [MaxLength(60)]
        public PPN[] AuthenticationPersonTimeStamp
        {
            get { return GetValuesAt<PPN>(21); }
        }
        [Description("Distributed Copies")]
        [MaxLength(60)]
        public XCN DistributedCopies
        {
            get { return GetValueAt<XCN>(22); }
        }
    }
}
