using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSspAdminUnit")]
	public class VwSspAdminUnit : BaseEntity
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
		private string _LicenseName;
		[CProperty(ColumnPath ="LicenseName")]
		public string LicenseName
		{
			get{return _LicenseName;}
			set
			{
				_LicenseName = value;
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
		[CProperty(Navigation ="SysAdminUnitType:SysAdminUnitTypeId")]
		public SysAdminUnitType SysAdminUnitType { get; set; }
		[CProperty(Navigation ="SysCulture:SysCultureId")]
		public SysCulture SysCulture { get; set; }
		[CProperty(Navigation ="VwSspAdminUnit:ParentRoleId")]
		public VwSspAdminUnit ParentRole { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwSspAdminUnit:ParentRoleId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByParentRole { get; set; }
		#endregion
	}
}
