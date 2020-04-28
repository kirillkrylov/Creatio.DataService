using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysDcmSettings")]
	public class SysDcmSettings : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DefaultSchemaUId")]
		public Guid DefaultSchemaUId { get; set; }
		[CProperty(ColumnPath ="Filters")]
		public string Filters { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StageColumnUId")]
		public Guid StageColumnUId { get; set; }
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId { get; set; }
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
		[CProperty(Association ="SysDcmSchemaInSettings:SysDcmSettingsId")]
		public virtual ICollection<SysDcmSchemaInSettings> SysDcmSchemaInSettingsBySysDcmSettings { get; set; }
		#endregion
	}
}
