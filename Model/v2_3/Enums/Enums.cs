using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoETL.HL7.Model.v2_3
{
    [Description("0007: Admission type")]
    public enum AdmissionType
    {
        Accident = 'A',
        Emergency = 'E',
        LaborAndDelivery = 'L',
        Routine = 'R'
    }

    [Description("0023: Admit source")]
    public enum AdmitSource
    {
        PhysicianReferral = '1',
        ClinicReferral = '2',
        HMOReferral = '3',
        TransferFromHospital = '4',
        TransferFromSkilledNursingFacility = '5',
        TransferFromAnotherHealthcareFacility = '6',
        EmergencyRoom = '7',
        CourtLawEnforcement = '8',
        InformationNotAvailable = '9'
    }

    [Description("0128: Allergy severity")]
    public enum AllergySeverity
    {
        [Description("SV")]
        Severe,
        [Description("MO")]
        Moderate,
        [Description("MI")]
        Mild
    }

    [Description("0127: Allergy type")]
    public enum AllergyType
    {
        [Description("DA")]
        DrugAllergy,
        [Description("FA")]
        FoodAllergy,
        [Description("MA")]
        MiscellaneousAllergy,
        [Description("MC")]
        MiscellaneousContraindication
    }

    [Description("0279: Allow substitution codes")]
    public enum AllowSubstitutionCodes
    {
    }

    /// <summary>
    /// 0009: Ambulatory status
    /// </summary>
    [Description("0009: Ambulatory status")]
    public enum AmbulatoryStatus
    {
        [Description("A0")]
        Nofunctionallimitations,
        [Description("A1")]
        Ambulateswithassistivedevice,
        [Description("A2")]
        WheelchairStretcherbound,
        [Description("A3")]
        ComatoseNonResponsive,
        [Description("A4")]
        Disoriented,
        [Description("A5")]
        Visionimpaired,
        [Description("A6")]
        Hearingimpaired,
        [Description("A7")]
        Speechimpaired,
        [Description("A8")]
        NonEnglishspeaking,
        [Description("A9")]
        Functionallevelunknown,
        [Description("B1")]
        Oxygentherapy,
        [Description("B2")]
        Specialequipment,
        [Description("B3")]
        Amputee,
        [Description("B4")]
        Mastectomy,
        [Description("B5")]
        Paraplegic,
        [Description("B6")]
        Pregnant
    }

    [Description("0193: Amount class")]
    public enum AmountClass
    {
        [Description("AT")]
        Amount,
        [Description("LM")]
        Limit,
        [Description("PC")]
        Percentage,
        [Description("UL")]
        Unlimited
    }

    [Description("0276: Appointment reason codes")]
    public enum AppointmentReasonCodes
    {
    }

    [Description("0276: Appointment type  codes")]
    public enum AppointmentTypeCodes
    {
    }

    /// <summary>
    /// 0135: Assignment of benefits
    /// </summary>
    [Description("0135: Assignment of benefits")]
    public enum AssignmentOfBenefits
    {
        Yes = 'Y',
        No = 'N',
        ModifiedAssignment = 'M'
    }

    [Description("0116: Bed status")]
    public enum BedStatus
    {
        Closed = 'C',
        Housekeeping = 'H',
        Occupied = 'O',
        Unoccupied = 'U',
        Contaminated = 'C',
        Isolated = 'I'
    }

    [Description("0269: Charge on indicator")]
    public enum ChargeOnIndicator
    {
        ChargeOnOrder = 'O',
        ChargeOnResult = 'R'
    }

    [Description("0043: Condition code")]
    public enum ConditionCode
    {
        [Description("01")]
        Militaryservicerelated,
        [Description("02")]
        Conditionisemploymentrelated,
        [Description("03")]
        Patientcoveredbyinsurancenotreflectedhere,
        [Description("04")]
        HMOenrollee,
        [Description("05")]
        Lienhasbeenfiled,
        [Description("06")]
        ESRDpatientinfirst18monthsofentitlementcoveredbyemployergrouphealthinsurance,
        [Description("07")]
        Treatmentofnonterminalconditionforhospicepatient,
        [Description("08")]
        Beneficiarywouldnotprovideinformationconcerningotherinsurancecoverage,
        [Description("09")]
        Neitherpatientnorspouseisemployed,
        [Description("10")]
        PatientandorspouseisemployedbutnoEGHPexists,
        [Description("11")]
        DisabledbeneficiarybutnoLGHP,
        [Description("12")]
        Payercodes_12,
        [Description("13")]
        Payercodes_13,
        [Description("14")]
        Payercodes_14,
        [Description("15")]
        Payercodes_15,
        [Description("16")]
        Payercodes_16,
        [Description("18")]
        Maidennameretained,
        [Description("19")]
        Childretainsmothersname,
        [Description("20")]
        Beneficiaryrequestedbilling,
        [Description("21")]
        BillingforDenialNotice,
        [Description("26")]
        VAeligiblepatientchoosestoreceiveservicesinaMedicarecertifiedfacility,
        [Description("27")]
        Patientreferredtoasolecommunityhospitalforadiagnosticlaboratorytest,
        [Description("28")]
        PatientandorspousesEGHPissecondarytoMedicare,
        [Description("29")]
        DisabledbeneficiaryandorfamilymembersLGHPissecondarytoMedicare,
        [Description("31")]
        Patientisstudentfulltimeday,
        [Description("32")]
        Patientisstudentcooperativeworkstudyprogram,
        [Description("33")]
        Patientisstudentfulltimenight,
        [Description("34")]
        PatientisstudentParttime,
        [Description("36")]
        Generalcarepatientinaspecialunit,
        [Description("37")]
        Wardaccommodationaspatientrequest,
        [Description("38")]
        Semiprivateroomnotavailable,
        [Description("39")]
        Privateroommedicallynecessary,
        [Description("40")]
        Samedaytransfer,
        [Description("41")]
        Partialhospitalization,
        [Description("46")]
        Nonavailabilitystatementonfile,
        [Description("48")]
        Psychiatricresidentialtreatmentcentersforchildrenandadolescents,
        [Description("55")]
        SNFbednotavailable,
        [Description("56")]
        Medicalappropriateness,
        [Description("57")]
        SNFreadmission,
        [Description("60")]
        Dayoutlier,
        [Description("61")]
        Costoutlier,
        [Description("62")]
        Payercode,
        [Description("66")]
        Providerdoesnotwishcostoutlierpayment,
        [Description("67")]
        Beneficiaryelectsnottouselifetimereservedays,
        [Description("68")]
        Beneficiaryelectstouselifetimereservedays,
        [Description("70")]
        SelfadministeredEPO,
        [Description("71")]
        Fullcareinunit,
        [Description("72")]
        Selfcareinunit,
        [Description("73")]
        Selfcaretraining,
        [Description("74")]
        Home,
        [Description("75")]
        Home100Percentreimbursement,
        [Description("76")]
        Backupinfacilitydialysis,
        [Description("77")]
        Provideracceptsorisobligatedrequiredduetoacontractualarrangementorlawtoacceptpaymentbyaprimarypayeraspaymentinfull,
        [Description("78")]
        NewcoveragenotimplementedbyHMO,
        [Description("79")]
        Corfservicesprovidedoffsite,
        [Description("80")]
        Pregnant
    }

    [Description("0177: Confidentiality code")]
    public enum ConfidentialityCode
    {
        [Description("V")]
        VeryRestricted,
        [Description("R")]
        Restricted,
        [Description("U")]
        UsualControl,
        [Description("EMP")]
        Employee,
        [Description("UWM")]
        UnwedMother,
        [Description("VIP")]
        VeryImportantPersonOrCelebrity,
        [Description("PSY")]
        PsychiatricPatient,
        [Description("AID")]
        AIDSPatient,
        [Description("HIV")]
        HIVPlusPatient,
        [Description("ETH")]
        AlcoholDrugTreatmentPatient,
    }

    /// <summary>
    /// 0173: Coordination of benefits
    /// </summary>
    [Description("0173: Coordination of benefits")]
    public enum CoordinationOfBenefits
    {
        [Description("CO")]
        Coordination,
        [Description("IN")]
        Independent
    }

    /// <summary>
    /// 0309: Coverage type
    /// </summary>
    [Description("0309: Coverage type")]
    public enum CoverageType
    {
        Hospital = 'H',
        Physician = 'P',
        Both = 'B'
    }

    [Description("0228: Diagnosis classification")]
    public enum DiagnosisClassification
    {
        Consultation = 'C',
        Diagnosis = 'D',
        Medicationantibiotic = 'M',
        Other = 'O',
        RadiologicalschedulingnotusingICDAcodes = 'R',
        Signandsymptom = 'S',
        Tissuediagnosis = 'T',
        Invasiveprocedurenotclassifiedelsewhere = 'I'
    }

    [Description("0052: Diagnosis type")]
    public enum DiagnosisType
    {
        Admitting = 'A',
        Working = 'W',
        Final = 'F'
    }

    [Description("0112: Discharge disposition")]
    public enum DischargeDisposition
    {
        [Description("01")]
        Dischargedtohomeorselfcare,
        [Description("02")]
        Dischargedtransferredtoanothershorttermgeneralhospitalforinpatientcare,
        [Description("03")]
        Dischargedtransferredtoskillednursingfacility,
        [Description("04")]
        Dischargedtransferredtoanintermediatecarefacility,
        [Description("05")]
        Dischargedtransferredtoanothertypeofinstitutionforinpatientcareorreferredforoutpatientservicestoanotherinstitution,
        [Description("06")]
        Dischargedtransferredtohomeundercareoforganizedhomehealthserviceorganization,
        [Description("07")]
        Leftagainstmedicaladviceordiscontinuedcare,
        [Description("08")]
        DischargedtransferredtohomeundercareofHomeIVprovider,
        [Description("09")]
        Admittedasaninpatienttothishospital,
        [Description("10,11,12,13,14,15,16,17,18,19")]
        Dischargetobedefinedatstatelevel,
        [Description("20")]
        Expired,
        [Description("21,22,23,24,25,26,27,28,29")]
        Expiredtobedefinedatstatelevel,
        [Description("30")]
        Stillpatientorexpectedtoreturnforoutpatientservices,
        [Description("31,32,33,34,35,37,38,39")]
        Stillpatienttobedefinedatstatelevel,
        [Description("40")]
        Expiredathome,
        [Description("41")]
        Expiredinamedicalfacility,
        [Description("42")]
        Expiredplaceunknown
    }

    [Description("0270: Document type")]
    public enum DocumentType
    {
        [Description("AR")]
        Autopsyreport,
        [Description("CD")]
        Cardiodiagnostics,
        [Description("CN")]
        Consultation,
        [Description("DI")]
        Diagnosticimaging,
        [Description("DS")]
        Dischargesummary,
        [Description("ED")]
        Emergencydepartmentreport,
        [Description("HP")]
        Historyandphysicalexamination,
        [Description("OP")]
        Operativereport,
        [Description("PC")]
        Psychiatricconsultation,
        [Description("PH")]
        Psychiatrichistoryandphysicalexamination,
        [Description("PN")]
        Procedurenote,
        [Description("PR")]
        Progressnote,
        [Description("SP")]
        Surgicalpathology,
        [Description("TS")]
        Transfersummary
    }

    [Description("0229: DRG payor")]
    public enum DRGPayor
    {
        Medicare = 'M',
        Champus = 'C',
        ManagedCareOrganization = 'G'
    }

    [Description("0144: Eligibility source")]
    public enum EligibilitySource
    {
        Insurancecompany = '1',
        Employer = '2',
        Insuredpresentedpolicy = '3',
        Insuredpresentedcard = '4',
        Signedstatementonfile = '5',
        Verbalinformation = '6',
        None = '7',
    }

    [Description("0062: Event reason")]
    public enum EventReason
    {
        [Description("01")]
        PatientRequest,
        [Description("02")]
        PhysicianOrder,
        [Description("03")]
        CensusManagement
    }

    [Description("0278: Filler status code")]
    public enum FillerStatusCode
    {
    }

    [Description("0203: Identifier type")]
    public enum IdentifierType
    {
        [Description("AM")]
        AmericanExpress,
        [Description("AN")]
        Accountnumber,
        [Description("BR")]
        Birthregistrynumber,
        [Description("DI")]
        DinersClubcard,
        [Description("DL")]
        Driverslicensenumber,
        [Description("DN")]
        Doctornumber,
        [Description("DS")]
        DiscoverCard,
        [Description("EI")]
        Employeenumber,
        [Description("EN")]
        Employernumber,
        [Description("FI")]
        FacilityID,
        [Description("GI")]
        Guarantorinternalidentifier,
        [Description("GN")]
        Guarantorexternalidentifier,
        [Description("LN")]
        Licensenumber,
        [Description("LR")]
        LocalRegistryID,
        [Description("MS")]
        MasterCard,
        [Description("MA")]
        Medicaidnumber,
        [Description("MC")]
        Medicarenumber,
        [Description("MR")]
        Medicalrecordnumber,
        [Description("NE")]
        Nationalemployeridentifier,
        [Description("NI")]
        Nationaluniqueindividualidentifier,
        [Description("NH")]
        NationalHealthPlanIdentifier,
        [Description("NN...")]
        NationalPersonIdentifier,
        [Description("NPI")]
        Nationalprovideridentifier,
        [Description("PI")]
        Patientinternalidentifier,
        [Description("PN")]
        Personnumber,
        [Description("PRN")]
        Providernumber,
        [Description("PT")]
        Patientexternalidentifier,
        [Description("RRI")]
        RegionalregistryID,
        [Description("RR")]
        RailroadRetirementnumber,
        [Description("SL")]
        Statelicense,
        [Description("SR")]
        StateregistryID,
        [Description("SS")]
        SocialSecuritynumber,
        [Description("U")]
        Unspecified,
        [Description("UPIN")]
        MedicareHCFAsUniversalPhysicianIdentificationnumbers,
        [Description("VS")]
        VISA,
        [Description("VN")]
        Visitnumber,
        [Description("WC")]
        WICidentifier,
        [Description("XX")]
        Organizationidentifier
    }

    [Description("0232: Insurance company contact reason")]
    public enum InsuranceCompanyContactReason
    {
        [Description("01")]
        MedicareClaimStatus,
        [Description("02")]
        MedicaidClaimStatus,
        [Description("03")]
        NameAddressChange
    }

    /// <summary>
    /// 0220: Living arrangement
    /// </summary>
    [Description("0220: Living arrangement")]
    public enum LivingArrangement
    {
        Alone = 'A',
        Family = 'F',
        Institution = 'I',
        Relative = 'R',
        Unknown = 'U',
        SpouseOnly = 'S'
    }

    /// <summary>
    /// 0223: Living dependency
    /// </summary>
    [Description("0223: Living dependency")]
    public enum LivingDependency
    {
        [Description("D")]
        SpouseDependent,
        MedicalSupervisionRequired,
        [Description("S")]
        SmallChildren,
        [Description("WU")]
        Walkup,
        [Description("CB")]
        CommonBath
    }

    [Description("0315: Living will")]
    public enum LivingWill
    {
        Yespatienthasalivingwill = 'Y',
        Yespatienthasalivingwillbutitisnotonfile = 'F',
        Nopatientdoesnothavealivingwillandnoinformationwasprovided = 'N',
        Nopatientdoesnothavealivingwillbutinformationwasprovided = 'I',
        Unknown = 'U'
    }

    [Description("0261: Location equipment")]
    public enum LocationEquipment
    {
        [Description("OXY")]
        Oxygen,
        [Description("SUC")]
        Suction,
        [Description("VIT")]
        Vitalsignsmonitor,
        [Description("INF")]
        Infusionpump,
        [Description("IVP")]
        IVpump,
        [Description("EEG")]
        ElectroEncephalogram,
        [Description("EKG")]
        ElectroCardiogram,
        [Description("VEN")]
        Ventilator
    }

    [Description("0137: Mail claim party")]
    public enum MailClaimParty
    {
        Employer = 'E',
        Guarantor = 'G',
        InsuranceCompany = 'I',
        Other = 'O',
        Patient = 'P'
    }

    /// <summary>
    /// 0002: Marital status
    /// </summary>
    [Description("0002: Marital status")]
    public enum MaritalStatus
    {
        Separated = '1',
        Divorced = 'D',
        Married = 'M',
        Single = 'S',
        Widowed = 'W'
    }

    [Description("0141: Military rank/grade")]
    public enum MilitaryRank
    {
        [Description("E1,E2,E3,E4,E5,E6,E7,E8,E9")]
        Enlisted,
        [Description("O1,O2,O3,O4,O5,O6,O7,O8,O9,O10")]
        Officers,
        [Description("W1,W2,W3,W4")]
        WarrantOfficers
    }

    [Description("0140: Military service")]
    public enum MilitaryService
    {
        [Description("USA")]
        USArmy,
        [Description("USN")]
        USNavy,
        [Description("USAF")]
        USAirForce,
        [Description("USMC")]
        USMarines,
        [Description("USCG")]
        USCoastGaurd,
        [Description("USPHS")]
        USPublicHealthService,
        [Description("NOAA")]
        NationalOceanicAndAtmosphericAdministration,
        [Description("NATO")]
        NorthAtlanticTreatyOrganization
    }

    [Description("0142: Military status")]
    public enum MilitaryStatus
    {
        [Description("ACT")]
        ActiveDuty,
        [Description("RET")]
        Retired,
        [Description("DEC")]
        Deceased
    }

    [Description("0174: Nature of test/observation")]
    public enum NatureOfTestObservation
    {
        ProfileOrBatteryConsistingofManyIndependentAtomicObservations = 'P',
        Functionalprocedurethatmayconsistofoneormoreinterrelatedmeasures = 'F',
        Atomictestobservation = 'A',
        Supersetasetofbatteriesorproceduresorderedunderasinglecodeunitbutprocessedasseparatebatteries = 'S',
        Singleobservationcalculatedviaaruleorformulafromotherindependentobservations = 'C'
    }

    [Description("0316: Organ donor")]
    public enum OrganDonor
    {
        Yespatientisadonorandcardisonfile = 'F',
        Yespatientisadonorbutcardisnotonfile = 'M',
        Nopatientdoesnothavealivingwillbutinformationwasprovided = 'O',
        Unknowm = 'U'
    }

    [Description("0083: Outlier type")]
    public enum OutlierType
    {
        OutlierDays = 'D',
        OutlierCost = 'C'
    }

    [Description("0004: Patient class")]
    public enum PatientClass
    {
        Emergency = 'E',
        Inpatient = 'I',
        Outpatient = 'O',
        Preadmit = 'P',
        RecurringPatient = 'R',
        Obstetrics = 'B'
    }

    [Description("0260: Patient location type")]
    public enum PatientLocationType
    {
        NursingUnit = 'N',
        Room = 'R',
        Bed = 'B',
        ExamRoom = 'E',
        OperatingRoom = 'O',
        Clinic = 'C',
        Department = 'D',
        OtherLocation = 'L',
    }

    [Description("0147: Policy type")]
    public enum PolicyType
    {
        [Description("ANC")]
        Ancillary,
        [Description("2ANC")]
        SecondAncillary,
        [Description("MMD")]
        MajorMedical,
        [Description("2MMD")]
        SecondMajorMedical,
        [Description("3MMD")]
        ThirdMajorMedical
    }

    /// <summary>
    /// 0230: Procedure functional type
    /// </summary>
    [Description("0230: Procedure functional type")]
    public enum ProcedureType
    {
        Anesthesia = 'A',
        ProcedureForTreatment = 'P',
        InvasiveProcedureNotClassifiedElsewhere = 'I',
        DiagnosticProcedure = 'D'
    }

    [Description("0213: Purge status")]
    public enum PurgeStatus
    {
        MarkedforpurgeUserisnolongerabletoupdatethevisit = 'A',
        Thevisitismarkedfordeletionandtheusercannotenternewdataagainstit = 'P',
        hevisitismarkedinactiveandtheusercannotenternewdataagainstit = 'I'
    }

    /// <summary>
    /// 0093: Release information
    /// </summary>
    [Description("0093: Release information")]
    public enum ReleaseInformation
    {
        Yes = 'Y',
        Bo = 'N'
    }

    /// <summary>
    /// 0145: Room type
    /// </summary>
    [Description("0145: Room type")]
    public enum RoomType
    {
        [Description("PRI")]
        PrivateRoom,
        [Description("2PRI")]
        SecondPrivateRoom,
        [Description("SPR")]
        SemiPrivateRoom,
        [Description("2SPR")]
        SecondSemiPrivateRoom,
        [Description("ICU")]
        IntensiveCareUnit,
        [Description("2ICU")]
        SecondIntensiveCareUnit
    }

    /// <summary>
    /// 0001: Sex
    /// </summary>
    [Description("0001: Sex")]
    public enum Sex
    {
        Female = 'F',
        Male = 'M',
        Other = 'O',
        Unknowm = 'U'
    }

    /// <summary>
    /// 0231: Student status
    /// </summary>
    [Description("0231: Student status")]
    public enum StudentIndicator
    {
        FullTimeStudent = 'F',
        PartTimeStudent = 'P',
        NotAStudent = 'N'
    }

    [Description("0017: Transaction type")]
    public enum TransactionType
    {
        [Description("CG")]
        Charge,
        [Description("CD")]
        Credit,
        [Description("PY")]
        Payment,
        [Description("AJ")]
        Adjustment
    }

    /// <summary>
    /// 0098: Type of agreement
    /// </summary>
    [Description("0098: Type of agreement")]
    public enum TypeOfAgreement
    {
        Standard = 'S',
        Unified = 'U',
        Maternity = 'M'
    }

    [Description("0326: Visit indicator")]
    public enum VisitIndicator
    {
        AccountLevel = 'A',
        VisitLevel = 'V',
    }
}
