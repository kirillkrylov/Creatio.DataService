using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleGrid")]
	public class SysModuleGrid : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HasAllItemsView")]
		public bool HasAllItemsView { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId { get; set; }
		[CProperty(ColumnPath ="SysPageSchemaUId")]
		public Guid SysPageSchemaUId { get; set; }
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
		[CProperty(Association ="SysModuleDetail:SysModuleGridId")]
		public virtual ICollection<SysModuleDetail> SysModuleDetailBySysModuleGrid { get; set; }
		[CProperty(Association ="SysModuleEditDetail:SysModuleGridId")]
		public virtual ICollection<SysModuleEditDetail> SysModuleEditDetailBySysModuleGrid { get; set; }
		[CProperty(Association ="SysModuleGridView:SysModuleGridId")]
		public virtual ICollection<SysModuleGridView> SysModuleGridViewBySysModuleGrid { get; set; }
		[CProperty(Association ="SysModulePrimaryGrid:SysModuleGridId")]
		public virtual ICollection<SysModulePrimaryGrid> SysModulePrimaryGridBySysModuleGrid { get; set; }
		#endregion
	}
}
