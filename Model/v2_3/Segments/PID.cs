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
    /// PID: Patient Identification Segment
    /// </summary>
    public class PID : ChoHL7Segment
    {
        [Description("Patient ID")]
        [MaxLength(4)]
        public SI PatientID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Patient External ID")]
        [MaxLength(20)]
        public CX PatientExternalID
        {
            get { return GetValueAt<CX>(1); }
        }
        [Description("Patient Internal ID")]
        [Required]
        [MaxLength(20)]
        public CX[] PatientInternalID
        {
            get { return GetValuesAt<CX>(2); }
        }
        [Description("Alternate Patient Internal ID")]
        [MaxLength(20)]
        public CX[] AlternatePatientInternalID
        {
            get { return GetValuesAt<CX>(3); }
        }
        [Description("Patient Name")]
        [Required]
        [MaxLength(48)]
        public XPN[] PatientName
        {
            get { return GetValuesAt<XPN>(4); }
        }
        [Description("Mother’s Maiden Name")]
        [MaxLength(48)]
        public XPN MothersMaidenName
        {
            get { return GetValueAt<XPN>(5); }
        }
        [Description("Date/Time of Birth")]
        [MaxLength(26)]
        public TS DateOfBirth
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Sex")]
        [MaxLength(1)]
        public IS Sex
        {
            get { return GetValueAt<IS>(7); }
        }
        [Description("Patient Alias")]
        [MaxLength(48)]
        public XPN[] PatientAlias
        {
            get { return GetValuesAt<XPN>(8); }
        }
        [Description("Race")]
        [MaxLength(1)]
        public IS Race
        {
            get { return GetValueAt<IS>(9); }
        }
        [Description("Patient Address")]
        [MaxLength(106)]
        public XAD[] PatientAddress
        {
            get { return GetValuesAt<XAD>(10); }
        }
        [Description("Country Code")]
        [MaxLength(4)]
        public IS CountryCode
        {
            get { return GetValueAt<IS>(11); }
        }
        [Description("Home Phone Number")]
        [MaxLength(40)]
        public XTN[] HomePhoneNumber
        {
            get { return GetValuesAt<XTN>(12); }
        }
        [Description("Business Phone Number")]
        [MaxLength(40)]
        public XTN[] BusinessPhoneNumber
        {
            get { return GetValuesAt<XTN>(13); }
        }
        [Description("Primary Language")]
        [MaxLength(60)]
        public CE PrimaryLanguage
        {
            get { return GetValueAt<CE>(14); }
        }
        [Description("Marital Status")]
        [MaxLength(1)]
        public IS MaritalStatus
        {
            get { return GetValueAt<IS>(15); }
        }
        [Description("Religion")]
        [MaxLength(3)]
        public IS Religion
        {
            get { return GetValueAt<IS>(16); }
        }
        [Description("Patient Account Number")]
        [MaxLength(20)]
        public CX PatientAccountNumber
        {
            get { return GetValueAt<CX>(17); }
        }
        [Description("Patient SSN Number")]
        [MaxLength(16)]
        public ST PatientSSNNumber
        {
            get { return GetValueAt<ST>(18); }
        }
        [Description("Patient Driver’s License Number")]
        [MaxLength(25)]
        public DLN PatientDriversLicenseNumber
        {
            get { return GetValueAt<DLN>(19); }
        }
        [Description("Mother’s Identifier")]
        [MaxLength(20)]
        public CX[] MothersIdentifier
        {
            get { return GetValuesAt<CX>(20); }
        }
        [Description("Ethnic Group")]
        [MaxLength(3)]
        public IS EthnicGroup
        {
            get { return GetValueAt<IS>(21); }
        }
        [Description("Birth Place")]
        [MaxLength(60)]
        public ST BirthPlace
        {
            get { return GetValueAt<ST>(22); }
        }
        [Description("Multiple Birth Indicator")]
        [MaxLength(2)]
        public ID MultipleBirthIndicator
        {
            get { return GetValueAt<ID>(23); }
        }
        [Description("Birth Order")]
        [MaxLength(2)]
        public NM BirthOrder
        {
            get { return GetValueAt<NM>(24); }
        }
        [Description("Citizenship")]
        [MaxLength(2)]
        public IS[] Citizenship
        {
            get { return GetValuesAt<IS>(25); }
        }
        [Description("Veterans Military Status")]
        [MaxLength(60)]
        public CE VeteransMilitaryStatus
        {
            get { return GetValueAt<CE>(26); }
        }
        [Description("Nationality")]
        [MaxLength(80)]
        public CE Nationality
        {
            get { return GetValueAt<CE>(27); }
        }
        [Description("Patient Death Date and Time")]
        [MaxLength(26)]
        public TS PatientDeathDateAndTime
        {
            get { return GetValueAt<TS>(28); }
        }
        [Description("Patient Death Indicator")]
        [MaxLength(1)]
        public ID PatientDeathIndicator
        {
            get { return GetValueAt<ID>(29); }
        }
    }
}
