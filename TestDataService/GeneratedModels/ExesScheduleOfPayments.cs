using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExesScheduleOfPayments")]
	public class ExesScheduleOfPayments : BaseEntity
	{
		#region Values
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
		private Guid _ExesInRequestId;
		[CProperty(ColumnPath ="ExesInRequestId")]
		public Guid ExesInRequestId
		{
			get{return _ExesInRequestId;}
			set
			{
				_ExesInRequestId = value;
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
		private DateTime _PaymentDate;
		[CProperty(ColumnPath ="PaymentDate")]
		public DateTime PaymentDate
		{
			get{return _PaymentDate;}
			set
			{
				_PaymentDate = value;
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
		private decimal _PlannedAmount;
		[CProperty(ColumnPath ="PlannedAmount")]
		public decimal PlannedAmount
		{
			get{return _PlannedAmount;}
			set
			{
				_PlannedAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlannedAmountBaseCurrency;
		[CProperty(ColumnPath ="PlannedAmountBaseCurrency")]
		public decimal PlannedAmountBaseCurrency
		{
			get{return _PlannedAmountBaseCurrency;}
			set
			{
				_PlannedAmountBaseCurrency = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlannedPaymentDate;
		[CProperty(ColumnPath ="PlannedPaymentDate")]
		public DateTime PlannedPaymentDate
		{
			get{return _PlannedPaymentDate;}
			set
			{
				_PlannedPaymentDate = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ExesInRequest:ExesInRequestId")]
		public ExesInRequest ExesInRequest { get; set; }
		[CProperty(Navigation ="ExesPaymentStatus:PaymentStatusId")]
		public ExesPaymentStatus PaymentStatus { get; set; }
		[CProperty(Navigation ="SettlementAccounts:SettlementAccountId")]
		public SettlementAccounts SettlementAccount { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
