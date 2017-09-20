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
    /// OM2: Numeric observation
    /// </summary>
    public class OM2 : ChoHL7Segment
    {
        [Description("Sequence Number - Test/ Observation Master File")]
        [MaxLength(4)]
        public NM SequenceNumber
        {
            get { return GetValueAt<NM>(0); }
        }
        [Description("Units of Measure")]
        [MaxLength(60)]
        public CE UnitsofMeasure
        {
            get { return GetValueAt<CE>(1); }
        }
        [Description("Range of Decimal Precision")]
        [MaxLength(10)]
        public NM[] RangeofDecimalPrecision
        {
            get { return GetValuesAt<NM>(2); }
        }
        [Description("Corresponding SI Units of Measure")]
        [MaxLength(60)]
        public CE CorrespondingSIUnitsofMeasure
        {
            get { return GetValueAt<CE>(3); }
        }
        [Description("SI Conversion Factor")]
        [MaxLength(60)]
        public TX SIConversionFactor
        {
            get { return GetValueAt<TX>(4); }
        }
        [Description("Reference")]
        [MaxLength(200)]
        public CM_RFR Reference
        {
            get { return GetValueAt<CM_RFR>(5); }
        }
        [Description("Critical Range for Ordinal & Continuous Obs")]
        [MaxLength(200)]
        public CM_RANGE CriticalRangeforOrdinalContinuousObs
        {
            get { return GetValueAt<CM_RANGE>(6); }
        }
        [Description("Absolute Range for Ordinal & Continuous Obs")]
        [MaxLength(200)]
        public CM_ABS_RANGE AbsoluteRangeforOrdinalContinuousObs
        {
            get { return GetValueAt<CM_ABS_RANGE>(7); }
        }
        [Description("Delta Check Criteria")]
        [MaxLength(200)]
        public CM_DLT DeltaCheckCriteria
        {
            get { return GetValueAt<CM_DLT>(8); }
        }
        [Description("Minimum Meaningful Increments")]
        [MaxLength(8)]
        public NM MinimumMeaningfulIncrements
        {
            get { return GetValueAt<NM>(9); }
        }
    }
}
