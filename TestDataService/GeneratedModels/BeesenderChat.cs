using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChat")]
	public class BeesenderChat : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="ChannelId")]
		public Guid ChannelId { get; set; }
		[CProperty(ColumnPath ="ClientId")]
		public Guid ClientId { get; set; }
		[CProperty(ColumnPath ="Closed")]
		public bool Closed { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FirstMessage")]
		public string FirstMessage { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalId")]
		public string InternalId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OperatorContactId")]
		public Guid OperatorContactId { get; set; }
		[CProperty(ColumnPath ="OperatorId")]
		public Guid OperatorId { get; set; }
		[CProperty(ColumnPath ="Processing")]
		public bool Processing { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BeesenderChannel:ChannelId")]
		public BeesenderChannel Channel { get; set; }
		[CProperty(Navigation ="BeesenderChatCategory:CategoryId")]
		public BeesenderChatCategory Category { get; set; }
		[CProperty(Navigation ="BeesenderClient:ClientId")]
		public BeesenderClient Client { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OperatorContactId")]
		public Contact OperatorContact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:OperatorId")]
		public SysAdminUnit Operator { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChatFile:BeesenderChatId")]
		public virtual ICollection<BeesenderChatFile> BeesenderChatFileByBeesenderChat { get; set; }
		[CProperty(Association ="BeesenderChatInFolder:BeesenderChatId")]
		public virtual ICollection<BeesenderChatInFolder> BeesenderChatInFolderByBeesenderChat { get; set; }
		[CProperty(Association ="BeesenderChatInTag:EntityId")]
		public virtual ICollection<BeesenderChatInTag> BeesenderChatInTagByEntity { get; set; }
		[CProperty(Association ="BeesenderChatMessage:ChatId")]
		public virtual ICollection<BeesenderChatMessage> BeesenderChatMessageByChat { get; set; }
		#endregion
	}
}
