using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_NDL: Observing Practitioner")]
    public class CM_NDL : ChoHL7AbstractField
    {
        public CN OPName
        {
            get { return GetValueAt<CN>(0); }
        }
        public TS StartDateTime
        {
            get { return GetValueAt<TS>(1); }
        }
        public TS EndDateTime
        {
            get { return GetValueAt<TS>(2); }
        }
        public IS PointOfCare
        {
            get { return GetValueAt<IS>(3); }
        }
        public IS Room
        {
            get { return GetValueAt<IS>(4); }
        }
        public IS Bed
        {
            get { return GetValueAt<IS>(5); }
        }
        public HD Facility
        {
            get { return GetValueAt<HD>(6); }
        }
        public IS LocationStatus
        {
            get { return GetValueAt<IS>(7); }
        }
        public IS PersonLocationType
        {
            get { return GetValueAt<IS>(8); }
        }
        public IS Building
        {
            get { return GetValueAt<IS>(9); }
        }
        public ST Floor
        {
            get { return GetValueAt<ST>(10); }
        }

        public CM_NDL(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_NDL(ChoHL7Field field) : base(field)
        {
        }
    }
}
