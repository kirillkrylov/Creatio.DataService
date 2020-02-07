using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastIndicator")]
	public class ForecastIndicator : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:IndicatorId")]
		public virtual ICollection<AccountForecast> AccountForecastByIndicator { get; set; }
		[CProperty(Association ="ContactForecast:IndicatorId")]
		public virtual ICollection<ContactForecast> ContactForecastByIndicator { get; set; }
		[CProperty(Association ="ForecastColumn:IndicatorId")]
		public virtual ICollection<ForecastColumn> ForecastColumnByIndicator { get; set; }
		[CProperty(Association ="LeadTypeForecast:IndicatorId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByIndicator { get; set; }
		[CProperty(Association ="OppDepartmentForecast:IndicatorId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByIndicator { get; set; }
		#endregion
	}
}
