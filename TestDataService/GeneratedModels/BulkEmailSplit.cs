using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailSplit")]
	public class BulkEmailSplit : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecipientCount")]
		public int RecipientCount { get; set; }
		[CProperty(ColumnPath ="RecipientPercent")]
		public decimal RecipientPercent { get; set; }
		[CProperty(ColumnPath ="SegmentsStatusId")]
		public Guid SegmentsStatusId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StartManual")]
		public bool StartManual { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TestRecipientCount")]
		public int TestRecipientCount { get; set; }
		[CProperty(ColumnPath ="TransferTableName")]
		public string TransferTableName { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="BulkEmailSplitStatus:StatusId")]
		public BulkEmailSplitStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="SegmentStatus:SegmentsStatusId")]
		public SegmentStatus SegmentsStatus { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BulkEmail:SplitTestId")]
		public virtual ICollection<BulkEmail> BulkEmailBySplitTest { get; set; }
		[CProperty(Association ="BulkEmailInBulkEmailSplit:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailInBulkEmailSplit> BulkEmailInBulkEmailSplitByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitFile:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitFile> BulkEmailSplitFileByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitInFolder:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitInFolder> BulkEmailSplitInFolderByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitSegment:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitSegment> BulkEmailSplitSegmentByBulkEmailSplit { get; set; }
		[CProperty(Association ="BulkEmailSplitTarget:BulkEmailSplitId")]
		public virtual ICollection<BulkEmailSplitTarget> BulkEmailSplitTargetByBulkEmailSplit { get; set; }
		#endregion
	}
}
