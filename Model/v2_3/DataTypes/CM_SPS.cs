using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_SPS: Specimen Source")]
    public class CM_SPS : ChoHL7AbstractField
    {
        public CE SpecimenSourceName
        {
            get { return GetValueAt<CE>(0); }
        }
        public TX Additives
        {
            get { return GetValueAt<TX>(1); }
        }
        public TX Freetext
        {
            get { return GetValueAt<TX>(2); }
        }
        public CE BodySite
        {
            get { return GetValueAt<CE>(3); }
        }
        public CE SiteModifier
        {
            get { return GetValueAt<CE>(4); }
        }
        public CE CollectionModifierMethodCode
        {
            get { return GetValueAt<CE>(5); }
        }

        public CM_SPS(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_SPS(ChoHL7Field field) : base(field)
        {
        }
    }
}
