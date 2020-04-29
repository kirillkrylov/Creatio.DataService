using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrderProduct")]
	public class OrderProduct : BaseEntity
	{
		#region Values
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
		private decimal _AmountWithDiscount;
		[CProperty(ColumnPath ="AmountWithDiscount")]
		public decimal AmountWithDiscount
		{
			get{return _AmountWithDiscount;}
			set
			{
				_AmountWithDiscount = value;
				OnPropertyChanged();
			}
		}
		private decimal _Balance;
		[CProperty(ColumnPath ="Balance")]
		public decimal Balance
		{
			get{return _Balance;}
			set
			{
				_Balance = value;
				OnPropertyChanged();
			}
		}
		private decimal _BaseQuantity;
		[CProperty(ColumnPath ="BaseQuantity")]
		public decimal BaseQuantity
		{
			get{return _BaseQuantity;}
			set
			{
				_BaseQuantity = value;
				OnPropertyChanged();
			}
		}
		private Guid _CalcMethodId;
		[CProperty(ColumnPath ="CalcMethodId")]
		public Guid CalcMethodId
		{
			get{return _CalcMethodId;}
			set
			{
				_CalcMethodId = value;
				OnPropertyChanged();
			}
		}
		private decimal _CompensationAmount;
		[CProperty(ColumnPath ="CompensationAmount")]
		public decimal CompensationAmount
		{
			get{return _CompensationAmount;}
			set
			{
				_CompensationAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _CompensationPercent;
		[CProperty(ColumnPath ="CompensationPercent")]
		public decimal CompensationPercent
		{
			get{return _CompensationPercent;}
			set
			{
				_CompensationPercent = value;
				OnPropertyChanged();
			}
		}
		private decimal _CompensationPrimaryAmount;
		[CProperty(ColumnPath ="CompensationPrimaryAmount")]
		public decimal CompensationPrimaryAmount
		{
			get{return _CompensationPrimaryAmount;}
			set
			{
				_CompensationPrimaryAmount = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContractId;
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId
		{
			get{return _ContractId;}
			set
			{
				_ContractId = value;
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
		private string _CustomProduct;
		[CProperty(ColumnPath ="CustomProduct")]
		public string CustomProduct
		{
			get{return _CustomProduct;}
			set
			{
				_CustomProduct = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DeliveryDate;
		[CProperty(ColumnPath ="DeliveryDate")]
		public DateTime DeliveryDate
		{
			get{return _DeliveryDate;}
			set
			{
				_DeliveryDate = value;
				OnPropertyChanged();
			}
		}
		private bool _DeliveryOnEvent;
		[CProperty(ColumnPath ="DeliveryOnEvent")]
		public bool DeliveryOnEvent
		{
			get{return _DeliveryOnEvent;}
			set
			{
				_DeliveryOnEvent = value;
				OnPropertyChanged();
			}
		}
		private decimal _DiscountAmount;
		[CProperty(ColumnPath ="DiscountAmount")]
		public decimal DiscountAmount
		{
			get{return _DiscountAmount;}
			set
			{
				_DiscountAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _DiscountPercent;
		[CProperty(ColumnPath ="DiscountPercent")]
		public decimal DiscountPercent
		{
			get{return _DiscountPercent;}
			set
			{
				_DiscountPercent = value;
				OnPropertyChanged();
			}
		}
		private decimal _DiscountTax;
		[CProperty(ColumnPath ="DiscountTax")]
		public decimal DiscountTax
		{
			get{return _DiscountTax;}
			set
			{
				_DiscountTax = value;
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
		private decimal _LicensePrice;
		[CProperty(ColumnPath ="LicensePrice")]
		public decimal LicensePrice
		{
			get{return _LicensePrice;}
			set
			{
				_LicensePrice = value;
				OnPropertyChanged();
			}
		}
		private decimal _LicenseQuantity;
		[CProperty(ColumnPath ="LicenseQuantity")]
		public decimal LicenseQuantity
		{
			get{return _LicenseQuantity;}
			set
			{
				_LicenseQuantity = value;
				OnPropertyChanged();
			}
		}
		private decimal _MinPrice;
		[CProperty(ColumnPath ="MinPrice")]
		public decimal MinPrice
		{
			get{return _MinPrice;}
			set
			{
				_MinPrice = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
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
		private Guid _OrderId;
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId
		{
			get{return _OrderId;}
			set
			{
				_OrderId = value;
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
		private decimal _PaymentCurrencyPrice;
		[CProperty(ColumnPath ="PaymentCurrencyPrice")]
		public decimal PaymentCurrencyPrice
		{
			get{return _PaymentCurrencyPrice;}
			set
			{
				_PaymentCurrencyPrice = value;
				OnPropertyChanged();
			}
		}
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Price;
		[CProperty(ColumnPath ="Price")]
		public decimal Price
		{
			get{return _Price;}
			set
			{
				_Price = value;
				OnPropertyChanged();
			}
		}
		private Guid _PriceListId;
		[CProperty(ColumnPath ="PriceListId")]
		public Guid PriceListId
		{
			get{return _PriceListId;}
			set
			{
				_PriceListId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PricePercent;
		[CProperty(ColumnPath ="PricePercent")]
		public decimal PricePercent
		{
			get{return _PricePercent;}
			set
			{
				_PricePercent = value;
				OnPropertyChanged();
			}
		}
		private decimal _PriceWithDiscount;
		[CProperty(ColumnPath ="PriceWithDiscount")]
		public decimal PriceWithDiscount
		{
			get{return _PriceWithDiscount;}
			set
			{
				_PriceWithDiscount = value;
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
		private decimal _PrimaryAmountWithDiscount;
		[CProperty(ColumnPath ="PrimaryAmountWithDiscount")]
		public decimal PrimaryAmountWithDiscount
		{
			get{return _PrimaryAmountWithDiscount;}
			set
			{
				_PrimaryAmountWithDiscount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryDiscountAmount;
		[CProperty(ColumnPath ="PrimaryDiscountAmount")]
		public decimal PrimaryDiscountAmount
		{
			get{return _PrimaryDiscountAmount;}
			set
			{
				_PrimaryDiscountAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPrice;
		[CProperty(ColumnPath ="PrimaryPrice")]
		public decimal PrimaryPrice
		{
			get{return _PrimaryPrice;}
			set
			{
				_PrimaryPrice = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPriceWithDiscount;
		[CProperty(ColumnPath ="PrimaryPriceWithDiscount")]
		public decimal PrimaryPriceWithDiscount
		{
			get{return _PrimaryPriceWithDiscount;}
			set
			{
				_PrimaryPriceWithDiscount = value;
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
		private decimal _PrimaryTotalAmount;
		[CProperty(ColumnPath ="PrimaryTotalAmount")]
		public decimal PrimaryTotalAmount
		{
			get{return _PrimaryTotalAmount;}
			set
			{
				_PrimaryTotalAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTotalAmountWithoutTax;
		[CProperty(ColumnPath ="PrimaryTotalAmountWithoutTax")]
		public decimal PrimaryTotalAmountWithoutTax
		{
			get{return _PrimaryTotalAmountWithoutTax;}
			set
			{
				_PrimaryTotalAmountWithoutTax = value;
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
		private Guid _ProductId;
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId
		{
			get{return _ProductId;}
			set
			{
				_ProductId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Quantity;
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity
		{
			get{return _Quantity;}
			set
			{
				_Quantity = value;
				OnPropertyChanged();
			}
		}
		private Guid _RelatedOrderProductId;
		[CProperty(ColumnPath ="RelatedOrderProductId")]
		public Guid RelatedOrderProductId
		{
			get{return _RelatedOrderProductId;}
			set
			{
				_RelatedOrderProductId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RenewalDate;
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate
		{
			get{return _RenewalDate;}
			set
			{
				_RenewalDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SaleTypeId;
		[CProperty(ColumnPath ="SaleTypeId")]
		public Guid SaleTypeId
		{
			get{return _SaleTypeId;}
			set
			{
				_SaleTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubscriptionId;
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId
		{
			get{return _SubscriptionId;}
			set
			{
				_SubscriptionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubscriptionProductId;
		[CProperty(ColumnPath ="SubscriptionProductId")]
		public Guid SubscriptionProductId
		{
			get{return _SubscriptionProductId;}
			set
			{
				_SubscriptionProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupportSoldForId;
		[CProperty(ColumnPath ="SupportSoldForId")]
		public Guid SupportSoldForId
		{
			get{return _SupportSoldForId;}
			set
			{
				_SupportSoldForId = value;
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
		private Guid _TaxId;
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId
		{
			get{return _TaxId;}
			set
			{
				_TaxId = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalAmount;
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount
		{
			get{return _TotalAmount;}
			set
			{
				_TotalAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalAmountWithoutTax;
		[CProperty(ColumnPath ="TotalAmountWithoutTax")]
		public decimal TotalAmountWithoutTax
		{
			get{return _TotalAmountWithoutTax;}
			set
			{
				_TotalAmountWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _UnitId;
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId
		{
			get{return _UnitId;}
			set
			{
				_UnitId = value;
				OnPropertyChanged();
			}
		}
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
