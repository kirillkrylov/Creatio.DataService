using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwWorkTripInternalRequest")]
	public class VwWorkTripInternalRequest : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="PlannedDepartureDateTimeFromDestination")]
		public DateTime PlannedDepartureDateTimeFromDestination { get; set; }
		[CProperty(ColumnPath ="PlannedDepartureDateTimeToDestination")]
		public DateTime PlannedDepartureDateTimeToDestination { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RequesterId")]
		public Guid RequesterId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TripId")]
		public Guid TripId { get; set; }
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
