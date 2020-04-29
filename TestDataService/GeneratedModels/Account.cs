using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Account")]
	public class Account : BaseEntity
	{
		#region Values
		private Guid _AccountCategoryId;
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId
		{
			get{return _AccountCategoryId;}
			set
			{
				_AccountCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountLogoId;
		[CProperty(ColumnPath ="AccountLogoId")]
		public Guid AccountLogoId
		{
			get{return _AccountLogoId;}
			set
			{
				_AccountLogoId = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountOwnerId;
		[CProperty(ColumnPath ="AccountOwnerId")]
		public Guid AccountOwnerId
		{
			get{return _AccountOwnerId;}
			set
			{
				_AccountOwnerId = value;
				OnPropertyChanged();
			}
		}
		private string _AdditionalComments;
		[CProperty(ColumnPath ="AdditionalComments")]
		public string AdditionalComments
		{
			get{return _AdditionalComments;}
			set
			{
				_AdditionalComments = value;
				OnPropertyChanged();
			}
		}
		private string _AdditionalPhone;
		[CProperty(ColumnPath ="AdditionalPhone")]
		public string AdditionalPhone
		{
			get{return _AdditionalPhone;}
			set
			{
				_AdditionalPhone = value;
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
		private string _AlternativeName;
		[CProperty(ColumnPath ="AlternativeName")]
		public string AlternativeName
		{
			get{return _AlternativeName;}
			set
			{
				_AlternativeName = value;
				OnPropertyChanged();
			}
		}
		private decimal _AnnualRevenueBC;
		[CProperty(ColumnPath ="AnnualRevenueBC")]
		public decimal AnnualRevenueBC
		{
			get{return _AnnualRevenueBC;}
			set
			{
				_AnnualRevenueBC = value;
				OnPropertyChanged();
			}
		}
		private Guid _AnnualRevenueId;
		[CProperty(ColumnPath ="AnnualRevenueId")]
		public Guid AnnualRevenueId
		{
			get{return _AnnualRevenueId;}
			set
			{
				_AnnualRevenueId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ARRBucketId;
		[CProperty(ColumnPath ="ARRBucketId")]
		public Guid ARRBucketId
		{
			get{return _ARRBucketId;}
			set
			{
				_ARRBucketId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Assets;
		[CProperty(ColumnPath ="Assets")]
		public decimal Assets
		{
			get{return _Assets;}
			set
			{
				_Assets = value;
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
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private Guid _CsmId;
		[CProperty(ColumnPath ="CsmId")]
		public Guid CsmId
		{
			get{return _CsmId;}
			set
			{
				_CsmId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeploymentTypeId;
		[CProperty(ColumnPath ="DeploymentTypeId")]
		public Guid DeploymentTypeId
		{
			get{return _DeploymentTypeId;}
			set
			{
				_DeploymentTypeId = value;
				OnPropertyChanged();
			}
		}
		private decimal _DR;
		[CProperty(ColumnPath ="DR")]
		public decimal DR
		{
			get{return _DR;}
			set
			{
				_DR = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeesNumberId;
		[CProperty(ColumnPath ="EmployeesNumberId")]
		public Guid EmployeesNumberId
		{
			get{return _EmployeesNumberId;}
			set
			{
				_EmployeesNumberId = value;
				OnPropertyChanged();
			}
		}
		private bool _Enterprisebasket;
		[CProperty(ColumnPath ="Enterprisebasket")]
		public bool Enterprisebasket
		{
			get{return _Enterprisebasket;}
			set
			{
				_Enterprisebasket = value;
				OnPropertyChanged();
			}
		}
		private int _ExactNoOfEmployees;
		[CProperty(ColumnPath ="ExactNoOfEmployees")]
		public int ExactNoOfEmployees
		{
			get{return _ExactNoOfEmployees;}
			set
			{
				_ExactNoOfEmployees = value;
				OnPropertyChanged();
			}
		}
		private string _Fax;
		[CProperty(ColumnPath ="Fax")]
		public string Fax
		{
			get{return _Fax;}
			set
			{
				_Fax = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbCustomerId;
		[CProperty(ColumnPath ="GlbCustomerId")]
		public Guid GlbCustomerId
		{
			get{return _GlbCustomerId;}
			set
			{
				_GlbCustomerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbReferenceableDetailsId;
		[CProperty(ColumnPath ="GlbReferenceableDetailsId")]
		public Guid GlbReferenceableDetailsId
		{
			get{return _GlbReferenceableDetailsId;}
			set
			{
				_GlbReferenceableDetailsId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbReferenceableTypeId;
		[CProperty(ColumnPath ="GlbReferenceableTypeId")]
		public Guid GlbReferenceableTypeId
		{
			get{return _GlbReferenceableTypeId;}
			set
			{
				_GlbReferenceableTypeId = value;
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
		private Guid _IndustryId;
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId
		{
			get{return _IndustryId;}
			set
			{
				_IndustryId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _IntegratedOn;
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn
		{
			get{return _IntegratedOn;}
			set
			{
				_IntegratedOn = value;
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
		private byte[] _Logo;
		[CProperty(ColumnPath ="Logo")]
		public byte[] Logo
		{
			get{return _Logo;}
			set
			{
				_Logo = value;
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
		private string _NameENU;
		[CProperty(ColumnPath ="NameENU")]
		public string NameENU
		{
			get{return _NameENU;}
			set
			{
				_NameENU = value;
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
		private int _NumberOfMarketing;
		[CProperty(ColumnPath ="NumberOfMarketing")]
		public int NumberOfMarketing
		{
			get{return _NumberOfMarketing;}
			set
			{
				_NumberOfMarketing = value;
				OnPropertyChanged();
			}
		}
		private int _NumberOfSales;
		[CProperty(ColumnPath ="NumberOfSales")]
		public int NumberOfSales
		{
			get{return _NumberOfSales;}
			set
			{
				_NumberOfSales = value;
				OnPropertyChanged();
			}
		}
		private int _NumberOfService;
		[CProperty(ColumnPath ="NumberOfService")]
		public int NumberOfService
		{
			get{return _NumberOfService;}
			set
			{
				_NumberOfService = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityDepartmentId;
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId
		{
			get{return _OpportunityDepartmentId;}
			set
			{
				_OpportunityDepartmentId = value;
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
		private Guid _OwnershipId;
		[CProperty(ColumnPath ="OwnershipId")]
		public Guid OwnershipId
		{
			get{return _OwnershipId;}
			set
			{
				_OwnershipId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerRoleId;
		[CProperty(ColumnPath ="PartnerRoleId")]
		public Guid PartnerRoleId
		{
			get{return _PartnerRoleId;}
			set
			{
				_PartnerRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerSegmentId;
		[CProperty(ColumnPath ="PartnerSegmentId")]
		public Guid PartnerSegmentId
		{
			get{return _PartnerSegmentId;}
			set
			{
				_PartnerSegmentId = value;
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
		private Guid _PracticeId;
		[CProperty(ColumnPath ="PracticeId")]
		public Guid PracticeId
		{
			get{return _PracticeId;}
			set
			{
				_PracticeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PriceListId;
		[CProperty(ColumnPath ="PriceListId")]
		public Guid PriceListId
		{
			get{return _PriceListId;}
			set
			{
				_PriceListId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PrimaryContactId;
		[CProperty(ColumnPath ="PrimaryContactId")]
		public Guid PrimaryContactId
		{
			get{return _PrimaryContactId;}
			set
			{
				_PrimaryContactId = value;
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
		private Guid _ProductPlatformId;
		[CProperty(ColumnPath ="ProductPlatformId")]
		public Guid ProductPlatformId
		{
			get{return _ProductPlatformId;}
			set
			{
				_ProductPlatformId = value;
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
		private DateTime _RenewalDate;
		[CProperty(ColumnPath ="RenewalDate")]
		public DateTime RenewalDate
		{
			get{return _RenewalDate;}
			set
			{
				_RenewalDate = value;
				OnPropertyChanged();
			}
		}
		private bool _SegmentVerification;
		[CProperty(ColumnPath ="SegmentVerification")]
		public bool SegmentVerification
		{
			get{return _SegmentVerification;}
			set
			{
				_SegmentVerification = value;
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
		private Guid _SubIndustryId;
		[CProperty(ColumnPath ="SubIndustryId")]
		public Guid SubIndustryId
		{
			get{return _SubIndustryId;}
			set
			{
				_SubIndustryId = value;
				OnPropertyChanged();
			}
		}
		private string _SupportNotes;
		[CProperty(ColumnPath ="SupportNotes")]
		public string SupportNotes
		{
			get{return _SupportNotes;}
			set
			{
				_SupportNotes = value;
				OnPropertyChanged();
			}
		}
		private Guid _TerritoryId;
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId
		{
			get{return _TerritoryId;}
			set
			{
				_TerritoryId = value;
				OnPropertyChanged();
			}
		}
		private bool _Top50;
		[CProperty(ColumnPath ="Top50")]
		public bool Top50
		{
			get{return _Top50;}
			set
			{
				_Top50 = value;
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
		private Guid _Uid1C;
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C
		{
			get{return _Uid1C;}
			set
			{
				_Uid1C = value;
				OnPropertyChanged();
			}
		}
		private string _Web;
		[CProperty(ColumnPath ="Web")]
		public string Web
		{
			get{return _Web;}
			set
			{
				_Web = value;
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
		[CProperty(Navigation ="Account:ParentId")]
		public Account Parent { get; set; }
		[CProperty(Navigation ="Account:AccountOwnerId")]
		public Account AccountOwner { get; set; }
		[CProperty(Navigation ="AccountAnnualRevenue:AnnualRevenueId")]
		public AccountAnnualRevenue AnnualRevenue { get; set; }
		[CProperty(Navigation ="AccountARRBucket:ARRBucketId")]
		public AccountARRBucket ARRBucket { get; set; }
		[CProperty(Navigation ="AccountCategory:AccountCategoryId")]
		public AccountCategory AccountCategory { get; set; }
		[CProperty(Navigation ="AccountEmployeesNumber:EmployeesNumberId")]
		public AccountEmployeesNumber EmployeesNumber { get; set; }
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation ="AccountOwnership:OwnershipId")]
		public AccountOwnership Ownership { get; set; }
		[CProperty(Navigation ="AccountStatus:StatusId")]
		public AccountStatus Status { get; set; }
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
		[CProperty(Navigation ="Contact:CsmId")]
		public Contact Csm { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="DeploymentType:DeploymentTypeId")]
		public DeploymentType DeploymentType { get; set; }
		[CProperty(Navigation ="GlbCustomer:GlbCustomerId")]
		public GlbCustomer GlbCustomer { get; set; }
		[CProperty(Navigation ="GlbReferenceableDetails:GlbReferenceableDetailsId")]
		public GlbReferenceableDetails GlbReferenceableDetails { get; set; }
		[CProperty(Navigation ="GlbReferenceableTypeValue:GlbReferenceableTypeId")]
		public GlbReferenceableTypeValue GlbReferenceableType { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		[CProperty(Navigation ="PartnerProjectRole:PartnerRoleId")]
		public PartnerProjectRole PartnerRole { get; set; }
		[CProperty(Navigation ="PartnerSegment:PartnerSegmentId")]
		public PartnerSegment PartnerSegment { get; set; }
		[CProperty(Navigation ="Practice:PracticeId")]
		public Practice Practice { get; set; }
		[CProperty(Navigation ="Pricelist:PriceListId")]
		public Pricelist PriceList { get; set; }
		[CProperty(Navigation ="ProductPlatform:ProductPlatformId")]
		public ProductPlatform ProductPlatform { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="SubIndustry:SubIndustryId")]
		public SubIndustry SubIndustry { get; set; }
		[CProperty(Navigation ="SysImage:AccountLogoId")]
		public SysImage AccountLogo { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:ParentId")]
		public virtual ICollection<Account> AccountByParent { get; set; }
		[CProperty(Association ="Account:AccountOwnerId")]
		public virtual ICollection<Account> AccountByAccountOwner { get; set; }
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
		[CProperty(Association ="AccountCompleteness:AccountId")]
		public virtual ICollection<AccountCompleteness> AccountCompletenessByAccount { get; set; }
		[CProperty(Association ="AccountDataSourceList:AccountId")]
		public virtual ICollection<AccountDataSourceList> AccountDataSourceListByAccount { get; set; }
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
		[CProperty(Association ="AccountSegmentVerification:AccountId")]
		public virtual ICollection<AccountSegmentVerification> AccountSegmentVerificationByAccount { get; set; }
		[CProperty(Association ="AccountStageHistory:AccountId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByAccount { get; set; }
		[CProperty(Association ="AccountStageHistory:AccountOwnerId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByAccountOwner { get; set; }
		[CProperty(Association ="Activity:AccountId")]
		public virtual ICollection<Activity> ActivityByAccount { get; set; }
		[CProperty(Association ="Applicant:CurrentAccountId")]
		public virtual ICollection<Applicant> ApplicantByCurrentAccount { get; set; }
		[CProperty(Association ="Call:AccountId")]
		public virtual ICollection<Call> CallByAccount { get; set; }
		[CProperty(Association ="Case:AccountId")]
		public virtual ICollection<Case> CaseByAccount { get; set; }
		[CProperty(Association ="Case:PDEReferenceProviderId")]
		public virtual ICollection<Case> CaseByPDEReferenceProvider { get; set; }
		[CProperty(Association ="CaseLifecycle:AccountId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByAccount { get; set; }
		[CProperty(Association ="ClientARRInPeriod:AccountId")]
		public virtual ICollection<ClientARRInPeriod> ClientARRInPeriodByAccount { get; set; }
		[CProperty(Association ="ClientSaaSMetrics:AccountId")]
		public virtual ICollection<ClientSaaSMetrics> ClientSaaSMetricsByAccount { get; set; }
		[CProperty(Association ="CompetitorProduct:CompetitorId")]
		public virtual ICollection<CompetitorProduct> CompetitorProductByCompetitor { get; set; }
		[CProperty(Association ="ConfItem:AccountId")]
		public virtual ICollection<ConfItem> ConfItemByAccount { get; set; }
		[CProperty(Association ="ConfItem:PartnerAccountId")]
		public virtual ICollection<ConfItem> ConfItemByPartnerAccount { get; set; }
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
		[CProperty(Association ="DefaultReport:SupplierId")]
		public virtual ICollection<DefaultReport> DefaultReportBySupplier { get; set; }
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
		[CProperty(Association ="EventTarget:PartnerId")]
		public virtual ICollection<EventTarget> EventTargetByPartner { get; set; }
		[CProperty(Association ="EventTeam:AccountId")]
		public virtual ICollection<EventTeam> EventTeamByAccount { get; set; }
		[CProperty(Association ="ExesInRequest:SupplierId")]
		public virtual ICollection<ExesInRequest> ExesInRequestBySupplier { get; set; }
		[CProperty(Association ="GlbCustomer:GlbAssignedPartnerId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbAssignedPartner { get; set; }
		[CProperty(Association ="GlbCustomer:GlbCustomerAccountId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbCustomerAccount { get; set; }
		[CProperty(Association ="GlbCustomerGift:GlbGiftAccountId")]
		public virtual ICollection<GlbCustomerGift> GlbCustomerGiftByGlbGiftAccount { get; set; }
		[CProperty(Association ="GlbCustomerKeyPlayerList:GlbAccountInCustomerId")]
		public virtual ICollection<GlbCustomerKeyPlayerList> GlbCustomerKeyPlayerListByGlbAccountInCustomer { get; set; }
		[CProperty(Association ="GlbReferenceable:GlbAccountCustomerId")]
		public virtual ICollection<GlbReferenceable> GlbReferenceableByGlbAccountCustomer { get; set; }
		[CProperty(Association ="InternalRequest:AccountId")]
		public virtual ICollection<InternalRequest> InternalRequestByAccount { get; set; }
		[CProperty(Association ="InternalRequest:PartnerId")]
		public virtual ICollection<InternalRequest> InternalRequestByPartner { get; set; }
		[CProperty(Association ="Investor:AccountId")]
		public virtual ICollection<Investor> InvestorByAccount { get; set; }
		[CProperty(Association ="Invoice:AccountId")]
		public virtual ICollection<Invoice> InvoiceByAccount { get; set; }
		[CProperty(Association ="Invoice:SupplierId")]
		public virtual ICollection<Invoice> InvoiceBySupplier { get; set; }
		[CProperty(Association ="Invoice:PayerId")]
		public virtual ICollection<Invoice> InvoiceByPayer { get; set; }
		[CProperty(Association ="KnowledgeBase:PDEAccountId")]
		public virtual ICollection<KnowledgeBase> KnowledgeBaseByPDEAccount { get; set; }
		[CProperty(Association ="Lead:QualifiedAccountId")]
		public virtual ICollection<Lead> LeadByQualifiedAccount { get; set; }
		[CProperty(Association ="Lead:PartnerId")]
		public virtual ICollection<Lead> LeadByPartner { get; set; }
		[CProperty(Association ="LeadCompetitor:CompetitorId")]
		public virtual ICollection<LeadCompetitor> LeadCompetitorByCompetitor { get; set; }
		[CProperty(Association ="LeadCompetitor:SupplierId")]
		public virtual ICollection<LeadCompetitor> LeadCompetitorBySupplier { get; set; }
		[CProperty(Association ="LeadQualification:AccountId")]
		public virtual ICollection<LeadQualification> LeadQualificationByAccount { get; set; }
		[CProperty(Association ="MarketplaceApplication:AccountId")]
		public virtual ICollection<MarketplaceApplication> MarketplaceApplicationByAccount { get; set; }
		[CProperty(Association ="MktgActivity:AccountId")]
		public virtual ICollection<MktgActivity> MktgActivityByAccount { get; set; }
		[CProperty(Association ="NPS:GlbNPSbyCustomerId")]
		public virtual ICollection<NPS> NPSByGlbNPSbyCustomer { get; set; }
		[CProperty(Association ="OppForecastWizPartners:PartnerId")]
		public virtual ICollection<OppForecastWizPartners> OppForecastWizPartnersByPartner { get; set; }
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
		[CProperty(Association ="OpportunityContact:GlbAccountId")]
		public virtual ICollection<OpportunityContact> OpportunityContactByGlbAccount { get; set; }
		[CProperty(Association ="OpportunityParticipant:AccountId")]
		public virtual ICollection<OpportunityParticipant> OpportunityParticipantByAccount { get; set; }
		[CProperty(Association ="OpportunityPartner:PartnerId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByPartner { get; set; }
		[CProperty(Association ="OpportunityPartnerHistory:PartnerId")]
		public virtual ICollection<OpportunityPartnerHistory> OpportunityPartnerHistoryByPartner { get; set; }
		[CProperty(Association ="OpportunityReference:AccountId")]
		public virtual ICollection<OpportunityReference> OpportunityReferenceByAccount { get; set; }
		[CProperty(Association ="Order:AccountId")]
		public virtual ICollection<Order> OrderByAccount { get; set; }
		[CProperty(Association ="Order:SupplierId")]
		public virtual ICollection<Order> OrderBySupplier { get; set; }
		[CProperty(Association ="Order:PartnerId")]
		public virtual ICollection<Order> OrderByPartner { get; set; }
		[CProperty(Association ="OrderExpense:TargetId")]
		public virtual ICollection<OrderExpense> OrderExpenseByTarget { get; set; }
		[CProperty(Association ="PartnerDomain:PartnerAccountId")]
		public virtual ICollection<PartnerDomain> PartnerDomainByPartnerAccount { get; set; }
		[CProperty(Association ="Partnership:AccountId")]
		public virtual ICollection<Partnership> PartnershipByAccount { get; set; }
		[CProperty(Association ="PDEClientCaseCompetitor:PDECompetitorId")]
		public virtual ICollection<PDEClientCaseCompetitor> PDEClientCaseCompetitorByPDECompetitor { get; set; }
		[CProperty(Association ="PDEClientNeedInKnowledgeBase:PDEPartnerId")]
		public virtual ICollection<PDEClientNeedInKnowledgeBase> PDEClientNeedInKnowledgeBaseByPDEPartner { get; set; }
		[CProperty(Association ="PDECustomerNeedInCustomer:PDEPartnerId")]
		public virtual ICollection<PDECustomerNeedInCustomer> PDECustomerNeedInCustomerByPDEPartner { get; set; }
		[CProperty(Association ="PRMTransaction:PartnerAccountId")]
		public virtual ICollection<PRMTransaction> PRMTransactionByPartnerAccount { get; set; }
		[CProperty(Association ="PRMTransactionHistory:PartnerAccountId")]
		public virtual ICollection<PRMTransactionHistory> PRMTransactionHistoryByPartnerAccount { get; set; }
		[CProperty(Association ="Product:PartnerId")]
		public virtual ICollection<Product> ProductByPartner { get; set; }
		[CProperty(Association ="ProductForLicGenerator:AccountId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByAccount { get; set; }
		[CProperty(Association ="ProductInSubscription:AccountId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByAccount { get; set; }
		[CProperty(Association ="Project:AccountId")]
		public virtual ICollection<Project> ProjectByAccount { get; set; }
		[CProperty(Association ="Project:SupplierId")]
		public virtual ICollection<Project> ProjectBySupplier { get; set; }
		[CProperty(Association ="QueueItemReaction:AccountId")]
		public virtual ICollection<QueueItemReaction> QueueItemReactionByAccount { get; set; }
		[CProperty(Association ="QuickDialUserSettings:AccountId")]
		public virtual ICollection<QuickDialUserSettings> QuickDialUserSettingsByAccount { get; set; }
		[CProperty(Association ="RegionalLanguagePartner:PartnerAccountId")]
		public virtual ICollection<RegionalLanguagePartner> RegionalLanguagePartnerByPartnerAccount { get; set; }
		[CProperty(Association ="Relationship:AccountAId")]
		public virtual ICollection<Relationship> RelationshipByAccountA { get; set; }
		[CProperty(Association ="Relationship:AccountBId")]
		public virtual ICollection<Relationship> RelationshipByAccountB { get; set; }
		[CProperty(Association ="SaaSMetrics:AccountId")]
		public virtual ICollection<SaaSMetrics> SaaSMetricsByAccount { get; set; }
		[CProperty(Association ="SaaSMetricsTransactions:AccountId")]
		public virtual ICollection<SaaSMetricsTransactions> SaaSMetricsTransactionsByAccount { get; set; }
		[CProperty(Association ="SaaSMetrix:AccountId")]
		public virtual ICollection<SaaSMetrix> SaaSMetrixByAccount { get; set; }
		[CProperty(Association ="ScreenResult:AccountId")]
		public virtual ICollection<ScreenResult> ScreenResultByAccount { get; set; }
		[CProperty(Association ="Segment:AccountId")]
		public virtual ICollection<Segment> SegmentByAccount { get; set; }
		[CProperty(Association ="ServiceObject:AccountId")]
		public virtual ICollection<ServiceObject> ServiceObjectByAccount { get; set; }
		[CProperty(Association ="ServicePact:ServiceProviderId")]
		public virtual ICollection<ServicePact> ServicePactByServiceProvider { get; set; }
		[CProperty(Association ="ServicePact:AccountId")]
		public virtual ICollection<ServicePact> ServicePactByAccount { get; set; }
		[CProperty(Association ="Sites:AccountId")]
		public virtual ICollection<Sites> SitesByAccount { get; set; }
		[CProperty(Association ="Subscription:AccountId")]
		public virtual ICollection<Subscription> SubscriptionByAccount { get; set; }
		[CProperty(Association ="SupCustomScore:SupAccountId")]
		public virtual ICollection<SupCustomScore> SupCustomScoreBySupAccount { get; set; }
		[CProperty(Association ="SupplyPaymentElement:TargetId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByTarget { get; set; }
		[CProperty(Association ="SupplyPaymentElement:PartnerId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByPartner { get; set; }
		[CProperty(Association ="SysAdminUnit:AccountId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByAccount { get; set; }
		[CProperty(Association ="SysAdminUnit:PortalAccountId")]
		public virtual ICollection<SysAdminUnit> SysAdminUnitByPortalAccount { get; set; }
		[CProperty(Association ="TableStatistics:AccountId")]
		public virtual ICollection<TableStatistics> TableStatisticsByAccount { get; set; }
		[CProperty(Association ="Transaction:AccountId")]
		public virtual ICollection<Transaction> TransactionByAccount { get; set; }
		[CProperty(Association ="TransactionForecast:AccountId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByAccount { get; set; }
		[CProperty(Association ="TsOrderExpense:PartnerId")]
		public virtual ICollection<TsOrderExpense> TsOrderExpenseByPartner { get; set; }
		[CProperty(Association ="TsOrderExpense:ClientId")]
		public virtual ICollection<TsOrderExpense> TsOrderExpenseByClient { get; set; }
		[CProperty(Association ="UserSessions:AccountId")]
		public virtual ICollection<UserSessions> UserSessionsByAccount { get; set; }
		[CProperty(Association ="UserSessionsNew:AccountId")]
		public virtual ICollection<UserSessionsNew> UserSessionsNewByAccount { get; set; }
		[CProperty(Association ="VwAccountDuplicate:Entity1Id")]
		public virtual ICollection<VwAccountDuplicate> VwAccountDuplicateByEntity1 { get; set; }
		[CProperty(Association ="VwAccountDuplicate:Entity2Id")]
		public virtual ICollection<VwAccountDuplicate> VwAccountDuplicateByEntity2 { get; set; }
		[CProperty(Association ="VwAccountFile:AccountId")]
		public virtual ICollection<VwAccountFile> VwAccountFileByAccount { get; set; }
		[CProperty(Association ="VwAccountModuleHistory:AccountId")]
		public virtual ICollection<VwAccountModuleHistory> VwAccountModuleHistoryByAccount { get; set; }
		[CProperty(Association ="VwAccountRelationship:AccountId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByAccount { get; set; }
		[CProperty(Association ="VwAccountRelationship:RelatedAccountId")]
		public virtual ICollection<VwAccountRelationship> VwAccountRelationshipByRelatedAccount { get; set; }
		[CProperty(Association ="VwAccountStatusHistory:AccountId")]
		public virtual ICollection<VwAccountStatusHistory> VwAccountStatusHistoryByAccount { get; set; }
		[CProperty(Association ="VwAnniversary:AccountId")]
		public virtual ICollection<VwAnniversary> VwAnniversaryByAccount { get; set; }
		[CProperty(Association ="VwCaseDashboard:AccountId")]
		public virtual ICollection<VwCaseDashboard> VwCaseDashboardByAccount { get; set; }
		[CProperty(Association ="VwContactRelationship:RelatedAccountId")]
		public virtual ICollection<VwContactRelationship> VwContactRelationshipByRelatedAccount { get; set; }
		[CProperty(Association ="VwEventInContact:AccountId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByAccount { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:AccountId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByAccount { get; set; }
		[CProperty(Association ="VwGroupSysAdminUnit:PortalAccountId")]
		public virtual ICollection<VwGroupSysAdminUnit> VwGroupSysAdminUnitByPortalAccount { get; set; }
		[CProperty(Association ="VwLead:QualifiedAccountId")]
		public virtual ICollection<VwLead> VwLeadByQualifiedAccount { get; set; }
		[CProperty(Association ="VwLead:PartnerId")]
		public virtual ICollection<VwLead> VwLeadByPartner { get; set; }
		[CProperty(Association ="VwMandrillRecipient:AccountId")]
		public virtual ICollection<VwMandrillRecipient> VwMandrillRecipientByAccount { get; set; }
		[CProperty(Association ="VwMandrillRecipientFilter:AccountId")]
		public virtual ICollection<VwMandrillRecipientFilter> VwMandrillRecipientFilterByAccount { get; set; }
		[CProperty(Association ="VwModuleHistory:AccountId")]
		public virtual ICollection<VwModuleHistory> VwModuleHistoryByAccount { get; set; }
		[CProperty(Association ="VwNewClientsBySubscription:AccountId")]
		public virtual ICollection<VwNewClientsBySubscription> VwNewClientsBySubscriptionByAccount { get; set; }
		[CProperty(Association ="VwPortalOpportunity:AccountId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByAccount { get; set; }
		[CProperty(Association ="VwPortalOpportunity:PartnerId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByPartner { get; set; }
		[CProperty(Association ="VwProjectHierarchy:AccountId")]
		public virtual ICollection<VwProjectHierarchy> VwProjectHierarchyByAccount { get; set; }
		[CProperty(Association ="VwQueueItem:AccountId")]
		public virtual ICollection<VwQueueItem> VwQueueItemByAccount { get; set; }
		[CProperty(Association ="VwQueueItemSuper:AccountId")]
		public virtual ICollection<VwQueueItemSuper> VwQueueItemSuperByAccount { get; set; }
		[CProperty(Association ="VwRelationship:AccountAId")]
		public virtual ICollection<VwRelationship> VwRelationshipByAccountA { get; set; }
		[CProperty(Association ="VwRelationship:AccountBId")]
		public virtual ICollection<VwRelationship> VwRelationshipByAccountB { get; set; }
		[CProperty(Association ="VwServicePactActive:AccountId")]
		public virtual ICollection<VwServicePactActive> VwServicePactActiveByAccount { get; set; }
		[CProperty(Association ="VwServiceRecepients:AccountId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByAccount { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsage:AccountId")]
		public virtual ICollection<VwSiteStatModuleUsage> VwSiteStatModuleUsageByAccount { get; set; }
		[CProperty(Association ="VwSiteStatModuleUsageHistory:AccountId")]
		public virtual ICollection<VwSiteStatModuleUsageHistory> VwSiteStatModuleUsageHistoryByAccount { get; set; }
		[CProperty(Association ="VwSspAdminUnit:AccountId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByAccount { get; set; }
		[CProperty(Association ="VwSspAdminUnit:PortalAccountId")]
		public virtual ICollection<VwSspAdminUnit> VwSspAdminUnitByPortalAccount { get; set; }
		[CProperty(Association ="VwSysAdminUnit:AccountId")]
		public virtual ICollection<VwSysAdminUnit> VwSysAdminUnitByAccount { get; set; }
		[CProperty(Association ="VwTransaction:AccountId")]
		public virtual ICollection<VwTransaction> VwTransactionByAccount { get; set; }
		[CProperty(Association ="VwTSSLA:AccountId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByAccount { get; set; }
		[CProperty(Association ="VwTSSLAArchive:AccountId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByAccount { get; set; }
		[CProperty(Association ="VwWorkMandrillRecip:AccountId")]
		public virtual ICollection<VwWorkMandrillRecip> VwWorkMandrillRecipByAccount { get; set; }
		#endregion
	}
}
