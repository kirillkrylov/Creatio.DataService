using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupplyPaymentTemplateItem")]
	public class SupplyPaymentTemplateItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Delay")]
		public int Delay { get; set; }
		[CProperty(ColumnPath ="DelayTypeId")]
		public Guid DelayTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Percentage")]
		public decimal Percentage { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="PreviousElementId")]
		public Guid PreviousElementId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupplyPaymentTemplateId")]
		public Guid SupplyPaymentTemplateId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SupplyPaymentDelay:DelayTypeId")]
		public SupplyPaymentDelay DelayType { get; set; }
		[CProperty(Navigation ="SupplyPaymentTemplate:SupplyPaymentTemplateId")]
		public SupplyPaymentTemplate SupplyPaymentTemplate { get; set; }
		[CProperty(Navigation ="SupplyPaymentTemplateItem:PreviousElementId")]
		public SupplyPaymentTemplateItem PreviousElement { get; set; }
		[CProperty(Navigation ="SupplyPaymentType:TypeId")]
		public SupplyPaymentType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SupplyPaymentTemplateItem:PreviousElementId")]
		public virtual ICollection<SupplyPaymentTemplateItem> SupplyPaymentTemplateItemByPreviousElement { get; set; }
		#endregion
	}
}
