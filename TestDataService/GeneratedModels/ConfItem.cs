using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ConfItem")]
	public class ConfItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="BpmonlineBuildDBMSId")]
		public Guid BpmonlineBuildDBMSId { get; set; }
		[CProperty(ColumnPath ="BpmonlineBuildId")]
		public Guid BpmonlineBuildId { get; set; }
		[CProperty(ColumnPath ="BpmonlineLczId")]
		public Guid BpmonlineLczId { get; set; }
		[CProperty(ColumnPath ="BpmonlineProductId")]
		public Guid BpmonlineProductId { get; set; }
		[CProperty(ColumnPath ="BpmonlineVersionId")]
		public Guid BpmonlineVersionId { get; set; }
		[CProperty(ColumnPath ="BPMPkgId")]
		public Guid BPMPkgId { get; set; }
		[CProperty(ColumnPath ="CancelDate")]
		public DateTime CancelDate { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContactsCount")]
		public int ContactsCount { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CustomerID")]
		public string CustomerID { get; set; }
		[CProperty(ColumnPath ="DBSizeMB")]
		public int DBSizeMB { get; set; }
		[CProperty(ColumnPath ="Domain")]
		public string Domain { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InventoryNumber")]
		public string InventoryNumber { get; set; }
		[CProperty(ColumnPath ="LastSessionEndDate")]
		public DateTime LastSessionEndDate { get; set; }
		[CProperty(ColumnPath ="LastSessionStartDate")]
		public DateTime LastSessionStartDate { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="LicenseDueDate")]
		public DateTime LicenseDueDate { get; set; }
		[CProperty(ColumnPath ="MandrillAPIKey")]
		public string MandrillAPIKey { get; set; }
		[CProperty(ColumnPath ="MandrillAPIKeyStateId")]
		public Guid MandrillAPIKeyStateId { get; set; }
		[CProperty(ColumnPath ="MandrillUserName")]
		public string MandrillUserName { get; set; }
		[CProperty(ColumnPath ="MandrillUserPassword")]
		public string MandrillUserPassword { get; set; }
		[CProperty(ColumnPath ="MaxSiteCount")]
		public int MaxSiteCount { get; set; }
		[CProperty(ColumnPath ="ModelId")]
		public Guid ModelId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentConfItemId")]
		public Guid ParentConfItemId { get; set; }
		[CProperty(ColumnPath ="PartnerAccountId")]
		public Guid PartnerAccountId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="PurchaseDate")]
		public DateTime PurchaseDate { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="SerialNumber")]
		public string SerialNumber { get; set; }
		[CProperty(ColumnPath ="ServerBlockNumber")]
		public int ServerBlockNumber { get; set; }
		[CProperty(ColumnPath ="ServerBlockTypeId")]
		public Guid ServerBlockTypeId { get; set; }
		[CProperty(ColumnPath ="SiteId")]
		public Guid SiteId { get; set; }
		[CProperty(ColumnPath ="SitePurposeId")]
		public Guid SitePurposeId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Street")]
		public string Street { get; set; }
		[CProperty(ColumnPath ="SubscriptionId")]
		public Guid SubscriptionId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UpdateDate")]
		public DateTime UpdateDate { get; set; }
		[CProperty(ColumnPath ="UpdateResultId")]
		public Guid UpdateResultId { get; set; }
		[CProperty(ColumnPath ="UpdateStatusId")]
		public Guid UpdateStatusId { get; set; }
		[CProperty(ColumnPath ="UpdatingSlots")]
		public int UpdatingSlots { get; set; }
		[CProperty(ColumnPath ="UsersCount")]
		public int UsersCount { get; set; }
		[CProperty(ColumnPath ="Violation")]
		public string Violation { get; set; }
		[CProperty(ColumnPath ="VirtualizationTypeId")]
		public Guid VirtualizationTypeId { get; set; }
		[CProperty(ColumnPath ="WarrantyUntil")]
		public DateTime WarrantyUntil { get; set; }
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
