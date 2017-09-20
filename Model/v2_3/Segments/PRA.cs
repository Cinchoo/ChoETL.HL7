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
    /// PRA: Practitioner detail segment
    /// </summary>
    public class PRA : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(20)]
        public ST PrimaryKeyValue
        {
            get { return GetValueAt<ST>(0); }
        }
        [Description("Practitioner Group")]
        [MaxLength(60)]
        public CE[] PractitionerGroup
        {
            get { return GetValuesAt<CE>(1); }
        }
        [Description("Practitioner Category")]
        [MaxLength(3)]
        public ID[] PractitionerCategory
        {
            get { return GetValuesAt<ID>(2); }
        }
        [Description("Provider Billing")]
        [MaxLength(1)]
        public ID ProviderBilling
        {
            get { return GetValueAt<ID>(3); }
        }
        [Description("Specialty")]
        [MaxLength(100)]
        public CM_SPD[] Specialty
        {
            get { return GetValuesAt<CM_SPD>(4); }
        }
        [Description("Practitioner ID Numbers")]
        [MaxLength(100)]
        public CM_PLN[] PractitionerIDNumbers
        {
            get { return GetValuesAt<CM_PLN>(5); }
        }
        [Description("Privileges")]
        [MaxLength(200)]
        public CM_PIP[] Privileges
        {
            get { return GetValuesAt<CM_PIP>(6); }
        }
    }
}
