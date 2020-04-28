using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SiteStatUserSession")]
	public class SiteStatUserSession : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactName")]
		public string ContactName { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SessionCount")]
		public int SessionCount { get; set; }
		[CProperty(ColumnPath ="SiteStatId")]
		public Guid SiteStatId { get; set; }
		[CProperty(ColumnPath ="UserName")]
		public string UserName { get; set; }
		[CProperty(ColumnPath ="UserType")]
		public string UserType { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SiteStat:SiteStatId")]
		public SiteStat SiteStat { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
