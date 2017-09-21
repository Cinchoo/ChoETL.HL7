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
    /// QRD: Query definition segment
    /// </summary>
    public class QRD : ChoHL7Segment
    {
        [Description("Query Date/Time")]
        [MaxLength(26)]
        public TS QueryDateTime
        {
            get { return GetValueAt<TS>(0); }
        }
        [Description("Query Format Code")]
        [Required]
        [MaxLength(1)]
        public ID QueryFormatCode
        {
            get { return GetValueAt<ID>(1); }
        }
        [Description("Query Priority")]
        [Required]
        [MaxLength(1)]
        public ID QueryPriority
        {
            get { return GetValueAt<ID>(2); }
        }
        [Description("Query ID")]
        [Required]
        [MaxLength(10)]
        public ST QueryID
        {
            get { return GetValueAt<ST>(3); }
        }
        [Description("Deferred Response Type")]
        [MaxLength(1)]
        public ID DeferredResponseType
        {
            get { return GetValueAt<ID>(4); }
        }
        [Description("Deferred Response Date/Time")]
        [MaxLength(26)]
        public TS DeferredResponseDateTime
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Quantity Limited Request")]
        [Required]
        [MaxLength(10)]
        public CQ QuantityLimitedRequest
        {
            get { return GetValueAt<CQ>(6); }
        }
        [Description("Who Subject Filter")]
        [Required]
        [MaxLength(60)]
        public XCN[] WhoSubjectFilter
        {
            get { return GetValuesAt<XCN>(7); }
        }
        [Description("What Subject Filter")]
        [Required]
        [MaxLength(60)]
        public CE[] WhatSubjectFilter
        {
            get { return GetValuesAt<CE>(8); }
        }
        [Description("What Department Data Code")]
        [Required]
        [MaxLength(60)]
        public CE[] WhatDepartmentDataCode
        {
            get { return GetValuesAt<CE>(9); }
        }
        [Description("What Data Code Value Qualifier")]
        [MaxLength(20)]
        public CM_VR WhatDataCodeValueQualifier
        {
            get { return GetValueAt<CM_VR>(10); }
        }
        [Description("Query Results Level")]
        [MaxLength(1)]
        public ID QueryResultsLevel
        {
            get { return GetValueAt<ID>(11); }
        }
    }
}
