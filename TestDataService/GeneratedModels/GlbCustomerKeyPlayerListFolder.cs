using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbCustomerKeyPlayerListFolder")]
	public class GlbCustomerKeyPlayerListFolder : BaseEntity
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
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
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
		[CProperty(Navigation ="GlbCustomerKeyPlayerListFolder:ParentId")]
		public GlbCustomerKeyPlayerListFolder Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="GlbCustomerKeyPlayerListFolder:ParentId")]
		public virtual ICollection<GlbCustomerKeyPlayerListFolder> GlbCustomerKeyPlayerListFolderByParent { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerListInFolder:FolderId")]
		public virtual ICollection<GlbCustomerKeyPlayerListInFolder> GlbCustomerKeyPlayerListInFolderByFolder { get; set; }
		#endregion
	}
}
