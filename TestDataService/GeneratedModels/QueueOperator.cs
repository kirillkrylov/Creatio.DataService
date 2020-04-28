using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "QueueOperator")]
	public class QueueOperator : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Active")]
		public bool Active { get; set; }
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
		[CProperty(ColumnPath ="OperatorId")]
		public Guid OperatorId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="QueueId")]
		public Guid QueueId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OperatorId")]
		public Contact Operator { get; set; }
		[CProperty(Navigation ="Queue:QueueId")]
		public Queue Queue { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
