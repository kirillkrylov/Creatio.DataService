using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Calendar")]
	public class Calendar : BaseEntity
	{
		#region Values
		private bool _AroundClock;
		[CProperty(ColumnPath ="AroundClock")]
		public bool AroundClock
		{
			get{return _AroundClock;}
			set
			{
				_AroundClock = value;
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
		private int _Depth;
		[CProperty(ColumnPath ="Depth")]
		public int Depth
		{
			get{return _Depth;}
			set
			{
				_Depth = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private Guid _TimeZoneId;
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId
		{
			get{return _TimeZoneId;}
			set
			{
				_TimeZoneId = value;
				OnPropertyChanged();
			}
		}
		private Guid _UserId;
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId
		{
			get{return _UserId;}
			set
			{
				_UserId = value;
				OnPropertyChanged();
			}
		}
		private bool _WithoutDayOff;
		[CProperty(ColumnPath ="WithoutDayOff")]
		public bool WithoutDayOff
		{
			get{return _WithoutDayOff;}
			set
			{
				_WithoutDayOff = value;
				OnPropertyChanged();
			}
		}
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
		[CProperty(Association ="SupportUnit:CalendarId")]
		public virtual ICollection<SupportUnit> SupportUnitByCalendar { get; set; }
		[CProperty(Association ="SupportUnitLog:CalendarId")]
		public virtual ICollection<SupportUnitLog> SupportUnitLogByCalendar { get; set; }
		[CProperty(Association ="VwProductSLA:CalendarId")]
		public virtual ICollection<VwProductSLA> VwProductSLAByCalendar { get; set; }
		#endregion
	}
}
