using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Portal_SysModule")]
	public class Portal_SysModule : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Attribute")]
		public string Attribute { get; set; }
		[CProperty(ColumnPath ="Caption")]
		public string Caption { get; set; }
		[CProperty(ColumnPath ="CardModuleUId")]
		public Guid CardModuleUId { get; set; }
		[CProperty(ColumnPath ="CardSchemaUId")]
		public Guid CardSchemaUId { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FolderModeId")]
		public Guid FolderModeId { get; set; }
		[CProperty(ColumnPath ="GlobalSearchAvailable")]
		public bool GlobalSearchAvailable { get; set; }
		[CProperty(ColumnPath ="HasActions")]
		public bool HasActions { get; set; }
		[CProperty(ColumnPath ="HasAnalytics")]
		public bool HasAnalytics { get; set; }
		[CProperty(ColumnPath ="HasRecent")]
		public bool HasRecent { get; set; }
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="Image16")]
		public byte[] Image16 { get; set; }
		[CProperty(ColumnPath ="Image20")]
		public byte[] Image20 { get; set; }
		[CProperty(ColumnPath ="Image32Id")]
		public Guid Image32Id { get; set; }
		[CProperty(ColumnPath ="IsSystem")]
		public bool IsSystem { get; set; }
		[CProperty(ColumnPath ="LogoId")]
		public Guid LogoId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ModuleHeader")]
		public string ModuleHeader { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SectionModuleSchemaUId")]
		public Guid SectionModuleSchemaUId { get; set; }
		[CProperty(ColumnPath ="SectionSchemaUId")]
		public Guid SectionSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId { get; set; }
		[CProperty(ColumnPath ="SysModuleVisaId")]
		public Guid SysModuleVisaId { get; set; }
		[CProperty(ColumnPath ="SysPageSchemaUId")]
		public Guid SysPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="Type")]
		public int Type { get; set; }
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ERROR")]
		public SysImage Image32 { get; set; }
		[CProperty(Navigation ="ERROR")]
		public SysImage Logo { get; set; }
		[CProperty(Navigation ="ERROR")]
		public SysModuleEntity SysModuleEntity { get; set; }
		[CProperty(Navigation ="ERROR")]
		public SysModuleFolderMode FolderMode { get; set; }
		[CProperty(Navigation ="ERROR")]
		public SysModuleVisa SysModuleVisa { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
