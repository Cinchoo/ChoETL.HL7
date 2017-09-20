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
    /// OM3: Numeric observation
    /// </summary>
    public class OM3 : ChoHL7Segment
    {
        [Description("Sequence Number - Test/ Observation Master File")]
        [MaxLength(4)]
        public NM SequenceNumber
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("Preferred Coding System")]
        [MaxLength(60)]
        public CE PreferredCodingSystem
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Valid Coded Answers")]
        [MaxLength(60)]
        public CE ValidCodedAnswers
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Normal Text/Codes for Categorical Observations")]
        [MaxLength(200)]
        public CE[] NormalTextforCategoricalObservations
        {
            get { return GetValuesAt<CE>(3); }
        }
        [Description("Abnormal Text/Codes for Categorical Observations")]
        [MaxLength(200)]
        public CE AbnormalTextforCategoricalObservations
        {
            get { return GetValueAt<CE>(4); }
        }
        [Description("Critical Text Codes for Categorical Observations")]
        [MaxLength(200)]
        public CE CriticalTextforCategoricalObservations
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("Value Type")]
        [MaxLength(2)]
        [Required]
        public ID ValueType
        {
            get { return GetValueAt<ID>(6); }
        }
    }
}
