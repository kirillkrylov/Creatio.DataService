using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStatModuleUsageHistory")]
	public class SiteStatModuleUsageHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SiteStatId")]
		public Guid SiteStatId { get; set; }
		[CProperty(ColumnPath ="UsageStatusId")]
		public Guid UsageStatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SiteStat:SiteStatId")]
		public SiteStat SiteStat { get; set; }
		[CProperty(Navigation ="UsageCondition:UsageStatusId")]
		public UsageCondition UsageStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
