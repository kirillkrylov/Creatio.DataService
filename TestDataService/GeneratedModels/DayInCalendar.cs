using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DayInCalendar")]
	public class DayInCalendar : BaseEntity
	{
		#region Values
		private Guid _CalendarId;
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId
		{
			get{return _CalendarId;}
			set
			{
				_CalendarId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _Date;
		[CProperty(ColumnPath ="Date")]
		public DateTime Date
		{
			get{return _Date;}
			set
			{
				_Date = value;
				OnPropertyChanged();
			}
		}
		private Guid _DayOfWeekId;
		[CProperty(ColumnPath ="DayOfWeekId")]
		public Guid DayOfWeekId
		{
			get{return _DayOfWeekId;}
			set
			{
				_DayOfWeekId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DayTypeId;
		[CProperty(ColumnPath ="DayTypeId")]
		public Guid DayTypeId
		{
			get{return _DayTypeId;}
			set
			{
				_DayTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Calendar:CalendarId")]
		public Calendar Calendar { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DayOfWeek:DayOfWeekId")]
		public DayOfWeek DayOfWeek { get; set; }
		[CProperty(Navigation ="DayType:DayTypeId")]
		public DayType DayType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="WorkingTimeInterval:DayInCalendarId")]
		public virtual ICollection<WorkingTimeInterval> WorkingTimeIntervalByDayInCalendar { get; set; }
		#endregion
	}
}
