using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "WorkingTimeInterval")]
	public class WorkingTimeInterval : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DayInCalendarId")]
		public Guid DayInCalendarId { get; set; }
		[CProperty(ColumnPath ="DayOffId")]
		public Guid DayOffId { get; set; }
		[CProperty(ColumnPath ="From")]
		public DateTime From { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Index")]
		public int Index { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="To")]
		public DateTime To { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DayInCalendar:DayInCalendarId")]
		public DayInCalendar DayInCalendar { get; set; }
		[CProperty(Navigation ="DayOff:DayOffId")]
		public DayOff DayOff { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
