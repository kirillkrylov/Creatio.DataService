using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleEditDetail")]
	public class SysModuleEditDetail : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId { get; set; }
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
		[CProperty(ColumnPath ="SysModuleEditId")]
		public Guid SysModuleEditId { get; set; }
		[CProperty(ColumnPath ="SysModuleGridId")]
		public Guid SysModuleGridId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysModuleEdit:SysModuleEditId")]
		public SysModuleEdit SysModuleEdit { get; set; }
		[CProperty(Navigation ="SysModuleGrid:SysModuleGridId")]
		public SysModuleGrid SysModuleGrid { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysModuleEditDetailParentAssc:SysModuleEditDetailId")]
		public virtual ICollection<SysModuleEditDetailParentAssc> SysModuleEditDetailParentAsscBySysModuleEditDetail { get; set; }
		#endregion
	}
}
