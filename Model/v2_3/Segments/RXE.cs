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
    /// RXE: Pharmacy encoded order segment
    /// </summary>
    public class RXE : ChoHL7Segment
    {
        [Description("Quantity/Timing")]
        [Required]
        [MaxLength(200)]
        public TQ QuantityTiming
        {
            get { return GetValueAt<TQ>(0); }
        }
        [Description("Give Code")]
        [Required]
        [MaxLength(100)]
        public CE GiveCode
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Give Amount - Minimum")]
        [Required]
        [MaxLength(20)]
        public NM MinimumGiveAmount
        {
            get { return GetValueAt<NM>(2); }
        }
        [Description("Give Amount - Maximum")]
        [MaxLength(20)]
        public NM MaximumGiveAmount
        {
            get { return GetValueAt<NM>(3); }
        }
        [Description("Give Units")]
        [Required]
        [MaxLength(60)]
        public CE GiveUnits
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Give Dosage Form")]
        [MaxLength(60)]
        public CE GiveDosageForm
        {
            get { return GetValueAt<CE>(5); }
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
        [Description("Substitution Status")]
        [MaxLength(1)]
        public ID SubstitutionStatus
        {
            get { return GetValueAt<ID>(8); }
        }
        [Description("Dispense Amount")]
        [MaxLength(20)]
        public NM DispenseAmount
        {
            get { return GetValueAt<NM>(9); }
        }
        [Description("Dispense Units")]
        [MaxLength(60)]
        public CE DispenseUnits
        {
            get { return GetValueAt<CE>(10); }
        }
        [Description("Number of Refills")]
        [MaxLength(3)]
        public NM NumberofRefills
        {
            get { return GetValueAt<NM>(11); }
        }
        [Description("Ordering Provider's DEA Number")]
        [MaxLength(60)]
        public CN OrderingProvidersDEANumber
        {
            get { return GetValueAt<CN>(12); }
        }
        [Description("Pharmacist/Treatment Supplier's Verifier ID")]
        [MaxLength(60)]
        public CN PharmacistTreatmentSuppliersVerifierID
        {
            get { return GetValueAt<CN>(13); }
        }
        [Description("Prescription Number")]
        [MaxLength(20)]
        public ST PrescriptionNumber
        {
            get { return GetValueAt<ST>(14); }
        }
        [Description("Number of Refills Remaining")]
        [MaxLength(20)]
        public NM NumberofRefillsRemaining
        {
            get { return GetValueAt<NM>(15); }
        }
        [Description("Number of Refills/Doses Dispensed")]
        [MaxLength(20)]
        public NM NumberofRefillsDosesDispensed
        {
            get { return GetValueAt<NM>(16); }
        }
        [Description("Date / time of most recent refill or dose dispensed")]
        [MaxLength(26)]
        public TS DateTimeofMostRecentRefillorDoseDispensed
        {
            get { return GetValueAt<TS>(17); }
        }
        [Description("Total Daily Dose")]
        [MaxLength(10)]
        public CQ TotalDailyDose
        {
            get { return GetValueAt<CQ>(18); }
        }
        [Description("Needs Human Review")]
        [MaxLength(1)]
        public ID NeedsHumanReview
        {
            get { return GetValueAt<ID>(19); }
        }
        [Description("Pharmacy/Treatment Supplier's Special Dispensing Instructions")]
        [MaxLength(200)]
        public CE[] PharmacyTreatmentSuppliersSpecialDispensingInstructions
        {
            get { return GetValuesAt<CE>(20); }
        }
        [Description("Give Per")]
        [MaxLength(20)]
        public ST GivePer
        {
            get { return GetValueAt<ST>(21); }
        }
        [Description("Give Rate Amount")]
        [MaxLength(6)]
        public ST GiveRateAmount
        {
            get { return GetValueAt<ST>(22); }
        }
        [Description("Give Rate Units")]
        [MaxLength(60)]
        public CE GiveRateUnits
        {
            get { return GetValueAt<CE>(23); }
        }
        [Description("Give Strength")]
        [MaxLength(20)]
        public NM GiveStrength
        {
            get { return GetValueAt<NM>(24); }
        }
        [Description("Give Strength Units")]
        [MaxLength(60)]
        public CE GiveStrengthUnits
        {
            get { return GetValueAt<CE>(25); }
        }
        [Description("Give Indication")]
        [MaxLength(200)]
        public CE GiveIndication
        {
            get { return GetValueAt<CE>(26); }
        }
        [Description("Dispense Package Size")]
        [MaxLength(20)]
        public NM DispensePackageSize
        {
            get { return GetValueAt<NM>(27); }
        }
        [Description("Dispense Package Size Unit")]
        [MaxLength(60)]
        public CE DispensePackageSizeUnit
        {
            get { return GetValueAt<CE>(28); }
        }
        [Description("Dispense Package Method")]
        [MaxLength(2)]
        public ID DispensePackageMethod
        {
            get { return GetValueAt<ID>(29); }
        }
    }
}
