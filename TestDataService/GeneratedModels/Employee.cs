using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Employee")]
	public class Employee : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="BpmManageDataPrivacyId")]
		public Guid BpmManageDataPrivacyId { get; set; }
		[CProperty(ColumnPath ="CareerDueDate")]
		public DateTime CareerDueDate { get; set; }
		[CProperty(ColumnPath ="CareerStartDate")]
		public DateTime CareerStartDate { get; set; }
		[CProperty(ColumnPath ="CitizenshipId")]
		public Guid CitizenshipId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DigitalProfileProgress")]
		public decimal DigitalProfileProgress { get; set; }
		[CProperty(ColumnPath ="DismissalInitiatorId")]
		public Guid DismissalInitiatorId { get; set; }
		[CProperty(ColumnPath ="EmploymentTypeId")]
		public Guid EmploymentTypeId { get; set; }
		[CProperty(ColumnPath ="ExamDate")]
		public DateTime ExamDate { get; set; }
		[CProperty(ColumnPath ="ExamResultId")]
		public Guid ExamResultId { get; set; }
		[CProperty(ColumnPath ="ExpertiseLevelId")]
		public Guid ExpertiseLevelId { get; set; }
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle { get; set; }
		[CProperty(ColumnPath ="HRId")]
		public Guid HRId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId { get; set; }
		[CProperty(ColumnPath ="MaritalStatusId")]
		public Guid MaritalStatusId { get; set; }
		[CProperty(ColumnPath ="MaternityLeave")]
		public bool MaternityLeave { get; set; }
		[CProperty(ColumnPath ="MentorId")]
		public Guid MentorId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OrgStructureUnitId")]
		public Guid OrgStructureUnitId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PersonnelNumber")]
		public string PersonnelNumber { get; set; }
		[CProperty(ColumnPath ="ProbationDueDate")]
		public DateTime ProbationDueDate { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReasonForDismissalId")]
		public Guid ReasonForDismissalId { get; set; }
		[CProperty(ColumnPath ="SkillPlanId")]
		public Guid SkillPlanId { get; set; }
		[CProperty(ColumnPath ="SMId")]
		public Guid SMId { get; set; }
		[CProperty(ColumnPath ="StaffUnitId")]
		public Guid StaffUnitId { get; set; }
		[CProperty(ColumnPath ="WorkExperienceDays")]
		public int WorkExperienceDays { get; set; }
		[CProperty(ColumnPath ="WorkExperienceId")]
		public Guid WorkExperienceId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="BpmGDPR:BpmManageDataPrivacyId")]
		public BpmGDPR BpmManageDataPrivacy { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:MentorId")]
		public Contact Mentor { get; set; }
		[CProperty(Navigation ="Contact:SMId")]
		public Contact SM { get; set; }
		[CProperty(Navigation ="Contact:HRId")]
		public Contact HR { get; set; }
		[CProperty(Navigation ="Country:CitizenshipId")]
		public Country Citizenship { get; set; }
		[CProperty(Navigation ="DismissalInitiator:DismissalInitiatorId")]
		public DismissalInitiator DismissalInitiator { get; set; }
		[CProperty(Navigation ="EduActivityResult:ExamResultId")]
		public EduActivityResult ExamResult { get; set; }
		[CProperty(Navigation ="Employee:ManagerId")]
		public Employee Manager { get; set; }
		[CProperty(Navigation ="EmployeeJob:JobId")]
		public EmployeeJob Job { get; set; }
		[CProperty(Navigation ="EmploymentType:EmploymentTypeId")]
		public EmploymentType EmploymentType { get; set; }
		[CProperty(Navigation ="ExpertiseLevel:ExpertiseLevelId")]
		public ExpertiseLevel ExpertiseLevel { get; set; }
		[CProperty(Navigation ="MaritalStatus:MaritalStatusId")]
		public MaritalStatus MaritalStatus { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:OrgStructureUnitId")]
		public OrgStructureUnit OrgStructureUnit { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:StaffUnitId")]
		public OrgStructureUnit StaffUnit { get; set; }
		[CProperty(Navigation ="ReasonForLeaving:ReasonForDismissalId")]
		public ReasonForLeaving ReasonForDismissal { get; set; }
		[CProperty(Navigation ="TsSkillPlan:SkillPlanId")]
		public TsSkillPlan SkillPlan { get; set; }
		[CProperty(Navigation ="WorkExperienceDirectory:WorkExperienceId")]
		public WorkExperienceDirectory WorkExperience { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Applicant:EmployeeId")]
		public virtual ICollection<Applicant> ApplicantByEmployee { get; set; }
		[CProperty(Association ="Bonus:EmployeeId")]
		public virtual ICollection<Bonus> BonusByEmployee { get; set; }
		[CProperty(Association ="BonusQueue:EmployeeId")]
		public virtual ICollection<BonusQueue> BonusQueueByEmployee { get; set; }
		[CProperty(Association ="DwhRndActivityCube:EmployeeId")]
		public virtual ICollection<DwhRndActivityCube> DwhRndActivityCubeByEmployee { get; set; }
		[CProperty(Association ="DwhRndActivityTagCube:EmployeeId")]
		public virtual ICollection<DwhRndActivityTagCube> DwhRndActivityTagCubeByEmployee { get; set; }
		[CProperty(Association ="DwhRndActivityTaskCategoryCube:EmployeeId")]
		public virtual ICollection<DwhRndActivityTaskCategoryCube> DwhRndActivityTaskCategoryCubeByEmployee { get; set; }
		[CProperty(Association ="Employee:ManagerId")]
		public virtual ICollection<Employee> EmployeeByManager { get; set; }
		[CProperty(Association ="EmployeeCareer:EmployeeId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByEmployee { get; set; }
		[CProperty(Association ="EmployeeCompetence:EmployeeId")]
		public virtual ICollection<EmployeeCompetence> EmployeeCompetenceByEmployee { get; set; }
		[CProperty(Association ="EmployeeFile:EmployeeId")]
		public virtual ICollection<EmployeeFile> EmployeeFileByEmployee { get; set; }
		[CProperty(Association ="EmployeeForecast:EmployeeId")]
		public virtual ICollection<EmployeeForecast> EmployeeForecastByEmployee { get; set; }
		[CProperty(Association ="EmployeeInFolder:EmployeeId")]
		public virtual ICollection<EmployeeInFolder> EmployeeInFolderByEmployee { get; set; }
		[CProperty(Association ="EmployeeInTag:EntityId")]
		public virtual ICollection<EmployeeInTag> EmployeeInTagByEntity { get; set; }
		[CProperty(Association ="HRTalks:EmployeeId")]
		public virtual ICollection<HRTalks> HRTalksByEmployee { get; set; }
		[CProperty(Association ="InteractionWithManager:EmployeeId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByEmployee { get; set; }
		[CProperty(Association ="InternalRequest:EmployeeId")]
		public virtual ICollection<InternalRequest> InternalRequestByEmployee { get; set; }
		[CProperty(Association ="OrgStructureUnit:HeadId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByHead { get; set; }
		[CProperty(Association ="OrgStructureUnit:EmployeeId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByEmployee { get; set; }
		[CProperty(Association ="Salary:EmployeeId")]
		public virtual ICollection<Salary> SalaryByEmployee { get; set; }
		[CProperty(Association ="SMHealthCheck:AccountManagerId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckByAccountManager { get; set; }
		[CProperty(Association ="SMHealthCheck:EmployeeId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckByEmployee { get; set; }
		[CProperty(Association ="SMHealthCheck:ResponsibleSEId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckByResponsibleSE { get; set; }
		[CProperty(Association ="SMHealthCheck:DDId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckByDD { get; set; }
		[CProperty(Association ="TsStaffGoal:EmployeeId")]
		public virtual ICollection<TsStaffGoal> TsStaffGoalByEmployee { get; set; }
		[CProperty(Association ="TsStaffSkillPeriod:EmployeeId")]
		public virtual ICollection<TsStaffSkillPeriod> TsStaffSkillPeriodByEmployee { get; set; }
		[CProperty(Association ="TsStaffSkillPeriodValueVisa:EmployeeId")]
		public virtual ICollection<TsStaffSkillPeriodValueVisa> TsStaffSkillPeriodValueVisaByEmployee { get; set; }
		[CProperty(Association ="VwEmployeesHierarchy:EmployeeId")]
		public virtual ICollection<VwEmployeesHierarchy> VwEmployeesHierarchyByEmployee { get; set; }
		[CProperty(Association ="VwSubordinatesWithManager:ManagerId")]
		public virtual ICollection<VwSubordinatesWithManager> VwSubordinatesWithManagerByManager { get; set; }
		#endregion
	}
}
