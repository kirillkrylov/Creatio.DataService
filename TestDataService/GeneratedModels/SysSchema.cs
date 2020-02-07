using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysSchema")]
	public class SysSchema : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="Checksum")]
		public string Checksum { get; set; }
		[CProperty(ColumnPath ="ClientContentModifiedOn")]
		public DateTime ClientContentModifiedOn { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DenyExtending")]
		public bool DenyExtending { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Descriptor")]
		public byte[] Descriptor { get; set; }
		[CProperty(ColumnPath ="ExtendParent")]
		public bool ExtendParent { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IncludeDependenciesSource")]
		public bool IncludeDependenciesSource { get; set; }
		[CProperty(ColumnPath ="IsChanged")]
		public bool IsChanged { get; set; }
		[CProperty(ColumnPath ="IsLocked")]
		public bool IsLocked { get; set; }
		[CProperty(ColumnPath ="IsNetStandard")]
		public bool IsNetStandard { get; set; }
		[CProperty(ColumnPath ="LastError")]
		public string LastError { get; set; }
		[CProperty(ColumnPath ="LockedById")]
		public Guid LockedById { get; set; }
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
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StructureModifiedOn")]
		public DateTime StructureModifiedOn { get; set; }
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId { get; set; }
		[CProperty(ColumnPath ="UId")]
		public Guid UId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:LockedById")]
		public SysAdminUnit LockedBy { get; set; }
		[CProperty(Navigation ="SysPackage:SysPackageId")]
		public SysPackage SysPackage { get; set; }
		[CProperty(Navigation ="SysSchema:ParentId")]
		public SysSchema Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Attribute:OwnerSchemaId")]
		public virtual ICollection<Attribute> AttributeByOwnerSchema { get; set; }
		[CProperty(Association ="Attribute:ReferenceSchemaId")]
		public virtual ICollection<Attribute> AttributeByReferenceSchema { get; set; }
		[CProperty(Association ="AttributeReferenceSchema:ReferenceSchemaId")]
		public virtual ICollection<AttributeReferenceSchema> AttributeReferenceSchemaByReferenceSchema { get; set; }
		[CProperty(Association ="SysClientUnitSchemaDependency:SysSchemaId")]
		public virtual ICollection<SysClientUnitSchemaDependency> SysClientUnitSchemaDependencyBySysSchema { get; set; }
		[CProperty(Association ="SysClientUnitSchemaSource:SysSchemaId")]
		public virtual ICollection<SysClientUnitSchemaSource> SysClientUnitSchemaSourceBySysSchema { get; set; }
		[CProperty(Association ="SysEditPage:SysPageSchemaId")]
		public virtual ICollection<SysEditPage> SysEditPageBySysPageSchema { get; set; }
		[CProperty(Association ="SysEditPage:SysEntitySchemaId")]
		public virtual ICollection<SysEditPage> SysEditPageBySysEntitySchema { get; set; }
		[CProperty(Association ="SysEntityPrcStartEvent:ProcessSchemaId")]
		public virtual ICollection<SysEntityPrcStartEvent> SysEntityPrcStartEventByProcessSchema { get; set; }
		[CProperty(Association ="SysEntitySchemaReference:ReferenceSchemaId")]
		public virtual ICollection<SysEntitySchemaReference> SysEntitySchemaReferenceByReferenceSchema { get; set; }
		[CProperty(Association ="SysEntitySchemaReference:SysSchemaId")]
		public virtual ICollection<SysEntitySchemaReference> SysEntitySchemaReferenceBySysSchema { get; set; }
		[CProperty(Association ="SysGridPage:SysPageSchemaId")]
		public virtual ICollection<SysGridPage> SysGridPageBySysPageSchema { get; set; }
		[CProperty(Association ="SysGridPage:SysEntitySchemaId")]
		public virtual ICollection<SysGridPage> SysGridPageBySysEntitySchema { get; set; }
		[CProperty(Association ="SysInstalledPackageData:SysSchemaId")]
		public virtual ICollection<SysInstalledPackageData> SysInstalledPackageDataBySysSchema { get; set; }
		[CProperty(Association ="SysLocalizableValue:SysSchemaId")]
		public virtual ICollection<SysLocalizableValue> SysLocalizableValueBySysSchema { get; set; }
		[CProperty(Association ="SysModuleGridEditPage:SysModuleGridPageId")]
		public virtual ICollection<SysModuleGridEditPage> SysModuleGridEditPageBySysModuleGridPage { get; set; }
		[CProperty(Association ="SysModuleGridEditPage:SysEditPageSchemaId")]
		public virtual ICollection<SysModuleGridEditPage> SysModuleGridEditPageBySysEditPageSchema { get; set; }
		[CProperty(Association ="SysPackageResourceChecksum:SysSchemaId")]
		public virtual ICollection<SysPackageResourceChecksum> SysPackageResourceChecksumBySysSchema { get; set; }
		[CProperty(Association ="SysPrcActualVersion:RootVersionSchemaId")]
		public virtual ICollection<SysPrcActualVersion> SysPrcActualVersionByRootVersionSchema { get; set; }
		[CProperty(Association ="SysPrcActualVersion:ActualVersionSchemaId")]
		public virtual ICollection<SysPrcActualVersion> SysPrcActualVersionByActualVersionSchema { get; set; }
		[CProperty(Association ="SysPrcHistoryLog:SysSchemaId")]
		public virtual ICollection<SysPrcHistoryLog> SysPrcHistoryLogBySysSchema { get; set; }
		[CProperty(Association ="SysProcessData:SysSchemaId")]
		public virtual ICollection<SysProcessData> SysProcessDataBySysSchema { get; set; }
		[CProperty(Association ="SysProcessDisabled:SysSchemaId")]
		public virtual ICollection<SysProcessDisabled> SysProcessDisabledBySysSchema { get; set; }
		[CProperty(Association ="SysProcessLog:SysSchemaId")]
		public virtual ICollection<SysProcessLog> SysProcessLogBySysSchema { get; set; }
		[CProperty(Association ="SysSchema:ParentId")]
		public virtual ICollection<SysSchema> SysSchemaByParent { get; set; }
		[CProperty(Association ="SysSchemaContent:SysSchemaId")]
		public virtual ICollection<SysSchemaContent> SysSchemaContentBySysSchema { get; set; }
		[CProperty(Association ="SysSchemaProperty:SysSchemaId")]
		public virtual ICollection<SysSchemaProperty> SysSchemaPropertyBySysSchema { get; set; }
		[CProperty(Association ="VwProcessLib:ParentId")]
		public virtual ICollection<VwProcessLib> VwProcessLibByParent { get; set; }
		[CProperty(Association ="VwSysDcmLib:ParentId")]
		public virtual ICollection<VwSysDcmLib> VwSysDcmLibByParent { get; set; }
		[CProperty(Association ="VwSysEntitySchemaInWorkspace:ParentId")]
		public virtual ICollection<VwSysEntitySchemaInWorkspace> VwSysEntitySchemaInWorkspaceByParent { get; set; }
		[CProperty(Association ="VwSysPageSchemaInWorkspace:ParentId")]
		public virtual ICollection<VwSysPageSchemaInWorkspace> VwSysPageSchemaInWorkspaceByParent { get; set; }
		[CProperty(Association ="VwSysProcess:ParentId")]
		public virtual ICollection<VwSysProcess> VwSysProcessByParent { get; set; }
		[CProperty(Association ="VwSysProcessLog:SysSchemaId")]
		public virtual ICollection<VwSysProcessLog> VwSysProcessLogBySysSchema { get; set; }
		[CProperty(Association ="VwSysSchemaDataInPackage:SysSchemaId")]
		public virtual ICollection<VwSysSchemaDataInPackage> VwSysSchemaDataInPackageBySysSchema { get; set; }
		[CProperty(Association ="VwSysSchemaInfo:ParentId")]
		public virtual ICollection<VwSysSchemaInfo> VwSysSchemaInfoByParent { get; set; }
		[CProperty(Association ="VwSysSchemaInWorkspace:ParentId")]
		public virtual ICollection<VwSysSchemaInWorkspace> VwSysSchemaInWorkspaceByParent { get; set; }
		[CProperty(Association ="VwSysSSPEntitySchemaAccessList:SysSchemaId")]
		public virtual ICollection<VwSysSSPEntitySchemaAccessList> VwSysSSPEntitySchemaAccessListBySysSchema { get; set; }
		[CProperty(Association ="VwWebServiceV2:ParentId")]
		public virtual ICollection<VwWebServiceV2> VwWebServiceV2ByParent { get; set; }
		#endregion
	}
}
