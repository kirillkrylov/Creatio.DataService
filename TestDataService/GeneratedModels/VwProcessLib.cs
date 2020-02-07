using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwProcessLib")]
	public class VwProcessLib : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AddToRunButton")]
		public bool AddToRunButton { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Enabled")]
		public bool Enabled { get; set; }
		[CProperty(ColumnPath ="ExtendParent")]
		public bool ExtendParent { get; set; }
		[CProperty(ColumnPath ="HasStartEvent")]
		public bool HasStartEvent { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActiveVersion")]
		public bool IsActiveVersion { get; set; }
		[CProperty(ColumnPath ="IsChanged")]
		public bool IsChanged { get; set; }
		[CProperty(ColumnPath ="IsLocked")]
		public bool IsLocked { get; set; }
		[CProperty(ColumnPath ="IsMaxVersion")]
		public bool IsMaxVersion { get; set; }
		[CProperty(ColumnPath ="IsProcessTracing")]
		public bool IsProcessTracing { get; set; }
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
		[CProperty(ColumnPath ="ProcessSchemaTypeId")]
		public Guid ProcessSchemaTypeId { get; set; }
		[CProperty(ColumnPath ="StartOptionsImageId")]
		public Guid StartOptionsImageId { get; set; }
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId { get; set; }
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		[CProperty(ColumnPath ="TagProperty")]
		public string TagProperty { get; set; }
		[CProperty(ColumnPath ="UId")]
		public Guid UId { get; set; }
		[CProperty(ColumnPath ="Version")]
		public int Version { get; set; }
		[CProperty(ColumnPath ="VersionParentId")]
		public Guid VersionParentId { get; set; }
		[CProperty(ColumnPath ="VersionParentUId")]
		public Guid VersionParentUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProcessSchemaType:ProcessSchemaTypeId")]
		public ProcessSchemaType ProcessSchemaType { get; set; }
		[CProperty(Navigation ="SysImage:StartOptionsImageId")]
		public SysImage StartOptionsImage { get; set; }
		[CProperty(Navigation ="SysPackage:SysPackageId")]
		public SysPackage SysPackage { get; set; }
		[CProperty(Navigation ="SysSchema:ParentId")]
		public SysSchema Parent { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwSubProcessInProcess:HostProcessId")]
		public virtual ICollection<VwSubProcessInProcess> VwSubProcessInProcessByHostProcess { get; set; }
		[CProperty(Association ="VwSubProcessInProcess:ParentProcessId")]
		public virtual ICollection<VwSubProcessInProcess> VwSubProcessInProcessByParentProcess { get; set; }
		[CProperty(Association ="VwSubProcessInProcess:SubProcessId")]
		public virtual ICollection<VwSubProcessInProcess> VwSubProcessInProcessBySubProcess { get; set; }
		[CProperty(Association ="VwSubProcessInProcess:ParentSubProcessId")]
		public virtual ICollection<VwSubProcessInProcess> VwSubProcessInProcessByParentSubProcess { get; set; }
		[CProperty(Association ="VwSubProcessInProcess:ActiveSubProcessId")]
		public virtual ICollection<VwSubProcessInProcess> VwSubProcessInProcessByActiveSubProcess { get; set; }
		#endregion
	}
}
