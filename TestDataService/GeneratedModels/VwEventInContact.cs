using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwEventInContact")]
	public class VwEventInContact : BaseEntity
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
		private Guid _EventResponseId;
		[CProperty(ColumnPath ="EventResponseId")]
		public Guid EventResponseId
		{
			get{return _EventResponseId;}
			set
			{
				_EventResponseId = value;
				OnPropertyChanged();
			}
		}
		private string _EventTargetDescription;
		[CProperty(ColumnPath ="EventTargetDescription")]
		public string EventTargetDescription
		{
			get{return _EventTargetDescription;}
			set
			{
				_EventTargetDescription = value;
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
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="EventResponse:EventResponseId")]
		public EventResponse EventResponse { get; set; }
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
		#endregion
	}
}
