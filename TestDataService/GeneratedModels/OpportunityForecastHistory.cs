using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityForecastHistory")]
	public class OpportunityForecastHistory : BaseEntity
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
		private string _Changes;
		[CProperty(ColumnPath ="Changes")]
		public string Changes
		{
			get{return _Changes;}
			set
			{
				_Changes = value;
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
		private int _Days;
		[CProperty(ColumnPath ="Days")]
		public int Days
		{
			get{return _Days;}
			set
			{
				_Days = value;
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
		private Guid _DeliveryId;
		[CProperty(ColumnPath ="DeliveryId")]
		public Guid DeliveryId
		{
			get{return _DeliveryId;}
			set
			{
				_DeliveryId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Expenses;
		[CProperty(ColumnPath ="Expenses")]
		public decimal Expenses
		{
			get{return _Expenses;}
			set
			{
				_Expenses = value;
				OnPropertyChanged();
			}
		}
		private Guid _ForecastOwnerId;
		[CProperty(ColumnPath ="ForecastOwnerId")]
		public Guid ForecastOwnerId
		{
			get{return _ForecastOwnerId;}
			set
			{
				_ForecastOwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ForecastProductTypeId;
		[CProperty(ColumnPath ="ForecastProductTypeId")]
		public Guid ForecastProductTypeId
		{
			get{return _ForecastProductTypeId;}
			set
			{
				_ForecastProductTypeId = value;
				OnPropertyChanged();
			}
		}
		private decimal _GrossMargin;
		[CProperty(ColumnPath ="GrossMargin")]
		public decimal GrossMargin
		{
			get{return _GrossMargin;}
			set
			{
				_GrossMargin = value;
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
		private bool _IsContractSigned;
		[CProperty(ColumnPath ="IsContractSigned")]
		public bool IsContractSigned
		{
			get{return _IsContractSigned;}
			set
			{
				_IsContractSigned = value;
				OnPropertyChanged();
			}
		}
		private bool _IsForecastItem;
		[CProperty(ColumnPath ="IsForecastItem")]
		public bool IsForecastItem
		{
			get{return _IsForecastItem;}
			set
			{
				_IsForecastItem = value;
				OnPropertyChanged();
			}
		}
		private bool _IsTargetChanges;
		[CProperty(ColumnPath ="IsTargetChanges")]
		public bool IsTargetChanges
		{
			get{return _IsTargetChanges;}
			set
			{
				_IsTargetChanges = value;
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
		private Guid _OpportunityForecastId;
		[CProperty(ColumnPath ="OpportunityForecastId")]
		public Guid OpportunityForecastId
		{
			get{return _OpportunityForecastId;}
			set
			{
				_OpportunityForecastId = value;
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
		private Guid _PaymentModelId;
		[CProperty(ColumnPath ="PaymentModelId")]
		public Guid PaymentModelId
		{
			get{return _PaymentModelId;}
			set
			{
				_PaymentModelId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PercentOfTCV;
		[CProperty(ColumnPath ="PercentOfTCV")]
		public decimal PercentOfTCV
		{
			get{return _PercentOfTCV;}
			set
			{
				_PercentOfTCV = value;
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
		private decimal _Proceeds;
		[CProperty(ColumnPath ="Proceeds")]
		public decimal Proceeds
		{
			get{return _Proceeds;}
			set
			{
				_Proceeds = value;
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
		private Guid _ProductKindId;
		[CProperty(ColumnPath ="ProductKindId")]
		public Guid ProductKindId
		{
			get{return _ProductKindId;}
			set
			{
				_ProductKindId = value;
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
		private Guid _SupportLevelId;
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId
		{
			get{return _SupportLevelId;}
			set
			{
				_SupportLevelId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ForecastOwnerId")]
		public Contact ForecastOwner { get; set; }
		[CProperty(Navigation ="ForecastProductType:ForecastProductTypeId")]
		public ForecastProductType ForecastProductType { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityForecast:OpportunityForecastId")]
		public OpportunityForecast OpportunityForecast { get; set; }
		[CProperty(Navigation ="OpportunityForecastStatus:StatusId")]
		public OpportunityForecastStatus Status { get; set; }
		[CProperty(Navigation ="OpportunityForecastType:TypeId")]
		public OpportunityForecastType Type { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProductPeriod:PeriodId")]
		public OrderProductPeriod Period { get; set; }
		[CProperty(Navigation ="PaymentModel:PaymentModelId")]
		public PaymentModel PaymentModel { get; set; }
		[CProperty(Navigation ="ProductKind:ProductKindId")]
		public ProductKind ProductKind { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:DeliveryId")]
		public SupplyPaymentElement Delivery { get; set; }
		[CProperty(Navigation ="SupportLevel:SupportLevelId")]
		public SupportLevel SupportLevel { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
