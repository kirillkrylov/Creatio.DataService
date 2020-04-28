using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BulkEmailInBulkEmailSplit")]
	public class BulkEmailInBulkEmailSplit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId { get; set; }
		[CProperty(ColumnPath ="BulkEmailSplitId")]
		public Guid BulkEmailSplitId { get; set; }
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
		[CProperty(Navigation ="BulkEmail:BulkEmailId")]
		public BulkEmail BulkEmail { get; set; }
		[CProperty(Navigation ="BulkEmailSplit:BulkEmailSplitId")]
		public BulkEmailSplit BulkEmailSplit { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
