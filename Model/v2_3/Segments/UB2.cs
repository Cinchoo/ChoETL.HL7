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
    /// UB2: UB92 data
    /// </summary>
    public class UB2 : ChoHL7Segment
    {
        [Description("Set ID")]
        [MaxLength(4)]
        public SI SetID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Co-Insurance Days")]
        [MaxLength(3)]
        public ST CoInsuranceDays
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Condition Code")]
        [MaxLength(2)]
        [ChoHL7MaxCount(7)]
        [ChoHL7EnumType(typeof(ConditionCode))]
        public ID[] ConditionCode
        {
            get { return GetValuesAt<ID>(2); }
        }
        [Description("Covered Days")]
        [MaxLength(3)]
        public ST CoveredDays
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Non-Covered Days")]
        [MaxLength(4)]
        public ST NonCoveredDays
        {
            get { return GetValueAt<ST>(4); }
        }
        [Description("Value Amount & Code")]
        [MaxLength(11)]
        [ChoHL7MaxCount(12)]
        public CM_UVC[] ValueAmountAndCode
        {
            get { return GetValuesAt<CM_UVC>(5); }
        }
        [Description("Occurrence Code & Date")]
        [MaxLength(11)]
        [ChoHL7MaxCount(8)]
        public CM_OCD[] OccurrenceCodeDate
        {
            get { return GetValuesAt<CM_OCD>(6); }
        }
        [Description("Occurrence Span Code/Dates")]
        [ChoHL7MaxCount(2)]
        [MaxLength(28)]
        public CM_OSP[] OccurrenceSpanCodeDates
        {
            get { return GetValuesAt<CM_OSP>(7); }
        }
        [Description("UB92 Locater 2")]
        [ChoHL7MaxCount(2)]
        [MaxLength(29)]
        public ST[] UB92Locater2
        {
            get { return GetValuesAt<ST>(8); }
        }
        [Description("UB92 Locater 11")]
        [MaxLength(12)]
        [ChoHL7MaxCount(2)]
        public ST[] UB92Locater11
        {
            get { return GetValuesAt<ST>(9); }
        }
        [Description("UB92 Locater 31")]
        [MaxLength(5)]
        public ST UB92Locater31
        {
            get { return GetValueAt<ST>(10); }
        }
        [Description("Document Control Number")]
        [ChoHL7MaxCount(3)]
        [MaxLength(23)]
        public ST[] DocumentControlNumber
        {
            get { return GetValuesAt<ST>(11); }
        }
        [Description("UB92 Locater 49")]
        [MaxLength(4)]
        [ChoHL7MaxCount(23)]
        public ST[] UB92Locater49
        {
            get { return GetValuesAt<ST>(12); }
        }
        [Description("UB92 Locater 56")]
        [MaxLength(14)]
        [ChoHL7MaxCount(5)]
        public ST[] UB92Locater56
        {
            get { return GetValuesAt<ST>(13); }
        }
        [Description("UB92 Locater 57")]
        [MaxLength(27)]
        public ST UB92Locater57
        {
            get { return GetValueAt<ST>(14); }
        }
        [Description("UB92 Locater 78")]
        [MaxLength(2)]
        [ChoHL7MaxCount(2)]
        public ST[] UB92Locater78
        {
            get { return GetValuesAt<ST>(15); }
        }
        [Description("Special Visit Count")]
        [MaxLength(3)]
        public NM SpecialVisitCount
        {
            get { return GetValueAt<NM>(16); }
        }
    }
}
