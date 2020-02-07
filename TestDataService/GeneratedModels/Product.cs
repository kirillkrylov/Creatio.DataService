using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Product")]
	public class Product : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Active")]
		public bool Active { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsArchive")]
		public bool IsArchive { get; set; }
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PaymentModelId")]
		public Guid PaymentModelId { get; set; }
		[CProperty(ColumnPath ="PictureId")]
		public Guid PictureId { get; set; }
		[CProperty(ColumnPath ="Price")]
		public decimal Price { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductDeliveryTypeId")]
		public Guid ProductDeliveryTypeId { get; set; }
		[CProperty(ColumnPath ="ProductSourceId")]
		public Guid ProductSourceId { get; set; }
		[CProperty(ColumnPath ="RevenueRecognitionMethodId")]
		public Guid RevenueRecognitionMethodId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId { get; set; }
		[CProperty(ColumnPath ="TradeMarkId")]
		public Guid TradeMarkId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId { get; set; }
		[CProperty(ColumnPath ="URL")]
		public string URL { get; set; }
		[CProperty(ColumnPath ="WorkId")]
		public string WorkId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Kind:KindId")]
		public Kind Kind { get; set; }
		[CProperty(Navigation ="PaymentModel:PaymentModelId")]
		public PaymentModel PaymentModel { get; set; }
		[CProperty(Navigation ="ProductCategory:CategoryId")]
		public ProductCategory Category { get; set; }
		[CProperty(Navigation ="ProductDeliveryType:ProductDeliveryTypeId")]
		public ProductDeliveryType ProductDeliveryType { get; set; }
		[CProperty(Navigation ="ProductSource:ProductSourceId")]
		public ProductSource ProductSource { get; set; }
		[CProperty(Navigation ="ProductType:TypeId")]
		public ProductType Type { get; set; }
		[CProperty(Navigation ="RevenueRecognitionMethod:RevenueRecognitionMethodId")]
		public RevenueRecognitionMethod RevenueRecognitionMethod { get; set; }
		[CProperty(Navigation ="SysImage:PictureId")]
		public SysImage Picture { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		[CProperty(Navigation ="TradeMark:TradeMarkId")]
		public TradeMark TradeMark { get; set; }
		[CProperty(Navigation ="Unit:UnitId")]
		public Unit Unit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AttributeInSiteEvent:ProductValueId")]
		public virtual ICollection<AttributeInSiteEvent> AttributeInSiteEventByProductValue { get; set; }
		[CProperty(Association ="ContactsProductInterest:ProductId")]
		public virtual ICollection<ContactsProductInterest> ContactsProductInterestByProduct { get; set; }
		[CProperty(Association ="DocumentProduct:ProductId")]
		public virtual ICollection<DocumentProduct> DocumentProductByProduct { get; set; }
		[CProperty(Association ="EventProduct:ProductId")]
		public virtual ICollection<EventProduct> EventProductByProduct { get; set; }
		[CProperty(Association ="InvoiceProduct:ProductId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByProduct { get; set; }
		[CProperty(Association ="LeadProduct:ProductId")]
		public virtual ICollection<LeadProduct> LeadProductByProduct { get; set; }
		[CProperty(Association ="OpportunityProductInterest:ProductId")]
		public virtual ICollection<OpportunityProductInterest> OpportunityProductInterestByProduct { get; set; }
		[CProperty(Association ="OrderProduct:ProductId")]
		public virtual ICollection<OrderProduct> OrderProductByProduct { get; set; }
		[CProperty(Association ="ProductEntry:ProductId")]
		public virtual ICollection<ProductEntry> ProductEntryByProduct { get; set; }
		[CProperty(Association ="ProductEntry:CrossSalesOferringId")]
		public virtual ICollection<ProductEntry> ProductEntryByCrossSalesOferring { get; set; }
		[CProperty(Association ="ProductFile:ProductId")]
		public virtual ICollection<ProductFile> ProductFileByProduct { get; set; }
		[CProperty(Association ="ProductInFolder:ProductId")]
		public virtual ICollection<ProductInFolder> ProductInFolderByProduct { get; set; }
		[CProperty(Association ="ProductInLeadType:ProductId")]
		public virtual ICollection<ProductInLeadType> ProductInLeadTypeByProduct { get; set; }
		[CProperty(Association ="ProductInTag:EntityId")]
		public virtual ICollection<ProductInTag> ProductInTagByEntity { get; set; }
		[CProperty(Association ="ProductPrice:ProductId")]
		public virtual ICollection<ProductPrice> ProductPriceByProduct { get; set; }
		[CProperty(Association ="ProductStockBalance:ProductId")]
		public virtual ICollection<ProductStockBalance> ProductStockBalanceByProduct { get; set; }
		[CProperty(Association ="ProductUnit:ProductId")]
		public virtual ICollection<ProductUnit> ProductUnitByProduct { get; set; }
		[CProperty(Association ="ProjectProduct:ProductId")]
		public virtual ICollection<ProjectProduct> ProjectProductByProduct { get; set; }
		[CProperty(Association ="SpecificationInProduct:ProductId")]
		public virtual ICollection<SpecificationInProduct> SpecificationInProductByProduct { get; set; }
		[CProperty(Association ="VwDocumentProduct:ProductId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByProduct { get; set; }
		[CProperty(Association ="VwInvoiceProduct:ProductId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByProduct { get; set; }
		[CProperty(Association ="VwProductInLeadType:ProductId")]
		public virtual ICollection<VwProductInLeadType> VwProductInLeadTypeByProduct { get; set; }
		[CProperty(Association ="VwProjectProduct:ProductId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByProduct { get; set; }
		#endregion
	}
}
