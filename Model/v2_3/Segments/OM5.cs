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
    /// OM5: Observation batteries
    /// </summary>
    public class OM5 : ChoHL7Segment
    {
        [Description("Sequence Number - Test/ Observation Master File")]
        [MaxLength(4)]
        public NM SequenceNumber
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("ObservationsIncludedWithOrderedTestBattery")]
        [MaxLength(200)]
        public CE[] PreferredCodingSystem
        {
            get { return GetValuesAt<CE>(1); }
        }
        [Description("Observation ID Suffixes")]
        [MaxLength(200)]
        public ST ObservationIDSuffixes
        {
            get { return GetValueAt<ST>(2); }
        }
    }
}
