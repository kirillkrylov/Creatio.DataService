using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Contact")]
	public class Contact : BaseEntity
	{


		#region Values
		[CProperty(ColumnPath ="AcademyLink")]
		public string AcademyLink { get; set; }
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="AddressTypeId")]
		public Guid AddressTypeId { get; set; }
		[CProperty(ColumnPath ="BirthDate")]
		public DateTime BirthDate { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="Completeness")]
		public int Completeness { get; set; }
		[CProperty(ColumnPath ="Confirmed")]
		public bool Confirmed { get; set; }
		[CProperty(ColumnPath ="ContactPhoto")]
		public byte[] ContactPhoto { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Dear")]
		public string Dear { get; set; }
		[CProperty(ColumnPath ="DecisionRoleId")]
		public Guid DecisionRoleId { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="DoNotUseCall")]
		public bool DoNotUseCall { get; set; }
		[CProperty(ColumnPath ="DoNotUseEmail")]
		public bool DoNotUseEmail { get; set; }
		[CProperty(ColumnPath ="DoNotUseFax")]
		public bool DoNotUseFax { get; set; }
		[CProperty(ColumnPath ="DoNotUseMail")]
		public bool DoNotUseMail { get; set; }
		[CProperty(ColumnPath ="DoNotUseSms")]
		public bool DoNotUseSms { get; set; }
		[CProperty(ColumnPath ="DrupalContactUid")]
		public string DrupalContactUid { get; set; }
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="Facebook")]
		public string Facebook { get; set; }
		[CProperty(ColumnPath ="FacebookAFDAId")]
		public Guid FacebookAFDAId { get; set; }
		[CProperty(ColumnPath ="FacebookId")]
		public string FacebookId { get; set; }
		[CProperty(ColumnPath ="GenderId")]
		public Guid GenderId { get; set; }
		[CProperty(ColumnPath ="GivenName")]
		public string GivenName { get; set; }
		[CProperty(ColumnPath ="GPSE")]
		public string GPSE { get; set; }
		[CProperty(ColumnPath ="GPSN")]
		public string GPSN { get; set; }
		[CProperty(ColumnPath ="HomePhone")]
		public string HomePhone { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsNonActualEmail")]
		public bool IsNonActualEmail { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle { get; set; }
		[CProperty(ColumnPath ="LanguageId")]
		public Guid LanguageId { get; set; }
		[CProperty(ColumnPath ="LinkedIn")]
		public string LinkedIn { get; set; }
		[CProperty(ColumnPath ="LinkedInAFDAId")]
		public Guid LinkedInAFDAId { get; set; }
		[CProperty(ColumnPath ="LinkedInId")]
		public string LinkedInId { get; set; }
		[CProperty(ColumnPath ="MiddleName")]
		public string MiddleName { get; set; }
		[CProperty(ColumnPath ="MobilePhone")]
		public string MobilePhone { get; set; }
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
		[CProperty(ColumnPath ="Phone")]
		public string Phone { get; set; }
		[CProperty(ColumnPath ="PhotoId")]
		public Guid PhotoId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="SalutationTypeId")]
		public Guid SalutationTypeId { get; set; }
		[CProperty(ColumnPath ="Skype")]
		public string Skype { get; set; }
		[CProperty(ColumnPath ="Surname")]
		public string Surname { get; set; }
		[CProperty(ColumnPath ="Twitter")]
		public string Twitter { get; set; }
		[CProperty(ColumnPath ="TwitterAFDAId")]
		public Guid TwitterAFDAId { get; set; }
		[CProperty(ColumnPath ="TwitterId")]
		public string TwitterId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="WorkContactTypeId")]
		public Guid WorkContactTypeId { get; set; }
		[CProperty(ColumnPath ="WorkID")]
		public string WorkID { get; set; }
		[CProperty(ColumnPath ="Zip")]
		public string Zip { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
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
		[CProperty(Navigation ="ContactDecisionRole:DecisionRoleId")]
		public ContactDecisionRole DecisionRole { get; set; }
		[CProperty(Navigation ="ContactSalutationType:SalutationTypeId")]
		public ContactSalutationType SalutationType { get; set; }
		[CProperty(Navigation ="ContactType:TypeId")]
		public ContactType Type { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="Department:DepartmentId")]
		public Department Department { get; set; }
		[CProperty(Navigation ="Gender:GenderId")]
		public Gender Gender { get; set; }
		[CProperty(Navigation ="Job:JobId")]
		public Job Job { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="SocialAccount:TwitterAFDAId")]
		public SocialAccount TwitterAFDA { get; set; }
		[CProperty(Navigation ="SocialAccount:FacebookAFDAId")]
		public SocialAccount FacebookAFDA { get; set; }
		[CProperty(Navigation ="SocialAccount:LinkedInAFDAId")]
		public SocialAccount LinkedInAFDA { get; set; }
		[CProperty(Navigation ="SysImage:PhotoId")]
		public SysImage Photo { get; set; }
		[CProperty(Navigation ="SysLanguage:LanguageId")]
		public SysLanguage Language { get; set; }
		[CProperty(Navigation ="WorkContactType:WorkContactTypeId")]
		public WorkContactType WorkContactType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:OwnerId")]
		public virtual ICollection<Account> AccountByOwner { get; set; }
		[CProperty(Association ="Account:PrimaryContactId")]
		public virtual ICollection<Account> AccountByPrimaryContact { get; set; }
		[CProperty(Association ="Account:WorkOwnerId")]
		public virtual ICollection<Account> AccountByWorkOwner { get; set; }
		[CProperty(Association ="AccountBillingInfo:AccountManagerId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByAccountManager { get; set; }
		[CProperty(Association ="AccountBillingInfo:ChiefAccountantId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByChiefAccountant { get; set; }
		[CProperty(Association ="AccountFile:LockedById")]
		public virtual ICollection<AccountFile> AccountFileByLockedBy { get; set; }
		[CProperty(Association ="AccountOrganizationChart:ManagerId")]
		public virtual ICollection<AccountOrganizationChart> AccountOrganizationChartByManager { get; set; }
		[CProperty(Association ="Activity:OwnerId")]
		public virtual ICollection<Activity> ActivityByOwner { get; set; }
		[CProperty(Association ="Activity:AuthorId")]
		public virtual ICollection<Activity> ActivityByAuthor { get; set; }
		[CProperty(Association ="Activity:ContactId")]
		public virtual ICollection<Activity> ActivityByContact { get; set; }
		[CProperty(Association ="Activity:OrganizerId")]
		public virtual ICollection<Activity> ActivityByOrganizer { get; set; }
		[CProperty(Association ="Activity:SenderContactId")]
		public virtual ICollection<Activity> ActivityBySenderContact { get; set; }
		[CProperty(Association ="ActivityFile:LockedById")]
		public virtual ICollection<ActivityFile> ActivityFileByLockedBy { get; set; }
		[CProperty(Association ="ActivityParticipant:ParticipantId")]
		public virtual ICollection<ActivityParticipant> ActivityParticipantByParticipant { get; set; }
		[CProperty(Association ="BulkEmail:OwnerId")]
		public virtual ICollection<BulkEmail> BulkEmailByOwner { get; set; }
		[CProperty(Association ="BulkEmailFile:LockedById")]
		public virtual ICollection<BulkEmailFile> BulkEmailFileByLockedBy { get; set; }
		[CProperty(Association ="BulkEmailRecipientMacro:ContactId")]
		public virtual ICollection<BulkEmailRecipientMacro> BulkEmailRecipientMacroByContact { get; set; }
		[CProperty(Association ="BulkEmailSplit:OwnerId")]
		public virtual ICollection<BulkEmailSplit> BulkEmailSplitByOwner { get; set; }
		[CProperty(Association ="BulkEmailSplitFile:LockedById")]
		public virtual ICollection<BulkEmailSplitFile> BulkEmailSplitFileByLockedBy { get; set; }
		[CProperty(Association ="BulkEmailSplitTarget:ContactId")]
		public virtual ICollection<BulkEmailSplitTarget> BulkEmailSplitTargetByContact { get; set; }
		[CProperty(Association ="BulkEmailSubscription:ContactId")]
		public virtual ICollection<BulkEmailSubscription> BulkEmailSubscriptionByContact { get; set; }
		[CProperty(Association ="BulkEmailTarget:ContactId")]
		public virtual ICollection<BulkEmailTarget> BulkEmailTargetByContact { get; set; }
		[CProperty(Association ="Call:ContactId")]
		public virtual ICollection<Call> CallByContact { get; set; }
		[CProperty(Association ="CallFile:LockedById")]
		public virtual ICollection<CallFile> CallFileByLockedBy { get; set; }
		[CProperty(Association ="Campaign:OwnerId")]
		public virtual ICollection<Campaign> CampaignByOwner { get; set; }
		[CProperty(Association ="CampaignFile:LockedById")]
		public virtual ICollection<CampaignFile> CampaignFileByLockedBy { get; set; }
		[CProperty(Association ="CampaignParticipant:ContactId")]
		public virtual ICollection<CampaignParticipant> CampaignParticipantByContact { get; set; }
		[CProperty(Association ="CampaignParticipantOp:ContactId")]
		public virtual ICollection<CampaignParticipantOp> CampaignParticipantOpByContact { get; set; }
		[CProperty(Association ="CampaignPlanner:OwnerId")]
		public virtual ICollection<CampaignPlanner> CampaignPlannerByOwner { get; set; }
		[CProperty(Association ="CampaignPlannerFile:LockedById")]
		public virtual ICollection<CampaignPlannerFile> CampaignPlannerFileByLockedBy { get; set; }
		[CProperty(Association ="CampaignQueue:ContactId")]
		public virtual ICollection<CampaignQueue> CampaignQueueByContact { get; set; }
		[CProperty(Association ="CampaignSignal:ContactId")]
		public virtual ICollection<CampaignSignal> CampaignSignalByContact { get; set; }
		[CProperty(Association ="CampaignTarget:ContactId")]
		public virtual ICollection<CampaignTarget> CampaignTargetByContact { get; set; }
		[CProperty(Association ="Case:OwnerId")]
		public virtual ICollection<Case> CaseByOwner { get; set; }
		[CProperty(Association ="Case:ContactId")]
		public virtual ICollection<Case> CaseByContact { get; set; }
		[CProperty(Association ="Case:HolderId")]
		public virtual ICollection<Case> CaseByHolder { get; set; }
		[CProperty(Association ="CaseFile:LockedById")]
		public virtual ICollection<CaseFile> CaseFileByLockedBy { get; set; }
		[CProperty(Association ="CaseLifecycle:OwnerId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByOwner { get; set; }
		[CProperty(Association ="Certificate:ContactId")]
		public virtual ICollection<Certificate> CertificateByContact { get; set; }
		[CProperty(Association ="Certification:StudentId")]
		public virtual ICollection<Certification> CertificationByStudent { get; set; }
		[CProperty(Association ="Certification:TrainerId")]
		public virtual ICollection<Certification> CertificationByTrainer { get; set; }
		[CProperty(Association ="Certification:POMId")]
		public virtual ICollection<Certification> CertificationByPOM { get; set; }
		[CProperty(Association ="CertificationFile:LockedById")]
		public virtual ICollection<CertificationFile> CertificationFileByLockedBy { get; set; }
		[CProperty(Association ="CertificationParticipant:ContactId")]
		public virtual ICollection<CertificationParticipant> CertificationParticipantByContact { get; set; }
		[CProperty(Association ="Change:AuthorId")]
		public virtual ICollection<Change> ChangeByAuthor { get; set; }
		[CProperty(Association ="Change:OwnerId")]
		public virtual ICollection<Change> ChangeByOwner { get; set; }
		[CProperty(Association ="ChangeFile:LockedById")]
		public virtual ICollection<ChangeFile> ChangeFileByLockedBy { get; set; }
		[CProperty(Association ="Comment:ContactId")]
		public virtual ICollection<Comment> CommentByContact { get; set; }
		[CProperty(Association ="ConfItem:OwnerId")]
		public virtual ICollection<ConfItem> ConfItemByOwner { get; set; }
		[CProperty(Association ="ConfItemFile:LockedById")]
		public virtual ICollection<ConfItemFile> ConfItemFileByLockedBy { get; set; }
		[CProperty(Association ="ConfItemUser:ContactId")]
		public virtual ICollection<ConfItemUser> ConfItemUserByContact { get; set; }
		[CProperty(Association ="Contact:OwnerId")]
		public virtual ICollection<Contact> ContactByOwner { get; set; }
		[CProperty(Association ="ContactAddress:ContactId")]
		public virtual ICollection<ContactAddress> ContactAddressByContact { get; set; }
		[CProperty(Association ="ContactAnniversary:ContactId")]
		public virtual ICollection<ContactAnniversary> ContactAnniversaryByContact { get; set; }
		[CProperty(Association ="ContactCareer:ContactId")]
		public virtual ICollection<ContactCareer> ContactCareerByContact { get; set; }
		[CProperty(Association ="ContactCommunication:ContactId")]
		public virtual ICollection<ContactCommunication> ContactCommunicationByContact { get; set; }
		[CProperty(Association ="ContactCorrespondence:ContactId")]
		public virtual ICollection<ContactCorrespondence> ContactCorrespondenceByContact { get; set; }
		[CProperty(Association ="ContactDuplicate:Entity1Id")]
		public virtual ICollection<ContactDuplicate> ContactDuplicateByEntity1 { get; set; }
		[CProperty(Association ="ContactDuplicate:Entity2Id")]
		public virtual ICollection<ContactDuplicate> ContactDuplicateByEntity2 { get; set; }
		[CProperty(Association ="ContactExternalRate:ContactId")]
		public virtual ICollection<ContactExternalRate> ContactExternalRateByContact { get; set; }
		[CProperty(Association ="ContactFile:LockedById")]
		public virtual ICollection<ContactFile> ContactFileByLockedBy { get; set; }
		[CProperty(Association ="ContactFile:ContactId")]
		public virtual ICollection<ContactFile> ContactFileByContact { get; set; }
		[CProperty(Association ="ContactForecast:ContactId")]
		public virtual ICollection<ContactForecast> ContactForecastByContact { get; set; }
		[CProperty(Association ="ContactInFolder:ContactId")]
		public virtual ICollection<ContactInFolder> ContactInFolderByContact { get; set; }
		[CProperty(Association ="ContactInTag:EntityId")]
		public virtual ICollection<ContactInTag> ContactInTagByEntity { get; set; }
		[CProperty(Association ="ContactInternalRate:ContactId")]
		public virtual ICollection<ContactInternalRate> ContactInternalRateByContact { get; set; }
		[CProperty(Association ="ContactsProductInterest:ContactId")]
		public virtual ICollection<ContactsProductInterest> ContactsProductInterestByContact { get; set; }
		[CProperty(Association ="ContentBlockFile:LockedById")]
		public virtual ICollection<ContentBlockFile> ContentBlockFileByLockedBy { get; set; }
		[CProperty(Association ="Contract:OwnerId")]
		public virtual ICollection<Contract> ContractByOwner { get; set; }
		[CProperty(Association ="Contract:ContactId")]
		public virtual ICollection<Contract> ContractByContact { get; set; }
		[CProperty(Association ="ContractFile:LockedById")]
		public virtual ICollection<ContractFile> ContractFileByLockedBy { get; set; }
		[CProperty(Association ="ContractVisa:SetById")]
		public virtual ICollection<ContractVisa> ContractVisaBySetBy { get; set; }
		[CProperty(Association ="CTISearchResult:ContactId")]
		public virtual ICollection<CTISearchResult> CTISearchResultByContact { get; set; }
		[CProperty(Association ="DayOff:ContactId")]
		public virtual ICollection<DayOff> DayOffByContact { get; set; }
		[CProperty(Association ="Document:OwnerId")]
		public virtual ICollection<Document> DocumentByOwner { get; set; }
		[CProperty(Association ="Document:ContactId")]
		public virtual ICollection<Document> DocumentByContact { get; set; }
		[CProperty(Association ="DocumentFile:LockedById")]
		public virtual ICollection<DocumentFile> DocumentFileByLockedBy { get; set; }
		[CProperty(Association ="DocumentVisa:SetById")]
		public virtual ICollection<DocumentVisa> DocumentVisaBySetBy { get; set; }
		[CProperty(Association ="EducationActivity:ContactId")]
		public virtual ICollection<EducationActivity> EducationActivityByContact { get; set; }
		[CProperty(Association ="EmailFolderColumnValuesSetting:ContactId")]
		public virtual ICollection<EmailFolderColumnValuesSetting> EmailFolderColumnValuesSettingByContact { get; set; }
		[CProperty(Association ="EmailMessageData:OwnerId")]
		public virtual ICollection<EmailMessageData> EmailMessageDataByOwner { get; set; }
		[CProperty(Association ="EmailTemplateFile:LockedById")]
		public virtual ICollection<EmailTemplateFile> EmailTemplateFileByLockedBy { get; set; }
		[CProperty(Association ="Employee:ContactId")]
		public virtual ICollection<Employee> EmployeeByContact { get; set; }
		[CProperty(Association ="Employee:OwnerId")]
		public virtual ICollection<Employee> EmployeeByOwner { get; set; }
		[CProperty(Association ="EmployeeFile:LockedById")]
		public virtual ICollection<EmployeeFile> EmployeeFileByLockedBy { get; set; }
		[CProperty(Association ="EnrchFoundContact:ContactId")]
		public virtual ICollection<EnrchFoundContact> EnrchFoundContactByContact { get; set; }
		[CProperty(Association ="EnrchProcessedData:ContactId")]
		public virtual ICollection<EnrchProcessedData> EnrchProcessedDataByContact { get; set; }
		[CProperty(Association ="EnrchRejectedData:ContactId")]
		public virtual ICollection<EnrchRejectedData> EnrchRejectedDataByContact { get; set; }
		[CProperty(Association ="ESNNotification:OwnerId")]
		public virtual ICollection<ESNNotification> ESNNotificationByOwner { get; set; }
		[CProperty(Association ="Event:OwnerId")]
		public virtual ICollection<Event> EventByOwner { get; set; }
		[CProperty(Association ="EventFile:LockedById")]
		public virtual ICollection<EventFile> EventFileByLockedBy { get; set; }
		[CProperty(Association ="EventTarget:ContactId")]
		public virtual ICollection<EventTarget> EventTargetByContact { get; set; }
		[CProperty(Association ="EventTeam:ContactId")]
		public virtual ICollection<EventTeam> EventTeamByContact { get; set; }
		[CProperty(Association ="ExternalAccess:GrantorId")]
		public virtual ICollection<ExternalAccess> ExternalAccessByGrantor { get; set; }
		[CProperty(Association ="ExternalAccessFile:LockedById")]
		public virtual ICollection<ExternalAccessFile> ExternalAccessFileByLockedBy { get; set; }
		[CProperty(Association ="ExternalAccessRequestLog:RequestedById")]
		public virtual ICollection<ExternalAccessRequestLog> ExternalAccessRequestLogByRequestedBy { get; set; }
		[CProperty(Association ="Favorites:ContactId")]
		public virtual ICollection<Favorites> FavoritesByContact { get; set; }
		[CProperty(Association ="File:LockedById")]
		public virtual ICollection<File> FileByLockedBy { get; set; }
		[CProperty(Association ="FileLead:LockedById")]
		public virtual ICollection<FileLead> FileLeadByLockedBy { get; set; }
		[CProperty(Association ="GeneratedWebForm:OwnerId")]
		public virtual ICollection<GeneratedWebForm> GeneratedWebFormByOwner { get; set; }
		[CProperty(Association ="GeneratedWebFormFile:LockedById")]
		public virtual ICollection<GeneratedWebFormFile> GeneratedWebFormFileByLockedBy { get; set; }
		[CProperty(Association ="GuidedLearning:TrainerId")]
		public virtual ICollection<GuidedLearning> GuidedLearningByTrainer { get; set; }
		[CProperty(Association ="GuidedLearningFile:LockedById")]
		public virtual ICollection<GuidedLearningFile> GuidedLearningFileByLockedBy { get; set; }
		[CProperty(Association ="GuidedLearningParticipants:ContactId")]
		public virtual ICollection<GuidedLearningParticipants> GuidedLearningParticipantsByContact { get; set; }
		[CProperty(Association ="Invoice:OwnerId")]
		public virtual ICollection<Invoice> InvoiceByOwner { get; set; }
		[CProperty(Association ="Invoice:ContactId")]
		public virtual ICollection<Invoice> InvoiceByContact { get; set; }
		[CProperty(Association ="InvoiceFile:LockedById")]
		public virtual ICollection<InvoiceFile> InvoiceFileByLockedBy { get; set; }
		[CProperty(Association ="InvoiceVisa:SetById")]
		public virtual ICollection<InvoiceVisa> InvoiceVisaBySetBy { get; set; }
		[CProperty(Association ="KnowledgeBaseFile:LockedById")]
		public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFileByLockedBy { get; set; }
		[CProperty(Association ="Lead:QualifiedContactId")]
		public virtual ICollection<Lead> LeadByQualifiedContact { get; set; }
		[CProperty(Association ="Lead:OwnerId")]
		public virtual ICollection<Lead> LeadByOwner { get; set; }
		[CProperty(Association ="Lead:SalesOwnerId")]
		public virtual ICollection<Lead> LeadBySalesOwner { get; set; }
		[CProperty(Association ="Lead:PartnerOwnerId")]
		public virtual ICollection<Lead> LeadByPartnerOwner { get; set; }
		[CProperty(Association ="LeadInQualifyStatus:OwnerId")]
		public virtual ICollection<LeadInQualifyStatus> LeadInQualifyStatusByOwner { get; set; }
		[CProperty(Association ="LeadQualification:ContactId")]
		public virtual ICollection<LeadQualification> LeadQualificationByContact { get; set; }
		[CProperty(Association ="Like:ContactId")]
		public virtual ICollection<Like> LikeByContact { get; set; }
		[CProperty(Association ="LocationHistory:ContactId")]
		public virtual ICollection<LocationHistory> LocationHistoryByContact { get; set; }
		[CProperty(Association ="MailboxSettingsFile:LockedById")]
		public virtual ICollection<MailboxSettingsFile> MailboxSettingsFileByLockedBy { get; set; }
		[CProperty(Association ="MktgActivity:OwnerId")]
		public virtual ICollection<MktgActivity> MktgActivityByOwner { get; set; }
		[CProperty(Association ="MktgActivityFile:LockedById")]
		public virtual ICollection<MktgActivityFile> MktgActivityFileByLockedBy { get; set; }
		[CProperty(Association ="MLModelFile:LockedById")]
		public virtual ICollection<MLModelFile> MLModelFileByLockedBy { get; set; }
		[CProperty(Association ="OAuth20AppFile:LockedById")]
		public virtual ICollection<OAuth20AppFile> OAuth20AppFileByLockedBy { get; set; }
		[CProperty(Association ="Opportunity:OwnerId")]
		public virtual ICollection<Opportunity> OpportunityByOwner { get; set; }
		[CProperty(Association ="Opportunity:ContactId")]
		public virtual ICollection<Opportunity> OpportunityByContact { get; set; }
		[CProperty(Association ="OpportunityContact:ContactId")]
		public virtual ICollection<OpportunityContact> OpportunityContactByContact { get; set; }
		[CProperty(Association ="OpportunityDepartment:SalesDirectorId")]
		public virtual ICollection<OpportunityDepartment> OpportunityDepartmentBySalesDirector { get; set; }
		[CProperty(Association ="OpportunityFile:LockedById")]
		public virtual ICollection<OpportunityFile> OpportunityFileByLockedBy { get; set; }
		[CProperty(Association ="OpportunityInStage:OwnerId")]
		public virtual ICollection<OpportunityInStage> OpportunityInStageByOwner { get; set; }
		[CProperty(Association ="OpportunityParticipant:ContactId")]
		public virtual ICollection<OpportunityParticipant> OpportunityParticipantByContact { get; set; }
		[CProperty(Association ="OpportunityVisa:SetById")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaBySetBy { get; set; }
		[CProperty(Association ="Order:OwnerId")]
		public virtual ICollection<Order> OrderByOwner { get; set; }
		[CProperty(Association ="Order:ContactId")]
		public virtual ICollection<Order> OrderByContact { get; set; }
		[CProperty(Association ="Order:WorkOwnerId")]
		public virtual ICollection<Order> OrderByWorkOwner { get; set; }
		[CProperty(Association ="OrderFile:LockedById")]
		public virtual ICollection<OrderFile> OrderFileByLockedBy { get; set; }
		[CProperty(Association ="OrderVisa:SetById")]
		public virtual ICollection<OrderVisa> OrderVisaBySetBy { get; set; }
		[CProperty(Association ="PartnershipFile:LockedById")]
		public virtual ICollection<PartnershipFile> PartnershipFileByLockedBy { get; set; }
		[CProperty(Association ="PortalMessageFile:LockedById")]
		public virtual ICollection<PortalMessageFile> PortalMessageFileByLockedBy { get; set; }
		[CProperty(Association ="Problem:AuthorId")]
		public virtual ICollection<Problem> ProblemByAuthor { get; set; }
		[CProperty(Association ="Problem:OwnerId")]
		public virtual ICollection<Problem> ProblemByOwner { get; set; }
		[CProperty(Association ="ProblemFile:LockedById")]
		public virtual ICollection<ProblemFile> ProblemFileByLockedBy { get; set; }
		[CProperty(Association ="Product:OwnerId")]
		public virtual ICollection<Product> ProductByOwner { get; set; }
		[CProperty(Association ="ProductFile:LockedById")]
		public virtual ICollection<ProductFile> ProductFileByLockedBy { get; set; }
		[CProperty(Association ="Project:ContactId")]
		public virtual ICollection<Project> ProjectByContact { get; set; }
		[CProperty(Association ="Project:OwnerId")]
		public virtual ICollection<Project> ProjectByOwner { get; set; }
		[CProperty(Association ="ProjectFile:LockedById")]
		public virtual ICollection<ProjectFile> ProjectFileByLockedBy { get; set; }
		[CProperty(Association ="ProjectResourceElement:ContactId")]
		public virtual ICollection<ProjectResourceElement> ProjectResourceElementByContact { get; set; }
		[CProperty(Association ="QandA:TrainerId")]
		public virtual ICollection<QandA> QandAByTrainer { get; set; }
		[CProperty(Association ="QandAFile:LockedById")]
		public virtual ICollection<QandAFile> QandAFileByLockedBy { get; set; }
		[CProperty(Association ="QueueItem:OperatorId")]
		public virtual ICollection<QueueItem> QueueItemByOperator { get; set; }
		[CProperty(Association ="QueueOperator:OperatorId")]
		public virtual ICollection<QueueOperator> QueueOperatorByOperator { get; set; }
		[CProperty(Association ="QuickDialUserSettings:ContactId")]
		public virtual ICollection<QuickDialUserSettings> QuickDialUserSettingsByContact { get; set; }
		[CProperty(Association ="Relationship:ContactAId")]
		public virtual ICollection<Relationship> RelationshipByContactA { get; set; }
		[CProperty(Association ="Relationship:ContactBId")]
		public virtual ICollection<Relationship> RelationshipByContactB { get; set; }
		[CProperty(Association ="ReleaseFile:LockedById")]
		public virtual ICollection<ReleaseFile> ReleaseFileByLockedBy { get; set; }
		[CProperty(Association ="Reminding:AuthorId")]
		public virtual ICollection<Reminding> RemindingByAuthor { get; set; }
		[CProperty(Association ="Reminding:ContactId")]
		public virtual ICollection<Reminding> RemindingByContact { get; set; }
		[CProperty(Association ="ServiceItem:OwnerId")]
		public virtual ICollection<ServiceItem> ServiceItemByOwner { get; set; }
		[CProperty(Association ="ServiceItemFile:LockedById")]
		public virtual ICollection<ServiceItemFile> ServiceItemFileByLockedBy { get; set; }
		[CProperty(Association ="ServiceObject:ContactId")]
		public virtual ICollection<ServiceObject> ServiceObjectByContact { get; set; }
		[CProperty(Association ="ServicePact:OwnerId")]
		public virtual ICollection<ServicePact> ServicePactByOwner { get; set; }
		[CProperty(Association ="ServicePact:ServiceProviderContactId")]
		public virtual ICollection<ServicePact> ServicePactByServiceProviderContact { get; set; }
		[CProperty(Association ="ServicePactFile:LockedById")]
		public virtual ICollection<ServicePactFile> ServicePactFileByLockedBy { get; set; }
		[CProperty(Association ="SiteEvent:ContactId")]
		public virtual ICollection<SiteEvent> SiteEventByContact { get; set; }
		[CProperty(Association ="SiteEventTypeFile:LockedById")]
		public virtual ICollection<SiteEventTypeFile> SiteEventTypeFileByLockedBy { get; set; }
		[CProperty(Association ="SocialMention:ContactId")]
		public virtual ICollection<SocialMention> SocialMentionByContact { get; set; }
		[CProperty(Association ="SqlConsoleLog:ContactId")]
		public virtual ICollection<SqlConsoleLog> SqlConsoleLogByContact { get; set; }
		[CProperty(Association ="SysAdminUnit:ContactId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByContact { get; set; }
		[CProperty(Association ="SysGridPageView:OwnerId")]
		public virtual ICollection<SysGridPageView> SysGridPageViewByOwner { get; set; }
		[CProperty(Association ="SysOperationAudit:OwnerId")]
		public virtual ICollection<SysOperationAudit> SysOperationAuditByOwner { get; set; }
		[CProperty(Association ="SysOperationAuditArch:OwnerId")]
		public virtual ICollection<SysOperationAuditArch> SysOperationAuditArchByOwner { get; set; }
		[CProperty(Association ="SysPrcElHistoryLog:OwnerId")]
		public virtual ICollection<SysPrcElHistoryLog> SysPrcElHistoryLogByOwner { get; set; }
		[CProperty(Association ="SysPrcHistoryLog:OwnerId")]
		public virtual ICollection<SysPrcHistoryLog> SysPrcHistoryLogByOwner { get; set; }
		[CProperty(Association ="SysProcessData:OwnerId")]
		public virtual ICollection<SysProcessData> SysProcessDataByOwner { get; set; }
		[CProperty(Association ="SysProcessElementData:OwnerId")]
		public virtual ICollection<SysProcessElementData> SysProcessElementDataByOwner { get; set; }
		[CProperty(Association ="SysProcessElementLog:OwnerId")]
		public virtual ICollection<SysProcessElementLog> SysProcessElementLogByOwner { get; set; }
		[CProperty(Association ="SysProcessLog:OwnerId")]
		public virtual ICollection<SysProcessLog> SysProcessLogByOwner { get; set; }
		[CProperty(Association ="SysProfileData:ContactId")]
		public virtual ICollection<SysProfileData> SysProfileDataByContact { get; set; }
		[CProperty(Association ="SysRegistrationData:ContactId")]
		public virtual ICollection<SysRegistrationData> SysRegistrationDataByContact { get; set; }
		[CProperty(Association ="tsaTerm:tsaTermOwnerAcaId")]
		public virtual ICollection<tsaTerm> tsaTermBytsaTermOwnerAca { get; set; }
		[CProperty(Association ="tsaTerm:tsaTermOwnerRnDId")]
		public virtual ICollection<tsaTerm> tsaTermBytsaTermOwnerRnD { get; set; }
		[CProperty(Association ="tsaTermFile:LockedById")]
		public virtual ICollection<tsaTermFile> tsaTermFileByLockedBy { get; set; }
		[CProperty(Association ="tsaTermTranslationFile:LockedById")]
		public virtual ICollection<tsaTermTranslationFile> tsaTermTranslationFileByLockedBy { get; set; }
		[CProperty(Association ="tsaTermVisa:SetById")]
		public virtual ICollection<tsaTermVisa> tsaTermVisaBySetBy { get; set; }
		[CProperty(Association ="VwAccountRelationship:RelatedContactId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByRelatedContact { get; set; }
		[CProperty(Association ="VwAnniversary:ContactId")]
		public virtual ICollection<VwAnniversary> VwAnniversaryByContact { get; set; }
		[CProperty(Association ="VwBulkEmailClickedLink:ContactId")]
		public virtual ICollection<VwBulkEmailClickedLink> VwBulkEmailClickedLinkByContact { get; set; }
		[CProperty(Association ="VwContactDuplicate:Entity1Id")]
		public virtual ICollection<VwContactDuplicate> VwContactDuplicateByEntity1 { get; set; }
		[CProperty(Association ="VwContactDuplicate:Entity2Id")]
		public virtual ICollection<VwContactDuplicate> VwContactDuplicateByEntity2 { get; set; }
		[CProperty(Association ="VwContactModuleHistory:ContactId")]
		public virtual ICollection<VwContactModuleHistory> VwContactModuleHistoryByContact { get; set; }
		[CProperty(Association ="VwContactRelationship:ContactId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByContact { get; set; }
		[CProperty(Association ="VwContactRelationship:RelatedContactId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByRelatedContact { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:ContactId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByContact { get; set; }
		[CProperty(Association ="VwMandrillRecipient:ContactId")]
		public virtual ICollection<VwMandrillRecipient> VwMandrillRecipientByContact { get; set; }
		[CProperty(Association ="VwMandrillRecipientV2:ContactId")]
		public virtual ICollection<VwMandrillRecipientV2> VwMandrillRecipientV2ByContact { get; set; }
		[CProperty(Association ="VwModuleHistory:ContactId")]
		public virtual ICollection<VwModuleHistory> VwModuleHistoryByContact { get; set; }
		[CProperty(Association ="VwOpportInStageForAnalysis:OwnerId")]
		public virtual ICollection<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisByOwner { get; set; }
		[CProperty(Association ="VwOpportunityInStage:OwnerId")]
		public virtual ICollection<VwOpportunityInStage> VwOpportunityInStageByOwner { get; set; }
		[CProperty(Association ="VwPortalOpportunity:OwnerId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByOwner { get; set; }
		[CProperty(Association ="VwProcessDashboard:OwnerId")]
		public virtual ICollection<VwProcessDashboard> VwProcessDashboardByOwner { get; set; }
		[CProperty(Association ="VwProcessDashboard:ElementOwnerId")]
		public virtual ICollection<VwProcessDashboard> VwProcessDashboardByElementOwner { get; set; }
		[CProperty(Association ="VwProcessDashboard:ProcessOwnerId")]
		public virtual ICollection<VwProcessDashboard> VwProcessDashboardByProcessOwner { get; set; }
		[CProperty(Association ="VwProcessLibFile:LockedById")]
		public virtual ICollection<VwProcessLibFile> VwProcessLibFileByLockedBy { get; set; }
		[CProperty(Association ="VwQueueItem:OperatorId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByOperator { get; set; }
		[CProperty(Association ="VwQueueItem:ContactId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByContact { get; set; }
		[CProperty(Association ="VwRelationship:ContactAId")]
		public virtual ICollection<VwRelationship> VwRelationshipByContactA { get; set; }
		[CProperty(Association ="VwRelationship:ContactBId")]
		public virtual ICollection<VwRelationship> VwRelationshipByContactB { get; set; }
		[CProperty(Association ="VwRemindings:ContactId")]
		public virtual ICollection<VwRemindings> VwRemindingsByContact { get; set; }
		[CProperty(Association ="VwRemindingsCount:ContactId")]
		public virtual ICollection<VwRemindingsCount> VwRemindingsCountByContact { get; set; }
		[CProperty(Association ="VwServiceRecepients:ContactId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByContact { get; set; }
		[CProperty(Association ="VwSiteEvent:ContactId")]
		public virtual ICollection<VwSiteEvent> VwSiteEventByContact { get; set; }
		[CProperty(Association ="VwSspAdminUnit:ContactId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByContact { get; set; }
		[CProperty(Association ="VwSysAdminUnit:ContactId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByContact { get; set; }
		[CProperty(Association ="ERROR")]
		public virtual ICollection<VwSysContactLcz_RU> VwSysContactLczByRUByRecord { get; set; }
		[CProperty(Association ="VwSysProcessElementLog:OwnerId")]
		public virtual ICollection<VwSysProcessElementLog> VwSysProcessElementLogByOwner { get; set; }
		[CProperty(Association ="VwSysProcessFile:LockedById")]
		public virtual ICollection<VwSysProcessFile> VwSysProcessFileByLockedBy { get; set; }
		[CProperty(Association ="VwSysProcessLog:OwnerId")]
		public virtual ICollection<VwSysProcessLog> VwSysProcessLogByOwner { get; set; }
		[CProperty(Association ="VwSystemUsers:ContactId")]
		public virtual ICollection<VwSystemUsers> VwSystemUsersByContact { get; set; }
		[CProperty(Association ="VwVisa:SetById")]
		public virtual ICollection<VwVisa> VwVisaBySetBy { get; set; }
		[CProperty(Association ="WebServiceV2File:LockedById")]
		public virtual ICollection<WebServiceV2File> WebServiceV2FileByLockedBy { get; set; }
		[CProperty(Association ="WSysAccount:ContactId")]
		public virtual ICollection<WSysAccount> WSysAccountByContact { get; set; }
		#endregion
	}
}
