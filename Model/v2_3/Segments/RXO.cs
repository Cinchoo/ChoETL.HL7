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
    /// RXO: Pharmacy prescription order segment
    /// </summary>
    public class RXO : ChoHL7Segment
    {
        [Description("Requested Give Code")]
        [Required]
        [MaxLength(100)]
        public CE RequestedGiveCode
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Requested Give Amount - Minimum")]
        [Required]
        [MaxLength(20)]
        public NM RequestedGiveMinimumAmount
        {
            get { return GetValueAt<NM>(1); }
        }
        [Description("Requested Give Amount - Maximum")]
        [MaxLength(20)]
        public NM RequestedGiveMaximumAmount
        {
            get { return GetValueAt<NM>(2); }
        }
        [Description("Requested Give Units")]
        [Required]
        [MaxLength(60)]
        public CE RequestedGiveUnits
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Requested Dosage Form")]
        [MaxLength(60)]
        public CE RequestedDosageForm
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Provider's Pharmacy Instructions")]
        [MaxLength(200)]
        public CE[] ProvidersPharmacyInstructions
        {
            get { return GetValuesAt<CE>(5); }
        }
        [Description("Provider's Administration Instructions")]
        [MaxLength(200)]
        public CE[] ProvidersAdministrationInstructions
        {
            get { return GetValuesAt<CE>(6); }
        }
        [Description("Deliver To Location")]
        [MaxLength(200)]
        public CM_LA1 DeliverToLocation
        {
            get { return GetValueAt<CM_LA1>(7); }
        }
        [Description("Allow Substitutions")]
        [MaxLength(1)]
        public ID AllowSubstitutions
        {
            get { return GetValueAt<ID>(8); }
        }
        [Description("Requested Dispense Code")]
        [MaxLength(100)]
        public CE RequestedDispenseCode
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Requested Dispense Amount")]
        [MaxLength(20)]
        public NM RequestedDispenseAmount
        {
            get { return GetValueAt<NM>(10); }
        }
        [Description("Requested Dispense Units")]
        [MaxLength(60)]
        public CE RequestedDispenseUnits
        {
            get { return GetValueAt<CE>(11); }
        }
        [Description("Number of Refills")]
        [MaxLength(3)]
        public NM NumberofRefills
        {
            get { return GetValueAt<NM>(12); }
        }
        [Description("Ordering Provider's DEA Number")]
        [MaxLength(60)]
        public CN OrderingProvidersDEANumber
        {
            get { return GetValueAt<CN>(13); }
        }
        [Description("Pharmacist/Treatment Supplier's Verifier ID")]
        [MaxLength(60)]
        public CN PharmacistTreatmentSuppliersVerifierID
        {
            get { return GetValueAt<CN>(14); }
        }
        [Description("Needs Human Review")]
        [MaxLength(1)]
        public ID NeedsHumanReview
        {
            get { return GetValueAt<ID>(15); }
        }
        [Description("Requested Give Per")]
        [MaxLength(20)]
        public ST RequestedGivePer
        {
            get { return GetValueAt<ST>(16); }
        }
        [Description("Requested Give Strength")]
        [MaxLength(20)]
        public NM RequestedGiveStrength
        {
            get { return GetValueAt<NM>(17); }
        }
        [Description("Requested Give Strength Units")]
        [MaxLength(60)]
        public CE RequestedGiveStrengthUnits
        {
            get { return GetValueAt<CE>(18); }
        }
        [Description("Indication")]
        [MaxLength(200)]
        public CE Indication
        {
            get { return GetValueAt<CE>(19); }
        }
        [Description("Requested Give Rate Amount")]
        [MaxLength(6)]
        public ST RequestedGiveRateAmount
        {
            get { return GetValueAt<ST>(20); }
        }
        [Description("Requested Give Rate Units")]
        [MaxLength(60)]
        public CE RequestedGiveRateUnits
        {
            get { return GetValueAt<CE>(21); }
        }
    }
}
