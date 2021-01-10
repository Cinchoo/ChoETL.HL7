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
    /// STF: Staff identification segment
    /// </summary>
    public class STF : ChoHL7Segment
    {
        [Description("Primary Key Value")]
        [Required]
        [MaxLength(60)]
        public CE PrimaryKeyValue
        {
            get { return GetValueAt<CE>(0); }
        }
        [Description("Staff ID Code")]
        [MaxLength(60)]
        public CE[] StaffIDCode
        {
            get { return GetValuesAt<CE>(1); }
        }
        [Description("Staff Name")]
        [MaxLength(48)]
        public XPN StaffName
        {
            get { return GetValueAt<XPN>(2); }
        }
        [Description("Staff Type")]
        [Required]
        [MaxLength(2)]
        public ID[] StaffType
        {
            get { return GetValuesAt<ID>(3); }
        }
        [Description("Sex")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(Sex))]
        public IS Sex
        {
            get { return GetValueAt<IS>(4); }
        }
        [Description("Date of Birth")]
        [MaxLength(26)]
        public TS DateofBirth
        {
            get { return GetValueAt<TS>(5); }
        }
        [Description("Active/Inactive Flag")]
        [MaxLength(1)]
        public ID ActiveInactiveFlag
        {
            get { return GetValueAt<ID>(6); }
        }
        [Description("Department")]
        [MaxLength(200)]
        public CE Department
        {
            get { return GetValueAt<CE>(7); }
        }
        [Description("Service")]
        [MaxLength(200)]
        public CE Service
        {
            get { return GetValueAt<CE>(8); }
        }
        [Description("Phone")]
        [MaxLength(40)]
        public XTN Phone
        {
            get { return GetValueAt<XTN>(9); }
        }
        [Description("Office/Home Address")]
        [MaxLength(106)]
        [ChoHL7MaxCount(2)]
        public AD[] OfficeHomeAddress
        {
            get { return GetValuesAt<AD>(10); }
        }
        [Description("Activation Date")]
        [MaxLength(26)]
        public CM_DIN[] ActivationDate
        {
            get { return GetValuesAt<CM_DIN>(11); }
        }
        [Description("Inactivation Date")]
        [MaxLength(26)]
        public CM_DIN[] InactivationDate
        {
            get { return GetValuesAt<CM_DIN>(12); }
        }
        [Description("Backup Person ID")]
        [MaxLength(60)]
        public CE[] BackupPersonID
        {
            get { return GetValuesAt<CE>(13); }
        }
        [Description("E-mail Address")]
        [MaxLength(40)]
        public ST[] EMailAddress
        {
            get { return GetValuesAt<ST>(14); }
        }
        [Description("Preferred Method of Contact")]
        [MaxLength(200)]
        public CE PreferredMethodofContact
        {
            get { return GetValueAt<CE>(15); }
        }
        [Description("Marital Status")]
        [MaxLength(1)]
        [ChoHL7EnumType(typeof(MaritalStatus))]
        public IS[] MaritalStatus
        {
            get { return GetValuesAt<IS>(16); }
        }
        [Description("Job Title")]
        [MaxLength(20)]
        public ST JobTitle
        {
            get { return GetValueAt<ST>(17); }
        }
        [Description("Job Code/Class")]
        [MaxLength(20)]
        public JCC JobCodeClass
        {
            get { return GetValueAt<JCC>(18); }
        }
        [Description("Employment Status")]
        [MaxLength(2)]
        public IS EmploymentStatus
        {
            get { return GetValueAt<IS>(19); }
        }
        [Description("Additional Insured on Auto")]
        [MaxLength(1)]
        public ID AdditionalInsuredonAuto
        {
            get { return GetValueAt<ID>(20); }
        }
        [Description("Driver's License Number")]
        [MaxLength(25)]
        public DLN DriversLicenseNumber
        {
            get { return GetValueAt<DLN>(21); }
        }
        [Description("Copy Auto Ins")]
        [MaxLength(1)]
        public ID CopyAutoIns
        {
            get { return GetValueAt<ID>(22); }
        }
        [Description("Auto Ins. Expires")]
        [MaxLength(8)]
        public DT AutoInsExpires
        {
            get { return GetValueAt<DT>(23); }
        }
        [Description("Date Last DMV Review")]
        [MaxLength(8)]
        public DT DateLastDMVReview
        {
            get { return GetValueAt<DT>(24); }
        }
        [Description("Date Next DMV Review")]
        [MaxLength(8)]
        public DT DateNextDMVReview
        {
            get { return GetValueAt<DT>(25); }
        }
    }
}
