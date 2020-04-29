using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CalendarAstronomic")]
	public class CalendarAstronomic : BaseEntity
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
		private int _Day;
		[CProperty(ColumnPath ="Day")]
		public int Day
		{
			get{return _Day;}
			set
			{
				_Day = value;
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
		private int _Month;
		[CProperty(ColumnPath ="Month")]
		public int Month
		{
			get{return _Month;}
			set
			{
				_Month = value;
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
		private int _Quart;
		[CProperty(ColumnPath ="Quart")]
		public int Quart
		{
			get{return _Quart;}
			set
			{
				_Quart = value;
				OnPropertyChanged();
			}
		}
		private int _Week;
		[CProperty(ColumnPath ="Week")]
		public int Week
		{
			get{return _Week;}
			set
			{
				_Week = value;
				OnPropertyChanged();
			}
		}
		private int _WeekDay;
		[CProperty(ColumnPath ="WeekDay")]
		public int WeekDay
		{
			get{return _WeekDay;}
			set
			{
				_WeekDay = value;
				OnPropertyChanged();
			}
		}
		private int _Year;
		[CProperty(ColumnPath ="Year")]
		public int Year
		{
			get{return _Year;}
			set
			{
				_Year = value;
				OnPropertyChanged();
			}
		}
		private int _YearMonth;
		[CProperty(ColumnPath ="YearMonth")]
		public int YearMonth
		{
			get{return _YearMonth;}
			set
			{
				_YearMonth = value;
				OnPropertyChanged();
			}
		}
		private int _YearQuart;
		[CProperty(ColumnPath ="YearQuart")]
		public int YearQuart
		{
			get{return _YearQuart;}
			set
			{
				_YearQuart = value;
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
