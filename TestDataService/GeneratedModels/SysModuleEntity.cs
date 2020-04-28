using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleEntity")]
	public class SysModuleEntity : BaseEntity
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
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="TypeColumnUId")]
		public Guid TypeColumnUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ERROR")]
		public virtual ICollection<Portal_SysModule> PortalBySysModuleBySysModuleEntity { get; set; }
		[CProperty(Association ="SysDcmSettings:SysModuleEntityId")]
		public virtual ICollection<SysDcmSettings> SysDcmSettingsBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModule:SysModuleEntityId")]
		public virtual ICollection<SysModule> SysModuleBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleDcmSettings:SysModuleEntityId")]
		public virtual ICollection<SysModuleDcmSettings> SysModuleDcmSettingsBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleEdit:SysModuleEntityId")]
		public virtual ICollection<SysModuleEdit> SysModuleEditBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleEntityInPortal:SysModuleEntityId")]
		public virtual ICollection<SysModuleEntityInPortal> SysModuleEntityInPortalBySysModuleEntity { get; set; }
		[CProperty(Association ="SysModuleGrid:SysModuleEntityId")]
		public virtual ICollection<SysModuleGrid> SysModuleGridBySysModuleEntity { get; set; }
		[CProperty(Association ="VwSysModuleEdit:SysModuleEntityId")]
		public virtual ICollection<VwSysModuleEdit> VwSysModuleEditBySysModuleEntity { get; set; }
		[CProperty(Association ="VwSysModuleSchemaEdit:SysModuleEntityId")]
		public virtual ICollection<VwSysModuleSchemaEdit> VwSysModuleSchemaEditBySysModuleEntity { get; set; }
		#endregion
	}
}
