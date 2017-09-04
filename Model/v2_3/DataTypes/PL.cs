using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    /// <summary>
    /// PL: Processing Type
    /// </summary>
    [Description("PL: Person Location")]
    public class PL : ChoHL7AbstractField
    {
        public ID PointOfCare
        {
            get { return GetValueAt<ID>(0); }
        }
        public IS Room
        {
            get { return GetValueAt<IS>(1); }
        }
        public IS Bed
        {
            get { return GetValueAt<IS>(2); }
        }
        public HD Facility
        {
            get { return GetValueAt<HD>(3); }
        }
        public IS LocationStatus
        {
            get { return GetValueAt<IS>(4); }
        }
        public IS PersonLocationType
        {
            get { return GetValueAt<IS>(5); }
        }
        public IS Building
        {
            get { return GetValueAt<IS>(6); }
        }
        public ST Floor
        {
            get { return GetValueAt<ST>(7); }
        }
        public ST LocationType
        {
            get { return GetValueAt<ST>(8); }
        }

        public PL(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public PL(ChoHL7Field field) : base(field)
        {
        }
    }
}
