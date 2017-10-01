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
    /// RXG: Pharmacy give segment
    /// </summary>
    public class RXG : ChoHL7Segment
    {
        [Description("Give Sub-ID Counter")]
        [MaxLength(4)]
        public ID GiveSubIDCounter
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Dispense Sub-ID Counter")]
        [Required]
        [MaxLength(4)]
        public NM DispenseSubIDCounter
        {
            get { return GetValueAt<NM>(1); }
        }
        [Description("Quantity/Timing")]
        [Required]
        [MaxLength(200)]
        public TQ QuantityTiming
        {
            get { return GetValueAt<TQ>(2); }
        }
        [Description("Give Code")]
        [Required]
        [MaxLength(100)]
        public CE GiveCode
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Give Amount - Minimum")]
        [Required]
        [MaxLength(20)]
        public NM GiveMinimumAmount
        {
            get { return GetValueAt<NM>(4); }
        }
        [Description("Give Amount - Maximum")]
        [MaxLength(20)]
        public NM GiveMaximumAmount
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Give Units")]
        [Required]
        [MaxLength(60)]
        public CE GiveUnits
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Give Dosage Form")]
        [MaxLength(60)]
        public CE GiveDosageForm
        {
            get { return GetValueAt<CE>(7); }
        }
        [Description("Administration Notes")]
        [MaxLength(200)]
        public CE[] AdministrationNotes
        {
            get { return GetValuesAt<CE>(8); }
        }
        [Description("Substitution Status")]
        [MaxLength(1)]
        public ID SubstitutionStatus
        {
            get { return GetValueAt<ID>(9); }
        }
        [Description("Dispense-To Location")]
        [MaxLength(200)]
        public CM_LA1 DispenseToLocation
        {
            get { return GetValueAt<CM_LA1>(10); }
        }
        [Description("Needs Human Review")]
        [MaxLength(1)]
        public ID NeedsHumanReview
        {
            get { return GetValueAt<ID>(11); }
        }
        [Description("Pharmacy Special Administration Instructions")]
        [MaxLength(200)]
        public CE PharmacySpecialAdministrationInstructions
        {
            get { return GetValueAt<CE>(12); }
        }
        [Description("Give Per")]
        [MaxLength(20)]
        public ST GivePer
        {
            get { return GetValueAt<ST>(13); }
        }
        [Description("Give Rate Amount")]
        [MaxLength(6)]
        public ST GiveRateAmount
        {
            get { return GetValueAt<ST>(14); }
        }
        [Description("Give Rate Units")]
        [MaxLength(60)]
        public CE GiveRateUnits
        {
            get { return GetValueAt<CE>(15); }
        }
        [Description("Give Strength")]
        [MaxLength(20)]
        public NM GiveStrength
        {
            get { return GetValueAt<NM>(16); }
        }
        [Description("Give Strength Units")]
        [MaxLength(60)]
        public CE GiveStrengthUnits
        {
            get { return GetValueAt<CE>(17); }
        }
        [Description("Substance Lot Number")]
        [MaxLength(20)]
        public ST[] SubstanceLotNumber
        {
            get { return GetValuesAt<ST>(18); }
        }
        [Description("Substance Expiration Date")]
        [MaxLength(26)]
        public TS[] SubstanceExpirationDate
        {
            get { return GetValuesAt<TS>(19); }
        }
        [Description("Substance Manufacturer Name")]
        [MaxLength(60)]
        public CE[] SubstanceManufacturerName
        {
            get { return GetValuesAt<CE>(20); }
        }
        [Description("Indication")]
        [MaxLength(200)]
        public CE Indication
        {
            get { return GetValueAt<CE>(21); }
        }
    }
}
