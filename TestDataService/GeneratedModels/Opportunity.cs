using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Opportunity")]
	public class Opportunity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccessCriteria")]
		public string AccessCriteria { get; set; }
		[CProperty(ColumnPath ="AccountBillingInfoId")]
		public Guid AccountBillingInfoId { get; set; }
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AverageFunnel")]
		public decimal AverageFunnel { get; set; }
		[CProperty(ColumnPath ="BonusSchemeId")]
		public Guid BonusSchemeId { get; set; }
		[CProperty(ColumnPath ="Booking")]
		public decimal Booking { get; set; }
		[CProperty(ColumnPath ="Budget")]
		public decimal Budget { get; set; }
		[CProperty(ColumnPath ="BuyingProcess")]
		public string BuyingProcess { get; set; }
		[CProperty(ColumnPath ="ByProcess")]
		public bool ByProcess { get; set; }
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CheckDate")]
		public DateTime CheckDate { get; set; }
		[CProperty(ColumnPath ="ClientLeadChannelId")]
		public Guid ClientLeadChannelId { get; set; }
		[CProperty(ColumnPath ="ClosedOnDate")]
		public DateTime ClosedOnDate { get; set; }
		[CProperty(ColumnPath ="CloseReasonId")]
		public Guid CloseReasonId { get; set; }
		[CProperty(ColumnPath ="Completeness")]
		public int Completeness { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="FirstYearMargin")]
		public decimal FirstYearMargin { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId { get; set; }
		[CProperty(ColumnPath ="IsPrimary")]
		public bool IsPrimary { get; set; }
		[CProperty(ColumnPath ="LeadChannelId")]
		public Guid LeadChannelId { get; set; }
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="LicenseCount")]
		public int LicenseCount { get; set; }
		[CProperty(ColumnPath ="MainLeadId")]
		public Guid MainLeadId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="MoodId")]
		public Guid MoodId { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="NumberOfUsers")]
		public int NumberOfUsers { get; set; }
		[CProperty(ColumnPath ="OpportunitySubProcessId")]
		public Guid OpportunitySubProcessId { get; set; }
		[CProperty(ColumnPath ="OwnerFarmerId")]
		public Guid OwnerFarmerId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PartnerProjectRoleId")]
		public Guid PartnerProjectRoleId { get; set; }
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId { get; set; }
		[CProperty(ColumnPath ="PartnerWorkConditionId")]
		public Guid PartnerWorkConditionId { get; set; }
		[CProperty(ColumnPath ="PredictiveProbability")]
		public int PredictiveProbability { get; set; }
		[CProperty(ColumnPath ="Probability")]
		public int Probability { get; set; }
		[CProperty(ColumnPath ="ProcessId")]
		public Guid ProcessId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegisterMethodId")]
		public Guid RegisterMethodId { get; set; }
		[CProperty(ColumnPath ="Renewal")]
		public bool Renewal { get; set; }
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate { get; set; }
		[CProperty(ColumnPath ="ResponsibleDepartmentId")]
		public Guid ResponsibleDepartmentId { get; set; }
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId { get; set; }
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId { get; set; }
		[CProperty(ColumnPath ="Strength")]
		public string Strength { get; set; }
		[CProperty(ColumnPath ="Tactic")]
		public string Tactic { get; set; }
		[CProperty(ColumnPath ="TCV")]
		public decimal TCV { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		[CProperty(ColumnPath ="TsBudgetRenewal")]
		public decimal TsBudgetRenewal { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UsePublicOffer")]
		public bool UsePublicOffer { get; set; }
		[CProperty(ColumnPath ="Weaknesses")]
		public string Weaknesses { get; set; }
		[CProperty(ColumnPath ="WeightedBooking")]
		public decimal WeightedBooking { get; set; }
		[CProperty(ColumnPath ="WeightedFirstYearMargin")]
		public decimal WeightedFirstYearMargin { get; set; }
		[CProperty(ColumnPath ="WinnerId")]
		public Guid WinnerId { get; set; }
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
