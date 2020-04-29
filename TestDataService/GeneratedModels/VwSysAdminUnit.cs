using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysAdminUnit")]
	public class VwSysAdminUnit : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private bool _Active;
		[CProperty(ColumnPath ="Active")]
		public bool Active
		{
			get{return _Active;}
			set
			{
				_Active = value;
				OnPropertyChanged();
			}
		}
		private int _ConnectionType;
		[CProperty(ColumnPath ="ConnectionType")]
		public int ConnectionType
		{
			get{return _ConnectionType;}
			set
			{
				_ConnectionType = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private Guid _DateTimeFormatId;
		[CProperty(ColumnPath ="DateTimeFormatId")]
		public Guid DateTimeFormatId
		{
			get{return _DateTimeFormatId;}
			set
			{
				_DateTimeFormatId = value;
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
		private bool _ForceChangePassword;
		[CProperty(ColumnPath ="ForceChangePassword")]
		public bool ForceChangePassword
		{
			get{return _ForceChangePassword;}
			set
			{
				_ForceChangePassword = value;
				OnPropertyChanged();
			}
		}
		private Guid _HomePageId;
		[CProperty(ColumnPath ="HomePageId")]
		public Guid HomePageId
		{
			get{return _HomePageId;}
			set
			{
				_HomePageId = value;
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
		private bool _IsDirectoryEntry;
		[CProperty(ColumnPath ="IsDirectoryEntry")]
		public bool IsDirectoryEntry
		{
			get{return _IsDirectoryEntry;}
			set
			{
				_IsDirectoryEntry = value;
				OnPropertyChanged();
			}
		}
		private Guid _LDAPElementId;
		[CProperty(ColumnPath ="LDAPElementId")]
		public Guid LDAPElementId
		{
			get{return _LDAPElementId;}
			set
			{
				_LDAPElementId = value;
				OnPropertyChanged();
			}
		}
		private string _LDAPEntry;
		[CProperty(ColumnPath ="LDAPEntry")]
		public string LDAPEntry
		{
			get{return _LDAPEntry;}
			set
			{
				_LDAPEntry = value;
				OnPropertyChanged();
			}
		}
		private string _LDAPEntryDN;
		[CProperty(ColumnPath ="LDAPEntryDN")]
		public string LDAPEntryDN
		{
			get{return _LDAPEntryDN;}
			set
			{
				_LDAPEntryDN = value;
				OnPropertyChanged();
			}
		}
		private string _LDAPEntryId;
		[CProperty(ColumnPath ="LDAPEntryId")]
		public string LDAPEntryId
		{
			get{return _LDAPEntryId;}
			set
			{
				_LDAPEntryId = value;
				OnPropertyChanged();
			}
		}
		private bool _LoggedIn;
		[CProperty(ColumnPath ="LoggedIn")]
		public bool LoggedIn
		{
			get{return _LoggedIn;}
			set
			{
				_LoggedIn = value;
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
		private Guid _ParentRoleId;
		[CProperty(ColumnPath ="ParentRoleId")]
		public Guid ParentRoleId
		{
			get{return _ParentRoleId;}
			set
			{
				_ParentRoleId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PasswordExpireDate;
		[CProperty(ColumnPath ="PasswordExpireDate")]
		public DateTime PasswordExpireDate
		{
			get{return _PasswordExpireDate;}
			set
			{
				_PasswordExpireDate = value;
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
		private int _SessionTimeout;
		[CProperty(ColumnPath ="SessionTimeout")]
		public int SessionTimeout
		{
			get{return _SessionTimeout;}
			set
			{
				_SessionTimeout = value;
				OnPropertyChanged();
			}
		}
		private bool _SynchronizeWithLDAP;
		[CProperty(ColumnPath ="SynchronizeWithLDAP")]
		public bool SynchronizeWithLDAP
		{
			get{return _SynchronizeWithLDAP;}
			set
			{
				_SynchronizeWithLDAP = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysAdminUnitId;
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId
		{
			get{return _SysAdminUnitId;}
			set
			{
				_SysAdminUnitId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysAdminUnitTypeId;
		[CProperty(ColumnPath ="SysAdminUnitTypeId")]
		public Guid SysAdminUnitTypeId
		{
			get{return _SysAdminUnitTypeId;}
			set
			{
				_SysAdminUnitTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysCultureId;
		[CProperty(ColumnPath ="SysCultureId")]
		public Guid SysCultureId
		{
			get{return _SysCultureId;}
			set
			{
				_SysCultureId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TimeZoneId;
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId
		{
			get{return _TimeZoneId;}
			set
			{
				_TimeZoneId = value;
				OnPropertyChanged();
			}
		}
		private Guid _UserConnectionTypeId;
		[CProperty(ColumnPath ="UserConnectionTypeId")]
		public Guid UserConnectionTypeId
		{
			get{return _UserConnectionTypeId;}
			set
			{
				_UserConnectionTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="ConnectionType:UserConnectionTypeId")]
		public ConnectionType UserConnectionType { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="LDAPElement:LDAPElementId")]
		public LDAPElement LDAPElement { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnitType:SysAdminUnitTypeId")]
		public SysAdminUnitType SysAdminUnitType { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		[CProperty(Navigation ="SysLanguage:DateTimeFormatId")]
		public SysLanguage DateTimeFormat { get; set; }
		[CProperty(Navigation ="SysModule:HomePageId")]
		public SysModule HomePage { get; set; }
		[CProperty(Navigation ="TimeZone:TimeZoneId")]
		public TimeZone TimeZone { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:ParentRoleId")]
		public VwSysAdminUnit ParentRole { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="IQAddRight:IQUserRoleId")]
		public virtual ICollection<IQAddRight> IQAddRightByIQUserRole { get; set; }
		[CProperty(Association ="IQGrantedRight:IQGrantorSysAdminUnitId")]
		public virtual ICollection<IQGrantedRight> IQGrantedRightByIQGrantorSysAdminUnit { get; set; }
		[CProperty(Association ="IQGrantedRight:IQGranteeSysAdminUnitId")]
		public virtual ICollection<IQGrantedRight> IQGrantedRightByIQGranteeSysAdminUnit { get; set; }
		[CProperty(Association ="IQLimitRight:IQUserRoleId")]
		public virtual ICollection<IQLimitRight> IQLimitRightByIQUserRole { get; set; }
		[CProperty(Association ="SysAdminUnitGrantedRight:GrantorSysAdminUnitId")]
		public virtual ICollection<SysAdminUnitGrantedRight> SysAdminUnitGrantedRightByGrantorSysAdminUnit { get; set; }
		[CProperty(Association ="SysAdminUnitGrantedRight:GranteeSysAdminUnitId")]
		public virtual ICollection<SysAdminUnitGrantedRight> SysAdminUnitGrantedRightByGranteeSysAdminUnit { get; set; }
		[CProperty(Association ="SysEntitySchemaOperationRight:SysAdminUnitId")]
		public virtual ICollection<SysEntitySchemaOperationRight> SysEntitySchemaOperationRightBySysAdminUnit { get; set; }
		[CProperty(Association ="SysExtServiceOperationRight:SysAdminUnitId")]
		public virtual ICollection<SysExtServiceOperationRight> SysExtServiceOperationRightBySysAdminUnit { get; set; }
		[CProperty(Association ="VwSysAdminUnit:ParentRoleId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByParentRole { get; set; }
		[CProperty(Association ="VwSysEntitySchemaColumnRight:SysAdminUnitId")]
		public virtual ICollection<VwSysEntitySchemaColumnRight> VwSysEntitySchemaColumnRightBySysAdminUnit { get; set; }
		#endregion
	}
}
