using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysSchemaInPackage")]
	public class VwSysSchemaInPackage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ManagerName")]
		public string ManagerName { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId { get; set; }
		[CProperty(ColumnPath ="SysPackageLevel")]
		public int SysPackageLevel { get; set; }
		[CProperty(ColumnPath ="SysPackageUId")]
		public Guid SysPackageUId { get; set; }
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
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		[CProperty(Navigation ="VwSysSchemaInPackage:ParentId")]
		public VwSysSchemaInPackage Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwSysClientUnitSchemaInPackage:ParentId")]
		public virtual ICollection<VwSysClientUnitSchemaInPackage> VwSysClientUnitSchemaInPackageByParent { get; set; }
		[CProperty(Association ="VwSysEntitySchemaInPackage:ParentId")]
		public virtual ICollection<VwSysEntitySchemaInPackage> VwSysEntitySchemaInPackageByParent { get; set; }
		[CProperty(Association ="VwSysSchemaInPackage:ParentId")]
		public virtual ICollection<VwSysSchemaInPackage> VwSysSchemaInPackageByParent { get; set; }
		#endregion
	}
}
