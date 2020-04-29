using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Transaction")]
	public class Transaction : BaseEntity
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
		private string _ContractNumber;
		[CProperty(ColumnPath ="ContractNumber")]
		public string ContractNumber
		{
			get{return _ContractNumber;}
			set
			{
				_ContractNumber = value;
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
		private Guid _IncomeTypeId;
		[CProperty(ColumnPath ="IncomeTypeId")]
		public Guid IncomeTypeId
		{
			get{return _IncomeTypeId;}
			set
			{
				_IncomeTypeId = value;
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
		private Guid _ProductInOrderId;
		[CProperty(ColumnPath ="ProductInOrderId")]
		public Guid ProductInOrderId
		{
			get{return _ProductInOrderId;}
			set
			{
				_ProductInOrderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductInSubscriptionId;
		[CProperty(ColumnPath ="ProductInSubscriptionId")]
		public Guid ProductInSubscriptionId
		{
			get{return _ProductInSubscriptionId;}
			set
			{
				_ProductInSubscriptionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StateId;
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId
		{
			get{return _StateId;}
			set
			{
				_StateId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TransactionCategoryId;
		[CProperty(ColumnPath ="TransactionCategoryId")]
		public Guid TransactionCategoryId
		{
			get{return _TransactionCategoryId;}
			set
			{
				_TransactionCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TransactionTypeId;
		[CProperty(ColumnPath ="TransactionTypeId")]
		public Guid TransactionTypeId
		{
			get{return _TransactionTypeId;}
			set
			{
				_TransactionTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProduct:ProductInOrderId")]
		public OrderProduct ProductInOrder { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="ProductDeliveryType:IncomeTypeId")]
		public ProductDeliveryType IncomeType { get; set; }
		[CProperty(Navigation ="ProductInSubscription:ProductInSubscriptionId")]
		public ProductInSubscription ProductInSubscription { get; set; }
		[CProperty(Navigation ="TransactionCategory:TransactionCategoryId")]
		public TransactionCategory TransactionCategory { get; set; }
		[CProperty(Navigation ="TransactionState:StateId")]
		public TransactionState State { get; set; }
		[CProperty(Navigation ="TransactionType:TransactionTypeId")]
		public TransactionType TransactionType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TransactionFile:TransactionId")]
		public virtual ICollection<TransactionFile> TransactionFileByTransaction { get; set; }
		[CProperty(Association ="TransactionHistory:TransactionId")]
		public virtual ICollection<TransactionHistory> TransactionHistoryByTransaction { get; set; }
		[CProperty(Association ="TransactionInFolder:TransactionId")]
		public virtual ICollection<TransactionInFolder> TransactionInFolderByTransaction { get; set; }
		[CProperty(Association ="TransactionInTag:EntityId")]
		public virtual ICollection<TransactionInTag> TransactionInTagByEntity { get; set; }
		#endregion
	}
}
