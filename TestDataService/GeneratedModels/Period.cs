using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Period")]
	public class Period : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="PeriodTypeId")]
		public Guid PeriodTypeId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="QuarterId")]
		public Guid QuarterId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="YearId")]
		public Guid YearId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Period:ParentId")]
		public Period Parent { get; set; }
		[CProperty(Navigation ="Period:YearId")]
		public Period Year { get; set; }
		[CProperty(Navigation ="Period:QuarterId")]
		public Period Quarter { get; set; }
		[CProperty(Navigation ="PeriodType:PeriodTypeId")]
		public PeriodType PeriodType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:PeriodId")]
		public virtual ICollection<AccountForecast> AccountForecastByPeriod { get; set; }
		[CProperty(Association ="ContactForecast:PeriodId")]
		public virtual ICollection<ContactForecast> ContactForecastByPeriod { get; set; }
		[CProperty(Association ="LeadTypeForecast:PeriodId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByPeriod { get; set; }
		[CProperty(Association ="OppDepartmentForecast:PeriodId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByPeriod { get; set; }
		[CProperty(Association ="Period:ParentId")]
		public virtual ICollection<Period> PeriodByParent { get; set; }
		[CProperty(Association ="Period:YearId")]
		public virtual ICollection<Period> PeriodByYear { get; set; }
		[CProperty(Association ="Period:QuarterId")]
		public virtual ICollection<Period> PeriodByQuarter { get; set; }
		#endregion
	}
}
