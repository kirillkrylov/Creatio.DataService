using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductType")]
	public class ProductType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn { get; set; }
		[CProperty(ColumnPath ="IsService")]
		public bool IsService { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C { get; set; }
		[CProperty(ColumnPath ="UseMinimumMargin")]
		public bool UseMinimumMargin { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ProductCategory:CategoryId")]
		public ProductCategory Category { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AttributeInSiteEvent:ProductTypeValueId")]
		public virtual ICollection<AttributeInSiteEvent> AttributeInSiteEventByProductTypeValue { get; set; }
		[CProperty(Association ="ContractByProductType:ProductTypeId")]
		public virtual ICollection<ContractByProductType> ContractByProductTypeByProductType { get; set; }
		[CProperty(Association ="Product:TypeId")]
		public virtual ICollection<Product> ProductByType { get; set; }
		[CProperty(Association ="ProductFilter:ProductTypeId")]
		public virtual ICollection<ProductFilter> ProductFilterByProductType { get; set; }
		#endregion
	}
}
