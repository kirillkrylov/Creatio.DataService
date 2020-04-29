using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProductStockBalance")]
	public class ProductStockBalance : BaseEntity
	{
		#region Values
		private decimal _AvailableQuantity;
		[CProperty(ColumnPath ="AvailableQuantity")]
		public decimal AvailableQuantity
		{
			get{return _AvailableQuantity;}
			set
			{
				_AvailableQuantity = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductId;
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId
		{
			get{return _ProductId;}
			set
			{
				_ProductId = value;
				OnPropertyChanged();
			}
		}
		private decimal _ReserveQuantity;
		[CProperty(ColumnPath ="ReserveQuantity")]
		public decimal ReserveQuantity
		{
			get{return _ReserveQuantity;}
			set
			{
				_ReserveQuantity = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalQuantity;
		[CProperty(ColumnPath ="TotalQuantity")]
		public decimal TotalQuantity
		{
			get{return _TotalQuantity;}
			set
			{
				_TotalQuantity = value;
				OnPropertyChanged();
			}
		}
		private Guid _WarehouseId;
		[CProperty(ColumnPath ="WarehouseId")]
		public Guid WarehouseId
		{
			get{return _WarehouseId;}
			set
			{
				_WarehouseId = value;
				OnPropertyChanged();
			}
		}
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
