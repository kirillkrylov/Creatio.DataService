using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PtGanttSetting")]
	public class PtGanttSetting : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DiagramColumn")]
		public string DiagramColumn { get; set; }
		[CProperty(ColumnPath ="DueDateColumn")]
		public string DueDateColumn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NameColumn")]
		public string NameColumn { get; set; }
		[CProperty(ColumnPath ="ParentColumn")]
		public string ParentColumn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SectionId")]
		public Guid SectionId { get; set; }
		[CProperty(ColumnPath ="StartDateColumn")]
		public string StartDateColumn { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModule:SectionId")]
		public SysModule Section { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
