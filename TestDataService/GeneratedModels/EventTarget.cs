using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EventTarget")]
	public class EventTarget : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="EventResponseId")]
		public Guid EventResponseId { get; set; }
		[CProperty(ColumnPath ="GeneratedWebFormId")]
		public Guid GeneratedWebFormId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsFromGroup")]
		public bool IsFromGroup { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Note")]
		public string Note { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParticipantStatusId")]
		public Guid ParticipantStatusId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegistrationTypeId")]
		public Guid RegistrationTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="EventParticipantStatus:ParticipantStatusId")]
		public EventParticipantStatus ParticipantStatus { get; set; }
		[CProperty(Navigation ="EventResponse:EventResponseId")]
		public EventResponse EventResponse { get; set; }
		[CProperty(Navigation ="EventTargetRegistrationType:RegistrationTypeId")]
		public EventTargetRegistrationType RegistrationType { get; set; }
		[CProperty(Navigation ="GeneratedWebForm:GeneratedWebFormId")]
		public GeneratedWebForm GeneratedWebForm { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EventResponseChangeLog:EventTargetId")]
		public virtual ICollection<EventResponseChangeLog> EventResponseChangeLogByEventTarget { get; set; }
		#endregion
	}
}
