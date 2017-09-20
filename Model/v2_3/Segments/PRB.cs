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
    /// PRB: Problem Detail
    /// </summary>
    public class PRB : ChoHL7Segment
    {
        [Description("Action Code")]
        [Required]
        [MaxLength(2)]
        public ID ActionCode
        {
            get { return GetValueAt<ID>(0); }
        }
        [Description("Action Date/Time")]
        [Required]
        [MaxLength(26)]
        public TS ActionDateTime
        {
            get { return GetValueAt<TS>(1); }
        }
        [Description("Problem ID")]
        [Required]
        [MaxLength(80)]
        public CE ProblemID
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Problem Instance ID")]
        [Required]
        [MaxLength(60)]
        public EI ProblemInstanceID
        {
            get { return GetValueAt<EI>(3); }
        }
        [Description("Episode of Care ID")]
        [MaxLength(60)]
        public EI EpisodeofCareID
        {
            get { return GetValueAt<EI>(4); }
        }
        [Description("Problem List Priority")]
        [MaxLength(60)]
        public NM ProblemListPriority
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Problem Established Date/Time")]
        [MaxLength(26)]
        public TS ProblemEstablishedDateTime
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("AnticipatedProblemResolutionDateTime")]
        [MaxLength(26)]
        public TS EventQualification
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Actual Problem Resolution Date/Time")]
        [MaxLength(26)]
        public TS ActualProblemResolutionDateTime
        {
            get { return GetValueAt<TS>(8); }
        }
        [Description("Problem Classification")]
        [MaxLength(80)]
        public CE ProblemClassification
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Problem Management Discipline")]
        [MaxLength(80)]
        public CE[] ProblemManagementDiscipline
        {
            get { return GetValuesAt<CE>(10); }
        }
        [Description("Problem Persistence")]
        [MaxLength(80)]
        public CE ProblemPersistence
        {
            get { return GetValueAt<CE>(11); }
        }
        [Description("Problem Confirmation Status")]
        [MaxLength(80)]
        public CE ProblemConfirmationStatus
        {
            get { return GetValueAt<CE>(12); }
        }
        [Description("Problem Life Cycle Status")]
        [MaxLength(80)]
        public CE ProblemLifeCycleStatus
        {
            get { return GetValueAt<CE>(13); }
        }
        [Description("Problem Life Cycle Status Date/Time")]
        [MaxLength(26)]
        public TS ProblemLifeCycleStatusDateTime
        {
            get { return GetValueAt<TS>(14); }
        }
        [Description("Problem Date of Onset")]
        [MaxLength(26)]
        public TS ProblemDateofOnset
        {
            get { return GetValueAt<TS>(15); }
        }
        [Description("Problem Onset Text")]
        [MaxLength(80)]
        public ST ProblemOnsetText
        {
            get { return GetValueAt<ST>(16); }
        }
        [Description("Problem Ranking")]
        [MaxLength(80)]
        public CE ProblemRanking
        {
            get { return GetValueAt<CE>(17); }
        }
        [Description("Certainty of Problem")]
        [MaxLength(60)]
        public CE CertaintyofProblem
        {
            get { return GetValueAt<CE>(18); }
        }
        [Description("Probability of Problem")]
        [MaxLength(5)]
        public NM ProbabilityofProblem
        {
            get { return GetValueAt<NM>(19); }
        }
        [Description("Individual Awareness of Problem")]
        [MaxLength(80)]
        public CE IndividualAwarenessofProblem
        {
            get { return GetValueAt<CE>(20); }
        }
        [Description("Problem Prognosis")]
        [MaxLength(80)]
        public CE ProblemPrognosis
        {
            get { return GetValueAt<CE>(21); }
        }
        [Description("Individual Awareness of Prognosis")]
        [MaxLength(80)]
        public CE IndividualAwarenessofPrognosis
        {
            get { return GetValueAt<CE>(22); }
        }
        [Description("Family/Significant Other Awareness of Problem/Prognosis")]
        [MaxLength(200)]
        public ST FamilySignificantOtherAwarenessofProblemPrognosis
        {
            get { return GetValueAt<ST>(23); }
        }
        [Description("Security/Sensitivity")]
        [MaxLength(80)]
        public CE SecuritySensitivity
        {
            get { return GetValueAt<CE>(24); }
        }
    }
}
