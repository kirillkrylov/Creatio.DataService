using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ConfItem")]
	public class ConfItem : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private string _Address;
		[CProperty(ColumnPath ="Address")]
		public string Address
		{
			get{return _Address;}
			set
			{
				_Address = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineBuildDBMSId;
		[CProperty(ColumnPath ="BpmonlineBuildDBMSId")]
		public Guid BpmonlineBuildDBMSId
		{
			get{return _BpmonlineBuildDBMSId;}
			set
			{
				_BpmonlineBuildDBMSId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineBuildId;
		[CProperty(ColumnPath ="BpmonlineBuildId")]
		public Guid BpmonlineBuildId
		{
			get{return _BpmonlineBuildId;}
			set
			{
				_BpmonlineBuildId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineLczId;
		[CProperty(ColumnPath ="BpmonlineLczId")]
		public Guid BpmonlineLczId
		{
			get{return _BpmonlineLczId;}
			set
			{
				_BpmonlineLczId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineProductId;
		[CProperty(ColumnPath ="BpmonlineProductId")]
		public Guid BpmonlineProductId
		{
			get{return _BpmonlineProductId;}
			set
			{
				_BpmonlineProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmonlineVersionId;
		[CProperty(ColumnPath ="BpmonlineVersionId")]
		public Guid BpmonlineVersionId
		{
			get{return _BpmonlineVersionId;}
			set
			{
				_BpmonlineVersionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BPMPkgId;
		[CProperty(ColumnPath ="BPMPkgId")]
		public Guid BPMPkgId
		{
			get{return _BPMPkgId;}
			set
			{
				_BPMPkgId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CancelDate;
		[CProperty(ColumnPath ="CancelDate")]
		public DateTime CancelDate
		{
			get{return _CancelDate;}
			set
			{
				_CancelDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CityId;
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId
		{
			get{return _CityId;}
			set
			{
				_CityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private int _ContactsCount;
		[CProperty(ColumnPath ="ContactsCount")]
		public int ContactsCount
		{
			get{return _ContactsCount;}
			set
			{
				_ContactsCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _CountryId;
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId
		{
			get{return _CountryId;}
			set
			{
				_CountryId = value;
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
		private string _CustomerID;
		[CProperty(ColumnPath ="CustomerID")]
		public string CustomerID
		{
			get{return _CustomerID;}
			set
			{
				_CustomerID = value;
				OnPropertyChanged();
			}
		}
		private int _DBSizeMB;
		[CProperty(ColumnPath ="DBSizeMB")]
		public int DBSizeMB
		{
			get{return _DBSizeMB;}
			set
			{
				_DBSizeMB = value;
				OnPropertyChanged();
			}
		}
		private string _Domain;
		[CProperty(ColumnPath ="Domain")]
		public string Domain
		{
			get{return _Domain;}
			set
			{
				_Domain = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
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
		private string _InventoryNumber;
		[CProperty(ColumnPath ="InventoryNumber")]
		public string InventoryNumber
		{
			get{return _InventoryNumber;}
			set
			{
				_InventoryNumber = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastSessionEndDate;
		[CProperty(ColumnPath ="LastSessionEndDate")]
		public DateTime LastSessionEndDate
		{
			get{return _LastSessionEndDate;}
			set
			{
				_LastSessionEndDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LastSessionStartDate;
		[CProperty(ColumnPath ="LastSessionStartDate")]
		public DateTime LastSessionStartDate
		{
			get{return _LastSessionStartDate;}
			set
			{
				_LastSessionStartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LicenseDueDate;
		[CProperty(ColumnPath ="LicenseDueDate")]
		public DateTime LicenseDueDate
		{
			get{return _LicenseDueDate;}
			set
			{
				_LicenseDueDate = value;
				OnPropertyChanged();
			}
		}
		private string _MandrillAPIKey;
		[CProperty(ColumnPath ="MandrillAPIKey")]
		public string MandrillAPIKey
		{
			get{return _MandrillAPIKey;}
			set
			{
				_MandrillAPIKey = value;
				OnPropertyChanged();
			}
		}
		private Guid _MandrillAPIKeyStateId;
		[CProperty(ColumnPath ="MandrillAPIKeyStateId")]
		public Guid MandrillAPIKeyStateId
		{
			get{return _MandrillAPIKeyStateId;}
			set
			{
				_MandrillAPIKeyStateId = value;
				OnPropertyChanged();
			}
		}
		private string _MandrillUserName;
		[CProperty(ColumnPath ="MandrillUserName")]
		public string MandrillUserName
		{
			get{return _MandrillUserName;}
			set
			{
				_MandrillUserName = value;
				OnPropertyChanged();
			}
		}
		private string _MandrillUserPassword;
		[CProperty(ColumnPath ="MandrillUserPassword")]
		public string MandrillUserPassword
		{
			get{return _MandrillUserPassword;}
			set
			{
				_MandrillUserPassword = value;
				OnPropertyChanged();
			}
		}
		private int _MaxSiteCount;
		[CProperty(ColumnPath ="MaxSiteCount")]
		public int MaxSiteCount
		{
			get{return _MaxSiteCount;}
			set
			{
				_MaxSiteCount = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModelId;
		[CProperty(ColumnPath ="ModelId")]
		public Guid ModelId
		{
			get{return _ModelId;}
			set
			{
				_ModelId = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentConfItemId;
		[CProperty(ColumnPath ="ParentConfItemId")]
		public Guid ParentConfItemId
		{
			get{return _ParentConfItemId;}
			set
			{
				_ParentConfItemId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerAccountId;
		[CProperty(ColumnPath ="PartnerAccountId")]
		public Guid PartnerAccountId
		{
			get{return _PartnerAccountId;}
			set
			{
				_PartnerAccountId = value;
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
		private DateTime _PurchaseDate;
		[CProperty(ColumnPath ="PurchaseDate")]
		public DateTime PurchaseDate
		{
			get{return _PurchaseDate;}
			set
			{
				_PurchaseDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _RegionId;
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId
		{
			get{return _RegionId;}
			set
			{
				_RegionId = value;
				OnPropertyChanged();
			}
		}
		private string _SerialNumber;
		[CProperty(ColumnPath ="SerialNumber")]
		public string SerialNumber
		{
			get{return _SerialNumber;}
			set
			{
				_SerialNumber = value;
				OnPropertyChanged();
			}
		}
		private int _ServerBlockNumber;
		[CProperty(ColumnPath ="ServerBlockNumber")]
		public int ServerBlockNumber
		{
			get{return _ServerBlockNumber;}
			set
			{
				_ServerBlockNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServerBlockTypeId;
		[CProperty(ColumnPath ="ServerBlockTypeId")]
		public Guid ServerBlockTypeId
		{
			get{return _ServerBlockTypeId;}
			set
			{
				_ServerBlockTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SiteId;
		[CProperty(ColumnPath ="SiteId")]
		public Guid SiteId
		{
			get{return _SiteId;}
			set
			{
				_SiteId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SitePurposeId;
		[CProperty(ColumnPath ="SitePurposeId")]
		public Guid SitePurposeId
		{
			get{return _SitePurposeId;}
			set
			{
				_SitePurposeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private string _Street;
		[CProperty(ColumnPath ="Street")]
		public string Street
		{
			get{return _Street;}
			set
			{
				_Street = value;
				OnPropertyChanged();
			}
		}
		private Guid _SubscriptionId;
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId
		{
			get{return _SubscriptionId;}
			set
			{
				_SubscriptionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _UpdateDate;
		[CProperty(ColumnPath ="UpdateDate")]
		public DateTime UpdateDate
		{
			get{return _UpdateDate;}
			set
			{
				_UpdateDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _UpdateResultId;
		[CProperty(ColumnPath ="UpdateResultId")]
		public Guid UpdateResultId
		{
			get{return _UpdateResultId;}
			set
			{
				_UpdateResultId = value;
				OnPropertyChanged();
			}
		}
		private Guid _UpdateStatusId;
		[CProperty(ColumnPath ="UpdateStatusId")]
		public Guid UpdateStatusId
		{
			get{return _UpdateStatusId;}
			set
			{
				_UpdateStatusId = value;
				OnPropertyChanged();
			}
		}
		private int _UpdatingSlots;
		[CProperty(ColumnPath ="UpdatingSlots")]
		public int UpdatingSlots
		{
			get{return _UpdatingSlots;}
			set
			{
				_UpdatingSlots = value;
				OnPropertyChanged();
			}
		}
		private int _UsersCount;
		[CProperty(ColumnPath ="UsersCount")]
		public int UsersCount
		{
			get{return _UsersCount;}
			set
			{
				_UsersCount = value;
				OnPropertyChanged();
			}
		}
		private string _Violation;
		[CProperty(ColumnPath ="Violation")]
		public string Violation
		{
			get{return _Violation;}
			set
			{
				_Violation = value;
				OnPropertyChanged();
			}
		}
		private Guid _VirtualizationTypeId;
		[CProperty(ColumnPath ="VirtualizationTypeId")]
		public Guid VirtualizationTypeId
		{
			get{return _VirtualizationTypeId;}
			set
			{
				_VirtualizationTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _WarrantyUntil;
		[CProperty(ColumnPath ="WarrantyUntil")]
		public DateTime WarrantyUntil
		{
			get{return _WarrantyUntil;}
			set
			{
				_WarrantyUntil = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:PartnerAccountId")]
		public Account PartnerAccount { get; set; }
		[CProperty(Navigation ="BpmonlineBuild:BpmonlineBuildId")]
		public BpmonlineBuild BpmonlineBuild { get; set; }
		[CProperty(Navigation ="BpmonlineBuildDBMS:BpmonlineBuildDBMSId")]
		public BpmonlineBuildDBMS BpmonlineBuildDBMS { get; set; }
		[CProperty(Navigation ="BpmonlineLcz:BpmonlineLczId")]
		public BpmonlineLcz BpmonlineLcz { get; set; }
		[CProperty(Navigation ="BpmonlineProduct:BpmonlineProductId")]
		public BpmonlineProduct BpmonlineProduct { get; set; }
		[CProperty(Navigation ="BpmonlineVersion:BpmonlineVersionId")]
		public BpmonlineVersion BpmonlineVersion { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation ="ConfigItemCategory:CategoryId")]
		public ConfigItemCategory Category { get; set; }
		[CProperty(Navigation ="ConfigItemModel:ModelId")]
		public ConfigItemModel Model { get; set; }
		[CProperty(Navigation ="ConfigItemStatus:StatusId")]
		public ConfigItemStatus Status { get; set; }
		[CProperty(Navigation ="ConfigItemType:TypeId")]
		public ConfigItemType Type { get; set; }
		[CProperty(Navigation ="ConfItem:ParentConfItemId")]
		public ConfItem ParentConfItem { get; set; }
		[CProperty(Navigation ="ConfItem:BPMPkgId")]
		public ConfItem BPMPkg { get; set; }
		[CProperty(Navigation ="ConfItem:SiteId")]
		public ConfItem Site { get; set; }
		[CProperty(Navigation ="ConfItemUpdateResult:UpdateResultId")]
		public ConfItemUpdateResult UpdateResult { get; set; }
		[CProperty(Navigation ="ConfItemUpdateStatus:UpdateStatusId")]
		public ConfItemUpdateStatus UpdateStatus { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="MandrillAPIKeyState:MandrillAPIKeyStateId")]
		public MandrillAPIKeyState MandrillAPIKeyState { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="ServerBlockType:ServerBlockTypeId")]
		public ServerBlockType ServerBlockType { get; set; }
		[CProperty(Navigation ="SitePurpose:SitePurposeId")]
		public SitePurpose SitePurpose { get; set; }
		[CProperty(Navigation ="Subscription:SubscriptionId")]
		public Subscription Subscription { get; set; }
		[CProperty(Navigation ="VirtualizationType:VirtualizationTypeId")]
		public VirtualizationType VirtualizationType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ActiveSiteLocalization:ConfItemId")]
		public virtual ICollection<ActiveSiteLocalization> ActiveSiteLocalizationByConfItem { get; set; }
		[CProperty(Association ="Activity:ConfItemId")]
		public virtual ICollection<Activity> ActivityByConfItem { get; set; }
		[CProperty(Association ="BPMPkgLocation:BPMPkgId")]
		public virtual ICollection<BPMPkgLocation> BPMPkgLocationByBPMPkg { get; set; }
		[CProperty(Association ="BPMPkgLocation:DataCenterId")]
		public virtual ICollection<BPMPkgLocation> BPMPkgLocationByDataCenter { get; set; }
		[CProperty(Association ="Case:ConfItemId")]
		public virtual ICollection<Case> CaseByConfItem { get; set; }
		[CProperty(Association ="ChangeConfItem:ConfItemId")]
		public virtual ICollection<ChangeConfItem> ChangeConfItemByConfItem { get; set; }
		[CProperty(Association ="ConfigItemAddValue:ConfItemId")]
		public virtual ICollection<ConfigItemAddValue> ConfigItemAddValueByConfItem { get; set; }
		[CProperty(Association ="ConfItem:ParentConfItemId")]
		public virtual ICollection<ConfItem> ConfItemByParentConfItem { get; set; }
		[CProperty(Association ="ConfItem:BPMPkgId")]
		public virtual ICollection<ConfItem> ConfItemByBPMPkg { get; set; }
		[CProperty(Association ="ConfItem:SiteId")]
		public virtual ICollection<ConfItem> ConfItemBySite { get; set; }
		[CProperty(Association ="ConfItemAddress:ConfItemId")]
		public virtual ICollection<ConfItemAddress> ConfItemAddressByConfItem { get; set; }
		[CProperty(Association ="ConfItemFile:ConfItemId")]
		public virtual ICollection<ConfItemFile> ConfItemFileByConfItem { get; set; }
		[CProperty(Association ="ConfItemInCase:ConfItemId")]
		public virtual ICollection<ConfItemInCase> ConfItemInCaseByConfItem { get; set; }
		[CProperty(Association ="ConfItemInFolder:ConfItemId")]
		public virtual ICollection<ConfItemInFolder> ConfItemInFolderByConfItem { get; set; }
		[CProperty(Association ="ConfItemInTag:EntityId")]
		public virtual ICollection<ConfItemInTag> ConfItemInTagByEntity { get; set; }
		[CProperty(Association ="ConfItemRelationship:ConfItemAId")]
		public virtual ICollection<ConfItemRelationship> ConfItemRelationshipByConfItemA { get; set; }
		[CProperty(Association ="ConfItemRelationship:ConfItemBId")]
		public virtual ICollection<ConfItemRelationship> ConfItemRelationshipByConfItemB { get; set; }
		[CProperty(Association ="ConfItemUpdateHistory:ConfItemId")]
		public virtual ICollection<ConfItemUpdateHistory> ConfItemUpdateHistoryByConfItem { get; set; }
		[CProperty(Association ="ConfItemUser:ConfItemId")]
		public virtual ICollection<ConfItemUser> ConfItemUserByConfItem { get; set; }
		[CProperty(Association ="InternalRequest:ConfItemId")]
		public virtual ICollection<InternalRequest> InternalRequestByConfItem { get; set; }
		[CProperty(Association ="Problem:ConfItemId")]
		public virtual ICollection<Problem> ProblemByConfItem { get; set; }
		[CProperty(Association ="ProductForLicGenerator:ConfItemId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByConfItem { get; set; }
		[CProperty(Association ="ProductInSubscription:ConfItemId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByConfItem { get; set; }
		[CProperty(Association ="Release:BPMInstallationPackageId")]
		public virtual ICollection<Release> ReleaseByBPMInstallationPackage { get; set; }
		[CProperty(Association ="ReleaseConfItem:ConfItemId")]
		public virtual ICollection<ReleaseConfItem> ReleaseConfItemByConfItem { get; set; }
		[CProperty(Association ="ServiceInConfItem:ConfItemId")]
		public virtual ICollection<ServiceInConfItem> ServiceInConfItemByConfItem { get; set; }
		[CProperty(Association ="SiteChangedSchema:SiteId")]
		public virtual ICollection<SiteChangedSchema> SiteChangedSchemaBySite { get; set; }
		[CProperty(Association ="SiteReplacedModules:ConfItemId")]
		public virtual ICollection<SiteReplacedModules> SiteReplacedModulesByConfItem { get; set; }
		[CProperty(Association ="SiteStat:SiteId")]
		public virtual ICollection<SiteStat> SiteStatBySite { get; set; }
		[CProperty(Association ="SiteTechnologicalPeriod:ConfItemId")]
		public virtual ICollection<SiteTechnologicalPeriod> SiteTechnologicalPeriodByConfItem { get; set; }
		[CProperty(Association ="SiteUserSession:ConfItemId")]
		public virtual ICollection<SiteUserSession> SiteUserSessionByConfItem { get; set; }
		[CProperty(Association ="SupAccessToClient:SupConfItemId")]
		public virtual ICollection<SupAccessToClient> SupAccessToClientBySupConfItem { get; set; }
		[CProperty(Association ="VwConfItemRelationship:ConfItemAId")]
		public virtual ICollection<VwConfItemRelationship> VwConfItemRelationshipByConfItemA { get; set; }
		[CProperty(Association ="VwConfItemRelationship:ConfItemBId")]
		public virtual ICollection<VwConfItemRelationship> VwConfItemRelationshipByConfItemB { get; set; }
		[CProperty(Association ="VwServiceInConfItem:ConfItemId")]
		public virtual ICollection<VwServiceInConfItem> VwServiceInConfItemByConfItem { get; set; }
		[CProperty(Association ="VwSiteStatActiveUsrPrc:SiteStatId")]
		public virtual ICollection<VwSiteStatActiveUsrPrc> VwSiteStatActiveUsrPrcBySiteStat { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsage:ConfItemId")]
		public virtual ICollection<VwSiteStatModuleUsage> VwSiteStatModuleUsageByConfItem { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsageHistory:ConfItemId")]
		public virtual ICollection<VwSiteStatModuleUsageHistory> VwSiteStatModuleUsageHistoryByConfItem { get; set; }
		[CProperty(Association ="VwTSSLA:ConfItemId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByConfItem { get; set; }
		[CProperty(Association ="VwTSSLAArchive:ConfItemId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByConfItem { get; set; }
		#endregion
	}
}
