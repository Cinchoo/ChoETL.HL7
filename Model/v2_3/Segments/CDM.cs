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
    /// CDM: Charge Description Master
    /// </summary>
    public class CDM : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(200)]
        public CE PrimaryKeyValue
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Charge Code Alias")]
        [MaxLength(200)]
        public CE[] ChargeCodeAlias
        {
            get { return GetValuesAt<CE>(1); }
        }
        [Description("Charge Description Short")]
        [Required]
        [MaxLength(20)]
        public ST ChargeDescriptionShort
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Charge Description Long")]
        [MaxLength(250)]
        public ST ChargeDescriptionLong
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Description Override Indicator")]
        [MaxLength(1)]
        public IS DescriptionOverrideIndicator
        {
            get { return GetValueAt<IS>(4); }
        }
        [Description("Exploding Charges")]
        [MaxLength(60)]
        public CE[] ExplodingCharges
        {
            get { return GetValuesAt<CE>(5); }
        }
        [Description("Procedure Code")]
        [MaxLength(60)]
        public CE ProcedureCode
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Active/Inactive Flag")]
        [MaxLength(1)]
        public ID ActiveInactiveFlag
        {
            get { return GetValueAt<ID>(7); }
        }
        [Description("Inventory Number")]
        [MaxLength(60)]
        public CE[] InventoryNumber
        {
            get { return GetValuesAt<CE>(8); }
        }
        [Description("Resource Load")]
        [MaxLength(12)]
        public NM ResourceLoad
        {
            get { return GetValueAt<NM>(9); }
        }
        [Description("Contract Number")]
        [MaxLength(200)]
        public CK[] ContractNumber
        {
            get { return GetValuesAt<CK>(10); }
        }
        [Description("Contract Organization")]
        [MaxLength(200)]
        public XON ContractOrganization
        {
            get { return GetValueAt<XON>(11); }
        }
        [Description("Room Fee Indicator")]
        [MaxLength(1)]
        public ID RoomFeeIndicator
        {
            get { return GetValueAt<ID>(12); }
        }
    }
}
