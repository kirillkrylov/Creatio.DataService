using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountCategory")]
	public class AccountCategory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AnnualRevenueBC")]
		public decimal AnnualRevenueBC { get; set; }
		[CProperty(ColumnPath ="Assets")]
		public decimal Assets { get; set; }
		[CProperty(ColumnPath ="CoefficientOfNumberUsers")]
		public decimal CoefficientOfNumberUsers { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ExactNoOfEmployees")]
		public int ExactNoOfEmployees { get; set; }
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
		[CProperty(ColumnPath ="Priority")]
		public int Priority { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
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
