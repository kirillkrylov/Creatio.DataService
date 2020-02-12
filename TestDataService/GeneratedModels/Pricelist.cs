using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Pricelist")]
	public class Pricelist : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsBase")]
		public bool IsBase { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:PriceListId")]
		public virtual ICollection<Account> AccountByPriceList { get; set; }
		[CProperty(Association ="DocumentProduct:PriceListId")]
		public virtual ICollection<DocumentProduct> DocumentProductByPriceList { get; set; }
		[CProperty(Association ="InnerCurrencyRate:BasePriceListId")]
		public virtual ICollection<InnerCurrencyRate> InnerCurrencyRateByBasePriceList { get; set; }
		[CProperty(Association ="InnerCurrencyRate:NewPriceListId")]
		public virtual ICollection<InnerCurrencyRate> InnerCurrencyRateByNewPriceList { get; set; }
		[CProperty(Association ="InvoiceProduct:PriceListId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByPriceList { get; set; }
		[CProperty(Association ="OrderProduct:PriceListId")]
		public virtual ICollection<OrderProduct> OrderProductByPriceList { get; set; }
		[CProperty(Association ="PricelistByCountry:PricelistId")]
		public virtual ICollection<PricelistByCountry> PricelistByCountryByPricelist { get; set; }
		[CProperty(Association ="ProductPrice:PriceListId")]
		public virtual ICollection<ProductPrice> ProductPriceByPriceList { get; set; }
		[CProperty(Association ="ProjectProduct:PriceListId")]
		public virtual ICollection<ProjectProduct> ProjectProductByPriceList { get; set; }
		[CProperty(Association ="VwDocumentProduct:PriceListId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByPriceList { get; set; }
		[CProperty(Association ="VwInvoiceProduct:PriceListId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByPriceList { get; set; }
		[CProperty(Association ="VwPortalOrderExpenceProduct:BasePriceListId")]
		public virtual ICollection<VwPortalOrderExpenceProduct> VwPortalOrderExpenceProductByBasePriceList { get; set; }
		[CProperty(Association ="VwPortalOrderExpenceProduct:NewPriceListId")]
		public virtual ICollection<VwPortalOrderExpenceProduct> VwPortalOrderExpenceProductByNewPriceList { get; set; }
		[CProperty(Association ="VwProjectProduct:PriceListId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByPriceList { get; set; }
		#endregion
	}
}
