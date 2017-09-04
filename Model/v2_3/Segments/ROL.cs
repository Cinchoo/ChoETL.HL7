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
    /// ROL: Role
    /// </summary>
    public class ROL : ChoHL7Segment
    {
        [Description("ID")]
        [Required]
        [MaxLength(60)]
        public EI ID
        {
            get { return GetValueAt<EI>(0); }
        }
        [Description("Action Code")]
        [Required]
        [MaxLength(2)]
        public ID ActionCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Role")]
        //[MaxLength(0)]
        public CE Role
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Role Person")]
        [MaxLength(80)]
        [Required]
        public XCN RolePerson
        {
            get { return GetValueAt<XCN>(3); }
        }
        [Description("Role Begin Date/Time")]
        [MaxLength(26)]
        public TS RoleBeginDateTime
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Role End Date/Time")]
        [MaxLength(26)]
        public TS RoleEndDateTime
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Role Duration")]
        [MaxLength(80)]
        public CE RoleDuration
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Role Action")]
        [MaxLength(80)]
        public CE RoleAction
        {
            get { return GetValueAt<CE>(7); }
        }
    }
}
