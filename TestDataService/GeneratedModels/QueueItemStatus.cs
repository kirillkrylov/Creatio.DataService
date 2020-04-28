using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QueueItemStatus")]
	public class QueueItemStatus : BaseEntity
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
		[CProperty(ColumnPath ="IsFinal")]
		public bool IsFinal { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="QueueItem:StatusId")]
		public virtual ICollection<QueueItem> QueueItemByStatus { get; set; }
		[CProperty(Association ="VwLeadInQueue:ElementStatusId")]
		public virtual ICollection<VwLeadInQueue> VwLeadInQueueByElementStatus { get; set; }
		[CProperty(Association ="VwQueueItem:StatusId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByStatus { get; set; }
		[CProperty(Association ="VwQueueItemDashboard:QueueItemStatusId")]
		public virtual ICollection<VwQueueItemDashboard> VwQueueItemDashboardByQueueItemStatus { get; set; }
		[CProperty(Association ="VwQueueItemDashboardC:QueueItemStatusId")]
		public virtual ICollection<VwQueueItemDashboardC> VwQueueItemDashboardCByQueueItemStatus { get; set; }
		[CProperty(Association ="VwQueueItemSuper:StatusId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByStatus { get; set; }
		#endregion
	}
}
