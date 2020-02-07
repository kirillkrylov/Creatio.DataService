using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Case")]
	public class Case : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="ChangeId")]
		public Guid ChangeId { get; set; }
		[CProperty(ColumnPath ="ClosureCodeId")]
		public Guid ClosureCodeId { get; set; }
		[CProperty(ColumnPath ="ClosureDate")]
		public DateTime ClosureDate { get; set; }
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FirstSolutionProvidedOn")]
		public DateTime FirstSolutionProvidedOn { get; set; }
		[CProperty(ColumnPath ="GroupId")]
		public Guid GroupId { get; set; }
		[CProperty(ColumnPath ="HolderId")]
		public Guid HolderId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OriginId")]
		public Guid OriginId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentActivityId")]
		public Guid ParentActivityId { get; set; }
		[CProperty(ColumnPath ="ParentCaseId")]
		public Guid ParentCaseId { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProblemId")]
		public Guid ProblemId { get; set; }
		[CProperty(ColumnPath ="ProcessingTimeUnitId")]
		public Guid ProcessingTimeUnitId { get; set; }
		[CProperty(ColumnPath ="ProcessingTimeUnitValue")]
		public int ProcessingTimeUnitValue { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegisteredOn")]
		public DateTime RegisteredOn { get; set; }
		[CProperty(ColumnPath ="RespondedOn")]
		public DateTime RespondedOn { get; set; }
		[CProperty(ColumnPath ="ResponseDate")]
		public DateTime ResponseDate { get; set; }
		[CProperty(ColumnPath ="ResponseOverdue")]
		public bool ResponseOverdue { get; set; }
		[CProperty(ColumnPath ="SatisfactionLevelComment")]
		public string SatisfactionLevelComment { get; set; }
		[CProperty(ColumnPath ="SatisfactionLevelId")]
		public Guid SatisfactionLevelId { get; set; }
		[CProperty(ColumnPath ="ServiceCategoryId")]
		public Guid ServiceCategoryId { get; set; }
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId { get; set; }
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId { get; set; }
		[CProperty(ColumnPath ="Solution")]
		public string Solution { get; set; }
		[CProperty(ColumnPath ="SolutionDate")]
		public DateTime SolutionDate { get; set; }
		[CProperty(ColumnPath ="SolutionOverdue")]
		public bool SolutionOverdue { get; set; }
		[CProperty(ColumnPath ="SolutionProvidedOn")]
		public DateTime SolutionProvidedOn { get; set; }
		[CProperty(ColumnPath ="SolutionRemains")]
		public decimal SolutionRemains { get; set; }
		[CProperty(ColumnPath ="SolvedOnSupportLevelId")]
		public Guid SolvedOnSupportLevelId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Subject")]
		public string Subject { get; set; }
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId { get; set; }
		[CProperty(ColumnPath ="Symptoms")]
		public string Symptoms { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Activity:ParentActivityId")]
		public Activity ParentActivity { get; set; }
		[CProperty(Navigation ="Case:ParentCaseId")]
		public Case ParentCase { get; set; }
		[CProperty(Navigation ="CaseCategory:CategoryId")]
		public CaseCategory Category { get; set; }
		[CProperty(Navigation ="CaseOrigin:OriginId")]
		public CaseOrigin Origin { get; set; }
		[CProperty(Navigation ="CasePriority:PriorityId")]
		public CasePriority Priority { get; set; }
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation ="Change:ChangeId")]
		public Change Change { get; set; }
		[CProperty(Navigation ="ClosureCode:ClosureCodeId")]
		public ClosureCode ClosureCode { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:HolderId")]
		public Contact Holder { get; set; }
		[CProperty(Navigation ="Problem:ProblemId")]
		public Problem Problem { get; set; }
		[CProperty(Navigation ="RoleInServiceTeam:SolvedOnSupportLevelId")]
		public RoleInServiceTeam SolvedOnSupportLevel { get; set; }
		[CProperty(Navigation ="RoleInServiceTeam:SupportLevelId")]
		public RoleInServiceTeam SupportLevel { get; set; }
		[CProperty(Navigation ="SatisfactionLevel:SatisfactionLevelId")]
		public SatisfactionLevel SatisfactionLevel { get; set; }
		[CProperty(Navigation ="ServiceCategory:ServiceCategoryId")]
		public ServiceCategory ServiceCategory { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		[CProperty(Navigation ="ServicePact:ServicePactId")]
		public ServicePact ServicePact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:GroupId")]
		public SysAdminUnit Group { get; set; }
		[CProperty(Navigation ="TimeUnit:ProcessingTimeUnitId")]
		public TimeUnit ProcessingTimeUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:CaseId")]
		public virtual ICollection<Activity> ActivityByCase { get; set; }
		[CProperty(Association ="Call:CaseId")]
		public virtual ICollection<Call> CallByCase { get; set; }
		[CProperty(Association ="Case:ParentCaseId")]
		public virtual ICollection<Case> CaseByParentCase { get; set; }
		[CProperty(Association ="CaseFile:CaseId")]
		public virtual ICollection<CaseFile> CaseFileByCase { get; set; }
		[CProperty(Association ="CaseInFolder:CaseId")]
		public virtual ICollection<CaseInFolder> CaseInFolderByCase { get; set; }
		[CProperty(Association ="CaseInTag:EntityId")]
		public virtual ICollection<CaseInTag> CaseInTagByEntity { get; set; }
		[CProperty(Association ="CaseLifecycle:CaseId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByCase { get; set; }
		[CProperty(Association ="CaseMessageHistory:CaseId")]
		public virtual ICollection<CaseMessageHistory> CaseMessageHistoryByCase { get; set; }
		[CProperty(Association ="ConfItemInCase:CaseId")]
		public virtual ICollection<ConfItemInCase> ConfItemInCaseByCase { get; set; }
		[CProperty(Association ="DelayedNotification:CaseId")]
		public virtual ICollection<DelayedNotification> DelayedNotificationByCase { get; set; }
		[CProperty(Association ="KnowledgeBaseInCase:CaseId")]
		public virtual ICollection<KnowledgeBaseInCase> KnowledgeBaseInCaseByCase { get; set; }
		[CProperty(Association ="ProblemInCase:CaseId")]
		public virtual ICollection<ProblemInCase> ProblemInCaseByCase { get; set; }
		[CProperty(Association ="SatisfactionUpdate:CaseId")]
		public virtual ICollection<SatisfactionUpdate> SatisfactionUpdateByCase { get; set; }
		[CProperty(Association ="VwDeclarerComments:CaseId")]
		public virtual ICollection<VwDeclarerComments> VwDeclarerCommentsByCase { get; set; }
		[CProperty(Association ="VwMobileCaseMessageHistory:CaseId")]
		public virtual ICollection<VwMobileCaseMessageHistory> VwMobileCaseMessageHistoryByCase { get; set; }
		[CProperty(Association ="VwQueueItem:CaseId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByCase { get; set; }
		#endregion
	}
}
