using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TripType")]
	public class TripType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InternalRequest:TripId")]
		public virtual ICollection<InternalRequest> InternalRequestByTrip { get; set; }
		[CProperty(Association ="RequestExesType:TripTypeId")]
		public virtual ICollection<RequestExesType> RequestExesTypeByTripType { get; set; }
		[CProperty(Association ="TripsDailyAllowance:TripTypeId")]
		public virtual ICollection<TripsDailyAllowance> TripsDailyAllowanceByTripType { get; set; }
		[CProperty(Association ="VwWorkTripInternalRequest:TripId")]
		public virtual ICollection<VwWorkTripInternalRequest> VwWorkTripInternalRequestByTrip { get; set; }
		#endregion
	}
}
