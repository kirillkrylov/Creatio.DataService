using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Account")]
	public class Account : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId { get; set; }
		[CProperty(ColumnPath ="AccountLogoId")]
		public Guid AccountLogoId { get; set; }
		[CProperty(ColumnPath ="AdditionalPhone")]
		public string AdditionalPhone { get; set; }
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="AddressTypeId")]
		public Guid AddressTypeId { get; set; }
		[CProperty(ColumnPath ="AlternativeName")]
		public string AlternativeName { get; set; }
		[CProperty(ColumnPath ="AnnualRevenueId")]
		public Guid AnnualRevenueId { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="Completeness")]
		public int Completeness { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmployeesNumberId")]
		public Guid EmployeesNumberId { get; set; }
		[CProperty(ColumnPath ="Fax")]
		public string Fax { get; set; }
		[CProperty(ColumnPath ="GPSE")]
		public string GPSE { get; set; }
		[CProperty(ColumnPath ="GPSN")]
		public string GPSN { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId { get; set; }
		[CProperty(ColumnPath ="Logo")]
		public byte[] Logo { get; set; }
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
		[CProperty(ColumnPath ="OwnershipId")]
		public Guid OwnershipId { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="Phone")]
		public string Phone { get; set; }
		[CProperty(ColumnPath ="PriceListId")]
		public Guid PriceListId { get; set; }
		[CProperty(ColumnPath ="PrimaryContactId")]
		public Guid PrimaryContactId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Web")]
		public string Web { get; set; }
		[CProperty(ColumnPath ="WorkAccountTypeId")]
		public Guid WorkAccountTypeId { get; set; }
		[CProperty(ColumnPath ="WorkID")]
		public string WorkID { get; set; }
		[CProperty(ColumnPath ="WorkOpportunityTerritoryId")]
		public Guid WorkOpportunityTerritoryId { get; set; }
		[CProperty(ColumnPath ="WorkOwnerId")]
		public Guid WorkOwnerId { get; set; }
		[CProperty(ColumnPath ="Zip")]
		public string Zip { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:ParentId")]
		public Account Parent { get; set; }
		[CProperty(Navigation ="AccountAnnualRevenue:AnnualRevenueId")]
		public AccountAnnualRevenue AnnualRevenue { get; set; }
		[CProperty(Navigation ="AccountCategory:AccountCategoryId")]
		public AccountCategory AccountCategory { get; set; }
		[CProperty(Navigation ="AccountEmployeesNumber:EmployeesNumberId")]
		public AccountEmployeesNumber EmployeesNumber { get; set; }
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation ="AccountOwnership:OwnershipId")]
		public AccountOwnership Ownership { get; set; }
		[CProperty(Navigation ="AccountType:TypeId")]
		public AccountType Type { get; set; }
		[CProperty(Navigation ="AddressType:AddressTypeId")]
		public AddressType AddressType { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:PrimaryContactId")]
		public Contact PrimaryContact { get; set; }
		[CProperty(Navigation ="Contact:WorkOwnerId")]
		public Contact WorkOwner { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Pricelist:PriceListId")]
		public Pricelist PriceList { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="SysImage:AccountLogoId")]
		public SysImage AccountLogo { get; set; }
		[CProperty(Navigation ="WorkAccountType:WorkAccountTypeId")]
		public WorkAccountType WorkAccountType { get; set; }
		[CProperty(Navigation ="WorkOpportunityTerritory:WorkOpportunityTerritoryId")]
		public WorkOpportunityTerritory WorkOpportunityTerritory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:ParentId")]
		public virtual ICollection<Account> AccountByParent { get; set; }
		[CProperty(Association ="AccountAddress:AccountId")]
		public virtual ICollection<AccountAddress> AccountAddressByAccount { get; set; }
		[CProperty(Association ="AccountAlternativeName:AccountId")]
		public virtual ICollection<AccountAlternativeName> AccountAlternativeNameByAccount { get; set; }
		[CProperty(Association ="AccountAnniversary:AccountId")]
		public virtual ICollection<AccountAnniversary> AccountAnniversaryByAccount { get; set; }
		[CProperty(Association ="AccountBillingInfo:AccountId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByAccount { get; set; }
		[CProperty(Association ="AccountCommunication:AccountId")]
		public virtual ICollection<AccountCommunication> AccountCommunicationByAccount { get; set; }
		[CProperty(Association ="AccountDuplicate:Entity1Id")]
		public virtual ICollection<AccountDuplicate> AccountDuplicateByEntity1 { get; set; }
		[CProperty(Association ="AccountDuplicate:Entity2Id")]
		public virtual ICollection<AccountDuplicate> AccountDuplicateByEntity2 { get; set; }
		[CProperty(Association ="AccountEnrichedData:AccountId")]
		public virtual ICollection<AccountEnrichedData> AccountEnrichedDataByAccount { get; set; }
		[CProperty(Association ="AccountFile:AccountId")]
		public virtual ICollection<AccountFile> AccountFileByAccount { get; set; }
		[CProperty(Association ="AccountForecast:AccountId")]
		public virtual ICollection<AccountForecast> AccountForecastByAccount { get; set; }
		[CProperty(Association ="AccountInFolder:AccountId")]
		public virtual ICollection<AccountInFolder> AccountInFolderByAccount { get; set; }
		[CProperty(Association ="AccountInTag:EntityId")]
		public virtual ICollection<AccountInTag> AccountInTagByEntity { get; set; }
		[CProperty(Association ="AccountOrganizationChart:AccountId")]
		public virtual ICollection<AccountOrganizationChart> AccountOrganizationChartByAccount { get; set; }
		[CProperty(Association ="Activity:AccountId")]
		public virtual ICollection<Activity> ActivityByAccount { get; set; }
		[CProperty(Association ="Call:AccountId")]
		public virtual ICollection<Call> CallByAccount { get; set; }
		[CProperty(Association ="Case:AccountId")]
		public virtual ICollection<Case> CaseByAccount { get; set; }
		[CProperty(Association ="CompetitorProduct:CompetitorId")]
		public virtual ICollection<CompetitorProduct> CompetitorProductByCompetitor { get; set; }
		[CProperty(Association ="ConfItemUser:AccountId")]
		public virtual ICollection<ConfItemUser> ConfItemUserByAccount { get; set; }
		[CProperty(Association ="Contact:AccountId")]
		public virtual ICollection<Contact> ContactByAccount { get; set; }
		[CProperty(Association ="ContactCareer:AccountId")]
		public virtual ICollection<ContactCareer> ContactCareerByAccount { get; set; }
		[CProperty(Association ="Contract:AccountId")]
		public virtual ICollection<Contract> ContractByAccount { get; set; }
		[CProperty(Association ="Contract:OurCompanyId")]
		public virtual ICollection<Contract> ContractByOurCompany { get; set; }
		[CProperty(Association ="CTISearchResult:AccountId")]
		public virtual ICollection<CTISearchResult> CTISearchResultByAccount { get; set; }
		[CProperty(Association ="Document:AccountId")]
		public virtual ICollection<Document> DocumentByAccount { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:AccountId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByAccount { get; set; }
		[CProperty(Association ="Employee:AccountId")]
		public virtual ICollection<Employee> EmployeeByAccount { get; set; }
		[CProperty(Association ="EmployeeCareer:AccountId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByAccount { get; set; }
		[CProperty(Association ="EnrchFoundAccount:AccountId")]
		public virtual ICollection<EnrchFoundAccount> EnrchFoundAccountByAccount { get; set; }
		[CProperty(Association ="EventTeam:AccountId")]
		public virtual ICollection<EventTeam> EventTeamByAccount { get; set; }
		[CProperty(Association ="Invoice:AccountId")]
		public virtual ICollection<Invoice> InvoiceByAccount { get; set; }
		[CProperty(Association ="Invoice:SupplierId")]
		public virtual ICollection<Invoice> InvoiceBySupplier { get; set; }
		[CProperty(Association ="Lead:QualifiedAccountId")]
		public virtual ICollection<Lead> LeadByQualifiedAccount { get; set; }
		[CProperty(Association ="Lead:PartnerId")]
		public virtual ICollection<Lead> LeadByPartner { get; set; }
		[CProperty(Association ="LeadQualification:AccountId")]
		public virtual ICollection<LeadQualification> LeadQualificationByAccount { get; set; }
		[CProperty(Association ="Opportunity:AccountId")]
		public virtual ICollection<Opportunity> OpportunityByAccount { get; set; }
		[CProperty(Association ="Opportunity:PartnerId")]
		public virtual ICollection<Opportunity> OpportunityByPartner { get; set; }
		[CProperty(Association ="Opportunity:WinnerId")]
		public virtual ICollection<Opportunity> OpportunityByWinner { get; set; }
		[CProperty(Association ="OpportunityCompetitor:CompetitorId")]
		public virtual ICollection<OpportunityCompetitor> OpportunityCompetitorByCompetitor { get; set; }
		[CProperty(Association ="OpportunityCompetitor:SupplierId")]
		public virtual ICollection<OpportunityCompetitor> OpportunityCompetitorBySupplier { get; set; }
		[CProperty(Association ="OpportunityParticipant:AccountId")]
		public virtual ICollection<OpportunityParticipant> OpportunityParticipantByAccount { get; set; }
		[CProperty(Association ="Order:AccountId")]
		public virtual ICollection<Order> OrderByAccount { get; set; }
		[CProperty(Association ="Partnership:AccountId")]
		public virtual ICollection<Partnership> PartnershipByAccount { get; set; }
		[CProperty(Association ="Project:AccountId")]
		public virtual ICollection<Project> ProjectByAccount { get; set; }
		[CProperty(Association ="Project:SupplierId")]
		public virtual ICollection<Project> ProjectBySupplier { get; set; }
		[CProperty(Association ="QuickDialUserSettings:AccountId")]
		public virtual ICollection<QuickDialUserSettings> QuickDialUserSettingsByAccount { get; set; }
		[CProperty(Association ="Relationship:AccountAId")]
		public virtual ICollection<Relationship> RelationshipByAccountA { get; set; }
		[CProperty(Association ="Relationship:AccountBId")]
		public virtual ICollection<Relationship> RelationshipByAccountB { get; set; }
		[CProperty(Association ="ServiceObject:AccountId")]
		public virtual ICollection<ServiceObject> ServiceObjectByAccount { get; set; }
		[CProperty(Association ="ServicePact:ServiceProviderId")]
		public virtual ICollection<ServicePact> ServicePactByServiceProvider { get; set; }
		[CProperty(Association ="SysAdminUnit:AccountId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByAccount { get; set; }
		[CProperty(Association ="SysAdminUnit:PortalAccountId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByPortalAccount { get; set; }
		[CProperty(Association ="VwAccountDuplicate:Entity1Id")]
		public virtual ICollection<VwAccountDuplicate> VwAccountDuplicateByEntity1 { get; set; }
		[CProperty(Association ="VwAccountDuplicate:Entity2Id")]
		public virtual ICollection<VwAccountDuplicate> VwAccountDuplicateByEntity2 { get; set; }
		[CProperty(Association ="VwAccountModuleHistory:AccountId")]
		public virtual ICollection<VwAccountModuleHistory> VwAccountModuleHistoryByAccount { get; set; }
		[CProperty(Association ="VwAccountRelationship:AccountId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByAccount { get; set; }
		[CProperty(Association ="VwAccountRelationship:RelatedAccountId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByRelatedAccount { get; set; }
		[CProperty(Association ="VwAnniversary:AccountId")]
		public virtual ICollection<VwAnniversary> VwAnniversaryByAccount { get; set; }
		[CProperty(Association ="VwContactRelationship:RelatedAccountId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByRelatedAccount { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:AccountId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByAccount { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:PortalAccountId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByPortalAccount { get; set; }
		[CProperty(Association ="VwModuleHistory:AccountId")]
		public virtual ICollection<VwModuleHistory> VwModuleHistoryByAccount { get; set; }
		[CProperty(Association ="VwPortalOpportunity:AccountId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByAccount { get; set; }
		[CProperty(Association ="VwPortalOpportunity:PartnerId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByPartner { get; set; }
		[CProperty(Association ="VwProjectHierarchy:AccountId")]
		public virtual ICollection<VwProjectHierarchy> VwProjectHierarchyByAccount { get; set; }
		[CProperty(Association ="VwQueueItem:AccountId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByAccount { get; set; }
		[CProperty(Association ="VwRelationship:AccountAId")]
		public virtual ICollection<VwRelationship> VwRelationshipByAccountA { get; set; }
		[CProperty(Association ="VwRelationship:AccountBId")]
		public virtual ICollection<VwRelationship> VwRelationshipByAccountB { get; set; }
		[CProperty(Association ="VwServiceRecepients:AccountId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByAccount { get; set; }
		[CProperty(Association ="VwSspAdminUnit:AccountId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByAccount { get; set; }
		[CProperty(Association ="VwSspAdminUnit:PortalAccountId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByPortalAccount { get; set; }
		[CProperty(Association ="VwSysAdminUnit:AccountId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByAccount { get; set; }
		#endregion
	}
}
