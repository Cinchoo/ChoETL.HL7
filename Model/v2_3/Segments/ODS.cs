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
    /// ODS: Dietary orders, supplements, and preferences
    /// </summary>
    public class ODS : ChoHL7Segment
    {
        [Description("Type")]
        [Required]
        [MaxLength(1)]
        public SI Type
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Service Period")]
        [MaxLength(60)]
        [ChoHL7MaxCount(10)]
        public CE[] ServicePeriod
        {
            get { return GetValuesAt<CE>(1); }
        }
        [Description("Diet, Supplement, or Preference Code")]
        [Required]
        [MaxLength(60)]
        [ChoHL7MaxCount(20)]
        public CE[] DietSupplementorPreferenceCode
        {
            get { return GetValuesAt<CE>(2); }
        }
        [Description("Text Instruction")]
        [MaxLength(80)]
        public ST TextInstruction
        {
            get { return GetValueAt<ST>(3); }
        }
    }
}
