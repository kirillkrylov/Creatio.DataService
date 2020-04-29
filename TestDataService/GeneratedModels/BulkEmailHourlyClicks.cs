using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailHourlyClicks")]
	public class BulkEmailHourlyClicks : BaseEntity
	{
		#region Values
		private Guid _BulkEmailId;
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId
		{
			get{return _BulkEmailId;}
			set
			{
				_BulkEmailId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DateMark;
		[CProperty(ColumnPath ="DateMark")]
		public DateTime DateMark
		{
			get{return _DateMark;}
			set
			{
				_DateMark = value;
				OnPropertyChanged();
			}
		}
		private int _EventsCount;
		[CProperty(ColumnPath ="EventsCount")]
		public int EventsCount
		{
			get{return _EventsCount;}
			set
			{
				_EventsCount = value;
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
