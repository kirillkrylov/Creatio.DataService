using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ResolvedLookupConflict")]
	public class ResolvedLookupConflict : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="LookupRecordId")]
		public Guid LookupRecordId { get; set; }
		[CProperty(ColumnPath ="LookupSchemaDisplayColumnName")]
		public string LookupSchemaDisplayColumnName { get; set; }
		[CProperty(ColumnPath ="LookupSchemaDisplayColumnValue")]
		public string LookupSchemaDisplayColumnValue { get; set; }
		[CProperty(ColumnPath ="LookupSchemaName")]
		public string LookupSchemaName { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
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
		#endregion
	}
}
