using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysSchemaInWorkspace")]
	public class VwSysSchemaInWorkspace : BaseEntity
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
		private bool _NeedInstall;
		[CProperty(ColumnPath ="NeedInstall")]
		public bool NeedInstall
		{
			get{return _NeedInstall;}
			set
			{
				_NeedInstall = value;
				OnPropertyChanged();
			}
		}
		private bool _NeedUpdateSourceCode;
		[CProperty(ColumnPath ="NeedUpdateSourceCode")]
		public bool NeedUpdateSourceCode
		{
			get{return _NeedUpdateSourceCode;}
			set
			{
				_NeedUpdateSourceCode = value;
				OnPropertyChanged();
			}
		}
		private bool _NeedUpdateStructure;
		[CProperty(ColumnPath ="NeedUpdateStructure")]
		public bool NeedUpdateStructure
		{
			get{return _NeedUpdateStructure;}
			set
			{
				_NeedUpdateStructure = value;
				OnPropertyChanged();
			}
		}
		private Guid _PackageUId;
		[CProperty(ColumnPath ="PackageUId")]
		public Guid PackageUId
		{
			get{return _PackageUId;}
			set
			{
				_PackageUId = value;
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
		[CProperty(Association ="VwSysProcessEntity:SysSchemaId")]
		public virtual ICollection<VwSysProcessEntity> VwSysProcessEntityBySysSchema { get; set; }
		#endregion
	}
}
