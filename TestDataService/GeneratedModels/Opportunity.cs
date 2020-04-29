using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Opportunity")]
	public class Opportunity : BaseEntity
	{
		#region Values
		private string _AccessCriteria;
		[CProperty(ColumnPath ="AccessCriteria")]
		public string AccessCriteria
		{
			get{return _AccessCriteria;}
			set
			{
				_AccessCriteria = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountBillingInfoId;
		[CProperty(ColumnPath ="AccountBillingInfoId")]
		public Guid AccountBillingInfoId
		{
			get{return _AccountBillingInfoId;}
			set
			{
				_AccountBillingInfoId = value;
				OnPropertyChanged();
			}
		}
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
		private decimal _Amount;
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
				OnPropertyChanged();
			}
		}
		private decimal _AverageFunnel;
		[CProperty(ColumnPath ="AverageFunnel")]
		public decimal AverageFunnel
		{
			get{return _AverageFunnel;}
			set
			{
				_AverageFunnel = value;
				OnPropertyChanged();
			}
		}
		private Guid _BonusSchemeId;
		[CProperty(ColumnPath ="BonusSchemeId")]
		public Guid BonusSchemeId
		{
			get{return _BonusSchemeId;}
			set
			{
				_BonusSchemeId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Booking;
		[CProperty(ColumnPath ="Booking")]
		public decimal Booking
		{
			get{return _Booking;}
			set
			{
				_Booking = value;
				OnPropertyChanged();
			}
		}
		private decimal _Budget;
		[CProperty(ColumnPath ="Budget")]
		public decimal Budget
		{
			get{return _Budget;}
			set
			{
				_Budget = value;
				OnPropertyChanged();
			}
		}
		private string _BuyingProcess;
		[CProperty(ColumnPath ="BuyingProcess")]
		public string BuyingProcess
		{
			get{return _BuyingProcess;}
			set
			{
				_BuyingProcess = value;
				OnPropertyChanged();
			}
		}
		private bool _ByProcess;
		[CProperty(ColumnPath ="ByProcess")]
		public bool ByProcess
		{
			get{return _ByProcess;}
			set
			{
				_ByProcess = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignId;
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId
		{
			get{return _CampaignId;}
			set
			{
				_CampaignId = value;
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
		private DateTime _CheckDate;
		[CProperty(ColumnPath ="CheckDate")]
		public DateTime CheckDate
		{
			get{return _CheckDate;}
			set
			{
				_CheckDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClientLeadChannelId;
		[CProperty(ColumnPath ="ClientLeadChannelId")]
		public Guid ClientLeadChannelId
		{
			get{return _ClientLeadChannelId;}
			set
			{
				_ClientLeadChannelId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ClosedOnDate;
		[CProperty(ColumnPath ="ClosedOnDate")]
		public DateTime ClosedOnDate
		{
			get{return _ClosedOnDate;}
			set
			{
				_ClosedOnDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _CloseReasonId;
		[CProperty(ColumnPath ="CloseReasonId")]
		public Guid CloseReasonId
		{
			get{return _CloseReasonId;}
			set
			{
				_CloseReasonId = value;
				OnPropertyChanged();
			}
		}
		private int _Completeness;
		[CProperty(ColumnPath ="Completeness")]
		public int Completeness
		{
			get{return _Completeness;}
			set
			{
				_Completeness = value;
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
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _FirstYearMargin;
		[CProperty(ColumnPath ="FirstYearMargin")]
		public decimal FirstYearMargin
		{
			get{return _FirstYearMargin;}
			set
			{
				_FirstYearMargin = value;
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
		private Guid _IndustryId;
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId
		{
			get{return _IndustryId;}
			set
			{
				_IndustryId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsPrimary;
		[CProperty(ColumnPath ="IsPrimary")]
		public bool IsPrimary
		{
			get{return _IsPrimary;}
			set
			{
				_IsPrimary = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadChannelId;
		[CProperty(ColumnPath ="LeadChannelId")]
		public Guid LeadChannelId
		{
			get{return _LeadChannelId;}
			set
			{
				_LeadChannelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadSourceId;
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId
		{
			get{return _LeadSourceId;}
			set
			{
				_LeadSourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeId;
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId
		{
			get{return _LeadTypeId;}
			set
			{
				_LeadTypeId = value;
				OnPropertyChanged();
			}
		}
		private int _LicenseCount;
		[CProperty(ColumnPath ="LicenseCount")]
		public int LicenseCount
		{
			get{return _LicenseCount;}
			set
			{
				_LicenseCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _MainLeadId;
		[CProperty(ColumnPath ="MainLeadId")]
		public Guid MainLeadId
		{
			get{return _MainLeadId;}
			set
			{
				_MainLeadId = value;
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
		private Guid _MoodId;
		[CProperty(ColumnPath ="MoodId")]
		public Guid MoodId
		{
			get{return _MoodId;}
			set
			{
				_MoodId = value;
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
		private int _NumberOfUsers;
		[CProperty(ColumnPath ="NumberOfUsers")]
		public int NumberOfUsers
		{
			get{return _NumberOfUsers;}
			set
			{
				_NumberOfUsers = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunitySubProcessId;
		[CProperty(ColumnPath ="OpportunitySubProcessId")]
		public Guid OpportunitySubProcessId
		{
			get{return _OpportunitySubProcessId;}
			set
			{
				_OpportunitySubProcessId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerFarmerId;
		[CProperty(ColumnPath ="OwnerFarmerId")]
		public Guid OwnerFarmerId
		{
			get{return _OwnerFarmerId;}
			set
			{
				_OwnerFarmerId = value;
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
		private Guid _PartnerId;
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId
		{
			get{return _PartnerId;}
			set
			{
				_PartnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerProjectRoleId;
		[CProperty(ColumnPath ="PartnerProjectRoleId")]
		public Guid PartnerProjectRoleId
		{
			get{return _PartnerProjectRoleId;}
			set
			{
				_PartnerProjectRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerTypeId;
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId
		{
			get{return _PartnerTypeId;}
			set
			{
				_PartnerTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerWorkConditionId;
		[CProperty(ColumnPath ="PartnerWorkConditionId")]
		public Guid PartnerWorkConditionId
		{
			get{return _PartnerWorkConditionId;}
			set
			{
				_PartnerWorkConditionId = value;
				OnPropertyChanged();
			}
		}
		private int _PredictiveProbability;
		[CProperty(ColumnPath ="PredictiveProbability")]
		public int PredictiveProbability
		{
			get{return _PredictiveProbability;}
			set
			{
				_PredictiveProbability = value;
				OnPropertyChanged();
			}
		}
		private int _Probability;
		[CProperty(ColumnPath ="Probability")]
		public int Probability
		{
			get{return _Probability;}
			set
			{
				_Probability = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessId;
		[CProperty(ColumnPath ="ProcessId")]
		public Guid ProcessId
		{
			get{return _ProcessId;}
			set
			{
				_ProcessId = value;
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
		private Guid _RegisterMethodId;
		[CProperty(ColumnPath ="RegisterMethodId")]
		public Guid RegisterMethodId
		{
			get{return _RegisterMethodId;}
			set
			{
				_RegisterMethodId = value;
				OnPropertyChanged();
			}
		}
		private bool _Renewal;
		[CProperty(ColumnPath ="Renewal")]
		public bool Renewal
		{
			get{return _Renewal;}
			set
			{
				_Renewal = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RenewalDate;
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate
		{
			get{return _RenewalDate;}
			set
			{
				_RenewalDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResponsibleDepartmentId;
		[CProperty(ColumnPath ="ResponsibleDepartmentId")]
		public Guid ResponsibleDepartmentId
		{
			get{return _ResponsibleDepartmentId;}
			set
			{
				_ResponsibleDepartmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SourceId;
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId
		{
			get{return _SourceId;}
			set
			{
				_SourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageId;
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId
		{
			get{return _StageId;}
			set
			{
				_StageId = value;
				OnPropertyChanged();
			}
		}
		private string _Strength;
		[CProperty(ColumnPath ="Strength")]
		public string Strength
		{
			get{return _Strength;}
			set
			{
				_Strength = value;
				OnPropertyChanged();
			}
		}
		private string _Tactic;
		[CProperty(ColumnPath ="Tactic")]
		public string Tactic
		{
			get{return _Tactic;}
			set
			{
				_Tactic = value;
				OnPropertyChanged();
			}
		}
		private decimal _TCV;
		[CProperty(ColumnPath ="TCV")]
		public decimal TCV
		{
			get{return _TCV;}
			set
			{
				_TCV = value;
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
		private decimal _TsBudgetRenewal;
		[CProperty(ColumnPath ="TsBudgetRenewal")]
		public decimal TsBudgetRenewal
		{
			get{return _TsBudgetRenewal;}
			set
			{
				_TsBudgetRenewal = value;
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
		private bool _UsePublicOffer;
		[CProperty(ColumnPath ="UsePublicOffer")]
		public bool UsePublicOffer
		{
			get{return _UsePublicOffer;}
			set
			{
				_UsePublicOffer = value;
				OnPropertyChanged();
			}
		}
		private string _Weaknesses;
		[CProperty(ColumnPath ="Weaknesses")]
		public string Weaknesses
		{
			get{return _Weaknesses;}
			set
			{
				_Weaknesses = value;
				OnPropertyChanged();
			}
		}
		private decimal _WeightedBooking;
		[CProperty(ColumnPath ="WeightedBooking")]
		public decimal WeightedBooking
		{
			get{return _WeightedBooking;}
			set
			{
				_WeightedBooking = value;
				OnPropertyChanged();
			}
		}
		private decimal _WeightedFirstYearMargin;
		[CProperty(ColumnPath ="WeightedFirstYearMargin")]
		public decimal WeightedFirstYearMargin
		{
			get{return _WeightedFirstYearMargin;}
			set
			{
				_WeightedFirstYearMargin = value;
				OnPropertyChanged();
			}
		}
		private Guid _WinnerId;
		[CProperty(ColumnPath ="WinnerId")]
		public Guid WinnerId
		{
			get{return _WinnerId;}
			set
			{
				_WinnerId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="Account:WinnerId")]
		public Account Winner { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:AccountBillingInfoId")]
		public AccountBillingInfo AccountBillingInfo { get; set; }
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation ="BonusScheme:BonusSchemeId")]
		public BonusScheme BonusScheme { get; set; }
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OwnerFarmerId")]
		public Contact OwnerFarmer { get; set; }
		[CProperty(Navigation ="Lead:MainLeadId")]
		public Lead MainLead { get; set; }
		[CProperty(Navigation ="LeadMedium:LeadChannelId")]
		public LeadMedium LeadChannel { get; set; }
		[CProperty(Navigation ="LeadRegisterMethod:RegisterMethodId")]
		public LeadRegisterMethod RegisterMethod { get; set; }
		[CProperty(Navigation ="LeadSource:LeadSourceId")]
		public LeadSource LeadSource { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="OpportunityCategory:CategoryId")]
		public OpportunityCategory Category { get; set; }
		[CProperty(Navigation ="OpportunityCloseReason:CloseReasonId")]
		public OpportunityCloseReason CloseReason { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:ResponsibleDepartmentId")]
		public OpportunityDepartment ResponsibleDepartment { get; set; }
		[CProperty(Navigation ="OpportunityMood:MoodId")]
		public OpportunityMood Mood { get; set; }
		[CProperty(Navigation ="OpportunitySource:SourceId")]
		public OpportunitySource Source { get; set; }
		[CProperty(Navigation ="OpportunitySource:ClientLeadChannelId")]
		public OpportunitySource ClientLeadChannel { get; set; }
		[CProperty(Navigation ="OpportunityStage:StageId")]
		public OpportunityStage Stage { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		[CProperty(Navigation ="OpportunityType:TypeId")]
		public OpportunityType Type { get; set; }
		[CProperty(Navigation ="PartnerProjectRole:PartnerProjectRoleId")]
		public PartnerProjectRole PartnerProjectRole { get; set; }
		[CProperty(Navigation ="PartnerType:PartnerTypeId")]
		public PartnerType PartnerType { get; set; }
		[CProperty(Navigation ="PartnerWorkCondition:PartnerWorkConditionId")]
		public PartnerWorkCondition PartnerWorkCondition { get; set; }
		[CProperty(Navigation ="VwSysProcessData:OpportunitySubProcessId")]
		public VwSysProcessData OpportunitySubProcess { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:OpportunityId")]
		public virtual ICollection<Activity> ActivityByOpportunity { get; set; }
		[CProperty(Association ="Call:OpportunityId")]
		public virtual ICollection<Call> CallByOpportunity { get; set; }
		[CProperty(Association ="Case:OpportunityId")]
		public virtual ICollection<Case> CaseByOpportunity { get; set; }
		[CProperty(Association ="Document:OpportunityId")]
		public virtual ICollection<Document> DocumentByOpportunity { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:OpportunityId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByOpportunity { get; set; }
		[CProperty(Association ="GlbCustomer:GlbFirstOpportunityId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbFirstOpportunity { get; set; }
		[CProperty(Association ="Invoice:OpportunityId")]
		public virtual ICollection<Invoice> InvoiceByOpportunity { get; set; }
		[CProperty(Association ="Lead:OpportunityId")]
		public virtual ICollection<Lead> LeadByOpportunity { get; set; }
		[CProperty(Association ="LeadCompetitor:OpportunityId")]
		public virtual ICollection<LeadCompetitor> LeadCompetitorByOpportunity { get; set; }
		[CProperty(Association ="OppForecastWizDeliveryPlan:OpportunityId")]
		public virtual ICollection<OppForecastWizDeliveryPlan> OppForecastWizDeliveryPlanByOpportunity { get; set; }
		[CProperty(Association ="OppForecastWizPartners:OpportunityId")]
		public virtual ICollection<OppForecastWizPartners> OppForecastWizPartnersByOpportunity { get; set; }
		[CProperty(Association ="OppForecastWizPayments:OpportunityId")]
		public virtual ICollection<OppForecastWizPayments> OppForecastWizPaymentsByOpportunity { get; set; }
		[CProperty(Association ="OppForecastWizSupport:OpportunityId")]
		public virtual ICollection<OppForecastWizSupport> OppForecastWizSupportByOpportunity { get; set; }
		[CProperty(Association ="OpportunityCompetitor:OpportunityId")]
		public virtual ICollection<OpportunityCompetitor> OpportunityCompetitorByOpportunity { get; set; }
		[CProperty(Association ="OpportunityContact:OpportunityId")]
		public virtual ICollection<OpportunityContact> OpportunityContactByOpportunity { get; set; }
		[CProperty(Association ="OpportunityFile:OpportunityId")]
		public virtual ICollection<OpportunityFile> OpportunityFileByOpportunity { get; set; }
		[CProperty(Association ="OpportunityForecast:OpportunityId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByOpportunity { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:OpportunityId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByOpportunity { get; set; }
		[CProperty(Association ="OpportunityInFolder:OpportunityId")]
		public virtual ICollection<OpportunityInFolder> OpportunityInFolderByOpportunity { get; set; }
		[CProperty(Association ="OpportunityInStage:OpportunityId")]
		public virtual ICollection<OpportunityInStage> OpportunityInStageByOpportunity { get; set; }
		[CProperty(Association ="OpportunityInTag:EntityId")]
		public virtual ICollection<OpportunityInTag> OpportunityInTagByEntity { get; set; }
		[CProperty(Association ="OpportunityMessageHistory:OpportunityId")]
		public virtual ICollection<OpportunityMessageHistory> OpportunityMessageHistoryByOpportunity { get; set; }
		[CProperty(Association ="OpportunityParticipant:OpportunityId")]
		public virtual ICollection<OpportunityParticipant> OpportunityParticipantByOpportunity { get; set; }
		[CProperty(Association ="OpportunityPartner:OpportunityId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByOpportunity { get; set; }
		[CProperty(Association ="OpportunityPartnerHistory:OpportunityId")]
		public virtual ICollection<OpportunityPartnerHistory> OpportunityPartnerHistoryByOpportunity { get; set; }
		[CProperty(Association ="OpportunityProductInterest:OpportunityId")]
		public virtual ICollection<OpportunityProductInterest> OpportunityProductInterestByOpportunity { get; set; }
		[CProperty(Association ="OpportunityReference:OpportunityId")]
		public virtual ICollection<OpportunityReference> OpportunityReferenceByOpportunity { get; set; }
		[CProperty(Association ="OpportunityTacticHist:OpportunityId")]
		public virtual ICollection<OpportunityTacticHist> OpportunityTacticHistByOpportunity { get; set; }
		[CProperty(Association ="OpportunityVisa:OpportunityId")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaByOpportunity { get; set; }
		[CProperty(Association ="OppSubProcessHistory:OpportunityId")]
		public virtual ICollection<OppSubProcessHistory> OppSubProcessHistoryByOpportunity { get; set; }
		[CProperty(Association ="Order:OpportunityId")]
		public virtual ICollection<Order> OrderByOpportunity { get; set; }
		[CProperty(Association ="PainChain:OpportunityId")]
		public virtual ICollection<PainChain> PainChainByOpportunity { get; set; }
		[CProperty(Association ="PDECustomerNeedInOpportunity:PDEOpportunityId")]
		public virtual ICollection<PDECustomerNeedInOpportunity> PDECustomerNeedInOpportunityByPDEOpportunity { get; set; }
		[CProperty(Association ="PDESuitableCustomerCaseInOpportunity:PDEOpportunityId")]
		public virtual ICollection<PDESuitableCustomerCaseInOpportunity> PDESuitableCustomerCaseInOpportunityByPDEOpportunity { get; set; }
		[CProperty(Association ="PDESuitableCustomerInOpportunity:PDEOpportunityId")]
		public virtual ICollection<PDESuitableCustomerInOpportunity> PDESuitableCustomerInOpportunityByPDEOpportunity { get; set; }
		[CProperty(Association ="PDESuitableDemoInOpportunity:PDEOpportunityId")]
		public virtual ICollection<PDESuitableDemoInOpportunity> PDESuitableDemoInOpportunityByPDEOpportunity { get; set; }
		[CProperty(Association ="PDESuitablePainAndSolutionInOpportunity:PDEOpportunityId")]
		public virtual ICollection<PDESuitablePainAndSolutionInOpportunity> PDESuitablePainAndSolutionInOpportunityByPDEOpportunity { get; set; }
		[CProperty(Association ="PDESuitableReferenceInOpportunity:PDEOpportunityId")]
		public virtual ICollection<PDESuitableReferenceInOpportunity> PDESuitableReferenceInOpportunityByPDEOpportunity { get; set; }
		[CProperty(Association ="Project:OpportunityId")]
		public virtual ICollection<Project> ProjectByOpportunity { get; set; }
		[CProperty(Association ="ReasonsForLosing:OpportunityId")]
		public virtual ICollection<ReasonsForLosing> ReasonsForLosingByOpportunity { get; set; }
		[CProperty(Association ="SalesProcessEvent:OpportunityId")]
		public virtual ICollection<SalesProcessEvent> SalesProcessEventByOpportunity { get; set; }
		[CProperty(Association ="TransactionForecast:OpportunityId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByOpportunity { get; set; }
		[CProperty(Association ="VwLead:OpportunityId")]
		public virtual ICollection<VwLead> VwLeadByOpportunity { get; set; }
		[CProperty(Association ="VwOpportFunnelData:OpportunityId")]
		public virtual ICollection<VwOpportFunnelData> VwOpportFunnelDataByOpportunity { get; set; }
		[CProperty(Association ="VwOpportInStageForAnalysis:OpportunityId")]
		public virtual ICollection<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisByOpportunity { get; set; }
		[CProperty(Association ="VwOpportunityFile:OpportunityId")]
		public virtual ICollection<VwOpportunityFile> VwOpportunityFileByOpportunity { get; set; }
		[CProperty(Association ="VwOpportunityInStage:OpportunityId")]
		public virtual ICollection<VwOpportunityInStage> VwOpportunityInStageByOpportunity { get; set; }
		#endregion
	}
}
