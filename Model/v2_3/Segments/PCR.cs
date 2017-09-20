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
    /// PCR: Possible Causal Relationship
    /// </summary>
    public class PCR : ChoHL7Segment
    {
        [Description("Implicated Product")]
        [Required]
        [MaxLength(60)]
        public CE ImplicatedProduct
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Generic Product")]
        [MaxLength(1)]
        public IS GenericProduct
        {
            get { return GetValueAt<IS>(1); }
        }
        [Description("Product Class")]
        [MaxLength(30)]
        public CE ProductClass
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Total Duration Of Therapy")]
        [MaxLength(8)]
        public CQ TotalDurationOfTherapy
        {
            get { return GetValueAt<CQ>(3); }
        }
        [Description("Product Manufacture Date")]
        [MaxLength(26)]
        public TS ProductManufactureDate
        {
            get { return GetValueAt<TS>(4); }
        }
        [Description("Product Expiration Date")]
        [MaxLength(26)]
        public TS ProductExpirationDate
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Product Implantation Date")]
        [MaxLength(26)]
        public TS ProductImplantationDate
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Product Explanation Date")]
        [MaxLength(26)]
        public TS ProductExplanationDate
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Single Use Device")]
        [MaxLength(8)]
        public IS SingleUseDevice
        {
            get { return GetValueAt<IS>(8); }
        }
        [Description("Indication For Product Use")]
        [MaxLength(60)]
        public CE IndicationForProductUse
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Product Problem")]
        [MaxLength(8)]
        public IS ProductProblem
        {
            get { return GetValueAt<IS>(10); }
        }
        [Description("Product Serial/Lot Number")]
        [MaxLength(30)]
        [ChoHL7MaxCount(3)]
        public ST[] ProductSerialNumber
        {
            get { return GetValuesAt<ST>(11); }
        }
        [Description("Product Available For Inspection")]
        [MaxLength(1)]
        public IS ProductAvailableForInspection
        {
            get { return GetValueAt<IS>(12); }
        }
        [Description("Product Evaluation Performed")]
        [MaxLength(8)]
        public CE ProductEvaluationPerformed
        {
            get { return GetValueAt<CE>(13); }
        }
        [Description("Product Evaluation Status")]
        [MaxLength(60)]
        public CE ProductEvaluationStatus
        {
            get { return GetValueAt<CE>(14); }
        }
        [Description("Product Evaluation Results")]
        [MaxLength(60)]
        public CE ProductEvaluationResults
        {
            get { return GetValueAt<CE>(15); }
        }
        [Description("Evaluated Product Source")]
        [MaxLength(8)]
        public ID EvaluatedProductSource
        {
            get { return GetValueAt<ID>(16); }
        }
        [Description("Date Product Returned To Manufacturer")]
        [MaxLength(26)]
        public TS DateProductReturnedToManufacturer
        {
            get { return GetValueAt<TS>(17); }
        }
        [Description("Device Operator Qualifications")]
        [MaxLength(1)]
        public ID DeviceOperatorQualifications
        {
            get { return GetValueAt<ID>(18); }
        }
        [Description("Relatedness Assessment")]
        [MaxLength(8)]
        public ID RelatednessAssessment
        {
            get { return GetValueAt<ID>(19); }
        }
        [Description("Action Taken In Response To The Event")]
        [MaxLength(2)]
        [ChoHL7MaxCount(6)]
        public ID[] ActionTakenInResponseToTheEvent
        {
            get { return GetValuesAt<ID>(20); }
        }
        [Description("Event Causality Observations")]
        [MaxLength(2)]
        [ChoHL7MaxCount(6)]
        public ID[] EventCausalityObservations
        {
            get { return GetValuesAt<ID>(21); }
        }
        [Description("Indirect Exposure Mechanism")]
        [MaxLength(2)]
        [ChoHL7MaxCount(3)]
        public ID[] IndirectExposureMechanism
        {
            get { return GetValuesAt<ID>(22); }
        }
    }
}
