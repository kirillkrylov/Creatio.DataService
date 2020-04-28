using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwAdministrativeObjects")]
	public class VwAdministrativeObjects : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AdministratedByColumns")]
		public bool AdministratedByColumns { get; set; }
		[CProperty(ColumnPath ="AdministratedByOperations")]
		public bool AdministratedByOperations { get; set; }
		[CProperty(ColumnPath ="AdministratedByRecords")]
		public bool AdministratedByRecords { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsInSSPEntitySchemaAccessList")]
		public bool IsInSSPEntitySchemaAccessList { get; set; }
		[CProperty(ColumnPath ="IsLookup")]
		public bool IsLookup { get; set; }
		[CProperty(ColumnPath ="IsModule")]
		public bool IsModule { get; set; }
		[CProperty(ColumnPath ="IsTrackChangesInDB")]
		public bool IsTrackChangesInDB { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
