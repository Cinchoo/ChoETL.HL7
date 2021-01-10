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
    /// UB1: UB82 data
    /// </summary>
    public class UB1 : ChoHL7Segment
    {
        [Description("Set ID")]
        [MaxLength(4)]
        public SI SetID
        {
            get { return GetValueAt<SI>(0); }
        }
        [Description("Blood Deductible")]
        [MaxLength(1)]
        public NM BloodDeductible
        {
            get { return GetValueAt<NM>(1); }
        }
        [Description("Blood Furnished Pints Of")]
        [MaxLength(2)]
        public NM BloodFurnishedPintsOf
        {
            get { return GetValueAt<NM>(2); }
        }
        [Description("Blood Replaced Pints")]
        [MaxLength(2)]
        public NM BloodReplacedPints
        {
            get { return GetValueAt<NM>(3); }
        }
        [Description("Blood Not Replaced Pints")]
        [MaxLength(2)]
        public NM BloodNotReplacedPints
        {
            get { return GetValueAt<NM>(4); }
        }
        [Description("Co Insurance Days")]
        [MaxLength(2)]
        public NM CoInsuranceDays
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Transcription Date/Time")]
        [MaxLength(2)]
        [ChoHL7MaxCount(5)]
        public IS[] ConditionCode
        {
            get { return GetValuesAt<IS>(6); }
        }
        [Description("Covered Days")]
        [MaxLength(3)]
        public NM CoveredDays
        {
            get { return GetValueAt<NM>(7); }
        }
        [Description("Non Covered Days")]
        [MaxLength(3)]
        public NM NonCoveredDays
        {
            get { return GetValueAt<NM>(8); }
        }
        [Description("Value Amount & Code")]
        [MaxLength(12)]
        [ChoHL7MaxCount(8)]
        public CM_UVC[] ValueAmountAndCode
        {
            get { return GetValuesAt<CM_UVC>(9); }
        }
        [Description("Number Of Grace Days")]
        [MaxLength(2)]
        public NM NumberOfGraceDays
        {
            get { return GetValueAt<NM>(10); }
        }
        [Description("Spec Program Indicator")]
        [MaxLength(60)]
        public CE SpecProgramIndicator
        {
            get { return GetValueAt<CE>(11); }
        }
        [Description("PSRO/UR Approval Indicator")]
        [MaxLength(60)]
        public ID PSROURApprovalIndicator
        {
            get { return GetValueAt<ID>(12); }
        }
        [Description("PSRO/UR Approved Stay Fm")]
        [MaxLength(8)]
        public DT PSROURApprovedStayFm
        {
            get { return GetValueAt<DT>(13); }
        }
        [Description("PSRO/UR Approved Stay To")]
        [MaxLength(8)]
        public DT PSROURApprovedStayTo
        {
            get { return GetValueAt<DT>(14); }
        }
        [Description("Occurrence")]
        [MaxLength(20)]
        [ChoHL7MaxCount(5)]
        public CM_OCD[] Occurrence
        {
            get { return GetValuesAt<CM_OCD>(15); }
        }
        [Description("Occurrence Span")]
        [MaxLength(2)]
        public ID OccurrenceSpan
        {
            get { return GetValueAt<ID>(16); }
        }
        [Description("Occur Span Start Date")]
        [MaxLength(8)]
        public DT OccurSpanStartDate
        {
            get { return GetValueAt<DT>(17); }
        }
        [Description("Occur Span End Date")]
        [MaxLength(8)]
        public DT OccurSpanEndDate
        {
            get { return GetValueAt<DT>(18); }
        }
        [Description("UB 82 Locater 2")]
        [MaxLength(30)]
        public ST UB82Locater2
        {
            get { return GetValueAt<ST>(19); }
        }
        [Description("UB 82 Locater 9")]
        [MaxLength(7)]
        public ST UB82Locater9
        {
            get { return GetValueAt<ST>(20); }
        }
        [Description("UB 82 Locater 27")]
        [MaxLength(8)]
        public ST UB82Locater27
        {
            get { return GetValueAt<ST>(21); }
        }
        [Description("UB 82 Locater 45")]
        [MaxLength(17)]
        public ST UB82Locater45
        {
            get { return GetValueAt<ST>(22); }
        }
    }
}
