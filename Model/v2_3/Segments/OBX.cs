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
    /// OBX: Observation segment
    /// </summary>
    public class OBX : ChoHL7Segment
    {
        [Description("Set ID - OBX")]
        [MaxLength(4)]
        public SI ID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Value Type")]
        [MaxLength(2)]
        [ChoHL7EnumType(typeof(ValueType))]
        public ID ValueType
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Observation Identifier")]
        [Required]
        [MaxLength(590)]
        public CE ObservationIdentifier
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Observation Sub-ID")]
        [MaxLength(20)]
        public ST ObservationSubID
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Observation Value")]
        [MaxLength(65536)]
        public VARIES[] ObservationValue
        {
            get { return GetValuesAt<VARIES>(4); }
        }
        [Description("Units")]
        [MaxLength(60)]
        public CE Units
        {
            get { return GetValueAt<CE>(5); }
        }
        [Description("References Range")]
        [MaxLength(10)]
        public ST ReferencesRange
        {
            get { return GetValueAt<ST>(6); }
        }
        [Description("Abnormal Flags")]
        [MaxLength(5)]
        [ChoHL7MaxCount(5)]
        public ID AbnormalFlags
        {
            get { return GetValueAt<ID>(7); }
        }
        [Description("Probability")]
        [MaxLength(5)]
        public NM Probability
        {
            get { return GetValueAt<NM>(8); }
        }
        [Description("Nature of Abnormal Test")]
        [MaxLength(2)]
        public ID NatureofAbnormalTest
        {
            get { return GetValueAt<ID>(9); }
        }
        [Description("Observ Result Status")]
        [Required]
        [MaxLength(1)]
        public ID ObservResultStatus
        {
            get { return GetValueAt<ID>(10); }
        }
        [Description("Date Last Obs Normal Values")]
        [MaxLength(26)]
        public TS DateLastObsNormalValues
        {
            get { return GetValueAt<TS>(11); }
        }
        [Description("User Defined Access Checks")]
        [MaxLength(20)]
        public ST UserDefinedAccessChecks
        {
            get { return GetValueAt<ST>(12); }
        }
        [Description("Date/Time of the Observation")]
        [MaxLength(26)]
        public TS DateTimeoftheObservation
        {
            get { return GetValueAt<TS>(13); }
        }
        [Description("Producer's ID")]
        [MaxLength(60)]
        public CE ProducersID
        {
            get { return GetValueAt<CE>(14); }
        }
        [Description("Responsible Observer")]
        [MaxLength(80)]
        public XCN ResponsibleObserver
        {
            get { return GetValueAt<XCN>(15); }
        }
        [Description("Observation Method")]
        [MaxLength(80)]
        public CE[] ObservationMethod
        {
            get { return GetValuesAt<CE>(16); }
        }
    }
}
