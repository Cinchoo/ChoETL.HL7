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
    /// MRG: Merge patient information
    /// </summary>
    public class MRG : ChoHL7Segment
    {
        [Description("Prior Patient ID - Internal")]
        [Required]
        [MaxLength(20)]
        public CX[] PriorPatientInternalID
        {
            get { return GetValuesAt<CX>(0); }
        }
        [Description("Prior Alternate Patient ID")]
        [MaxLength(16)]
        public CX[] PriorAlternatePatientID
        {
            get { return GetValuesAt<CX>(1); }
        }
        [Description("Prior Patient Account Number")]
        [MaxLength(20)]
        public CX PriorPatientAccountNumber
        {
            get { return GetValueAt<CX>(2); }
        }
        [Description("Prior Patient ID - External")]
        [MaxLength(16)]
        public CX PriorPatientExternalID
        {
            get { return GetValueAt<CX>(3); }
        }
        [Description("Prior Visit Number")]
        public CX PriorVisitNumber
        {
            get { return GetValueAt<CX>(4); }
        }
        [Description("Prior Alternate Visit ID")]
        public CX PriorAlternateVisitID
        {
            get { return GetValueAt<CX>(5); }
        }
        [Description("Prior Patient Name")]
        public CX PriorPatientName
        {
            get { return GetValueAt<CX>(6); }
        }
    }
}
