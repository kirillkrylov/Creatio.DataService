using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModule")]
	public class SysModule : BaseEntity
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
		public Guid Id { get; set; }
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
		[CProperty(Navigation ="SysImage:Image32Id")]
		public SysImage Image32 { get; set; }
		[CProperty(Navigation ="SysImage:LogoId")]
		public SysImage Logo { get; set; }
		[CProperty(Navigation ="SysModuleEntity:SysModuleEntityId")]
		public SysModuleEntity SysModuleEntity { get; set; }
		[CProperty(Navigation ="SysModuleFolderMode:FolderModeId")]
		public SysModuleFolderMode FolderMode { get; set; }
		[CProperty(Navigation ="SysModuleVisa:SysModuleVisaId")]
		public SysModuleVisa SysModuleVisa { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DefaultReport:SysModuleId")]
		public virtual ICollection<DefaultReport> DefaultReportBySysModule { get; set; }
		[CProperty(Association ="MessageNotifierBySection:SectionId")]
		public virtual ICollection<MessageNotifierBySection> MessageNotifierBySectionBySection { get; set; }
		[CProperty(Association ="MessagePublisherBySection:SectionId")]
		public virtual ICollection<MessagePublisherBySection> MessagePublisherBySectionBySection { get; set; }
		[CProperty(Association ="ProcessInModules:SysModuleId")]
		public virtual ICollection<ProcessInModules> ProcessInModulesBySysModule { get; set; }
		[CProperty(Association ="PtGanttSetting:SectionId")]
		public virtual ICollection<PtGanttSetting> PtGanttSettingBySection { get; set; }
		[CProperty(Association ="SysAdminUnit:HomePageId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByHomePage { get; set; }
		[CProperty(Association ="SysDashboard:SectionId")]
		public virtual ICollection<SysDashboard> SysDashboardBySection { get; set; }
		[CProperty(Association ="SysModuleAction:SysModuleId")]
		public virtual ICollection<SysModuleAction> SysModuleActionBySysModule { get; set; }
		[CProperty(Association ="SysModuleAnalyticsReport:SysModuleId")]
		public virtual ICollection<SysModuleAnalyticsReport> SysModuleAnalyticsReportBySysModule { get; set; }
		[CProperty(Association ="SysModuleDetail:SysModuleId")]
		public virtual ICollection<SysModuleDetail> SysModuleDetailBySysModule { get; set; }
		[CProperty(Association ="SysModuleInSysModuleFolder:SysModuleId")]
		public virtual ICollection<SysModuleInSysModuleFolder> SysModuleInSysModuleFolderBySysModule { get; set; }
		[CProperty(Association ="SysModuleInWorkplace:SysModuleId")]
		public virtual ICollection<SysModuleInWorkplace> SysModuleInWorkplaceBySysModule { get; set; }
		[CProperty(Association ="SysModuleLczOld:RecordId")]
		public virtual ICollection<SysModuleLczOld> SysModuleLczOldByRecord { get; set; }
		[CProperty(Association ="SysModulePrimaryGrid:SysModuleId")]
		public virtual ICollection<SysModulePrimaryGrid> SysModulePrimaryGridBySysModule { get; set; }
		[CProperty(Association ="SysModuleReport:SysModuleId")]
		public virtual ICollection<SysModuleReport> SysModuleReportBySysModule { get; set; }
		[CProperty(Association ="SysWidgetDashboard:SectionId")]
		public virtual ICollection<SysWidgetDashboard> SysWidgetDashboardBySection { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:HomePageId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByHomePage { get; set; }
		[CProperty(Association ="VwSysAdminUnit:HomePageId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByHomePage { get; set; }
		#endregion
	}
}
