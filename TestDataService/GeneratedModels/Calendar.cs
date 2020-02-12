using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Calendar")]
	public class Calendar : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AroundClock")]
		public bool AroundClock { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Depth")]
		public int Depth { get; set; }
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
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId { get; set; }
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId { get; set; }
		[CProperty(ColumnPath ="WithoutDayOff")]
		public bool WithoutDayOff { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:ParentId")]
		public Calendar Parent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:UserId")]
		public SysAdminUnit User { get; set; }
		[CProperty(Navigation ="TimeZone:TimeZoneId")]
		public TimeZone TimeZone { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Calendar:ParentId")]
		public virtual ICollection<Calendar> CalendarByParent { get; set; }
		[CProperty(Association ="DayInCalendar:CalendarId")]
		public virtual ICollection<DayInCalendar> DayInCalendarByCalendar { get; set; }
		[CProperty(Association ="DayOff:CalendarId")]
		public virtual ICollection<DayOff> DayOffByCalendar { get; set; }
		[CProperty(Association ="ServiceCalendar:CalendarId")]
		public virtual ICollection<ServiceCalendar> ServiceCalendarByCalendar { get; set; }
		[CProperty(Association ="ServiceInServicePact:CalendarId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByCalendar { get; set; }
		[CProperty(Association ="ServiceItem:CalendarId")]
		public virtual ICollection<ServiceItem> ServiceItemByCalendar { get; set; }
		[CProperty(Association ="ServicePact:CalendarId")]
		public virtual ICollection<ServicePact> ServicePactByCalendar { get; set; }
		[CProperty(Association ="VwProductSLA:CalendarId")]
		public virtual ICollection<VwProductSLA> VwProductSLAByCalendar { get; set; }
		#endregion
	}
}
