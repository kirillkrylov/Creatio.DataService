using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountBillingInfo")]
	public class AccountBillingInfo : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="AccountManagerFull")]
		public string AccountManagerFull { get; set; }
		[CProperty(ColumnPath ="AccountManagerId")]
		public Guid AccountManagerId { get; set; }
		[CProperty(ColumnPath ="AccountNumber")]
		public string AccountNumber { get; set; }
		[CProperty(ColumnPath ="BankId")]
		public Guid BankId { get; set; }
		[CProperty(ColumnPath ="BillingInfo")]
		public string BillingInfo { get; set; }
		[CProperty(ColumnPath ="CanUseAusDollar")]
		public bool CanUseAusDollar { get; set; }
		[CProperty(ColumnPath ="CanUseDollar")]
		public bool CanUseDollar { get; set; }
		[CProperty(ColumnPath ="CanUseEuro")]
		public bool CanUseEuro { get; set; }
		[CProperty(ColumnPath ="CanUseFranc")]
		public bool CanUseFranc { get; set; }
		[CProperty(ColumnPath ="CanUseHryvnia")]
		public bool CanUseHryvnia { get; set; }
		[CProperty(ColumnPath ="CanUsePounds")]
		public bool CanUsePounds { get; set; }
		[CProperty(ColumnPath ="CanUseRuble")]
		public bool CanUseRuble { get; set; }
		[CProperty(ColumnPath ="CanUseSingaporeDollar")]
		public bool CanUseSingaporeDollar { get; set; }
		[CProperty(ColumnPath ="CanUseTenge")]
		public bool CanUseTenge { get; set; }
		[CProperty(ColumnPath ="ChiefAccountantId")]
		public Guid ChiefAccountantId { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="email")]
		public string email { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="INN")]
		public string INN { get; set; }
		[CProperty(ColumnPath ="IntegrationCode")]
		public string IntegrationCode { get; set; }
		[CProperty(ColumnPath ="JobTitleFull")]
		public string JobTitleFull { get; set; }
		[CProperty(ColumnPath ="KPP")]
		public string KPP { get; set; }
		[CProperty(ColumnPath ="LegalAddress")]
		public string LegalAddress { get; set; }
		[CProperty(ColumnPath ="LegalEntityWithoutOwnership")]
		public string LegalEntityWithoutOwnership { get; set; }
		[CProperty(ColumnPath ="LegalUnit")]
		public string LegalUnit { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NonSDN")]
		public bool NonSDN { get; set; }
		[CProperty(ColumnPath ="NonTaxpayer")]
		public bool NonTaxpayer { get; set; }
		[CProperty(ColumnPath ="OwnershipType")]
		public string OwnershipType { get; set; }
		[CProperty(ColumnPath ="PhoneNumber")]
		public string PhoneNumber { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="ScreeningResultStatusId")]
		public Guid ScreeningResultStatusId { get; set; }
		[CProperty(ColumnPath ="SignatureBase")]
		public string SignatureBase { get; set; }
		[CProperty(ColumnPath ="SingleTax")]
		public bool SingleTax { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="Street")]
		public string Street { get; set; }
		[CProperty(ColumnPath ="TsIsActive")]
		public bool TsIsActive { get; set; }
		[CProperty(ColumnPath ="VatId")]
		public string VatId { get; set; }
		[CProperty(ColumnPath ="VatPayerId")]
		public Guid VatPayerId { get; set; }
		[CProperty(ColumnPath ="ZipCode")]
		public string ZipCode { get; set; }
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
