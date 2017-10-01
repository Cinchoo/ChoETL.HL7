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
    /// RQ1: Requisition detail-1 segment
    /// </summary>
    public class RQ1 : ChoHL7Segment
    {
        [Description("Anticipated Price")]
        [Required]
        [MaxLength(10)]
        public ST AnticipatedPrice
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("Manufactured ID")]
        [MaxLength(60)]
        public CE ManufacturedID
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Manufacturer's Catalog")]
        [MaxLength(16)]
        public ST ManufacturersCatalog
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Vendor ID")]
        [MaxLength(60)]
        public CE VendorID
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Vendor Catalog")]
        [MaxLength(16)]
        public ST VendorCatalog
        {
            get { return GetValueAt<ST>(4); }
        }
        [Description("Taxable")]
        [MaxLength(1)]
        public ID Taxable
        {
            get { return GetValueAt<ID>(5); }
        }
        [Description("Substitute Allowed")]
        [MaxLength(1)]
        public ID SubstituteAllowed
        {
            get { return GetValueAt<ID>(6); }
        }
    }
}
