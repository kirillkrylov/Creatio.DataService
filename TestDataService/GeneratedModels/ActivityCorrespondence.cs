using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ActivityCorrespondence")]
	public class ActivityCorrespondence : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActivityId")]
		public Guid ActivityId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedInBPMonline")]
		public bool CreatedInBPMonline { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsDeleted")]
		public bool IsDeleted { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SourceAccountId")]
		public Guid SourceAccountId { get; set; }
		[CProperty(ColumnPath ="SourceActivityId")]
		public string SourceActivityId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Activity:ActivityId")]
		public Activity Activity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SocialAccount:SourceAccountId")]
		public SocialAccount SourceAccount { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
