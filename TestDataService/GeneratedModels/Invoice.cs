using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Invoice")]
	public class Invoice : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AmountWithoutTax")]
		public decimal AmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="CloseInvoice")]
		public bool CloseInvoice { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CrossRateOnBillingDate")]
		public decimal CrossRateOnBillingDate { get; set; }
		[CProperty(ColumnPath ="CrossRateOnPaymentDate")]
		public decimal CrossRateOnPaymentDate { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="FillBonusesManually")]
		public bool FillBonusesManually { get; set; }
		[CProperty(ColumnPath ="FillDetailsManually")]
		public bool FillDetailsManually { get; set; }
		[CProperty(ColumnPath ="FundTypeId")]
		public Guid FundTypeId { get; set; }
		[CProperty(ColumnPath ="GlbCurrentFY")]
		public bool GlbCurrentFY { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn { get; set; }
		[CProperty(ColumnPath ="InvoiceKindId")]
		public Guid InvoiceKindId { get; set; }
		[CProperty(ColumnPath ="IsHasProducts")]
		public bool IsHasProducts { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="Margin")]
		public decimal Margin { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="NotesForSection")]
		public string NotesForSection { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PayerId")]
		public Guid PayerId { get; set; }
		[CProperty(ColumnPath ="PaymentAmount")]
		public decimal PaymentAmount { get; set; }
		[CProperty(ColumnPath ="PaymentAmountWithoutTax")]
		public decimal PaymentAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="PaymentCurrencyId")]
		public Guid PaymentCurrencyId { get; set; }
		[CProperty(ColumnPath ="PaymentCurrencyRate")]
		public decimal PaymentCurrencyRate { get; set; }
		[CProperty(ColumnPath ="PaymentStatusId")]
		public Guid PaymentStatusId { get; set; }
		[CProperty(ColumnPath ="PaymentTypeId")]
		public Guid PaymentTypeId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountWithoutTax")]
		public decimal PrimaryAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="PrimaryPaymentAmount")]
		public decimal PrimaryPaymentAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryPaymentAmountWithoutTax")]
		public decimal PrimaryPaymentAmountWithoutTax { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount { get; set; }
		[CProperty(ColumnPath ="PrintableId")]
		public Guid PrintableId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="RemindToOwner")]
		public bool RemindToOwner { get; set; }
		[CProperty(ColumnPath ="RemindToOwnerDate")]
		public DateTime RemindToOwnerDate { get; set; }
		[CProperty(ColumnPath ="SpecificationId")]
		public Guid SpecificationId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="SupplierBillingInfoId")]
		public Guid SupplierBillingInfoId { get; set; }
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId { get; set; }
		[CProperty(ColumnPath ="TaxAmount")]
		public decimal TaxAmount { get; set; }
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C { get; set; }
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
