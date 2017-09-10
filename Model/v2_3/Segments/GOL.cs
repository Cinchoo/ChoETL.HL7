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
    /// GOL: Goal Detail
    /// </summary>
    public class GOL : ChoHL7Segment
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
        [Description("Goal ID")]
        [Required]
        [MaxLength(80)]
        public CE ID
        {
            get { return GetValueAt<CE>(2); }
        }
        [Description("Goal Instance ID")]
        [Required]
        [MaxLength(60)]
        public EI InstanceID
        {
            get { return GetValueAt<EI>(3); }
        }
        [Description("Episode of Care ID")]
        [MaxLength(60)]
        public EI EpisodeofCareID
        {
            get { return GetValueAt<EI>(4); }
        }
        [Description("Goal List Priority")]
        [MaxLength(60)]
        public NM GoalListPriority
        {
            get { return GetValueAt<NM>(5); }
        }
        [Description("Goal Established Date/Time")]
        [MaxLength(26)]
        public TS GoalEstablishedDateTime
        {
            get { return GetValueAt<TS>(6); }
        }
        [Description("Expected Goal Achievement Date/Time")]
        [MaxLength(26)]
        public TS ExpectedGoalAchievementDateTime
        {
            get { return GetValueAt<TS>(7); }
        }
        [Description("Goal Classification")]
        [MaxLength(80)]
        public CE GoalClassification
        {
            get { return GetValueAt<CE>(8); }
        }
        [Description("Goal Management Discipline")]
        [MaxLength(80)]
        public CE GoalManagementDiscipline
        {
            get { return GetValueAt<CE>(9); }
        }
        [Description("Current Goal Review Status")]
        [MaxLength(80)]
        public CE CurrentGoalReviewStatus
        {
            get { return GetValueAt<CE>(10); }
        }
        [Description("Current Goal Review Date/Time")]
        [MaxLength(26)]
        public TS CurrentGoalReviewDateTime
        {
            get { return GetValueAt<TS>(11); }
        }
        [Description("Next Goal Review Date/Time")]
        [MaxLength(26)]
        public TS NextGoalReviewDateTime
        {
            get { return GetValueAt<TS>(12); }
        }
        [Description("Previous Goal Review Date/Time")]
        [MaxLength(26)]
        public TS PreviousGoalReviewDateTime
        {
            get { return GetValueAt<TS>(13); }
        }
        [Description("Goal Review Interval")]
        [MaxLength(200)]
        public TQ GoalReviewInterval
        {
            get { return GetValueAt<TQ>(14); }
        }
        [Description("Goal Evaluation")]
        [MaxLength(80)]
        public CE GoalEvaluation
        {
            get { return GetValueAt<CE>(15); }
        }
        [Description("Goal Evaluation Comment")]
        [MaxLength(300)]
        public ST[] GoalEvaluationComment
        {
            get { return GetValuesAt<ST>(16); }
        }
        [Description("Goal Life Cycle Status")]
        [MaxLength(80)]
        public CE GoalLifeCycleStatus
        {
            get { return GetValueAt<CE>(17); }
        }
        [Description("Goal Life Cycle Status Date/Time")]
        [MaxLength(26)]
        public TS GoalLifeCycleStatusDateTime
        {
            get { return GetValueAt<TS>(18); }
        }
        [Description("Goal Target Type")]
        [MaxLength(80)]
        public CE[] GoalTargetType
        {
            get { return GetValuesAt<CE>(19); }
        }
        [Description("Goal Target Name")]
        [MaxLength(120)]
        public XPN[] GoalTargetName
        {
            get { return GetValuesAt<XPN>(20); }
        }
    }
}
