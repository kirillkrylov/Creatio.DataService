using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupplyPaymentElement")]
	public class SupplyPaymentElement : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActId")]
		public Guid ActId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="AmountFact")]
		public decimal AmountFact { get; set; }
		[CProperty(ColumnPath ="AmountFactWithTax")]
		public decimal AmountFactWithTax { get; set; }
		[CProperty(ColumnPath ="AmountPlan")]
		public decimal AmountPlan { get; set; }
		[CProperty(ColumnPath ="AmountPlanWithoutTax")]
		public decimal AmountPlanWithoutTax { get; set; }
		[CProperty(ColumnPath ="AmountPlanWithTax")]
		public decimal AmountPlanWithTax { get; set; }
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="Commission")]
		public decimal Commission { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="DateFact")]
		public DateTime DateFact { get; set; }
		[CProperty(ColumnPath ="DatePlan")]
		public DateTime DatePlan { get; set; }
		[CProperty(ColumnPath ="Delay")]
		public int Delay { get; set; }
		[CProperty(ColumnPath ="DelayTypeId")]
		public Guid DelayTypeId { get; set; }
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="IsRecordLocked")]
		public bool IsRecordLocked { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="Percentage")]
		public decimal Percentage { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="PreviousElementId")]
		public Guid PreviousElementId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountFact")]
		public decimal PrimaryAmountFact { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountFactWithTax")]
		public decimal PrimaryAmountFactWithTax { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountPlan")]
		public decimal PrimaryAmountPlan { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountPlanWithoutTax")]
		public decimal PrimaryAmountPlanWithoutTax { get; set; }
		[CProperty(ColumnPath ="PrimaryAmountPlanWithTax")]
		public decimal PrimaryAmountPlanWithTax { get; set; }
		[CProperty(ColumnPath ="PrimaryTaxPlanAmount")]
		public decimal PrimaryTaxPlanAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="Products")]
		public string Products { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="RequestId")]
		public Guid RequestId { get; set; }
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="TargetId")]
		public Guid TargetId { get; set; }
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId { get; set; }
		[CProperty(ColumnPath ="TaxPlanAmount")]
		public decimal TaxPlanAmount { get; set; }
		[CProperty(ColumnPath ="TotalCommission")]
		public decimal TotalCommission { get; set; }
		[CProperty(ColumnPath ="TotalWithoutTax")]
		public decimal TotalWithoutTax { get; set; }
		[CProperty(ColumnPath ="TotalWithTax")]
		public decimal TotalWithTax { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
