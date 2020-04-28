using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "KnowledgeBase")]
	public class KnowledgeBase : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Keywords")]
		public string Keywords { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="NotHtmlNote")]
		public string NotHtmlNote { get; set; }
		[CProperty(ColumnPath ="PDEAccountId")]
		public Guid PDEAccountId { get; set; }
		[CProperty(ColumnPath ="PDECustomerId")]
		public Guid PDECustomerId { get; set; }
		[CProperty(ColumnPath ="PDEIndustryId")]
		public Guid PDEIndustryId { get; set; }
		[CProperty(ColumnPath ="PDEProjectEndDate")]
		public DateTime PDEProjectEndDate { get; set; }
		[CProperty(ColumnPath ="PDEProjectStatusId")]
		public Guid PDEProjectStatusId { get; set; }
		[CProperty(ColumnPath ="PDEStatusId")]
		public Guid PDEStatusId { get; set; }
		[CProperty(ColumnPath ="PDESubIndustryId")]
		public Guid PDESubIndustryId { get; set; }
		[CProperty(ColumnPath ="PDEVerificationDate")]
		public DateTime PDEVerificationDate { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="ViewsCount")]
		public int ViewsCount { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PDEAccountId")]
		public Account PDEAccount { get; set; }
		[CProperty(Navigation ="AccountIndustry:PDEIndustryId")]
		public AccountIndustry PDEIndustry { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlbCustomer:PDECustomerId")]
		public GlbCustomer PDECustomer { get; set; }
		[CProperty(Navigation ="KnowledgeBaseType:TypeId")]
		public KnowledgeBaseType Type { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		[CProperty(Navigation ="PDEClientCaseProjectStatus:PDEProjectStatusId")]
		public PDEClientCaseProjectStatus PDEProjectStatus { get; set; }
		[CProperty(Navigation ="PDEKnowledgeBaseStatus:PDEStatusId")]
		public PDEKnowledgeBaseStatus PDEStatus { get; set; }
		[CProperty(Navigation ="SubIndustry:PDESubIndustryId")]
		public SubIndustry PDESubIndustry { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:PDEKnowledgeBaseId")]
		public virtual ICollection<Activity> ActivityByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="Comment:KnowledgeBaseId")]
		public virtual ICollection<Comment> CommentByKnowledgeBase { get; set; }
		[CProperty(Association ="Favorites:KnowledgeBaseId")]
		public virtual ICollection<Favorites> FavoritesByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseFile:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFileByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseInCase:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseInCase> KnowledgeBaseInCaseByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseInFolder:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseInFolder> KnowledgeBaseInFolderByKnowledgeBase { get; set; }
		[CProperty(Association ="KnowledgeBaseInTagV2:EntityId")]
		public virtual ICollection<KnowledgeBaseInTagV2> KnowledgeBaseInTagV2ByEntity { get; set; }
		[CProperty(Association ="KnowledgeBaseTagDecoupling:KnowledgeBaseId")]
		public virtual ICollection<KnowledgeBaseTagDecoupling> KnowledgeBaseTagDecouplingByKnowledgeBase { get; set; }
		[CProperty(Association ="Like:KnowledgeBaseId")]
		public virtual ICollection<Like> LikeByKnowledgeBase { get; set; }
		[CProperty(Association ="PDEClientCaseCompetitor:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEClientCaseCompetitor> PDEClientCaseCompetitorByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDEClientCaseIntegration:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEClientCaseIntegration> PDEClientCaseIntegrationByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDEClientCaseMigration:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEClientCaseMigration> PDEClientCaseMigrationByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDEClientCaseRecommendation:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEClientCaseRecommendation> PDEClientCaseRecommendationByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDEClientNeedInKnowledgeBase:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEClientNeedInKnowledgeBase> PDEClientNeedInKnowledgeBaseByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDEIndustryInKnowledgeBase:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEIndustryInKnowledgeBase> PDEIndustryInKnowledgeBaseByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDEKnowledgeBaseVisa:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEKnowledgeBaseVisa> PDEKnowledgeBaseVisaByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDEPresaleNotesInKnowledgeBase:PDEKnowledgeBaseId")]
		public virtual ICollection<PDEPresaleNotesInKnowledgeBase> PDEPresaleNotesInKnowledgeBaseByPDEKnowledgeBase { get; set; }
		[CProperty(Association ="PDESuitableCustomerCaseInOpportunity:PDECustomerCaseId")]
		public virtual ICollection<PDESuitableCustomerCaseInOpportunity> PDESuitableCustomerCaseInOpportunityByPDECustomerCase { get; set; }
		[CProperty(Association ="PDESuitableDemoInOpportunity:PDEDemoLibraryId")]
		public virtual ICollection<PDESuitableDemoInOpportunity> PDESuitableDemoInOpportunityByPDEDemoLibrary { get; set; }
		[CProperty(Association ="PDESuitablePainAndSolutionInOpportunity:PDEPainAndSolutionId")]
		public virtual ICollection<PDESuitablePainAndSolutionInOpportunity> PDESuitablePainAndSolutionInOpportunityByPDEPainAndSolution { get; set; }
		#endregion
	}
}
