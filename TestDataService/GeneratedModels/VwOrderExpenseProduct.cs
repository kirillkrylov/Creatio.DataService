using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOrderExpenseProduct")]
	public class VwOrderExpenseProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OrderProductName")]
		public string OrderProductName { get; set; }
		[CProperty(ColumnPath ="OrderProductTotalAmount")]
		public decimal OrderProductTotalAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TsOrderExpenseId")]
		public Guid TsOrderExpenseId { get; set; }
		[CProperty(ColumnPath ="TsOrderExpenseProductId")]
		public Guid TsOrderExpenseProductId { get; set; }
		[CProperty(ColumnPath ="UseInExpense")]
		public bool UseInExpense { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="TsOrderExpense:TsOrderExpenseId")]
		public TsOrderExpense TsOrderExpense { get; set; }
		[CProperty(Navigation ="TsOrderExpenseProduct:TsOrderExpenseProductId")]
		public TsOrderExpenseProduct TsOrderExpenseProduct { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
