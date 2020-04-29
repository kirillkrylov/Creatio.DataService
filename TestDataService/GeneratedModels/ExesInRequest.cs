using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExesInRequest")]
	public class ExesInRequest : BaseEntity
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
		private decimal _AmountEuro;
		[CProperty(ColumnPath ="AmountEuro")]
		public decimal AmountEuro
		{
			get{return _AmountEuro;}
			set
			{
				_AmountEuro = value;
				OnPropertyChanged();
			}
		}
		private bool _AvailabilityOfPrimaryDocuments;
		[CProperty(ColumnPath ="AvailabilityOfPrimaryDocuments")]
		public bool AvailabilityOfPrimaryDocuments
		{
			get{return _AvailabilityOfPrimaryDocuments;}
			set
			{
				_AvailabilityOfPrimaryDocuments = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private string _ExesNumber;
		[CProperty(ColumnPath ="ExesNumber")]
		public string ExesNumber
		{
			get{return _ExesNumber;}
			set
			{
				_ExesNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _ExesStatusId;
		[CProperty(ColumnPath ="ExesStatusId")]
		public Guid ExesStatusId
		{
			get{return _ExesStatusId;}
			set
			{
				_ExesStatusId = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactualAmount;
		[CProperty(ColumnPath ="FactualAmount")]
		public decimal FactualAmount
		{
			get{return _FactualAmount;}
			set
			{
				_FactualAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactualAmountBaseCurrency;
		[CProperty(ColumnPath ="FactualAmountBaseCurrency")]
		public decimal FactualAmountBaseCurrency
		{
			get{return _FactualAmountBaseCurrency;}
			set
			{
				_FactualAmountBaseCurrency = value;
				OnPropertyChanged();
			}
		}
		private Guid _FinanceExecutorId;
		[CProperty(ColumnPath ="FinanceExecutorId")]
		public Guid FinanceExecutorId
		{
			get{return _FinanceExecutorId;}
			set
			{
				_FinanceExecutorId = value;
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
		private bool _IsNonBudgetExes;
		[CProperty(ColumnPath ="IsNonBudgetExes")]
		public bool IsNonBudgetExes
		{
			get{return _IsNonBudgetExes;}
			set
			{
				_IsNonBudgetExes = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadSourceId;
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId
		{
			get{return _LeadSourceId;}
			set
			{
				_LeadSourceId = value;
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
		private bool _PartialPayment;
		[CProperty(ColumnPath ="PartialPayment")]
		public bool PartialPayment
		{
			get{return _PartialPayment;}
			set
			{
				_PartialPayment = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PayDate;
		[CProperty(ColumnPath ="PayDate")]
		public DateTime PayDate
		{
			get{return _PayDate;}
			set
			{
				_PayDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _PayerTerritoryId;
		[CProperty(ColumnPath ="PayerTerritoryId")]
		public Guid PayerTerritoryId
		{
			get{return _PayerTerritoryId;}
			set
			{
				_PayerTerritoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentReasonId;
		[CProperty(ColumnPath ="PaymentReasonId")]
		public Guid PaymentReasonId
		{
			get{return _PaymentReasonId;}
			set
			{
				_PaymentReasonId = value;
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
		private DateTime _PlannedPayDate;
		[CProperty(ColumnPath ="PlannedPayDate")]
		public DateTime PlannedPayDate
		{
			get{return _PlannedPayDate;}
			set
			{
				_PlannedPayDate = value;
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
		private Guid _RequestExesId;
		[CProperty(ColumnPath ="RequestExesId")]
		public Guid RequestExesId
		{
			get{return _RequestExesId;}
			set
			{
				_RequestExesId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RequestExesTypeId;
		[CProperty(ColumnPath ="RequestExesTypeId")]
		public Guid RequestExesTypeId
		{
			get{return _RequestExesTypeId;}
			set
			{
				_RequestExesTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SettlementAccountId;
		[CProperty(ColumnPath ="SettlementAccountId")]
		public Guid SettlementAccountId
		{
			get{return _SettlementAccountId;}
			set
			{
				_SettlementAccountId = value;
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
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:FinanceExecutorId")]
		public Contact FinanceExecutor { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ExesStatus:ExesStatusId")]
		public ExesStatus ExesStatus { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="LeadSource:LeadSourceId")]
		public LeadSource LeadSource { get; set; }
		[CProperty(Navigation ="PaymentReason:PaymentReasonId")]
		public PaymentReason PaymentReason { get; set; }
		[CProperty(Navigation ="PaymentType:PaymentTypeId")]
		public PaymentType PaymentType { get; set; }
		[CProperty(Navigation ="RequestExes:RequestExesId")]
		public RequestExes RequestExes { get; set; }
		[CProperty(Navigation ="RequestExesType:RequestExesTypeId")]
		public RequestExesType RequestExesType { get; set; }
		[CProperty(Navigation ="SettlementAccounts:SettlementAccountId")]
		public SettlementAccounts SettlementAccount { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		[CProperty(Navigation ="Territory:PayerTerritoryId")]
		public Territory PayerTerritory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ExesInRequestHistory:ExesInRequestId")]
		public virtual ICollection<ExesInRequestHistory> ExesInRequestHistoryByExesInRequest { get; set; }
		[CProperty(Association ="ExesInRequestInFolder:ExesInRequestId")]
		public virtual ICollection<ExesInRequestInFolder> ExesInRequestInFolderByExesInRequest { get; set; }
		[CProperty(Association ="ExesInRequestInTag:EntityId")]
		public virtual ICollection<ExesInRequestInTag> ExesInRequestInTagByEntity { get; set; }
		[CProperty(Association ="ExesScheduleOfPayments:ExesInRequestId")]
		public virtual ICollection<ExesScheduleOfPayments> ExesScheduleOfPaymentsByExesInRequest { get; set; }
		#endregion
	}
}
