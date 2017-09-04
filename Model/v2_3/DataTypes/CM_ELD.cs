using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_ELD: Error")]
    public class CM_ELD : ChoHL7AbstractField
    {
        public ST SegmentID
        {
            get { return GetValueAt<ST>(0); }
        }
        public NM Sequence
        {
            get { return GetValueAt<NM>(1); }
        }
        public NM FieldPosition
        {
            get { return GetValueAt<NM>(2); }
        }
        public CE CodeIdentifyingError
        {
            get { return GetValueAt<CE>(3); }
        }

        public CM_ELD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_ELD(ChoHL7Field field) : base(field)
        {
        }
    }
}
