using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountBillingInfo")]
	public class AccountBillingInfo : BaseEntity
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
		private string _AccountManagerFull;
		[CProperty(ColumnPath ="AccountManagerFull")]
		public string AccountManagerFull
		{
			get{return _AccountManagerFull;}
			set
			{
				_AccountManagerFull = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountManagerId;
		[CProperty(ColumnPath ="AccountManagerId")]
		public Guid AccountManagerId
		{
			get{return _AccountManagerId;}
			set
			{
				_AccountManagerId = value;
				OnPropertyChanged();
			}
		}
		private string _AccountNumber;
		[CProperty(ColumnPath ="AccountNumber")]
		public string AccountNumber
		{
			get{return _AccountNumber;}
			set
			{
				_AccountNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _BankId;
		[CProperty(ColumnPath ="BankId")]
		public Guid BankId
		{
			get{return _BankId;}
			set
			{
				_BankId = value;
				OnPropertyChanged();
			}
		}
		private string _BillingInfo;
		[CProperty(ColumnPath ="BillingInfo")]
		public string BillingInfo
		{
			get{return _BillingInfo;}
			set
			{
				_BillingInfo = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseAusDollar;
		[CProperty(ColumnPath ="CanUseAusDollar")]
		public bool CanUseAusDollar
		{
			get{return _CanUseAusDollar;}
			set
			{
				_CanUseAusDollar = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseDollar;
		[CProperty(ColumnPath ="CanUseDollar")]
		public bool CanUseDollar
		{
			get{return _CanUseDollar;}
			set
			{
				_CanUseDollar = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseEuro;
		[CProperty(ColumnPath ="CanUseEuro")]
		public bool CanUseEuro
		{
			get{return _CanUseEuro;}
			set
			{
				_CanUseEuro = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseFranc;
		[CProperty(ColumnPath ="CanUseFranc")]
		public bool CanUseFranc
		{
			get{return _CanUseFranc;}
			set
			{
				_CanUseFranc = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseHryvnia;
		[CProperty(ColumnPath ="CanUseHryvnia")]
		public bool CanUseHryvnia
		{
			get{return _CanUseHryvnia;}
			set
			{
				_CanUseHryvnia = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUsePounds;
		[CProperty(ColumnPath ="CanUsePounds")]
		public bool CanUsePounds
		{
			get{return _CanUsePounds;}
			set
			{
				_CanUsePounds = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseRuble;
		[CProperty(ColumnPath ="CanUseRuble")]
		public bool CanUseRuble
		{
			get{return _CanUseRuble;}
			set
			{
				_CanUseRuble = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseSingaporeDollar;
		[CProperty(ColumnPath ="CanUseSingaporeDollar")]
		public bool CanUseSingaporeDollar
		{
			get{return _CanUseSingaporeDollar;}
			set
			{
				_CanUseSingaporeDollar = value;
				OnPropertyChanged();
			}
		}
		private bool _CanUseTenge;
		[CProperty(ColumnPath ="CanUseTenge")]
		public bool CanUseTenge
		{
			get{return _CanUseTenge;}
			set
			{
				_CanUseTenge = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChiefAccountantId;
		[CProperty(ColumnPath ="ChiefAccountantId")]
		public Guid ChiefAccountantId
		{
			get{return _ChiefAccountantId;}
			set
			{
				_ChiefAccountantId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CityId;
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId
		{
			get{return _CityId;}
			set
			{
				_CityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CountryId;
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId
		{
			get{return _CountryId;}
			set
			{
				_CountryId = value;
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
		private string _email;
		[CProperty(ColumnPath ="email")]
		public string email
		{
			get{return _email;}
			set
			{
				_email = value;
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
		private string _INN;
		[CProperty(ColumnPath ="INN")]
		public string INN
		{
			get{return _INN;}
			set
			{
				_INN = value;
				OnPropertyChanged();
			}
		}
		private string _IntegrationCode;
		[CProperty(ColumnPath ="IntegrationCode")]
		public string IntegrationCode
		{
			get{return _IntegrationCode;}
			set
			{
				_IntegrationCode = value;
				OnPropertyChanged();
			}
		}
		private string _JobTitleFull;
		[CProperty(ColumnPath ="JobTitleFull")]
		public string JobTitleFull
		{
			get{return _JobTitleFull;}
			set
			{
				_JobTitleFull = value;
				OnPropertyChanged();
			}
		}
		private string _KPP;
		[CProperty(ColumnPath ="KPP")]
		public string KPP
		{
			get{return _KPP;}
			set
			{
				_KPP = value;
				OnPropertyChanged();
			}
		}
		private string _LegalAddress;
		[CProperty(ColumnPath ="LegalAddress")]
		public string LegalAddress
		{
			get{return _LegalAddress;}
			set
			{
				_LegalAddress = value;
				OnPropertyChanged();
			}
		}
		private string _LegalEntityWithoutOwnership;
		[CProperty(ColumnPath ="LegalEntityWithoutOwnership")]
		public string LegalEntityWithoutOwnership
		{
			get{return _LegalEntityWithoutOwnership;}
			set
			{
				_LegalEntityWithoutOwnership = value;
				OnPropertyChanged();
			}
		}
		private string _LegalUnit;
		[CProperty(ColumnPath ="LegalUnit")]
		public string LegalUnit
		{
			get{return _LegalUnit;}
			set
			{
				_LegalUnit = value;
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
		private bool _NonSDN;
		[CProperty(ColumnPath ="NonSDN")]
		public bool NonSDN
		{
			get{return _NonSDN;}
			set
			{
				_NonSDN = value;
				OnPropertyChanged();
			}
		}
		private bool _NonTaxpayer;
		[CProperty(ColumnPath ="NonTaxpayer")]
		public bool NonTaxpayer
		{
			get{return _NonTaxpayer;}
			set
			{
				_NonTaxpayer = value;
				OnPropertyChanged();
			}
		}
		private string _OwnershipType;
		[CProperty(ColumnPath ="OwnershipType")]
		public string OwnershipType
		{
			get{return _OwnershipType;}
			set
			{
				_OwnershipType = value;
				OnPropertyChanged();
			}
		}
		private string _PhoneNumber;
		[CProperty(ColumnPath ="PhoneNumber")]
		public string PhoneNumber
		{
			get{return _PhoneNumber;}
			set
			{
				_PhoneNumber = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		private Guid _RegionId;
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId
		{
			get{return _RegionId;}
			set
			{
				_RegionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScreeningResultStatusId;
		[CProperty(ColumnPath ="ScreeningResultStatusId")]
		public Guid ScreeningResultStatusId
		{
			get{return _ScreeningResultStatusId;}
			set
			{
				_ScreeningResultStatusId = value;
				OnPropertyChanged();
			}
		}
		private string _SignatureBase;
		[CProperty(ColumnPath ="SignatureBase")]
		public string SignatureBase
		{
			get{return _SignatureBase;}
			set
			{
				_SignatureBase = value;
				OnPropertyChanged();
			}
		}
		private bool _SingleTax;
		[CProperty(ColumnPath ="SingleTax")]
		public bool SingleTax
		{
			get{return _SingleTax;}
			set
			{
				_SingleTax = value;
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
		private string _Street;
		[CProperty(ColumnPath ="Street")]
		public string Street
		{
			get{return _Street;}
			set
			{
				_Street = value;
				OnPropertyChanged();
			}
		}
		private bool _TsIsActive;
		[CProperty(ColumnPath ="TsIsActive")]
		public bool TsIsActive
		{
			get{return _TsIsActive;}
			set
			{
				_TsIsActive = value;
				OnPropertyChanged();
			}
		}
		private string _VatId;
		[CProperty(ColumnPath ="VatId")]
		public string VatId
		{
			get{return _VatId;}
			set
			{
				_VatId = value;
				OnPropertyChanged();
			}
		}
		private Guid _VatPayerId;
		[CProperty(ColumnPath ="VatPayerId")]
		public Guid VatPayerId
		{
			get{return _VatPayerId;}
			set
			{
				_VatPayerId = value;
				OnPropertyChanged();
			}
		}
		private string _ZipCode;
		[CProperty(ColumnPath ="ZipCode")]
		public string ZipCode
		{
			get{return _ZipCode;}
			set
			{
				_ZipCode = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Bank:BankId")]
		public Bank Bank { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AccountManagerId")]
		public Contact AccountManager { get; set; }
		[CProperty(Navigation ="Contact:ChiefAccountantId")]
		public Contact ChiefAccountant { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="ScreeningResultStatus:ScreeningResultStatusId")]
		public ScreeningResultStatus ScreeningResultStatus { get; set; }
		[CProperty(Navigation ="State:StateId")]
		public State State { get; set; }
		[CProperty(Navigation ="VatPayer:VatPayerId")]
		public VatPayer VatPayer { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BillingInfoByCurrency:BillingInfoId")]
		public virtual ICollection<BillingInfoByCurrency> BillingInfoByCurrencyByBillingInfo { get; set; }
		[CProperty(Association ="Contract:SupplierBillingInfoId")]
		public virtual ICollection<Contract> ContractBySupplierBillingInfo { get; set; }
		[CProperty(Association ="Contract:CustomerBillingInfoId")]
		public virtual ICollection<Contract> ContractByCustomerBillingInfo { get; set; }
		[CProperty(Association ="DefaultReport:SupplierBillingInfoId")]
		public virtual ICollection<DefaultReport> DefaultReportBySupplierBillingInfo { get; set; }
		[CProperty(Association ="Document:CustomerBillingInfoId")]
		public virtual ICollection<Document> DocumentByCustomerBillingInfo { get; set; }
		[CProperty(Association ="Invoice:SupplierBillingInfoId")]
		public virtual ICollection<Invoice> InvoiceBySupplierBillingInfo { get; set; }
		[CProperty(Association ="Invoice:CustomerBillingInfoId")]
		public virtual ICollection<Invoice> InvoiceByCustomerBillingInfo { get; set; }
		[CProperty(Association ="Lead:AccountBillingInfoId")]
		public virtual ICollection<Lead> LeadByAccountBillingInfo { get; set; }
		[CProperty(Association ="Opportunity:AccountBillingInfoId")]
		public virtual ICollection<Opportunity> OpportunityByAccountBillingInfo { get; set; }
		[CProperty(Association ="Order:CustomerBillingInfoId")]
		public virtual ICollection<Order> OrderByCustomerBillingInfo { get; set; }
		[CProperty(Association ="Order:SupplierBillingInfoLicId")]
		public virtual ICollection<Order> OrderBySupplierBillingInfoLic { get; set; }
		[CProperty(Association ="Order:SupplierBillingInfoSerId")]
		public virtual ICollection<Order> OrderBySupplierBillingInfoSer { get; set; }
		[CProperty(Association ="ProductTaxRate:SupplierBillingInfoId")]
		public virtual ICollection<ProductTaxRate> ProductTaxRateBySupplierBillingInfo { get; set; }
		[CProperty(Association ="ProductTaxRate:CustomerBillingInfoId")]
		public virtual ICollection<ProductTaxRate> ProductTaxRateByCustomerBillingInfo { get; set; }
		[CProperty(Association ="ScreenResult:AccountBillingInfoId")]
		public virtual ICollection<ScreenResult> ScreenResultByAccountBillingInfo { get; set; }
		[CProperty(Association ="VwAccountBillingInfo:AccountBillingInfoId")]
		public virtual ICollection<VwAccountBillingInfo> VwAccountBillingInfoByAccountBillingInfo { get; set; }
		[CProperty(Association ="VwLead:AccountBillingInfoId")]
		public virtual ICollection<VwLead> VwLeadByAccountBillingInfo { get; set; }
		#endregion
	}
}
