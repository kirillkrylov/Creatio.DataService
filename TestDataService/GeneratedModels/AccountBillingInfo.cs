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
		[CProperty(ColumnPath ="AccountManagerId")]
		public Guid AccountManagerId { get; set; }
		[CProperty(ColumnPath ="BillingInfo")]
		public string BillingInfo { get; set; }
		[CProperty(ColumnPath ="ChiefAccountantId")]
		public Guid ChiefAccountantId { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="LegalUnit")]
		public string LegalUnit { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
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
		#endregion

		#region Associations
		[CProperty(Association ="Contract:SupplierBillingInfoId")]
		public virtual ICollection<Contract> ContractBySupplierBillingInfo { get; set; }
		[CProperty(Association ="Contract:CustomerBillingInfoId")]
		public virtual ICollection<Contract> ContractByCustomerBillingInfo { get; set; }
		[CProperty(Association ="Invoice:SupplierBillingInfoId")]
		public virtual ICollection<Invoice> InvoiceBySupplierBillingInfo { get; set; }
		[CProperty(Association ="Invoice:CustomerBillingInfoId")]
		public virtual ICollection<Invoice> InvoiceByCustomerBillingInfo { get; set; }
		#endregion
	}
}
