using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysWorkspace")]
	public class SysWorkspace : BaseEntity
	{
		#region Values
		private byte[] _AssemblyData;
		[CProperty(ColumnPath ="AssemblyData")]
		public byte[] AssemblyData
		{
			get{return _AssemblyData;}
			set
			{
				_AssemblyData = value;
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
		private bool _IsDefault;
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault
		{
			get{return _IsDefault;}
			set
			{
				_IsDefault = value;
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
		private int _Number;
		[CProperty(ColumnPath ="Number")]
		public int Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
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
		private string _RepositoryUri;
		[CProperty(ColumnPath ="RepositoryUri")]
		public string RepositoryUri
		{
			get{return _RepositoryUri;}
			set
			{
				_RepositoryUri = value;
				OnPropertyChanged();
			}
		}
		private int _Version;
		[CProperty(ColumnPath ="Version")]
		public int Version
		{
			get{return _Version;}
			set
			{
				_Version = value;
				OnPropertyChanged();
			}
		}
		private string _WorkingCopyPath;
		[CProperty(ColumnPath ="WorkingCopyPath")]
		public string WorkingCopyPath
		{
			get{return _WorkingCopyPath;}
			set
			{
				_WorkingCopyPath = value;
				OnPropertyChanged();
			}
		}
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
