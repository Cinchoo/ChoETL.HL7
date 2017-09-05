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
    /// ACC: Accident
    /// </summary>
    public class ACC : ChoHL7Segment
    {
        [Description("Accident Date/Time")]
        [MaxLength(26)]
        public TS AccidentDateTime
        {
            get { return GetValueAt<TS>(0); }
        }
        [Description("Accident Code")]
        [MaxLength(2)]
        public ID AccidentCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Accident Location")]
        [MaxLength(25)]
        public ST AccidentLocation
        {
            get { return GetValueAt<ST>(2); }
        }
        [Description("Auto Accident State")]
        [MaxLength(60)]
        public CE AutoAccidentState
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("Accident Job Related Indicator")]
        [MaxLength(2)]
        public ID AccidentJobRelatedIndicator
        {
            get { return GetValueAt<ID>(4); }
        }
        [Description("Accident Death Indicator")]
        [MaxLength(2)]
        public ID AccidentDeathIndicator
        {
            get { return GetValueAt<ID>(5); }
        }
    }
}
