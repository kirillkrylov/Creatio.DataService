using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductTaxRate")]
	public class ProductTaxRate : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CustomerBillingInfoId")]
		public Guid CustomerBillingInfoId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductCode")]
		public string ProductCode { get; set; }
		[CProperty(ColumnPath ="SupplierBillingInfoId")]
		public Guid SupplierBillingInfoId { get; set; }
		[CProperty(ColumnPath ="SynchronisationDate")]
		public DateTime SynchronisationDate { get; set; }
		[CProperty(ColumnPath ="TaxPercent")]
		public decimal TaxPercent { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountBillingInfo:SupplierBillingInfoId")]
		public AccountBillingInfo SupplierBillingInfo { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:CustomerBillingInfoId")]
		public AccountBillingInfo CustomerBillingInfo { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
