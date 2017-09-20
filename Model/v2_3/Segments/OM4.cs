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
    /// OM4: Observations that require specimens
    /// </summary>
    public class OM4 : ChoHL7Segment
    {
        [Description("Sequence Number - Test/ Observation Master File")]
        [MaxLength(4)]
        public NM SequenceNumber
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("Derived Specimen")]
        [MaxLength(1)]
        public ID DerivedSpecimen
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Container Description")]
        [MaxLength(60)]
        public TX ContainerDescription
        {
            get { return GetValueAt<TX>(2); }
        }
        [Description("Container Volume")]
        [MaxLength(20)]
        public NM ContainerVolume
        {
            get { return GetValueAt<NM>(3); }
        }
        [Description("Container Units")]
        [MaxLength(60)]
        public CE ContainerUnits
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Specimen")]
        [MaxLength(60)]
        public CE Specimen
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Additive")]
        [MaxLength(60)]
        public CE Additive
        {
            get { return GetValueAt<CE>(6); }
        }
        [Description("Preparation")]
        [MaxLength(10240)]
        public TX Preparation
        {
            get { return GetValueAt<TX>(7); }
        }
        [Description("Special Handling Requirements")]
        [MaxLength(10240)]
        public TX SpecialHandlingRequirements
        {
            get { return GetValueAt<TX>(8); }
        }
        [Description("Normal Collection Volume")]
        [MaxLength(20)]
        public CQ NormalCollectionVolume
        {
            get { return GetValueAt<CQ>(9); }
        }
        [Description("Minimum Collection Volume")]
        [MaxLength(20)]
        public CQ MinimumCollectionVolume
        {
            get { return GetValueAt<CQ>(10); }
        }
        [Description("Specimen Requirements")]
        [MaxLength(10240)]
        public TX SpecimenRequirements
        {
            get { return GetValueAt<TX>(11); }
        }
        [Description("Specimen Priorities")]
        [MaxLength(1)]
        public ID SpecimenPriorities
        {
            get { return GetValueAt<ID>(12); }
        }
        [Description("Specimen Retention Time")]
        [MaxLength(20)]
        public CQ SpecimenRetentionTime
        {
            get { return GetValueAt<CQ>(13); }
        }
    }
}
