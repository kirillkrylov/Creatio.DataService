using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupplyPaymentElement")]
	public class SupplyPaymentElement : BaseEntity
	{
		#region Values
		private Guid _ActId;
		[CProperty(ColumnPath ="ActId")]
		public Guid ActId
		{
			get{return _ActId;}
			set
			{
				_ActId = value;
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
		private decimal _AmountFact;
		[CProperty(ColumnPath ="AmountFact")]
		public decimal AmountFact
		{
			get{return _AmountFact;}
			set
			{
				_AmountFact = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountFactWithTax;
		[CProperty(ColumnPath ="AmountFactWithTax")]
		public decimal AmountFactWithTax
		{
			get{return _AmountFactWithTax;}
			set
			{
				_AmountFactWithTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountPlan;
		[CProperty(ColumnPath ="AmountPlan")]
		public decimal AmountPlan
		{
			get{return _AmountPlan;}
			set
			{
				_AmountPlan = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountPlanWithoutTax;
		[CProperty(ColumnPath ="AmountPlanWithoutTax")]
		public decimal AmountPlanWithoutTax
		{
			get{return _AmountPlanWithoutTax;}
			set
			{
				_AmountPlanWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _AmountPlanWithTax;
		[CProperty(ColumnPath ="AmountPlanWithTax")]
		public decimal AmountPlanWithTax
		{
			get{return _AmountPlanWithTax;}
			set
			{
				_AmountPlanWithTax = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseId;
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId
		{
			get{return _CaseId;}
			set
			{
				_CaseId = value;
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
		private decimal _Commission;
		[CProperty(ColumnPath ="Commission")]
		public decimal Commission
		{
			get{return _Commission;}
			set
			{
				_Commission = value;
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
		private DateTime _DateFact;
		[CProperty(ColumnPath ="DateFact")]
		public DateTime DateFact
		{
			get{return _DateFact;}
			set
			{
				_DateFact = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DatePlan;
		[CProperty(ColumnPath ="DatePlan")]
		public DateTime DatePlan
		{
			get{return _DatePlan;}
			set
			{
				_DatePlan = value;
				OnPropertyChanged();
			}
		}
		private int _Delay;
		[CProperty(ColumnPath ="Delay")]
		public int Delay
		{
			get{return _Delay;}
			set
			{
				_Delay = value;
				OnPropertyChanged();
			}
		}
		private Guid _DelayTypeId;
		[CProperty(ColumnPath ="DelayTypeId")]
		public Guid DelayTypeId
		{
			get{return _DelayTypeId;}
			set
			{
				_DelayTypeId = value;
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
		private decimal _Percentage;
		[CProperty(ColumnPath ="Percentage")]
		public decimal Percentage
		{
			get{return _Percentage;}
			set
			{
				_Percentage = value;
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
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
				OnPropertyChanged();
			}
		}
		private Guid _PreviousElementId;
		[CProperty(ColumnPath ="PreviousElementId")]
		public Guid PreviousElementId
		{
			get{return _PreviousElementId;}
			set
			{
				_PreviousElementId = value;
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
		private decimal _PrimaryAmountFact;
		[CProperty(ColumnPath ="PrimaryAmountFact")]
		public decimal PrimaryAmountFact
		{
			get{return _PrimaryAmountFact;}
			set
			{
				_PrimaryAmountFact = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountFactWithTax;
		[CProperty(ColumnPath ="PrimaryAmountFactWithTax")]
		public decimal PrimaryAmountFactWithTax
		{
			get{return _PrimaryAmountFactWithTax;}
			set
			{
				_PrimaryAmountFactWithTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountPlan;
		[CProperty(ColumnPath ="PrimaryAmountPlan")]
		public decimal PrimaryAmountPlan
		{
			get{return _PrimaryAmountPlan;}
			set
			{
				_PrimaryAmountPlan = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountPlanWithoutTax;
		[CProperty(ColumnPath ="PrimaryAmountPlanWithoutTax")]
		public decimal PrimaryAmountPlanWithoutTax
		{
			get{return _PrimaryAmountPlanWithoutTax;}
			set
			{
				_PrimaryAmountPlanWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountPlanWithTax;
		[CProperty(ColumnPath ="PrimaryAmountPlanWithTax")]
		public decimal PrimaryAmountPlanWithTax
		{
			get{return _PrimaryAmountPlanWithTax;}
			set
			{
				_PrimaryAmountPlanWithTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTaxPlanAmount;
		[CProperty(ColumnPath ="PrimaryTaxPlanAmount")]
		public decimal PrimaryTaxPlanAmount
		{
			get{return _PrimaryTaxPlanAmount;}
			set
			{
				_PrimaryTaxPlanAmount = value;
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
		private string _Products;
		[CProperty(ColumnPath ="Products")]
		public string Products
		{
			get{return _Products;}
			set
			{
				_Products = value;
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
		private Guid _RequestId;
		[CProperty(ColumnPath ="RequestId")]
		public Guid RequestId
		{
			get{return _RequestId;}
			set
			{
				_RequestId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServicePactId;
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId
		{
			get{return _ServicePactId;}
			set
			{
				_ServicePactId = value;
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
		private Guid _TargetId;
		[CProperty(ColumnPath ="TargetId")]
		public Guid TargetId
		{
			get{return _TargetId;}
			set
			{
				_TargetId = value;
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
		private decimal _TaxPlanAmount;
		[CProperty(ColumnPath ="TaxPlanAmount")]
		public decimal TaxPlanAmount
		{
			get{return _TaxPlanAmount;}
			set
			{
				_TaxPlanAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalCommission;
		[CProperty(ColumnPath ="TotalCommission")]
		public decimal TotalCommission
		{
			get{return _TotalCommission;}
			set
			{
				_TotalCommission = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalWithoutTax;
		[CProperty(ColumnPath ="TotalWithoutTax")]
		public decimal TotalWithoutTax
		{
			get{return _TotalWithoutTax;}
			set
			{
				_TotalWithoutTax = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalWithTax;
		[CProperty(ColumnPath ="TotalWithTax")]
		public decimal TotalWithTax
		{
			get{return _TotalWithTax;}
			set
			{
				_TotalWithTax = value;
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
		[CProperty(Navigation ="Account:TargetId")]
		public Account Target { get; set; }
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Document:ActId")]
		public Document Act { get; set; }
		[CProperty(Navigation ="InternalRequest:RequestId")]
		public InternalRequest Request { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProduct:ProductId")]
		public OrderProduct Product { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		[CProperty(Navigation ="ProductDeliveryType:DeliveryTypeId")]
		public ProductDeliveryType DeliveryType { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="ServicePact:ServicePactId")]
		public ServicePact ServicePact { get; set; }
		[CProperty(Navigation ="SupplyPaymentDelay:DelayTypeId")]
		public SupplyPaymentDelay DelayType { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:PreviousElementId")]
		public SupplyPaymentElement PreviousElement { get; set; }
		[CProperty(Navigation ="SupplyPaymentState:StateId")]
		public SupplyPaymentState State { get; set; }
		[CProperty(Navigation ="SupplyPaymentType:TypeId")]
		public SupplyPaymentType Type { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:DeliveryId")]
		public virtual ICollection<Activity> ActivityByDelivery { get; set; }
		[CProperty(Association ="OpportunityForecast:DeliveryId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByDelivery { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:DeliveryId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByDelivery { get; set; }
		[CProperty(Association ="ProductForLicGenerator:SupplyPaymentElementId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorBySupplyPaymentElement { get; set; }
		[CProperty(Association ="ProductInSubscription:SupplyPaymentElementId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionBySupplyPaymentElement { get; set; }
		[CProperty(Association ="SupplyPaymentElement:PreviousElementId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByPreviousElement { get; set; }
		[CProperty(Association ="SupplyPaymentItemFile:SupplyPaymentElementId")]
		public virtual ICollection<SupplyPaymentItemFile> SupplyPaymentItemFileBySupplyPaymentElement { get; set; }
		[CProperty(Association ="SupplyPaymentProduct:SupplyPaymentElementId")]
		public virtual ICollection<SupplyPaymentProduct> SupplyPaymentProductBySupplyPaymentElement { get; set; }
		[CProperty(Association ="VwSupplyPaymentProduct:SupplyPaymentElementId")]
		public virtual ICollection<VwSupplyPaymentProduct> VwSupplyPaymentProductBySupplyPaymentElement { get; set; }
		[CProperty(Association ="VwTSSLA:SupplyPaymentElementId")]
		public virtual ICollection<VwTSSLA> VwTSSLABySupplyPaymentElement { get; set; }
		[CProperty(Association ="VwTSSLAArchive:SupplyPaymentElementId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveBySupplyPaymentElement { get; set; }
		#endregion
	}
}
