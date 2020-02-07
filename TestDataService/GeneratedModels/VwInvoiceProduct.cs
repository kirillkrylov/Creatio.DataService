using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwInvoiceProduct")]
	public class VwInvoiceProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="BaseQuantity")]
		public decimal BaseQuantity { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CustomProduct")]
		public string CustomProduct { get; set; }
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate { get; set; }
		[CProperty(ColumnPath ="DiscountAmount")]
		public decimal DiscountAmount { get; set; }
		[CProperty(ColumnPath ="DiscountPercent")]
		public decimal DiscountPercent { get; set; }
		[CProperty(ColumnPath ="DiscountTax")]
		public decimal DiscountTax { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Price")]
		public decimal Price { get; set; }
		[CProperty(ColumnPath ="PriceListId")]
		public Guid PriceListId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryDiscountAmount")]
		public decimal PrimaryDiscountAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryPrice")]
		public decimal PrimaryPrice { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTotalAmount")]
		public decimal PrimaryTotalAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity { get; set; }
		[CProperty(ColumnPath ="SupplyPaymentProductId")]
		public Guid SupplyPaymentProductId { get; set; }
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount { get; set; }
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId { get; set; }
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount { get; set; }
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Pricelist:PriceListId")]
		public Pricelist PriceList { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="SupplyPaymentProduct:SupplyPaymentProductId")]
		public SupplyPaymentProduct SupplyPaymentProduct { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		[CProperty(Navigation ="Unit:UnitId")]
		public Unit Unit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
