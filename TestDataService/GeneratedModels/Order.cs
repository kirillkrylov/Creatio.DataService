using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Order")]
	public class Order : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ActualDate;
		[CProperty(ColumnPath ="ActualDate")]
		public DateTime ActualDate
		{
			get{return _ActualDate;}
			set
			{
				_ActualDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _Amount;
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountWithoutTax;
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax
		{
			get{return _AmountWithoutTax;}
			set
			{
				_AmountWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private string _ContactNumber;
		[CProperty(ColumnPath ="ContactNumber")]
		public string ContactNumber
		{
			get{return _ContactNumber;}
			set
			{
				_ContactNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private int _CurrencyDeviation;
		[CProperty(ColumnPath ="CurrencyDeviation")]
		public int CurrencyDeviation
		{
			get{return _CurrencyDeviation;}
			set
			{
				_CurrencyDeviation = value;
				OnPropertyChanged();
			}
		}
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _CurrencyRate;
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate
		{
			get{return _CurrencyRate;}
			set
			{
				_CurrencyRate = value;
				OnPropertyChanged();
			}
		}
		private Guid _CustomerBillingInfoId;
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId
		{
			get{return _CustomerBillingInfoId;}
			set
			{
				_CustomerBillingInfoId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _Date;
		[CProperty(ColumnPath ="Date")]
		public DateTime Date
		{
			get{return _Date;}
			set
			{
				_Date = value;
				OnPropertyChanged();
			}
		}
		private string _DeliveryAddress;
		[CProperty(ColumnPath ="DeliveryAddress")]
		public string DeliveryAddress
		{
			get{return _DeliveryAddress;}
			set
			{
				_DeliveryAddress = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeliveryStatusId;
		[CProperty(ColumnPath ="DeliveryStatusId")]
		public Guid DeliveryStatusId
		{
			get{return _DeliveryStatusId;}
			set
			{
				_DeliveryStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeliveryTypeId;
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId
		{
			get{return _DeliveryTypeId;}
			set
			{
				_DeliveryTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _EventId;
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId
		{
			get{return _EventId;}
			set
			{
				_EventId = value;
				OnPropertyChanged();
			}
		}
		private Guid _FixCurrencyId;
		[CProperty(ColumnPath ="FixCurrencyId")]
		public Guid FixCurrencyId
		{
			get{return _FixCurrencyId;}
			set
			{
				_FixCurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _FixCurrencyRate;
		[CProperty(ColumnPath ="FixCurrencyRate")]
		public decimal FixCurrencyRate
		{
			get{return _FixCurrencyRate;}
			set
			{
				_FixCurrencyRate = value;
				OnPropertyChanged();
			}
		}
		private decimal _FixedExchangeRate;
		[CProperty(ColumnPath ="FixedExchangeRate")]
		public decimal FixedExchangeRate
		{
			get{return _FixedExchangeRate;}
			set
			{
				_FixedExchangeRate = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private bool _IsApproved;
		[CProperty(ColumnPath ="IsApproved")]
		public bool IsApproved
		{
			get{return _IsApproved;}
			set
			{
				_IsApproved = value;
				OnPropertyChanged();
			}
		}
		private bool _isFirstOrder;
		[CProperty(ColumnPath ="isFirstOrder")]
		public bool isFirstOrder
		{
			get{return _isFirstOrder;}
			set
			{
				_isFirstOrder = value;
				OnPropertyChanged();
			}
		}
		private bool _IsFixRate;
		[CProperty(ColumnPath ="IsFixRate")]
		public bool IsFixRate
		{
			get{return _IsFixRate;}
			set
			{
				_IsFixRate = value;
				OnPropertyChanged();
			}
		}
		private bool _IsRecordLocked;
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked
		{
			get{return _IsRecordLocked;}
			set
			{
				_IsRecordLocked = value;
				OnPropertyChanged();
			}
		}
		private decimal _ManualProductTax;
		[CProperty(ColumnPath ="ManualProductTax")]
		public decimal ManualProductTax
		{
			get{return _ManualProductTax;}
			set
			{
				_ManualProductTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _ManualServicesTax;
		[CProperty(ColumnPath ="ManualServicesTax")]
		public decimal ManualServicesTax
		{
			get{return _ManualServicesTax;}
			set
			{
				_ManualServicesTax = value;
				OnPropertyChanged();
			}
		}
		private bool _ManualTaxCalculation;
		[CProperty(ColumnPath ="ManualTaxCalculation")]
		public bool ManualTaxCalculation
		{
			get{return _ManualTaxCalculation;}
			set
			{
				_ManualTaxCalculation = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _MultiYearContractId;
		[CProperty(ColumnPath ="MultiYearContractId")]
		public Guid MultiYearContractId
		{
			get{return _MultiYearContractId;}
			set
			{
				_MultiYearContractId = value;
				OnPropertyChanged();
			}
		}
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private bool _Oferta;
		[CProperty(ColumnPath ="Oferta")]
		public bool Oferta
		{
			get{return _Oferta;}
			set
			{
				_Oferta = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderKindId;
		[CProperty(ColumnPath ="OrderKindId")]
		public Guid OrderKindId
		{
			get{return _OrderKindId;}
			set
			{
				_OrderKindId = value;
				OnPropertyChanged();
			}
		}
		private bool _OrderKindIsApproved;
		[CProperty(ColumnPath ="OrderKindIsApproved")]
		public bool OrderKindIsApproved
		{
			get{return _OrderKindIsApproved;}
			set
			{
				_OrderKindIsApproved = value;
				OnPropertyChanged();
			}
		}
		private decimal _OrderMargin;
		[CProperty(ColumnPath ="OrderMargin")]
		public decimal OrderMargin
		{
			get{return _OrderMargin;}
			set
			{
				_OrderMargin = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderTypeId;
		[CProperty(ColumnPath ="OrderTypeId")]
		public Guid OrderTypeId
		{
			get{return _OrderTypeId;}
			set
			{
				_OrderTypeId = value;
				OnPropertyChanged();
			}
		}
		private bool _OrderVerified;
		[CProperty(ColumnPath ="OrderVerified")]
		public bool OrderVerified
		{
			get{return _OrderVerified;}
			set
			{
				_OrderVerified = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerId;
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId
		{
			get{return _PartnerId;}
			set
			{
				_PartnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PayerId;
		[CProperty(ColumnPath ="PayerId")]
		public Guid PayerId
		{
			get{return _PayerId;}
			set
			{
				_PayerId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PaymentAmount;
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount
		{
			get{return _PaymentAmount;}
			set
			{
				_PaymentAmount = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentCurrencyId;
		[CProperty(ColumnPath ="PaymentCurrencyId")]
		public Guid PaymentCurrencyId
		{
			get{return _PaymentCurrencyId;}
			set
			{
				_PaymentCurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PaymentMargin;
		[CProperty(ColumnPath ="PaymentMargin")]
		public decimal PaymentMargin
		{
			get{return _PaymentMargin;}
			set
			{
				_PaymentMargin = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentStatusId;
		[CProperty(ColumnPath ="PaymentStatusId")]
		public Guid PaymentStatusId
		{
			get{return _PaymentStatusId;}
			set
			{
				_PaymentStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentTypeId;
		[CProperty(ColumnPath ="PaymentTypeId")]
		public Guid PaymentTypeId
		{
			get{return _PaymentTypeId;}
			set
			{
				_PaymentTypeId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmount;
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount
		{
			get{return _PrimaryAmount;}
			set
			{
				_PrimaryAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountWithoutTax;
		[CProperty(ColumnPath ="PrimaryAmountWithoutTax")]
		public decimal PrimaryAmountWithoutTax
		{
			get{return _PrimaryAmountWithoutTax;}
			set
			{
				_PrimaryAmountWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPaymentAmount;
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount
		{
			get{return _PrimaryPaymentAmount;}
			set
			{
				_PrimaryPaymentAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTaxAmount;
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount
		{
			get{return _PrimaryTaxAmount;}
			set
			{
				_PrimaryTaxAmount = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProjectId;
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId
		{
			get{return _ProjectId;}
			set
			{
				_ProjectId = value;
				OnPropertyChanged();
			}
		}
		private string _ReceiverName;
		[CProperty(ColumnPath ="ReceiverName")]
		public string ReceiverName
		{
			get{return _ReceiverName;}
			set
			{
				_ReceiverName = value;
				OnPropertyChanged();
			}
		}
		private Guid _SourceOrderId;
		[CProperty(ColumnPath ="SourceOrderId")]
		public Guid SourceOrderId
		{
			get{return _SourceOrderId;}
			set
			{
				_SourceOrderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierBillingInfoLicId;
		[CProperty(ColumnPath ="SupplierBillingInfoLicId")]
		public Guid SupplierBillingInfoLicId
		{
			get{return _SupplierBillingInfoLicId;}
			set
			{
				_SupplierBillingInfoLicId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierBillingInfoSerId;
		[CProperty(ColumnPath ="SupplierBillingInfoSerId")]
		public Guid SupplierBillingInfoSerId
		{
			get{return _SupplierBillingInfoSerId;}
			set
			{
				_SupplierBillingInfoSerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplierId;
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId
		{
			get{return _SupplierId;}
			set
			{
				_SupplierId = value;
				OnPropertyChanged();
			}
		}
		private decimal _TaxAmount;
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount
		{
			get{return _TaxAmount;}
			set
			{
				_TaxAmount = value;
				OnPropertyChanged();
			}
		}
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
