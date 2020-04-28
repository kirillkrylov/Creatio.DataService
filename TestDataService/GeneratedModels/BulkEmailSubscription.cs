using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailSubscription")]
	public class BulkEmailSubscription : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BulkEmailSubsStatusId")]
		public Guid BulkEmailSubsStatusId { get; set; }
		[CProperty(ColumnPath ="BulkEmailTypeId")]
		public Guid BulkEmailTypeId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailSubsStatus:BulkEmailSubsStatusId")]
		public BulkEmailSubsStatus BulkEmailSubsStatus { get; set; }
		[CProperty(Navigation ="BulkEmailType:BulkEmailTypeId")]
		public BulkEmailType BulkEmailType { get; set; }
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
