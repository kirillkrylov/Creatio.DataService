using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwPortalOrderExpenseProduct")]
	public class VwPortalOrderExpenseProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AmountWithVAT")]
		public decimal AmountWithVAT { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DiscountAmountInPaymentCurrency")]
		public decimal DiscountAmountInPaymentCurrency { get; set; }
		[CProperty(ColumnPath ="DiscountPercent")]
		public decimal DiscountPercent { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PartnerCompensationAmount")]
		public decimal PartnerCompensationAmount { get; set; }
		[CProperty(ColumnPath ="PartnerCompensationPercent")]
		public decimal PartnerCompensationPercent { get; set; }
		[CProperty(ColumnPath ="PartnerMargin")]
		public decimal PartnerMargin { get; set; }
		[CProperty(ColumnPath ="PartnerMarginInPaymentCurrency")]
		public decimal PartnerMarginInPaymentCurrency { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="ProductPriceInInvoiceCurrency")]
		public decimal ProductPriceInInvoiceCurrency { get; set; }
		[CProperty(ColumnPath ="Quantity")]
		public int Quantity { get; set; }
		[CProperty(ColumnPath ="SupportSoldForId")]
		public Guid SupportSoldForId { get; set; }
		[CProperty(ColumnPath ="TsOrderExpenseId")]
		public Guid TsOrderExpenseId { get; set; }
		[CProperty(ColumnPath ="VATAmount")]
		public decimal VATAmount { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Product:SupportSoldForId")]
		public Product SupportSoldFor { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="TsOrderExpense:TsOrderExpenseId")]
		public TsOrderExpense TsOrderExpense { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
