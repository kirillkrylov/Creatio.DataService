using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountAnnualRevenue")]
	public class AccountAnnualRevenue : BaseEntity
	{
		#region Values
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
		private decimal _FromBaseCurrency;
		[CProperty(ColumnPath ="FromBaseCurrency")]
		public decimal FromBaseCurrency
		{
			get{return _FromBaseCurrency;}
			set
			{
				_FromBaseCurrency = value;
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
		private decimal _ToBaseCurrency;
		[CProperty(ColumnPath ="ToBaseCurrency")]
		public decimal ToBaseCurrency
		{
			get{return _ToBaseCurrency;}
			set
			{
				_ToBaseCurrency = value;
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
		[CProperty(Association ="Account:AnnualRevenueId")]
		public virtual ICollection<Account> AccountByAnnualRevenue { get; set; }
		[CProperty(Association ="AccountStageHistory:AnnualRevenueId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByAnnualRevenue { get; set; }
		[CProperty(Association ="GlbCustomer:GlbAnnualRevenueRangeId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbAnnualRevenueRange { get; set; }
		[CProperty(Association ="Lead:AnnualRevenueId")]
		public virtual ICollection<Lead> LeadByAnnualRevenue { get; set; }
		[CProperty(Association ="LeadQualification:AnnualRevenueId")]
		public virtual ICollection<LeadQualification> LeadQualificationByAnnualRevenue { get; set; }
		[CProperty(Association ="VwLead:AnnualRevenueId")]
		public virtual ICollection<VwLead> VwLeadByAnnualRevenue { get; set; }
		#endregion
	}
}
