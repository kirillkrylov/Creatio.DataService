using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Tax")]
	public class Tax : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Percent")]
		public decimal Percent { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DocumentProduct:TaxId")]
		public virtual ICollection<DocumentProduct> DocumentProductByTax { get; set; }
		[CProperty(Association ="ExesInRequest:TaxId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByTax { get; set; }
		[CProperty(Association ="InvoiceProduct:TaxId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByTax { get; set; }
		[CProperty(Association ="OrderProduct:TaxId")]
		public virtual ICollection<OrderProduct> OrderProductByTax { get; set; }
		[CProperty(Association ="Product:TaxId")]
		public virtual ICollection<Product> ProductByTax { get; set; }
		[CProperty(Association ="ProductPrice:TaxId")]
		public virtual ICollection<ProductPrice> ProductPriceByTax { get; set; }
		[CProperty(Association ="ProjectProduct:TaxId")]
		public virtual ICollection<ProjectProduct> ProjectProductByTax { get; set; }
		[CProperty(Association ="SupplyPaymentElement:TaxId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByTax { get; set; }
		[CProperty(Association ="TaxByCountry:TaxId")]
		public virtual ICollection<TaxByCountry> TaxByCountryByTax { get; set; }
		[CProperty(Association ="VwDocumentProduct:TaxId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByTax { get; set; }
		[CProperty(Association ="VwInvoiceProduct:TaxId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByTax { get; set; }
		[CProperty(Association ="VwProjectProduct:TaxId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByTax { get; set; }
		#endregion
	}
}
