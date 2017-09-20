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
    /// ORC: Common order segment
    /// </summary>
    public class ORC : ChoHL7Segment
    {
        [Description("Order Control")]
        [Required]
        [MaxLength(2)]
        public ID OrderControl
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Placer Order Number")]
        [MaxLength(22)]
        public EI[] PlacerOrderNumber
        {
            get { return GetValuesAt<EI>(1); }
        }
        [Description("Filler Order Number")]
        [MaxLength(22)]
        public EI FillerOrderNumber
        {
            get { return GetValueAt<EI>(2); }
        }
        [Description("Placer Group Number")]
        [MaxLength(22)]
        public EI PlacerGroupNumber
        {
            get { return GetValueAt<EI>(3); }
        }
        [Description("Order Status")]
        [MaxLength(2)]
        public ID OrderStatus
        {
            get { return GetValueAt<ID>(4); }
        }
        [Description("Response Flag")]
        [MaxLength(1)]
        public ID ResponseFlag
        {
            get { return GetValueAt<ID>(5); }
        }
        [Description("Quantity")]
        [MaxLength(200)]
        [Required]
        public TQ Quantity
        {
            get { return GetValueAt<TQ>(6); }
        }
        [Description("Parent Order")]
        [MaxLength(200)]
        public CM_EIP ParentOrder
        {
            get { return GetValueAt<CM_EIP>(7); }
        }
        [Description("Date/Time of Transaction")]
        [MaxLength(26)]
        public TS DateTimeofTransaction
        {
            get { return GetValueAt<TS>(8); }
        }
        [Description("Entered By")]
        [MaxLength(120)]
        public XCN EnteredBy
        {
            get { return GetValueAt<XCN>(9); }
        }
        [Description("Verified By")]
        [MaxLength(120)]
        public XCN VerifiedBy
        {
            get { return GetValueAt<XCN>(10); }
        }
        [Description("Ordering Provider")]
        [MaxLength(2)]
        public XCN[] OrderingProvider
        {
            get { return GetValuesAt<XCN>(11); }
        }
        [Description("Enterer's Location")]
        [MaxLength(80)]
        public PL EnterersLocation
        {
            get { return GetValueAt<PL>(12); }
        }
        [Description("Call Back Phone Number")]
        [MaxLength(40)]
        [ChoHL7MaxCount(2)]
        public TN[] CallBackPhoneNumber
        {
            get { return GetValuesAt<TN>(13); }
        }
        [Description("Order Effective Date/Time")]
        [MaxLength(26)]
        public TS OrderEffectiveDateTime
        {
            get { return GetValueAt<TS>(14); }
        }
        [Description("Order Control Code Reason")]
        [MaxLength(200)]
        public CE OrderControlCodeReason
        {
            get { return GetValueAt<CE>(15); }
        }
        [Description("Entering Organization")]
        [MaxLength(60)]
        public CE EnteringOrganization
        {
            get { return GetValueAt<CE>(16); }
        }
        [Description("Entering Device")]
        [MaxLength(60)]
        public CE EnteringDevice
        {
            get { return GetValueAt<CE>(17); }
        }
        [Description("Action By")]
        [MaxLength(120)]
        public XCN ActionBy
        {
            get { return GetValueAt<XCN>(18); }
        }

    }
}
