using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwIsolatedRecord")]
	public class VwIsolatedRecord : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntitySchemaId")]
		public Guid EntitySchemaId { get; set; }
		[CProperty(ColumnPath ="EntitySchemaName")]
		public string EntitySchemaName { get; set; }
		[CProperty(ColumnPath ="ExternalAccessId")]
		public Guid ExternalAccessId { get; set; }
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
		[CProperty(ColumnPath ="RecordId")]
		public Guid RecordId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ExternalAccess:ExternalAccessId")]
		public ExternalAccess ExternalAccess { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:EntitySchemaId")]
		public VwSysSchemaInfo EntitySchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
