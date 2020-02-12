using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TaxByCountry")]
	public class TaxByCountry : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CustomerCountryId")]
		public Guid CustomerCountryId { get; set; }
		[CProperty(ColumnPath ="CustomerRegionId")]
		public Guid CustomerRegionId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsCustomerVatPayer")]
		public bool IsCustomerVatPayer { get; set; }
		[CProperty(ColumnPath ="IsEu")]
		public bool IsEu { get; set; }
		[CProperty(ColumnPath ="IsSupplierSingleTaxPayer")]
		public bool IsSupplierSingleTaxPayer { get; set; }
		[CProperty(ColumnPath ="IsSupplierVatPayer")]
		public bool IsSupplierVatPayer { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductCategoryId")]
		public Guid ProductCategoryId { get; set; }
		[CProperty(ColumnPath ="ShowMessage")]
		public bool ShowMessage { get; set; }
		[CProperty(ColumnPath ="SupplierCountryId")]
		public Guid SupplierCountryId { get; set; }
		[CProperty(ColumnPath ="SupplierRegionId")]
		public Guid SupplierRegionId { get; set; }
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Country:SupplierCountryId")]
		public Country SupplierCountry { get; set; }
		[CProperty(Navigation ="Country:CustomerCountryId")]
		public Country CustomerCountry { get; set; }
		[CProperty(Navigation ="ProductCategory:ProductCategoryId")]
		public ProductCategory ProductCategory { get; set; }
		[CProperty(Navigation ="Region:SupplierRegionId")]
		public Region SupplierRegion { get; set; }
		[CProperty(Navigation ="Region:CustomerRegionId")]
		public Region CustomerRegion { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
