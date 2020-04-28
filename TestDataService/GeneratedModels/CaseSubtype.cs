using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseSubtype")]
	public class CaseSubtype : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrgStructureUnitId")]
		public Guid OrgStructureUnitId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SupSupportOrgStructureUnitId")]
		public Guid SupSupportOrgStructureUnitId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
