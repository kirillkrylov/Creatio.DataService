using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrderProductHistory")]
	public class OrderProductHistory : BaseEntity
	{
		#region Values
		private Guid _BaseCurrencyId;
		[CProperty(ColumnPath ="BaseCurrencyId")]
		public Guid BaseCurrencyId
		{
			get{return _BaseCurrencyId;}
			set
			{
				_BaseCurrencyId = value;
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
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
				OnPropertyChanged();
			}
		}
		private decimal _CurrencyRate;
		[CProperty(ColumnPath ="CurrencyRate")]
		public decimal CurrencyRate
		{
			get{return _CurrencyRate;}
			set
			{
				_CurrencyRate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _HistoryDate;
		[CProperty(ColumnPath ="HistoryDate")]
		public DateTime HistoryDate
		{
			get{return _HistoryDate;}
			set
			{
				_HistoryDate = value;
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
		private Guid _OrderProductId;
		[CProperty(ColumnPath ="OrderProductId")]
		public Guid OrderProductId
		{
			get{return _OrderProductId;}
			set
			{
				_OrderProductId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmount;
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount
		{
			get{return _PrimaryAmount;}
			set
			{
				_PrimaryAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryAmountWithDiscount;
		[CProperty(ColumnPath ="PrimaryAmountWithDiscount")]
		public decimal PrimaryAmountWithDiscount
		{
			get{return _PrimaryAmountWithDiscount;}
			set
			{
				_PrimaryAmountWithDiscount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryPrice;
		[CProperty(ColumnPath ="PrimaryPrice")]
		public decimal PrimaryPrice
		{
			get{return _PrimaryPrice;}
			set
			{
				_PrimaryPrice = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTaxAmount;
		[CProperty(ColumnPath ="PrimaryTaxAmount")]
		public decimal PrimaryTaxAmount
		{
			get{return _PrimaryTaxAmount;}
			set
			{
				_PrimaryTaxAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTotalAmount;
		[CProperty(ColumnPath ="PrimaryTotalAmount")]
		public decimal PrimaryTotalAmount
		{
			get{return _PrimaryTotalAmount;}
			set
			{
				_PrimaryTotalAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _PrimaryTotalAmountWithoutTax;
		[CProperty(ColumnPath ="PrimaryTotalAmountWithoutTax")]
		public decimal PrimaryTotalAmountWithoutTax
		{
			get{return _PrimaryTotalAmountWithoutTax;}
			set
			{
				_PrimaryTotalAmountWithoutTax = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="Currency:BaseCurrencyId")]
		public Currency BaseCurrency { get; set; }
		[CProperty(Navigation ="OrderProduct:OrderProductId")]
		public OrderProduct OrderProduct { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
