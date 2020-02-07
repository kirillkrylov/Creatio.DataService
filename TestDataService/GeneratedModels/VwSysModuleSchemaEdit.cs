using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysModuleSchemaEdit")]
	public class VwSysModuleSchemaEdit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EditPageCaption")]
		public string EditPageCaption { get; set; }
		[CProperty(ColumnPath ="EditPageName")]
		public string EditPageName { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MiniPageSchemaUId")]
		public Guid MiniPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PageCaption")]
		public string PageCaption { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId { get; set; }
		[CProperty(ColumnPath ="TypeColumnValue")]
		public string TypeColumnValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleEntity:SysModuleEntityId")]
		public SysModuleEntity SysModuleEntity { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
