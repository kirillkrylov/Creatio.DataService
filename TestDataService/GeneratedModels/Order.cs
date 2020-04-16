using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Order")]
	public class Order : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ActualDate")]
		public DateTime ActualDate { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContactNumber")]
		public string ContactNumber { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyDeviation")]
		public int CurrencyDeviation { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="DeliveryAddress")]
		public string DeliveryAddress { get; set; }
		[CProperty(ColumnPath ="DeliveryStatusId")]
		public Guid DeliveryStatusId { get; set; }
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="FixCurrencyId")]
		public Guid FixCurrencyId { get; set; }
		[CProperty(ColumnPath ="FixCurrencyRate")]
		public decimal FixCurrencyRate { get; set; }
		[CProperty(ColumnPath ="FixedExchangeRate")]
		public decimal FixedExchangeRate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsApproved")]
		public bool IsApproved { get; set; }
		[CProperty(ColumnPath ="isFirstOrder")]
		public bool isFirstOrder { get; set; }
		[CProperty(ColumnPath ="IsFixRate")]
		public bool IsFixRate { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="ManualProductTax")]
		public decimal ManualProductTax { get; set; }
		[CProperty(ColumnPath ="ManualServicesTax")]
		public decimal ManualServicesTax { get; set; }
		[CProperty(ColumnPath ="ManualTaxCalculation")]
		public bool ManualTaxCalculation { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="MultiYearContractId")]
		public Guid MultiYearContractId { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="Oferta")]
		public bool Oferta { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderKindId")]
		public Guid OrderKindId { get; set; }
		[CProperty(ColumnPath ="OrderKindIsApproved")]
		public bool OrderKindIsApproved { get; set; }
		[CProperty(ColumnPath ="OrderMargin")]
		public decimal OrderMargin { get; set; }
		[CProperty(ColumnPath ="OrderTypeId")]
		public Guid OrderTypeId { get; set; }
		[CProperty(ColumnPath ="OrderVerified")]
		public bool OrderVerified { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PayerId")]
		public Guid PayerId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentCurrencyId")]
		public Guid PaymentCurrencyId { get; set; }
		[CProperty(ColumnPath ="PaymentMargin")]
		public decimal PaymentMargin { get; set; }
		[CProperty(ColumnPath ="PaymentStatusId")]
		public Guid PaymentStatusId { get; set; }
		[CProperty(ColumnPath ="PaymentTypeId")]
		public Guid PaymentTypeId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountWithoutTax")]
		public decimal PrimaryAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="ReceiverName")]
		public string ReceiverName { get; set; }
		[CProperty(ColumnPath ="SourceOrderId")]
		public Guid SourceOrderId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SupplierBillingInfoLicId")]
		public Guid SupplierBillingInfoLicId { get; set; }
		[CProperty(ColumnPath ="SupplierBillingInfoSerId")]
		public Guid SupplierBillingInfoSerId { get; set; }
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId { get; set; }
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:CustomerBillingInfoId")]
		public AccountBillingInfo CustomerBillingInfo { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:SupplierBillingInfoLicId")]
		public AccountBillingInfo SupplierBillingInfoLic { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:SupplierBillingInfoSerId")]
		public AccountBillingInfo SupplierBillingInfoSer { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Currency:FixCurrencyId")]
		public Currency FixCurrency { get; set; }
		[CProperty(Navigation ="Currency:PaymentCurrencyId")]
		public Currency PaymentCurrency { get; set; }
		[CProperty(Navigation ="DeliveryType:DeliveryTypeId")]
		public DeliveryType DeliveryType { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="MultiYearContract:MultiYearContractId")]
		public MultiYearContract MultiYearContract { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OrderDeliveryStatus:DeliveryStatusId")]
		public OrderDeliveryStatus DeliveryStatus { get; set; }
		[CProperty(Navigation ="OrderPayer:PayerId")]
		public OrderPayer Payer { get; set; }
		[CProperty(Navigation ="OrderPaymentStatus:PaymentStatusId")]
		public OrderPaymentStatus PaymentStatus { get; set; }
		[CProperty(Navigation ="OrderStatus:StatusId")]
		public OrderStatus Status { get; set; }
		[CProperty(Navigation ="PaymentType:PaymentTypeId")]
		public PaymentType PaymentType { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="SourceOrder:SourceOrderId")]
		public SourceOrder SourceOrder { get; set; }
		[CProperty(Navigation ="WorkOrderKind:OrderKindId")]
		public WorkOrderKind OrderKind { get; set; }
		[CProperty(Navigation ="WorkOrderType:OrderTypeId")]
		public WorkOrderType OrderType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:OrderId")]
		public virtual ICollection<Activity> ActivityByOrder { get; set; }
		[CProperty(Association ="Bonus:OrderId")]
		public virtual ICollection<Bonus> BonusByOrder { get; set; }
		[CProperty(Association ="Call:OrderId")]
		public virtual ICollection<Call> CallByOrder { get; set; }
		[CProperty(Association ="Contract:OrderId")]
		public virtual ICollection<Contract> ContractByOrder { get; set; }
		[CProperty(Association ="CorrespondenceLink:OrderId")]
		public virtual ICollection<CorrespondenceLink> CorrespondenceLinkByOrder { get; set; }
		[CProperty(Association ="Document:OrderId")]
		public virtual ICollection<Document> DocumentByOrder { get; set; }
		[CProperty(Association ="InternalRequest:OrderId")]
		public virtual ICollection<InternalRequest> InternalRequestByOrder { get; set; }
		[CProperty(Association ="Invoice:OrderId")]
		public virtual ICollection<Invoice> InvoiceByOrder { get; set; }
		[CProperty(Association ="Lead:OrderId")]
		public virtual ICollection<Lead> LeadByOrder { get; set; }
		[CProperty(Association ="OpportunityForecast:OrderId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByOrder { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:OrderId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByOrder { get; set; }
		[CProperty(Association ="OpportunityPartner:OrderId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByOrder { get; set; }
		[CProperty(Association ="OrderExpense:OrderId")]
		public virtual ICollection<OrderExpense> OrderExpenseByOrder { get; set; }
		[CProperty(Association ="OrderFile:OrderId")]
		public virtual ICollection<OrderFile> OrderFileByOrder { get; set; }
		[CProperty(Association ="OrderHistory:OrderId")]
		public virtual ICollection<OrderHistory> OrderHistoryByOrder { get; set; }
		[CProperty(Association ="OrderInFolder:OrderId")]
		public virtual ICollection<OrderInFolder> OrderInFolderByOrder { get; set; }
		[CProperty(Association ="OrderInTag:EntityId")]
		public virtual ICollection<OrderInTag> OrderInTagByEntity { get; set; }
		[CProperty(Association ="OrderProduct:OrderId")]
		public virtual ICollection<OrderProduct> OrderProductByOrder { get; set; }
		[CProperty(Association ="OrderVisa:OrderId")]
		public virtual ICollection<OrderVisa> OrderVisaByOrder { get; set; }
		[CProperty(Association ="ProductForLicGenerator:OrderId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByOrder { get; set; }
		[CProperty(Association ="ProductInSubscription:OrderId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByOrder { get; set; }
		[CProperty(Association ="Project:OrderId")]
		public virtual ICollection<Project> ProjectByOrder { get; set; }
		[CProperty(Association ="SupplyPaymentElement:OrderId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByOrder { get; set; }
		[CProperty(Association ="Transaction:OrderId")]
		public virtual ICollection<Transaction> TransactionByOrder { get; set; }
		[CProperty(Association ="TransactionForecast:OrderId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByOrder { get; set; }
		[CProperty(Association ="TsOrderExpense:OrderId")]
		public virtual ICollection<TsOrderExpense> TsOrderExpenseByOrder { get; set; }
		[CProperty(Association ="VwLead:OrderId")]
		public virtual ICollection<VwLead> VwLeadByOrder { get; set; }
		[CProperty(Association ="VwOrderExpenseProduct:OrderId")]
		public virtual ICollection<VwOrderExpenseProduct> VwOrderExpenseProductByOrder { get; set; }
		[CProperty(Association ="VwQueueItem:OrderId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByOrder { get; set; }
		[CProperty(Association ="VwQueueItemSuper:OrderId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByOrder { get; set; }
		[CProperty(Association ="VwTransaction:OrderId")]
		public virtual ICollection<VwTransaction> VwTransactionByOrder { get; set; }
		[CProperty(Association ="VwTSSLA:OrderId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByOrder { get; set; }
		[CProperty(Association ="VwTSSLAArchive:OrderId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByOrder { get; set; }
		#endregion
	}
}
