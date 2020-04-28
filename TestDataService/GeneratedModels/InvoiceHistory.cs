using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InvoiceHistory")]
	public class InvoiceHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="BaseCurrencyId")]
		public Guid BaseCurrencyId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="HistoryDate")]
		public DateTime HistoryDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="Margin")]
		public decimal Margin { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentCurrencyId")]
		public Guid PaymentCurrencyId { get; set; }
		[CProperty(ColumnPath ="PaymentCurrencyRate")]
		public decimal PaymentCurrencyRate { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountWithoutTax")]
		public decimal PrimaryAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Currency:PaymentCurrencyId")]
		public Currency PaymentCurrency { get; set; }
		[CProperty(Navigation ="Currency:BaseCurrencyId")]
		public Currency BaseCurrency { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
