using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCObjectColumn")]
	public class OneCObjectColumn : BaseEntity
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
		[CProperty(ColumnPath ="IsCheck")]
		public bool IsCheck { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OneCObjectId")]
		public Guid OneCObjectId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Type")]
		public string Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OneCObject:OneCObjectId")]
		public OneCObject OneCObject { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AgregateObject:OneCObjectColumnLinkId")]
		public virtual ICollection<AgregateObject> AgregateObjectByOneCObjectColumnLink { get; set; }
		[CProperty(Association ="AgregateObject:OneCObjectColumnAggregateId")]
		public virtual ICollection<AgregateObject> AgregateObjectByOneCObjectColumnAggregate { get; set; }
		[CProperty(Association ="IntegrationFilter:OneCObjectColumnId")]
		public virtual ICollection<IntegrationFilter> IntegrationFilterByOneCObjectColumn { get; set; }
		[CProperty(Association ="IntegrationFilter:OneCObjectCompareColumnId")]
		public virtual ICollection<IntegrationFilter> IntegrationFilterByOneCObjectCompareColumn { get; set; }
		[CProperty(Association ="SyncColumn:OneCObjectColumnId")]
		public virtual ICollection<SyncColumn> SyncColumnByOneCObjectColumn { get; set; }
		#endregion
	}
}
