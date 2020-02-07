using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AttributeInSiteEvent")]
	public class AttributeInSiteEvent : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BooleanValue")]
		public bool BooleanValue { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FloatValue")]
		public decimal FloatValue { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IntValue")]
		public int IntValue { get; set; }
		[CProperty(ColumnPath ="ListItemValueId")]
		public Guid ListItemValueId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductCategoryValueId")]
		public Guid ProductCategoryValueId { get; set; }
		[CProperty(ColumnPath ="ProductTradeMarkValueId")]
		public Guid ProductTradeMarkValueId { get; set; }
		[CProperty(ColumnPath ="ProductTypeValueId")]
		public Guid ProductTypeValueId { get; set; }
		[CProperty(ColumnPath ="ProductValueId")]
		public Guid ProductValueId { get; set; }
		[CProperty(ColumnPath ="SiteEventAttributeId")]
		public Guid SiteEventAttributeId { get; set; }
		[CProperty(ColumnPath ="SiteEventId")]
		public Guid SiteEventId { get; set; }
		[CProperty(ColumnPath ="StringValue")]
		public string StringValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Product:ProductValueId")]
		public Product ProductValue { get; set; }
		[CProperty(Navigation ="ProductCategory:ProductCategoryValueId")]
		public ProductCategory ProductCategoryValue { get; set; }
		[CProperty(Navigation ="ProductType:ProductTypeValueId")]
		public ProductType ProductTypeValue { get; set; }
		[CProperty(Navigation ="SiteEvent:SiteEventId")]
		public SiteEvent SiteEvent { get; set; }
		[CProperty(Navigation ="SiteEventAttribute:SiteEventAttributeId")]
		public SiteEventAttribute SiteEventAttribute { get; set; }
		[CProperty(Navigation ="SiteEventAttrListItem:ListItemValueId")]
		public SiteEventAttrListItem ListItemValue { get; set; }
		[CProperty(Navigation ="TradeMark:ProductTradeMarkValueId")]
		public TradeMark ProductTradeMarkValue { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
