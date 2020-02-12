using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrderProductHistory")]
	public class OrderProductHistory : BaseEntity
	{
		#region Values
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
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountWithDiscount")]
		public decimal PrimaryAmountWithDiscount { get; set; }
		[CProperty(ColumnPath ="PrimaryPrice")]
		public decimal PrimaryPrice { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTotalAmount")]
		public decimal PrimaryTotalAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTotalAmountWithoutTax")]
		public decimal PrimaryTotalAmountWithoutTax { get; set; }
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
		[CProperty(Navigation ="Currency:BaseCurrencyId")]
		public Currency BaseCurrency { get; set; }
		[CProperty(Navigation ="OrderProduct:OrderProductId")]
		public OrderProduct OrderProduct { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
