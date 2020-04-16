using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductInSubscription")]
	public class ProductInSubscription : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AtZeroValue")]
		public bool AtZeroValue { get; set; }
		[CProperty(ColumnPath ="BilledAmount")]
		public decimal BilledAmount { get; set; }
		[CProperty(ColumnPath ="BilledManhours")]
		public decimal BilledManhours { get; set; }
		[CProperty(ColumnPath ="CancelDate")]
		public DateTime CancelDate { get; set; }
		[CProperty(ColumnPath ="Comments")]
		public string Comments { get; set; }
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="Count")]
		public decimal Count { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId { get; set; }
		[CProperty(ColumnPath ="IsCompetitive")]
		public bool IsCompetitive { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="IsVefiried")]
		public bool IsVefiried { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTotalAmountWithoutTax")]
		public decimal PrimaryTotalAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="PurchaseTypeId")]
		public Guid PurchaseTypeId { get; set; }
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId { get; set; }
		[CProperty(ColumnPath ="SubscriptionTypeId")]
		public Guid SubscriptionTypeId { get; set; }
		[CProperty(ColumnPath ="SupplyPaymentElementId")]
		public Guid SupplyPaymentElementId { get; set; }
		[CProperty(ColumnPath ="TotalAmountWithoutTax")]
		public decimal TotalAmountWithoutTax { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProduct:OrderProductId")]
		public OrderProduct OrderProduct { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="PurchaseType:PurchaseTypeId")]
		public PurchaseType PurchaseType { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		[CProperty(Navigation ="SubscriptionType:SubscriptionTypeId")]
		public SubscriptionType SubscriptionType { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:SupplyPaymentElementId")]
		public SupplyPaymentElement SupplyPaymentElement { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OrderProduct:SubscriptionProductId")]
		public virtual ICollection<OrderProduct> OrderProductBySubscriptionProduct { get; set; }
		[CProperty(Association ="SubscriptionExpirationProduct:ProductInSubscriptionId")]
		public virtual ICollection<SubscriptionExpirationProduct> SubscriptionExpirationProductByProductInSubscription { get; set; }
		[CProperty(Association ="Transaction:ProductInSubscriptionId")]
		public virtual ICollection<Transaction> TransactionByProductInSubscription { get; set; }
		[CProperty(Association ="TransactionForecast:ProductInSubscriptionId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByProductInSubscription { get; set; }
		[CProperty(Association ="VwProductBalance:ProductInSubscriptionId")]
		public virtual ICollection<VwProductBalance> VwProductBalanceByProductInSubscription { get; set; }
		[CProperty(Association ="VwTransaction:ProductInSubscriptionId")]
		public virtual ICollection<VwTransaction> VwTransactionByProductInSubscription { get; set; }
		#endregion
	}
}
