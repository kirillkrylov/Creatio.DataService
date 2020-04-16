using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsOrderExpense")]
	public class TsOrderExpense : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountComment")]
		public string AccountComment { get; set; }
		[CProperty(ColumnPath ="AccoutVisaId")]
		public Guid AccoutVisaId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="CalculateMethodId")]
		public Guid CalculateMethodId { get; set; }
		[CProperty(ColumnPath ="ClientId")]
		public Guid ClientId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="ExpenseDate")]
		public DateTime ExpenseDate { get; set; }
		[CProperty(ColumnPath ="FinanceComment")]
		public string FinanceComment { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="InvoiceOwnerId")]
		public Guid InvoiceOwnerId { get; set; }
		[CProperty(ColumnPath ="InvoicePaidOn")]
		public DateTime InvoicePaidOn { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Note")]
		public string Note { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountPlan")]
		public decimal PrimaryAmountPlan { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Products")]
		public string Products { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="Account:ClientId")]
		public Account Client { get; set; }
		[CProperty(Navigation ="AccountExpenseVisa:AccoutVisaId")]
		public AccountExpenseVisa AccoutVisa { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:InvoiceOwnerId")]
		public Contact InvoiceOwner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="FormulasForCalculatingCosts:CalculateMethodId")]
		public FormulasForCalculatingCosts CalculateMethod { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="TsOrderExpenseStatus:StatusId")]
		public TsOrderExpenseStatus Status { get; set; }
		[CProperty(Navigation ="TsOrderExpenseType:TypeId")]
		public TsOrderExpenseType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TsOrderExpenseFile:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseFile> TsOrderExpenseFileByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseHistory:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseHistory> TsOrderExpenseHistoryByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseInFolder:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseInFolder> TsOrderExpenseInFolderByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseInTag:EntityId")]
		public virtual ICollection<TsOrderExpenseInTag> TsOrderExpenseInTagByEntity { get; set; }
		[CProperty(Association ="TsOrderExpenseProduct:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseProduct> TsOrderExpenseProductByTsOrderExpense { get; set; }
		[CProperty(Association ="TsOrderExpenseVisa:TsOrderExpenseId")]
		public virtual ICollection<TsOrderExpenseVisa> TsOrderExpenseVisaByTsOrderExpense { get; set; }
		[CProperty(Association ="VwOrderExpenseProduct:TsOrderExpenseId")]
		public virtual ICollection<VwOrderExpenseProduct> VwOrderExpenseProductByTsOrderExpense { get; set; }
		[CProperty(Association ="VwPortalOrderExpenseProduct:TsOrderExpenseId")]
		public virtual ICollection<VwPortalOrderExpenseProduct> VwPortalOrderExpenseProductByTsOrderExpense { get; set; }
		#endregion
	}
}
