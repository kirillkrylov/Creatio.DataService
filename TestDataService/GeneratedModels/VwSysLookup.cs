using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysLookup")]
	public class VwSysLookup : BaseEntity
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
		[CProperty(ColumnPath ="IsSimple")]
		public bool IsSimple { get; set; }
		[CProperty(ColumnPath ="IsSystem")]
		public bool IsSystem { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysEditPageSchemaUId")]
		public Guid SysEditPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="SysFolderId")]
		public Guid SysFolderId { get; set; }
		[CProperty(ColumnPath ="SysGridPageSchemaUId")]
		public Guid SysGridPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysLookupFolder:SysFolderId")]
		public SysLookupFolder SysFolder { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:SysGridPageSchemaUId")]
		public VwSysSchemaInfo SysGridPageSchemaU { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:SysEntitySchemaUId")]
		public VwSysSchemaInfo SysEntitySchemaU { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
