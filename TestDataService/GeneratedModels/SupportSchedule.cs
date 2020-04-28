using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupportSchedule")]
	public class SupportSchedule : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Date")]
		public DateTime Date { get; set; }
		[CProperty(ColumnPath ="DayOfWeekId")]
		public Guid DayOfWeekId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsAvailable")]
		public bool IsAvailable { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SupportUnitId")]
		public Guid SupportUnitId { get; set; }
		[CProperty(ColumnPath ="SupportWorkingDayTypeId")]
		public Guid SupportWorkingDayTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DayOfWeek:DayOfWeekId")]
		public DayOfWeek DayOfWeek { get; set; }
		[CProperty(Navigation ="SupportUnit:SupportUnitId")]
		public SupportUnit SupportUnit { get; set; }
		[CProperty(Navigation ="SupportWorkingDayType:SupportWorkingDayTypeId")]
		public SupportWorkingDayType SupportWorkingDayType { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
