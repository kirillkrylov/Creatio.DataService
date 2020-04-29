using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseType")]
	public class CaseType : BaseEntity
	{
		#region Values
		private Guid _CaseCategoryId;
		[CProperty(ColumnPath ="CaseCategoryId")]
		public Guid CaseCategoryId
		{
			get{return _CaseCategoryId;}
			set
			{
				_CaseCategoryId = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseCategory:CaseCategoryId")]
		public CaseCategory CaseCategory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:TypeId")]
		public virtual ICollection<Case> CaseByType { get; set; }
		[CProperty(Association ="CaseSubtype:TypeId")]
		public virtual ICollection<CaseSubtype> CaseSubtypeByType { get; set; }
		[CProperty(Association ="CaseTypeFile:CaseTypeId")]
		public virtual ICollection<CaseTypeFile> CaseTypeFileByCaseType { get; set; }
		[CProperty(Association ="CaseTypeInFolder:CaseTypeId")]
		public virtual ICollection<CaseTypeInFolder> CaseTypeInFolderByCaseType { get; set; }
		[CProperty(Association ="CaseTypeInTag:EntityId")]
		public virtual ICollection<CaseTypeInTag> CaseTypeInTagByEntity { get; set; }
		[CProperty(Association ="Change:ProductModuleId")]
		public virtual ICollection<Change> ChangeByProductModule { get; set; }
		[CProperty(Association ="ModuleInProduct:CaseTypeId")]
		public virtual ICollection<ModuleInProduct> ModuleInProductByCaseType { get; set; }
		[CProperty(Association ="Problem:CaseTypeId")]
		public virtual ICollection<Problem> ProblemByCaseType { get; set; }
		[CProperty(Association ="SiteStatModuleUsageMetrics:ModuleId")]
		public virtual ICollection<SiteStatModuleUsageMetrics> SiteStatModuleUsageMetricsByModule { get; set; }
		[CProperty(Association ="SupCloudCaseDefValue:SupTypeId")]
		public virtual ICollection<SupCloudCaseDefValue> SupCloudCaseDefValueBySupType { get; set; }
		[CProperty(Association ="VwChange:ProductModuleId")]
		public virtual ICollection<VwChange> VwChangeByProductModule { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsage:ModuleId")]
		public virtual ICollection<VwSiteStatModuleUsage> VwSiteStatModuleUsageByModule { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsageHistory:ModuleId")]
		public virtual ICollection<VwSiteStatModuleUsageHistory> VwSiteStatModuleUsageHistoryByModule { get; set; }
		[CProperty(Association ="WorkFunctionOwner:CaseTypeId")]
		public virtual ICollection<WorkFunctionOwner> WorkFunctionOwnerByCaseType { get; set; }
		#endregion
	}
}
