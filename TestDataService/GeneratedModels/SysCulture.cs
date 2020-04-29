using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysCulture")]
	public class SysCulture : BaseEntity
	{
		#region Values
		private bool _Active;
		[CProperty(ColumnPath ="Active")]
		public bool Active
		{
			get{return _Active;}
			set
			{
				_Active = value;
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
		private bool _Default;
		[CProperty(ColumnPath ="Default")]
		public bool Default
		{
			get{return _Default;}
			set
			{
				_Default = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private Guid _ImageId;
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId
		{
			get{return _ImageId;}
			set
			{
				_ImageId = value;
				OnPropertyChanged();
			}
		}
		private int _Index;
		[CProperty(ColumnPath ="Index")]
		public int Index
		{
			get{return _Index;}
			set
			{
				_Index = value;
				OnPropertyChanged();
			}
		}
		private Guid _LanguageId;
		[CProperty(ColumnPath ="LanguageId")]
		public Guid LanguageId
		{
			get{return _LanguageId;}
			set
			{
				_LanguageId = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		[CProperty(Navigation ="SysLanguage:LanguageId")]
		public SysLanguage Language { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="DefaultReport:CultureId")]
		public virtual ICollection<DefaultReport> DefaultReportByCulture { get; set; }
		[CProperty(Association ="MainParamLczOld:SysCultureId")]
		public virtual ICollection<MainParamLczOld> MainParamLczOldBySysCulture { get; set; }
		[CProperty(Association ="OpportunityTerritory:CultureId")]
		public virtual ICollection<OpportunityTerritory> OpportunityTerritoryByCulture { get; set; }
		[CProperty(Association ="SupCommunityPostAddress:SupCultureId")]
		public virtual ICollection<SupCommunityPostAddress> SupCommunityPostAddressBySupCulture { get; set; }
		[CProperty(Association ="SysAdminUnit:SysCultureId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitBySysCulture { get; set; }
		[CProperty(Association ="SysClientUnitSchemaSource:SysCultureId")]
		public virtual ICollection<SysClientUnitSchemaSource> SysClientUnitSchemaSourceBySysCulture { get; set; }
		[CProperty(Association ="SysLocalizableValue:SysCultureId")]
		public virtual ICollection<SysLocalizableValue> SysLocalizableValueBySysCulture { get; set; }
		[CProperty(Association ="SysModuleActionLczOld:SysCultureId")]
		public virtual ICollection<SysModuleActionLczOld> SysModuleActionLczOldBySysCulture { get; set; }
		[CProperty(Association ="SysModuleAnalyticsReportLczOld:SysCultureId")]
		public virtual ICollection<SysModuleAnalyticsReportLczOld> SysModuleAnalyticsReportLczOldBySysCulture { get; set; }
		[CProperty(Association ="SysModuleDetailLczOld:SysCultureId")]
		public virtual ICollection<SysModuleDetailLczOld> SysModuleDetailLczOldBySysCulture { get; set; }
		[CProperty(Association ="SysModuleEditLczOld:SysCultureId")]
		public virtual ICollection<SysModuleEditLczOld> SysModuleEditLczOldBySysCulture { get; set; }
		[CProperty(Association ="SysModuleFolderLczOld:SysCultureId")]
		public virtual ICollection<SysModuleFolderLczOld> SysModuleFolderLczOldBySysCulture { get; set; }
		[CProperty(Association ="SysModuleLczOld:SysCultureId")]
		public virtual ICollection<SysModuleLczOld> SysModuleLczOldBySysCulture { get; set; }
		[CProperty(Association ="SysModuleReportLczOld:SysCultureId")]
		public virtual ICollection<SysModuleReportLczOld> SysModuleReportLczOldBySysCulture { get; set; }
		[CProperty(Association ="SysPackageDataLcz:SysCultureId")]
		public virtual ICollection<SysPackageDataLcz> SysPackageDataLczBySysCulture { get; set; }
		[CProperty(Association ="SysPackageResourceChecksum:SysCultureId")]
		public virtual ICollection<SysPackageResourceChecksum> SysPackageResourceChecksumBySysCulture { get; set; }
		[CProperty(Association ="SysProfileData:SysCultureId")]
		public virtual ICollection<SysProfileData> SysProfileDataBySysCulture { get; set; }
		[CProperty(Association ="TsMailNotificationValue:CultureId")]
		public virtual ICollection<TsMailNotificationValue> TsMailNotificationValueByCulture { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:SysCultureId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitBySysCulture { get; set; }
		[CProperty(Association ="VwSspAdminUnit:SysCultureId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitBySysCulture { get; set; }
		[CProperty(Association ="VwSysAdminUnit:SysCultureId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitBySysCulture { get; set; }
		#endregion
	}
}
