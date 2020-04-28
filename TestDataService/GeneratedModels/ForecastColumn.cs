using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastColumn")]
	public class ForecastColumn : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IndicatorId")]
		public Guid IndicatorId { get; set; }
		[CProperty(ColumnPath ="IsHide")]
		public bool IsHide { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Settings")]
		public string Settings { get; set; }
		[CProperty(ColumnPath ="SheetId")]
		public Guid SheetId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ForecastColumnType:TypeId")]
		public ForecastColumnType Type { get; set; }
		[CProperty(Navigation ="ForecastIndicator:IndicatorId")]
		public ForecastIndicator Indicator { get; set; }
		[CProperty(Navigation ="ForecastSheet:SheetId")]
		public ForecastSheet Sheet { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:ForecastColumnId")]
		public virtual ICollection<AccountForecast> AccountForecastByForecastColumn { get; set; }
		[CProperty(Association ="ContactForecast:ForecastColumnId")]
		public virtual ICollection<ContactForecast> ContactForecastByForecastColumn { get; set; }
		[CProperty(Association ="EmployeeForecast:ForecastColumnId")]
		public virtual ICollection<EmployeeForecast> EmployeeForecastByForecastColumn { get; set; }
		[CProperty(Association ="LeadTypeForecast:ForecastColumnId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByForecastColumn { get; set; }
		[CProperty(Association ="OppDepartmentForecast:ForecastColumnId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByForecastColumn { get; set; }
		[CProperty(Association ="ProductForecast:ForecastColumnId")]
		public virtual ICollection<ProductForecast> ProductForecastByForecastColumn { get; set; }
		#endregion
	}
}
