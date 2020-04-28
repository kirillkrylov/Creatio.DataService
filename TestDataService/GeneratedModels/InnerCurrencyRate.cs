using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InnerCurrencyRate")]
	public class InnerCurrencyRate : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BasePriceListId")]
		public Guid BasePriceListId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NewPriceListId")]
		public Guid NewPriceListId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Rate")]
		public decimal Rate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Pricelist:BasePriceListId")]
		public Pricelist BasePriceList { get; set; }
		[CProperty(Navigation ="Pricelist:NewPriceListId")]
		public Pricelist NewPriceList { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
