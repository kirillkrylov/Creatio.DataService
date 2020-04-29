using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysSchema")]
	public class SysSchema : BaseEntity
	{
		#region Values
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
				OnPropertyChanged();
			}
		}
		private string _Checksum;
		[CProperty(ColumnPath ="Checksum")]
		public string Checksum
		{
			get{return _Checksum;}
			set
			{
				_Checksum = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ClientContentModifiedOn;
		[CProperty(ColumnPath ="ClientContentModifiedOn")]
		public DateTime ClientContentModifiedOn
		{
			get{return _ClientContentModifiedOn;}
			set
			{
				_ClientContentModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private bool _DenyExtending;
		[CProperty(ColumnPath ="DenyExtending")]
		public bool DenyExtending
		{
			get{return _DenyExtending;}
			set
			{
				_DenyExtending = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private byte[] _Descriptor;
		[CProperty(ColumnPath ="Descriptor")]
		public byte[] Descriptor
		{
			get{return _Descriptor;}
			set
			{
				_Descriptor = value;
				OnPropertyChanged();
			}
		}
		private bool _ExtendParent;
		[CProperty(ColumnPath ="ExtendParent")]
		public bool ExtendParent
		{
			get{return _ExtendParent;}
			set
			{
				_ExtendParent = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private bool _IncludeDependenciesSource;
		[CProperty(ColumnPath ="IncludeDependenciesSource")]
		public bool IncludeDependenciesSource
		{
			get{return _IncludeDependenciesSource;}
			set
			{
				_IncludeDependenciesSource = value;
				OnPropertyChanged();
			}
		}
		private bool _IsChanged;
		[CProperty(ColumnPath ="IsChanged")]
		public bool IsChanged
		{
			get{return _IsChanged;}
			set
			{
				_IsChanged = value;
				OnPropertyChanged();
			}
		}
		private bool _IsLocked;
		[CProperty(ColumnPath ="IsLocked")]
		public bool IsLocked
		{
			get{return _IsLocked;}
			set
			{
				_IsLocked = value;
				OnPropertyChanged();
			}
		}
		private bool _IsNetStandard;
		[CProperty(ColumnPath ="IsNetStandard")]
		public bool IsNetStandard
		{
			get{return _IsNetStandard;}
			set
			{
				_IsNetStandard = value;
				OnPropertyChanged();
			}
		}
		private string _LastError;
		[CProperty(ColumnPath ="LastError")]
		public string LastError
		{
			get{return _LastError;}
			set
			{
				_LastError = value;
				OnPropertyChanged();
			}
		}
		private Guid _LockedById;
		[CProperty(ColumnPath ="LockedById")]
		public Guid LockedById
		{
			get{return _LockedById;}
			set
			{
				_LockedById = value;
				OnPropertyChanged();
			}
		}
		private string _ManagerName;
		[CProperty(ColumnPath ="ManagerName")]
		public string ManagerName
		{
			get{return _ManagerName;}
			set
			{
				_ManagerName = value;
				OnPropertyChanged();
			}
		}
		private byte[] _MetaData;
		[CProperty(ColumnPath ="MetaData")]
		public byte[] MetaData
		{
			get{return _MetaData;}
			set
			{
				_MetaData = value;
				OnPropertyChanged();
			}
		}
		private DateTime _MetaDataModifiedOn;
		[CProperty(ColumnPath ="MetaDataModifiedOn")]
		public DateTime MetaDataModifiedOn
		{
			get{return _MetaDataModifiedOn;}
			set
			{
				_MetaDataModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StructureModifiedOn;
		[CProperty(ColumnPath ="StructureModifiedOn")]
		public DateTime StructureModifiedOn
		{
			get{return _StructureModifiedOn;}
			set
			{
				_StructureModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysPackageId;
		[CProperty(ColumnPath ="SysPackageId")]
		public Guid SysPackageId
		{
			get{return _SysPackageId;}
			set
			{
				_SysPackageId = value;
				OnPropertyChanged();
			}
		}
		private Guid _UId;
		[CProperty(ColumnPath ="UId")]
		public Guid UId
		{
			get{return _UId;}
			set
			{
				_UId = value;
				OnPropertyChanged();
			}
		}
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
		[CProperty(Association ="GameRewardType:RewardProcessId")]
		public virtual ICollection<GameRewardType> GameRewardTypeByRewardProcess { get; set; }
		[CProperty(Association ="ProcessInIntegration:BusinessProcessId")]
		public virtual ICollection<ProcessInIntegration> ProcessInIntegrationByBusinessProcess { get; set; }
		[CProperty(Association ="RecruitmentInStage:SysSchemaId")]
		public virtual ICollection<RecruitmentInStage> RecruitmentInStageBySysSchema { get; set; }
		[CProperty(Association ="SupCaseScoringGroup:SupSysSchemaId")]
		public virtual ICollection<SupCaseScoringGroup> SupCaseScoringGroupBySupSysSchema { get; set; }
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
