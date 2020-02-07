using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOrderProductFilter")]
	public class VwOrderProductFilter : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="OrderProduct:ProductId")]
		public OrderProduct Product { get; set; }
		[CProperty(Navigation ="SupplyPaymentType:TypeId")]
		public SupplyPaymentType Type { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
