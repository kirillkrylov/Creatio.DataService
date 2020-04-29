using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmailMessageData")]
	public class EmailMessageData : BaseEntity
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
		private Guid _ConversationId;
		[CProperty(ColumnPath ="ConversationId")]
		public Guid ConversationId
		{
			get{return _ConversationId;}
			set
			{
				_ConversationId = value;
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
		private Guid _ExchangeThreadId;
		[CProperty(ColumnPath ="ExchangeThreadId")]
		public Guid ExchangeThreadId
		{
			get{return _ExchangeThreadId;}
			set
			{
				_ExchangeThreadId = value;
				OnPropertyChanged();
			}
		}
		private int _ExchangeThreadPosition;
		[CProperty(ColumnPath ="ExchangeThreadPosition")]
		public int ExchangeThreadPosition
		{
			get{return _ExchangeThreadPosition;}
			set
			{
				_ExchangeThreadPosition = value;
				OnPropertyChanged();
			}
		}
		private string _Headers;
		[CProperty(ColumnPath ="Headers")]
		public string Headers
		{
			get{return _Headers;}
			set
			{
				_Headers = value;
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
		private string _InReplyTo;
		[CProperty(ColumnPath ="InReplyTo")]
		public string InReplyTo
		{
			get{return _InReplyTo;}
			set
			{
				_InReplyTo = value;
				OnPropertyChanged();
			}
		}
		private bool _IsNeedProcess;
		[CProperty(ColumnPath ="IsNeedProcess")]
		public bool IsNeedProcess
		{
			get{return _IsNeedProcess;}
			set
			{
				_IsNeedProcess = value;
				OnPropertyChanged();
			}
		}
		private Guid _MailboxSyncSettings;
		[CProperty(ColumnPath ="MailboxSyncSettings")]
		public Guid MailboxSyncSettings
		{
			get{return _MailboxSyncSettings;}
			set
			{
				_MailboxSyncSettings = value;
				OnPropertyChanged();
			}
		}
		private string _MessageId;
		[CProperty(ColumnPath ="MessageId")]
		public string MessageId
		{
			get{return _MessageId;}
			set
			{
				_MessageId = value;
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
		private Guid _ParentMessageId;
		[CProperty(ColumnPath ="ParentMessageId")]
		public Guid ParentMessageId
		{
			get{return _ParentMessageId;}
			set
			{
				_ParentMessageId = value;
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
		private string _References;
		[CProperty(ColumnPath ="References")]
		public string References
		{
			get{return _References;}
			set
			{
				_References = value;
				OnPropertyChanged();
			}
		}
		private Guid _RoleId;
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId
		{
			get{return _RoleId;}
			set
			{
				_RoleId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SendDate;
		[CProperty(ColumnPath ="SendDate")]
		public DateTime SendDate
		{
			get{return _SendDate;}
			set
			{
				_SendDate = value;
				OnPropertyChanged();
			}
		}
		private string _SyncSessionId;
		[CProperty(ColumnPath ="SyncSessionId")]
		public string SyncSessionId
		{
			get{return _SyncSessionId;}
			set
			{
				_SyncSessionId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation ="ActivityParticipantRole:RoleId")]
		public ActivityParticipantRole Role { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="EmailMessageData:ParentMessageId")]
		public EmailMessageData ParentMessage { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="EmailMessageData:ParentMessageId")]
		public virtual ICollection<EmailMessageData> EmailMessageDataByParentMessage { get; set; }
		#endregion
	}
}
