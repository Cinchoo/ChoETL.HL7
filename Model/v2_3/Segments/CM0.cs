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
    /// CM0: Clinical Study Master
    /// </summary>
    public class CM0 : ChoHL7Segment
    {
        [Description("CM0 - Set ID")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Sponsor Study ID")]
        [Required]
        [MaxLength(60)]
        public EI ChargeCodeAlias
        {
            get { return GetValueAt<EI>(1); }
        }
        [Description("Alternate Study ID")]
        [MaxLength(60)]
        [ChoHL7MaxCount(3)]
        public ST AlternateStudyID
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Title of Study")]
        [Required]
        [MaxLength(300)]
        public ST TitleofStudy
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Chairman of Study")]
        [MaxLength(60)]
        public XCN ChairmanofStudy
        {
            get { return GetValueAt<XCN>(4); }
        }
        [Description("Last IRB Approval Date")]
        [MaxLength(8)]
        public DT LastIRBApprovalDate
        {
            get { return GetValueAt<DT>(5); }
        }
        [Description("Total Accrual to Date")]
        [MaxLength(8)]
        public NM TotalAccrualtoDate
        {
            get { return GetValueAt<NM>(6); }
        }
        [Description("Last Accrual Date")]
        [MaxLength(8)]
        public DT LastAccrualDate
        {
            get { return GetValueAt<DT>(7); }
        }
        [Description("Contact for Study")]
        [MaxLength(60)]
        public XCN ContactforStudy
        {
            get { return GetValueAt<XCN>(8); }
        }
        [Description("Contact's Tel. Number")]
        [MaxLength(40)]
        public XTN ContactsTelphoneNumber
        {
            get { return GetValueAt<XTN>(9); }
        }
        [Description("Contact's Address")]
        [MaxLength(100)]
        public XAD ContactsAddress
        {
            get { return GetValueAt<XAD>(10); }
        }
    }
}
