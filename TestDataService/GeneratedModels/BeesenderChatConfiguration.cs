using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BeesenderChatConfiguration")]
	public class BeesenderChatConfiguration : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CloseChat")]
		public bool CloseChat { get; set; }
		[CProperty(ColumnPath ="CloseChatTimeout")]
		public int CloseChatTimeout { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Login")]
		public string Login { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Password")]
		public string Password { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SaveAfkChats")]
		public bool SaveAfkChats { get; set; }
		[CProperty(ColumnPath ="SaveAfkChatTimeout")]
		public int SaveAfkChatTimeout { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BeesenderChannel:ConfigurationId")]
		public virtual ICollection<BeesenderChannel> BeesenderChannelByConfiguration { get; set; }
		[CProperty(Association ="BeesenderChatConfigurationFile:BeesenderChatConfigurationId")]
		public virtual ICollection<BeesenderChatConfigurationFile> BeesenderChatConfigurationFileByBeesenderChatConfiguration { get; set; }
		[CProperty(Association ="BeesenderOperatorUnit:ChatConfigId")]
		public virtual ICollection<BeesenderOperatorUnit> BeesenderOperatorUnitByChatConfig { get; set; }
		#endregion
	}
}
