using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PeriodicitySettings")]
	public class PeriodicitySettings : BaseEntity
	{
		#region Values
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
		private DateTime _CustomFrom;
		[CProperty(ColumnPath ="CustomFrom")]
		public DateTime CustomFrom
		{
			get{return _CustomFrom;}
			set
			{
				_CustomFrom = value;
				OnPropertyChanged();
			}
		}
		private int _CustomPeriod;
		[CProperty(ColumnPath ="CustomPeriod")]
		public int CustomPeriod
		{
			get{return _CustomPeriod;}
			set
			{
				_CustomPeriod = value;
				OnPropertyChanged();
			}
		}
		private int _CustomPeriodType;
		[CProperty(ColumnPath ="CustomPeriodType")]
		public int CustomPeriodType
		{
			get{return _CustomPeriodType;}
			set
			{
				_CustomPeriodType = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CustomTill;
		[CProperty(ColumnPath ="CustomTill")]
		public DateTime CustomTill
		{
			get{return _CustomTill;}
			set
			{
				_CustomTill = value;
				OnPropertyChanged();
			}
		}
		private int _DailyPeriod;
		[CProperty(ColumnPath ="DailyPeriod")]
		public int DailyPeriod
		{
			get{return _DailyPeriod;}
			set
			{
				_DailyPeriod = value;
				OnPropertyChanged();
			}
		}
		private int _DayOfMonth;
		[CProperty(ColumnPath ="DayOfMonth")]
		public int DayOfMonth
		{
			get{return _DayOfMonth;}
			set
			{
				_DayOfMonth = value;
				OnPropertyChanged();
			}
		}
		private int _DayOfWeek;
		[CProperty(ColumnPath ="DayOfWeek")]
		public int DayOfWeek
		{
			get{return _DayOfWeek;}
			set
			{
				_DayOfWeek = value;
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
		private bool _IsCustom;
		[CProperty(ColumnPath ="IsCustom")]
		public bool IsCustom
		{
			get{return _IsCustom;}
			set
			{
				_IsCustom = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDaily;
		[CProperty(ColumnPath ="IsDaily")]
		public bool IsDaily
		{
			get{return _IsDaily;}
			set
			{
				_IsDaily = value;
				OnPropertyChanged();
			}
		}
		private bool _IsMonthly;
		[CProperty(ColumnPath ="IsMonthly")]
		public bool IsMonthly
		{
			get{return _IsMonthly;}
			set
			{
				_IsMonthly = value;
				OnPropertyChanged();
			}
		}
		private bool _IsMonthlyCustom;
		[CProperty(ColumnPath ="IsMonthlyCustom")]
		public bool IsMonthlyCustom
		{
			get{return _IsMonthlyCustom;}
			set
			{
				_IsMonthlyCustom = value;
				OnPropertyChanged();
			}
		}
		private bool _IsMonthlyLastDay;
		[CProperty(ColumnPath ="IsMonthlyLastDay")]
		public bool IsMonthlyLastDay
		{
			get{return _IsMonthlyLastDay;}
			set
			{
				_IsMonthlyLastDay = value;
				OnPropertyChanged();
			}
		}
		private bool _IsOnce;
		[CProperty(ColumnPath ="IsOnce")]
		public bool IsOnce
		{
			get{return _IsOnce;}
			set
			{
				_IsOnce = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSchedulerEndless;
		[CProperty(ColumnPath ="IsSchedulerEndless")]
		public bool IsSchedulerEndless
		{
			get{return _IsSchedulerEndless;}
			set
			{
				_IsSchedulerEndless = value;
				OnPropertyChanged();
			}
		}
		private bool _IsWeekly;
		[CProperty(ColumnPath ="IsWeekly")]
		public bool IsWeekly
		{
			get{return _IsWeekly;}
			set
			{
				_IsWeekly = value;
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
		private DateTime _OnceAt;
		[CProperty(ColumnPath ="OnceAt")]
		public DateTime OnceAt
		{
			get{return _OnceAt;}
			set
			{
				_OnceAt = value;
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
		private DateTime _SchedulerFinish;
		[CProperty(ColumnPath ="SchedulerFinish")]
		public DateTime SchedulerFinish
		{
			get{return _SchedulerFinish;}
			set
			{
				_SchedulerFinish = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SchedulerStart;
		[CProperty(ColumnPath ="SchedulerStart")]
		public DateTime SchedulerStart
		{
			get{return _SchedulerStart;}
			set
			{
				_SchedulerStart = value;
				OnPropertyChanged();
			}
		}
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
