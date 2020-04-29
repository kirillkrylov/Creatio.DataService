using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountCategory")]
	public class AccountCategory : BaseEntity
	{
		#region Values
		private decimal _AnnualRevenueBC;
		[CProperty(ColumnPath ="AnnualRevenueBC")]
		public decimal AnnualRevenueBC
		{
			get{return _AnnualRevenueBC;}
			set
			{
				_AnnualRevenueBC = value;
				OnPropertyChanged();
			}
		}
		private decimal _Assets;
		[CProperty(ColumnPath ="Assets")]
		public decimal Assets
		{
			get{return _Assets;}
			set
			{
				_Assets = value;
				OnPropertyChanged();
			}
		}
		private decimal _CoefficientOfNumberUsers;
		[CProperty(ColumnPath ="CoefficientOfNumberUsers")]
		public decimal CoefficientOfNumberUsers
		{
			get{return _CoefficientOfNumberUsers;}
			set
			{
				_CoefficientOfNumberUsers = value;
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
		private int _ExactNoOfEmployees;
		[CProperty(ColumnPath ="ExactNoOfEmployees")]
		public int ExactNoOfEmployees
		{
			get{return _ExactNoOfEmployees;}
			set
			{
				_ExactNoOfEmployees = value;
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
		private int _Priority;
		[CProperty(ColumnPath ="Priority")]
		public int Priority
		{
			get{return _Priority;}
			set
			{
				_Priority = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:AccountCategoryId")]
		public virtual ICollection<Account> AccountByAccountCategory { get; set; }
		[CProperty(Association ="AccountStageHistory:SegmentId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryBySegment { get; set; }
		[CProperty(Association ="Lead:AccountCategoryId")]
		public virtual ICollection<Lead> LeadByAccountCategory { get; set; }
		[CProperty(Association ="LeadQualification:AccountCategoryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByAccountCategory { get; set; }
		[CProperty(Association ="OpportunityCategory:AccountCategoryId")]
		public virtual ICollection<OpportunityCategory> OpportunityCategoryByAccountCategory { get; set; }
		[CProperty(Association ="VwLead:AccountCategoryId")]
		public virtual ICollection<VwLead> VwLeadByAccountCategory { get; set; }
		#endregion
	}
}
