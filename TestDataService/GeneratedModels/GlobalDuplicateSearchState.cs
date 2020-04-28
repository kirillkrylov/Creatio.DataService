using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlobalDuplicateSearchState")]
	public class GlobalDuplicateSearchState : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntityRowNumber")]
		public int EntityRowNumber { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsManuallyTriggered")]
		public bool IsManuallyTriggered { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessedCount")]
		public int ProcessedCount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SchemaToSearchId")]
		public Guid SchemaToSearchId { get; set; }
		[CProperty(ColumnPath ="SchemaToSearchName")]
		public string SchemaToSearchName { get; set; }
		[CProperty(ColumnPath ="SearchStatusChangedOn")]
		public DateTime SearchStatusChangedOn { get; set; }
		[CProperty(ColumnPath ="SearchStatusId")]
		public Guid SearchStatusId { get; set; }
		[CProperty(ColumnPath ="TotalCount")]
		public int TotalCount { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlobalDuplicateSearchStatus:SearchStatusId")]
		public GlobalDuplicateSearchStatus SearchStatus { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
