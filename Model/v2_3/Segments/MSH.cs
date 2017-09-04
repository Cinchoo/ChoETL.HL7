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
    /// MSH – Message Header
    /// </summary>
    public class MSH : ChoHL7Segment
    {
        [Description("Field Separator")]
        [Required]
        [MaxLength(1)]
        public ST FieldSeperator
        {
            get { return new ST("|"); }
        }

        [Description("Encoding Characters")]
        [Required]
        [MaxLength(4)]
        public ST EncodingCharacters
        {
            get { return GetValueAt<ST>(0); }
        }

        [Description("Sending Application")]
        [MaxLength(180)]
        public HD SendingApplication
        {
            get { return GetValueAt<HD>(1); }
        }

        [Description("Sending Facility")]
        [MaxLength(180)]
        public HD SendingFacility
        {
            get { return GetValueAt<HD>(2); }
        }

        [Description("Receiving Application")]
        [MaxLength(180)]
        public HD ReceivingApplication
        {
            get { return GetValueAt<HD>(3); }
        }

        [Description("Receiving Facility")]
        [MaxLength(180)]
        public HD ReceivingFacility
        {
            get { return GetValueAt<HD>(4); }
        }

        [Description("Date / Time of Message")]
        [MaxLength(26)]
        public TS Timestamp
        {
            get { return GetValueAt<TS>(5); }
        }

        [Description("Security")]
        [MaxLength(40)]
        public ST Security
        {
            get { return GetValueAt<ST>(6); }
        }

        [Description("Message Type")]
        [Required]
        [MaxLength(7)]
        public CM_MSG MessageType
        {
            get { return GetValueAt<CM_MSG>(7); }
        }

        [Description("Message Control ID")]
        [Required]
        [MaxLength(20)]
        public ST MessageControlId
        {
            get { return GetValueAt<ST>(8); }
        }

        [Description("Processing ID")]
        [Required]
        [MaxLength(3)]
        public PT ProcessingID
        {
            get { return GetValueAt<PT>(9); }
        }

        [Description("Version ID")]
        [Required]
        [MaxLength(8)]
        public ID VersionID
        {
            get { return GetValueAt<ID>(10); }
        }

        [Description("Sequence Number")]
        [MaxLength(15)]
        public NM SequenceNumber
        {
            get { return GetValueAt<NM>(11); }
        }

        [Description("Continuation Pointer")]
        [MaxLength(180)]
        public ST ContinuationPointer
        {
            get { return GetValueAt<ST>(12); }
        }

        [Description("Accept Acknowledgment Type")]
        [MaxLength(2)]
        public ID AcceptAcknowledgmentType
        {
            get { return GetValueAt<ID>(13); }
        }

        [Description("Application Acknowledgment Type")]
        [MaxLength(2)]
        public ID ApplicationAcknowledgmentType
        {
            get { return GetValueAt<ID>(14); }
        }

        [Description("Country Code")]
        [MaxLength(2)]
        public ID CountryCode
        {
            get { return GetValueAt<ID>(15); }
        }

        [Description("Character Set")]
        [MaxLength(6)]
        public ID CharacterSet
        {
            get { return GetValueAt<ID>(16); }
        }

        [Description("Principal Language of Message")]
        [MaxLength(3)]
        public CE PrincipalLanguageOfMessage
        {
            get { return GetValueAt<CE>(17); }
        }
    }
}
