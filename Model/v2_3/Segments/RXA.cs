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
    /// RXA: Pharmacy administration segment
    /// </summary>
    public class RXA : ChoHL7Segment
    {
        [Description("Give Sub-ID Counter")]
        [Required]
        [MaxLength(4)]
        public ID GiveSubIDCounter
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Administration Sub-ID Counter")]
        [Required]
        [MaxLength(4)]
        public NM AdministrationSubIDCounter
        {
            get { return GetValueAt<NM>(1); }
        }
        [Description("Date/Time Start of Administration")]
        [Required]
        [MaxLength(26)]
        public TS DateTimeStartofAdministration
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("Date/Time End of Administration")]
        [Required]
        [MaxLength(26)]
        public TS DateTimeEndofAdministration
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Administered Code")]
        [Required]
        [MaxLength(100)]
        public CE AdministeredCode
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Administered Amount")]
        [Required]
        [MaxLength(20)]
        public NM AdministeredAmount
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Administered Units")]
        [MaxLength(60)]
        public CE AdministeredUnits
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Administered Dosage Form")]
        [MaxLength(60)]
        public CE AdministeredDosageForm
        {
            get { return GetValueAt<CE>(7); }
        }
        [Description("Administration Notes")]
        [MaxLength(200)]
        public CE[] AdministrationNotes
        {
            get { return GetValuesAt<CE>(8); }
        }
        [Description("Administering Provider")]
        [MaxLength(200)]
        public XCN AdministeringProvider
        {
            get { return GetValueAt<XCN>(9); }
        }
        [Description("Administered-at Location")]
        [MaxLength(200)]
        public CM_LA1 AdministeredatLocation
        {
            get { return GetValueAt<CM_LA1>(10); }
        }
        [Description("Administered Per")]
        [MaxLength(20)]
        public ST AdministeredPer
        {
            get { return GetValueAt<ST>(11); }
        }
        [Description("Administered Strength")]
        [MaxLength(20)]
        public NM AdministeredStrength
        {
            get { return GetValueAt<NM>(12); }
        }
        [Description("Administered Strength Units")]
        [MaxLength(60)]
        public CE AdministeredStrengthUnits
        {
            get { return GetValueAt<CE>(13); }
        }
        [Description("Substance Lot Number")]
        [MaxLength(20)]
        public ST[] SubstanceLotNumber
        {
            get { return GetValuesAt<ST>(14); }
        }
        [Description("Substance Expiration Date")]
        [MaxLength(26)]
        public TS[] SubstanceExpirationDate
        {
            get { return GetValuesAt<TS>(15); }
        }
        [Description("Substance Manufacturer Name")]
        [MaxLength(60)]
        public CE[] SubstanceManufacturerName
        {
            get { return GetValuesAt<CE>(16); }
        }
        [Description("Substance Refusal Reason")]
        [MaxLength(60)]
        public CE[] SubstanceRefusalReason
        {
            get { return GetValuesAt<CE>(17); }
        }
        [Description("Indication")]
        [MaxLength(200)]
        public CE[] Indication
        {
            get { return GetValuesAt<CE>(18); }
        }
        [Description("Completion Status")]
        [MaxLength(2)]
        public ID CompletionStatus
        {
            get { return GetValueAt<ID>(19); }
        }
        [Description("Action Code-RXA")]
        [MaxLength(2)]
        public ID ActionCodeRXA
        {
            get { return GetValueAt<ID>(20); }
        }
        [Description("System Entry Date/Time")]
        [MaxLength(26)]
        public TS SystemEntryDateTime
        {
            get { return GetValueAt<TS>(21); }
        }
    }
}
