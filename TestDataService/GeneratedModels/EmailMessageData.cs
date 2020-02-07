using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmailMessageData")]
	public class EmailMessageData : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId { get; set; }
		[CProperty(ColumnPath ="ConversationId")]
		public Guid ConversationId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExchangeThreadId")]
		public Guid ExchangeThreadId { get; set; }
		[CProperty(ColumnPath ="ExchangeThreadPosition")]
		public int ExchangeThreadPosition { get; set; }
		[CProperty(ColumnPath ="Headers")]
		public string Headers { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InReplyTo")]
		public string InReplyTo { get; set; }
		[CProperty(ColumnPath ="IsNeedProcess")]
		public bool IsNeedProcess { get; set; }
		[CProperty(ColumnPath ="MailboxSyncSettings")]
		public Guid MailboxSyncSettings { get; set; }
		[CProperty(ColumnPath ="MessageId")]
		public string MessageId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentMessageId")]
		public Guid ParentMessageId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="References")]
		public string References { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		[CProperty(ColumnPath ="SendDate")]
		public DateTime SendDate { get; set; }
		[CProperty(ColumnPath ="SyncSessionId")]
		public string SyncSessionId { get; set; }
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
