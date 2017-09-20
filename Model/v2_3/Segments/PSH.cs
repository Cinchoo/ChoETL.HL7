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
    /// PSH: Product Summary Header
    /// </summary>
    public class PSH : ChoHL7Segment
    {
        [Description("Report Type")]
        [Required]
        [MaxLength(60)]
        public ST ReportType
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("Report Form Identifier")]
        [MaxLength(60)]
        public ST ReportFormIdentifier
        {
            get { return GetValueAt<ST>(1); }
        }
        [Description("Report Date")]
        [MaxLength(26)]
        public TS ReportDate
        {
            get { return GetValueAt<TS>(2); }
        }
        [Description("Report Interval Start Date")]
        [MaxLength(26)]
        public TS ReportIntervalStartDate
        {
            get { return GetValueAt<TS>(3); }
        }
        [Description("Report Interval End Date")]
        [MaxLength(26)]
        public TS ReportIntervalEndDate
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Quantity Manufactured")]
        [MaxLength(12)]
        public CQ QuantityManufactured
        {
            get { return GetValueAt<CQ>(5); }
        }
        [Description("Quantity Distributed")]
        [MaxLength(12)]
        public CQ QuantityDistributed
        {
            get { return GetValueAt<CQ>(6); }
        }
        [Description("Quantity Distributed Method")]
        [MaxLength(1)]
        public ID QuantityDistributedMethod
        {
            get { return GetValueAt<ID>(7); }
        }
        [Description("Quantity Distributed Comment")]
        [MaxLength(600)]
        public FT QuantityDistributedComment
        {
            get { return GetValueAt<FT>(8); }
        }
        [Description("Quantity in Use")]
        [MaxLength(12)]
        public CQ QuantityinUse
        {
            get { return GetValueAt<CQ>(9); }
        }
        [Description("Quantity in Use Method")]
        [MaxLength(1)]
        public ID QuantityinUseMethod
        {
            get { return GetValueAt<ID>(10); }
        }
        [Description("Quantity in Use Comment")]
        [MaxLength(600)]
        public FT QuantityinUseComment
        {
            get { return GetValueAt<FT>(11); }
        }
        [Description("Number of Product Experience Reports Filed by Facility")]
        [MaxLength(2)]
        public NM NumberofProductExperienceReportsFiledbyFacility
        {
            get { return GetValueAt<NM>(12); }
        }
        [Description("Number of Product Experience Reports Filed by Distributor")]
        [MaxLength(2)]
        public NM NumberofProductExperienceReportsFiledbyDistributor
        {
            get { return GetValueAt<NM>(13); }
        }
    }
}
