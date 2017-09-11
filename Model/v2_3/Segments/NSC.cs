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
    /// NSC: STATUS CHANGE
    /// </summary>
    public class NSC : ChoHL7Segment
    {
        [Description("Network Change Type")]
        [MaxLength(4)]
        public ID NetworkChangeType
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Current CPU")]
        [MaxLength(30)]
        public ST CurrentCPU
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Current Fileserver")]
        [MaxLength(30)]
        public ST CurrentFileserver
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Current Application")]
        [MaxLength(30)]
        public ST CurrentApplication
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Current Facility")]
        [MaxLength(30)]
        public ST CurrentFacility
        {
            get { return GetValueAt<ST>(4); }
        }
        [Description("New Fileserver")]
        [MaxLength(30)]
        public ST NewFileserver
        {
            get { return GetValueAt<ST>(5); }
        }
        [Description("New Application")]
        [MaxLength(30)]
        public ST NewApplication
        {
            get { return GetValueAt<ST>(6); }
        }
        [Description("New Facility")]
        [MaxLength(30)]
        public ST NewFacility
        {
            get { return GetValueAt<ST>(7); }
        }
    }
}
