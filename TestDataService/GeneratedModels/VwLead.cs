using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwLead")]
	public class VwLead : BaseEntity
	{
		#region Values
		private string _Account;
		[CProperty(ColumnPath ="Account")]
		public string Account
		{
			get{return _Account;}
			set
			{
				_Account = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountBillingInfoId;
		[CProperty(ColumnPath ="AccountBillingInfoId")]
		public Guid AccountBillingInfoId
		{
			get{return _AccountBillingInfoId;}
			set
			{
				_AccountBillingInfoId = value;
				OnPropertyChanged();
			}
		}
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
		private Guid _AccountOwnershipId;
		[CProperty(ColumnPath ="AccountOwnershipId")]
		public Guid AccountOwnershipId
		{
			get{return _AccountOwnershipId;}
			set
			{
				_AccountOwnershipId = value;
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
		private Guid _BonusSchemeId;
		[CProperty(ColumnPath ="BonusSchemeId")]
		public Guid BonusSchemeId
		{
			get{return _BonusSchemeId;}
			set
			{
				_BonusSchemeId = value;
				OnPropertyChanged();
			}
		}
		private bool _BpmEmailConfirmed;
		[CProperty(ColumnPath ="BpmEmailConfirmed")]
		public bool BpmEmailConfirmed
		{
			get{return _BpmEmailConfirmed;}
			set
			{
				_BpmEmailConfirmed = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmGDPRId;
		[CProperty(ColumnPath ="BpmGDPRId")]
		public Guid BpmGDPRId
		{
			get{return _BpmGDPRId;}
			set
			{
				_BpmGDPRId = value;
				OnPropertyChanged();
			}
		}
		private string _BpmHref;
		[CProperty(ColumnPath ="BpmHref")]
		public string BpmHref
		{
			get{return _BpmHref;}
			set
			{
				_BpmHref = value;
				OnPropertyChanged();
			}
		}
		private bool _BpmMarketingCommAgreement;
		[CProperty(ColumnPath ="BpmMarketingCommAgreement")]
		public bool BpmMarketingCommAgreement
		{
			get{return _BpmMarketingCommAgreement;}
			set
			{
				_BpmMarketingCommAgreement = value;
				OnPropertyChanged();
			}
		}
		private string _BpmonlineComment;
		[CProperty(ColumnPath ="BpmonlineComment")]
		public string BpmonlineComment
		{
			get{return _BpmonlineComment;}
			set
			{
				_BpmonlineComment = value;
				OnPropertyChanged();
			}
		}
		private string _BpmRef;
		[CProperty(ColumnPath ="BpmRef")]
		public string BpmRef
		{
			get{return _BpmRef;}
			set
			{
				_BpmRef = value;
				OnPropertyChanged();
			}
		}
		private Guid _BpmSessionId;
		[CProperty(ColumnPath ="BpmSessionId")]
		public Guid BpmSessionId
		{
			get{return _BpmSessionId;}
			set
			{
				_BpmSessionId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Budget;
		[CProperty(ColumnPath ="Budget")]
		public decimal Budget
		{
			get{return _Budget;}
			set
			{
				_Budget = value;
				OnPropertyChanged();
			}
		}
		private Guid _BulkEmailId;
		[CProperty(ColumnPath ="BulkEmailId")]
		public Guid BulkEmailId
		{
			get{return _BulkEmailId;}
			set
			{
				_BulkEmailId = value;
				OnPropertyChanged();
			}
		}
		private string _BusinesPhone;
		[CProperty(ColumnPath ="BusinesPhone")]
		public string BusinesPhone
		{
			get{return _BusinesPhone;}
			set
			{
				_BusinesPhone = value;
				OnPropertyChanged();
			}
		}
		private Guid _CampaignId;
		[CProperty(ColumnPath ="CampaignId")]
		public Guid CampaignId
		{
			get{return _CampaignId;}
			set
			{
				_CampaignId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
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
		private string _CityStr;
		[CProperty(ColumnPath ="CityStr")]
		public string CityStr
		{
			get{return _CityStr;}
			set
			{
				_CityStr = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClientLeadMediumId;
		[CProperty(ColumnPath ="ClientLeadMediumId")]
		public Guid ClientLeadMediumId
		{
			get{return _ClientLeadMediumId;}
			set
			{
				_ClientLeadMediumId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ClientLeadSourceId;
		[CProperty(ColumnPath ="ClientLeadSourceId")]
		public Guid ClientLeadSourceId
		{
			get{return _ClientLeadSourceId;}
			set
			{
				_ClientLeadSourceId = value;
				OnPropertyChanged();
			}
		}
		private string _Commentary;
		[CProperty(ColumnPath ="Commentary")]
		public string Commentary
		{
			get{return _Commentary;}
			set
			{
				_Commentary = value;
				OnPropertyChanged();
			}
		}
		private string _Contact;
		[CProperty(ColumnPath ="Contact")]
		public string Contact
		{
			get{return _Contact;}
			set
			{
				_Contact = value;
				OnPropertyChanged();
			}
		}
		private decimal _ConversionProbability;
		[CProperty(ColumnPath ="ConversionProbability")]
		public decimal ConversionProbability
		{
			get{return _ConversionProbability;}
			set
			{
				_ConversionProbability = value;
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
		private string _CountryStr;
		[CProperty(ColumnPath ="CountryStr")]
		public string CountryStr
		{
			get{return _CountryStr;}
			set
			{
				_CountryStr = value;
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
		private bool _CreditForKPI;
		[CProperty(ColumnPath ="CreditForKPI")]
		public bool CreditForKPI
		{
			get{return _CreditForKPI;}
			set
			{
				_CreditForKPI = value;
				OnPropertyChanged();
			}
		}
		private string _CustomerIP;
		[CProperty(ColumnPath ="CustomerIP")]
		public string CustomerIP
		{
			get{return _CustomerIP;}
			set
			{
				_CustomerIP = value;
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
		private DateTime _DecisionDate;
		[CProperty(ColumnPath ="DecisionDate")]
		public DateTime DecisionDate
		{
			get{return _DecisionDate;}
			set
			{
				_DecisionDate = value;
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
		private string _Domain;
		[CProperty(ColumnPath ="Domain")]
		public string Domain
		{
			get{return _Domain;}
			set
			{
				_Domain = value;
				OnPropertyChanged();
			}
		}
		private bool _DoNotCreateQueueItem;
		[CProperty(ColumnPath ="DoNotCreateQueueItem")]
		public bool DoNotCreateQueueItem
		{
			get{return _DoNotCreateQueueItem;}
			set
			{
				_DoNotCreateQueueItem = value;
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
		private bool _DoNotUsePhone;
		[CProperty(ColumnPath ="DoNotUsePhone")]
		public bool DoNotUsePhone
		{
			get{return _DoNotUsePhone;}
			set
			{
				_DoNotUsePhone = value;
				OnPropertyChanged();
			}
		}
		private bool _DoNotUseSMS;
		[CProperty(ColumnPath ="DoNotUseSMS")]
		public bool DoNotUseSMS
		{
			get{return _DoNotUseSMS;}
			set
			{
				_DoNotUseSMS = value;
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
		private string _FullJobTitle;
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle
		{
			get{return _FullJobTitle;}
			set
			{
				_FullJobTitle = value;
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
		private string _GoogleAnalytics;
		[CProperty(ColumnPath ="GoogleAnalytics")]
		public string GoogleAnalytics
		{
			get{return _GoogleAnalytics;}
			set
			{
				_GoogleAnalytics = value;
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
		private bool _IdentificationPassed;
		[CProperty(ColumnPath ="IdentificationPassed")]
		public bool IdentificationPassed
		{
			get{return _IdentificationPassed;}
			set
			{
				_IdentificationPassed = value;
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
		private Guid _InformationSourceId;
		[CProperty(ColumnPath ="InformationSourceId")]
		public Guid InformationSourceId
		{
			get{return _InformationSourceId;}
			set
			{
				_InformationSourceId = value;
				OnPropertyChanged();
			}
		}
		private string _InitialPain;
		[CProperty(ColumnPath ="InitialPain")]
		public string InitialPain
		{
			get{return _InitialPain;}
			set
			{
				_InitialPain = value;
				OnPropertyChanged();
			}
		}
		private bool _IsAccountWhileQualification;
		[CProperty(ColumnPath ="IsAccountWhileQualification")]
		public bool IsAccountWhileQualification
		{
			get{return _IsAccountWhileQualification;}
			set
			{
				_IsAccountWhileQualification = value;
				OnPropertyChanged();
			}
		}
		private bool _IsISR;
		[CProperty(ColumnPath ="IsISR")]
		public bool IsISR
		{
			get{return _IsISR;}
			set
			{
				_IsISR = value;
				OnPropertyChanged();
			}
		}
		private bool _IsMeetingNotScheduled;
		[CProperty(ColumnPath ="IsMeetingNotScheduled")]
		public bool IsMeetingNotScheduled
		{
			get{return _IsMeetingNotScheduled;}
			set
			{
				_IsMeetingNotScheduled = value;
				OnPropertyChanged();
			}
		}
		private bool _IsOkToProcessPD;
		[CProperty(ColumnPath ="IsOkToProcessPD")]
		public bool IsOkToProcessPD
		{
			get{return _IsOkToProcessPD;}
			set
			{
				_IsOkToProcessPD = value;
				OnPropertyChanged();
			}
		}
		private bool _IsTrialConfirmed;
		[CProperty(ColumnPath ="IsTrialConfirmed")]
		public bool IsTrialConfirmed
		{
			get{return _IsTrialConfirmed;}
			set
			{
				_IsTrialConfirmed = value;
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
		private Guid _LeadCloseReasonId;
		[CProperty(ColumnPath ="LeadCloseReasonId")]
		public Guid LeadCloseReasonId
		{
			get{return _LeadCloseReasonId;}
			set
			{
				_LeadCloseReasonId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadCloudId;
		[CProperty(ColumnPath ="LeadCloudId")]
		public Guid LeadCloudId
		{
			get{return _LeadCloudId;}
			set
			{
				_LeadCloudId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadDetailedTypeId;
		[CProperty(ColumnPath ="LeadDetailedTypeId")]
		public Guid LeadDetailedTypeId
		{
			get{return _LeadDetailedTypeId;}
			set
			{
				_LeadDetailedTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadDisqualifyReasonId;
		[CProperty(ColumnPath ="LeadDisqualifyReasonId")]
		public Guid LeadDisqualifyReasonId
		{
			get{return _LeadDisqualifyReasonId;}
			set
			{
				_LeadDisqualifyReasonId = value;
				OnPropertyChanged();
			}
		}
		private string _LeadId;
		[CProperty(ColumnPath ="LeadId")]
		public string LeadId
		{
			get{return _LeadId;}
			set
			{
				_LeadId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadMediumId;
		[CProperty(ColumnPath ="LeadMediumId")]
		public Guid LeadMediumId
		{
			get{return _LeadMediumId;}
			set
			{
				_LeadMediumId = value;
				OnPropertyChanged();
			}
		}
		private string _LeadName;
		[CProperty(ColumnPath ="LeadName")]
		public string LeadName
		{
			get{return _LeadName;}
			set
			{
				_LeadName = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadSourceId;
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId
		{
			get{return _LeadSourceId;}
			set
			{
				_LeadSourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeId;
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId
		{
			get{return _LeadTypeId;}
			set
			{
				_LeadTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeStatusId;
		[CProperty(ColumnPath ="LeadTypeStatusId")]
		public Guid LeadTypeStatusId
		{
			get{return _LeadTypeStatusId;}
			set
			{
				_LeadTypeStatusId = value;
				OnPropertyChanged();
			}
		}
		private string _MarketingActivity;
		[CProperty(ColumnPath ="MarketingActivity")]
		public string MarketingActivity
		{
			get{return _MarketingActivity;}
			set
			{
				_MarketingActivity = value;
				OnPropertyChanged();
			}
		}
		private string _MarketingPartner;
		[CProperty(ColumnPath ="MarketingPartner")]
		public string MarketingPartner
		{
			get{return _MarketingPartner;}
			set
			{
				_MarketingPartner = value;
				OnPropertyChanged();
			}
		}
		private Guid _MarketplaceProductId;
		[CProperty(ColumnPath ="MarketplaceProductId")]
		public Guid MarketplaceProductId
		{
			get{return _MarketplaceProductId;}
			set
			{
				_MarketplaceProductId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _MeetingDate;
		[CProperty(ColumnPath ="MeetingDate")]
		public DateTime MeetingDate
		{
			get{return _MeetingDate;}
			set
			{
				_MeetingDate = value;
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
		private DateTime _MovedToFinalStateOn;
		[CProperty(ColumnPath ="MovedToFinalStateOn")]
		public DateTime MovedToFinalStateOn
		{
			get{return _MovedToFinalStateOn;}
			set
			{
				_MovedToFinalStateOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _NextActualizationDate;
		[CProperty(ColumnPath ="NextActualizationDate")]
		public DateTime NextActualizationDate
		{
			get{return _NextActualizationDate;}
			set
			{
				_NextActualizationDate = value;
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
		private int _NumberOfUsers;
		[CProperty(ColumnPath ="NumberOfUsers")]
		public int NumberOfUsers
		{
			get{return _NumberOfUsers;}
			set
			{
				_NumberOfUsers = value;
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
		private DateTime _OpportunityDueDate;
		[CProperty(ColumnPath ="OpportunityDueDate")]
		public DateTime OpportunityDueDate
		{
			get{return _OpportunityDueDate;}
			set
			{
				_OpportunityDueDate = value;
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
		private Guid _OpportunityStageId;
		[CProperty(ColumnPath ="OpportunityStageId")]
		public Guid OpportunityStageId
		{
			get{return _OpportunityStageId;}
			set
			{
				_OpportunityStageId = value;
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
		private Guid _PartnerId;
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId
		{
			get{return _PartnerId;}
			set
			{
				_PartnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerOwnerId;
		[CProperty(ColumnPath ="PartnerOwnerId")]
		public Guid PartnerOwnerId
		{
			get{return _PartnerOwnerId;}
			set
			{
				_PartnerOwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerTypeId;
		[CProperty(ColumnPath ="PartnerTypeId")]
		public Guid PartnerTypeId
		{
			get{return _PartnerTypeId;}
			set
			{
				_PartnerTypeId = value;
				OnPropertyChanged();
			}
		}
		private bool _PaymentWasMade;
		[CProperty(ColumnPath ="PaymentWasMade")]
		public bool PaymentWasMade
		{
			get{return _PaymentWasMade;}
			set
			{
				_PaymentWasMade = value;
				OnPropertyChanged();
			}
		}
		private int _Potential;
		[CProperty(ColumnPath ="Potential")]
		public int Potential
		{
			get{return _Potential;}
			set
			{
				_Potential = value;
				OnPropertyChanged();
			}
		}
		private decimal _PredictedScore;
		[CProperty(ColumnPath ="PredictedScore")]
		public decimal PredictedScore
		{
			get{return _PredictedScore;}
			set
			{
				_PredictedScore = value;
				OnPropertyChanged();
			}
		}
		private int _PredictiveScore;
		[CProperty(ColumnPath ="PredictiveScore")]
		public int PredictiveScore
		{
			get{return _PredictiveScore;}
			set
			{
				_PredictiveScore = value;
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
		private string _ProductCode;
		[CProperty(ColumnPath ="ProductCode")]
		public string ProductCode
		{
			get{return _ProductCode;}
			set
			{
				_ProductCode = value;
				OnPropertyChanged();
			}
		}
		private bool _QualificationPassed;
		[CProperty(ColumnPath ="QualificationPassed")]
		public bool QualificationPassed
		{
			get{return _QualificationPassed;}
			set
			{
				_QualificationPassed = value;
				OnPropertyChanged();
			}
		}
		private Guid _QualificationProcessId;
		[CProperty(ColumnPath ="QualificationProcessId")]
		public Guid QualificationProcessId
		{
			get{return _QualificationProcessId;}
			set
			{
				_QualificationProcessId = value;
				OnPropertyChanged();
			}
		}
		private int _Qualified;
		[CProperty(ColumnPath ="Qualified")]
		public int Qualified
		{
			get{return _Qualified;}
			set
			{
				_Qualified = value;
				OnPropertyChanged();
			}
		}
		private Guid _QualifiedAccountId;
		[CProperty(ColumnPath ="QualifiedAccountId")]
		public Guid QualifiedAccountId
		{
			get{return _QualifiedAccountId;}
			set
			{
				_QualifiedAccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _QualifiedContactId;
		[CProperty(ColumnPath ="QualifiedContactId")]
		public Guid QualifiedContactId
		{
			get{return _QualifiedContactId;}
			set
			{
				_QualifiedContactId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _QualifiedOn;
		[CProperty(ColumnPath ="QualifiedOn")]
		public DateTime QualifiedOn
		{
			get{return _QualifiedOn;}
			set
			{
				_QualifiedOn = value;
				OnPropertyChanged();
			}
		}
		private decimal _QualifiedPercent;
		[CProperty(ColumnPath ="QualifiedPercent")]
		public decimal QualifiedPercent
		{
			get{return _QualifiedPercent;}
			set
			{
				_QualifiedPercent = value;
				OnPropertyChanged();
			}
		}
		private Guid _QualifyStatusId;
		[CProperty(ColumnPath ="QualifyStatusId")]
		public Guid QualifyStatusId
		{
			get{return _QualifyStatusId;}
			set
			{
				_QualifyStatusId = value;
				OnPropertyChanged();
			}
		}
		private string _Question;
		[CProperty(ColumnPath ="Question")]
		public string Question
		{
			get{return _Question;}
			set
			{
				_Question = value;
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
		private string _RegionStr;
		[CProperty(ColumnPath ="RegionStr")]
		public string RegionStr
		{
			get{return _RegionStr;}
			set
			{
				_RegionStr = value;
				OnPropertyChanged();
			}
		}
		private Guid _RegisterMethodId;
		[CProperty(ColumnPath ="RegisterMethodId")]
		public Guid RegisterMethodId
		{
			get{return _RegisterMethodId;}
			set
			{
				_RegisterMethodId = value;
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
		private int _SaleParticipant;
		[CProperty(ColumnPath ="SaleParticipant")]
		public int SaleParticipant
		{
			get{return _SaleParticipant;}
			set
			{
				_SaleParticipant = value;
				OnPropertyChanged();
			}
		}
		private decimal _SalePercent;
		[CProperty(ColumnPath ="SalePercent")]
		public decimal SalePercent
		{
			get{return _SalePercent;}
			set
			{
				_SalePercent = value;
				OnPropertyChanged();
			}
		}
		private Guid _SalesChannelId;
		[CProperty(ColumnPath ="SalesChannelId")]
		public Guid SalesChannelId
		{
			get{return _SalesChannelId;}
			set
			{
				_SalesChannelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SalesOwnerId;
		[CProperty(ColumnPath ="SalesOwnerId")]
		public Guid SalesOwnerId
		{
			get{return _SalesOwnerId;}
			set
			{
				_SalesOwnerId = value;
				OnPropertyChanged();
			}
		}
		private string _SaleType;
		[CProperty(ColumnPath ="SaleType")]
		public string SaleType
		{
			get{return _SaleType;}
			set
			{
				_SaleType = value;
				OnPropertyChanged();
			}
		}
		private decimal _Score;
		[CProperty(ColumnPath ="Score")]
		public decimal Score
		{
			get{return _Score;}
			set
			{
				_Score = value;
				OnPropertyChanged();
			}
		}
		private bool _ShowDistributionPage;
		[CProperty(ColumnPath ="ShowDistributionPage")]
		public bool ShowDistributionPage
		{
			get{return _ShowDistributionPage;}
			set
			{
				_ShowDistributionPage = value;
				OnPropertyChanged();
			}
		}
		private bool _StartLeadManagementProcess;
		[CProperty(ColumnPath ="StartLeadManagementProcess")]
		public bool StartLeadManagementProcess
		{
			get{return _StartLeadManagementProcess;}
			set
			{
				_StartLeadManagementProcess = value;
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
		private Guid _TitleId;
		[CProperty(ColumnPath ="TitleId")]
		public Guid TitleId
		{
			get{return _TitleId;}
			set
			{
				_TitleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TrainingCertificationId;
		[CProperty(ColumnPath ="TrainingCertificationId")]
		public Guid TrainingCertificationId
		{
			get{return _TrainingCertificationId;}
			set
			{
				_TrainingCertificationId = value;
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
		private string _UTMCampaign;
		[CProperty(ColumnPath ="UTMCampaign")]
		public string UTMCampaign
		{
			get{return _UTMCampaign;}
			set
			{
				_UTMCampaign = value;
				OnPropertyChanged();
			}
		}
		private Guid _WebFormId;
		[CProperty(ColumnPath ="WebFormId")]
		public Guid WebFormId
		{
			get{return _WebFormId;}
			set
			{
				_WebFormId = value;
				OnPropertyChanged();
			}
		}
		private string _Website;
		[CProperty(ColumnPath ="Website")]
		public string Website
		{
			get{return _Website;}
			set
			{
				_Website = value;
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
		[CProperty(Navigation ="Account:QualifiedAccountId")]
		public Account QualifiedAccount { get; set; }
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="AccountAnnualRevenue:AnnualRevenueId")]
		public AccountAnnualRevenue AnnualRevenue { get; set; }
		[CProperty(Navigation ="AccountBillingInfo:AccountBillingInfoId")]
		public AccountBillingInfo AccountBillingInfo { get; set; }
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
		[CProperty(Navigation ="BonusScheme:BonusSchemeId")]
		public BonusScheme BonusScheme { get; set; }
		[CProperty(Navigation ="BpmGDPR:BpmGDPRId")]
		public BpmGDPR BpmGDPR { get; set; }
		[CProperty(Navigation ="BulkEmail:BulkEmailId")]
		public BulkEmail BulkEmail { get; set; }
		[CProperty(Navigation ="Campaign:CampaignId")]
		public Campaign Campaign { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:QualifiedContactId")]
		public Contact QualifiedContact { get; set; }
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
		[CProperty(Navigation ="LeadCloseReason:LeadCloseReasonId")]
		public LeadCloseReason LeadCloseReason { get; set; }
		[CProperty(Navigation ="LeadDetailedType:LeadDetailedTypeId")]
		public LeadDetailedType LeadDetailedType { get; set; }
		[CProperty(Navigation ="LeadDisqualifyReason:LeadDisqualifyReasonId")]
		public LeadDisqualifyReason LeadDisqualifyReason { get; set; }
		[CProperty(Navigation ="LeadMedium:LeadMediumId")]
		public LeadMedium LeadMedium { get; set; }
		[CProperty(Navigation ="LeadRegisterMethod:RegisterMethodId")]
		public LeadRegisterMethod RegisterMethod { get; set; }
		[CProperty(Navigation ="LeadSource:LeadSourceId")]
		public LeadSource LeadSource { get; set; }
		[CProperty(Navigation ="LeadSource:ClientLeadSourceId")]
		public LeadSource ClientLeadSource { get; set; }
		[CProperty(Navigation ="LeadStatus:StatusId")]
		public LeadStatus Status { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="LeadTypeStatus:LeadTypeStatusId")]
		public LeadTypeStatus LeadTypeStatus { get; set; }
		[CProperty(Navigation ="MarketplaceApplication:MarketplaceProductId")]
		public MarketplaceApplication MarketplaceProduct { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityCategory:CategoryId")]
		public OpportunityCategory Category { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		[CProperty(Navigation ="OpportunitySource:ClientLeadMediumId")]
		public OpportunitySource ClientLeadMedium { get; set; }
		[CProperty(Navigation ="OpportunityStage:OpportunityStageId")]
		public OpportunityStage OpportunityStage { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:TerritoryId")]
		public OpportunityTerritory Territory { get; set; }
		[CProperty(Navigation ="OpportunityType:SalesChannelId")]
		public OpportunityType SalesChannel { get; set; }
		[CProperty(Navigation ="OpportunityType:TypeId")]
		public OpportunityType Type { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="PartnerType:PartnerTypeId")]
		public PartnerType PartnerType { get; set; }
		[CProperty(Navigation ="Project:TrainingCertificationId")]
		public Project TrainingCertification { get; set; }
		[CProperty(Navigation ="QualifyStatus:QualifyStatusId")]
		public QualifyStatus QualifyStatus { get; set; }
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="SubIndustry:SubIndustryId")]
		public SubIndustry SubIndustry { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
