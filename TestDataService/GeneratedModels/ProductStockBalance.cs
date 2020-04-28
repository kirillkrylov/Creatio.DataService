using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductStockBalance")]
	public class ProductStockBalance : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AvailableQuantity")]
		public decimal AvailableQuantity { get; set; }
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="ReserveQuantity")]
		public decimal ReserveQuantity { get; set; }
		[CProperty(ColumnPath ="TotalQuantity")]
		public decimal TotalQuantity { get; set; }
		[CProperty(ColumnPath ="WarehouseId")]
		public Guid WarehouseId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Product:ProductId")]
		public Product Product { get; set; }
		[CProperty(Navigation ="Warehouse:WarehouseId")]
		public Warehouse Warehouse { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
