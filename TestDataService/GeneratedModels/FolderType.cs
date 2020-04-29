using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "FolderType")]
	public class FolderType : BaseEntity
	{
		#region Values
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private Guid _ImageId;
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId
		{
			get{return _ImageId;}
			set
			{
				_ImageId = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private int _Order;
		[CProperty(ColumnPath ="Order")]
		public int Order
		{
			get{return _Order;}
			set
			{
				_Order = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountFolder:FolderTypeId")]
		public virtual ICollection<AccountFolder> AccountFolderByFolderType { get; set; }
		[CProperty(Association ="ActivityFolder:FolderTypeId")]
		public virtual ICollection<ActivityFolder> ActivityFolderByFolderType { get; set; }
		[CProperty(Association ="ApplicantFolder:FolderTypeId")]
		public virtual ICollection<ApplicantFolder> ApplicantFolderByFolderType { get; set; }
		[CProperty(Association ="BeesenderChatFolder:FolderTypeId")]
		public virtual ICollection<BeesenderChatFolder> BeesenderChatFolderByFolderType { get; set; }
		[CProperty(Association ="BonusFolder:FolderTypeId")]
		public virtual ICollection<BonusFolder> BonusFolderByFolderType { get; set; }
		[CProperty(Association ="BpmGDPRFolder:FolderTypeId")]
		public virtual ICollection<BpmGDPRFolder> BpmGDPRFolderByFolderType { get; set; }
		[CProperty(Association ="BpmonlineBuildFolder:FolderTypeId")]
		public virtual ICollection<BpmonlineBuildFolder> BpmonlineBuildFolderByFolderType { get; set; }
		[CProperty(Association ="BsoChatsFolder:FolderTypeId")]
		public virtual ICollection<BsoChatsFolder> BsoChatsFolderByFolderType { get; set; }
		[CProperty(Association ="BudgetFolder:FolderTypeId")]
		public virtual ICollection<BudgetFolder> BudgetFolderByFolderType { get; set; }
		[CProperty(Association ="BulkEmailFolder:FolderTypeId")]
		public virtual ICollection<BulkEmailFolder> BulkEmailFolderByFolderType { get; set; }
		[CProperty(Association ="BulkEmailSplitFolder:FolderTypeId")]
		public virtual ICollection<BulkEmailSplitFolder> BulkEmailSplitFolderByFolderType { get; set; }
		[CProperty(Association ="CallFolder:FolderTypeId")]
		public virtual ICollection<CallFolder> CallFolderByFolderType { get; set; }
		[CProperty(Association ="CampaignFolder:FolderTypeId")]
		public virtual ICollection<CampaignFolder> CampaignFolderByFolderType { get; set; }
		[CProperty(Association ="CampaignPlannerFolder:FolderTypeId")]
		public virtual ICollection<CampaignPlannerFolder> CampaignPlannerFolderByFolderType { get; set; }
		[CProperty(Association ="CaseFolder:FolderTypeId")]
		public virtual ICollection<CaseFolder> CaseFolderByFolderType { get; set; }
		[CProperty(Association ="CaseTypeFolder:FolderTypeId")]
		public virtual ICollection<CaseTypeFolder> CaseTypeFolderByFolderType { get; set; }
		[CProperty(Association ="ChangeFolder:FolderTypeId")]
		public virtual ICollection<ChangeFolder> ChangeFolderByFolderType { get; set; }
		[CProperty(Association ="CIFolder:FolderTypeId")]
		public virtual ICollection<CIFolder> CIFolderByFolderType { get; set; }
		[CProperty(Association ="CompetenceFolder:FolderTypeId")]
		public virtual ICollection<CompetenceFolder> CompetenceFolderByFolderType { get; set; }
		[CProperty(Association ="ConfItemFolder:FolderTypeId")]
		public virtual ICollection<ConfItemFolder> ConfItemFolderByFolderType { get; set; }
		[CProperty(Association ="ContactFolder:FolderTypeId")]
		public virtual ICollection<ContactFolder> ContactFolderByFolderType { get; set; }
		[CProperty(Association ="ContractFolder:FolderTypeId")]
		public virtual ICollection<ContractFolder> ContractFolderByFolderType { get; set; }
		[CProperty(Association ="DocumentFolder:FolderTypeId")]
		public virtual ICollection<DocumentFolder> DocumentFolderByFolderType { get; set; }
		[CProperty(Association ="DuplicatesRuleFolder:FolderTypeId")]
		public virtual ICollection<DuplicatesRuleFolder> DuplicatesRuleFolderByFolderType { get; set; }
		[CProperty(Association ="EmployeeFolder:FolderTypeId")]
		public virtual ICollection<EmployeeFolder> EmployeeFolderByFolderType { get; set; }
		[CProperty(Association ="EmployeeScoreFolder:FolderTypeId")]
		public virtual ICollection<EmployeeScoreFolder> EmployeeScoreFolderByFolderType { get; set; }
		[CProperty(Association ="EventFolder:FolderTypeId")]
		public virtual ICollection<EventFolder> EventFolderByFolderType { get; set; }
		[CProperty(Association ="ExesInRequestFolder:FolderTypeId")]
		public virtual ICollection<ExesInRequestFolder> ExesInRequestFolderByFolderType { get; set; }
		[CProperty(Association ="ExternalAccessFolder:FolderTypeId")]
		public virtual ICollection<ExternalAccessFolder> ExternalAccessFolderByFolderType { get; set; }
		[CProperty(Association ="FileFolder:FolderTypeId")]
		public virtual ICollection<FileFolder> FileFolderByFolderType { get; set; }
		[CProperty(Association ="GeneratedWebFormFolder:FolderTypeId")]
		public virtual ICollection<GeneratedWebFormFolder> GeneratedWebFormFolderByFolderType { get; set; }
		[CProperty(Association ="GiftFolder:FolderTypeId")]
		public virtual ICollection<GiftFolder> GiftFolderByFolderType { get; set; }
		[CProperty(Association ="GlbCustomerFolder:FolderTypeId")]
		public virtual ICollection<GlbCustomerFolder> GlbCustomerFolderByFolderType { get; set; }
		[CProperty(Association ="GlbCustomerGiftFolder:FolderTypeId")]
		public virtual ICollection<GlbCustomerGiftFolder> GlbCustomerGiftFolderByFolderType { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerListFolder:FolderTypeId")]
		public virtual ICollection<GlbCustomerKeyPlayerListFolder> GlbCustomerKeyPlayerListFolderByFolderType { get; set; }
		[CProperty(Association ="GlbReferenceableFolder:FolderTypeId")]
		public virtual ICollection<GlbReferenceableFolder> GlbReferenceableFolderByFolderType { get; set; }
		[CProperty(Association ="INFLUwebFolder:FolderTypeId")]
		public virtual ICollection<INFLUwebFolder> INFLUwebFolderByFolderType { get; set; }
		[CProperty(Association ="InternalRequestFolder:FolderTypeId")]
		public virtual ICollection<InternalRequestFolder> InternalRequestFolderByFolderType { get; set; }
		[CProperty(Association ="InvestorFolder:FolderTypeId")]
		public virtual ICollection<InvestorFolder> InvestorFolderByFolderType { get; set; }
		[CProperty(Association ="InvoiceFolder:FolderTypeId")]
		public virtual ICollection<InvoiceFolder> InvoiceFolderByFolderType { get; set; }
		[CProperty(Association ="IQSetRightsFolder:FolderTypeId")]
		public virtual ICollection<IQSetRightsFolder> IQSetRightsFolderByFolderType { get; set; }
		[CProperty(Association ="KnowledgeBaseFolder:FolderTypeId")]
		public virtual ICollection<KnowledgeBaseFolder> KnowledgeBaseFolderByFolderType { get; set; }
		[CProperty(Association ="LeadFolder:FolderTypeId")]
		public virtual ICollection<LeadFolder> LeadFolderByFolderType { get; set; }
		[CProperty(Association ="LookupFolder:FolderTypeId")]
		public virtual ICollection<LookupFolder> LookupFolderByFolderType { get; set; }
		[CProperty(Association ="MarketplaceApplicationFolder:FolderTypeId")]
		public virtual ICollection<MarketplaceApplicationFolder> MarketplaceApplicationFolderByFolderType { get; set; }
		[CProperty(Association ="MktgActivityFolder:FolderTypeId")]
		public virtual ICollection<MktgActivityFolder> MktgActivityFolderByFolderType { get; set; }
		[CProperty(Association ="MLModelFolder:FolderTypeId")]
		public virtual ICollection<MLModelFolder> MLModelFolderByFolderType { get; set; }
		[CProperty(Association ="OAuth20AppFolder:FolderTypeId")]
		public virtual ICollection<OAuth20AppFolder> OAuth20AppFolderByFolderType { get; set; }
		[CProperty(Association ="OpportunityFolder:FolderTypeId")]
		public virtual ICollection<OpportunityFolder> OpportunityFolderByFolderType { get; set; }
		[CProperty(Association ="OpportunityForecastFolder:FolderTypeId")]
		public virtual ICollection<OpportunityForecastFolder> OpportunityForecastFolderByFolderType { get; set; }
		[CProperty(Association ="OrderFolder:FolderTypeId")]
		public virtual ICollection<OrderFolder> OrderFolderByFolderType { get; set; }
		[CProperty(Association ="OrgStructureUnitFolder:FolderTypeId")]
		public virtual ICollection<OrgStructureUnitFolder> OrgStructureUnitFolderByFolderType { get; set; }
		[CProperty(Association ="PartnershipFolder:FolderTypeId")]
		public virtual ICollection<PartnershipFolder> PartnershipFolderByFolderType { get; set; }
		[CProperty(Association ="PaymentRuleFolder:FolderTypeId")]
		public virtual ICollection<PaymentRuleFolder> PaymentRuleFolderByFolderType { get; set; }
		[CProperty(Association ="PaymentsFolder:FolderTypeId")]
		public virtual ICollection<PaymentsFolder> PaymentsFolderByFolderType { get; set; }
		[CProperty(Association ="ProblemFolder:FolderTypeId")]
		public virtual ICollection<ProblemFolder> ProblemFolderByFolderType { get; set; }
		[CProperty(Association ="ProductFolder:FolderTypeId")]
		public virtual ICollection<ProductFolder> ProductFolderByFolderType { get; set; }
		[CProperty(Association ="ProjectFolder:FolderTypeId")]
		public virtual ICollection<ProjectFolder> ProjectFolderByFolderType { get; set; }
		[CProperty(Association ="ProjectSolutionFolder:FolderTypeId")]
		public virtual ICollection<ProjectSolutionFolder> ProjectSolutionFolderByFolderType { get; set; }
		[CProperty(Association ="QueueFolder:FolderTypeId")]
		public virtual ICollection<QueueFolder> QueueFolderByFolderType { get; set; }
		[CProperty(Association ="QueueItemFolder:FolderTypeId")]
		public virtual ICollection<QueueItemFolder> QueueItemFolderByFolderType { get; set; }
		[CProperty(Association ="ReleaseFolder:FolderTypeId")]
		public virtual ICollection<ReleaseFolder> ReleaseFolderByFolderType { get; set; }
		[CProperty(Association ="ReportFolder:FolderTypeId")]
		public virtual ICollection<ReportFolder> ReportFolderByFolderType { get; set; }
		[CProperty(Association ="ScreenResultFolder:FolderTypeId")]
		public virtual ICollection<ScreenResultFolder> ScreenResultFolderByFolderType { get; set; }
		[CProperty(Association ="ServiceItemFolder:FolderTypeId")]
		public virtual ICollection<ServiceItemFolder> ServiceItemFolderByFolderType { get; set; }
		[CProperty(Association ="ServicePactFolder:FolderTypeId")]
		public virtual ICollection<ServicePactFolder> ServicePactFolderByFolderType { get; set; }
		[CProperty(Association ="SiteDomainFolder:FolderTypeId")]
		public virtual ICollection<SiteDomainFolder> SiteDomainFolderByFolderType { get; set; }
		[CProperty(Association ="SiteEventTypeFolder:FolderTypeId")]
		public virtual ICollection<SiteEventTypeFolder> SiteEventTypeFolderByFolderType { get; set; }
		[CProperty(Association ="SocialChannelFolder:FolderTypeId")]
		public virtual ICollection<SocialChannelFolder> SocialChannelFolderByFolderType { get; set; }
		[CProperty(Association ="SubscriptionFolder:FolderTypeId")]
		public virtual ICollection<SubscriptionFolder> SubscriptionFolderByFolderType { get; set; }
		[CProperty(Association ="SupportUnitFolder:FolderTypeId")]
		public virtual ICollection<SupportUnitFolder> SupportUnitFolderByFolderType { get; set; }
		[CProperty(Association ="SysAdminOperationFolder:FolderTypeId")]
		public virtual ICollection<SysAdminOperationFolder> SysAdminOperationFolderByFolderType { get; set; }
		[CProperty(Association ="SysAdminUnitFolder:FolderTypeId")]
		public virtual ICollection<SysAdminUnitFolder> SysAdminUnitFolderByFolderType { get; set; }
		[CProperty(Association ="SysLookupFolder:FolderTypeId")]
		public virtual ICollection<SysLookupFolder> SysLookupFolderByFolderType { get; set; }
		[CProperty(Association ="SysProcessLogFolder:FolderTypeId")]
		public virtual ICollection<SysProcessLogFolder> SysProcessLogFolderByFolderType { get; set; }
		[CProperty(Association ="SysProcessUserTaskFolder:FolderTypeId")]
		public virtual ICollection<SysProcessUserTaskFolder> SysProcessUserTaskFolderByFolderType { get; set; }
		[CProperty(Association ="SysSettingsFolder:FolderTypeId")]
		public virtual ICollection<SysSettingsFolder> SysSettingsFolderByFolderType { get; set; }
		[CProperty(Association ="SysTranslationFolder:FolderTypeId")]
		public virtual ICollection<SysTranslationFolder> SysTranslationFolderByFolderType { get; set; }
		[CProperty(Association ="TeamOnDutyFolder:FolderTypeId")]
		public virtual ICollection<TeamOnDutyFolder> TeamOnDutyFolderByFolderType { get; set; }
		[CProperty(Association ="TransactionFolder:FolderTypeId")]
		public virtual ICollection<TransactionFolder> TransactionFolderByFolderType { get; set; }
		[CProperty(Association ="TsOrderExpenseFolder:FolderTypeId")]
		public virtual ICollection<TsOrderExpenseFolder> TsOrderExpenseFolderByFolderType { get; set; }
		[CProperty(Association ="VwFolderInCampaign:FolderTypeId")]
		public virtual ICollection<VwFolderInCampaign> VwFolderInCampaignByFolderType { get; set; }
		[CProperty(Association ="VwProcessLibFolder:FolderTypeId")]
		public virtual ICollection<VwProcessLibFolder> VwProcessLibFolderByFolderType { get; set; }
		[CProperty(Association ="VwSysDcmLibFolder:FolderTypeId")]
		public virtual ICollection<VwSysDcmLibFolder> VwSysDcmLibFolderByFolderType { get; set; }
		[CProperty(Association ="VwSysProcessFolder:FolderTypeId")]
		public virtual ICollection<VwSysProcessFolder> VwSysProcessFolderByFolderType { get; set; }
		[CProperty(Association ="WebServiceV2Folder:FolderTypeId")]
		public virtual ICollection<WebServiceV2Folder> WebServiceV2FolderByFolderType { get; set; }
		[CProperty(Association ="WorkDeployLogFolder:FolderTypeId")]
		public virtual ICollection<WorkDeployLogFolder> WorkDeployLogFolderByFolderType { get; set; }
		#endregion
	}
}
