using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestExesType")]
	public class RequestExesType : BaseEntity
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
		[CProperty(ColumnPath ="TripTypeId")]
		public Guid TripTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TripType:TripTypeId")]
		public TripType TripType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ExesInRequest:RequestExesTypeId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByRequestExesType { get; set; }
		[CProperty(Association ="InternalRequest:ExesTypeId")]
		public virtual ICollection<InternalRequest> InternalRequestByExesType { get; set; }
		[CProperty(Association ="RequestExesByType:RequestExesTypeId")]
		public virtual ICollection<RequestExesByType> RequestExesByTypeByRequestExesType { get; set; }
		#endregion
	}
}
