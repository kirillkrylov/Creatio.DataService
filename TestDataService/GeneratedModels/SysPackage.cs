using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPackage")]
	public class SysPackage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Annotation")]
		public string Annotation { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Essential")]
		public bool Essential { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InstallType")]
		public int InstallType { get; set; }
		[CProperty(ColumnPath ="IsChanged")]
		public bool IsChanged { get; set; }
		[CProperty(ColumnPath ="IsLocked")]
		public bool IsLocked { get; set; }
		[CProperty(ColumnPath ="Maintainer")]
		public string Maintainer { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RepositoryRevisionNumber")]
		public int RepositoryRevisionNumber { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		[CProperty(ColumnPath ="UId")]
		public Guid UId { get; set; }
		[CProperty(ColumnPath ="Version")]
		public string Version { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysInstalledPackageData:SysPackageId")]
		public virtual ICollection<SysInstalledPackageData> SysInstalledPackageDataBySysPackage { get; set; }
		[CProperty(Association ="SysLocalizableValue:SysPackageId")]
		public virtual ICollection<SysLocalizableValue> SysLocalizableValueBySysPackage { get; set; }
		[CProperty(Association ="SysPackageHierarchy:BaseSysPackageId")]
		public virtual ICollection<SysPackageHierarchy> SysPackageHierarchyByBaseSysPackage { get; set; }
		[CProperty(Association ="SysPackageHierarchy:SysPackageId")]
		public virtual ICollection<SysPackageHierarchy> SysPackageHierarchyBySysPackage { get; set; }
		[CProperty(Association ="SysPackageHierarchy:DependOnPackageId")]
		public virtual ICollection<SysPackageHierarchy> SysPackageHierarchyByDependOnPackage { get; set; }
		[CProperty(Association ="SysPackageInInstalledApp:SysPackageId")]
		public virtual ICollection<SysPackageInInstalledApp> SysPackageInInstalledAppBySysPackage { get; set; }
		[CProperty(Association ="SysPackageResourceChecksum:SysPackageId")]
		public virtual ICollection<SysPackageResourceChecksum> SysPackageResourceChecksumBySysPackage { get; set; }
		[CProperty(Association ="SysSchema:SysPackageId")]
		public virtual ICollection<SysSchema> SysSchemaBySysPackage { get; set; }
		[CProperty(Association ="VwProcessLib:SysPackageId")]
		public virtual ICollection<VwProcessLib> VwProcessLibBySysPackage { get; set; }
		[CProperty(Association ="VwSysClientUnitSchema:SysPackageId")]
		public virtual ICollection<VwSysClientUnitSchema> VwSysClientUnitSchemaBySysPackage { get; set; }
		[CProperty(Association ="VwSysClientUnitSchemaInPackage:SysPackageId")]
		public virtual ICollection<VwSysClientUnitSchemaInPackage> VwSysClientUnitSchemaInPackageBySysPackage { get; set; }
		[CProperty(Association ="VwSysDcmLib:PackageId")]
		public virtual ICollection<VwSysDcmLib> VwSysDcmLibByPackage { get; set; }
		[CProperty(Association ="VwSysEntitySchemaInPackage:SysPackageId")]
		public virtual ICollection<VwSysEntitySchemaInPackage> VwSysEntitySchemaInPackageBySysPackage { get; set; }
		[CProperty(Association ="VwSysEntitySchemaInWorkspace:SysPackageId")]
		public virtual ICollection<VwSysEntitySchemaInWorkspace> VwSysEntitySchemaInWorkspaceBySysPackage { get; set; }
		[CProperty(Association ="VwSysPageSchemaInWorkspace:SysPackageId")]
		public virtual ICollection<VwSysPageSchemaInWorkspace> VwSysPageSchemaInWorkspaceBySysPackage { get; set; }
		[CProperty(Association ="VwSysProcess:SysPackageId")]
		public virtual ICollection<VwSysProcess> VwSysProcessBySysPackage { get; set; }
		[CProperty(Association ="VwSysSchemaInfo:SysPackageId")]
		public virtual ICollection<VwSysSchemaInfo> VwSysSchemaInfoBySysPackage { get; set; }
		[CProperty(Association ="VwSysSchemaInPackage:SysPackageId")]
		public virtual ICollection<VwSysSchemaInPackage> VwSysSchemaInPackageBySysPackage { get; set; }
		[CProperty(Association ="VwSysSchemaInWorkspace:SysPackageId")]
		public virtual ICollection<VwSysSchemaInWorkspace> VwSysSchemaInWorkspaceBySysPackage { get; set; }
		[CProperty(Association ="VwSysSqlScriptInPackage:SysPackageId")]
		public virtual ICollection<VwSysSqlScriptInPackage> VwSysSqlScriptInPackageBySysPackage { get; set; }
		[CProperty(Association ="VwWebServiceV2:SysPackageId")]
		public virtual ICollection<VwWebServiceV2> VwWebServiceV2BySysPackage { get; set; }
		#endregion
	}
}
