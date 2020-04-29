using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EventTarget")]
	public class EventTarget : BaseEntity
	{
		#region Values
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _EventId;
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId
		{
			get{return _EventId;}
			set
			{
				_EventId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EventResponseId;
		[CProperty(ColumnPath ="EventResponseId")]
		public Guid EventResponseId
		{
			get{return _EventResponseId;}
			set
			{
				_EventResponseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GeneratedWebFormId;
		[CProperty(ColumnPath ="GeneratedWebFormId")]
		public Guid GeneratedWebFormId
		{
			get{return _GeneratedWebFormId;}
			set
			{
				_GeneratedWebFormId = value;
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
		private bool _IsFromGroup;
		[CProperty(ColumnPath ="IsFromGroup")]
		public bool IsFromGroup
		{
			get{return _IsFromGroup;}
			set
			{
				_IsFromGroup = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Note;
		[CProperty(ColumnPath ="Note")]
		public string Note
		{
			get{return _Note;}
			set
			{
				_Note = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParticipantStatusId;
		[CProperty(ColumnPath ="ParticipantStatusId")]
		public Guid ParticipantStatusId
		{
			get{return _ParticipantStatusId;}
			set
			{
				_ParticipantStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerId;
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId
		{
			get{return _PartnerId;}
			set
			{
				_PartnerId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _RegistrationTypeId;
		[CProperty(ColumnPath ="RegistrationTypeId")]
		public Guid RegistrationTypeId
		{
			get{return _RegistrationTypeId;}
			set
			{
				_RegistrationTypeId = value;
				OnPropertyChanged();
			}
		}
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
