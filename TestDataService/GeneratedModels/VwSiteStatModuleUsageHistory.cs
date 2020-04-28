using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSiteStatModuleUsageHistory")]
	public class VwSiteStatModuleUsageHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FunctionId")]
		public Guid FunctionId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="MetricCode")]
		public string MetricCode { get; set; }
		[CProperty(ColumnPath ="MetricValue")]
		public decimal MetricValue { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ModuleId")]
		public Guid ModuleId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UpdateDate")]
		public DateTime UpdateDate { get; set; }
		[CProperty(ColumnPath ="UsageStatusId")]
		public Guid UsageStatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="CaseSubtype:FunctionId")]
		public CaseSubtype Function { get; set; }
		[CProperty(Navigation ="CaseType:ModuleId")]
		public CaseType Module { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="UsageCondition:UsageStatusId")]
		public UsageCondition UsageStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
