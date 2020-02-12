using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Contract")]
	public class Contract : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ACV")]
		public decimal ACV { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="CompanyAddressId")]
		public Guid CompanyAddressId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContractLength")]
		public decimal ContractLength { get; set; }
		[CProperty(ColumnPath ="ContractPartyId")]
		public Guid ContractPartyId { get; set; }
		[CProperty(ColumnPath ="ContractRecipientAddress")]
		public string ContractRecipientAddress { get; set; }
		[CProperty(ColumnPath ="ContractRecipientId")]
		public Guid ContractRecipientId { get; set; }
		[CProperty(ColumnPath ="ContractReturnDate")]
		public DateTime ContractReturnDate { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="CurrencyRateOnStartDate")]
		public decimal CurrencyRateOnStartDate { get; set; }
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId { get; set; }
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId { get; set; }
		[CProperty(ColumnPath ="DR")]
		public decimal DR { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="FixedEndDate")]
		public bool FixedEndDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OurCompanyId")]
		public Guid OurCompanyId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountWithoutTax")]
		public decimal PrimaryAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount { get; set; }
		[CProperty(ColumnPath ="PrintableId")]
		public Guid PrintableId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecognizedRevenue")]
		public decimal RecognizedRevenue { get; set; }
		[CProperty(ColumnPath ="SalesAssistantContactId")]
		public Guid SalesAssistantContactId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="SupplierBillingInfoId")]
		public Guid SupplierBillingInfoId { get; set; }
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount { get; set; }
		[CProperty(ColumnPath ="TCV")]
		public decimal TCV { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
