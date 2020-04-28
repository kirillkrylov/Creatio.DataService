using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleReportTable")]
	public class SysModuleReportTable : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Filter")]
		public byte[] Filter { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsEmptyTableHide")]
		public bool IsEmptyTableHide { get; set; }
		[CProperty(ColumnPath ="MacrosList")]
		public string MacrosList { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ObjectColumnCaption")]
		public string ObjectColumnCaption { get; set; }
		[CProperty(ColumnPath ="ObjectColumnPath")]
		public string ObjectColumnPath { get; set; }
		[CProperty(ColumnPath ="ObjectId")]
		public Guid ObjectId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReferenceColumn")]
		public string ReferenceColumn { get; set; }
		[CProperty(ColumnPath ="ReferenceColumnCaption")]
		public string ReferenceColumnCaption { get; set; }
		[CProperty(ColumnPath ="SysModuleReportId")]
		public Guid SysModuleReportId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleReport:SysModuleReportId")]
		public SysModuleReport SysModuleReport { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
