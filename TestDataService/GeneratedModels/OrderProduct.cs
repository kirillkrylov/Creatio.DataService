using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrderProduct")]
	public class OrderProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AmountWithDiscount")]
		public decimal AmountWithDiscount { get; set; }
		[CProperty(ColumnPath ="Balance")]
		public decimal Balance { get; set; }
		[CProperty(ColumnPath ="BaseQuantity")]
		public decimal BaseQuantity { get; set; }
		[CProperty(ColumnPath ="CalcMethodId")]
		public Guid CalcMethodId { get; set; }
		[CProperty(ColumnPath ="CompensationAmount")]
		public decimal CompensationAmount { get; set; }
		[CProperty(ColumnPath ="CompensationPercent")]
		public decimal CompensationPercent { get; set; }
		[CProperty(ColumnPath ="CompensationPrimaryAmount")]
		public decimal CompensationPrimaryAmount { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="CustomProduct")]
		public string CustomProduct { get; set; }
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate { get; set; }
		[CProperty(ColumnPath ="DeliveryOnEvent")]
		public bool DeliveryOnEvent { get; set; }
		[CProperty(ColumnPath ="DiscountAmount")]
		public decimal DiscountAmount { get; set; }
		[CProperty(ColumnPath ="DiscountPercent")]
		public decimal DiscountPercent { get; set; }
		[CProperty(ColumnPath ="DiscountTax")]
		public decimal DiscountTax { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="LicensePrice")]
		public decimal LicensePrice { get; set; }
		[CProperty(ColumnPath ="LicenseQuantity")]
		public decimal LicenseQuantity { get; set; }
		[CProperty(ColumnPath ="MinPrice")]
		public decimal MinPrice { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="MultiYearContractId")]
		public Guid MultiYearContractId { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentCurrencyPrice")]
		public decimal PaymentCurrencyPrice { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="Price")]
		public decimal Price { get; set; }
		[CProperty(ColumnPath ="PriceListId")]
		public Guid PriceListId { get; set; }
		[CProperty(ColumnPath ="PricePercent")]
		public decimal PricePercent { get; set; }
		[CProperty(ColumnPath ="PriceWithDiscount")]
		public decimal PriceWithDiscount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountWithDiscount")]
		public decimal PrimaryAmountWithDiscount { get; set; }
		[CProperty(ColumnPath ="PrimaryDiscountAmount")]
		public decimal PrimaryDiscountAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryPrice")]
		public decimal PrimaryPrice { get; set; }
		[CProperty(ColumnPath ="PrimaryPriceWithDiscount")]
		public decimal PrimaryPriceWithDiscount { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTotalAmount")]
		public decimal PrimaryTotalAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTotalAmountWithoutTax")]
		public decimal PrimaryTotalAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity { get; set; }
		[CProperty(ColumnPath ="RelatedOrderProductId")]
		public Guid RelatedOrderProductId { get; set; }
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate { get; set; }
		[CProperty(ColumnPath ="SaleTypeId")]
		public Guid SaleTypeId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId { get; set; }
		[CProperty(ColumnPath ="SubscriptionProductId")]
		public Guid SubscriptionProductId { get; set; }
		[CProperty(ColumnPath ="SupportSoldForId")]
		public Guid SupportSoldForId { get; set; }
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount { get; set; }
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId { get; set; }
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount { get; set; }
		[CProperty(ColumnPath ="TotalAmountWithoutTax")]
		public decimal TotalAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="FormulasForCalculatingCostsProduct:CalcMethodId")]
		public FormulasForCalculatingCostsProduct CalcMethod { get; set; }
		[CProperty(Navigation ="MultiYearContract:MultiYearContractId")]
		public MultiYearContract MultiYearContract { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProduct:RelatedOrderProductId")]
		public OrderProduct RelatedOrderProduct { get; set; }
		[CProperty(Navigation ="OrderProductPeriod:PeriodId")]
		public OrderProductPeriod Period { get; set; }
		[CProperty(Navigation ="OrderProductType:TypeId")]
		public OrderProductType Type { get; set; }
		[CProperty(Navigation ="Pricelist:PriceListId")]
		public Pricelist PriceList { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="Product:SupportSoldForId")]
		public Product SupportSoldFor { get; set; }
		[CProperty(Navigation ="ProductInSubscription:SubscriptionProductId")]
		public ProductInSubscription SubscriptionProduct { get; set; }
		[CProperty(Navigation ="SaleType:SaleTypeId")]
		public SaleType SaleType { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		[CProperty(Navigation ="Unit:UnitId")]
		public Unit Unit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InvoiceProduct:OrderProductId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByOrderProduct { get; set; }
		[CProperty(Association ="OrderExpense:ProductId")]
		public virtual ICollection<OrderExpense> OrderExpenseByProduct { get; set; }
		[CProperty(Association ="OrderProduct:RelatedOrderProductId")]
		public virtual ICollection<OrderProduct> OrderProductByRelatedOrderProduct { get; set; }
		[CProperty(Association ="OrderProductHistory:OrderProductId")]
		public virtual ICollection<OrderProductHistory> OrderProductHistoryByOrderProduct { get; set; }
		[CProperty(Association ="ProductForLicGenerator:OrderProductId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByOrderProduct { get; set; }
		[CProperty(Association ="ProductInSubscription:OrderProductId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByOrderProduct { get; set; }
		[CProperty(Association ="ProjectResourceElement:OrderProductId")]
		public virtual ICollection<ProjectResourceElement> ProjectResourceElementByOrderProduct { get; set; }
		[CProperty(Association ="SupplyPaymentElement:ProductId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByProduct { get; set; }
		[CProperty(Association ="SupplyPaymentProduct:ProductId")]
		public virtual ICollection<SupplyPaymentProduct> SupplyPaymentProductByProduct { get; set; }
		[CProperty(Association ="Transaction:ProductInOrderId")]
		public virtual ICollection<Transaction> TransactionByProductInOrder { get; set; }
		[CProperty(Association ="TransactionForecast:ProductInOrderId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByProductInOrder { get; set; }
		[CProperty(Association ="TsOrderExpenseProduct:OrderProductId")]
		public virtual ICollection<TsOrderExpenseProduct> TsOrderExpenseProductByOrderProduct { get; set; }
		[CProperty(Association ="VwInvoiceProduct:OrderProductId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByOrderProduct { get; set; }
		[CProperty(Association ="VwOrderProductFilter:ProductId")]
		public virtual ICollection<VwOrderProductFilter> VwOrderProductFilterByProduct { get; set; }
		[CProperty(Association ="VwSupplyPaymentProduct:OrderProductId")]
		public virtual ICollection<VwSupplyPaymentProduct> VwSupplyPaymentProductByOrderProduct { get; set; }
		[CProperty(Association ="VwTransaction:ProductInOrderId")]
		public virtual ICollection<VwTransaction> VwTransactionByProductInOrder { get; set; }
		[CProperty(Association ="VwTSSLA:OrderProductId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByOrderProduct { get; set; }
		[CProperty(Association ="VwTSSLAArchive:OrderProductId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByOrderProduct { get; set; }
		#endregion
	}
}
