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
    /// AL1: Patient Allergy Information
    /// </summary>
    public class AL1 : ChoHL7Segment
    {
        [Description("Set ID - AL1")]
        [Required]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Allergy Type")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AllergyType))]
        public ID AllergyType
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Allergy Code")]
        [Required]
        [MaxLength(60)]
        public CE AllergyCode
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Allergy Severity")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(AllergySeverity))]
        public IS AllergySeverity
        {
            get { return GetValueAt<IS>(3); }
        }
        [Description("Allergy Reaction")]
        [MaxLength(15)]
        public ST AllergyReaction
        {
            get { return GetValueAt<ST>(4); }
        }
        [Description("Identification Date")]
        [MaxLength(8)]
        public DT IdentificationDate
        {
            get { return GetValueAt<DT>(5); }
        }
    }
}
