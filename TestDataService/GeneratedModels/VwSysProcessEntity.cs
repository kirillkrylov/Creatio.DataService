using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysProcessEntity")]
	public class VwSysProcessEntity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Archived")]
		public bool Archived { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntityDisplayValue")]
		public string EntityDisplayValue { get; set; }
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReferenceSchemaName")]
		public string ReferenceSchemaName { get; set; }
		[CProperty(ColumnPath ="SysProcessId")]
		public Guid SysProcessId { get; set; }
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId { get; set; }
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
		[CProperty(Navigation ="VwSysProcessLog:SysProcessId")]
		public VwSysProcessLog SysProcess { get; set; }
		[CProperty(Navigation ="VwSysSchemaInWorkspace:SysSchemaId")]
		public VwSysSchemaInWorkspace SysSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
