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
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate { get; set; }
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
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
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="SupplierBillingInfoId")]
		public Guid SupplierBillingInfoId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:OurCompanyId")]
		public Account OurCompany { get; set; }
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
		[CProperty(Navigation ="Contract:ParentId")]
		public Contract Parent { get; set; }
		[CProperty(Navigation ="ContractState:StateId")]
		public ContractState State { get; set; }
		[CProperty(Navigation ="ContractType:TypeId")]
		public ContractType Type { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
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
		[CProperty(Association ="Document:ContractId")]
		public virtual ICollection<Document> DocumentByContract { get; set; }
		[CProperty(Association ="Invoice:ContractId")]
		public virtual ICollection<Invoice> InvoiceByContract { get; set; }
		[CProperty(Association ="OrderProduct:ContractId")]
		public virtual ICollection<OrderProduct> OrderProductByContract { get; set; }
		[CProperty(Association ="SupplyPaymentElement:ContractId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByContract { get; set; }
		#endregion
	}
}
