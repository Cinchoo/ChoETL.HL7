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
    /// RXD: Pharmacy dispense segment
    /// </summary>
    public class RXD : ChoHL7Segment
    {
        [Description("Dispense Sub-ID Counter")]
        [Required]
        [MaxLength(4)]
        public NM DispenseSubIDCounter
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("Dispense/Give Code")]
        [Required]
        [MaxLength(100)]
        public CE DispenseGiveCode
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Date/Time Dispensed")]
        [Required]
        [MaxLength(26)]
        public TS DateTimeDispensed
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("Actual Dispense Amount")]
        [Required]
        [MaxLength(20)]
        public NM ActualDispenseAmount
        {
            get { return GetValueAt<NM>(3); }
        }
        [Description("Actual Dispense Units")]
        [MaxLength(60)]
        public CE ActualDispenseUnits
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Actual Dosage Form")]
        [MaxLength(60)]
        public CE ActualDosageForm
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Prescription Number")]
        [Required]
        [MaxLength(20)]
        public ST PrescriptionNumber
        {
            get { return GetValueAt<ST>(6); }
        }
        [Description("Number of Refills Remaining")]
        [MaxLength(20)]
        public NM NumberofRefillsRemaining
        {
            get { return GetValueAt<NM>(7); }
        }
        [Description("Dispense Notes")]
        [MaxLength(200)]
        public CE[] DispenseNotes
        {
            get { return GetValuesAt<CE>(8); }
        }
        [Description("Dispensing Provider")]
        [MaxLength(200)]
        public XCN DispensingProvider
        {
            get { return GetValueAt<XCN>(9); }
        }
        [Description("Substitution Status")]
        [MaxLength(1)]
        public ID SubstitutionStatus
        {
            get { return GetValueAt<ID>(10); }
        }
        [Description("Total Daily Dose")]
        [MaxLength(10)]
        public CQ TotalDailyDose
        {
            get { return GetValueAt<CQ>(11); }
        }
        [Description("Dispense-To Location")]
        [MaxLength(200)]
        public CM_LA1 DispenseToLocation
        {
            get { return GetValueAt<CM_LA1>(12); }
        }
        [Description("Needs Human Review")]
        [MaxLength(1)]
        public ID NeedsHumanReview
        {
            get { return GetValueAt<ID>(13); }
        }
        [Description("Pharmacy/Treatment Supplier's Special Dispensing Instructions")]
        [MaxLength(200)]
        public CE[] PharmacyTreatmentSuppliersSpecialDispensingInstructions
        {
            get { return GetValuesAt<CE>(14); }
        }
        [Description("Actual Strength")]
        [MaxLength(20)]
        public NM ActualStrength
        {
            get { return GetValueAt<NM>(15); }
        }
        [Description("Actual Strength Unit")]
        [MaxLength(60)]
        public CE ActualStrengthUnit
        {
            get { return GetValueAt<CE>(16); }
        }
        [Description("Substance Lot Number")]
        [MaxLength(20)]
        public ST[] SubstanceLotNumber
        {
            get { return GetValuesAt<ST>(17); }
        }
        [Description("Substance Expiration Date")]
        [MaxLength(26)]
        public TS[] SubstanceExpirationDate
        {
            get { return GetValuesAt<TS>(18); }
        }
        [Description("Substance Manufacturer Name")]
        [MaxLength(60)]
        public CE[] SubstanceManufacturerName
        {
            get { return GetValuesAt<CE>(19); }
        }
        [Description("Indication")]
        [MaxLength(200)]
        public CE Indication
        {
            get { return GetValueAt<CE>(20); }
        }
        [Description("Dispense Package Size")]
        [MaxLength(20)]
        public NM DispensePackageSize
        {
            get { return GetValueAt<NM>(21); }
        }
        [Description("Dispense Package Size Unit")]
        [MaxLength(60)]
        public CE DispensePackageSizeUnit
        {
            get { return GetValueAt<CE>(22); }
        }
        [Description("Dispense Package Method")]
        [MaxLength(2)]
        public ID DispensePackageMethod
        {
            get { return GetValueAt<ID>(23); }
        }
    }
}
