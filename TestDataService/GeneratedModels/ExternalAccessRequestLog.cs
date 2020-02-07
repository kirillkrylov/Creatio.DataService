using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExternalAccessRequestLog")]
	public class ExternalAccessRequestLog : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CustomerId")]
		public string CustomerId { get; set; }
		[CProperty(ColumnPath ="ExternalAccessDescription")]
		public string ExternalAccessDescription { get; set; }
		[CProperty(ColumnPath ="ExternalAccessId")]
		public Guid ExternalAccessId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RequestedById")]
		public Guid RequestedById { get; set; }
		[CProperty(ColumnPath ="RequestedOn")]
		public DateTime RequestedOn { get; set; }
		[CProperty(ColumnPath ="Url")]
		public string Url { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:RequestedById")]
		public Contact RequestedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
