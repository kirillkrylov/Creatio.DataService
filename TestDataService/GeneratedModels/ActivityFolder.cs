using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivityFolder")]
	public class ActivityFolder : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FolderEmbeddedProcessId")]
		public Guid FolderEmbeddedProcessId { get; set; }
		[CProperty(ColumnPath ="FolderTypeId")]
		public Guid FolderTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OptimizationType")]
		public int OptimizationType { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SearchData")]
		public byte[] SearchData { get; set; }
		[CProperty(ColumnPath ="Synchronize")]
		public bool Synchronize { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ActivityFolder:ParentId")]
		public ActivityFolder Parent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FolderType:FolderTypeId")]
		public FolderType FolderType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ActivityFolder:ParentId")]
		public virtual ICollection<ActivityFolder> ActivityFolderByParent { get; set; }
		[CProperty(Association ="ActivityInFolder:FolderId")]
		public virtual ICollection<ActivityInFolder> ActivityInFolderByFolder { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:EmailFolderId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByEmailFolder { get; set; }
		[CProperty(Association ="MailboxFoldersCorrespondence:ActivityFolderId")]
		public virtual ICollection<MailboxFoldersCorrespondence> MailboxFoldersCorrespondenceByActivityFolder { get; set; }
		#endregion
	}
}
