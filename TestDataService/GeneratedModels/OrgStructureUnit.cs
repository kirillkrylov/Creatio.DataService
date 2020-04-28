using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrgStructureUnit")]
	public class OrgStructureUnit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BranchId")]
		public Guid BranchId { get; set; }
		[CProperty(ColumnPath ="CalendarId")]
		public Guid CalendarId { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="FullName")]
		public string FullName { get; set; }
		[CProperty(ColumnPath ="HeadId")]
		public Guid HeadId { get; set; }
		[CProperty(ColumnPath ="HRBPId")]
		public Guid HRBPId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IsManuallyEditingHead")]
		public bool IsManuallyEditingHead { get; set; }
		[CProperty(ColumnPath ="IsNotUsed")]
		public bool IsNotUsed { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId { get; set; }
		[CProperty(ColumnPath ="OrgStructureUnitLevelId")]
		public Guid OrgStructureUnitLevelId { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		[CProperty(ColumnPath ="ScheduleId")]
		public Guid ScheduleId { get; set; }
		[CProperty(ColumnPath ="ScrumMasterId")]
		public Guid ScrumMasterId { get; set; }
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId { get; set; }
		[CProperty(ColumnPath ="StaffUnitLevelId")]
		public Guid StaffUnitLevelId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Branch:BranchId")]
		public Branch Branch { get; set; }
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:HRBPId")]
		public Contact HRBP { get; set; }
		[CProperty(Navigation ="Contact:ScrumMasterId")]
		public Contact ScrumMaster { get; set; }
		[CProperty(Navigation ="CountryCodes:OfficeId")]
		public CountryCodes Office { get; set; }
		[CProperty(Navigation ="CountryCodes:CalendarId")]
		public CountryCodes Calendar { get; set; }
		[CProperty(Navigation ="Employee:HeadId")]
		public Employee Head { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="EmployeeJob:JobId")]
		public EmployeeJob Job { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:ParentId")]
		public OrgStructureUnit Parent { get; set; }
		[CProperty(Navigation ="OrgStructureUnitLevel:OrgStructureUnitLevelId")]
		public OrgStructureUnitLevel OrgStructureUnitLevel { get; set; }
		[CProperty(Navigation ="OrgstructureUnitType:TypeId")]
		public OrgstructureUnitType Type { get; set; }
		[CProperty(Navigation ="Schedule:ScheduleId")]
		public Schedule Schedule { get; set; }
		[CProperty(Navigation ="StaffUnitLevel:StaffUnitLevelId")]
		public StaffUnitLevel StaffUnitLevel { get; set; }
		[CProperty(Navigation ="TsSalesCareerMarket:MarketId")]
		public TsSalesCareerMarket Market { get; set; }
		[CProperty(Navigation ="TsSalesCareerRole:RoleId")]
		public TsSalesCareerRole Role { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:SegmentId")]
		public TsSalesCareerSegment Segment { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:PDEAuthorDepartmentId")]
		public virtual ICollection<Case> CaseByPDEAuthorDepartment { get; set; }
		[CProperty(Association ="CaseSubtype:OrgStructureUnitId")]
		public virtual ICollection<CaseSubtype> CaseSubtypeByOrgStructureUnit { get; set; }
		[CProperty(Association ="CompetencesByRoles:EmployeeJobId")]
		public virtual ICollection<CompetencesByRoles> CompetencesByRolesByEmployeeJob { get; set; }
		[CProperty(Association ="Employee:OrgStructureUnitId")]
		public virtual ICollection<Employee> EmployeeByOrgStructureUnit { get; set; }
		[CProperty(Association ="Employee:StaffUnitId")]
		public virtual ICollection<Employee> EmployeeByStaffUnit { get; set; }
		[CProperty(Association ="EmployeeCareer:OrgStructureUnitId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByOrgStructureUnit { get; set; }
		[CProperty(Association ="EmployeeCareer:StaffUnitId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByStaffUnit { get; set; }
		[CProperty(Association ="HRTalks:JobTitleId")]
		public virtual ICollection<HRTalks> HRTalksByJobTitle { get; set; }
		[CProperty(Association ="HRTalks:DepartmentId")]
		public virtual ICollection<HRTalks> HRTalksByDepartment { get; set; }
		[CProperty(Association ="InteractionWithManager:DepartmentId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByDepartment { get; set; }
		[CProperty(Association ="InteractionWithManager:JobTitleId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByJobTitle { get; set; }
		[CProperty(Association ="InternalRequest:DepartmentId")]
		public virtual ICollection<InternalRequest> InternalRequestByDepartment { get; set; }
		[CProperty(Association ="InternalRequest:StaffUnitId")]
		public virtual ICollection<InternalRequest> InternalRequestByStaffUnit { get; set; }
		[CProperty(Association ="Invoice:DepartmentId")]
		public virtual ICollection<Invoice> InvoiceByDepartment { get; set; }
		[CProperty(Association ="OrgStrctUnitInRoleExp:OrgStructureUnitId")]
		public virtual ICollection<OrgStrctUnitInRoleExp> OrgStrctUnitInRoleExpByOrgStructureUnit { get; set; }
		[CProperty(Association ="OrgStrctUnitRoleState:OrgStructureUnitId")]
		public virtual ICollection<OrgStrctUnitRoleState> OrgStrctUnitRoleStateByOrgStructureUnit { get; set; }
		[CProperty(Association ="OrgStructUnitExpanded:OrgStructureUnitId")]
		public virtual ICollection<OrgStructUnitExpanded> OrgStructUnitExpandedByOrgStructureUnit { get; set; }
		[CProperty(Association ="OrgStructUnitExpanded:OrgStructureUnitParentId")]
		public virtual ICollection<OrgStructUnitExpanded> OrgStructUnitExpandedByOrgStructureUnitParent { get; set; }
		[CProperty(Association ="OrgStructureUnit:ParentId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByParent { get; set; }
		[CProperty(Association ="OrgStructureUnitFile:OrgStructureUnitId")]
		public virtual ICollection<OrgStructureUnitFile> OrgStructureUnitFileByOrgStructureUnit { get; set; }
		[CProperty(Association ="OrgStructureUnitInRole:OrgStructureUnitId")]
		public virtual ICollection<OrgStructureUnitInRole> OrgStructureUnitInRoleByOrgStructureUnit { get; set; }
		[CProperty(Association ="OrgStructureUnitInTag:EntityId")]
		public virtual ICollection<OrgStructureUnitInTag> OrgStructureUnitInTagByEntity { get; set; }
		[CProperty(Association ="VwOrgStrctUnitRoleExp:OrgStructureUnitId")]
		public virtual ICollection<VwOrgStrctUnitRoleExp> VwOrgStrctUnitRoleExpByOrgStructureUnit { get; set; }
		#endregion
	}
}
