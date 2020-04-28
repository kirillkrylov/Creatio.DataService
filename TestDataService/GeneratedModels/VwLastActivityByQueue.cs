using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwLastActivityByQueue")]
	public class VwLastActivityByQueue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="QueueItemId")]
		public Guid QueueItemId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation ="QueueItem:QueueItemId")]
		public QueueItem QueueItem { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
