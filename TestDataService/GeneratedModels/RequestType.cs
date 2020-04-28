using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestType")]
	public class RequestType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AddAllExesToRequest")]
		public bool AddAllExesToRequest { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
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
		[CProperty(ColumnPath ="RequestDescriptionTemplate")]
		public string RequestDescriptionTemplate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestCategory:CategoryId")]
		public RequestCategory Category { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="InternalRequest:TypeId")]
		public virtual ICollection<InternalRequest> InternalRequestByType { get; set; }
		[CProperty(Association ="RequestExes:RequestTypeId")]
		public virtual ICollection<RequestExes> RequestExesByRequestType { get; set; }
		[CProperty(Association ="RequestExesByType:RequestTypeId")]
		public virtual ICollection<RequestExesByType> RequestExesByTypeByRequestType { get; set; }
		[CProperty(Association ="RequestSubType:RequestTypeId")]
		public virtual ICollection<RequestSubType> RequestSubTypeByRequestType { get; set; }
		#endregion
	}
}
