using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Fund")]
	public class Fund : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="FundTypeId")]
		public Guid FundTypeId { get; set; }
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
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FundType:FundTypeId")]
		public FundType FundType { get; set; }
		[CProperty(Navigation ="Partnership:PartnershipId")]
		public Partnership Partnership { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="MktgActivity:FundId")]
		public virtual ICollection<MktgActivity> MktgActivityByFund { get; set; }
		[CProperty(Association ="PRMTransaction:FundId")]
		public virtual ICollection<PRMTransaction> PRMTransactionByFund { get; set; }
		[CProperty(Association ="PRMTransactionHistory:FundId")]
		public virtual ICollection<PRMTransactionHistory> PRMTransactionHistoryByFund { get; set; }
		#endregion
	}
}
