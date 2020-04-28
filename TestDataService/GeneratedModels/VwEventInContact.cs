using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwEventInContact")]
	public class VwEventInContact : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="Address")]
		public string Address { get; set; }
		[CProperty(ColumnPath ="AddressTypeId")]
		public Guid AddressTypeId { get; set; }
		[CProperty(ColumnPath ="Age")]
		public int Age { get; set; }
		[CProperty(ColumnPath ="BirthDate")]
		public DateTime BirthDate { get; set; }
		[CProperty(ColumnPath ="BpmManageDataPrivacyId")]
		public Guid BpmManageDataPrivacyId { get; set; }
		[CProperty(ColumnPath ="BulkEmailConfItems")]
		public string BulkEmailConfItems { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="Completeness")]
		public int Completeness { get; set; }
		[CProperty(ColumnPath ="Confirmed")]
		public bool Confirmed { get; set; }
		[CProperty(ColumnPath ="ContactPhoto")]
		public byte[] ContactPhoto { get; set; }
		[CProperty(ColumnPath ="ContactSourceId")]
		public Guid ContactSourceId { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Dear")]
		public string Dear { get; set; }
		[CProperty(ColumnPath ="DearUkr")]
		public string DearUkr { get; set; }
		[CProperty(ColumnPath ="DecisionRoleId")]
		public Guid DecisionRoleId { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="DirectPhone")]
		public string DirectPhone { get; set; }
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
		[CProperty(ColumnPath ="Email")]
		public string Email { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="EventResponseId")]
		public Guid EventResponseId { get; set; }
		[CProperty(ColumnPath ="EventTargetDescription")]
		public string EventTargetDescription { get; set; }
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
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsNonActualEmail")]
		public bool IsNonActualEmail { get; set; }
		[CProperty(ColumnPath ="JobENG")]
		public string JobENG { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle { get; set; }
		[CProperty(ColumnPath ="LABActualAnonymizationDate")]
		public DateTime LABActualAnonymizationDate { get; set; }
		[CProperty(ColumnPath ="LABMarkedForAnonymizationDate")]
		public DateTime LABMarkedForAnonymizationDate { get; set; }
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
		[CProperty(ColumnPath ="NameEng")]
		public string NameEng { get; set; }
		[CProperty(ColumnPath ="NewsSubscription")]
		public bool NewsSubscription { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="Phone")]
		public string Phone { get; set; }
		[CProperty(ColumnPath ="PhotoId")]
		public Guid PhotoId { get; set; }
		[CProperty(ColumnPath ="PredictiveScoring")]
		public decimal PredictiveScoring { get; set; }
		[CProperty(ColumnPath ="PrimaryLanguageId")]
		public Guid PrimaryLanguageId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
		[CProperty(ColumnPath ="SalutationTypeId")]
		public Guid SalutationTypeId { get; set; }
		[CProperty(ColumnPath ="Score")]
		public int Score { get; set; }
		[CProperty(ColumnPath ="ScoreDemographic")]
		public int ScoreDemographic { get; set; }
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
		[CProperty(ColumnPath ="WebinarsSubscription")]
		public bool WebinarsSubscription { get; set; }
		[CProperty(ColumnPath ="Zip")]
		public string Zip { get; set; }
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
