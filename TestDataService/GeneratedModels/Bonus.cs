using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Bonus")]
	public class Bonus : BaseEntity
	{
		#region Values
		private DateTime _AccrualDate;
		[CProperty(ColumnPath ="AccrualDate")]
		public DateTime AccrualDate
		{
			get{return _AccrualDate;}
			set
			{
				_AccrualDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccrualPeriodId;
		[CProperty(ColumnPath ="AccrualPeriodId")]
		public Guid AccrualPeriodId
		{
			get{return _AccrualPeriodId;}
			set
			{
				_AccrualPeriodId = value;
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
		private Guid _BonusCategoryId;
		[CProperty(ColumnPath ="BonusCategoryId")]
		public Guid BonusCategoryId
		{
			get{return _BonusCategoryId;}
			set
			{
				_BonusCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CalculationRuleId;
		[CProperty(ColumnPath ="CalculationRuleId")]
		public Guid CalculationRuleId
		{
			get{return _CalculationRuleId;}
			set
			{
				_CalculationRuleId = value;
				OnPropertyChanged();
			}
		}
		private bool _ChargedManually;
		[CProperty(ColumnPath ="ChargedManually")]
		public bool ChargedManually
		{
			get{return _ChargedManually;}
			set
			{
				_ChargedManually = value;
				OnPropertyChanged();
			}
		}
		private decimal _Coefficient;
		[CProperty(ColumnPath ="Coefficient")]
		public decimal Coefficient
		{
			get{return _Coefficient;}
			set
			{
				_Coefficient = value;
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
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
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
		private Guid _InvoiceId;
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId
		{
			get{return _InvoiceId;}
			set
			{
				_InvoiceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InvoiceProductId;
		[CProperty(ColumnPath ="InvoiceProductId")]
		public Guid InvoiceProductId
		{
			get{return _InvoiceProductId;}
			set
			{
				_InvoiceProductId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsTarget;
		[CProperty(ColumnPath ="IsTarget")]
		public bool IsTarget
		{
			get{return _IsTarget;}
			set
			{
				_IsTarget = value;
				OnPropertyChanged();
			}
		}
		private decimal _ManagerPercentage;
		[CProperty(ColumnPath ="ManagerPercentage")]
		public decimal ManagerPercentage
		{
			get{return _ManagerPercentage;}
			set
			{
				_ManagerPercentage = value;
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
		private Guid _PaymentSchemaRecordId;
		[CProperty(ColumnPath ="PaymentSchemaRecordId")]
		public Guid PaymentSchemaRecordId
		{
			get{return _PaymentSchemaRecordId;}
			set
			{
				_PaymentSchemaRecordId = value;
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
		private string _Quartile;
		[CProperty(ColumnPath ="Quartile")]
		public string Quartile
		{
			get{return _Quartile;}
			set
			{
				_Quartile = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="BonusCategory:BonusCategoryId")]
		public BonusCategory BonusCategory { get; set; }
		[CProperty(Navigation ="BonusState:StateId")]
		public BonusState State { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="InvoiceProduct:InvoiceProductId")]
		public InvoiceProduct InvoiceProduct { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="PaymentRule:CalculationRuleId")]
		public PaymentRule CalculationRule { get; set; }
		[CProperty(Navigation ="Period:AccrualPeriodId")]
		public Period AccrualPeriod { get; set; }
		[CProperty(Navigation ="SaleType:SaleTypeId")]
		public SaleType SaleType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BonusFile:BonusId")]
		public virtual ICollection<BonusFile> BonusFileByBonus { get; set; }
		[CProperty(Association ="BonusHistory:BonusId")]
		public virtual ICollection<BonusHistory> BonusHistoryByBonus { get; set; }
		[CProperty(Association ="BonusInFolder:BonusId")]
		public virtual ICollection<BonusInFolder> BonusInFolderByBonus { get; set; }
		[CProperty(Association ="BonusInTag:EntityId")]
		public virtual ICollection<BonusInTag> BonusInTagByEntity { get; set; }
		[CProperty(Association ="BonusVisa:BonusId")]
		public virtual ICollection<BonusVisa> BonusVisaByBonus { get; set; }
		#endregion
	}
}
