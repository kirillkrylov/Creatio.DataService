using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MailboxFoldersCorrespondence")]
	public class MailboxFoldersCorrespondence : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityFolderId")]
		public Guid ActivityFolderId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FolderPath")]
		public string FolderPath { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="MailboxId")]
		public Guid MailboxId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="UId")]
		public string UId { get; set; }
		[CProperty(ColumnPath ="UIdValidity")]
		public string UIdValidity { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityFolder:ActivityFolderId")]
		public ActivityFolder ActivityFolder { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MailboxSyncSettings:MailboxId")]
		public MailboxSyncSettings Mailbox { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
