using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLookupFolder")]
	public class SysLookupFolder : BaseEntity
	{
		#region Values
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FolderType:FolderTypeId")]
		public FolderType FolderType { get; set; }
		[CProperty(Navigation ="SysLookupFolder:ParentId")]
		public SysLookupFolder Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysLookup:SysFolderId")]
		public virtual ICollection<SysLookup> SysLookupBySysFolder { get; set; }
		[CProperty(Association ="SysLookupFolder:ParentId")]
		public virtual ICollection<SysLookupFolder> SysLookupFolderByParent { get; set; }
		[CProperty(Association ="VwSysLookup:SysFolderId")]
		public virtual ICollection<VwSysLookup> VwSysLookupBySysFolder { get; set; }
		[CProperty(Association ="VwSysLookupInFolder:FolderId")]
		public virtual ICollection<VwSysLookupInFolder> VwSysLookupInFolderByFolder { get; set; }
		#endregion
	}
}
