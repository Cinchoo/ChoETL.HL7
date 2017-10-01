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
    /// RQD: Requisition detail
    /// </summary>
    public class RQD : ChoHL7Segment
    {
        [Description("Requisition Line Number")]
        [MaxLength(4)]
        public SI RequisitionLineNumber
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Item Code - Internal")]
        [MaxLength(60)]
        public CE InternalItemCode
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Item Code - External")]
        [MaxLength(60)]
        public CE ExternalItemCode
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Hospital Item Code")]
        [MaxLength(60)]
        public CE HospitalItemCode
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Requisition Quantity")]
        [MaxLength(6)]
        public NM RequisitionQuantity
        {
            get { return GetValueAt<NM>(4); }
        }
        [Description("Requisition Unit of Measure")]
        [MaxLength(60)]
        public CE RequisitionUnitofMeasure
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Department Cost Center")]
        [MaxLength(30)]
        public ID DepartmentCostCenter
        {
            get { return GetValueAt<ID>(6); }
        }
        [Description("Item Natural Account Code")]
        [MaxLength(30)]
        public ID ItemNaturalAccountCode
        {
            get { return GetValueAt<ID>(7); }
        }
        [Description("Deliver To ID")]
        [MaxLength(60)]
        public CE DeliverToID
        {
            get { return GetValueAt<CE>(8); }
        }
        [Description("Date Needed")]
        [MaxLength(8)]
        public DT DateNeeded
        {
            get { return GetValueAt<DT>(9); }
        }
    }
}
