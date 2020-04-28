using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastSheet")]
	public class ForecastSheet : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ForecastEntityId")]
		public Guid ForecastEntityId { get; set; }
		[CProperty(ColumnPath ="ForecastEntityInCellUId")]
		public Guid ForecastEntityInCellUId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PeriodTypeId")]
		public Guid PeriodTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Setting")]
		public string Setting { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PeriodType:PeriodTypeId")]
		public PeriodType PeriodType { get; set; }
		[CProperty(Navigation ="VwEntityObjects:ForecastEntityId")]
		public VwEntityObjects ForecastEntity { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:SheetId")]
		public virtual ICollection<AccountForecast> AccountForecastBySheet { get; set; }
		[CProperty(Association ="ContactForecast:SheetId")]
		public virtual ICollection<ContactForecast> ContactForecastBySheet { get; set; }
		[CProperty(Association ="EmployeeForecast:SheetId")]
		public virtual ICollection<EmployeeForecast> EmployeeForecastBySheet { get; set; }
		[CProperty(Association ="ForecastColumn:SheetId")]
		public virtual ICollection<ForecastColumn> ForecastColumnBySheet { get; set; }
		[CProperty(Association ="LeadTypeForecast:SheetId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastBySheet { get; set; }
		[CProperty(Association ="OppDepartmentForecast:SheetId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastBySheet { get; set; }
		[CProperty(Association ="ProductForecast:SheetId")]
		public virtual ICollection<ProductForecast> ProductForecastBySheet { get; set; }
		#endregion
	}
}
