using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseSubtype")]
	public class CaseSubtype : BaseEntity
	{
		#region Values
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
		private Guid _OrgStructureUnitId;
		[CProperty(ColumnPath ="OrgStructureUnitId")]
		public Guid OrgStructureUnitId
		{
			get{return _OrgStructureUnitId;}
			set
			{
				_OrgStructureUnitId = value;
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
		private Guid _SupSupportOrgStructureUnitId;
		[CProperty(ColumnPath ="SupSupportOrgStructureUnitId")]
		public Guid SupSupportOrgStructureUnitId
		{
			get{return _SupSupportOrgStructureUnitId;}
			set
			{
				_SupSupportOrgStructureUnitId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseType:TypeId")]
		public CaseType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:OrgStructureUnitId")]
		public OrgStructureUnit OrgStructureUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SupSupportOrgStructureUnitId")]
		public SysAdminUnit SupSupportOrgStructureUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:SubtypeId")]
		public virtual ICollection<Case> CaseBySubtype { get; set; }
		[CProperty(Association ="Change:ProductFunctionId")]
		public virtual ICollection<Change> ChangeByProductFunction { get; set; }
		[CProperty(Association ="Problem:CaseSubtypeId")]
		public virtual ICollection<Problem> ProblemByCaseSubtype { get; set; }
		[CProperty(Association ="SiteStatModuleUsageMetrics:FunctionId")]
		public virtual ICollection<SiteStatModuleUsageMetrics> SiteStatModuleUsageMetricsByFunction { get; set; }
		[CProperty(Association ="SupCloudCaseDefValue:SupSubtypeId")]
		public virtual ICollection<SupCloudCaseDefValue> SupCloudCaseDefValueBySupSubtype { get; set; }
		[CProperty(Association ="VwChange:ProductFunctionId")]
		public virtual ICollection<VwChange> VwChangeByProductFunction { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsage:FunctionId")]
		public virtual ICollection<VwSiteStatModuleUsage> VwSiteStatModuleUsageByFunction { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsageHistory:FunctionId")]
		public virtual ICollection<VwSiteStatModuleUsageHistory> VwSiteStatModuleUsageHistoryByFunction { get; set; }
		[CProperty(Association ="WorkFunctionOwner:CaseSubTypeId")]
		public virtual ICollection<WorkFunctionOwner> WorkFunctionOwnerByCaseSubType { get; set; }
		#endregion
	}
}
