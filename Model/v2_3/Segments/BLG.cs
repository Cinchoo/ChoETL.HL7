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
    /// BLG: Billing
    /// </summary>
    public class BLG : ChoHL7Segment
    {
        [Description("When to Charge")]
        [MaxLength(40)]
        public CM_CCD WhentoCharge
        {
            get { return GetValueAt<CM_CCD>(0); }
        }
        [Description("Charge Type")]
        [MaxLength(50)]
        public ID ChargeType
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Account ID")]
        [MaxLength(100)]
        public CK BLGhorizingPayerCompanyName
        {
            get { return GetValueAt<CK>(2); }
        }
    }
}
