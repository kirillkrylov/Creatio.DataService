using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "KnowledgeBase")]
	public class KnowledgeBase : BaseEntity
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
		private string _Keywords;
		[CProperty(ColumnPath ="Keywords")]
		public string Keywords
		{
			get{return _Keywords;}
			set
			{
				_Keywords = value;
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
		private string _NotHtmlNote;
		[CProperty(ColumnPath ="NotHtmlNote")]
		public string NotHtmlNote
		{
			get{return _NotHtmlNote;}
			set
			{
				_NotHtmlNote = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEAccountId;
		[CProperty(ColumnPath ="PDEAccountId")]
		public Guid PDEAccountId
		{
			get{return _PDEAccountId;}
			set
			{
				_PDEAccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDECustomerId;
		[CProperty(ColumnPath ="PDECustomerId")]
		public Guid PDECustomerId
		{
			get{return _PDECustomerId;}
			set
			{
				_PDECustomerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEIndustryId;
		[CProperty(ColumnPath ="PDEIndustryId")]
		public Guid PDEIndustryId
		{
			get{return _PDEIndustryId;}
			set
			{
				_PDEIndustryId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PDEProjectEndDate;
		[CProperty(ColumnPath ="PDEProjectEndDate")]
		public DateTime PDEProjectEndDate
		{
			get{return _PDEProjectEndDate;}
			set
			{
				_PDEProjectEndDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEProjectStatusId;
		[CProperty(ColumnPath ="PDEProjectStatusId")]
		public Guid PDEProjectStatusId
		{
			get{return _PDEProjectStatusId;}
			set
			{
				_PDEProjectStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEStatusId;
		[CProperty(ColumnPath ="PDEStatusId")]
		public Guid PDEStatusId
		{
			get{return _PDEStatusId;}
			set
			{
				_PDEStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDESubIndustryId;
		[CProperty(ColumnPath ="PDESubIndustryId")]
		public Guid PDESubIndustryId
		{
			get{return _PDESubIndustryId;}
			set
			{
				_PDESubIndustryId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PDEVerificationDate;
		[CProperty(ColumnPath ="PDEVerificationDate")]
		public DateTime PDEVerificationDate
		{
			get{return _PDEVerificationDate;}
			set
			{
				_PDEVerificationDate = value;
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
		private int _ViewsCount;
		[CProperty(ColumnPath ="ViewsCount")]
		public int ViewsCount
		{
			get{return _ViewsCount;}
			set
			{
				_ViewsCount = value;
				OnPropertyChanged();
			}
		}
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
