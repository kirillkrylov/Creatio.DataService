using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysEntitySchemaInWorkspace")]
	public class VwSysEntitySchemaInWorkspace : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ExtendParent")]
		public bool ExtendParent { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsChanged")]
		public bool IsChanged { get; set; }
		[CProperty(ColumnPath ="IsLocked")]
		public bool IsLocked { get; set; }
		[CProperty(ColumnPath ="IsVirtual")]
		public bool IsVirtual { get; set; }
		[CProperty(ColumnPath ="ManagerName")]
		public string ManagerName { get; set; }
		[CProperty(ColumnPath ="MetaData")]
		public byte[] MetaData { get; set; }
		[CProperty(ColumnPath ="MetaDataModifiedOn")]
		public DateTime MetaDataModifiedOn { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NeedInstall")]
		public bool NeedInstall { get; set; }
		[CProperty(ColumnPath ="NeedUpdateSourceCode")]
		public bool NeedUpdateSourceCode { get; set; }
		[CProperty(ColumnPath ="NeedUpdateStructure")]
		public bool NeedUpdateStructure { get; set; }
		[CProperty(ColumnPath ="PackageUId")]
		public Guid PackageUId { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		[CProperty(ColumnPath ="UId")]
		public Guid UId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysPackage:SysPackageId")]
		public SysPackage SysPackage { get; set; }
		[CProperty(Navigation ="SysSchema:ParentId")]
		public SysSchema Parent { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
