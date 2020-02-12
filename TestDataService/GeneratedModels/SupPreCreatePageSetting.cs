using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupPreCreatePageSetting")]
	public class SupPreCreatePageSetting : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SupEntitySchemaEditPageId")]
		public Guid SupEntitySchemaEditPageId { get; set; }
		[CProperty(ColumnPath ="SupEntitySchemaId")]
		public Guid SupEntitySchemaId { get; set; }
		[CProperty(ColumnPath ="SupPreCreateEditPageId")]
		public Guid SupPreCreateEditPageId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleEdit:SupEntitySchemaEditPageId")]
		public SysModuleEdit SupEntitySchemaEditPage { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:SupPreCreateEditPageId")]
		public VwSysSchemaInfo SupPreCreateEditPage { get; set; }
		[CProperty(Navigation ="VwSysSchemaInfo:SupEntitySchemaId")]
		public VwSysSchemaInfo SupEntitySchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
