using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Case")]
	public class Case : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private decimal _ActualWorkingTime;
		[CProperty(ColumnPath ="ActualWorkingTime")]
		public decimal ActualWorkingTime
		{
			get{return _ActualWorkingTime;}
			set
			{
				_ActualWorkingTime = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineBuildVersionId;
		[CProperty(ColumnPath ="BpmonlineBuildVersionId")]
		public Guid BpmonlineBuildVersionId
		{
			get{return _BpmonlineBuildVersionId;}
			set
			{
				_BpmonlineBuildVersionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChangeId;
		[CProperty(ColumnPath ="ChangeId")]
		public Guid ChangeId
		{
			get{return _ChangeId;}
			set
			{
				_ChangeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClosureCodeId;
		[CProperty(ColumnPath ="ClosureCodeId")]
		public Guid ClosureCodeId
		{
			get{return _ClosureCodeId;}
			set
			{
				_ClosureCodeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ClosureDate;
		[CProperty(ColumnPath ="ClosureDate")]
		public DateTime ClosureDate
		{
			get{return _ClosureDate;}
			set
			{
				_ClosureDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConfItemId;
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId
		{
			get{return _ConfItemId;}
			set
			{
				_ConfItemId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private DateTime _EscalateOn;
		[CProperty(ColumnPath ="EscalateOn")]
		public DateTime EscalateOn
		{
			get{return _EscalateOn;}
			set
			{
				_EscalateOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _FirstSolutionProvidedOn;
		[CProperty(ColumnPath ="FirstSolutionProvidedOn")]
		public DateTime FirstSolutionProvidedOn
		{
			get{return _FirstSolutionProvidedOn;}
			set
			{
				_FirstSolutionProvidedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _GroupId;
		[CProperty(ColumnPath ="GroupId")]
		public Guid GroupId
		{
			get{return _GroupId;}
			set
			{
				_GroupId = value;
				OnPropertyChanged();
			}
		}
		private Guid _HolderId;
		[CProperty(ColumnPath ="HolderId")]
		public Guid HolderId
		{
			get{return _HolderId;}
			set
			{
				_HolderId = value;
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
		private DateTime _IncidentDateTime;
		[CProperty(ColumnPath ="IncidentDateTime")]
		public DateTime IncidentDateTime
		{
			get{return _IncidentDateTime;}
			set
			{
				_IncidentDateTime = value;
				OnPropertyChanged();
			}
		}
		private string _IpAddress;
		[CProperty(ColumnPath ="IpAddress")]
		public string IpAddress
		{
			get{return _IpAddress;}
			set
			{
				_IpAddress = value;
				OnPropertyChanged();
			}
		}
		private bool _IsListSubjectReminds;
		[CProperty(ColumnPath ="IsListSubjectReminds")]
		public bool IsListSubjectReminds
		{
			get{return _IsListSubjectReminds;}
			set
			{
				_IsListSubjectReminds = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSubjectDelete;
		[CProperty(ColumnPath ="IsSubjectDelete")]
		public bool IsSubjectDelete
		{
			get{return _IsSubjectDelete;}
			set
			{
				_IsSubjectDelete = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OriginId;
		[CProperty(ColumnPath ="OriginId")]
		public Guid OriginId
		{
			get{return _OriginId;}
			set
			{
				_OriginId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentActivityId;
		[CProperty(ColumnPath ="ParentActivityId")]
		public Guid ParentActivityId
		{
			get{return _ParentActivityId;}
			set
			{
				_ParentActivityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentCaseId;
		[CProperty(ColumnPath ="ParentCaseId")]
		public Guid ParentCaseId
		{
			get{return _ParentCaseId;}
			set
			{
				_ParentCaseId = value;
				OnPropertyChanged();
			}
		}
		private bool _PDEApprovalIsNotRequired;
		[CProperty(ColumnPath ="PDEApprovalIsNotRequired")]
		public bool PDEApprovalIsNotRequired
		{
			get{return _PDEApprovalIsNotRequired;}
			set
			{
				_PDEApprovalIsNotRequired = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEAuthorDepartmentId;
		[CProperty(ColumnPath ="PDEAuthorDepartmentId")]
		public Guid PDEAuthorDepartmentId
		{
			get{return _PDEAuthorDepartmentId;}
			set
			{
				_PDEAuthorDepartmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEReferenceProviderCustomerId;
		[CProperty(ColumnPath ="PDEReferenceProviderCustomerId")]
		public Guid PDEReferenceProviderCustomerId
		{
			get{return _PDEReferenceProviderCustomerId;}
			set
			{
				_PDEReferenceProviderCustomerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEReferenceProviderId;
		[CProperty(ColumnPath ="PDEReferenceProviderId")]
		public Guid PDEReferenceProviderId
		{
			get{return _PDEReferenceProviderId;}
			set
			{
				_PDEReferenceProviderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEReferenceSatisfactionLevelId;
		[CProperty(ColumnPath ="PDEReferenceSatisfactionLevelId")]
		public Guid PDEReferenceSatisfactionLevelId
		{
			get{return _PDEReferenceSatisfactionLevelId;}
			set
			{
				_PDEReferenceSatisfactionLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PriorityId;
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId
		{
			get{return _PriorityId;}
			set
			{
				_PriorityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProblemId;
		[CProperty(ColumnPath ="ProblemId")]
		public Guid ProblemId
		{
			get{return _ProblemId;}
			set
			{
				_ProblemId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessingTimeUnitId;
		[CProperty(ColumnPath ="ProcessingTimeUnitId")]
		public Guid ProcessingTimeUnitId
		{
			get{return _ProcessingTimeUnitId;}
			set
			{
				_ProcessingTimeUnitId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessingTimeUnitValue;
		[CProperty(ColumnPath ="ProcessingTimeUnitValue")]
		public int ProcessingTimeUnitValue
		{
			get{return _ProcessingTimeUnitValue;}
			set
			{
				_ProcessingTimeUnitValue = value;
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
		private Guid _ProjectId;
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId
		{
			get{return _ProjectId;}
			set
			{
				_ProjectId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RegisteredOn;
		[CProperty(ColumnPath ="RegisteredOn")]
		public DateTime RegisteredOn
		{
			get{return _RegisteredOn;}
			set
			{
				_RegisteredOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReleaseId;
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId
		{
			get{return _ReleaseId;}
			set
			{
				_ReleaseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResolvedById;
		[CProperty(ColumnPath ="ResolvedById")]
		public Guid ResolvedById
		{
			get{return _ResolvedById;}
			set
			{
				_ResolvedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RespondedOn;
		[CProperty(ColumnPath ="RespondedOn")]
		public DateTime RespondedOn
		{
			get{return _RespondedOn;}
			set
			{
				_RespondedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ResponseDate;
		[CProperty(ColumnPath ="ResponseDate")]
		public DateTime ResponseDate
		{
			get{return _ResponseDate;}
			set
			{
				_ResponseDate = value;
				OnPropertyChanged();
			}
		}
		private bool _ResponseOverdue;
		[CProperty(ColumnPath ="ResponseOverdue")]
		public bool ResponseOverdue
		{
			get{return _ResponseOverdue;}
			set
			{
				_ResponseOverdue = value;
				OnPropertyChanged();
			}
		}
		private string _SatisfactionLevelComment;
		[CProperty(ColumnPath ="SatisfactionLevelComment")]
		public string SatisfactionLevelComment
		{
			get{return _SatisfactionLevelComment;}
			set
			{
				_SatisfactionLevelComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _SatisfactionLevelId;
		[CProperty(ColumnPath ="SatisfactionLevelId")]
		public Guid SatisfactionLevelId
		{
			get{return _SatisfactionLevelId;}
			set
			{
				_SatisfactionLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServiceCategoryId;
		[CProperty(ColumnPath ="ServiceCategoryId")]
		public Guid ServiceCategoryId
		{
			get{return _ServiceCategoryId;}
			set
			{
				_ServiceCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServiceItemId;
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId
		{
			get{return _ServiceItemId;}
			set
			{
				_ServiceItemId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServicePactId;
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId
		{
			get{return _ServicePactId;}
			set
			{
				_ServicePactId = value;
				OnPropertyChanged();
			}
		}
		private string _Solution;
		[CProperty(ColumnPath ="Solution")]
		public string Solution
		{
			get{return _Solution;}
			set
			{
				_Solution = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SolutionDate;
		[CProperty(ColumnPath ="SolutionDate")]
		public DateTime SolutionDate
		{
			get{return _SolutionDate;}
			set
			{
				_SolutionDate = value;
				OnPropertyChanged();
			}
		}
		private bool _SolutionOverdue;
		[CProperty(ColumnPath ="SolutionOverdue")]
		public bool SolutionOverdue
		{
			get{return _SolutionOverdue;}
			set
			{
				_SolutionOverdue = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SolutionProvidedOn;
		[CProperty(ColumnPath ="SolutionProvidedOn")]
		public DateTime SolutionProvidedOn
		{
			get{return _SolutionProvidedOn;}
			set
			{
				_SolutionProvidedOn = value;
				OnPropertyChanged();
			}
		}
		private decimal _SolutionRemains;
		[CProperty(ColumnPath ="SolutionRemains")]
		public decimal SolutionRemains
		{
			get{return _SolutionRemains;}
			set
			{
				_SolutionRemains = value;
				OnPropertyChanged();
			}
		}
		private Guid _SolvedOnSupportLevelId;
		[CProperty(ColumnPath ="SolvedOnSupportLevelId")]
		public Guid SolvedOnSupportLevelId
		{
			get{return _SolvedOnSupportLevelId;}
			set
			{
				_SolvedOnSupportLevelId = value;
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
		private string _Subject;
		[CProperty(ColumnPath ="Subject")]
		public string Subject
		{
			get{return _Subject;}
			set
			{
				_Subject = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubtypeId;
		[CProperty(ColumnPath ="SubtypeId")]
		public Guid SubtypeId
		{
			get{return _SubtypeId;}
			set
			{
				_SubtypeId = value;
				OnPropertyChanged();
			}
		}
		private int _SupCaseScore;
		[CProperty(ColumnPath ="SupCaseScore")]
		public int SupCaseScore
		{
			get{return _SupCaseScore;}
			set
			{
				_SupCaseScore = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupCloudTriggerId;
		[CProperty(ColumnPath ="SupCloudTriggerId")]
		public Guid SupCloudTriggerId
		{
			get{return _SupCloudTriggerId;}
			set
			{
				_SupCloudTriggerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupportLevelId;
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId
		{
			get{return _SupportLevelId;}
			set
			{
				_SupportLevelId = value;
				OnPropertyChanged();
			}
		}
		private string _Symptoms;
		[CProperty(ColumnPath ="Symptoms")]
		public string Symptoms
		{
			get{return _Symptoms;}
			set
			{
				_Symptoms = value;
				OnPropertyChanged();
			}
		}
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
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
		private DateTime _UsrNextActualizationDate;
		[CProperty(ColumnPath ="UsrNextActualizationDate")]
		public DateTime UsrNextActualizationDate
		{
			get{return _UsrNextActualizationDate;}
			set
			{
				_UsrNextActualizationDate = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:PDEReferenceProviderId")]
		public Account PDEReferenceProvider { get; set; }
		[CProperty(Navigation ="Activity:ParentActivityId")]
		public Activity ParentActivity { get; set; }
		[CProperty(Navigation ="BpmonlineBuildVersion:BpmonlineBuildVersionId")]
		public BpmonlineBuildVersion BpmonlineBuildVersion { get; set; }
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
		[CProperty(Navigation ="CaseSubtype:SubtypeId")]
		public CaseSubtype Subtype { get; set; }
		[CProperty(Navigation ="CaseType:TypeId")]
		public CaseType Type { get; set; }
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
		[CProperty(Navigation ="Contact:ResolvedById")]
		public Contact ResolvedBy { get; set; }
		[CProperty(Navigation ="GlbCustomer:PDEReferenceProviderCustomerId")]
		public GlbCustomer PDEReferenceProviderCustomer { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:PDEAuthorDepartmentId")]
		public OrgStructureUnit PDEAuthorDepartment { get; set; }
		[CProperty(Navigation ="PDESatisfactionLevelInReference:PDEReferenceSatisfactionLevelId")]
		public PDESatisfactionLevelInReference PDEReferenceSatisfactionLevel { get; set; }
		[CProperty(Navigation ="Problem:ProblemId")]
		public Problem Problem { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="Release:ReleaseId")]
		public Release Release { get; set; }
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
		[CProperty(Navigation ="SupCloudTrigger:SupCloudTriggerId")]
		public SupCloudTrigger SupCloudTrigger { get; set; }
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
		[CProperty(Association ="InternalRequest:CaseId")]
		public virtual ICollection<InternalRequest> InternalRequestByCase { get; set; }
		[CProperty(Association ="KnowledgeBaseInCase:CaseId")]
		public virtual ICollection<KnowledgeBaseInCase> KnowledgeBaseInCaseByCase { get; set; }
		[CProperty(Association ="NPS:CaseId")]
		public virtual ICollection<NPS> NPSByCase { get; set; }
		[CProperty(Association ="PDECaseVisa:PDECaseId")]
		public virtual ICollection<PDECaseVisa> PDECaseVisaByPDECase { get; set; }
		[CProperty(Association ="PDEContactInReferenceCase:PDEReferenceId")]
		public virtual ICollection<PDEContactInReferenceCase> PDEContactInReferenceCaseByPDEReference { get; set; }
		[CProperty(Association ="PDECustomerNeedInReference:PDEReferenceId")]
		public virtual ICollection<PDECustomerNeedInReference> PDECustomerNeedInReferenceByPDEReference { get; set; }
		[CProperty(Association ="PDESuitableReferenceInOpportunity:PDEReferenceId")]
		public virtual ICollection<PDESuitableReferenceInOpportunity> PDESuitableReferenceInOpportunityByPDEReference { get; set; }
		[CProperty(Association ="ProblemInCase:CaseId")]
		public virtual ICollection<ProblemInCase> ProblemInCaseByCase { get; set; }
		[CProperty(Association ="SatisfactionUpdate:CaseId")]
		public virtual ICollection<SatisfactionUpdate> SatisfactionUpdateByCase { get; set; }
		[CProperty(Association ="SupAccessToClient:SupCaseId")]
		public virtual ICollection<SupAccessToClient> SupAccessToClientBySupCase { get; set; }
		[CProperty(Association ="SupplyPaymentElement:CaseId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByCase { get; set; }
		[CProperty(Association ="VwCaseStatusHistory:CaseId")]
		public virtual ICollection<VwCaseStatusHistory> VwCaseStatusHistoryByCase { get; set; }
		[CProperty(Association ="VwDeclarerComments:CaseId")]
		public virtual ICollection<VwDeclarerComments> VwDeclarerCommentsByCase { get; set; }
		[CProperty(Association ="VwMobileCaseMessageHistory:CaseId")]
		public virtual ICollection<VwMobileCaseMessageHistory> VwMobileCaseMessageHistoryByCase { get; set; }
		[CProperty(Association ="VwQueueItem:CaseId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByCase { get; set; }
		[CProperty(Association ="VwQueueItemSuper:CaseId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByCase { get; set; }
		#endregion
	}
}
