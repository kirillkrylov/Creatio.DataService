using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountAnnualRevenue")]
	public class AccountAnnualRevenue : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FromBaseCurrency")]
		public decimal FromBaseCurrency { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="ToBaseCurrency")]
		public decimal ToBaseCurrency { get; set; }
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
