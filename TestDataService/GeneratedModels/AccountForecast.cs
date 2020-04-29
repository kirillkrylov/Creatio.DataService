using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountForecast")]
	public class AccountForecast : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Amount;
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount
		{
			get{return _Amount;}
			set
			{
				_Amount = value;
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
		private Guid _ForecastColumnId;
		[CProperty(ColumnPath ="ForecastColumnId")]
		public Guid ForecastColumnId
		{
			get{return _ForecastColumnId;}
			set
			{
				_ForecastColumnId = value;
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
		private Guid _IndicatorId;
		[CProperty(ColumnPath ="IndicatorId")]
		public Guid IndicatorId
		{
			get{return _IndicatorId;}
			set
			{
				_IndicatorId = value;
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
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
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
		private Guid _RowId;
		[CProperty(ColumnPath ="RowId")]
		public Guid RowId
		{
			get{return _RowId;}
			set
			{
				_RowId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SheetId;
		[CProperty(ColumnPath ="SheetId")]
		public Guid SheetId
		{
			get{return _SheetId;}
			set
			{
				_SheetId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Value;
		[CProperty(ColumnPath ="Value")]
		public decimal Value
		{
			get{return _Value;}
			set
			{
				_Value = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ForecastColumn:ForecastColumnId")]
		public ForecastColumn ForecastColumn { get; set; }
		[CProperty(Navigation ="ForecastIndicator:IndicatorId")]
		public ForecastIndicator Indicator { get; set; }
		[CProperty(Navigation ="ForecastRow:RowId")]
		public ForecastRow Row { get; set; }
		[CProperty(Navigation ="ForecastSheet:SheetId")]
		public ForecastSheet Sheet { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
