using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SegmentStatus")]
	public class SegmentStatus : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmail:SegmentsStatusId")]
		public virtual ICollection<BulkEmail> BulkEmailBySegmentsStatus { get; set; }
		[CProperty(Association ="BulkEmailSegment:StateId")]
		public virtual ICollection<BulkEmailSegment> BulkEmailSegmentByState { get; set; }
		[CProperty(Association ="BulkEmailSplit:SegmentsStatusId")]
		public virtual ICollection<BulkEmailSplit> BulkEmailSplitBySegmentsStatus { get; set; }
		[CProperty(Association ="BulkEmailSplitSegment:StateId")]
		public virtual ICollection<BulkEmailSplitSegment> BulkEmailSplitSegmentByState { get; set; }
		[CProperty(Association ="Campaign:SegmentsStatusId")]
		public virtual ICollection<Campaign> CampaignBySegmentsStatus { get; set; }
		[CProperty(Association ="CampaignSegment:StateId")]
		public virtual ICollection<CampaignSegment> CampaignSegmentByState { get; set; }
		[CProperty(Association ="Event:ActualizeStatusId")]
		public virtual ICollection<Event> EventByActualizeStatus { get; set; }
		[CProperty(Association ="Event:SegmentsStatusId")]
		public virtual ICollection<Event> EventBySegmentsStatus { get; set; }
		[CProperty(Association ="EventSegment:StateId")]
		public virtual ICollection<EventSegment> EventSegmentByState { get; set; }
		#endregion
	}
}
