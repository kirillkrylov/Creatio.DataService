using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysProcessUserTask")]
	public class SysProcessUserTask : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsQuickModel")]
		public bool IsQuickModel { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="QuickModelEditPageSchemaUId")]
		public Guid QuickModelEditPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysImageId")]
		public Guid SysImageId { get; set; }
		[CProperty(ColumnPath ="SysUserTaskSchemaUId")]
		public Guid SysUserTaskSchemaUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:SysImageId")]
		public SysImage SysImage { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
