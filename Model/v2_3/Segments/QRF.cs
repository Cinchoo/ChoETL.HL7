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
    /// QRF: Query filter segment
    /// </summary>
    public class QRF : ChoHL7Segment
    {
        [Description("Where Subject Filter")]
        [Required]
        [MaxLength(20)]
        public ST WhereSubjectFilter
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("When Data Start Date/Time")]
        [MaxLength(26)]
        public TS WhenDataStartDateTime
        {
            get { return GetValueAt<TS>(1); }
        }
        [Description("When Data End Date/Time")]
        [MaxLength(26)]
        public TS WhenDataEndDateTime
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("What User Qualifier")]
        [MaxLength(60)]
        public ST[] WhatUserQualifier
        {
            get { return GetValuesAt<ST>(3); }
        }
        [Description("Other QRY Subject Filter")]
        [MaxLength(60)]
        public ST[] OtherQRYSubjectFilter
        {
            get { return GetValuesAt<ST>(4); }
        }
        [Description("Which Date/Time Qualifier")]
        [MaxLength(12)]
        public ID[] WhichDateTimeQualifier
        {
            get { return GetValuesAt<ID>(5); }
        }
        [Description("Which Date/Time Status Qualifier")]
        [MaxLength(12)]
        public ID[] WhichDateTimeStatusQualifier
        {
            get { return GetValuesAt<ID>(6); }
        }
        [Description("Date/Time Selection Qualifier")]
        [MaxLength(12)]
        public ID[] DateTimeSelectionQualifier
        {
            get { return GetValuesAt<ID>(7); }
        }
        [Description("When Quantity/Timing Qualifier")]
        [MaxLength(60)]
        public TQ WhenQuantityTimingQualifier
        {
            get { return GetValueAt<TQ>(8); }
        }
    }
}
