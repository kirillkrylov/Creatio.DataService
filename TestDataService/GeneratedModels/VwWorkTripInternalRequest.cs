using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwWorkTripInternalRequest")]
	public class VwWorkTripInternalRequest : BaseEntity
	{
		#region Values
		private Guid _CityId;
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId
		{
			get{return _CityId;}
			set
			{
				_CityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CountryId;
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId
		{
			get{return _CountryId;}
			set
			{
				_CountryId = value;
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
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlannedDepartureDateTimeFromDestination;
		[CProperty(ColumnPath ="PlannedDepartureDateTimeFromDestination")]
		public DateTime PlannedDepartureDateTimeFromDestination
		{
			get{return _PlannedDepartureDateTimeFromDestination;}
			set
			{
				_PlannedDepartureDateTimeFromDestination = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlannedDepartureDateTimeToDestination;
		[CProperty(ColumnPath ="PlannedDepartureDateTimeToDestination")]
		public DateTime PlannedDepartureDateTimeToDestination
		{
			get{return _PlannedDepartureDateTimeToDestination;}
			set
			{
				_PlannedDepartureDateTimeToDestination = value;
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
		private Guid _RequesterId;
		[CProperty(ColumnPath ="RequesterId")]
		public Guid RequesterId
		{
			get{return _RequesterId;}
			set
			{
				_RequesterId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TripId;
		[CProperty(ColumnPath ="TripId")]
		public Guid TripId
		{
			get{return _TripId;}
			set
			{
				_TripId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:RequesterId")]
		public Contact Requester { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="RequestStatus:StatusId")]
		public RequestStatus Status { get; set; }
		[CProperty(Navigation ="TripType:TripId")]
		public TripType Trip { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
