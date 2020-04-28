using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountStatus")]
	public class AccountStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FirstOpportunity")]
		public bool FirstOpportunity { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
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
		[CProperty(Association ="Account:StatusId")]
		public virtual ICollection<Account> AccountByStatus { get; set; }
		[CProperty(Association ="AccountStageHistory:AccountStatusId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByAccountStatus { get; set; }
		[CProperty(Association ="GlbCustomer:GlbCustomerStatusId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbCustomerStatus { get; set; }
		[CProperty(Association ="VwAccountStatusHistory:OldStatusId")]
		public virtual ICollection<VwAccountStatusHistory> VwAccountStatusHistoryByOldStatus { get; set; }
		[CProperty(Association ="VwAccountStatusHistory:NewStatusId")]
		public virtual ICollection<VwAccountStatusHistory> VwAccountStatusHistoryByNewStatus { get; set; }
		#endregion
	}
}
