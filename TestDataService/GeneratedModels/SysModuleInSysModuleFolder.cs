using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleInSysModuleFolder")]
	public class SysModuleInSysModuleFolder : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SubSysModuleFolderId")]
		public Guid SubSysModuleFolderId { get; set; }
		[CProperty(ColumnPath ="SysModuleFolderId")]
		public Guid SysModuleFolderId { get; set; }
		[CProperty(ColumnPath ="SysModuleId")]
		public Guid SysModuleId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModule:SysModuleId")]
		public SysModule SysModule { get; set; }
		[CProperty(Navigation ="SysModuleFolder:SubSysModuleFolderId")]
		public SysModuleFolder SubSysModuleFolder { get; set; }
		[CProperty(Navigation ="SysModuleFolder:SysModuleFolderId")]
		public SysModuleFolder SysModuleFolder { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
