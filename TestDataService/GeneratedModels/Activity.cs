using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Activity")]
	public class Activity : BaseEntity
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
		private Guid _ActivityCategoryId;
		[CProperty(ColumnPath ="ActivityCategoryId")]
		public Guid ActivityCategoryId
		{
			get{return _ActivityCategoryId;}
			set
			{
				_ActivityCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ActivityConnectionId;
		[CProperty(ColumnPath ="ActivityConnectionId")]
		public Guid ActivityConnectionId
		{
			get{return _ActivityConnectionId;}
			set
			{
				_ActivityConnectionId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ActualFinishDate;
		[CProperty(ColumnPath ="ActualFinishDate")]
		public DateTime ActualFinishDate
		{
			get{return _ActualFinishDate;}
			set
			{
				_ActualFinishDate = value;
				OnPropertyChanged();
			}
		}
		private string _AdditionalNeed;
		[CProperty(ColumnPath ="AdditionalNeed")]
		public string AdditionalNeed
		{
			get{return _AdditionalNeed;}
			set
			{
				_AdditionalNeed = value;
				OnPropertyChanged();
			}
		}
		private string _AllowedResult;
		[CProperty(ColumnPath ="AllowedResult")]
		public string AllowedResult
		{
			get{return _AllowedResult;}
			set
			{
				_AllowedResult = value;
				OnPropertyChanged();
			}
		}
		private Guid _ApplicantId;
		[CProperty(ColumnPath ="ApplicantId")]
		public Guid ApplicantId
		{
			get{return _ApplicantId;}
			set
			{
				_ApplicantId = value;
				OnPropertyChanged();
			}
		}
		private Guid _AuthorId;
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId
		{
			get{return _AuthorId;}
			set
			{
				_AuthorId = value;
				OnPropertyChanged();
			}
		}
		private string _BlindCopyRecepient;
		[CProperty(ColumnPath ="BlindCopyRecepient")]
		public string BlindCopyRecepient
		{
			get{return _BlindCopyRecepient;}
			set
			{
				_BlindCopyRecepient = value;
				OnPropertyChanged();
			}
		}
		private string _Body;
		[CProperty(ColumnPath ="Body")]
		public string Body
		{
			get{return _Body;}
			set
			{
				_Body = value;
				OnPropertyChanged();
			}
		}
		private Guid _CallDirectionId;
		[CProperty(ColumnPath ="CallDirectionId")]
		public Guid CallDirectionId
		{
			get{return _CallDirectionId;}
			set
			{
				_CallDirectionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseId;
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId
		{
			get{return _CaseId;}
			set
			{
				_CaseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChangeId;
		[CProperty(ColumnPath ="ChangeId")]
		public Guid ChangeId
		{
			get{return _ChangeId;}
			set
			{
				_ChangeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CIId;
		[CProperty(ColumnPath ="CIId")]
		public Guid CIId
		{
			get{return _CIId;}
			set
			{
				_CIId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConferenceRoomId;
		[CProperty(ColumnPath ="ConferenceRoomId")]
		public Guid ConferenceRoomId
		{
			get{return _ConferenceRoomId;}
			set
			{
				_ConferenceRoomId = value;
				OnPropertyChanged();
			}
		}
		private bool _Confirmed;
		[CProperty(ColumnPath ="Confirmed")]
		public bool Confirmed
		{
			get{return _Confirmed;}
			set
			{
				_Confirmed = value;
				OnPropertyChanged();
			}
		}
		private Guid _ConfItemId;
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId
		{
			get{return _ConfItemId;}
			set
			{
				_ConfItemId = value;
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
		private Guid _ContractId;
		[CProperty(ColumnPath ="ContractId")]
		public Guid ContractId
		{
			get{return _ContractId;}
			set
			{
				_ContractId = value;
				OnPropertyChanged();
			}
		}
		private string _CopyRecepient;
		[CProperty(ColumnPath ="CopyRecepient")]
		public string CopyRecepient
		{
			get{return _CopyRecepient;}
			set
			{
				_CopyRecepient = value;
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
		private bool _CreatedByInvCRM;
		[CProperty(ColumnPath ="CreatedByInvCRM")]
		public bool CreatedByInvCRM
		{
			get{return _CreatedByInvCRM;}
			set
			{
				_CreatedByInvCRM = value;
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
		private Guid _DeliveryId;
		[CProperty(ColumnPath ="DeliveryId")]
		public Guid DeliveryId
		{
			get{return _DeliveryId;}
			set
			{
				_DeliveryId = value;
				OnPropertyChanged();
			}
		}
		private string _DetailedResult;
		[CProperty(ColumnPath ="DetailedResult")]
		public string DetailedResult
		{
			get{return _DetailedResult;}
			set
			{
				_DetailedResult = value;
				OnPropertyChanged();
			}
		}
		private Guid _DocumentId;
		[CProperty(ColumnPath ="DocumentId")]
		public Guid DocumentId
		{
			get{return _DocumentId;}
			set
			{
				_DocumentId = value;
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
		private int _DurationInMinutes;
		[CProperty(ColumnPath ="DurationInMinutes")]
		public int DurationInMinutes
		{
			get{return _DurationInMinutes;}
			set
			{
				_DurationInMinutes = value;
				OnPropertyChanged();
			}
		}
		private string _DurationInMnutesAndHours;
		[CProperty(ColumnPath ="DurationInMnutesAndHours")]
		public string DurationInMnutesAndHours
		{
			get{return _DurationInMnutesAndHours;}
			set
			{
				_DurationInMnutesAndHours = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmailSendStatusId;
		[CProperty(ColumnPath ="EmailSendStatusId")]
		public Guid EmailSendStatusId
		{
			get{return _EmailSendStatusId;}
			set
			{
				_EmailSendStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EnrchEmailDataId;
		[CProperty(ColumnPath ="EnrchEmailDataId")]
		public Guid EnrchEmailDataId
		{
			get{return _EnrchEmailDataId;}
			set
			{
				_EnrchEmailDataId = value;
				OnPropertyChanged();
			}
		}
		private string _EnrichStatus;
		[CProperty(ColumnPath ="EnrichStatus")]
		public string EnrichStatus
		{
			get{return _EnrichStatus;}
			set
			{
				_EnrichStatus = value;
				OnPropertyChanged();
			}
		}
		private string _ErrorOnSend;
		[CProperty(ColumnPath ="ErrorOnSend")]
		public string ErrorOnSend
		{
			get{return _ErrorOnSend;}
			set
			{
				_ErrorOnSend = value;
				OnPropertyChanged();
			}
		}
		private Guid _EventId;
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId
		{
			get{return _EventId;}
			set
			{
				_EventId = value;
				OnPropertyChanged();
			}
		}
		private string _FullProjectName;
		[CProperty(ColumnPath ="FullProjectName")]
		public string FullProjectName
		{
			get{return _FullProjectName;}
			set
			{
				_FullProjectName = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbGlbCustomerId;
		[CProperty(ColumnPath ="GlbGlbCustomerId")]
		public Guid GlbGlbCustomerId
		{
			get{return _GlbGlbCustomerId;}
			set
			{
				_GlbGlbCustomerId = value;
				OnPropertyChanged();
			}
		}
		private string _GlobalActivityID;
		[CProperty(ColumnPath ="GlobalActivityID")]
		public string GlobalActivityID
		{
			get{return _GlobalActivityID;}
			set
			{
				_GlobalActivityID = value;
				OnPropertyChanged();
			}
		}
		private string _HeaderProperties;
		[CProperty(ColumnPath ="HeaderProperties")]
		public string HeaderProperties
		{
			get{return _HeaderProperties;}
			set
			{
				_HeaderProperties = value;
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
		private Guid _InternalRequestId;
		[CProperty(ColumnPath ="InternalRequestId")]
		public Guid InternalRequestId
		{
			get{return _InternalRequestId;}
			set
			{
				_InternalRequestId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InvestorId;
		[CProperty(ColumnPath ="InvestorId")]
		public Guid InvestorId
		{
			get{return _InvestorId;}
			set
			{
				_InvestorId = value;
				OnPropertyChanged();
			}
		}
		private Guid _InvoiceId;
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId
		{
			get{return _InvoiceId;}
			set
			{
				_InvoiceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _IQIQSetRightsId;
		[CProperty(ColumnPath ="IQIQSetRightsId")]
		public Guid IQIQSetRightsId
		{
			get{return _IQIQSetRightsId;}
			set
			{
				_IQIQSetRightsId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsAutoSubmitted;
		[CProperty(ColumnPath ="IsAutoSubmitted")]
		public bool IsAutoSubmitted
		{
			get{return _IsAutoSubmitted;}
			set
			{
				_IsAutoSubmitted = value;
				OnPropertyChanged();
			}
		}
		private bool _IsHtmlBody;
		[CProperty(ColumnPath ="IsHtmlBody")]
		public bool IsHtmlBody
		{
			get{return _IsHtmlBody;}
			set
			{
				_IsHtmlBody = value;
				OnPropertyChanged();
			}
		}
		private bool _IsNeedProcess;
		[CProperty(ColumnPath ="IsNeedProcess")]
		public bool IsNeedProcess
		{
			get{return _IsNeedProcess;}
			set
			{
				_IsNeedProcess = value;
				OnPropertyChanged();
			}
		}
		private bool _IsNotPublished;
		[CProperty(ColumnPath ="IsNotPublished")]
		public bool IsNotPublished
		{
			get{return _IsNotPublished;}
			set
			{
				_IsNotPublished = value;
				OnPropertyChanged();
			}
		}
		private string _JiraURL;
		[CProperty(ColumnPath ="JiraURL")]
		public string JiraURL
		{
			get{return _JiraURL;}
			set
			{
				_JiraURL = value;
				OnPropertyChanged();
			}
		}
		private Guid _KindId;
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId
		{
			get{return _KindId;}
			set
			{
				_KindId = value;
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
		private string _Location;
		[CProperty(ColumnPath ="Location")]
		public string Location
		{
			get{return _Location;}
			set
			{
				_Location = value;
				OnPropertyChanged();
			}
		}
		private string _MailHash;
		[CProperty(ColumnPath ="MailHash")]
		public string MailHash
		{
			get{return _MailHash;}
			set
			{
				_MailHash = value;
				OnPropertyChanged();
			}
		}
		private Guid _MarketplaceApplicationId;
		[CProperty(ColumnPath ="MarketplaceApplicationId")]
		public Guid MarketplaceApplicationId
		{
			get{return _MarketplaceApplicationId;}
			set
			{
				_MarketplaceApplicationId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MessageTypeId;
		[CProperty(ColumnPath ="MessageTypeId")]
		public Guid MessageTypeId
		{
			get{return _MessageTypeId;}
			set
			{
				_MessageTypeId = value;
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
		private bool _NeedFlipchart;
		[CProperty(ColumnPath ="NeedFlipchart")]
		public bool NeedFlipchart
		{
			get{return _NeedFlipchart;}
			set
			{
				_NeedFlipchart = value;
				OnPropertyChanged();
			}
		}
		private bool _NeedWater;
		[CProperty(ColumnPath ="NeedWater")]
		public bool NeedWater
		{
			get{return _NeedWater;}
			set
			{
				_NeedWater = value;
				OnPropertyChanged();
			}
		}
		private int _NextStep;
		[CProperty(ColumnPath ="NextStep")]
		public int NextStep
		{
			get{return _NextStep;}
			set
			{
				_NextStep = value;
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
		private Guid _OpportunityForecastId;
		[CProperty(ColumnPath ="OpportunityForecastId")]
		public Guid OpportunityForecastId
		{
			get{return _OpportunityForecastId;}
			set
			{
				_OpportunityForecastId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrderId;
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId
		{
			get{return _OrderId;}
			set
			{
				_OrderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _OrganizerId;
		[CProperty(ColumnPath ="OrganizerId")]
		public Guid OrganizerId
		{
			get{return _OrganizerId;}
			set
			{
				_OrganizerId = value;
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
		private Guid _PartnershipId;
		[CProperty(ColumnPath ="PartnershipId")]
		public Guid PartnershipId
		{
			get{return _PartnershipId;}
			set
			{
				_PartnershipId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PDEKnowledgeBaseId;
		[CProperty(ColumnPath ="PDEKnowledgeBaseId")]
		public Guid PDEKnowledgeBaseId
		{
			get{return _PDEKnowledgeBaseId;}
			set
			{
				_PDEKnowledgeBaseId = value;
				OnPropertyChanged();
			}
		}
		private string _Preview;
		[CProperty(ColumnPath ="Preview")]
		public string Preview
		{
			get{return _Preview;}
			set
			{
				_Preview = value;
				OnPropertyChanged();
			}
		}
		private Guid _PriorityId;
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId
		{
			get{return _PriorityId;}
			set
			{
				_PriorityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProblemId;
		[CProperty(ColumnPath ="ProblemId")]
		public Guid ProblemId
		{
			get{return _ProblemId;}
			set
			{
				_ProblemId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProcessElementId;
		[CProperty(ColumnPath ="ProcessElementId")]
		public Guid ProcessElementId
		{
			get{return _ProcessElementId;}
			set
			{
				_ProcessElementId = value;
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
		private Guid _ProjectId;
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId
		{
			get{return _ProjectId;}
			set
			{
				_ProjectId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueId;
		[CProperty(ColumnPath ="QueueId")]
		public Guid QueueId
		{
			get{return _QueueId;}
			set
			{
				_QueueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QueueItemId;
		[CProperty(ColumnPath ="QueueItemId")]
		public Guid QueueItemId
		{
			get{return _QueueItemId;}
			set
			{
				_QueueItemId = value;
				OnPropertyChanged();
			}
		}
		private string _Recepient;
		[CProperty(ColumnPath ="Recepient")]
		public string Recepient
		{
			get{return _Recepient;}
			set
			{
				_Recepient = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReleaseId;
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId
		{
			get{return _ReleaseId;}
			set
			{
				_ReleaseId = value;
				OnPropertyChanged();
			}
		}
		private bool _RemindToAuthor;
		[CProperty(ColumnPath ="RemindToAuthor")]
		public bool RemindToAuthor
		{
			get{return _RemindToAuthor;}
			set
			{
				_RemindToAuthor = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RemindToAuthorDate;
		[CProperty(ColumnPath ="RemindToAuthorDate")]
		public DateTime RemindToAuthorDate
		{
			get{return _RemindToAuthorDate;}
			set
			{
				_RemindToAuthorDate = value;
				OnPropertyChanged();
			}
		}
		private bool _RemindToOwner;
		[CProperty(ColumnPath ="RemindToOwner")]
		public bool RemindToOwner
		{
			get{return _RemindToOwner;}
			set
			{
				_RemindToOwner = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RemindToOwnerDate;
		[CProperty(ColumnPath ="RemindToOwnerDate")]
		public DateTime RemindToOwnerDate
		{
			get{return _RemindToOwnerDate;}
			set
			{
				_RemindToOwnerDate = value;
				OnPropertyChanged();
			}
		}
		private string _Request3X;
		[CProperty(ColumnPath ="Request3X")]
		public string Request3X
		{
			get{return _Request3X;}
			set
			{
				_Request3X = value;
				OnPropertyChanged();
			}
		}
		private string _Request7X;
		[CProperty(ColumnPath ="Request7X")]
		public string Request7X
		{
			get{return _Request7X;}
			set
			{
				_Request7X = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResultId;
		[CProperty(ColumnPath ="ResultId")]
		public Guid ResultId
		{
			get{return _ResultId;}
			set
			{
				_ResultId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SendDate;
		[CProperty(ColumnPath ="SendDate")]
		public DateTime SendDate
		{
			get{return _SendDate;}
			set
			{
				_SendDate = value;
				OnPropertyChanged();
			}
		}
		private string _Sender;
		[CProperty(ColumnPath ="Sender")]
		public string Sender
		{
			get{return _Sender;}
			set
			{
				_Sender = value;
				OnPropertyChanged();
			}
		}
		private Guid _SenderContactId;
		[CProperty(ColumnPath ="SenderContactId")]
		public Guid SenderContactId
		{
			get{return _SenderContactId;}
			set
			{
				_SenderContactId = value;
				OnPropertyChanged();
			}
		}
		private bool _ServiceProcessed;
		[CProperty(ColumnPath ="ServiceProcessed")]
		public bool ServiceProcessed
		{
			get{return _ServiceProcessed;}
			set
			{
				_ServiceProcessed = value;
				OnPropertyChanged();
			}
		}
		private bool _ShowInScheduler;
		[CProperty(ColumnPath ="ShowInScheduler")]
		public bool ShowInScheduler
		{
			get{return _ShowInScheduler;}
			set
			{
				_ShowInScheduler = value;
				OnPropertyChanged();
			}
		}
		private Guid _SiteDomainId;
		[CProperty(ColumnPath ="SiteDomainId")]
		public Guid SiteDomainId
		{
			get{return _SiteDomainId;}
			set
			{
				_SiteDomainId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
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
		private Guid _TimeZoneId;
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId
		{
			get{return _TimeZoneId;}
			set
			{
				_TimeZoneId = value;
				OnPropertyChanged();
			}
		}
		private string _Title;
		[CProperty(ColumnPath ="Title")]
		public string Title
		{
			get{return _Title;}
			set
			{
				_Title = value;
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
		private string _UserEmailAddress;
		[CProperty(ColumnPath ="UserEmailAddress")]
		public string UserEmailAddress
		{
			get{return _UserEmailAddress;}
			set
			{
				_UserEmailAddress = value;
				OnPropertyChanged();
			}
		}
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
