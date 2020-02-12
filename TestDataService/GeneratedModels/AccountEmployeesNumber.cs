using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountEmployeesNumber")]
	public class AccountEmployeesNumber : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RangeEnd")]
		public int RangeEnd { get; set; }
		[CProperty(ColumnPath ="RangeStart")]
		public int RangeStart { get; set; }
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
		[CProperty(Association ="Account:EmployeesNumberId")]
		public virtual ICollection<Account> AccountByEmployeesNumber { get; set; }
		[CProperty(Association ="AccountStageHistory:EmployeesNumberId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByEmployeesNumber { get; set; }
		[CProperty(Association ="GlbCustomer:GlbEmployeesNumberRangeId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbEmployeesNumberRange { get; set; }
		[CProperty(Association ="Lead:EmployeesNumberId")]
		public virtual ICollection<Lead> LeadByEmployeesNumber { get; set; }
		[CProperty(Association ="LeadQualification:EmployeesNumberId")]
		public virtual ICollection<LeadQualification> LeadQualificationByEmployeesNumber { get; set; }
		[CProperty(Association ="VwLead:EmployeesNumberId")]
		public virtual ICollection<VwLead> VwLeadByEmployeesNumber { get; set; }
		#endregion
	}
}
