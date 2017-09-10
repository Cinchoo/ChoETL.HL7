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
    /// IAM: Patient adverse reaction information - unique iden
    /// </summary>
    public class IAM : ChoHL7Segment
    {
        [Description("Set ID - IAM")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Allergen Type Code")]
        [MaxLength(250)]
        public CE AllergenTypeCode
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Allergen Code/Mnemonic/Description")]
        [Required]
        [MaxLength(250)]
        public CE AllergenCodeMnemonicDescription
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Allergy Severity Code")]
        [MaxLength(250)]
        public CE AllergySeverityCode
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Allergy Reaction Code")]
        [MaxLength(15)]
        public ST[] AllergyReactionCode
        {
            get { return GetValuesAt<ST>(4); }
        }
        [Description("Allergy Action Code")]
        [MaxLength(250)]
        [Required]
        public CNE AllergyActionCode
        {
            get { return GetValueAt<CNE>(5); }
        }
        [Description("Allergy Unique Identifier")]
        [MaxLength(80)]
        [Required]
        public EI AllergyUniqueIdentifier
        {
            get { return GetValueAt<EI>(6); }
        }
        [Description("Action Reason")]
        [MaxLength(60)]
        public ST ActionReason
        {
            get { return GetValueAt<ST>(7); }
        }
        [Description("Sensitivity to Causative Agent Code")]
        [MaxLength(250)]
        public CE SensitivitytoCausativeAgentCode
        {
            get { return GetValueAt<CE>(8); }
        }
        [Description("Allergen Group Code/Mnemonic/Description")]
        [MaxLength(250)]
        public CE AllergenGroupCodeMnemonicDescription
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Onset Date")]
        [MaxLength(8)]
        public DT OnsetDate
        {
            get { return GetValueAt<DT>(10); }
        }
        [Description("Onset Date Text")]
        [MaxLength(60)]
        public ST OnsetDateText
        {
            get { return GetValueAt<ST>(11); }
        }
        [Description("Reported Date/Time")]
        [MaxLength(8)]
        public TS ReportedDateTime
        {
            get { return GetValueAt<TS>(12); }
        }
        [Description("Reported By")]
        [MaxLength(250)]
        public XPN ReportedBy
        {
            get { return GetValueAt<XPN>(13); }
        }
        [Description("Relationship to Patient Code")]
        [MaxLength(250)]
        public CE RelationshiptoPatientCode
        {
            get { return GetValueAt<CE>(14); }
        }
        [Description("Alert Device Code")]
        [MaxLength(250)]
        public CE AlertDeviceCode
        {
            get { return GetValueAt<CE>(15); }
        }
        [Description("Allergy Clinical Status Code")]
        [MaxLength(250)]
        public CE AllergyClinicalStatusCode
        {
            get { return GetValueAt<CE>(16); }
        }
        [Description("Goal Life Cycle Status")]
        [MaxLength(80)]
        public CE GoalLifeCycleStatus
        {
            get { return GetValueAt<CE>(17); }
        }
        [Description("Statused by Person")]
        [MaxLength(250)]
        public XCN StatusedbyPerson
        {
            get { return GetValueAt<XCN>(18); }
        }
        [Description("Statused by Organization")]
        [MaxLength(80)]
        public XON StatusedbyOrganization
        {
            get { return GetValueAt<XON>(19); }
        }
        [Description("Statused at Date/Time")]
        [MaxLength(8)]
        public TS StatusedatDateTime
        {
            get { return GetValueAt<TS>(20); }
        }
    }
}
