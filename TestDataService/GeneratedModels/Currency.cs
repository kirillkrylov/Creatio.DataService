using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Currency")]
	public class Currency : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrecySymbolPosition")]
		public int CurrecySymbolPosition { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Division")]
		public int Division { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Rate")]
		public decimal Rate { get; set; }
		[CProperty(ColumnPath ="RecalcDirection")]
		public int RecalcDirection { get; set; }
		[CProperty(ColumnPath ="ShortName")]
		public string ShortName { get; set; }
		[CProperty(ColumnPath ="Symbol")]
		public string Symbol { get; set; }
		[CProperty(ColumnPath ="TsIsBase")]
		public bool TsIsBase { get; set; }
		[CProperty(ColumnPath ="UsedInFinancialRequests")]
		public bool UsedInFinancialRequests { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:CurrencyId")]
		public virtual ICollection<AccountForecast> AccountForecastByCurrency { get; set; }
		[CProperty(Association ="BillingInfoByCurrency:CurrencyId")]
		public virtual ICollection<BillingInfoByCurrency> BillingInfoByCurrencyByCurrency { get; set; }
		[CProperty(Association ="Bonus:CurrencyId")]
		public virtual ICollection<Bonus> BonusByCurrency { get; set; }
		[CProperty(Association ="BonusHistory:BaseCurrencyId")]
		public virtual ICollection<BonusHistory> BonusHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="BonusQueue:CurrencyId")]
		public virtual ICollection<BonusQueue> BonusQueueByCurrency { get; set; }
		[CProperty(Association ="CampaignPlanner:CurrencyId")]
		public virtual ICollection<CampaignPlanner> CampaignPlannerByCurrency { get; set; }
		[CProperty(Association ="Cashflow:CurrencyId")]
		public virtual ICollection<Cashflow> CashflowByCurrency { get; set; }
		[CProperty(Association ="ContactForecast:CurrencyId")]
		public virtual ICollection<ContactForecast> ContactForecastByCurrency { get; set; }
		[CProperty(Association ="Contract:CurrencyId")]
		public virtual ICollection<Contract> ContractByCurrency { get; set; }
		[CProperty(Association ="CurrencyRate:CurrencyId")]
		public virtual ICollection<CurrencyRate> CurrencyRateByCurrency { get; set; }
		[CProperty(Association ="Document:CurrencyId")]
		public virtual ICollection<Document> DocumentByCurrency { get; set; }
		[CProperty(Association ="ExesInRequest:CurrencyId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByCurrency { get; set; }
		[CProperty(Association ="ExesInRequestHistory:BaseCurrencyId")]
		public virtual ICollection<ExesInRequestHistory> ExesInRequestHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="ExesScheduleOfPayments:CurrencyId")]
		public virtual ICollection<ExesScheduleOfPayments> ExesScheduleOfPaymentsByCurrency { get; set; }
		[CProperty(Association ="Invoice:CurrencyId")]
		public virtual ICollection<Invoice> InvoiceByCurrency { get; set; }
		[CProperty(Association ="Invoice:PaymentCurrencyId")]
		public virtual ICollection<Invoice> InvoiceByPaymentCurrency { get; set; }
		[CProperty(Association ="InvoiceHistory:CurrencyId")]
		public virtual ICollection<InvoiceHistory> InvoiceHistoryByCurrency { get; set; }
		[CProperty(Association ="InvoiceHistory:PaymentCurrencyId")]
		public virtual ICollection<InvoiceHistory> InvoiceHistoryByPaymentCurrency { get; set; }
		[CProperty(Association ="InvoiceHistory:BaseCurrencyId")]
		public virtual ICollection<InvoiceHistory> InvoiceHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="InvoiceProductHistory:BaseCurrencyId")]
		public virtual ICollection<InvoiceProductHistory> InvoiceProductHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="LeadTypeForecast:CurrencyId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByCurrency { get; set; }
		[CProperty(Association ="MaxCurrencyRate:CurrencyId")]
		public virtual ICollection<MaxCurrencyRate> MaxCurrencyRateByCurrency { get; set; }
		[CProperty(Association ="MktgActivity:CurrencyId")]
		public virtual ICollection<MktgActivity> MktgActivityByCurrency { get; set; }
		[CProperty(Association ="OppDepartmentForecast:CurrencyId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByCurrency { get; set; }
		[CProperty(Association ="OpportunityTerritory:OrderCurrencyId")]
		public virtual ICollection<OpportunityTerritory> OpportunityTerritoryByOrderCurrency { get; set; }
		[CProperty(Association ="Order:CurrencyId")]
		public virtual ICollection<Order> OrderByCurrency { get; set; }
		[CProperty(Association ="Order:FixCurrencyId")]
		public virtual ICollection<Order> OrderByFixCurrency { get; set; }
		[CProperty(Association ="Order:PaymentCurrencyId")]
		public virtual ICollection<Order> OrderByPaymentCurrency { get; set; }
		[CProperty(Association ="OrderExpense:CurrencyId")]
		public virtual ICollection<OrderExpense> OrderExpenseByCurrency { get; set; }
		[CProperty(Association ="OrderHistory:CurrencyId")]
		public virtual ICollection<OrderHistory> OrderHistoryByCurrency { get; set; }
		[CProperty(Association ="OrderHistory:BaseCurrencyId")]
		public virtual ICollection<OrderHistory> OrderHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="OrderProduct:CurrencyId")]
		public virtual ICollection<OrderProduct> OrderProductByCurrency { get; set; }
		[CProperty(Association ="OrderProductHistory:CurrencyId")]
		public virtual ICollection<OrderProductHistory> OrderProductHistoryByCurrency { get; set; }
		[CProperty(Association ="OrderProductHistory:BaseCurrencyId")]
		public virtual ICollection<OrderProductHistory> OrderProductHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="Payments:CurrencyId")]
		public virtual ICollection<Payments> PaymentsByCurrency { get; set; }
		[CProperty(Association ="Pricelist:CurrencyId")]
		public virtual ICollection<Pricelist> PricelistByCurrency { get; set; }
		[CProperty(Association ="Product:CurrencyId")]
		public virtual ICollection<Product> ProductByCurrency { get; set; }
		[CProperty(Association ="ProductForecast:CurrencyId")]
		public virtual ICollection<ProductForecast> ProductForecastByCurrency { get; set; }
		[CProperty(Association ="ProductForLicGenerator:CurrencyId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByCurrency { get; set; }
		[CProperty(Association ="ProductInSubscription:CurrencyId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByCurrency { get; set; }
		[CProperty(Association ="ProductPrice:CurrencyId")]
		public virtual ICollection<ProductPrice> ProductPriceByCurrency { get; set; }
		[CProperty(Association ="RequestExes:CurrencyId")]
		public virtual ICollection<RequestExes> RequestExesByCurrency { get; set; }
		[CProperty(Association ="SupplyPaymentElement:CurrencyId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByCurrency { get; set; }
		[CProperty(Association ="SupplyPaymentProduct:CurrencyId")]
		public virtual ICollection<SupplyPaymentProduct> SupplyPaymentProductByCurrency { get; set; }
		[CProperty(Association ="Transaction:CurrencyId")]
		public virtual ICollection<Transaction> TransactionByCurrency { get; set; }
		[CProperty(Association ="TransactionForecast:CurrencyId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByCurrency { get; set; }
		[CProperty(Association ="TransactionHistory:BaseCurrencyId")]
		public virtual ICollection<TransactionHistory> TransactionHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="TripsDailyAllowance:CurrencyId")]
		public virtual ICollection<TripsDailyAllowance> TripsDailyAllowanceByCurrency { get; set; }
		[CProperty(Association ="TsCurrencyRate:CurrencyId")]
		public virtual ICollection<TsCurrencyRate> TsCurrencyRateByCurrency { get; set; }
		[CProperty(Association ="TsOrderExpense:CurrencyId")]
		public virtual ICollection<TsOrderExpense> TsOrderExpenseByCurrency { get; set; }
		[CProperty(Association ="TsOrderExpenseHistory:CurrencyId")]
		public virtual ICollection<TsOrderExpenseHistory> TsOrderExpenseHistoryByCurrency { get; set; }
		[CProperty(Association ="TsOrderExpenseHistory:BaseCurrencyId")]
		public virtual ICollection<TsOrderExpenseHistory> TsOrderExpenseHistoryByBaseCurrency { get; set; }
		[CProperty(Association ="VwProductBalance:CurrencyId")]
		public virtual ICollection<VwProductBalance> VwProductBalanceByCurrency { get; set; }
		[CProperty(Association ="VwTransaction:CurrencyId")]
		public virtual ICollection<VwTransaction> VwTransactionByCurrency { get; set; }
		[CProperty(Association ="VwTSSLA:CurrencyId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByCurrency { get; set; }
		[CProperty(Association ="VwTSSLAArchive:CurrencyId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByCurrency { get; set; }
		#endregion
	}
}
