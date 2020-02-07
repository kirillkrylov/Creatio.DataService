using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PeriodicitySettings")]
	public class PeriodicitySettings : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CustomFrom")]
		public DateTime CustomFrom { get; set; }
		[CProperty(ColumnPath ="CustomPeriod")]
		public int CustomPeriod { get; set; }
		[CProperty(ColumnPath ="CustomPeriodType")]
		public int CustomPeriodType { get; set; }
		[CProperty(ColumnPath ="CustomTill")]
		public DateTime CustomTill { get; set; }
		[CProperty(ColumnPath ="DailyPeriod")]
		public int DailyPeriod { get; set; }
		[CProperty(ColumnPath ="DayOfMonth")]
		public int DayOfMonth { get; set; }
		[CProperty(ColumnPath ="DayOfWeek")]
		public int DayOfWeek { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsCustom")]
		public bool IsCustom { get; set; }
		[CProperty(ColumnPath ="IsDaily")]
		public bool IsDaily { get; set; }
		[CProperty(ColumnPath ="IsMonthly")]
		public bool IsMonthly { get; set; }
		[CProperty(ColumnPath ="IsMonthlyCustom")]
		public bool IsMonthlyCustom { get; set; }
		[CProperty(ColumnPath ="IsMonthlyLastDay")]
		public bool IsMonthlyLastDay { get; set; }
		[CProperty(ColumnPath ="IsOnce")]
		public bool IsOnce { get; set; }
		[CProperty(ColumnPath ="IsSchedulerEndless")]
		public bool IsSchedulerEndless { get; set; }
		[CProperty(ColumnPath ="IsWeekly")]
		public bool IsWeekly { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OnceAt")]
		public DateTime OnceAt { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SchedulerFinish")]
		public DateTime SchedulerFinish { get; set; }
		[CProperty(ColumnPath ="SchedulerStart")]
		public DateTime SchedulerStart { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
