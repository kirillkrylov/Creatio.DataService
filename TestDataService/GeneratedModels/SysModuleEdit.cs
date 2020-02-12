using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleEdit")]
	public class SysModuleEdit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActionKindCaption")]
		public string ActionKindCaption { get; set; }
		[CProperty(ColumnPath ="ActionKindName")]
		public string ActionKindName { get; set; }
		[CProperty(ColumnPath ="CardSchemaUId")]
		public Guid CardSchemaUId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MiniPageModes")]
		public string MiniPageModes { get; set; }
		[CProperty(ColumnPath ="MiniPageSchemaUId")]
		public Guid MiniPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PageCaption")]
		public string PageCaption { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SearchRowSchemaUId")]
		public Guid SearchRowSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId { get; set; }
		[CProperty(ColumnPath ="SysPageSchemaUId")]
		public Guid SysPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue { get; set; }
		[CProperty(ColumnPath ="UseModuleDetails")]
		public bool UseModuleDetails { get; set; }
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
		[CProperty(Association ="QuickAddMenuItem:SysModuleEditId")]
		public virtual ICollection<QuickAddMenuItem> QuickAddMenuItemBySysModuleEdit { get; set; }
		[CProperty(Association ="SupPreCreatePageSetting:SupEntitySchemaEditPageId")]
		public virtual ICollection<SupPreCreatePageSetting> SupPreCreatePageSettingBySupEntitySchemaEditPage { get; set; }
		[CProperty(Association ="SysModuleEditDetail:SysModuleEditId")]
		public virtual ICollection<SysModuleEditDetail> SysModuleEditDetailBySysModuleEdit { get; set; }
		[CProperty(Association ="SysModuleEditLczOld:RecordId")]
		public virtual ICollection<SysModuleEditLczOld> SysModuleEditLczOldByRecord { get; set; }
		#endregion
	}
}
