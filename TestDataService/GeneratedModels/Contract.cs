using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Contract")]
	public class Contract : BaseEntity
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
		private decimal _ACV;
		[CProperty(ColumnPath ="ACV")]
		public decimal ACV
		{
			get{return _ACV;}
			set
			{
				_ACV = value;
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
		private Guid _CompanyAddressId;
		[CProperty(ColumnPath ="CompanyAddressId")]
		public Guid CompanyAddressId
		{
			get{return _CompanyAddressId;}
			set
			{
				_CompanyAddressId = value;
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
		private decimal _ContractLength;
		[CProperty(ColumnPath ="ContractLength")]
		public decimal ContractLength
		{
			get{return _ContractLength;}
			set
			{
				_ContractLength = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContractPartyId;
		[CProperty(ColumnPath ="ContractPartyId")]
		public Guid ContractPartyId
		{
			get{return _ContractPartyId;}
			set
			{
				_ContractPartyId = value;
				OnPropertyChanged();
			}
		}
		private string _ContractRecipientAddress;
		[CProperty(ColumnPath ="ContractRecipientAddress")]
		public string ContractRecipientAddress
		{
			get{return _ContractRecipientAddress;}
			set
			{
				_ContractRecipientAddress = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContractRecipientId;
		[CProperty(ColumnPath ="ContractRecipientId")]
		public Guid ContractRecipientId
		{
			get{return _ContractRecipientId;}
			set
			{
				_ContractRecipientId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ContractReturnDate;
		[CProperty(ColumnPath ="ContractReturnDate")]
		public DateTime ContractReturnDate
		{
			get{return _ContractReturnDate;}
			set
			{
				_ContractReturnDate = value;
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
		private decimal _CurrencyRateOnStartDate;
		[CProperty(ColumnPath ="CurrencyRateOnStartDate")]
		public decimal CurrencyRateOnStartDate
		{
			get{return _CurrencyRateOnStartDate;}
			set
			{
				_CurrencyRateOnStartDate = value;
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
		private decimal _DR;
		[CProperty(ColumnPath ="DR")]
		public decimal DR
		{
			get{return _DR;}
			set
			{
				_DR = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
				OnPropertyChanged();
			}
		}
		private bool _FixedEndDate;
		[CProperty(ColumnPath ="FixedEndDate")]
		public bool FixedEndDate
		{
			get{return _FixedEndDate;}
			set
			{
				_FixedEndDate = value;
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
		private Guid _OurCompanyId;
		[CProperty(ColumnPath ="OurCompanyId")]
		public Guid OurCompanyId
		{
			get{return _OurCompanyId;}
			set
			{
				_OurCompanyId = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private Guid _PrintableId;
		[CProperty(ColumnPath ="PrintableId")]
		public Guid PrintableId
		{
			get{return _PrintableId;}
			set
			{
				_PrintableId = value;
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
		private decimal _RecognizedRevenue;
		[CProperty(ColumnPath ="RecognizedRevenue")]
		public decimal RecognizedRevenue
		{
			get{return _RecognizedRevenue;}
			set
			{
				_RecognizedRevenue = value;
				OnPropertyChanged();
			}
		}
		private Guid _SalesAssistantContactId;
		[CProperty(ColumnPath ="SalesAssistantContactId")]
		public Guid SalesAssistantContactId
		{
			get{return _SalesAssistantContactId;}
			set
			{
				_SalesAssistantContactId = value;
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
		private Guid _SupplierBillingInfoId;
		[CProperty(ColumnPath ="SupplierBillingInfoId")]
		public Guid SupplierBillingInfoId
		{
			get{return _SupplierBillingInfoId;}
			set
			{
				_SupplierBillingInfoId = value;
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
		private decimal _TCV;
		[CProperty(ColumnPath ="TCV")]
		public decimal TCV
		{
			get{return _TCV;}
			set
			{
				_TCV = value;
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
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:OurCompanyId")]
		public Account OurCompany { get; set; }
		[CProperty(Navigation ="AccountAddress:CompanyAddressId")]
		public AccountAddress CompanyAddress { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:SupplierBillingInfoId")]
		public AccountBillingInfo SupplierBillingInfo { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:CustomerBillingInfoId")]
		public AccountBillingInfo CustomerBillingInfo { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:ContractRecipientId")]
		public Contact ContractRecipient { get; set; }
		[CProperty(Navigation ="Contact:SalesAssistantContactId")]
		public Contact SalesAssistantContact { get; set; }
		[CProperty(Navigation ="Contract:ParentId")]
		public Contract Parent { get; set; }
		[CProperty(Navigation ="ContractParties:ContractPartyId")]
		public ContractParties ContractParty { get; set; }
		[CProperty(Navigation ="ContractState:StateId")]
		public ContractState State { get; set; }
		[CProperty(Navigation ="ContractType:TypeId")]
		public ContractType Type { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="DeliveryType:DeliveryTypeId")]
		public DeliveryType DeliveryType { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="SysModuleReport:PrintableId")]
		public SysModuleReport Printable { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ContractId")]
		public virtual ICollection<Activity> ActivityByContract { get; set; }
		[CProperty(Association ="Contract:ParentId")]
		public virtual ICollection<Contract> ContractByParent { get; set; }
		[CProperty(Association ="ContractFile:ContractId")]
		public virtual ICollection<ContractFile> ContractFileByContract { get; set; }
		[CProperty(Association ="ContractInFolder:ContractId")]
		public virtual ICollection<ContractInFolder> ContractInFolderByContract { get; set; }
		[CProperty(Association ="ContractInTag:EntityId")]
		public virtual ICollection<ContractInTag> ContractInTagByEntity { get; set; }
		[CProperty(Association ="ContractVisa:ContractId")]
		public virtual ICollection<ContractVisa> ContractVisaByContract { get; set; }
		[CProperty(Association ="ContractVisasList:ContractId")]
		public virtual ICollection<ContractVisasList> ContractVisasListByContract { get; set; }
		[CProperty(Association ="CorrespondenceLink:ContractId")]
		public virtual ICollection<CorrespondenceLink> CorrespondenceLinkByContract { get; set; }
		[CProperty(Association ="Document:ContractId")]
		public virtual ICollection<Document> DocumentByContract { get; set; }
		[CProperty(Association ="Invoice:ContractId")]
		public virtual ICollection<Invoice> InvoiceByContract { get; set; }
		[CProperty(Association ="Invoice:SpecificationId")]
		public virtual ICollection<Invoice> InvoiceBySpecification { get; set; }
		[CProperty(Association ="OrderProduct:ContractId")]
		public virtual ICollection<OrderProduct> OrderProductByContract { get; set; }
		[CProperty(Association ="SaaSMetrics:SpecificationId")]
		public virtual ICollection<SaaSMetrics> SaaSMetricsBySpecification { get; set; }
		[CProperty(Association ="SaaSMetrics:ParentContractId")]
		public virtual ICollection<SaaSMetrics> SaaSMetricsByParentContract { get; set; }
		[CProperty(Association ="SaaSMetricsTransactions:SpecificationId")]
		public virtual ICollection<SaaSMetricsTransactions> SaaSMetricsTransactionsBySpecification { get; set; }
		[CProperty(Association ="SpecInContract:ContractId")]
		public virtual ICollection<SpecInContract> SpecInContractByContract { get; set; }
		[CProperty(Association ="SpecInContractHistory:ContractId")]
		public virtual ICollection<SpecInContractHistory> SpecInContractHistoryByContract { get; set; }
		[CProperty(Association ="SupplyPaymentElement:ContractId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByContract { get; set; }
		[CProperty(Association ="VwOrderProduct:ContractId")]
		public virtual ICollection<VwOrderProduct> VwOrderProductByContract { get; set; }
		#endregion
	}
}
