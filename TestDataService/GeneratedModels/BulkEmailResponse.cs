using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailResponse")]
	public class BulkEmailResponse : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Category")]
		public int Category { get; set; }
		[CProperty(ColumnPath ="Code")]
		public int Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsFinalState")]
		public bool IsFinalState { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Priority")]
		public int Priority { get; set; }
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
		[CProperty(Association ="BulkEmailCountLimit:OverlimitResponseId")]
		public virtual ICollection<BulkEmailCountLimit> BulkEmailCountLimitByOverlimitResponse { get; set; }
		[CProperty(Association ="BulkEmailTarget:BulkEmailResponseId")]
		public virtual ICollection<BulkEmailTarget> BulkEmailTargetByBulkEmailResponse { get; set; }
		#endregion
	}
}
