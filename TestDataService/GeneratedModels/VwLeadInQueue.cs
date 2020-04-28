using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwLeadInQueue")]
	public class VwLeadInQueue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CloseReasonId")]
		public Guid CloseReasonId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="ElementStatusId")]
		public Guid ElementStatusId { get; set; }
		[CProperty(ColumnPath ="EntityRecordId")]
		public Guid EntityRecordId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OperatorId")]
		public Guid OperatorId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="QueueName")]
		public string QueueName { get; set; }
		[CProperty(ColumnPath ="QueuePriorityId")]
		public Guid QueuePriorityId { get; set; }
		[CProperty(ColumnPath ="QueueStatusId")]
		public Guid QueueStatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OperatorId")]
		public Contact Operator { get; set; }
		[CProperty(Navigation ="QueueItemCloseReason:CloseReasonId")]
		public QueueItemCloseReason CloseReason { get; set; }
		[CProperty(Navigation ="QueueItemStatus:ElementStatusId")]
		public QueueItemStatus ElementStatus { get; set; }
		[CProperty(Navigation ="QueuePriority:QueuePriorityId")]
		public QueuePriority QueuePriority { get; set; }
		[CProperty(Navigation ="QueueStatus:QueueStatusId")]
		public QueueStatus QueueStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
