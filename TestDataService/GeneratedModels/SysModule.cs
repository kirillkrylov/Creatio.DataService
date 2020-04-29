using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModule")]
	public class SysModule : BaseEntity
	{
		#region Values
		private string _Attribute;
		[CProperty(ColumnPath ="Attribute")]
		public string Attribute
		{
			get{return _Attribute;}
			set
			{
				_Attribute = value;
				OnPropertyChanged();
			}
		}
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
				OnPropertyChanged();
			}
		}
		private Guid _CardModuleUId;
		[CProperty(ColumnPath ="CardModuleUId")]
		public Guid CardModuleUId
		{
			get{return _CardModuleUId;}
			set
			{
				_CardModuleUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CardSchemaUId;
		[CProperty(ColumnPath ="CardSchemaUId")]
		public Guid CardSchemaUId
		{
			get{return _CardSchemaUId;}
			set
			{
				_CardSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _FolderModeId;
		[CProperty(ColumnPath ="FolderModeId")]
		public Guid FolderModeId
		{
			get{return _FolderModeId;}
			set
			{
				_FolderModeId = value;
				OnPropertyChanged();
			}
		}
		private bool _GlobalSearchAvailable;
		[CProperty(ColumnPath ="GlobalSearchAvailable")]
		public bool GlobalSearchAvailable
		{
			get{return _GlobalSearchAvailable;}
			set
			{
				_GlobalSearchAvailable = value;
				OnPropertyChanged();
			}
		}
		private bool _HasActions;
		[CProperty(ColumnPath ="HasActions")]
		public bool HasActions
		{
			get{return _HasActions;}
			set
			{
				_HasActions = value;
				OnPropertyChanged();
			}
		}
		private bool _HasAnalytics;
		[CProperty(ColumnPath ="HasAnalytics")]
		public bool HasAnalytics
		{
			get{return _HasAnalytics;}
			set
			{
				_HasAnalytics = value;
				OnPropertyChanged();
			}
		}
		private bool _HasRecent;
		[CProperty(ColumnPath ="HasRecent")]
		public bool HasRecent
		{
			get{return _HasRecent;}
			set
			{
				_HasRecent = value;
				OnPropertyChanged();
			}
		}
		private string _HelpContextId;
		[CProperty(ColumnPath ="HelpContextId")]
		public string HelpContextId
		{
			get{return _HelpContextId;}
			set
			{
				_HelpContextId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private byte[] _Image16;
		[CProperty(ColumnPath ="Image16")]
		public byte[] Image16
		{
			get{return _Image16;}
			set
			{
				_Image16 = value;
				OnPropertyChanged();
			}
		}
		private byte[] _Image20;
		[CProperty(ColumnPath ="Image20")]
		public byte[] Image20
		{
			get{return _Image20;}
			set
			{
				_Image20 = value;
				OnPropertyChanged();
			}
		}
		private Guid _Image32Id;
		[CProperty(ColumnPath ="Image32Id")]
		public Guid Image32Id
		{
			get{return _Image32Id;}
			set
			{
				_Image32Id = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSystem;
		[CProperty(ColumnPath ="IsSystem")]
		public bool IsSystem
		{
			get{return _IsSystem;}
			set
			{
				_IsSystem = value;
				OnPropertyChanged();
			}
		}
		private Guid _LogoId;
		[CProperty(ColumnPath ="LogoId")]
		public Guid LogoId
		{
			get{return _LogoId;}
			set
			{
				_LogoId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _ModuleHeader;
		[CProperty(ColumnPath ="ModuleHeader")]
		public string ModuleHeader
		{
			get{return _ModuleHeader;}
			set
			{
				_ModuleHeader = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _SectionModuleSchemaUId;
		[CProperty(ColumnPath ="SectionModuleSchemaUId")]
		public Guid SectionModuleSchemaUId
		{
			get{return _SectionModuleSchemaUId;}
			set
			{
				_SectionModuleSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SectionSchemaUId;
		[CProperty(ColumnPath ="SectionSchemaUId")]
		public Guid SectionSchemaUId
		{
			get{return _SectionSchemaUId;}
			set
			{
				_SectionSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleEntityId;
		[CProperty(ColumnPath ="SysModuleEntityId")]
		public Guid SysModuleEntityId
		{
			get{return _SysModuleEntityId;}
			set
			{
				_SysModuleEntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysModuleVisaId;
		[CProperty(ColumnPath ="SysModuleVisaId")]
		public Guid SysModuleVisaId
		{
			get{return _SysModuleVisaId;}
			set
			{
				_SysModuleVisaId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysPageSchemaUId;
		[CProperty(ColumnPath ="SysPageSchemaUId")]
		public Guid SysPageSchemaUId
		{
			get{return _SysPageSchemaUId;}
			set
			{
				_SysPageSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private int _Type;
		[CProperty(ColumnPath ="Type")]
		public int Type
		{
			get{return _Type;}
			set
			{
				_Type = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeColumnValue;
		[CProperty(ColumnPath ="TypeColumnValue")]
		public Guid TypeColumnValue
		{
			get{return _TypeColumnValue;}
			set
			{
				_TypeColumnValue = value;
				OnPropertyChanged();
			}
		}
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
