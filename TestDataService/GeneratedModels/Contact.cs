using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Contact")]
	public class Contact : BaseEntity
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
		private Guid _AddressTypeId;
		[CProperty(ColumnPath ="AddressTypeId")]
		public Guid AddressTypeId
		{
			get{return _AddressTypeId;}
			set
			{
				_AddressTypeId = value;
				OnPropertyChanged();
			}
		}
		private int _Age;
		[CProperty(ColumnPath ="Age")]
		public int Age
		{
			get{return _Age;}
			set
			{
				_Age = value;
				OnPropertyChanged();
			}
		}
		private DateTime _BirthDate;
		[CProperty(ColumnPath ="BirthDate")]
		public DateTime BirthDate
		{
			get{return _BirthDate;}
			set
			{
				_BirthDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmManageDataPrivacyId;
		[CProperty(ColumnPath ="BpmManageDataPrivacyId")]
		public Guid BpmManageDataPrivacyId
		{
			get{return _BpmManageDataPrivacyId;}
			set
			{
				_BpmManageDataPrivacyId = value;
				OnPropertyChanged();
			}
		}
		private string _BulkEmailConfItems;
		[CProperty(ColumnPath ="BulkEmailConfItems")]
		public string BulkEmailConfItems
		{
			get{return _BulkEmailConfItems;}
			set
			{
				_BulkEmailConfItems = value;
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
		private int _Completeness;
		[CProperty(ColumnPath ="Completeness")]
		public int Completeness
		{
			get{return _Completeness;}
			set
			{
				_Completeness = value;
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
		private byte[] _ContactPhoto;
		[CProperty(ColumnPath ="ContactPhoto")]
		public byte[] ContactPhoto
		{
			get{return _ContactPhoto;}
			set
			{
				_ContactPhoto = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactSourceId;
		[CProperty(ColumnPath ="ContactSourceId")]
		public Guid ContactSourceId
		{
			get{return _ContactSourceId;}
			set
			{
				_ContactSourceId = value;
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
		private string _Dear;
		[CProperty(ColumnPath ="Dear")]
		public string Dear
		{
			get{return _Dear;}
			set
			{
				_Dear = value;
				OnPropertyChanged();
			}
		}
		private string _DearUkr;
		[CProperty(ColumnPath ="DearUkr")]
		public string DearUkr
		{
			get{return _DearUkr;}
			set
			{
				_DearUkr = value;
				OnPropertyChanged();
			}
		}
		private Guid _DecisionRoleId;
		[CProperty(ColumnPath ="DecisionRoleId")]
		public Guid DecisionRoleId
		{
			get{return _DecisionRoleId;}
			set
			{
				_DecisionRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DepartmentId;
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId
		{
			get{return _DepartmentId;}
			set
			{
				_DepartmentId = value;
				OnPropertyChanged();
			}
		}
		private string _DirectPhone;
		[CProperty(ColumnPath ="DirectPhone")]
		public string DirectPhone
		{
			get{return _DirectPhone;}
			set
			{
				_DirectPhone = value;
				OnPropertyChanged();
			}
		}
		private bool _DoNotUseCall;
		[CProperty(ColumnPath ="DoNotUseCall")]
		public bool DoNotUseCall
		{
			get{return _DoNotUseCall;}
			set
			{
				_DoNotUseCall = value;
				OnPropertyChanged();
			}
		}
		private bool _DoNotUseEmail;
		[CProperty(ColumnPath ="DoNotUseEmail")]
		public bool DoNotUseEmail
		{
			get{return _DoNotUseEmail;}
			set
			{
				_DoNotUseEmail = value;
				OnPropertyChanged();
			}
		}
		private bool _DoNotUseFax;
		[CProperty(ColumnPath ="DoNotUseFax")]
		public bool DoNotUseFax
		{
			get{return _DoNotUseFax;}
			set
			{
				_DoNotUseFax = value;
				OnPropertyChanged();
			}
		}
		private bool _DoNotUseMail;
		[CProperty(ColumnPath ="DoNotUseMail")]
		public bool DoNotUseMail
		{
			get{return _DoNotUseMail;}
			set
			{
				_DoNotUseMail = value;
				OnPropertyChanged();
			}
		}
		private bool _DoNotUseSms;
		[CProperty(ColumnPath ="DoNotUseSms")]
		public bool DoNotUseSms
		{
			get{return _DoNotUseSms;}
			set
			{
				_DoNotUseSms = value;
				OnPropertyChanged();
			}
		}
		private string _Email;
		[CProperty(ColumnPath ="Email")]
		public string Email
		{
			get{return _Email;}
			set
			{
				_Email = value;
				OnPropertyChanged();
			}
		}
		private string _Facebook;
		[CProperty(ColumnPath ="Facebook")]
		public string Facebook
		{
			get{return _Facebook;}
			set
			{
				_Facebook = value;
				OnPropertyChanged();
			}
		}
		private Guid _FacebookAFDAId;
		[CProperty(ColumnPath ="FacebookAFDAId")]
		public Guid FacebookAFDAId
		{
			get{return _FacebookAFDAId;}
			set
			{
				_FacebookAFDAId = value;
				OnPropertyChanged();
			}
		}
		private string _FacebookId;
		[CProperty(ColumnPath ="FacebookId")]
		public string FacebookId
		{
			get{return _FacebookId;}
			set
			{
				_FacebookId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GenderId;
		[CProperty(ColumnPath ="GenderId")]
		public Guid GenderId
		{
			get{return _GenderId;}
			set
			{
				_GenderId = value;
				OnPropertyChanged();
			}
		}
		private string _GivenName;
		[CProperty(ColumnPath ="GivenName")]
		public string GivenName
		{
			get{return _GivenName;}
			set
			{
				_GivenName = value;
				OnPropertyChanged();
			}
		}
		private string _GPSE;
		[CProperty(ColumnPath ="GPSE")]
		public string GPSE
		{
			get{return _GPSE;}
			set
			{
				_GPSE = value;
				OnPropertyChanged();
			}
		}
		private string _GPSN;
		[CProperty(ColumnPath ="GPSN")]
		public string GPSN
		{
			get{return _GPSN;}
			set
			{
				_GPSN = value;
				OnPropertyChanged();
			}
		}
		private string _HomePhone;
		[CProperty(ColumnPath ="HomePhone")]
		public string HomePhone
		{
			get{return _HomePhone;}
			set
			{
				_HomePhone = value;
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
		private bool _IsNonActualEmail;
		[CProperty(ColumnPath ="IsNonActualEmail")]
		public bool IsNonActualEmail
		{
			get{return _IsNonActualEmail;}
			set
			{
				_IsNonActualEmail = value;
				OnPropertyChanged();
			}
		}
		private string _JobENG;
		[CProperty(ColumnPath ="JobENG")]
		public string JobENG
		{
			get{return _JobENG;}
			set
			{
				_JobENG = value;
				OnPropertyChanged();
			}
		}
		private Guid _JobId;
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId
		{
			get{return _JobId;}
			set
			{
				_JobId = value;
				OnPropertyChanged();
			}
		}
		private string _JobTitle;
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle
		{
			get{return _JobTitle;}
			set
			{
				_JobTitle = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LABActualAnonymizationDate;
		[CProperty(ColumnPath ="LABActualAnonymizationDate")]
		public DateTime LABActualAnonymizationDate
		{
			get{return _LABActualAnonymizationDate;}
			set
			{
				_LABActualAnonymizationDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _LABMarkedForAnonymizationDate;
		[CProperty(ColumnPath ="LABMarkedForAnonymizationDate")]
		public DateTime LABMarkedForAnonymizationDate
		{
			get{return _LABMarkedForAnonymizationDate;}
			set
			{
				_LABMarkedForAnonymizationDate = value;
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
		private string _LinkedIn;
		[CProperty(ColumnPath ="LinkedIn")]
		public string LinkedIn
		{
			get{return _LinkedIn;}
			set
			{
				_LinkedIn = value;
				OnPropertyChanged();
			}
		}
		private Guid _LinkedInAFDAId;
		[CProperty(ColumnPath ="LinkedInAFDAId")]
		public Guid LinkedInAFDAId
		{
			get{return _LinkedInAFDAId;}
			set
			{
				_LinkedInAFDAId = value;
				OnPropertyChanged();
			}
		}
		private string _LinkedInId;
		[CProperty(ColumnPath ="LinkedInId")]
		public string LinkedInId
		{
			get{return _LinkedInId;}
			set
			{
				_LinkedInId = value;
				OnPropertyChanged();
			}
		}
		private string _MiddleName;
		[CProperty(ColumnPath ="MiddleName")]
		public string MiddleName
		{
			get{return _MiddleName;}
			set
			{
				_MiddleName = value;
				OnPropertyChanged();
			}
		}
		private string _MobilePhone;
		[CProperty(ColumnPath ="MobilePhone")]
		public string MobilePhone
		{
			get{return _MobilePhone;}
			set
			{
				_MobilePhone = value;
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
		private string _NameEng;
		[CProperty(ColumnPath ="NameEng")]
		public string NameEng
		{
			get{return _NameEng;}
			set
			{
				_NameEng = value;
				OnPropertyChanged();
			}
		}
		private bool _NewsSubscription;
		[CProperty(ColumnPath ="NewsSubscription")]
		public bool NewsSubscription
		{
			get{return _NewsSubscription;}
			set
			{
				_NewsSubscription = value;
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
		private Guid _OfficeId;
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId
		{
			get{return _OfficeId;}
			set
			{
				_OfficeId = value;
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
		private string _Phone;
		[CProperty(ColumnPath ="Phone")]
		public string Phone
		{
			get{return _Phone;}
			set
			{
				_Phone = value;
				OnPropertyChanged();
			}
		}
		private Guid _PhotoId;
		[CProperty(ColumnPath ="PhotoId")]
		public Guid PhotoId
		{
			get{return _PhotoId;}
			set
			{
				_PhotoId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PredictiveScoring;
		[CProperty(ColumnPath ="PredictiveScoring")]
		public decimal PredictiveScoring
		{
			get{return _PredictiveScoring;}
			set
			{
				_PredictiveScoring = value;
				OnPropertyChanged();
			}
		}
		private Guid _PrimaryLanguageId;
		[CProperty(ColumnPath ="PrimaryLanguageId")]
		public Guid PrimaryLanguageId
		{
			get{return _PrimaryLanguageId;}
			set
			{
				_PrimaryLanguageId = value;
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
		private Guid _SalutationTypeId;
		[CProperty(ColumnPath ="SalutationTypeId")]
		public Guid SalutationTypeId
		{
			get{return _SalutationTypeId;}
			set
			{
				_SalutationTypeId = value;
				OnPropertyChanged();
			}
		}
		private int _Score;
		[CProperty(ColumnPath ="Score")]
		public int Score
		{
			get{return _Score;}
			set
			{
				_Score = value;
				OnPropertyChanged();
			}
		}
		private int _ScoreDemographic;
		[CProperty(ColumnPath ="ScoreDemographic")]
		public int ScoreDemographic
		{
			get{return _ScoreDemographic;}
			set
			{
				_ScoreDemographic = value;
				OnPropertyChanged();
			}
		}
		private string _Skype;
		[CProperty(ColumnPath ="Skype")]
		public string Skype
		{
			get{return _Skype;}
			set
			{
				_Skype = value;
				OnPropertyChanged();
			}
		}
		private string _Surname;
		[CProperty(ColumnPath ="Surname")]
		public string Surname
		{
			get{return _Surname;}
			set
			{
				_Surname = value;
				OnPropertyChanged();
			}
		}
		private string _Twitter;
		[CProperty(ColumnPath ="Twitter")]
		public string Twitter
		{
			get{return _Twitter;}
			set
			{
				_Twitter = value;
				OnPropertyChanged();
			}
		}
		private Guid _TwitterAFDAId;
		[CProperty(ColumnPath ="TwitterAFDAId")]
		public Guid TwitterAFDAId
		{
			get{return _TwitterAFDAId;}
			set
			{
				_TwitterAFDAId = value;
				OnPropertyChanged();
			}
		}
		private string _TwitterId;
		[CProperty(ColumnPath ="TwitterId")]
		public string TwitterId
		{
			get{return _TwitterId;}
			set
			{
				_TwitterId = value;
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
		private bool _WebinarsSubscription;
		[CProperty(ColumnPath ="WebinarsSubscription")]
		public bool WebinarsSubscription
		{
			get{return _WebinarsSubscription;}
			set
			{
				_WebinarsSubscription = value;
				OnPropertyChanged();
			}
		}
		private string _Zip;
		[CProperty(ColumnPath ="Zip")]
		public string Zip
		{
			get{return _Zip;}
			set
			{
				_Zip = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AddressType:AddressTypeId")]
		public AddressType AddressType { get; set; }
		[CProperty(Navigation ="BpmGDPR:BpmManageDataPrivacyId")]
		public BpmGDPR BpmManageDataPrivacy { get; set; }
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
		[CProperty(Navigation ="ContactSource:ContactSourceId")]
		public ContactSource ContactSource { get; set; }
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
		[CProperty(Navigation ="Office:OfficeId")]
		public Office Office { get; set; }
		[CProperty(Navigation ="PrimaryLanguage:PrimaryLanguageId")]
		public PrimaryLanguage PrimaryLanguage { get; set; }
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
		#endregion

		#region Associations
		[CProperty(Association ="Account:OwnerId")]
		public virtual ICollection<Account> AccountByOwner { get; set; }
		[CProperty(Association ="Account:PrimaryContactId")]
		public virtual ICollection<Account> AccountByPrimaryContact { get; set; }
		[CProperty(Association ="Account:CsmId")]
		public virtual ICollection<Account> AccountByCsm { get; set; }
		[CProperty(Association ="AccountBillingInfo:AccountManagerId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByAccountManager { get; set; }
		[CProperty(Association ="AccountBillingInfo:ChiefAccountantId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByChiefAccountant { get; set; }
		[CProperty(Association ="AccountCompleteness:AuthorId")]
		public virtual ICollection<AccountCompleteness> AccountCompletenessByAuthor { get; set; }
		[CProperty(Association ="AccountFile:LockedById")]
		public virtual ICollection<AccountFile> AccountFileByLockedBy { get; set; }
		[CProperty(Association ="AccountOrganizationChart:ManagerId")]
		public virtual ICollection<AccountOrganizationChart> AccountOrganizationChartByManager { get; set; }
		[CProperty(Association ="AccountStageHistory:OwnerId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByOwner { get; set; }
		[CProperty(Association ="AccountVerificationFile:LockedById")]
		public virtual ICollection<AccountVerificationFile> AccountVerificationFileByLockedBy { get; set; }
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
		[CProperty(Association ="ActivityVisa:SetById")]
		public virtual ICollection<ActivityVisa> ActivityVisaBySetBy { get; set; }
		[CProperty(Association ="Applicant:OwnerId")]
		public virtual ICollection<Applicant> ApplicantByOwner { get; set; }
		[CProperty(Association ="Applicant:ContactId")]
		public virtual ICollection<Applicant> ApplicantByContact { get; set; }
		[CProperty(Association ="ApplicantFile:LockedById")]
		public virtual ICollection<ApplicantFile> ApplicantFileByLockedBy { get; set; }
		[CProperty(Association ="ApplicantVisa:SetById")]
		public virtual ICollection<ApplicantVisa> ApplicantVisaBySetBy { get; set; }
		[CProperty(Association ="BeesenderChat:ContactId")]
		public virtual ICollection<BeesenderChat> BeesenderChatByContact { get; set; }
		[CProperty(Association ="BeesenderChat:OperatorContactId")]
		public virtual ICollection<BeesenderChat> BeesenderChatByOperatorContact { get; set; }
		[CProperty(Association ="BeesenderChatConfigurationFile:LockedById")]
		public virtual ICollection<BeesenderChatConfigurationFile> BeesenderChatConfigurationFileByLockedBy { get; set; }
		[CProperty(Association ="BeesenderChatFile:LockedById")]
		public virtual ICollection<BeesenderChatFile> BeesenderChatFileByLockedBy { get; set; }
		[CProperty(Association ="BeesenderChatMessage:OperatorContactId")]
		public virtual ICollection<BeesenderChatMessage> BeesenderChatMessageByOperatorContact { get; set; }
		[CProperty(Association ="BeesenderChatMessage:ClientContactId")]
		public virtual ICollection<BeesenderChatMessage> BeesenderChatMessageByClientContact { get; set; }
		[CProperty(Association ="BeesenderClient:ContactId")]
		public virtual ICollection<BeesenderClient> BeesenderClientByContact { get; set; }
		[CProperty(Association ="BeesenderOnlineUsers:ContactId")]
		public virtual ICollection<BeesenderOnlineUsers> BeesenderOnlineUsersByContact { get; set; }
		[CProperty(Association ="BonusFile:LockedById")]
		public virtual ICollection<BonusFile> BonusFileByLockedBy { get; set; }
		[CProperty(Association ="BonusVisa:SetById")]
		public virtual ICollection<BonusVisa> BonusVisaBySetBy { get; set; }
		[CProperty(Association ="BpmGDPRFile:LockedById")]
		public virtual ICollection<BpmGDPRFile> BpmGDPRFileByLockedBy { get; set; }
		[CProperty(Association ="BpmonlineBuildFile:LockedById")]
		public virtual ICollection<BpmonlineBuildFile> BpmonlineBuildFileByLockedBy { get; set; }
		[CProperty(Association ="BpmonlineReleaseNotificationSetup:ContactId")]
		public virtual ICollection<BpmonlineReleaseNotificationSetup> BpmonlineReleaseNotificationSetupByContact { get; set; }
		[CProperty(Association ="BsoChatMessage:BsoOwnerId")]
		public virtual ICollection<BsoChatMessage> BsoChatMessageByBsoOwner { get; set; }
		[CProperty(Association ="BsoChats:BsoContactId")]
		public virtual ICollection<BsoChats> BsoChatsByBsoContact { get; set; }
		[CProperty(Association ="BsoChats:BsoOwnerId")]
		public virtual ICollection<BsoChats> BsoChatsByBsoOwner { get; set; }
		[CProperty(Association ="BsoChatsFile:LockedById")]
		public virtual ICollection<BsoChatsFile> BsoChatsFileByLockedBy { get; set; }
		[CProperty(Association ="Budget:OwnerId")]
		public virtual ICollection<Budget> BudgetByOwner { get; set; }
		[CProperty(Association ="BudgetFile:LockedById")]
		public virtual ICollection<BudgetFile> BudgetFileByLockedBy { get; set; }
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
		[CProperty(Association ="Case:ResolvedById")]
		public virtual ICollection<Case> CaseByResolvedBy { get; set; }
		[CProperty(Association ="CaseFile:LockedById")]
		public virtual ICollection<CaseFile> CaseFileByLockedBy { get; set; }
		[CProperty(Association ="CaseLifecycle:OwnerId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByOwner { get; set; }
		[CProperty(Association ="CaseLifecycle:ContactId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByContact { get; set; }
		[CProperty(Association ="CaseTypeFile:LockedById")]
		public virtual ICollection<CaseTypeFile> CaseTypeFileByLockedBy { get; set; }
		[CProperty(Association ="Certificate:ContactId")]
		public virtual ICollection<Certificate> CertificateByContact { get; set; }
		[CProperty(Association ="Change:AuthorId")]
		public virtual ICollection<Change> ChangeByAuthor { get; set; }
		[CProperty(Association ="Change:OwnerId")]
		public virtual ICollection<Change> ChangeByOwner { get; set; }
		[CProperty(Association ="ChangeFile:LockedById")]
		public virtual ICollection<ChangeFile> ChangeFileByLockedBy { get; set; }
		[CProperty(Association ="ChangeType:OwnerId")]
		public virtual ICollection<ChangeType> ChangeTypeByOwner { get; set; }
		[CProperty(Association ="ChangeVisa:SetById")]
		public virtual ICollection<ChangeVisa> ChangeVisaBySetBy { get; set; }
		[CProperty(Association ="CI:OwnerId")]
		public virtual ICollection<CI> CIByOwner { get; set; }
		[CProperty(Association ="CI:AuthorId")]
		public virtual ICollection<CI> CIByAuthor { get; set; }
		[CProperty(Association ="CIFile:LockedById")]
		public virtual ICollection<CIFile> CIFileByLockedBy { get; set; }
		[CProperty(Association ="CIVisa:SetById")]
		public virtual ICollection<CIVisa> CIVisaBySetBy { get; set; }
		[CProperty(Association ="Comment:ContactId")]
		public virtual ICollection<Comment> CommentByContact { get; set; }
		[CProperty(Association ="CompetenceFile:LockedById")]
		public virtual ICollection<CompetenceFile> CompetenceFileByLockedBy { get; set; }
		[CProperty(Association ="ConfItem:OwnerId")]
		public virtual ICollection<ConfItem> ConfItemByOwner { get; set; }
		[CProperty(Association ="ConfItem:ContactId")]
		public virtual ICollection<ConfItem> ConfItemByContact { get; set; }
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
		[CProperty(Association ="ContactCompleteness:AuthorId")]
		public virtual ICollection<ContactCompleteness> ContactCompletenessByAuthor { get; set; }
		[CProperty(Association ="ContactCompleteness:ContactId")]
		public virtual ICollection<ContactCompleteness> ContactCompletenessByContact { get; set; }
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
		[CProperty(Association ="ContactGameAchievement:ContactId")]
		public virtual ICollection<ContactGameAchievement> ContactGameAchievementByContact { get; set; }
		[CProperty(Association ="ContactGameProfile:ContactId")]
		public virtual ICollection<ContactGameProfile> ContactGameProfileByContact { get; set; }
		[CProperty(Association ="ContactGameTitle:ContactId")]
		public virtual ICollection<ContactGameTitle> ContactGameTitleByContact { get; set; }
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
		[CProperty(Association ="Contract:ContractRecipientId")]
		public virtual ICollection<Contract> ContractByContractRecipient { get; set; }
		[CProperty(Association ="Contract:SalesAssistantContactId")]
		public virtual ICollection<Contract> ContractBySalesAssistantContact { get; set; }
		[CProperty(Association ="ContractFile:LockedById")]
		public virtual ICollection<ContractFile> ContractFileByLockedBy { get; set; }
		[CProperty(Association ="ContractVisa:SetById")]
		public virtual ICollection<ContractVisa> ContractVisaBySetBy { get; set; }
		[CProperty(Association ="ContractVisasList:ContactId")]
		public virtual ICollection<ContractVisasList> ContractVisasListByContact { get; set; }
		[CProperty(Association ="CTISearchResult:ContactId")]
		public virtual ICollection<CTISearchResult> CTISearchResultByContact { get; set; }
		[CProperty(Association ="DayOff:ContactId")]
		public virtual ICollection<DayOff> DayOffByContact { get; set; }
		[CProperty(Association ="Document:OwnerId")]
		public virtual ICollection<Document> DocumentByOwner { get; set; }
		[CProperty(Association ="Document:ContactId")]
		public virtual ICollection<Document> DocumentByContact { get; set; }
		[CProperty(Association ="Document:ResponsibleAccountantId")]
		public virtual ICollection<Document> DocumentByResponsibleAccountant { get; set; }
		[CProperty(Association ="Document:InitiatorId")]
		public virtual ICollection<Document> DocumentByInitiator { get; set; }
		[CProperty(Association ="Document:EmployeeId")]
		public virtual ICollection<Document> DocumentByEmployee { get; set; }
		[CProperty(Association ="DocumentFile:LockedById")]
		public virtual ICollection<DocumentFile> DocumentFileByLockedBy { get; set; }
		[CProperty(Association ="DocumentVisa:SetById")]
		public virtual ICollection<DocumentVisa> DocumentVisaBySetBy { get; set; }
		[CProperty(Association ="DutySchedule:DutyId")]
		public virtual ICollection<DutySchedule> DutyScheduleByDuty { get; set; }
		[CProperty(Association ="DwhDevCR:OwnerIdId")]
		public virtual ICollection<DwhDevCR> DwhDevCRByOwnerId { get; set; }
		[CProperty(Association ="DwhDevCR:HodId")]
		public virtual ICollection<DwhDevCR> DwhDevCRByHod { get; set; }
		[CProperty(Association ="DwhDevKpi:EmployeeId")]
		public virtual ICollection<DwhDevKpi> DwhDevKpiByEmployee { get; set; }
		[CProperty(Association ="DwhDevKpi:HodId")]
		public virtual ICollection<DwhDevKpi> DwhDevKpiByHod { get; set; }
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
		[CProperty(Association ="Employee:MentorId")]
		public virtual ICollection<Employee> EmployeeByMentor { get; set; }
		[CProperty(Association ="Employee:SMId")]
		public virtual ICollection<Employee> EmployeeBySM { get; set; }
		[CProperty(Association ="Employee:HRId")]
		public virtual ICollection<Employee> EmployeeByHR { get; set; }
		[CProperty(Association ="EmployeeFile:LockedById")]
		public virtual ICollection<EmployeeFile> EmployeeFileByLockedBy { get; set; }
		[CProperty(Association ="EmployeeKpi:ContactId")]
		public virtual ICollection<EmployeeKpi> EmployeeKpiByContact { get; set; }
		[CProperty(Association ="EmployeeKpi:OwnerId")]
		public virtual ICollection<EmployeeKpi> EmployeeKpiByOwner { get; set; }
		[CProperty(Association ="EmployeeScore:OwnerId")]
		public virtual ICollection<EmployeeScore> EmployeeScoreByOwner { get; set; }
		[CProperty(Association ="EmployeeScore:EmployeeId")]
		public virtual ICollection<EmployeeScore> EmployeeScoreByEmployee { get; set; }
		[CProperty(Association ="EmployeeScoreFile:LockedById")]
		public virtual ICollection<EmployeeScoreFile> EmployeeScoreFileByLockedBy { get; set; }
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
		[CProperty(Association ="EventTarget:OwnerId")]
		public virtual ICollection<EventTarget> EventTargetByOwner { get; set; }
		[CProperty(Association ="EventTeam:ContactId")]
		public virtual ICollection<EventTeam> EventTeamByContact { get; set; }
		[CProperty(Association ="ExesInRequest:FinanceExecutorId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByFinanceExecutor { get; set; }
		[CProperty(Association ="ExesInRequestFile:LockedById")]
		public virtual ICollection<ExesInRequestFile> ExesInRequestFileByLockedBy { get; set; }
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
		[CProperty(Association ="Game:OwnerId")]
		public virtual ICollection<Game> GameByOwner { get; set; }
		[CProperty(Association ="GameContactPoint:ContactId")]
		public virtual ICollection<GameContactPoint> GameContactPointByContact { get; set; }
		[CProperty(Association ="GameScoringLog:ContactId")]
		public virtual ICollection<GameScoringLog> GameScoringLogByContact { get; set; }
		[CProperty(Association ="GameTakenReward:ContactId")]
		public virtual ICollection<GameTakenReward> GameTakenRewardByContact { get; set; }
		[CProperty(Association ="GeneratedWebForm:OwnerId")]
		public virtual ICollection<GeneratedWebForm> GeneratedWebFormByOwner { get; set; }
		[CProperty(Association ="GeneratedWebFormFile:LockedById")]
		public virtual ICollection<GeneratedWebFormFile> GeneratedWebFormFileByLockedBy { get; set; }
		[CProperty(Association ="Gift:OwnerId")]
		public virtual ICollection<Gift> GiftByOwner { get; set; }
		[CProperty(Association ="GiftFile:LockedById")]
		public virtual ICollection<GiftFile> GiftFileByLockedBy { get; set; }
		[CProperty(Association ="GlbCustomer:GlbCSMId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbCSM { get; set; }
		[CProperty(Association ="GlbCustomer:GlbSalesExecutiveId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbSalesExecutive { get; set; }
		[CProperty(Association ="GlbCustomer:GlbCSEId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbCSE { get; set; }
		[CProperty(Association ="GlbCustomerFile:LockedById")]
		public virtual ICollection<GlbCustomerFile> GlbCustomerFileByLockedBy { get; set; }
		[CProperty(Association ="GlbCustomerGift:GlbGiftContactId")]
		public virtual ICollection<GlbCustomerGift> GlbCustomerGiftByGlbGiftContact { get; set; }
		[CProperty(Association ="GlbCustomerGiftFile:LockedById")]
		public virtual ICollection<GlbCustomerGiftFile> GlbCustomerGiftFileByLockedBy { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerList:GlbContactId")]
		public virtual ICollection<GlbCustomerKeyPlayerList> GlbCustomerKeyPlayerListByGlbContact { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerListFile:LockedById")]
		public virtual ICollection<GlbCustomerKeyPlayerListFile> GlbCustomerKeyPlayerListFileByLockedBy { get; set; }
		[CProperty(Association ="GlbReferenceableFile:LockedById")]
		public virtual ICollection<GlbReferenceableFile> GlbReferenceableFileByLockedBy { get; set; }
		[CProperty(Association ="HRTalks:HRBPId")]
		public virtual ICollection<HRTalks> HRTalksByHRBP { get; set; }
		[CProperty(Association ="ImprovementParticipant:ContactId")]
		public virtual ICollection<ImprovementParticipant> ImprovementParticipantByContact { get; set; }
		[CProperty(Association ="INFLUTargetsStats:INFLUContactId")]
		public virtual ICollection<INFLUTargetsStats> INFLUTargetsStatsByINFLUContact { get; set; }
		[CProperty(Association ="INFLUwebFile:LockedById")]
		public virtual ICollection<INFLUwebFile> INFLUwebFileByLockedBy { get; set; }
		[CProperty(Association ="InteractionFile:LockedById")]
		public virtual ICollection<InteractionFile> InteractionFileByLockedBy { get; set; }
		[CProperty(Association ="InteractionWithManager:ManagerId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByManager { get; set; }
		[CProperty(Association ="InternalRequest:OwnerId")]
		public virtual ICollection<InternalRequest> InternalRequestByOwner { get; set; }
		[CProperty(Association ="InternalRequest:RequesterId")]
		public virtual ICollection<InternalRequest> InternalRequestByRequester { get; set; }
		[CProperty(Association ="InternalRequest:NewEmployeeId")]
		public virtual ICollection<InternalRequest> InternalRequestByNewEmployee { get; set; }
		[CProperty(Association ="InternalRequest:CertificateContactId")]
		public virtual ICollection<InternalRequest> InternalRequestByCertificateContact { get; set; }
		[CProperty(Association ="InternalRequest:AuthorizedUserId")]
		public virtual ICollection<InternalRequest> InternalRequestByAuthorizedUser { get; set; }
		[CProperty(Association ="InternalRequestFile:LockedById")]
		public virtual ICollection<InternalRequestFile> InternalRequestFileByLockedBy { get; set; }
		[CProperty(Association ="InternalRequestVisa:SetById")]
		public virtual ICollection<InternalRequestVisa> InternalRequestVisaBySetBy { get; set; }
		[CProperty(Association ="InvestorCommentFile:LockedById")]
		public virtual ICollection<InvestorCommentFile> InvestorCommentFileByLockedBy { get; set; }
		[CProperty(Association ="InvestorFile:LockedById")]
		public virtual ICollection<InvestorFile> InvestorFileByLockedBy { get; set; }
		[CProperty(Association ="Invoice:OwnerId")]
		public virtual ICollection<Invoice> InvoiceByOwner { get; set; }
		[CProperty(Association ="Invoice:ContactId")]
		public virtual ICollection<Invoice> InvoiceByContact { get; set; }
		[CProperty(Association ="InvoiceAccrueRole:ContactId")]
		public virtual ICollection<InvoiceAccrueRole> InvoiceAccrueRoleByContact { get; set; }
		[CProperty(Association ="InvoiceAccrueRole:TeamLeaderId")]
		public virtual ICollection<InvoiceAccrueRole> InvoiceAccrueRoleByTeamLeader { get; set; }
		[CProperty(Association ="InvoiceFile:LockedById")]
		public virtual ICollection<InvoiceFile> InvoiceFileByLockedBy { get; set; }
		[CProperty(Association ="InvoiceVisa:SetById")]
		public virtual ICollection<InvoiceVisa> InvoiceVisaBySetBy { get; set; }
		[CProperty(Association ="IQSetRightsFile:LockedById")]
		public virtual ICollection<IQSetRightsFile> IQSetRightsFileByLockedBy { get; set; }
		[CProperty(Association ="KeyPartnerContact:ContactId")]
		public virtual ICollection<KeyPartnerContact> KeyPartnerContactByContact { get; set; }
		[CProperty(Association ="KnowledgeBaseFile:LockedById")]
		public virtual ICollection<KnowledgeBaseFile> KnowledgeBaseFileByLockedBy { get; set; }
		[CProperty(Association ="Lead:OwnerId")]
		public virtual ICollection<Lead> LeadByOwner { get; set; }
		[CProperty(Association ="Lead:QualifiedContactId")]
		public virtual ICollection<Lead> LeadByQualifiedContact { get; set; }
		[CProperty(Association ="Lead:SalesOwnerId")]
		public virtual ICollection<Lead> LeadBySalesOwner { get; set; }
		[CProperty(Association ="Lead:PartnerOwnerId")]
		public virtual ICollection<Lead> LeadByPartnerOwner { get; set; }
		[CProperty(Association ="LeadGenBonus:ContactId")]
		public virtual ICollection<LeadGenBonus> LeadGenBonusByContact { get; set; }
		[CProperty(Association ="LeadInQualifyStatus:OwnerId")]
		public virtual ICollection<LeadInQualifyStatus> LeadInQualifyStatusByOwner { get; set; }
		[CProperty(Association ="LeadInStage:OwnerId")]
		public virtual ICollection<LeadInStage> LeadInStageByOwner { get; set; }
		[CProperty(Association ="LeadQualification:ContactId")]
		public virtual ICollection<LeadQualification> LeadQualificationByContact { get; set; }
		[CProperty(Association ="Like:ContactId")]
		public virtual ICollection<Like> LikeByContact { get; set; }
		[CProperty(Association ="LocationHistory:ContactId")]
		public virtual ICollection<LocationHistory> LocationHistoryByContact { get; set; }
		[CProperty(Association ="MailboxSettingsFile:LockedById")]
		public virtual ICollection<MailboxSettingsFile> MailboxSettingsFileByLockedBy { get; set; }
		[CProperty(Association ="MarketplaceApplication:DeveloperId")]
		public virtual ICollection<MarketplaceApplication> MarketplaceApplicationByDeveloper { get; set; }
		[CProperty(Association ="MarketplaceApplication:OwnerId")]
		public virtual ICollection<MarketplaceApplication> MarketplaceApplicationByOwner { get; set; }
		[CProperty(Association ="MarketplaceApplicationFile:LockedById")]
		public virtual ICollection<MarketplaceApplicationFile> MarketplaceApplicationFileByLockedBy { get; set; }
		[CProperty(Association ="MktgActivity:OwnerId")]
		public virtual ICollection<MktgActivity> MktgActivityByOwner { get; set; }
		[CProperty(Association ="MktgActivityFile:LockedById")]
		public virtual ICollection<MktgActivityFile> MktgActivityFileByLockedBy { get; set; }
		[CProperty(Association ="MLModelFile:LockedById")]
		public virtual ICollection<MLModelFile> MLModelFileByLockedBy { get; set; }
		[CProperty(Association ="NPS:ContactId")]
		public virtual ICollection<NPS> NPSByContact { get; set; }
		[CProperty(Association ="OAuth20AppFile:LockedById")]
		public virtual ICollection<OAuth20AppFile> OAuth20AppFileByLockedBy { get; set; }
		[CProperty(Association ="Opportunity:OwnerId")]
		public virtual ICollection<Opportunity> OpportunityByOwner { get; set; }
		[CProperty(Association ="Opportunity:ContactId")]
		public virtual ICollection<Opportunity> OpportunityByContact { get; set; }
		[CProperty(Association ="Opportunity:OwnerFarmerId")]
		public virtual ICollection<Opportunity> OpportunityByOwnerFarmer { get; set; }
		[CProperty(Association ="OpportunityContact:ContactId")]
		public virtual ICollection<OpportunityContact> OpportunityContactByContact { get; set; }
		[CProperty(Association ="OpportunityDepartment:SalesDirectorId")]
		public virtual ICollection<OpportunityDepartment> OpportunityDepartmentBySalesDirector { get; set; }
		[CProperty(Association ="OpportunityFile:LockedById")]
		public virtual ICollection<OpportunityFile> OpportunityFileByLockedBy { get; set; }
		[CProperty(Association ="OpportunityForecast:ForecastOwnerId")]
		public virtual ICollection<OpportunityForecast> OpportunityForecastByForecastOwner { get; set; }
		[CProperty(Association ="OpportunityForecastFile:LockedById")]
		public virtual ICollection<OpportunityForecastFile> OpportunityForecastFileByLockedBy { get; set; }
		[CProperty(Association ="OpportunityForecastHistory:ForecastOwnerId")]
		public virtual ICollection<OpportunityForecastHistory> OpportunityForecastHistoryByForecastOwner { get; set; }
		[CProperty(Association ="OpportunityForecastVisa:SetById")]
		public virtual ICollection<OpportunityForecastVisa> OpportunityForecastVisaBySetBy { get; set; }
		[CProperty(Association ="OpportunityInStage:OwnerId")]
		public virtual ICollection<OpportunityInStage> OpportunityInStageByOwner { get; set; }
		[CProperty(Association ="OpportunityParticipant:ContactId")]
		public virtual ICollection<OpportunityParticipant> OpportunityParticipantByContact { get; set; }
		[CProperty(Association ="OpportunityPartner:PartnerOwnerId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByPartnerOwner { get; set; }
		[CProperty(Association ="OpportunityPartnerHistory:PartnerOwnerId")]
		public virtual ICollection<OpportunityPartnerHistory> OpportunityPartnerHistoryByPartnerOwner { get; set; }
		[CProperty(Association ="OpportunityPartnerHistory:RecordModifyId")]
		public virtual ICollection<OpportunityPartnerHistory> OpportunityPartnerHistoryByRecordModify { get; set; }
		[CProperty(Association ="OpportunityReference:ContactId")]
		public virtual ICollection<OpportunityReference> OpportunityReferenceByContact { get; set; }
		[CProperty(Association ="OpportunityVisa:SetById")]
		public virtual ICollection<OpportunityVisa> OpportunityVisaBySetBy { get; set; }
		[CProperty(Association ="Order:OwnerId")]
		public virtual ICollection<Order> OrderByOwner { get; set; }
		[CProperty(Association ="Order:ContactId")]
		public virtual ICollection<Order> OrderByContact { get; set; }
		[CProperty(Association ="OrderFile:LockedById")]
		public virtual ICollection<OrderFile> OrderFileByLockedBy { get; set; }
		[CProperty(Association ="OrderVisa:SetById")]
		public virtual ICollection<OrderVisa> OrderVisaBySetBy { get; set; }
		[CProperty(Association ="OrgStructureUnit:HRBPId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByHRBP { get; set; }
		[CProperty(Association ="OrgStructureUnit:ScrumMasterId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByScrumMaster { get; set; }
		[CProperty(Association ="OrgStructureUnitFile:LockedById")]
		public virtual ICollection<OrgStructureUnitFile> OrgStructureUnitFileByLockedBy { get; set; }
		[CProperty(Association ="PainChain:KeyPlayerId")]
		public virtual ICollection<PainChain> PainChainByKeyPlayer { get; set; }
		[CProperty(Association ="Partnership:POManagerId")]
		public virtual ICollection<Partnership> PartnershipByPOManager { get; set; }
		[CProperty(Association ="Partnership:PMMId")]
		public virtual ICollection<Partnership> PartnershipByPMM { get; set; }
		[CProperty(Association ="Partnership:OwnerId")]
		public virtual ICollection<Partnership> PartnershipByOwner { get; set; }
		[CProperty(Association ="PartnershipFile:LockedById")]
		public virtual ICollection<PartnershipFile> PartnershipFileByLockedBy { get; set; }
		[CProperty(Association ="PartnershipVisa:SetById")]
		public virtual ICollection<PartnershipVisa> PartnershipVisaBySetBy { get; set; }
		[CProperty(Association ="PaymentRuleFile:LockedById")]
		public virtual ICollection<PaymentRuleFile> PaymentRuleFileByLockedBy { get; set; }
		[CProperty(Association ="PaymentsFile:LockedById")]
		public virtual ICollection<PaymentsFile> PaymentsFileByLockedBy { get; set; }
		[CProperty(Association ="PDECaseVisa:SetById")]
		public virtual ICollection<PDECaseVisa> PDECaseVisaBySetBy { get; set; }
		[CProperty(Association ="PDEContactInReferenceCase:PDEContactId")]
		public virtual ICollection<PDEContactInReferenceCase> PDEContactInReferenceCaseByPDEContact { get; set; }
		[CProperty(Association ="PDEKnowledgeBaseVisa:SetById")]
		public virtual ICollection<PDEKnowledgeBaseVisa> PDEKnowledgeBaseVisaBySetBy { get; set; }
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
		[CProperty(Association ="Product:PartnerOwnerId")]
		public virtual ICollection<Product> ProductByPartnerOwner { get; set; }
		[CProperty(Association ="ProductFile:LockedById")]
		public virtual ICollection<ProductFile> ProductFileByLockedBy { get; set; }
		[CProperty(Association ="Project:ContactId")]
		public virtual ICollection<Project> ProjectByContact { get; set; }
		[CProperty(Association ="Project:OwnerId")]
		public virtual ICollection<Project> ProjectByOwner { get; set; }
		[CProperty(Association ="ProjectFile:LockedById")]
		public virtual ICollection<ProjectFile> ProjectFileByLockedBy { get; set; }
		[CProperty(Association ="ProjectInStatus:OwnerId")]
		public virtual ICollection<ProjectInStatus> ProjectInStatusByOwner { get; set; }
		[CProperty(Association ="ProjectResourceElement:ContactId")]
		public virtual ICollection<ProjectResourceElement> ProjectResourceElementByContact { get; set; }
		[CProperty(Association ="ProjectSolutionFile:LockedById")]
		public virtual ICollection<ProjectSolutionFile> ProjectSolutionFileByLockedBy { get; set; }
		[CProperty(Association ="PsDeliveryFile:LockedById")]
		public virtual ICollection<PsDeliveryFile> PsDeliveryFileByLockedBy { get; set; }
		[CProperty(Association ="PsDeliveryVisa:SetById")]
		public virtual ICollection<PsDeliveryVisa> PsDeliveryVisaBySetBy { get; set; }
		[CProperty(Association ="PsTeam:ContactId")]
		public virtual ICollection<PsTeam> PsTeamByContact { get; set; }
		[CProperty(Association ="QueueItem:OperatorId")]
		public virtual ICollection<QueueItem> QueueItemByOperator { get; set; }
		[CProperty(Association ="QueueItemReaction:ContactId")]
		public virtual ICollection<QueueItemReaction> QueueItemReactionByContact { get; set; }
		[CProperty(Association ="QueueItemReaction:OperatorId")]
		public virtual ICollection<QueueItemReaction> QueueItemReactionByOperator { get; set; }
		[CProperty(Association ="QueueOperator:OperatorId")]
		public virtual ICollection<QueueOperator> QueueOperatorByOperator { get; set; }
		[CProperty(Association ="QuickDialUserSettings:ContactId")]
		public virtual ICollection<QuickDialUserSettings> QuickDialUserSettingsByContact { get; set; }
		[CProperty(Association ="RecruitmentInStage:OwnerId")]
		public virtual ICollection<RecruitmentInStage> RecruitmentInStageByOwner { get; set; }
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
		[CProperty(Association ="SaaSMetrix:ContactId")]
		public virtual ICollection<SaaSMetrix> SaaSMetrixByContact { get; set; }
		[CProperty(Association ="SalesProcessEvent:OwnerId")]
		public virtual ICollection<SalesProcessEvent> SalesProcessEventByOwner { get; set; }
		[CProperty(Association ="SalesProcessEvent:ManagerId")]
		public virtual ICollection<SalesProcessEvent> SalesProcessEventByManager { get; set; }
		[CProperty(Association ="SalesProcessEvent:DepartmentManagerId")]
		public virtual ICollection<SalesProcessEvent> SalesProcessEventByDepartmentManager { get; set; }
		[CProperty(Association ="ScreenResult:ScreeningInitiatorId")]
		public virtual ICollection<ScreenResult> ScreenResultByScreeningInitiator { get; set; }
		[CProperty(Association ="ScreenResultFile:LockedById")]
		public virtual ICollection<ScreenResultFile> ScreenResultFileByLockedBy { get; set; }
		[CProperty(Association ="ScreenResultVisa:SetById")]
		public virtual ICollection<ScreenResultVisa> ScreenResultVisaBySetBy { get; set; }
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
		[CProperty(Association ="SiteDomain:OwnerId")]
		public virtual ICollection<SiteDomain> SiteDomainByOwner { get; set; }
		[CProperty(Association ="SiteDomainFile:LockedById")]
		public virtual ICollection<SiteDomainFile> SiteDomainFileByLockedBy { get; set; }
		[CProperty(Association ="SiteEvent:ContactId")]
		public virtual ICollection<SiteEvent> SiteEventByContact { get; set; }
		[CProperty(Association ="SiteEventTypeFile:LockedById")]
		public virtual ICollection<SiteEventTypeFile> SiteEventTypeFileByLockedBy { get; set; }
		[CProperty(Association ="SocialMention:ContactId")]
		public virtual ICollection<SocialMention> SocialMentionByContact { get; set; }
		[CProperty(Association ="SubscriptionExpirationReceiver:ContactId")]
		public virtual ICollection<SubscriptionExpirationReceiver> SubscriptionExpirationReceiverByContact { get; set; }
		[CProperty(Association ="SupAccessToClientFile:LockedById")]
		public virtual ICollection<SupAccessToClientFile> SupAccessToClientFileByLockedBy { get; set; }
		[CProperty(Association ="SupplyPaymentElement:OwnerId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByOwner { get; set; }
		[CProperty(Association ="SupplyPaymentElement:ContactId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByContact { get; set; }
		[CProperty(Association ="SupplyPaymentItemFile:LockedById")]
		public virtual ICollection<SupplyPaymentItemFile> SupplyPaymentItemFileByLockedBy { get; set; }
		[CProperty(Association ="SupportUnit:ContactId")]
		public virtual ICollection<SupportUnit> SupportUnitByContact { get; set; }
		[CProperty(Association ="SupportUnitLog:ContactId")]
		public virtual ICollection<SupportUnitLog> SupportUnitLogByContact { get; set; }
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
		[CProperty(Association ="TeamOnDutyFile:LockedById")]
		public virtual ICollection<TeamOnDutyFile> TeamOnDutyFileByLockedBy { get; set; }
		[CProperty(Association ="ToEmployeeQuote:ContactId")]
		public virtual ICollection<ToEmployeeQuote> ToEmployeeQuoteByContact { get; set; }
		[CProperty(Association ="TrackingProject:OwnerId")]
		public virtual ICollection<TrackingProject> TrackingProjectByOwner { get; set; }
		[CProperty(Association ="TransactionFile:LockedById")]
		public virtual ICollection<TransactionFile> TransactionFileByLockedBy { get; set; }
		[CProperty(Association ="TsOrderExpense:InvoiceOwnerId")]
		public virtual ICollection<TsOrderExpense> TsOrderExpenseByInvoiceOwner { get; set; }
		[CProperty(Association ="TsOrderExpenseFile:LockedById")]
		public virtual ICollection<TsOrderExpenseFile> TsOrderExpenseFileByLockedBy { get; set; }
		[CProperty(Association ="TsOrderExpenseVisa:SetById")]
		public virtual ICollection<TsOrderExpenseVisa> TsOrderExpenseVisaBySetBy { get; set; }
		[CProperty(Association ="TsSalesCareer:AccountManagerId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByAccountManager { get; set; }
		[CProperty(Association ="TsSalesCareer:ContactId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByContact { get; set; }
		[CProperty(Association ="TsStaffGoalFile:LockedById")]
		public virtual ICollection<TsStaffGoalFile> TsStaffGoalFileByLockedBy { get; set; }
		[CProperty(Association ="TsStaffGoalVisa:SetById")]
		public virtual ICollection<TsStaffGoalVisa> TsStaffGoalVisaBySetBy { get; set; }
		[CProperty(Association ="TsStaffSkillPeriod:OwnerId")]
		public virtual ICollection<TsStaffSkillPeriod> TsStaffSkillPeriodByOwner { get; set; }
		[CProperty(Association ="TsStaffSkillPeriodValueVisa:SetById")]
		public virtual ICollection<TsStaffSkillPeriodValueVisa> TsStaffSkillPeriodValueVisaBySetBy { get; set; }
		[CProperty(Association ="TsStaffSkillPeriodValueVisa:ConfirmedById")]
		public virtual ICollection<TsStaffSkillPeriodValueVisa> TsStaffSkillPeriodValueVisaByConfirmedBy { get; set; }
		[CProperty(Association ="VwAccountFile:LockedById")]
		public virtual ICollection<VwAccountFile> VwAccountFileByLockedBy { get; set; }
		[CProperty(Association ="VwAccountRelationship:RelatedContactId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByRelatedContact { get; set; }
		[CProperty(Association ="VwAnniversary:ContactId")]
		public virtual ICollection<VwAnniversary> VwAnniversaryByContact { get; set; }
		[CProperty(Association ="VwBulkEmailClickedLink:ContactId")]
		public virtual ICollection<VwBulkEmailClickedLink> VwBulkEmailClickedLinkByContact { get; set; }
		[CProperty(Association ="VwCallLeadGenBonus:ContactId")]
		public virtual ICollection<VwCallLeadGenBonus> VwCallLeadGenBonusByContact { get; set; }
		[CProperty(Association ="VwCardActLeadGenBonus:ContactId")]
		public virtual ICollection<VwCardActLeadGenBonus> VwCardActLeadGenBonusByContact { get; set; }
		[CProperty(Association ="VwCaseDashboard:CreatedById")]
		public virtual ICollection<VwCaseDashboard> VwCaseDashboardByCreatedBy { get; set; }
		[CProperty(Association ="VwCaseDashboard:ContactId")]
		public virtual ICollection<VwCaseDashboard> VwCaseDashboardByContact { get; set; }
		[CProperty(Association ="VwCaseDashboard:OwnerId")]
		public virtual ICollection<VwCaseDashboard> VwCaseDashboardByOwner { get; set; }
		[CProperty(Association ="VwCaseStatusHistory:ModifiedById")]
		public virtual ICollection<VwCaseStatusHistory> VwCaseStatusHistoryByModifiedBy { get; set; }
		[CProperty(Association ="VwChange:AuthorId")]
		public virtual ICollection<VwChange> VwChangeByAuthor { get; set; }
		[CProperty(Association ="VwChange:OwnerId")]
		public virtual ICollection<VwChange> VwChangeByOwner { get; set; }
		[CProperty(Association ="VwCompLeadGenBonus:ContactId")]
		public virtual ICollection<VwCompLeadGenBonus> VwCompLeadGenBonusByContact { get; set; }
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
		[CProperty(Association ="VwEARequestLog:RequestedById")]
		public virtual ICollection<VwEARequestLog> VwEARequestLogByRequestedBy { get; set; }
		[CProperty(Association ="VwEventInContact:OwnerId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByOwner { get; set; }
		[CProperty(Association ="VwForecastDashboarData:OwnerId")]
		public virtual ICollection<VwForecastDashboarData> VwForecastDashboarDataByOwner { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:ContactId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByContact { get; set; }
		[CProperty(Association ="VwLead:OwnerId")]
		public virtual ICollection<VwLead> VwLeadByOwner { get; set; }
		[CProperty(Association ="VwLead:QualifiedContactId")]
		public virtual ICollection<VwLead> VwLeadByQualifiedContact { get; set; }
		[CProperty(Association ="VwLead:SalesOwnerId")]
		public virtual ICollection<VwLead> VwLeadBySalesOwner { get; set; }
		[CProperty(Association ="VwLead:PartnerOwnerId")]
		public virtual ICollection<VwLead> VwLeadByPartnerOwner { get; set; }
		[CProperty(Association ="VwLeadInQueue:OperatorId")]
		public virtual ICollection<VwLeadInQueue> VwLeadInQueueByOperator { get; set; }
		[CProperty(Association ="VwMandrillRecipient:ContactId")]
		public virtual ICollection<VwMandrillRecipient> VwMandrillRecipientByContact { get; set; }
		[CProperty(Association ="VwMandrillRecipientFilter:ContactId")]
		public virtual ICollection<VwMandrillRecipientFilter> VwMandrillRecipientFilterByContact { get; set; }
		[CProperty(Association ="VwMandrillRecipientV2:ContactId")]
		public virtual ICollection<VwMandrillRecipientV2> VwMandrillRecipientV2ByContact { get; set; }
		[CProperty(Association ="VwMeetConLeadGenBonus:ContactId")]
		public virtual ICollection<VwMeetConLeadGenBonus> VwMeetConLeadGenBonusByContact { get; set; }
		[CProperty(Association ="VwMeetDoneLeadGenBonus:ContactId")]
		public virtual ICollection<VwMeetDoneLeadGenBonus> VwMeetDoneLeadGenBonusByContact { get; set; }
		[CProperty(Association ="VwModuleHistory:ContactId")]
		public virtual ICollection<VwModuleHistory> VwModuleHistoryByContact { get; set; }
		[CProperty(Association ="VwNewClientsBySubscription:OwnerId")]
		public virtual ICollection<VwNewClientsBySubscription> VwNewClientsBySubscriptionByOwner { get; set; }
		[CProperty(Association ="VwOpportInStageForAnalysis:OwnerId")]
		public virtual ICollection<VwOpportInStageForAnalysis> VwOpportInStageForAnalysisByOwner { get; set; }
		[CProperty(Association ="VwOpportunityFile:LockedById")]
		public virtual ICollection<VwOpportunityFile> VwOpportunityFileByLockedBy { get; set; }
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
		[CProperty(Association ="VwQueueItemSuper:OperatorId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByOperator { get; set; }
		[CProperty(Association ="VwQueueItemSuper:ContactId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByContact { get; set; }
		[CProperty(Association ="VwRelationship:ContactAId")]
		public virtual ICollection<VwRelationship> VwRelationshipByContactA { get; set; }
		[CProperty(Association ="VwRelationship:ContactBId")]
		public virtual ICollection<VwRelationship> VwRelationshipByContactB { get; set; }
		[CProperty(Association ="VwRemindings:ContactId")]
		public virtual ICollection<VwRemindings> VwRemindingsByContact { get; set; }
		[CProperty(Association ="VwRemindingsCount:ContactId")]
		public virtual ICollection<VwRemindingsCount> VwRemindingsCountByContact { get; set; }
		[CProperty(Association ="VwSalesOperationalIndicatorsByGroupLeader:ContactId")]
		public virtual ICollection<VwSalesOperationalIndicatorsByGroupLeader> VwSalesOperationalIndicatorsByGroupLeaderByContact { get; set; }
		[CProperty(Association ="VwSalesOperationalIndicatorsByManager:ContactId")]
		public virtual ICollection<VwSalesOperationalIndicatorsByManager> VwSalesOperationalIndicatorsByManagerByContact { get; set; }
		[CProperty(Association ="VwSalesOperationalIndicatorsBySalesDirector:ContactId")]
		public virtual ICollection<VwSalesOperationalIndicatorsBySalesDirector> VwSalesOperationalIndicatorsBySalesDirectorByContact { get; set; }
		[CProperty(Association ="VwServiceRecepients:ContactId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByContact { get; set; }
		[CProperty(Association ="VwSiteEvent:ContactId")]
		public virtual ICollection<VwSiteEvent> VwSiteEventByContact { get; set; }
		[CProperty(Association ="VwSspAdminUnit:ContactId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByContact { get; set; }
		[CProperty(Association ="VwSubordinatesWithManager:ContactId")]
		public virtual ICollection<VwSubordinatesWithManager> VwSubordinatesWithManagerByContact { get; set; }
		[CProperty(Association ="VwSubordinatesWithManager:ContactManagerId")]
		public virtual ICollection<VwSubordinatesWithManager> VwSubordinatesWithManagerByContactManager { get; set; }
		[CProperty(Association ="VwSysAdminUnit:ContactId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByContact { get; set; }
		[CProperty(Association ="VwSysAdminUnitInRole:ContactId")]
		public virtual ICollection<VwSysAdminUnitInRole> VwSysAdminUnitInRoleByContact { get; set; }
		[CProperty(Association ="VwSysProcessElementLog:OwnerId")]
		public virtual ICollection<VwSysProcessElementLog> VwSysProcessElementLogByOwner { get; set; }
		[CProperty(Association ="VwSysProcessFile:LockedById")]
		public virtual ICollection<VwSysProcessFile> VwSysProcessFileByLockedBy { get; set; }
		[CProperty(Association ="VwSysProcessLog:OwnerId")]
		public virtual ICollection<VwSysProcessLog> VwSysProcessLogByOwner { get; set; }
		[CProperty(Association ="VwSystemUsers:ContactId")]
		public virtual ICollection<VwSystemUsers> VwSystemUsersByContact { get; set; }
		[CProperty(Association ="VwTsProject:CreatedById")]
		public virtual ICollection<VwTsProject> VwTsProjectByCreatedBy { get; set; }
		[CProperty(Association ="VwTsProject:ModifiedById")]
		public virtual ICollection<VwTsProject> VwTsProjectByModifiedBy { get; set; }
		[CProperty(Association ="VwTsSalesCareer:AccountManagerId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByAccountManager { get; set; }
		[CProperty(Association ="VwTsSalesCareer:ContactId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByContact { get; set; }
		[CProperty(Association ="VwVisa:SetById")]
		public virtual ICollection<VwVisa> VwVisaBySetBy { get; set; }
		[CProperty(Association ="VwWorkMandrillRecip:ContactId")]
		public virtual ICollection<VwWorkMandrillRecip> VwWorkMandrillRecipByContact { get; set; }
		[CProperty(Association ="VwWorkTripInternalRequest:RequesterId")]
		public virtual ICollection<VwWorkTripInternalRequest> VwWorkTripInternalRequestByRequester { get; set; }
		[CProperty(Association ="WebServiceV2File:LockedById")]
		public virtual ICollection<WebServiceV2File> WebServiceV2FileByLockedBy { get; set; }
		[CProperty(Association ="WorkDeployLogFile:LockedById")]
		public virtual ICollection<WorkDeployLogFile> WorkDeployLogFileByLockedBy { get; set; }
		[CProperty(Association ="WorkFunctionOwner:StakeholderId")]
		public virtual ICollection<WorkFunctionOwner> WorkFunctionOwnerByStakeholder { get; set; }
		[CProperty(Association ="WorkFunctionOwner:OwnerId")]
		public virtual ICollection<WorkFunctionOwner> WorkFunctionOwnerByOwner { get; set; }
		[CProperty(Association ="WSysAccount:ContactId")]
		public virtual ICollection<WSysAccount> WSysAccountByContact { get; set; }
		#endregion
	}
}
