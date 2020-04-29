using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwGroupSysAdminUnit")]
	public class VwGroupSysAdminUnit : BaseEntity
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
		private Guid _AdminUnitCategoryId;
		[CProperty(ColumnPath ="AdminUnitCategoryId")]
		public Guid AdminUnitCategoryId
		{
			get{return _AdminUnitCategoryId;}
			set
			{
				_AdminUnitCategoryId = value;
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
		private int _LoginAttemptCount;
		[CProperty(ColumnPath ="LoginAttemptCount")]
		public int LoginAttemptCount
		{
			get{return _LoginAttemptCount;}
			set
			{
				_LoginAttemptCount = value;
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
		private Guid _PortalAccountId;
		[CProperty(ColumnPath ="PortalAccountId")]
		public Guid PortalAccountId
		{
			get{return _PortalAccountId;}
			set
			{
				_PortalAccountId = value;
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
		private string _SourceControlLogin;
		[CProperty(ColumnPath ="SourceControlLogin")]
		public string SourceControlLogin
		{
			get{return _SourceControlLogin;}
			set
			{
				_SourceControlLogin = value;
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
		private int _SysAdminUnitTypeValue;
		[CProperty(ColumnPath ="SysAdminUnitTypeValue")]
		public int SysAdminUnitTypeValue
		{
			get{return _SysAdminUnitTypeValue;}
			set
			{
				_SysAdminUnitTypeValue = value;
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
		private string _TimeZoneId;
		[CProperty(ColumnPath ="TimeZoneId")]
		public string TimeZoneId
		{
			get{return _TimeZoneId;}
			set
			{
				_TimeZoneId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _UnblockTime;
		[CProperty(ColumnPath ="UnblockTime")]
		public DateTime UnblockTime
		{
			get{return _UnblockTime;}
			set
			{
				_UnblockTime = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:PortalAccountId")]
		public Account PortalAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="LDAPElement:LDAPElementId")]
		public LDAPElement LDAPElement { get; set; }
		[CProperty(Navigation ="SysAdminUnitCategory:AdminUnitCategoryId")]
		public SysAdminUnitCategory AdminUnitCategory { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		[CProperty(Navigation ="SysLanguage:DateTimeFormatId")]
		public SysLanguage DateTimeFormat { get; set; }
		[CProperty(Navigation ="SysModule:HomePageId")]
		public SysModule HomePage { get; set; }
		[CProperty(Navigation ="VwGroupSysAdminUnit:ParentRoleId")]
		public VwGroupSysAdminUnit ParentRole { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwGroupSysAdminUnit:ParentRoleId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByParentRole { get; set; }
		#endregion
	}
}
