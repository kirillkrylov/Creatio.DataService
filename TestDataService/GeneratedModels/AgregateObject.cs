using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AgregateObject")]
	public class AgregateObject : BaseEntity
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
		[CProperty(ColumnPath ="OneCObjectColumnAggregateId")]
		public Guid OneCObjectColumnAggregateId { get; set; }
		[CProperty(ColumnPath ="OneCObjectColumnLinkId")]
		public Guid OneCObjectColumnLinkId { get; set; }
		[CProperty(ColumnPath ="OneCObjectId")]
		public Guid OneCObjectId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SyncColumnId")]
		public Guid SyncColumnId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OneCObject:OneCObjectId")]
		public OneCObject OneCObject { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectColumnLinkId")]
		public OneCObjectColumn OneCObjectColumnLink { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectColumnAggregateId")]
		public OneCObjectColumn OneCObjectColumnAggregate { get; set; }
		[CProperty(Navigation ="SyncColumn:SyncColumnId")]
		public SyncColumn SyncColumn { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
