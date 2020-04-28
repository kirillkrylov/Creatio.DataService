using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOrderProduct")]
	public class VwOrderProduct : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PriceWithDiscount")]
		public decimal PriceWithDiscount { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity { get; set; }
		[CProperty(ColumnPath ="SummaryAmount")]
		public decimal SummaryAmount { get; set; }
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="Unit:UnitId")]
		public Unit Unit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
