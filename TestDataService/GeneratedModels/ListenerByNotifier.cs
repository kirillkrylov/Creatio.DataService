using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ListenerByNotifier")]
	public class ListenerByNotifier : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MessageListenerId")]
		public Guid MessageListenerId { get; set; }
		[CProperty(ColumnPath ="MessageNotifierId")]
		public Guid MessageNotifierId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NotifierConnectionColumn")]
		public string NotifierConnectionColumn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MessageListener:MessageListenerId")]
		public MessageListener MessageListener { get; set; }
		[CProperty(Navigation ="MessageNotifier:MessageNotifierId")]
		public MessageNotifier MessageNotifier { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
