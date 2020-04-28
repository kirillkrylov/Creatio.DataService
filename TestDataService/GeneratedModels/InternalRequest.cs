using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "InternalRequest")]
	public class InternalRequest : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ApprovalDeadlineDate")]
		public DateTime ApprovalDeadlineDate { get; set; }
		[CProperty(ColumnPath ="AuthorizedUserId")]
		public Guid AuthorizedUserId { get; set; }
		[CProperty(ColumnPath ="AvailableDays")]
		public int AvailableDays { get; set; }
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
		[CProperty(ColumnPath ="CareerDueDate")]
		public DateTime CareerDueDate { get; set; }
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CertificateContactId")]
		public Guid CertificateContactId { get; set; }
		[CProperty(ColumnPath ="CIDId")]
		public Guid CIDId { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="ClosingPeriod")]
		public int ClosingPeriod { get; set; }
		[CProperty(ColumnPath ="Comments1")]
		public string Comments1 { get; set; }
		[CProperty(ColumnPath ="Comments2")]
		public string Comments2 { get; set; }
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="CostCenterId")]
		public Guid CostCenterId { get; set; }
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrentBonusAmount")]
		public decimal CurrentBonusAmount { get; set; }
		[CProperty(ColumnPath ="DeliveryAddress")]
		public string DeliveryAddress { get; set; }
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId { get; set; }
		[CProperty(ColumnPath ="DepartmentBudgetId")]
		public Guid DepartmentBudgetId { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DismissalInitiatorId")]
		public Guid DismissalInitiatorId { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="EmployeeJobId")]
		public Guid EmployeeJobId { get; set; }
		[CProperty(ColumnPath ="EmployeeStartDate")]
		public DateTime EmployeeStartDate { get; set; }
		[CProperty(ColumnPath ="EventId")]
		public Guid EventId { get; set; }
		[CProperty(ColumnPath ="ExesTypeId")]
		public Guid ExesTypeId { get; set; }
		[CProperty(ColumnPath ="FactEndDate")]
		public DateTime FactEndDate { get; set; }
		[CProperty(ColumnPath ="FromDate")]
		public DateTime FromDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InvoiceId")]
		public Guid InvoiceId { get; set; }
		[CProperty(ColumnPath ="LicenseId")]
		public Guid LicenseId { get; set; }
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NewEmployeeId")]
		public Guid NewEmployeeId { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId { get; set; }
		[CProperty(ColumnPath ="OpportunityPartnerRoleId")]
		public Guid OpportunityPartnerRoleId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParrentRequestId")]
		public Guid ParrentRequestId { get; set; }
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="PermissionLevelId")]
		public Guid PermissionLevelId { get; set; }
		[CProperty(ColumnPath ="PersonnelNumber")]
		public string PersonnelNumber { get; set; }
		[CProperty(ColumnPath ="PlannedDepartureDateTimeFromDestination")]
		public DateTime PlannedDepartureDateTimeFromDestination { get; set; }
		[CProperty(ColumnPath ="PlannedDepartureDateTimeToDestination")]
		public DateTime PlannedDepartureDateTimeToDestination { get; set; }
		[CProperty(ColumnPath ="PlannedEndDate")]
		public DateTime PlannedEndDate { get; set; }
		[CProperty(ColumnPath ="PlannedPaymentDate")]
		public DateTime PlannedPaymentDate { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessingDays")]
		public int ProcessingDays { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="RequesterId")]
		public Guid RequesterId { get; set; }
		[CProperty(ColumnPath ="Reservation")]
		public DateTime Reservation { get; set; }
		[CProperty(ColumnPath ="ScheduleId")]
		public Guid ScheduleId { get; set; }
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId { get; set; }
		[CProperty(ColumnPath ="StaffUnitId")]
		public Guid StaffUnitId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SubTypeId")]
		public Guid SubTypeId { get; set; }
		[CProperty(ColumnPath ="Sync1CId")]
		public Guid Sync1CId { get; set; }
		[CProperty(ColumnPath ="SyncError")]
		public string SyncError { get; set; }
		[CProperty(ColumnPath ="TemporaryChange")]
		public bool TemporaryChange { get; set; }
		[CProperty(ColumnPath ="TemporaryChangeDate")]
		public DateTime TemporaryChangeDate { get; set; }
		[CProperty(ColumnPath ="TemporaryChangeDateTo")]
		public DateTime TemporaryChangeDateTo { get; set; }
		[CProperty(ColumnPath ="TerrId")]
		public Guid TerrId { get; set; }
		[CProperty(ColumnPath ="ToDate")]
		public DateTime ToDate { get; set; }
		[CProperty(ColumnPath ="TotalAmount")]
		public decimal TotalAmount { get; set; }
		[CProperty(ColumnPath ="TotalWorkingDays")]
		public int TotalWorkingDays { get; set; }
		[CProperty(ColumnPath ="TripDuration")]
		public decimal TripDuration { get; set; }
		[CProperty(ColumnPath ="TripId")]
		public Guid TripId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="VacationTypeId")]
		public Guid VacationTypeId { get; set; }
		[CProperty(ColumnPath ="WorkingDay")]
		public DateTime WorkingDay { get; set; }
		[CProperty(ColumnPath ="WorkingDayResultId")]
		public Guid WorkingDayResultId { get; set; }
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
