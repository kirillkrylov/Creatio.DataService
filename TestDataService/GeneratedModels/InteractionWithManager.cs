using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InteractionWithManager")]
	public class InteractionWithManager : BaseEntity
	{
		#region Values
		private string _CommonComment;
		[CProperty(ColumnPath ="CommonComment")]
		public string CommonComment
		{
			get{return _CommonComment;}
			set
			{
				_CommonComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _Date;
		[CProperty(ColumnPath ="Date")]
		public DateTime Date
		{
			get{return _Date;}
			set
			{
				_Date = value;
				OnPropertyChanged();
			}
		}
		private Guid _DepartmentId;
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId
		{
			get{return _DepartmentId;}
			set
			{
				_DepartmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DevelopmentId;
		[CProperty(ColumnPath ="DevelopmentId")]
		public Guid DevelopmentId
		{
			get{return _DevelopmentId;}
			set
			{
				_DevelopmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DismissalInitiatorId;
		[CProperty(ColumnPath ="DismissalInitiatorId")]
		public Guid DismissalInitiatorId
		{
			get{return _DismissalInitiatorId;}
			set
			{
				_DismissalInitiatorId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DissatisfactionReasonsId;
		[CProperty(ColumnPath ="DissatisfactionReasonsId")]
		public Guid DissatisfactionReasonsId
		{
			get{return _DissatisfactionReasonsId;}
			set
			{
				_DissatisfactionReasonsId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
				OnPropertyChanged();
			}
		}
		private decimal _ExpectedWage;
		[CProperty(ColumnPath ="ExpectedWage")]
		public decimal ExpectedWage
		{
			get{return _ExpectedWage;}
			set
			{
				_ExpectedWage = value;
				OnPropertyChanged();
			}
		}
		private Guid _ExpertiseLevelId;
		[CProperty(ColumnPath ="ExpertiseLevelId")]
		public Guid ExpertiseLevelId
		{
			get{return _ExpertiseLevelId;}
			set
			{
				_ExpertiseLevelId = value;
				OnPropertyChanged();
			}
		}
		private string _FurtherActions;
		[CProperty(ColumnPath ="FurtherActions")]
		public string FurtherActions
		{
			get{return _FurtherActions;}
			set
			{
				_FurtherActions = value;
				OnPropertyChanged();
			}
		}
		private string _HardSkills;
		[CProperty(ColumnPath ="HardSkills")]
		public string HardSkills
		{
			get{return _HardSkills;}
			set
			{
				_HardSkills = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _IncomeId;
		[CProperty(ColumnPath ="IncomeId")]
		public Guid IncomeId
		{
			get{return _IncomeId;}
			set
			{
				_IncomeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InteractionWithTeamId;
		[CProperty(ColumnPath ="InteractionWithTeamId")]
		public Guid InteractionWithTeamId
		{
			get{return _InteractionWithTeamId;}
			set
			{
				_InteractionWithTeamId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsFollowUpInterviewRequired;
		[CProperty(ColumnPath ="IsFollowUpInterviewRequired")]
		public bool IsFollowUpInterviewRequired
		{
			get{return _IsFollowUpInterviewRequired;}
			set
			{
				_IsFollowUpInterviewRequired = value;
				OnPropertyChanged();
			}
		}
		private Guid _JobTitleId;
		[CProperty(ColumnPath ="JobTitleId")]
		public Guid JobTitleId
		{
			get{return _JobTitleId;}
			set
			{
				_JobTitleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ManagerId;
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId
		{
			get{return _ManagerId;}
			set
			{
				_ManagerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _NextMeeting;
		[CProperty(ColumnPath ="NextMeeting")]
		public DateTime NextMeeting
		{
			get{return _NextMeeting;}
			set
			{
				_NextMeeting = value;
				OnPropertyChanged();
			}
		}
		private Guid _OverallContentmentLevelId;
		[CProperty(ColumnPath ="OverallContentmentLevelId")]
		public Guid OverallContentmentLevelId
		{
			get{return _OverallContentmentLevelId;}
			set
			{
				_OverallContentmentLevelId = value;
				OnPropertyChanged();
			}
		}
		private string _PersonalGoals;
		[CProperty(ColumnPath ="PersonalGoals")]
		public string PersonalGoals
		{
			get{return _PersonalGoals;}
			set
			{
				_PersonalGoals = value;
				OnPropertyChanged();
			}
		}
		private string _Plans;
		[CProperty(ColumnPath ="Plans")]
		public string Plans
		{
			get{return _Plans;}
			set
			{
				_Plans = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private string _Reason;
		[CProperty(ColumnPath ="Reason")]
		public string Reason
		{
			get{return _Reason;}
			set
			{
				_Reason = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReasonForDismissalId;
		[CProperty(ColumnPath ="ReasonForDismissalId")]
		public Guid ReasonForDismissalId
		{
			get{return _ReasonForDismissalId;}
			set
			{
				_ReasonForDismissalId = value;
				OnPropertyChanged();
			}
		}
		private string _Result;
		[CProperty(ColumnPath ="Result")]
		public string Result
		{
			get{return _Result;}
			set
			{
				_Result = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReviewTypeId;
		[CProperty(ColumnPath ="ReviewTypeId")]
		public Guid ReviewTypeId
		{
			get{return _ReviewTypeId;}
			set
			{
				_ReviewTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RoleInCompanyId;
		[CProperty(ColumnPath ="RoleInCompanyId")]
		public Guid RoleInCompanyId
		{
			get{return _RoleInCompanyId;}
			set
			{
				_RoleInCompanyId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SatisfactionOfInteractionWithManagerId;
		[CProperty(ColumnPath ="SatisfactionOfInteractionWithManagerId")]
		public Guid SatisfactionOfInteractionWithManagerId
		{
			get{return _SatisfactionOfInteractionWithManagerId;}
			set
			{
				_SatisfactionOfInteractionWithManagerId = value;
				OnPropertyChanged();
			}
		}
		private string _SoftSkills;
		[CProperty(ColumnPath ="SoftSkills")]
		public string SoftSkills
		{
			get{return _SoftSkills;}
			set
			{
				_SoftSkills = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private string _Suggestion;
		[CProperty(ColumnPath ="Suggestion")]
		public string Suggestion
		{
			get{return _Suggestion;}
			set
			{
				_Suggestion = value;
				OnPropertyChanged();
			}
		}
		private Guid _TasksAndTargetsId;
		[CProperty(ColumnPath ="TasksAndTargetsId")]
		public Guid TasksAndTargetsId
		{
			get{return _TasksAndTargetsId;}
			set
			{
				_TasksAndTargetsId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TasksId;
		[CProperty(ColumnPath ="TasksId")]
		public Guid TasksId
		{
			get{return _TasksId;}
			set
			{
				_TasksId = value;
				OnPropertyChanged();
			}
		}
		private string _Title;
		[CProperty(ColumnPath ="Title")]
		public string Title
		{
			get{return _Title;}
			set
			{
				_Title = value;
				OnPropertyChanged();
			}
		}
		private Guid _TrainingQualityId;
		[CProperty(ColumnPath ="TrainingQualityId")]
		public Guid TrainingQualityId
		{
			get{return _TrainingQualityId;}
			set
			{
				_TrainingQualityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Wishes;
		[CProperty(ColumnPath ="Wishes")]
		public string Wishes
		{
			get{return _Wishes;}
			set
			{
				_Wishes = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ManagerId")]
		public Contact Manager { get; set; }
		[CProperty(Navigation ="ContentmentLevel:TasksId")]
		public ContentmentLevel Tasks { get; set; }
		[CProperty(Navigation ="ContentmentLevel:DevelopmentId")]
		public ContentmentLevel Development { get; set; }
		[CProperty(Navigation ="ContentmentLevel:SatisfactionOfInteractionWithManagerId")]
		public ContentmentLevel SatisfactionOfInteractionWithManager { get; set; }
		[CProperty(Navigation ="ContentmentLevel:InteractionWithTeamId")]
		public ContentmentLevel InteractionWithTeam { get; set; }
		[CProperty(Navigation ="ContentmentLevel:IncomeId")]
		public ContentmentLevel Income { get; set; }
		[CProperty(Navigation ="ContentmentLevel:TrainingQualityId")]
		public ContentmentLevel TrainingQuality { get; set; }
		[CProperty(Navigation ="DismissalInitiator:DismissalInitiatorId")]
		public DismissalInitiator DismissalInitiator { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="EmployeeJob:RoleInCompanyId")]
		public EmployeeJob RoleInCompany { get; set; }
		[CProperty(Navigation ="ExpertiseLevel:ExpertiseLevelId")]
		public ExpertiseLevel ExpertiseLevel { get; set; }
		[CProperty(Navigation ="Level:OverallContentmentLevelId")]
		public Level OverallContentmentLevel { get; set; }
		[CProperty(Navigation ="OneOnOneStatus:StatusId")]
		public OneOnOneStatus Status { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:DepartmentId")]
		public OrgStructureUnit Department { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:JobTitleId")]
		public OrgStructureUnit JobTitle { get; set; }
		[CProperty(Navigation ="PerformanceReviewType:ReviewTypeId")]
		public PerformanceReviewType ReviewType { get; set; }
		[CProperty(Navigation ="ReasonForLeaving:DissatisfactionReasonsId")]
		public ReasonForLeaving DissatisfactionReasons { get; set; }
		[CProperty(Navigation ="ReasonForLeaving:ReasonForDismissalId")]
		public ReasonForLeaving ReasonForDismissal { get; set; }
		[CProperty(Navigation ="TalkType:TypeId")]
		public TalkType Type { get; set; }
		[CProperty(Navigation ="UnderstandingLevel:TasksAndTargetsId")]
		public UnderstandingLevel TasksAndTargets { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EmployeeCompetence:InteractionWithManagerId")]
		public virtual ICollection<EmployeeCompetence> EmployeeCompetenceByInteractionWithManager { get; set; }
		[CProperty(Association ="EmployeeProjectReview:InteractionWithManagerId")]
		public virtual ICollection<EmployeeProjectReview> EmployeeProjectReviewByInteractionWithManager { get; set; }
		[CProperty(Association ="InteractionFile:InteractionId")]
		public virtual ICollection<InteractionFile> InteractionFileByInteraction { get; set; }
		[CProperty(Association ="PDP:InteractionWithManagerId")]
		public virtual ICollection<PDP> PDPByInteractionWithManager { get; set; }
		#endregion
	}
}
