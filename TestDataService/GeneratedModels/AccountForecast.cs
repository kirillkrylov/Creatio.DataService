using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountForecast")]
	public class AccountForecast : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Amount")]
		public decimal Amount { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath ="ForecastColumnId")]
		public Guid ForecastColumnId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IndicatorId")]
		public Guid IndicatorId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="PrimaryAmount")]
		public decimal PrimaryAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RowId")]
		public Guid RowId { get; set; }
		[CProperty(ColumnPath ="SheetId")]
		public Guid SheetId { get; set; }
		[CProperty(ColumnPath ="Value")]
		public decimal Value { get; set; }
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
