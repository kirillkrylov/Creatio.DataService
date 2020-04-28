using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InteractionWithManager")]
	public class InteractionWithManager : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CommonComment")]
		public string CommonComment { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="DevelopmentId")]
		public Guid DevelopmentId { get; set; }
		[CProperty(ColumnPath ="DismissalInitiatorId")]
		public Guid DismissalInitiatorId { get; set; }
		[CProperty(ColumnPath ="DissatisfactionReasonsId")]
		public Guid DissatisfactionReasonsId { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="ExpectedWage")]
		public decimal ExpectedWage { get; set; }
		[CProperty(ColumnPath ="ExpertiseLevelId")]
		public Guid ExpertiseLevelId { get; set; }
		[CProperty(ColumnPath ="FurtherActions")]
		public string FurtherActions { get; set; }
		[CProperty(ColumnPath ="HardSkills")]
		public string HardSkills { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IncomeId")]
		public Guid IncomeId { get; set; }
		[CProperty(ColumnPath ="InteractionWithTeamId")]
		public Guid InteractionWithTeamId { get; set; }
		[CProperty(ColumnPath ="IsFollowUpInterviewRequired")]
		public bool IsFollowUpInterviewRequired { get; set; }
		[CProperty(ColumnPath ="JobTitleId")]
		public Guid JobTitleId { get; set; }
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NextMeeting")]
		public DateTime NextMeeting { get; set; }
		[CProperty(ColumnPath ="OverallContentmentLevelId")]
		public Guid OverallContentmentLevelId { get; set; }
		[CProperty(ColumnPath ="PersonalGoals")]
		public string PersonalGoals { get; set; }
		[CProperty(ColumnPath ="Plans")]
		public string Plans { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Reason")]
		public string Reason { get; set; }
		[CProperty(ColumnPath ="ReasonForDismissalId")]
		public Guid ReasonForDismissalId { get; set; }
		[CProperty(ColumnPath ="Result")]
		public string Result { get; set; }
		[CProperty(ColumnPath ="ReviewTypeId")]
		public Guid ReviewTypeId { get; set; }
		[CProperty(ColumnPath ="RoleInCompanyId")]
		public Guid RoleInCompanyId { get; set; }
		[CProperty(ColumnPath ="SatisfactionOfInteractionWithManagerId")]
		public Guid SatisfactionOfInteractionWithManagerId { get; set; }
		[CProperty(ColumnPath ="SoftSkills")]
		public string SoftSkills { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Suggestion")]
		public string Suggestion { get; set; }
		[CProperty(ColumnPath ="TasksAndTargetsId")]
		public Guid TasksAndTargetsId { get; set; }
		[CProperty(ColumnPath ="TasksId")]
		public Guid TasksId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		[CProperty(ColumnPath ="TrainingQualityId")]
		public Guid TrainingQualityId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Wishes")]
		public string Wishes { get; set; }
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
