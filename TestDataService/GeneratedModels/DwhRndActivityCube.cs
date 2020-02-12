using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DwhRndActivityCube")]
	public class DwhRndActivityCube : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AvgDuration")]
		public decimal AvgDuration { get; set; }
		[CProperty(ColumnPath ="BillingJira")]
		public decimal BillingJira { get; set; }
		[CProperty(ColumnPath ="BillingTotal")]
		public decimal BillingTotal { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IncAvgDuration")]
		public decimal IncAvgDuration { get; set; }
		[CProperty(ColumnPath ="IncidentCount")]
		public int IncidentCount { get; set; }
		[CProperty(ColumnPath ="IncIncidentCount")]
		public decimal IncIncidentCount { get; set; }
		[CProperty(ColumnPath ="IncProductivity")]
		public decimal IncProductivity { get; set; }
		[CProperty(ColumnPath ="IncSpeed")]
		public decimal IncSpeed { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Productivity")]
		public decimal Productivity { get; set; }
		[CProperty(ColumnPath ="Speed")]
		public decimal Speed { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
