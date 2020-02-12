using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleFolder")]
	public class SysModuleFolder : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Image")]
		public byte[] Image { get; set; }
		[CProperty(ColumnPath ="Location")]
		public string Location { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="City:ParentId")]
		public City Parent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmPreferences:BpmObjectId")]
		public virtual ICollection<BpmPreferences> BpmPreferencesByBpmObject { get; set; }
		[CProperty(Association ="SysModuleFolderLczOld:RecordId")]
		public virtual ICollection<SysModuleFolderLczOld> SysModuleFolderLczOldByRecord { get; set; }
		[CProperty(Association ="SysModuleInSysModuleFolder:SubSysModuleFolderId")]
		public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderBySubSysModuleFolder { get; set; }
		[CProperty(Association ="SysModuleInSysModuleFolder:SysModuleFolderId")]
		public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderBySysModuleFolder { get; set; }
		#endregion
	}
}
