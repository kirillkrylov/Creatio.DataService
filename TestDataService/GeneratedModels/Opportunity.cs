using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Opportunity")]
	public class Opportunity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="Budget")]
		public decimal Budget { get; set; }
		[CProperty(ColumnPath ="ByProcess")]
		public bool ByProcess { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CheckDate")]
		public DateTime CheckDate { get; set; }
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
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsPrimary")]
		public bool IsPrimary { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="MoodId")]
		public Guid MoodId { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PredictiveProbability")]
		public int PredictiveProbability { get; set; }
		[CProperty(ColumnPath ="Probability")]
		public int Probability { get; set; }
		[CProperty(ColumnPath ="ProcessId")]
		public Guid ProcessId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
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
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Weaknesses")]
		public string Weaknesses { get; set; }
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
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
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
		[CProperty(Navigation ="OpportunityStage:StageId")]
		public OpportunityStage Stage { get; set; }
		[CProperty(Navigation ="OpportunityType:TypeId")]
		public OpportunityType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:OpportunityId")]
		public virtual ICollection<Activity> ActivityByOpportunity { get; set; }
		[CProperty(Association ="Call:OpportunityId")]
		public virtual ICollection<Call> CallByOpportunity { get; set; }
		[CProperty(Association ="Document:OpportunityId")]
		public virtual ICollection<Document> DocumentByOpportunity { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:OpportunityId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByOpportunity { get; set; }
		[CProperty(Association ="Invoice:OpportunityId")]
		public virtual ICollection<Invoice> InvoiceByOpportunity { get; set; }
		[CProperty(Association ="Lead:OpportunityId")]
		public virtual ICollection<Lead> LeadByOpportunity { get; set; }
		[CProperty(Association ="OpportunityCompetitor:OpportunityId")]
		public virtual ICollection<OpportunityCompetitor> OpportunityCompetitorByOpportunity { get; set; }
		[CProperty(Association ="OpportunityContact:OpportunityId")]
		public virtual ICollection<OpportunityContact> OpportunityContactByOpportunity { get; set; }
		[CProperty(Association ="OpportunityFile:OpportunityId")]
		public virtual ICollection<OpportunityFile> OpportunityFileByOpportunity { get; set; }
		[CProperty(Association ="OpportunityInFolder:OpportunityId")]
		public virtual ICollection<OpportunityInFolder> OpportunityInFolderByOpportunity { get; set; }
		[CProperty(Association ="OpportunityInStage:OpportunityId")]
		public virtual ICollection<OpportunityInStage> OpportunityInStageByOpportunity { get; set; }
		[CProperty(Association ="OpportunityInTag:EntityId")]
		public virtual ICollection<OpportunityInTag> OpportunityInTagByEntity { get; set; }
		[CProperty(Association ="OpportunityParticipant:OpportunityId")]
		public virtual ICollection<OpportunityParticipant> OpportunityParticipantByOpportunity { get; set; }
		[CProperty(Association ="OpportunityProductInterest:OpportunityId")]
		public virtual ICollection<OpportunityProductInterest> OpportunityProductInterestByOpportunity { get; set; }
		[CProperty(Association ="OpportunityTacticHist:OpportunityId")]
		public virtual ICollection<OpportunityTacticHist> OpportunityTacticHistByOpportunity { get; set; }
		[CProperty(Association ="OpportunityVisa:OpportunityId")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaByOpportunity { get; set; }
		[CProperty(Association ="Order:OpportunityId")]
		public virtual ICollection<Order> OrderByOpportunity { get; set; }
		[CProperty(Association ="Project:OpportunityId")]
		public virtual ICollection<Project> ProjectByOpportunity { get; set; }
		[CProperty(Association ="VwOpportFunnelData:OpportunityId")]
		public virtual ICollection<VwOpportFunnelData> VwOpportFunnelDataByOpportunity { get; set; }
		[CProperty(Association ="VwOpportInStageForAnalysis:OpportunityId")]
		public virtual ICollection<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisByOpportunity { get; set; }
		[CProperty(Association ="VwOpportunityInStage:OpportunityId")]
		public virtual ICollection<VwOpportunityInStage> VwOpportunityInStageByOpportunity { get; set; }
		#endregion
	}
}
