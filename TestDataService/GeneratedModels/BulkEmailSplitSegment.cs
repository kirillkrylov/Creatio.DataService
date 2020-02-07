using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailSplitSegment")]
	public class BulkEmailSplitSegment : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BulkEmailSplitId")]
		public Guid BulkEmailSplitId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailSplit:BulkEmailSplitId")]
		public BulkEmailSplit BulkEmailSplit { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ContactFolder:SegmentId")]
		public ContactFolder Segment { get; set; }
		[CProperty(Navigation ="SegmentStatus:StateId")]
		public SegmentStatus State { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
