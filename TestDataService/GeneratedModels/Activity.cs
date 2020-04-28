using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Activity")]
	public class Activity : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ActivityCategoryId")]
		public Guid ActivityCategoryId { get; set; }
		[CProperty(ColumnPath ="ActivityConnectionId")]
		public Guid ActivityConnectionId { get; set; }
		[CProperty(ColumnPath ="ActualFinishDate")]
		public DateTime ActualFinishDate { get; set; }
		[CProperty(ColumnPath ="AdditionalNeed")]
		public string AdditionalNeed { get; set; }
		[CProperty(ColumnPath ="AllowedResult")]
		public string AllowedResult { get; set; }
		[CProperty(ColumnPath ="ApplicantId")]
		public Guid ApplicantId { get; set; }
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId { get; set; }
		[CProperty(ColumnPath ="BlindCopyRecepient")]
		public string BlindCopyRecepient { get; set; }
		[CProperty(ColumnPath ="Body")]
		public string Body { get; set; }
		[CProperty(ColumnPath ="CallDirectionId")]
		public Guid CallDirectionId { get; set; }
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath ="ChangeId")]
		public Guid ChangeId { get; set; }
		[CProperty(ColumnPath ="CIId")]
		public Guid CIId { get; set; }
		[CProperty(ColumnPath ="ConferenceRoomId")]
		public Guid ConferenceRoomId { get; set; }
		[CProperty(ColumnPath ="Confirmed")]
		public bool Confirmed { get; set; }
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId { get; set; }
		[CProperty(ColumnPath ="CopyRecepient")]
		public string CopyRecepient { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedByInvCRM")]
		public bool CreatedByInvCRM { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DeliveryId")]
		public Guid DeliveryId { get; set; }
		[CProperty(ColumnPath ="DetailedResult")]
		public string DetailedResult { get; set; }
		[CProperty(ColumnPath ="DocumentId")]
		public Guid DocumentId { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="DurationInMinutes")]
		public int DurationInMinutes { get; set; }
		[CProperty(ColumnPath ="DurationInMnutesAndHours")]
		public string DurationInMnutesAndHours { get; set; }
		[CProperty(ColumnPath ="EmailSendStatusId")]
		public Guid EmailSendStatusId { get; set; }
		[CProperty(ColumnPath ="EnrchEmailDataId")]
		public Guid EnrchEmailDataId { get; set; }
		[CProperty(ColumnPath ="EnrichStatus")]
		public string EnrichStatus { get; set; }
		[CProperty(ColumnPath ="ErrorOnSend")]
		public string ErrorOnSend { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="FullProjectName")]
		public string FullProjectName { get; set; }
		[CProperty(ColumnPath ="GlbGlbCustomerId")]
		public Guid GlbGlbCustomerId { get; set; }
		[CProperty(ColumnPath ="GlobalActivityID")]
		public string GlobalActivityID { get; set; }
		[CProperty(ColumnPath ="HeaderProperties")]
		public string HeaderProperties { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId { get; set; }
		[CProperty(ColumnPath ="InvestorId")]
		public Guid InvestorId { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="IQIQSetRightsId")]
		public Guid IQIQSetRightsId { get; set; }
		[CProperty(ColumnPath ="IsAutoSubmitted")]
		public bool IsAutoSubmitted { get; set; }
		[CProperty(ColumnPath ="IsHtmlBody")]
		public bool IsHtmlBody { get; set; }
		[CProperty(ColumnPath ="IsNeedProcess")]
		public bool IsNeedProcess { get; set; }
		[CProperty(ColumnPath ="IsNotPublished")]
		public bool IsNotPublished { get; set; }
		[CProperty(ColumnPath ="JiraURL")]
		public string JiraURL { get; set; }
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="Location")]
		public string Location { get; set; }
		[CProperty(ColumnPath ="MailHash")]
		public string MailHash { get; set; }
		[CProperty(ColumnPath ="MarketplaceApplicationId")]
		public Guid MarketplaceApplicationId { get; set; }
		[CProperty(ColumnPath ="MessageTypeId")]
		public Guid MessageTypeId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="NeedFlipchart")]
		public bool NeedFlipchart { get; set; }
		[CProperty(ColumnPath ="NeedWater")]
		public bool NeedWater { get; set; }
		[CProperty(ColumnPath ="NextStep")]
		public int NextStep { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OpportunityForecastId")]
		public Guid OpportunityForecastId { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OrganizerId")]
		public Guid OrganizerId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId { get; set; }
		[CProperty(ColumnPath ="PDEKnowledgeBaseId")]
		public Guid PDEKnowledgeBaseId { get; set; }
		[CProperty(ColumnPath ="Preview")]
		public string Preview { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProblemId")]
		public Guid ProblemId { get; set; }
		[CProperty(ColumnPath ="ProcessElementId")]
		public Guid ProcessElementId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="QueueId")]
		public Guid QueueId { get; set; }
		[CProperty(ColumnPath ="QueueItemId")]
		public Guid QueueItemId { get; set; }
		[CProperty(ColumnPath ="Recepient")]
		public string Recepient { get; set; }
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId { get; set; }
		[CProperty(ColumnPath ="RemindToAuthor")]
		public bool RemindToAuthor { get; set; }
		[CProperty(ColumnPath ="RemindToAuthorDate")]
		public DateTime RemindToAuthorDate { get; set; }
		[CProperty(ColumnPath ="RemindToOwner")]
		public bool RemindToOwner { get; set; }
		[CProperty(ColumnPath ="RemindToOwnerDate")]
		public DateTime RemindToOwnerDate { get; set; }
		[CProperty(ColumnPath ="Request3X")]
		public string Request3X { get; set; }
		[CProperty(ColumnPath ="Request7X")]
		public string Request7X { get; set; }
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId { get; set; }
		[CProperty(ColumnPath ="SendDate")]
		public DateTime SendDate { get; set; }
		[CProperty(ColumnPath ="Sender")]
		public string Sender { get; set; }
		[CProperty(ColumnPath ="SenderContactId")]
		public Guid SenderContactId { get; set; }
		[CProperty(ColumnPath ="ServiceProcessed")]
		public bool ServiceProcessed { get; set; }
		[CProperty(ColumnPath ="ShowInScheduler")]
		public bool ShowInScheduler { get; set; }
		[CProperty(ColumnPath ="SiteDomainId")]
		public Guid SiteDomainId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId { get; set; }
		[CProperty(ColumnPath ="Title")]
		public string Title { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UserEmailAddress")]
		public string UserEmailAddress { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Activity:ActivityConnectionId")]
		public Activity ActivityConnection { get; set; }
		[CProperty(Navigation ="ActivityCategory:ActivityCategoryId")]
		public ActivityCategory ActivityCategory { get; set; }
		[CProperty(Navigation ="ActivityKind:KindId")]
		public ActivityKind Kind { get; set; }
		[CProperty(Navigation ="ActivityPriority:PriorityId")]
		public ActivityPriority Priority { get; set; }
		[CProperty(Navigation ="ActivityResult:ResultId")]
		public ActivityResult Result { get; set; }
		[CProperty(Navigation ="ActivityStatus:StatusId")]
		public ActivityStatus Status { get; set; }
		[CProperty(Navigation ="ActivityType:TypeId")]
		public ActivityType Type { get; set; }
		[CProperty(Navigation ="Applicant:ApplicantId")]
		public Applicant Applicant { get; set; }
		[CProperty(Navigation ="CallDirection:CallDirectionId")]
		public CallDirection CallDirection { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation ="Change:ChangeId")]
		public Change Change { get; set; }
		[CProperty(Navigation ="CI:CIId")]
		public CI CI { get; set; }
		[CProperty(Navigation ="ConferenceRoom:ConferenceRoomId")]
		public ConferenceRoom ConferenceRoom { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OrganizerId")]
		public Contact Organizer { get; set; }
		[CProperty(Navigation ="Contact:SenderContactId")]
		public Contact SenderContact { get; set; }
		[CProperty(Navigation ="Contract:ContractId")]
		public Contract Contract { get; set; }
		[CProperty(Navigation ="Document:DocumentId")]
		public Document Document { get; set; }
		[CProperty(Navigation ="EmailSendStatus:EmailSendStatusId")]
		public EmailSendStatus EmailSendStatus { get; set; }
		[CProperty(Navigation ="EmailType:MessageTypeId")]
		public EmailType MessageType { get; set; }
		[CProperty(Navigation ="EnrchEmailData:EnrchEmailDataId")]
		public EnrchEmailData EnrchEmailData { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="GlbCustomer:GlbGlbCustomerId")]
		public GlbCustomer GlbGlbCustomer { get; set; }
		[CProperty(Navigation ="InternalRequest:InternalRequestId")]
		public InternalRequest InternalRequest { get; set; }
		[CProperty(Navigation ="Investor:InvestorId")]
		public Investor Investor { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="IQSetRights:IQIQSetRightsId")]
		public IQSetRights IQIQSetRights { get; set; }
		[CProperty(Navigation ="KnowledgeBase:PDEKnowledgeBaseId")]
		public KnowledgeBase PDEKnowledgeBase { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="MarketplaceApplication:MarketplaceApplicationId")]
		public MarketplaceApplication MarketplaceApplication { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityForecast:OpportunityForecastId")]
		public OpportunityForecast OpportunityForecast { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="Partnership:PartnershipId")]
		public Partnership Partnership { get; set; }
		[CProperty(Navigation ="Problem:ProblemId")]
		public Problem Problem { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="Queue:QueueId")]
		public Queue Queue { get; set; }
		[CProperty(Navigation ="Release:ReleaseId")]
		public Release Release { get; set; }
		[CProperty(Navigation ="SiteDomain:SiteDomainId")]
		public SiteDomain SiteDomain { get; set; }
		[CProperty(Navigation ="SupplyPaymentElement:DeliveryId")]
		public SupplyPaymentElement Delivery { get; set; }
		[CProperty(Navigation ="TimeZone:TimeZoneId")]
		public TimeZone TimeZone { get; set; }
		[CProperty(Navigation ="VwQueueItem:QueueItemId")]
		public VwQueueItem QueueItem { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ActivityConnectionId")]
		public virtual ICollection<Activity> ActivityByActivityConnection { get; set; }
		[CProperty(Association ="ActivityCorrespondence:ActivityId")]
		public virtual ICollection<ActivityCorrespondence> ActivityCorrespondenceByActivity { get; set; }
		[CProperty(Association ="ActivityFile:ActivityId")]
		public virtual ICollection<ActivityFile> ActivityFileByActivity { get; set; }
		[CProperty(Association ="ActivityInFolder:ActivityId")]
		public virtual ICollection<ActivityInFolder> ActivityInFolderByActivity { get; set; }
		[CProperty(Association ="ActivityInTag:EntityId")]
		public virtual ICollection<ActivityInTag> ActivityInTagByEntity { get; set; }
		[CProperty(Association ="ActivityParticipant:ActivityId")]
		public virtual ICollection<ActivityParticipant> ActivityParticipantByActivity { get; set; }
		[CProperty(Association ="ActivityVisa:ActivityId")]
		public virtual ICollection<ActivityVisa> ActivityVisaByActivity { get; set; }
		[CProperty(Association ="Call:ActivityId")]
		public virtual ICollection<Call> CallByActivity { get; set; }
		[CProperty(Association ="Case:ParentActivityId")]
		public virtual ICollection<Case> CaseByParentActivity { get; set; }
		[CProperty(Association ="EmailMessageData:ActivityId")]
		public virtual ICollection<EmailMessageData> EmailMessageDataByActivity { get; set; }
		[CProperty(Association ="EmailRelation:EmailId")]
		public virtual ICollection<EmailRelation> EmailRelationByEmail { get; set; }
		[CProperty(Association ="EmailTemplateActivity:ActivityId")]
		public virtual ICollection<EmailTemplateActivity> EmailTemplateActivityByActivity { get; set; }
		[CProperty(Association ="InvestorComment:ActivityId")]
		public virtual ICollection<InvestorComment> InvestorCommentByActivity { get; set; }
		[CProperty(Association ="LeadInStage:MeetingId")]
		public virtual ICollection<LeadInStage> LeadInStageByMeeting { get; set; }
		[CProperty(Association ="PsDeliveryActivity:ActivityId")]
		public virtual ICollection<PsDeliveryActivity> PsDeliveryActivityByActivity { get; set; }
		[CProperty(Association ="QueueItem:CurrentActivityId")]
		public virtual ICollection<QueueItem> QueueItemByCurrentActivity { get; set; }
		[CProperty(Association ="VwLastActivityByQueue:ActivityId")]
		public virtual ICollection<VwLastActivityByQueue> VwLastActivityByQueueByActivity { get; set; }
		[CProperty(Association ="VwQueueItem:CurrentActivityId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByCurrentActivity { get; set; }
		[CProperty(Association ="VwQueueItem:LastActivityId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByLastActivity { get; set; }
		[CProperty(Association ="VwQueueItemSuper:CurrentActivityId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByCurrentActivity { get; set; }
		[CProperty(Association ="VwQueueItemSuper:LastActivityId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByLastActivity { get; set; }
		#endregion
	}
}
