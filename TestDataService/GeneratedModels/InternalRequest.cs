using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InternalRequest")]
	public class InternalRequest : BaseEntity
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
		private DateTime _ApprovalDeadlineDate;
		[CProperty(ColumnPath ="ApprovalDeadlineDate")]
		public DateTime ApprovalDeadlineDate
		{
			get{return _ApprovalDeadlineDate;}
			set
			{
				_ApprovalDeadlineDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _AuthorizedUserId;
		[CProperty(ColumnPath ="AuthorizedUserId")]
		public Guid AuthorizedUserId
		{
			get{return _AuthorizedUserId;}
			set
			{
				_AuthorizedUserId = value;
				OnPropertyChanged();
			}
		}
		private int _AvailableDays;
		[CProperty(ColumnPath ="AvailableDays")]
		public int AvailableDays
		{
			get{return _AvailableDays;}
			set
			{
				_AvailableDays = value;
				OnPropertyChanged();
			}
		}
		private Guid _CalendarId;
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId
		{
			get{return _CalendarId;}
			set
			{
				_CalendarId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CareerDueDate;
		[CProperty(ColumnPath ="CareerDueDate")]
		public DateTime CareerDueDate
		{
			get{return _CareerDueDate;}
			set
			{
				_CareerDueDate = value;
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
		private Guid _CertificateContactId;
		[CProperty(ColumnPath ="CertificateContactId")]
		public Guid CertificateContactId
		{
			get{return _CertificateContactId;}
			set
			{
				_CertificateContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CIDId;
		[CProperty(ColumnPath ="CIDId")]
		public Guid CIDId
		{
			get{return _CIDId;}
			set
			{
				_CIDId = value;
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
		private int _ClosingPeriod;
		[CProperty(ColumnPath ="ClosingPeriod")]
		public int ClosingPeriod
		{
			get{return _ClosingPeriod;}
			set
			{
				_ClosingPeriod = value;
				OnPropertyChanged();
			}
		}
		private string _Comments1;
		[CProperty(ColumnPath ="Comments1")]
		public string Comments1
		{
			get{return _Comments1;}
			set
			{
				_Comments1 = value;
				OnPropertyChanged();
			}
		}
		private string _Comments2;
		[CProperty(ColumnPath ="Comments2")]
		public string Comments2
		{
			get{return _Comments2;}
			set
			{
				_Comments2 = value;
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
		private Guid _CostCenterId;
		[CProperty(ColumnPath ="CostCenterId")]
		public Guid CostCenterId
		{
			get{return _CostCenterId;}
			set
			{
				_CostCenterId = value;
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
		private decimal _CurrentBonusAmount;
		[CProperty(ColumnPath ="CurrentBonusAmount")]
		public decimal CurrentBonusAmount
		{
			get{return _CurrentBonusAmount;}
			set
			{
				_CurrentBonusAmount = value;
				OnPropertyChanged();
			}
		}
		private string _DeliveryAddress;
		[CProperty(ColumnPath ="DeliveryAddress")]
		public string DeliveryAddress
		{
			get{return _DeliveryAddress;}
			set
			{
				_DeliveryAddress = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeliveryTypeId;
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId
		{
			get{return _DeliveryTypeId;}
			set
			{
				_DeliveryTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DepartmentBudgetId;
		[CProperty(ColumnPath ="DepartmentBudgetId")]
		public Guid DepartmentBudgetId
		{
			get{return _DepartmentBudgetId;}
			set
			{
				_DepartmentBudgetId = value;
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private Guid _DismissalInitiatorId;
		[CProperty(ColumnPath ="DismissalInitiatorId")]
		public Guid DismissalInitiatorId
		{
			get{return _DismissalInitiatorId;}
			set
			{
				_DismissalInitiatorId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeJobId;
		[CProperty(ColumnPath ="EmployeeJobId")]
		public Guid EmployeeJobId
		{
			get{return _EmployeeJobId;}
			set
			{
				_EmployeeJobId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EmployeeStartDate;
		[CProperty(ColumnPath ="EmployeeStartDate")]
		public DateTime EmployeeStartDate
		{
			get{return _EmployeeStartDate;}
			set
			{
				_EmployeeStartDate = value;
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
		private Guid _ExesTypeId;
		[CProperty(ColumnPath ="ExesTypeId")]
		public Guid ExesTypeId
		{
			get{return _ExesTypeId;}
			set
			{
				_ExesTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _FactEndDate;
		[CProperty(ColumnPath ="FactEndDate")]
		public DateTime FactEndDate
		{
			get{return _FactEndDate;}
			set
			{
				_FactEndDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _FromDate;
		[CProperty(ColumnPath ="FromDate")]
		public DateTime FromDate
		{
			get{return _FromDate;}
			set
			{
				_FromDate = value;
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
		private Guid _LicenseId;
		[CProperty(ColumnPath ="LicenseId")]
		public Guid LicenseId
		{
			get{return _LicenseId;}
			set
			{
				_LicenseId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MarketId;
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId
		{
			get{return _MarketId;}
			set
			{
				_MarketId = value;
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
		private Guid _NewEmployeeId;
		[CProperty(ColumnPath ="NewEmployeeId")]
		public Guid NewEmployeeId
		{
			get{return _NewEmployeeId;}
			set
			{
				_NewEmployeeId = value;
				OnPropertyChanged();
			}
		}
		private string _Number;
		[CProperty(ColumnPath ="Number")]
		public string Number
		{
			get{return _Number;}
			set
			{
				_Number = value;
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
		private Guid _OpportunityPartnerRoleId;
		[CProperty(ColumnPath ="OpportunityPartnerRoleId")]
		public Guid OpportunityPartnerRoleId
		{
			get{return _OpportunityPartnerRoleId;}
			set
			{
				_OpportunityPartnerRoleId = value;
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
		private Guid _ParrentRequestId;
		[CProperty(ColumnPath ="ParrentRequestId")]
		public Guid ParrentRequestId
		{
			get{return _ParrentRequestId;}
			set
			{
				_ParrentRequestId = value;
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
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PermissionLevelId;
		[CProperty(ColumnPath ="PermissionLevelId")]
		public Guid PermissionLevelId
		{
			get{return _PermissionLevelId;}
			set
			{
				_PermissionLevelId = value;
				OnPropertyChanged();
			}
		}
		private string _PersonnelNumber;
		[CProperty(ColumnPath ="PersonnelNumber")]
		public string PersonnelNumber
		{
			get{return _PersonnelNumber;}
			set
			{
				_PersonnelNumber = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlannedDepartureDateTimeFromDestination;
		[CProperty(ColumnPath ="PlannedDepartureDateTimeFromDestination")]
		public DateTime PlannedDepartureDateTimeFromDestination
		{
			get{return _PlannedDepartureDateTimeFromDestination;}
			set
			{
				_PlannedDepartureDateTimeFromDestination = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlannedDepartureDateTimeToDestination;
		[CProperty(ColumnPath ="PlannedDepartureDateTimeToDestination")]
		public DateTime PlannedDepartureDateTimeToDestination
		{
			get{return _PlannedDepartureDateTimeToDestination;}
			set
			{
				_PlannedDepartureDateTimeToDestination = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlannedEndDate;
		[CProperty(ColumnPath ="PlannedEndDate")]
		public DateTime PlannedEndDate
		{
			get{return _PlannedEndDate;}
			set
			{
				_PlannedEndDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlannedPaymentDate;
		[CProperty(ColumnPath ="PlannedPaymentDate")]
		public DateTime PlannedPaymentDate
		{
			get{return _PlannedPaymentDate;}
			set
			{
				_PlannedPaymentDate = value;
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
		private int _ProcessingDays;
		[CProperty(ColumnPath ="ProcessingDays")]
		public int ProcessingDays
		{
			get{return _ProcessingDays;}
			set
			{
				_ProcessingDays = value;
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
		private Guid _RequesterId;
		[CProperty(ColumnPath ="RequesterId")]
		public Guid RequesterId
		{
			get{return _RequesterId;}
			set
			{
				_RequesterId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _Reservation;
		[CProperty(ColumnPath ="Reservation")]
		public DateTime Reservation
		{
			get{return _Reservation;}
			set
			{
				_Reservation = value;
				OnPropertyChanged();
			}
		}
		private Guid _ScheduleId;
		[CProperty(ColumnPath ="ScheduleId")]
		public Guid ScheduleId
		{
			get{return _ScheduleId;}
			set
			{
				_ScheduleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentId;
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId
		{
			get{return _SegmentId;}
			set
			{
				_SegmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StaffUnitId;
		[CProperty(ColumnPath ="StaffUnitId")]
		public Guid StaffUnitId
		{
			get{return _StaffUnitId;}
			set
			{
				_StaffUnitId = value;
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
		private Guid _SubTypeId;
		[CProperty(ColumnPath ="SubTypeId")]
		public Guid SubTypeId
		{
			get{return _SubTypeId;}
			set
			{
				_SubTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Sync1CId;
		[CProperty(ColumnPath ="Sync1CId")]
		public Guid Sync1CId
		{
			get{return _Sync1CId;}
			set
			{
				_Sync1CId = value;
				OnPropertyChanged();
			}
		}
		private string _SyncError;
		[CProperty(ColumnPath ="SyncError")]
		public string SyncError
		{
			get{return _SyncError;}
			set
			{
				_SyncError = value;
				OnPropertyChanged();
			}
		}
		private bool _TemporaryChange;
		[CProperty(ColumnPath ="TemporaryChange")]
		public bool TemporaryChange
		{
			get{return _TemporaryChange;}
			set
			{
				_TemporaryChange = value;
				OnPropertyChanged();
			}
		}
		private DateTime _TemporaryChangeDate;
		[CProperty(ColumnPath ="TemporaryChangeDate")]
		public DateTime TemporaryChangeDate
		{
			get{return _TemporaryChangeDate;}
			set
			{
				_TemporaryChangeDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _TemporaryChangeDateTo;
		[CProperty(ColumnPath ="TemporaryChangeDateTo")]
		public DateTime TemporaryChangeDateTo
		{
			get{return _TemporaryChangeDateTo;}
			set
			{
				_TemporaryChangeDateTo = value;
				OnPropertyChanged();
			}
		}
		private Guid _TerrId;
		[CProperty(ColumnPath ="TerrId")]
		public Guid TerrId
		{
			get{return _TerrId;}
			set
			{
				_TerrId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ToDate;
		[CProperty(ColumnPath ="ToDate")]
		public DateTime ToDate
		{
			get{return _ToDate;}
			set
			{
				_ToDate = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalAmount;
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount
		{
			get{return _TotalAmount;}
			set
			{
				_TotalAmount = value;
				OnPropertyChanged();
			}
		}
		private int _TotalWorkingDays;
		[CProperty(ColumnPath ="TotalWorkingDays")]
		public int TotalWorkingDays
		{
			get{return _TotalWorkingDays;}
			set
			{
				_TotalWorkingDays = value;
				OnPropertyChanged();
			}
		}
		private decimal _TripDuration;
		[CProperty(ColumnPath ="TripDuration")]
		public decimal TripDuration
		{
			get{return _TripDuration;}
			set
			{
				_TripDuration = value;
				OnPropertyChanged();
			}
		}
		private Guid _TripId;
		[CProperty(ColumnPath ="TripId")]
		public Guid TripId
		{
			get{return _TripId;}
			set
			{
				_TripId = value;
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
		private Guid _VacationTypeId;
		[CProperty(ColumnPath ="VacationTypeId")]
		public Guid VacationTypeId
		{
			get{return _VacationTypeId;}
			set
			{
				_VacationTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _WorkingDay;
		[CProperty(ColumnPath ="WorkingDay")]
		public DateTime WorkingDay
		{
			get{return _WorkingDay;}
			set
			{
				_WorkingDay = value;
				OnPropertyChanged();
			}
		}
		private Guid _WorkingDayResultId;
		[CProperty(ColumnPath ="WorkingDayResultId")]
		public Guid WorkingDayResultId
		{
			get{return _WorkingDayResultId;}
			set
			{
				_WorkingDayResultId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:RequesterId")]
		public Contact Requester { get; set; }
		[CProperty(Navigation ="Contact:NewEmployeeId")]
		public Contact NewEmployee { get; set; }
		[CProperty(Navigation ="Contact:CertificateContactId")]
		public Contact CertificateContact { get; set; }
		[CProperty(Navigation ="Contact:AuthorizedUserId")]
		public Contact AuthorizedUser { get; set; }
		[CProperty(Navigation ="CostCenter:CostCenterId")]
		public CostCenter CostCenter { get; set; }
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="CountryCodes:OfficeId")]
		public CountryCodes Office { get; set; }
		[CProperty(Navigation ="CountryCodes:CalendarId")]
		public CountryCodes Calendar { get; set; }
		[CProperty(Navigation ="DeliveryType:DeliveryTypeId")]
		public DeliveryType DeliveryType { get; set; }
		[CProperty(Navigation ="DepartmentBudget:DepartmentBudgetId")]
		public DepartmentBudget DepartmentBudget { get; set; }
		[CProperty(Navigation ="DismissalInitiator:DismissalInitiatorId")]
		public DismissalInitiator DismissalInitiator { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="EmployeeJob:EmployeeJobId")]
		public EmployeeJob EmployeeJob { get; set; }
		[CProperty(Navigation ="Event:EventId")]
		public Event Event { get; set; }
		[CProperty(Navigation ="InternalRequest:ParrentRequestId")]
		public InternalRequest ParrentRequest { get; set; }
		[CProperty(Navigation ="Invoice:InvoiceId")]
		public Invoice Invoice { get; set; }
		[CProperty(Navigation ="LicenceType:LicenseId")]
		public LicenceType License { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:DepartmentId")]
		public OrgStructureUnit Department { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:StaffUnitId")]
		public OrgStructureUnit StaffUnit { get; set; }
		[CProperty(Navigation ="PartnerProjectRole:OpportunityPartnerRoleId")]
		public PartnerProjectRole OpportunityPartnerRole { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		[CProperty(Navigation ="PermissionLevel:PermissionLevelId")]
		public PermissionLevel PermissionLevel { get; set; }
		[CProperty(Navigation ="ProblemPriority:PriorityId")]
		public ProblemPriority Priority { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="RequestCategory:CategoryId")]
		public RequestCategory Category { get; set; }
		[CProperty(Navigation ="RequestExesType:ExesTypeId")]
		public RequestExesType ExesType { get; set; }
		[CProperty(Navigation ="RequestStatus:StatusId")]
		public RequestStatus Status { get; set; }
		[CProperty(Navigation ="RequestSubType:SubTypeId")]
		public RequestSubType SubType { get; set; }
		[CProperty(Navigation ="RequestType:TypeId")]
		public RequestType Type { get; set; }
		[CProperty(Navigation ="Schedule:ScheduleId")]
		public Schedule Schedule { get; set; }
		[CProperty(Navigation ="Subscription:CIDId")]
		public Subscription CID { get; set; }
		[CProperty(Navigation ="Territory:TerrId")]
		public Territory Terr { get; set; }
		[CProperty(Navigation ="TripType:TripId")]
		public TripType Trip { get; set; }
		[CProperty(Navigation ="TsSalesCareerMarket:MarketId")]
		public TsSalesCareerMarket Market { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:SegmentId")]
		public TsSalesCareerSegment Segment { get; set; }
		[CProperty(Navigation ="VacationType:VacationTypeId")]
		public VacationType VacationType { get; set; }
		[CProperty(Navigation ="WorkingDayResult:WorkingDayResultId")]
		public WorkingDayResult WorkingDayResult { get; set; }
		[CProperty(Navigation ="YesNo:Sync1CId")]
		public YesNo Sync1C { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountStageHistory:InternaRequestId")]
		public virtual ICollection<AccountStageHistory> AccountStageHistoryByInternaRequest { get; set; }
		[CProperty(Association ="Activity:InternalRequestId")]
		public virtual ICollection<Activity> ActivityByInternalRequest { get; set; }
		[CProperty(Association ="Applicant:InternalRequestId")]
		public virtual ICollection<Applicant> ApplicantByInternalRequest { get; set; }
		[CProperty(Association ="Bonus:InternalRequestId")]
		public virtual ICollection<Bonus> BonusByInternalRequest { get; set; }
		[CProperty(Association ="CorrespondenceLink:RequestId")]
		public virtual ICollection<CorrespondenceLink> CorrespondenceLinkByRequest { get; set; }
		[CProperty(Association ="Document:InternalRequestId")]
		public virtual ICollection<Document> DocumentByInternalRequest { get; set; }
		[CProperty(Association ="DomainInRequest:InternalRequestId")]
		public virtual ICollection<DomainInRequest> DomainInRequestByInternalRequest { get; set; }
		[CProperty(Association ="ExesInRequest:InternalRequestId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByInternalRequest { get; set; }
		[CProperty(Association ="InternalRequest:ParrentRequestId")]
		public virtual ICollection<InternalRequest> InternalRequestByParrentRequest { get; set; }
		[CProperty(Association ="InternalRequestFile:InternalRequestId")]
		public virtual ICollection<InternalRequestFile> InternalRequestFileByInternalRequest { get; set; }
		[CProperty(Association ="InternalRequestInFolder:InternalRequestId")]
		public virtual ICollection<InternalRequestInFolder> InternalRequestInFolderByInternalRequest { get; set; }
		[CProperty(Association ="InternalRequestInTag:EntityId")]
		public virtual ICollection<InternalRequestInTag> InternalRequestInTagByEntity { get; set; }
		[CProperty(Association ="InternalRequestVisa:InternalRequestId")]
		public virtual ICollection<InternalRequestVisa> InternalRequestVisaByInternalRequest { get; set; }
		[CProperty(Association ="ProductForLicGenerator:InternalRequestId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByInternalRequest { get; set; }
		[CProperty(Association ="ProductInSubscription:InternalRequestId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByInternalRequest { get; set; }
		[CProperty(Association ="SupplyPaymentElement:RequestId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByRequest { get; set; }
		[CProperty(Association ="VwBonusInRequest:InternalRequestId")]
		public virtual ICollection<VwBonusInRequest> VwBonusInRequestByInternalRequest { get; set; }
		[CProperty(Association ="VwInternalRequestSM:InternalRequestId")]
		public virtual ICollection<VwInternalRequestSM> VwInternalRequestSMByInternalRequest { get; set; }
		[CProperty(Association ="VwTSSLA:InternalRequestId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByInternalRequest { get; set; }
		[CProperty(Association ="VwTSSLAArchive:InternalRequestId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByInternalRequest { get; set; }
		#endregion
	}
}
