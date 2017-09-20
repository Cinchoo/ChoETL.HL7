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
    /// OM6: Observations that are calculated from other observations
    /// </summary>
    public class OM6 : ChoHL7Segment
    {
        [Description("Sequence Number - Test/ Observation Master File")]
        [MaxLength(4)]
        public NM SequenceNumber
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("Derivation Rule")]
        [MaxLength(10240)]
        public TX DerivationRule
        {
            get { return GetValueAt<TX>(1); }
        }
    }
}
