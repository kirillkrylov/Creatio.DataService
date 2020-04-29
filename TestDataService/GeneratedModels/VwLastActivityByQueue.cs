using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwLastActivityByQueue")]
	public class VwLastActivityByQueue : BaseEntity
	{
		#region Values
		private Guid _ActivityId;
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId
		{
			get{return _ActivityId;}
			set
			{
				_ActivityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueItemId;
		[CProperty(ColumnPath ="QueueItemId")]
		public Guid QueueItemId
		{
			get{return _QueueItemId;}
			set
			{
				_QueueItemId = value;
				OnPropertyChanged();
			}
		}
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
