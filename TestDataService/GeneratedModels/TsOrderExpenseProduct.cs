using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsOrderExpenseProduct")]
	public class TsOrderExpenseProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="CalculateExpense")]
		public bool CalculateExpense { get; set; }
		[CProperty(ColumnPath ="CalculateMethodId")]
		public Guid CalculateMethodId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceProductId")]
		public Guid InvoiceProductId { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TsOrderExpenseId")]
		public Guid TsOrderExpenseId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FormulasForCalculatingCostsProduct:CalculateMethodId")]
		public FormulasForCalculatingCostsProduct CalculateMethod { get; set; }
		[CProperty(Navigation ="InvoiceProduct:InvoiceProductId")]
		public InvoiceProduct InvoiceProduct { get; set; }
		[CProperty(Navigation ="OrderProduct:OrderProductId")]
		public OrderProduct OrderProduct { get; set; }
		[CProperty(Navigation ="TsOrderExpense:TsOrderExpenseId")]
		public TsOrderExpense TsOrderExpense { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwOrderExpenseProduct:TsOrderExpenseProductId")]
		public virtual ICollection<VwOrderExpenseProduct> VwOrderExpenseProductByTsOrderExpenseProduct { get; set; }
		#endregion
	}
}
