using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleGridEditPage")]
	public class SysModuleGridEditPage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysEditPageSchemaId")]
		public Guid SysEditPageSchemaId { get; set; }
		[CProperty(ColumnPath ="SysEditPageSchemaUId")]
		public Guid SysEditPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysModuleGridPageId")]
		public Guid SysModuleGridPageId { get; set; }
		[CProperty(ColumnPath ="SysModuleGridPageUId")]
		public Guid SysModuleGridPageUId { get; set; }
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:SysModuleGridPageId")]
		public SysSchema SysModuleGridPage { get; set; }
		[CProperty(Navigation ="SysSchema:SysEditPageSchemaId")]
		public SysSchema SysEditPageSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
