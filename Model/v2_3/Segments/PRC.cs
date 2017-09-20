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
    /// PRC: Pricing
    /// </summary>
    public class PRC : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(200)]
        public CE PrimaryKeyValue
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Facility ID")]
        [Required]
        [MaxLength(60)]
        public EI[] FacilityID
        {
            get { return GetValuesAt<EI>(1); }
        }
        [Description("Department")]
        [MaxLength(30)]
        public CE[] Department
        {
            get { return GetValuesAt<CE>(2); }
        }
        [Description("Valid Patient Classes")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(PatientClass))]
        public ID[] ValidPatientClasses
        {
            get { return GetValuesAt<ID>(3); }
        }
        [Description("Price")]
        [MaxLength(12)]
        public CP[] Price
        {
            get { return GetValuesAt<CP>(4); }
        }
        [Description("Formula")]
        [MaxLength(200)]
        public ST[] Formula
        {
            get { return GetValuesAt<ST>(5); }
        }
        [Description("Minimum Quantity")]
        [MaxLength(4)]
        public NM MinimumQuantity
        {
            get { return GetValueAt<NM>(6); }
        }
        [Description("Maximum Quantity")]
        [MaxLength(4)]
        public NM MaximumQuantity
        {
            get { return GetValueAt<NM>(7); }
        }
        [Description("Minimum Price")]
        [MaxLength(12)]
        public MO MinimumPrice
        {
            get { return GetValueAt<MO>(8); }
        }
        [Description("Maximum Price")]
        [MaxLength(12)]
        public MO MaximumPrice
        {
            get { return GetValueAt<MO>(9); }
        }
        [Description("Effective Start Date")]
        [MaxLength(26)]
        public TS EffectiveStartDate
        {
            get { return GetValueAt<TS>(10); }
        }
        [Description("Effective End Date")]
        [MaxLength(26)]
        public TS EffectiveEndDate
        {
            get { return GetValueAt<TS>(11); }
        }
        [Description("Price Override Flag")]
        [MaxLength(1)]
        public ID PriceOverrideFlag
        {
            get { return GetValueAt<ID>(12); }
        }
        [Description("Billing Category")]
        [MaxLength(60)]
        public CE[] BillingCategory
        {
            get { return GetValuesAt<CE>(13); }
        }
        [Description("Chargeable Flag")]
        [MaxLength(1)]
        public ID ChargeableFlag
        {
            get { return GetValueAt<ID>(14); }
        }
        [Description("Active/Inactive Flag")]
        [MaxLength(1)]
        public ID ActiveInactiveFlag
        {
            get { return GetValueAt<ID>(15); }
        }
        [Description("Cost")]
        [MaxLength(12)]
        public MO Cost
        {
            get { return GetValueAt<MO>(16); }
        }
        [Description("Charge On Indicator")]
        [MaxLength(1)]
        public ID ChargeOnIndicator
        {
            get { return GetValueAt<ID>(17); }
        }
    }
}
