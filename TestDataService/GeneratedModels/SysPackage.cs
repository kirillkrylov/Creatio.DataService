using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysPackage")]
	public class SysPackage : BaseEntity
	{
		#region Values
		private string _Annotation;
		[CProperty(ColumnPath ="Annotation")]
		public string Annotation
		{
			get{return _Annotation;}
			set
			{
				_Annotation = value;
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
		private bool _Essential;
		[CProperty(ColumnPath ="Essential")]
		public bool Essential
		{
			get{return _Essential;}
			set
			{
				_Essential = value;
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
		private int _InstallType;
		[CProperty(ColumnPath ="InstallType")]
		public int InstallType
		{
			get{return _InstallType;}
			set
			{
				_InstallType = value;
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
		private string _Maintainer;
		[CProperty(ColumnPath ="Maintainer")]
		public string Maintainer
		{
			get{return _Maintainer;}
			set
			{
				_Maintainer = value;
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
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		private int _RepositoryRevisionNumber;
		[CProperty(ColumnPath ="RepositoryRevisionNumber")]
		public int RepositoryRevisionNumber
		{
			get{return _RepositoryRevisionNumber;}
			set
			{
				_RepositoryRevisionNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysWorkspaceId;
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId
		{
			get{return _SysWorkspaceId;}
			set
			{
				_SysWorkspaceId = value;
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
		private string _Version;
		[CProperty(ColumnPath ="Version")]
		public string Version
		{
			get{return _Version;}
			set
			{
				_Version = value;
				OnPropertyChanged();
			}
		}
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
