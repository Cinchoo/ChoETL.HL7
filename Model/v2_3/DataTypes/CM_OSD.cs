using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("CM_OSD: Order Sequence")]
    public class CM_OSD : ChoHL7AbstractField
    {
        public ID SequenceResultsFlag
        {
            get { return GetValueAt<ID>(0); }
        }
        public ST PlacerOrderNumberEntityIdentifier
        {
            get { return GetValueAt<ST>(1); }
        }
        public IS PlacerOrderNumberNamespaceID
        {
            get { return GetValueAt<IS>(2); }
        }
        public ST FillerOrderNumberEntityIdentifier
        {
            get { return GetValueAt<ST>(3); }
        }
        public IS FillerOrderNumberNamespaceID
        {
            get { return GetValueAt<IS>(4); }
        }
        public ST SequenceConditionValue
        {
            get { return GetValueAt<ST>(5); }
        }
        public NM MaximumNumberOfRepeats
        {
            get { return GetValueAt<NM>(6); }
        }
        public ST PlacerOrderNumberUniversalID
        {
            get { return GetValueAt<ST>(7); }
        }
        public ID PlacerOrderNumberUniversalIDType
        {
            get { return GetValueAt<ID>(8); }
        }
        public ST FillerOrderNumberUniversalID
        {
            get { return GetValueAt<ST>(9); }
        }
        public ID FillerOrderNumberUniversalIDType
        {
            get { return GetValueAt<ID>(10); }
        }

        public CM_OSD(string value, ChoHL7Configuration config) : base(value, config)
        {
        }

        public CM_OSD(ChoHL7Field field) : base(field)
        {
        }
    }
}
