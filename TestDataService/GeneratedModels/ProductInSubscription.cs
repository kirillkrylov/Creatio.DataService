using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductInSubscription")]
	public class ProductInSubscription : BaseEntity
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
		private DateTime _ActivationDate;
		[CProperty(ColumnPath ="ActivationDate")]
		public DateTime ActivationDate
		{
			get{return _ActivationDate;}
			set
			{
				_ActivationDate = value;
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
		private bool _AtZeroValue;
		[CProperty(ColumnPath ="AtZeroValue")]
		public bool AtZeroValue
		{
			get{return _AtZeroValue;}
			set
			{
				_AtZeroValue = value;
				OnPropertyChanged();
			}
		}
		private decimal _BilledAmount;
		[CProperty(ColumnPath ="BilledAmount")]
		public decimal BilledAmount
		{
			get{return _BilledAmount;}
			set
			{
				_BilledAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _BilledManhours;
		[CProperty(ColumnPath ="BilledManhours")]
		public decimal BilledManhours
		{
			get{return _BilledManhours;}
			set
			{
				_BilledManhours = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CancelDate;
		[CProperty(ColumnPath ="CancelDate")]
		public DateTime CancelDate
		{
			get{return _CancelDate;}
			set
			{
				_CancelDate = value;
				OnPropertyChanged();
			}
		}
		private string _Comments;
		[CProperty(ColumnPath ="Comments")]
		public string Comments
		{
			get{return _Comments;}
			set
			{
				_Comments = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConfItemId;
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId
		{
			get{return _ConfItemId;}
			set
			{
				_ConfItemId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Count;
		[CProperty(ColumnPath ="Count")]
		public decimal Count
		{
			get{return _Count;}
			set
			{
				_Count = value;
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
		private DateTime _DeactivationDate;
		[CProperty(ColumnPath ="DeactivationDate")]
		public DateTime DeactivationDate
		{
			get{return _DeactivationDate;}
			set
			{
				_DeactivationDate = value;
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
		private Guid _InternalRequestId;
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId
		{
			get{return _InternalRequestId;}
			set
			{
				_InternalRequestId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsCompetitive;
		[CProperty(ColumnPath ="IsCompetitive")]
		public bool IsCompetitive
		{
			get{return _IsCompetitive;}
			set
			{
				_IsCompetitive = value;
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
		private bool _IsVefiried;
		[CProperty(ColumnPath ="IsVefiried")]
		public bool IsVefiried
		{
			get{return _IsVefiried;}
			set
			{
				_IsVefiried = value;
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
		private Guid _OrderProductId;
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId
		{
			get{return _OrderProductId;}
			set
			{
				_OrderProductId = value;
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
		private Guid _PurchaseTypeId;
		[CProperty(ColumnPath ="PurchaseTypeId")]
		public Guid PurchaseTypeId
		{
			get{return _PurchaseTypeId;}
			set
			{
				_PurchaseTypeId = value;
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
		private Guid _SubscriptionTypeId;
		[CProperty(ColumnPath ="SubscriptionTypeId")]
		public Guid SubscriptionTypeId
		{
			get{return _SubscriptionTypeId;}
			set
			{
				_SubscriptionTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupplyPaymentElementId;
		[CProperty(ColumnPath ="SupplyPaymentElementId")]
		public Guid SupplyPaymentElementId
		{
			get{return _SupplyPaymentElementId;}
			set
			{
				_SupplyPaymentElementId = value;
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
