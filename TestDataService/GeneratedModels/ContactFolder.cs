using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ContactFolder")]
	public class ContactFolder : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FolderTypeId")]
		public Guid FolderTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ContactFolder:ParentId")]
		public ContactFolder Parent { get; set; }
		[CProperty(Navigation ="FolderType:FolderTypeId")]
		public FolderType FolderType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmailSegment:SegmentId")]
		public virtual ICollection<BulkEmailSegment> BulkEmailSegmentBySegment { get; set; }
		[CProperty(Association ="BulkEmailSplitSegment:SegmentId")]
		public virtual ICollection<BulkEmailSplitSegment> BulkEmailSplitSegmentBySegment { get; set; }
		[CProperty(Association ="CampaignSegment:SegmentId")]
		public virtual ICollection<CampaignSegment> CampaignSegmentBySegment { get; set; }
		[CProperty(Association ="ContactFolder:ParentId")]
		public virtual ICollection<ContactFolder> ContactFolderByParent { get; set; }
		[CProperty(Association ="ContactInFolder:FolderId")]
		public virtual ICollection<ContactInFolder> ContactInFolderByFolder { get; set; }
		[CProperty(Association ="EventSegment:SegmentId")]
		public virtual ICollection<EventSegment> EventSegmentBySegment { get; set; }
		[CProperty(Association ="MailboxContactFolder:ContactFolderId")]
		public virtual ICollection<MailboxContactFolder> MailboxContactFolderByContactFolder { get; set; }
		[CProperty(Association ="VwFolderInCampaign:ContactFolderId")]
		public virtual ICollection<VwFolderInCampaign> VwFolderInCampaignByContactFolder { get; set; }
		#endregion
	}
}
