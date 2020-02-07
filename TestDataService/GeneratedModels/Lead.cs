using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Lead")]
	public class Lead : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Account")]
		public string Account { get; set; }
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId { get; set; }
		[CProperty(ColumnPath ="AccountOwnershipId")]
		public Guid AccountOwnershipId { get; set; }
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="AddressTypeId")]
		public Guid AddressTypeId { get; set; }
		[CProperty(ColumnPath ="AnnualRevenueId")]
		public Guid AnnualRevenueId { get; set; }
		[CProperty(ColumnPath ="BpmHref")]
		public string BpmHref { get; set; }
		[CProperty(ColumnPath ="BpmRef")]
		public string BpmRef { get; set; }
		[CProperty(ColumnPath ="BpmSessionId")]
		public Guid BpmSessionId { get; set; }
		[CProperty(ColumnPath ="Budget")]
		public decimal Budget { get; set; }
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId { get; set; }
		[CProperty(ColumnPath ="BusinesPhone")]
		public string BusinesPhone { get; set; }
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="CityStr")]
		public string CityStr { get; set; }
		[CProperty(ColumnPath ="Commentary")]
		public string Commentary { get; set; }
		[CProperty(ColumnPath ="Contact")]
		public string Contact { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CountryStr")]
		public string CountryStr { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Dear")]
		public string Dear { get; set; }
		[CProperty(ColumnPath ="DecisionDate")]
		public DateTime DecisionDate { get; set; }
		[CProperty(ColumnPath ="DecisionRoleId")]
		public Guid DecisionRoleId { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="DoNotUseEmail")]
		public bool DoNotUseEmail { get; set; }
		[CProperty(ColumnPath ="DoNotUseFax")]
		public bool DoNotUseFax { get; set; }
		[CProperty(ColumnPath ="DoNotUseMail")]
		public bool DoNotUseMail { get; set; }
		[CProperty(ColumnPath ="DoNotUsePhone")]
		public bool DoNotUsePhone { get; set; }
		[CProperty(ColumnPath ="DoNotUseSMS")]
		public bool DoNotUseSMS { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="EmployeesNumberId")]
		public Guid EmployeesNumberId { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="Fax")]
		public string Fax { get; set; }
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle { get; set; }
		[CProperty(ColumnPath ="GenderId")]
		public Guid GenderId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IdentificationPassed")]
		public bool IdentificationPassed { get; set; }
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId { get; set; }
		[CProperty(ColumnPath ="InformationSourceId")]
		public Guid InformationSourceId { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="LeadDisqualifyReasonId")]
		public Guid LeadDisqualifyReasonId { get; set; }
		[CProperty(ColumnPath ="LeadMediumId")]
		public Guid LeadMediumId { get; set; }
		[CProperty(ColumnPath ="LeadName")]
		public string LeadName { get; set; }
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="LeadTypeStatusId")]
		public Guid LeadTypeStatusId { get; set; }
		[CProperty(ColumnPath ="MeetingDate")]
		public DateTime MeetingDate { get; set; }
		[CProperty(ColumnPath ="MobilePhone")]
		public string MobilePhone { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="MovedToFinalStateOn")]
		public DateTime MovedToFinalStateOn { get; set; }
		[CProperty(ColumnPath ="NextActualizationDate")]
		public DateTime NextActualizationDate { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PartnerOwnerId")]
		public Guid PartnerOwnerId { get; set; }
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId { get; set; }
		[CProperty(ColumnPath ="PredictiveScore")]
		public int PredictiveScore { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="QualificationPassed")]
		public bool QualificationPassed { get; set; }
		[CProperty(ColumnPath ="QualificationProcessId")]
		public Guid QualificationProcessId { get; set; }
		[CProperty(ColumnPath ="Qualified")]
		public int Qualified { get; set; }
		[CProperty(ColumnPath ="QualifiedAccountId")]
		public Guid QualifiedAccountId { get; set; }
		[CProperty(ColumnPath ="QualifiedContactId")]
		public Guid QualifiedContactId { get; set; }
		[CProperty(ColumnPath ="QualifiedPercent")]
		public decimal QualifiedPercent { get; set; }
		[CProperty(ColumnPath ="QualifyStatusId")]
		public Guid QualifyStatusId { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="RegionStr")]
		public string RegionStr { get; set; }
		[CProperty(ColumnPath ="RegisterMethodId")]
		public Guid RegisterMethodId { get; set; }
		[CProperty(ColumnPath ="RemindToOwner")]
		public bool RemindToOwner { get; set; }
		[CProperty(ColumnPath ="SaleParticipant")]
		public int SaleParticipant { get; set; }
		[CProperty(ColumnPath ="SalePercent")]
		public decimal SalePercent { get; set; }
		[CProperty(ColumnPath ="SalesChannelId")]
		public Guid SalesChannelId { get; set; }
		[CProperty(ColumnPath ="SalesOwnerId")]
		public Guid SalesOwnerId { get; set; }
		[CProperty(ColumnPath ="SaleType")]
		public string SaleType { get; set; }
		[CProperty(ColumnPath ="Score")]
		public decimal Score { get; set; }
		[CProperty(ColumnPath ="ShowDistributionPage")]
		public bool ShowDistributionPage { get; set; }
		[CProperty(ColumnPath ="StartLeadManagementProcess")]
		public bool StartLeadManagementProcess { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TitleId")]
		public Guid TitleId { get; set; }
		[CProperty(ColumnPath ="WebFormId")]
		public Guid WebFormId { get; set; }
		[CProperty(ColumnPath ="Website")]
		public string Website { get; set; }
		[CProperty(ColumnPath ="Zip")]
		public string Zip { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:QualifiedAccountId")]
		public Account QualifiedAccount { get; set; }
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="AccountAnnualRevenue:AnnualRevenueId")]
		public AccountAnnualRevenue AnnualRevenue { get; set; }
		[CProperty(Navigation ="AccountCategory:AccountCategoryId")]
		public AccountCategory AccountCategory { get; set; }
		[CProperty(Navigation ="AccountEmployeesNumber:EmployeesNumberId")]
		public AccountEmployeesNumber EmployeesNumber { get; set; }
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation ="AccountOwnership:AccountOwnershipId")]
		public AccountOwnership AccountOwnership { get; set; }
		[CProperty(Navigation ="AddressType:AddressTypeId")]
		public AddressType AddressType { get; set; }
		[CProperty(Navigation ="BulkEmail:BulkEmailId")]
		public BulkEmail BulkEmail { get; set; }
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:QualifiedContactId")]
		public Contact QualifiedContact { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:SalesOwnerId")]
		public Contact SalesOwner { get; set; }
		[CProperty(Navigation ="Contact:PartnerOwnerId")]
		public Contact PartnerOwner { get; set; }
		[CProperty(Navigation ="ContactDecisionRole:DecisionRoleId")]
		public ContactDecisionRole DecisionRole { get; set; }
		[CProperty(Navigation ="ContactSalutationType:TitleId")]
		public ContactSalutationType Title { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Department:DepartmentId")]
		public Department Department { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="Gender:GenderId")]
		public Gender Gender { get; set; }
		[CProperty(Navigation ="GeneratedWebForm:WebFormId")]
		public GeneratedWebForm WebForm { get; set; }
		[CProperty(Navigation ="InformationSource:InformationSourceId")]
		public InformationSource InformationSource { get; set; }
		[CProperty(Navigation ="Job:JobId")]
		public Job Job { get; set; }
		[CProperty(Navigation ="LeadDisqualifyReason:LeadDisqualifyReasonId")]
		public LeadDisqualifyReason LeadDisqualifyReason { get; set; }
		[CProperty(Navigation ="LeadMedium:LeadMediumId")]
		public LeadMedium LeadMedium { get; set; }
		[CProperty(Navigation ="LeadRegisterMethod:RegisterMethodId")]
		public LeadRegisterMethod RegisterMethod { get; set; }
		[CProperty(Navigation ="LeadSource:LeadSourceId")]
		public LeadSource LeadSource { get; set; }
		[CProperty(Navigation ="LeadStatus:StatusId")]
		public LeadStatus Status { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="LeadTypeStatus:LeadTypeStatusId")]
		public LeadTypeStatus LeadTypeStatus { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		[CProperty(Navigation ="OpportunityType:SalesChannelId")]
		public OpportunityType SalesChannel { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="PartnerType:PartnerTypeId")]
		public PartnerType PartnerType { get; set; }
		[CProperty(Navigation ="QualifyStatus:QualifyStatusId")]
		public QualifyStatus QualifyStatus { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:LeadId")]
		public virtual ICollection<Activity> ActivityByLead { get; set; }
		[CProperty(Association ="Call:LeadId")]
		public virtual ICollection<Call> CallByLead { get; set; }
		[CProperty(Association ="FileLead:LeadId")]
		public virtual ICollection<FileLead> FileLeadByLead { get; set; }
		[CProperty(Association ="LeadAddress:LeadId")]
		public virtual ICollection<LeadAddress> LeadAddressByLead { get; set; }
		[CProperty(Association ="LeadInFolder:LeadId")]
		public virtual ICollection<LeadInFolder> LeadInFolderByLead { get; set; }
		[CProperty(Association ="LeadInQualifyStatus:LeadId")]
		public virtual ICollection<LeadInQualifyStatus> LeadInQualifyStatusByLead { get; set; }
		[CProperty(Association ="LeadInTag:EntityId")]
		public virtual ICollection<LeadInTag> LeadInTagByEntity { get; set; }
		[CProperty(Association ="LeadMessageHistory:LeadId")]
		public virtual ICollection<LeadMessageHistory> LeadMessageHistoryByLead { get; set; }
		[CProperty(Association ="LeadProduct:LeadId")]
		public virtual ICollection<LeadProduct> LeadProductByLead { get; set; }
		[CProperty(Association ="SpecificationInLead:LeadId")]
		public virtual ICollection<SpecificationInLead> SpecificationInLeadByLead { get; set; }
		[CProperty(Association ="VwSiteEvent:LeadId")]
		public virtual ICollection<VwSiteEvent> VwSiteEventByLead { get; set; }
		#endregion
	}
}
