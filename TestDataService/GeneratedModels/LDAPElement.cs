using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LDAPElement")]
	public class LDAPElement : BaseEntity
	{
		#region Values
		private string _Company;
		[CProperty(ColumnPath ="Company")]
		public string Company
		{
			get{return _Company;}
			set
			{
				_Company = value;
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
		private string _Email;
		[CProperty(ColumnPath ="Email")]
		public string Email
		{
			get{return _Email;}
			set
			{
				_Email = value;
				OnPropertyChanged();
			}
		}
		private string _FullName;
		[CProperty(ColumnPath ="FullName")]
		public string FullName
		{
			get{return _FullName;}
			set
			{
				_FullName = value;
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
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
				OnPropertyChanged();
			}
		}
		private string _JobTitle;
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle
		{
			get{return _JobTitle;}
			set
			{
				_JobTitle = value;
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
		private string _Phone;
		[CProperty(ColumnPath ="Phone")]
		public string Phone
		{
			get{return _Phone;}
			set
			{
				_Phone = value;
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
		private int _Type;
		[CProperty(ColumnPath ="Type")]
		public int Type
		{
			get{return _Type;}
			set
			{
				_Type = value;
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
		[CProperty(Association ="LDAPUserInLDAPGroup:LDAPUserId")]
		public virtual ICollection<LDAPUserInLDAPGroup> LDAPUserInLDAPGroupByLDAPUser { get; set; }
		[CProperty(Association ="LDAPUserInLDAPGroup:LDAPGroupId")]
		public virtual ICollection<LDAPUserInLDAPGroup> LDAPUserInLDAPGroupByLDAPGroup { get; set; }
		[CProperty(Association ="SysAdminUnit:LDAPElementId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByLDAPElement { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:LDAPElementId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByLDAPElement { get; set; }
		[CProperty(Association ="VwSysAdminUnit:LDAPElementId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByLDAPElement { get; set; }
		#endregion
	}
}
