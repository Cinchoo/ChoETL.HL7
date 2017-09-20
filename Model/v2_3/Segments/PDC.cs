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
    /// PDC: Product Detail Country
    /// </summary>
    public class PDC : ChoHL7Segment
    {
        [Description("Manufacturer")]
        [MaxLength(80)]
        [Required]
        public XON Manufacturer
        {
            get { return GetValueAt<XON>(0); }
        }
        [Description("Country")]
        [MaxLength(60)]
        [Required]
        public CE Country
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Brand Name")]
        [MaxLength(60)]
        [Required]
        public ST BrandName
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Device Family Name")]
        [MaxLength(60)]
        public ST DeviceFamilyName
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Generic Name")]
        [MaxLength(60)]
        public CE GenericName
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Model Identifier")]
        [MaxLength(60)]
        public ST[] ModelIdentifier
        {
            get { return GetValuesAt<ST>(5); }
        }
        [Description("Catalog Identifier")]
        [MaxLength(60)]
        public ST CatalogIdentifier
        {
            get { return GetValueAt<ST>(6); }
        }
        [Description("Other Identifier")]
        [MaxLength(60)]
        public ST[] OtherIdentifier
        {
            get { return GetValuesAt<ST>(7); }
        }
        [Description("Product Code")]
        [MaxLength(60)]
        public CE ProductCode
        {
            get { return GetValueAt<CE>(8); }
        }
        [Description("Marketing Basis")]
        [MaxLength(4)]
        public ID MarketingBasis
        {
            get { return GetValueAt<ID>(9); }
        }
        [Description("Marketing Approval Identifier")]
        [MaxLength(60)]
        public ST MarketingApprovalIdentifier
        {
            get { return GetValueAt<ST>(10); }
        }
        [Description("Labeled Shelf Life")]
        [MaxLength(12)]
        public CQ LabeledShelfLife
        {
            get { return GetValueAt<CQ>(11); }
        }
        [Description("Expected Shelf Life")]
        [MaxLength(12)]
        public CQ ExpectedShelfLife
        {
            get { return GetValueAt<CQ>(12); }
        }
        [Description("Date First Marked")]
        [MaxLength(26)]
        public TS DateFirstMarked
        {
            get { return GetValueAt<TS>(13); }
        }
        [Description("Date Last Marked")]
        [MaxLength(12)]
        public CQ DateLastMarked
        {
            get { return GetValueAt<CQ>(14); }
        }
    }
}
