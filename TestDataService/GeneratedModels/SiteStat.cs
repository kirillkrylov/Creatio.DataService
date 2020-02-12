using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStat")]
	public class SiteStat : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SiteId")]
		public Guid SiteId { get; set; }
		[CProperty(ColumnPath ="StatDate")]
		public DateTime StatDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ConfItem:SiteId")]
		public ConfItem Site { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SiteStatAddValue:SiteStatId")]
		public virtual ICollection<SiteStatAddValue> SiteStatAddValueBySiteStat { get; set; }
		[CProperty(Association ="SiteStatModuleUsageHistory:SiteStatId")]
		public virtual ICollection<SiteStatModuleUsageHistory> SiteStatModuleUsageHistoryBySiteStat { get; set; }
		[CProperty(Association ="SiteStatUserSession:SiteStatId")]
		public virtual ICollection<SiteStatUserSession> SiteStatUserSessionBySiteStat { get; set; }
		#endregion
	}
}
