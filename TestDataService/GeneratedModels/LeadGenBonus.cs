using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadGenBonus")]
	public class LeadGenBonus : BaseEntity
	{
		#region Values
		private decimal _BonusHours;
		[CProperty(ColumnPath ="BonusHours")]
		public decimal BonusHours
		{
			get{return _BonusHours;}
			set
			{
				_BonusHours = value;
				OnPropertyChanged();
			}
		}
		private int _CallCount;
		[CProperty(ColumnPath ="CallCount")]
		public int CallCount
		{
			get{return _CallCount;}
			set
			{
				_CallCount = value;
				OnPropertyChanged();
			}
		}
		private int _CardActCount;
		[CProperty(ColumnPath ="CardActCount")]
		public int CardActCount
		{
			get{return _CardActCount;}
			set
			{
				_CardActCount = value;
				OnPropertyChanged();
			}
		}
		private int _CompletnessCount;
		[CProperty(ColumnPath ="CompletnessCount")]
		public int CompletnessCount
		{
			get{return _CompletnessCount;}
			set
			{
				_CompletnessCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
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
		private int _HourInMonts;
		[CProperty(ColumnPath ="HourInMonts")]
		public int HourInMonts
		{
			get{return _HourInMonts;}
			set
			{
				_HourInMonts = value;
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
		private int _MeetConductCount;
		[CProperty(ColumnPath ="MeetConductCount")]
		public int MeetConductCount
		{
			get{return _MeetConductCount;}
			set
			{
				_MeetConductCount = value;
				OnPropertyChanged();
			}
		}
		private int _MeetDoneCount;
		[CProperty(ColumnPath ="MeetDoneCount")]
		public int MeetDoneCount
		{
			get{return _MeetDoneCount;}
			set
			{
				_MeetDoneCount = value;
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
