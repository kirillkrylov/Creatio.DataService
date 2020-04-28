using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysWorkspace")]
	public class SysWorkspace : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AssemblyData")]
		public byte[] AssemblyData { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Number")]
		public int Number { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RepositoryRevisionNumber")]
		public int RepositoryRevisionNumber { get; set; }
		[CProperty(ColumnPath ="RepositoryUri")]
		public string RepositoryUri { get; set; }
		[CProperty(ColumnPath ="Version")]
		public int Version { get; set; }
		[CProperty(ColumnPath ="WorkingCopyPath")]
		public string WorkingCopyPath { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysPackage:SysWorkspaceId")]
		public virtual ICollection<SysPackage> SysPackageBySysWorkspace { get; set; }
		[CProperty(Association ="SysPackageHierarchy:SysWorkspaceId")]
		public virtual ICollection<SysPackageHierarchy> SysPackageHierarchyBySysWorkspace { get; set; }
		[CProperty(Association ="SysPackageModule:SysWorkspaceId")]
		public virtual ICollection<SysPackageModule> SysPackageModuleBySysWorkspace { get; set; }
		[CProperty(Association ="SysPrcHistoryLog:SysWorkspaceId")]
		public virtual ICollection<SysPrcHistoryLog> SysPrcHistoryLogBySysWorkspace { get; set; }
		[CProperty(Association ="SysProcessLog:SysWorkspaceId")]
		public virtual ICollection<SysProcessLog> SysProcessLogBySysWorkspace { get; set; }
		[CProperty(Association ="VwAdministrativeObjects:SysWorkspaceId")]
		public virtual ICollection<VwAdministrativeObjects> VwAdministrativeObjectsBySysWorkspace { get; set; }
		[CProperty(Association ="VwLogObjects:SysWorkspaceId")]
		public virtual ICollection<VwLogObjects> VwLogObjectsBySysWorkspace { get; set; }
		[CProperty(Association ="VwProcessLib:SysWorkspaceId")]
		public virtual ICollection<VwProcessLib> VwProcessLibBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysClientUnitSchema:SysWorkspaceId")]
		public virtual ICollection<VwSysClientUnitSchema> VwSysClientUnitSchemaBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysClientUnitSchemaInPackage:SysWorkspaceId")]
		public virtual ICollection<VwSysClientUnitSchemaInPackage> VwSysClientUnitSchemaInPackageBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysDcmLib:SysWorkspaceId")]
		public virtual ICollection<VwSysDcmLib> VwSysDcmLibBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysEntitySchemaInPackage:SysWorkspaceId")]
		public virtual ICollection<VwSysEntitySchemaInPackage> VwSysEntitySchemaInPackageBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysEntitySchemaInWorkspace:SysWorkspaceId")]
		public virtual ICollection<VwSysEntitySchemaInWorkspace> VwSysEntitySchemaInWorkspaceBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysLookup:SysWorkspaceId")]
		public virtual ICollection<VwSysLookup> VwSysLookupBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysModuleEdit:SysWorkspaceId")]
		public virtual ICollection<VwSysModuleEdit> VwSysModuleEditBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysModuleEntity:SysWorkspaceId")]
		public virtual ICollection<VwSysModuleEntity> VwSysModuleEntityBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysModuleEntityForEdit:SysWorkspaceId")]
		public virtual ICollection<VwSysModuleEntityForEdit> VwSysModuleEntityForEditBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysPageSchemaInWorkspace:SysWorkspaceId")]
		public virtual ICollection<VwSysPageSchemaInWorkspace> VwSysPageSchemaInWorkspaceBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysProcess:SysWorkspaceId")]
		public virtual ICollection<VwSysProcess> VwSysProcessBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysProcessEntity:SysWorkspaceId")]
		public virtual ICollection<VwSysProcessEntity> VwSysProcessEntityBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysProcessLog:SysWorkspaceId")]
		public virtual ICollection<VwSysProcessLog> VwSysProcessLogBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysSchemaInfo:SysWorkspaceId")]
		public virtual ICollection<VwSysSchemaInfo> VwSysSchemaInfoBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysSchemaInPackage:SysWorkspaceId")]
		public virtual ICollection<VwSysSchemaInPackage> VwSysSchemaInPackageBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysSchemaInWorkspace:SysWorkspaceId")]
		public virtual ICollection<VwSysSchemaInWorkspace> VwSysSchemaInWorkspaceBySysWorkspace { get; set; }
		[CProperty(Association ="VwSysSqlScriptInPackage:SysWorkspaceId")]
		public virtual ICollection<VwSysSqlScriptInPackage> VwSysSqlScriptInPackageBySysWorkspace { get; set; }
		[CProperty(Association ="VwWebServiceV2:SysWorkspaceId")]
		public virtual ICollection<VwWebServiceV2> VwWebServiceV2BySysWorkspace { get; set; }
		[CProperty(Association ="VwWorkspaceObjects:SysWorkspaceId")]
		public virtual ICollection<VwWorkspaceObjects> VwWorkspaceObjectsBySysWorkspace { get; set; }
		#endregion
	}
}
