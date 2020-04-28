using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityCategory")]
	public class OpportunityCategory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId { get; set; }
		[CProperty(ColumnPath ="BudgetMax")]
		public decimal BudgetMax { get; set; }
		[CProperty(ColumnPath ="BudgetMin")]
		public decimal BudgetMin { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="LicenseMax")]
		public int LicenseMax { get; set; }
		[CProperty(ColumnPath ="LicenseMin")]
		public int LicenseMin { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="NumberOfUsersMax")]
		public int NumberOfUsersMax { get; set; }
		[CProperty(ColumnPath ="NumberOfUsersMin")]
		public int NumberOfUsersMin { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
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
