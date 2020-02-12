using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Queue")]
	public class Queue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AssignOperatorAutomatically")]
		public bool AssignOperatorAutomatically { get; set; }
		[CProperty(ColumnPath ="BusinessProcessSchemaId")]
		public Guid BusinessProcessSchemaId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntitySchemaCaption")]
		public string EntitySchemaCaption { get; set; }
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="FilterData")]
		public string FilterData { get; set; }
		[CProperty(ColumnPath ="FilterEditData")]
		public string FilterEditData { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IgnorePriorityFilterData")]
		public string IgnorePriorityFilterData { get; set; }
		[CProperty(ColumnPath ="IsManuallyFilling")]
		public bool IsManuallyFilling { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProcessSchemaCaption")]
		public string ProcessSchemaCaption { get; set; }
		[CProperty(ColumnPath ="ProcessSchemaUId")]
		public Guid ProcessSchemaUId { get; set; }
		[CProperty(ColumnPath ="QueueEntitySchemaId")]
		public Guid QueueEntitySchemaId { get; set; }
		[CProperty(ColumnPath ="QueueItemAdditionId")]
		public Guid QueueItemAdditionId { get; set; }
		[CProperty(ColumnPath ="QueueUpdateFrequencyId")]
		public Guid QueueUpdateFrequencyId { get; set; }
		[CProperty(ColumnPath ="SentEmailToOperator")]
		public bool SentEmailToOperator { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="QueueItemAddition:QueueItemAdditionId")]
		public QueueItemAddition QueueItemAddition { get; set; }
		[CProperty(Navigation ="QueuePriority:PriorityId")]
		public QueuePriority Priority { get; set; }
		[CProperty(Navigation ="QueueStatus:StatusId")]
		public QueueStatus Status { get; set; }
		[CProperty(Navigation ="QueueUpdateFrequency:QueueUpdateFrequencyId")]
		public QueueUpdateFrequency QueueUpdateFrequency { get; set; }
		[CProperty(Navigation ="VwQueueSysProcess:BusinessProcessSchemaId")]
		public VwQueueSysProcess BusinessProcessSchema { get; set; }
		[CProperty(Navigation ="VwQueueSysSchema:QueueEntitySchemaId")]
		public VwQueueSysSchema QueueEntitySchema { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:QueueId")]
		public virtual ICollection<Activity> ActivityByQueue { get; set; }
		[CProperty(Association ="QueueFilteredItem:QueueId")]
		public virtual ICollection<QueueFilteredItem> QueueFilteredItemByQueue { get; set; }
		[CProperty(Association ="QueueInFolder:QueueId")]
		public virtual ICollection<QueueInFolder> QueueInFolderByQueue { get; set; }
		[CProperty(Association ="QueueInTag:EntityId")]
		public virtual ICollection<QueueInTag> QueueInTagByEntity { get; set; }
		[CProperty(Association ="QueueItem:QueueId")]
		public virtual ICollection<QueueItem> QueueItemByQueue { get; set; }
		[CProperty(Association ="QueueItemReaction:QueueId")]
		public virtual ICollection<QueueItemReaction> QueueItemReactionByQueue { get; set; }
		[CProperty(Association ="QueueOperator:QueueId")]
		public virtual ICollection<QueueOperator> QueueOperatorByQueue { get; set; }
		[CProperty(Association ="VwQueueItem:QueueId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByQueue { get; set; }
		[CProperty(Association ="VwQueueItemDashboard:QueueId")]
		public virtual ICollection<VwQueueItemDashboard> VwQueueItemDashboardByQueue { get; set; }
		[CProperty(Association ="VwQueueItemDashboardC:QueueId")]
		public virtual ICollection<VwQueueItemDashboardC> VwQueueItemDashboardCByQueue { get; set; }
		[CProperty(Association ="VwQueueItemSuper:QueueId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByQueue { get; set; }
		#endregion
	}
}
