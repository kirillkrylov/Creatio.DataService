using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwDate")]
	public class VwDate : BaseEntity
	{
		#region Values
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
		#endregion

		#region Navigation
		#endregion

		#region Associations
		#endregion
	}
}
