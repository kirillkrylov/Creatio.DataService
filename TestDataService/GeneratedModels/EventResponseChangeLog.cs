using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EventResponseChangeLog")]
	public class EventResponseChangeLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EndOn")]
		public DateTime EndOn { get; set; }
		[CProperty(ColumnPath ="EventResponseId")]
		public Guid EventResponseId { get; set; }
		[CProperty(ColumnPath ="EventTargetId")]
		public Guid EventTargetId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EventResponse:EventResponseId")]
		public EventResponse EventResponse { get; set; }
		[CProperty(Navigation ="EventTarget:EventTargetId")]
		public EventTarget EventTarget { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
