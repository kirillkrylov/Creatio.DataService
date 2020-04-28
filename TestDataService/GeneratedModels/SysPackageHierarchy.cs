using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPackageHierarchy")]
	public class SysPackageHierarchy : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BaseSysPackageId")]
		public Guid BaseSysPackageId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DependOnPackageId")]
		public Guid DependOnPackageId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Level")]
		public int Level { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysPackage:BaseSysPackageId")]
		public SysPackage BaseSysPackage { get; set; }
		[CProperty(Navigation ="SysPackage:SysPackageId")]
		public SysPackage SysPackage { get; set; }
		[CProperty(Navigation ="SysPackage:DependOnPackageId")]
		public SysPackage DependOnPackage { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
