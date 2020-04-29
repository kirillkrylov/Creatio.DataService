using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Invoice")]
	public class Invoice : BaseEntity
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
		private bool _CloseInvoice;
		[CProperty(ColumnPath ="CloseInvoice")]
		public bool CloseInvoice
		{
			get{return _CloseInvoice;}
			set
			{
				_CloseInvoice = value;
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
		private decimal _CrossRateOnBillingDate;
		[CProperty(ColumnPath ="CrossRateOnBillingDate")]
		public decimal CrossRateOnBillingDate
		{
			get{return _CrossRateOnBillingDate;}
			set
			{
				_CrossRateOnBillingDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _CrossRateOnPaymentDate;
		[CProperty(ColumnPath ="CrossRateOnPaymentDate")]
		public decimal CrossRateOnPaymentDate
		{
			get{return _CrossRateOnPaymentDate;}
			set
			{
				_CrossRateOnPaymentDate = value;
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
		private Guid _DepartmentId;
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId
		{
			get{return _DepartmentId;}
			set
			{
				_DepartmentId = value;
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
		private bool _FillBonusesManually;
		[CProperty(ColumnPath ="FillBonusesManually")]
		public bool FillBonusesManually
		{
			get{return _FillBonusesManually;}
			set
			{
				_FillBonusesManually = value;
				OnPropertyChanged();
			}
		}
		private bool _FillDetailsManually;
		[CProperty(ColumnPath ="FillDetailsManually")]
		public bool FillDetailsManually
		{
			get{return _FillDetailsManually;}
			set
			{
				_FillDetailsManually = value;
				OnPropertyChanged();
			}
		}
		private Guid _FundTypeId;
		[CProperty(ColumnPath ="FundTypeId")]
		public Guid FundTypeId
		{
			get{return _FundTypeId;}
			set
			{
				_FundTypeId = value;
				OnPropertyChanged();
			}
		}
		private bool _GlbCurrentFY;
		[CProperty(ColumnPath ="GlbCurrentFY")]
		public bool GlbCurrentFY
		{
			get{return _GlbCurrentFY;}
			set
			{
				_GlbCurrentFY = value;
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
		private DateTime _IntegratedOn;
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn
		{
			get{return _IntegratedOn;}
			set
			{
				_IntegratedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _InvoiceKindId;
		[CProperty(ColumnPath ="InvoiceKindId")]
		public Guid InvoiceKindId
		{
			get{return _InvoiceKindId;}
			set
			{
				_InvoiceKindId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsHasProducts;
		[CProperty(ColumnPath ="IsHasProducts")]
		public bool IsHasProducts
		{
			get{return _IsHasProducts;}
			set
			{
				_IsHasProducts = value;
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
		private decimal _Margin;
		[CProperty(ColumnPath ="Margin")]
		public decimal Margin
		{
			get{return _Margin;}
			set
			{
				_Margin = value;
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
		private string _NotesForSection;
		[CProperty(ColumnPath ="NotesForSection")]
		public string NotesForSection
		{
			get{return _NotesForSection;}
			set
			{
				_NotesForSection = value;
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
		private decimal _PaymentAmountWithoutTax;
		[CProperty(ColumnPath ="PaymentAmountWithoutTax")]
		public decimal PaymentAmountWithoutTax
		{
			get{return _PaymentAmountWithoutTax;}
			set
			{
				_PaymentAmountWithoutTax = value;
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
		private decimal _PaymentCurrencyRate;
		[CProperty(ColumnPath ="PaymentCurrencyRate")]
		public decimal PaymentCurrencyRate
		{
			get{return _PaymentCurrencyRate;}
			set
			{
				_PaymentCurrencyRate = value;
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
		private decimal _PrimaryPaymentAmountWithoutTax;
		[CProperty(ColumnPath ="PrimaryPaymentAmountWithoutTax")]
		public decimal PrimaryPaymentAmountWithoutTax
		{
			get{return _PrimaryPaymentAmountWithoutTax;}
			set
			{
				_PrimaryPaymentAmountWithoutTax = value;
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
		private bool _RemindToOwner;
		[CProperty(ColumnPath ="RemindToOwner")]
		public bool RemindToOwner
		{
			get{return _RemindToOwner;}
			set
			{
				_RemindToOwner = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RemindToOwnerDate;
		[CProperty(ColumnPath ="RemindToOwnerDate")]
		public DateTime RemindToOwnerDate
		{
			get{return _RemindToOwnerDate;}
			set
			{
				_RemindToOwnerDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SpecificationId;
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId
		{
			get{return _SpecificationId;}
			set
			{
				_SpecificationId = value;
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
		private Guid _Uid1C;
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C
		{
			get{return _Uid1C;}
			set
			{
				_Uid1C = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation ="Account:PayerId")]
		public Account Payer { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:SupplierBillingInfoId")]
		public AccountBillingInfo SupplierBillingInfo { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:CustomerBillingInfoId")]
		public AccountBillingInfo CustomerBillingInfo { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="Contract:SpecificationId")]
		public Contract Specification { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Currency:PaymentCurrencyId")]
		public Currency PaymentCurrency { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="FundType:FundTypeId")]
		public FundType FundType { get; set; }
		[CProperty(Navigation ="InvoiceKind:InvoiceKindId")]
		public InvoiceKind InvoiceKind { get; set; }
		[CProperty(Navigation ="InvoicePaymentStatus:PaymentStatusId")]
		public InvoicePaymentStatus PaymentStatus { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:DepartmentId")]
		public OrgStructureUnit Department { get; set; }
		[CProperty(Navigation ="PaymentType:PaymentTypeId")]
		public PaymentType PaymentType { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="SysModuleReport:PrintableId")]
		public SysModuleReport Printable { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:InvoiceId")]
		public virtual ICollection<Activity> ActivityByInvoice { get; set; }
		[CProperty(Association ="Bonus:InvoiceId")]
		public virtual ICollection<Bonus> BonusByInvoice { get; set; }
		[CProperty(Association ="CorrespondenceLink:InvoiceId")]
		public virtual ICollection<CorrespondenceLink> CorrespondenceLinkByInvoice { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:InvoiceId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByInvoice { get; set; }
		[CProperty(Association ="InternalRequest:InvoiceId")]
		public virtual ICollection<InternalRequest> InternalRequestByInvoice { get; set; }
		[CProperty(Association ="InvoiceAccrueRole:InvoiceId")]
		public virtual ICollection<InvoiceAccrueRole> InvoiceAccrueRoleByInvoice { get; set; }
		[CProperty(Association ="InvoiceAct:InvoiceId")]
		public virtual ICollection<InvoiceAct> InvoiceActByInvoice { get; set; }
		[CProperty(Association ="InvoiceFile:InvoiceId")]
		public virtual ICollection<InvoiceFile> InvoiceFileByInvoice { get; set; }
		[CProperty(Association ="InvoiceHistory:InvoiceId")]
		public virtual ICollection<InvoiceHistory> InvoiceHistoryByInvoice { get; set; }
		[CProperty(Association ="InvoiceInFolder:InvoiceId")]
		public virtual ICollection<InvoiceInFolder> InvoiceInFolderByInvoice { get; set; }
		[CProperty(Association ="InvoiceInTag:EntityId")]
		public virtual ICollection<InvoiceInTag> InvoiceInTagByEntity { get; set; }
		[CProperty(Association ="InvoicePayments:InvoiceId")]
		public virtual ICollection<InvoicePayments> InvoicePaymentsByInvoice { get; set; }
		[CProperty(Association ="InvoiceProduct:InvoiceId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByInvoice { get; set; }
		[CProperty(Association ="InvoiceVisa:InvoiceId")]
		public virtual ICollection<InvoiceVisa> InvoiceVisaByInvoice { get; set; }
		[CProperty(Association ="OpportunityForecast:InvoiceId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByInvoice { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:InvoiceId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByInvoice { get; set; }
		[CProperty(Association ="PRMTransaction:InvoiceId")]
		public virtual ICollection<PRMTransaction> PRMTransactionByInvoice { get; set; }
		[CProperty(Association ="PRMTransactionHistory:InvoiceId")]
		public virtual ICollection<PRMTransactionHistory> PRMTransactionHistoryByInvoice { get; set; }
		[CProperty(Association ="SupplyPaymentElement:InvoiceId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByInvoice { get; set; }
		[CProperty(Association ="ToEmployeeQuote:InvoiceId")]
		public virtual ICollection<ToEmployeeQuote> ToEmployeeQuoteByInvoice { get; set; }
		[CProperty(Association ="TsOrderExpense:InvoiceId")]
		public virtual ICollection<TsOrderExpense> TsOrderExpenseByInvoice { get; set; }
		[CProperty(Association ="VwBonusInRequest:InvoiceId")]
		public virtual ICollection<VwBonusInRequest> VwBonusInRequestByInvoice { get; set; }
		[CProperty(Association ="VwInvoiceLastComment:InvoiceId")]
		public virtual ICollection<VwInvoiceLastComment> VwInvoiceLastCommentByInvoice { get; set; }
		[CProperty(Association ="VwInvoiceProduct:InvoiceId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByInvoice { get; set; }
		[CProperty(Association ="VwOrderExpenseProduct:InvoiceId")]
		public virtual ICollection<VwOrderExpenseProduct> VwOrderExpenseProductByInvoice { get; set; }
		#endregion
	}
}
