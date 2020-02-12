using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStatModuleUsageMetrics")]
	public class SiteStatModuleUsageMetrics : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FunctionId")]
		public Guid FunctionId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InTestValue")]
		public decimal InTestValue { get; set; }
		[CProperty(ColumnPath ="InUseValue")]
		public decimal InUseValue { get; set; }
		[CProperty(ColumnPath ="MetricCalcToolId")]
		public Guid MetricCalcToolId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ModuleId")]
		public Guid ModuleId { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseSubtype:FunctionId")]
		public CaseSubtype Function { get; set; }
		[CProperty(Navigation ="CaseType:ModuleId")]
		public CaseType Module { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MetricCalcTool:MetricCalcToolId")]
		public MetricCalcTool MetricCalcTool { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
