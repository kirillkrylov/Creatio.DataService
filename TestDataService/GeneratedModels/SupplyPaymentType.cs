using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupplyPaymentType")]
	public class SupplyPaymentType : BaseEntity
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TsIsForModalBox")]
		public bool TsIsForModalBox { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ProductDeliveryType:SupplyPaymentTypeId")]
		public virtual ICollection<ProductDeliveryType> ProductDeliveryTypeBySupplyPaymentType { get; set; }
		[CProperty(Association ="SupplyPaymentElement:TypeId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByType { get; set; }
		[CProperty(Association ="SupplyPaymentTemplateItem:TypeId")]
		public virtual ICollection<SupplyPaymentTemplateItem> SupplyPaymentTemplateItemByType { get; set; }
		[CProperty(Association ="VwOrderProductFilter:TypeId")]
		public virtual ICollection<VwOrderProductFilter> VwOrderProductFilterByType { get; set; }
		#endregion
	}
}
