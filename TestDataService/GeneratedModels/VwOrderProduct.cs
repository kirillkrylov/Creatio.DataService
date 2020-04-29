using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwOrderProduct")]
	public class VwOrderProduct : BaseEntity
	{
		#region Values
		private Guid _ContractId;
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId
		{
			get{return _ContractId;}
			set
			{
				_ContractId = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private decimal _PriceWithDiscount;
		[CProperty(ColumnPath ="PriceWithDiscount")]
		public decimal PriceWithDiscount
		{
			get{return _PriceWithDiscount;}
			set
			{
				_PriceWithDiscount = value;
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
		private decimal _Quantity;
		[CProperty(ColumnPath ="Quantity")]
		public decimal Quantity
		{
			get{return _Quantity;}
			set
			{
				_Quantity = value;
				OnPropertyChanged();
			}
		}
		private decimal _SummaryAmount;
		[CProperty(ColumnPath ="SummaryAmount")]
		public decimal SummaryAmount
		{
			get{return _SummaryAmount;}
			set
			{
				_SummaryAmount = value;
				OnPropertyChanged();
			}
		}
		private Guid _UnitId;
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId
		{
			get{return _UnitId;}
			set
			{
				_UnitId = value;
				OnPropertyChanged();
			}
		}
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
