using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityCategory")]
	public class OpportunityCategory : BaseEntity
	{
		#region Values
		private Guid _AccountCategoryId;
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId
		{
			get{return _AccountCategoryId;}
			set
			{
				_AccountCategoryId = value;
				OnPropertyChanged();
			}
		}
		private decimal _BudgetMax;
		[CProperty(ColumnPath ="BudgetMax")]
		public decimal BudgetMax
		{
			get{return _BudgetMax;}
			set
			{
				_BudgetMax = value;
				OnPropertyChanged();
			}
		}
		private decimal _BudgetMin;
		[CProperty(ColumnPath ="BudgetMin")]
		public decimal BudgetMin
		{
			get{return _BudgetMin;}
			set
			{
				_BudgetMin = value;
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
		private int _LicenseMax;
		[CProperty(ColumnPath ="LicenseMax")]
		public int LicenseMax
		{
			get{return _LicenseMax;}
			set
			{
				_LicenseMax = value;
				OnPropertyChanged();
			}
		}
		private int _LicenseMin;
		[CProperty(ColumnPath ="LicenseMin")]
		public int LicenseMin
		{
			get{return _LicenseMin;}
			set
			{
				_LicenseMin = value;
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
				OnPropertyChanged();
			}
		}
		private int _NumberOfUsersMax;
		[CProperty(ColumnPath ="NumberOfUsersMax")]
		public int NumberOfUsersMax
		{
			get{return _NumberOfUsersMax;}
			set
			{
				_NumberOfUsersMax = value;
				OnPropertyChanged();
			}
		}
		private int _NumberOfUsersMin;
		[CProperty(ColumnPath ="NumberOfUsersMin")]
		public int NumberOfUsersMin
		{
			get{return _NumberOfUsersMin;}
			set
			{
				_NumberOfUsersMin = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountCategory:AccountCategoryId")]
		public AccountCategory AccountCategory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountStageHistory:AccountCategoryId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByAccountCategory { get; set; }
		[CProperty(Association ="Lead:CategoryId")]
		public virtual ICollection<Lead> LeadByCategory { get; set; }
		[CProperty(Association ="Opportunity:CategoryId")]
		public virtual ICollection<Opportunity> OpportunityByCategory { get; set; }
		[CProperty(Association ="Project:CategoryId")]
		public virtual ICollection<Project> ProjectByCategory { get; set; }
		[CProperty(Association ="VwLead:CategoryId")]
		public virtual ICollection<VwLead> VwLeadByCategory { get; set; }
		#endregion
	}
}
