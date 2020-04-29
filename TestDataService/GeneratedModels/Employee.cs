using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Employee")]
	public class Employee : BaseEntity
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
		private DateTime _CareerStartDate;
		[CProperty(ColumnPath ="CareerStartDate")]
		public DateTime CareerStartDate
		{
			get{return _CareerStartDate;}
			set
			{
				_CareerStartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _CitizenshipId;
		[CProperty(ColumnPath ="CitizenshipId")]
		public Guid CitizenshipId
		{
			get{return _CitizenshipId;}
			set
			{
				_CitizenshipId = value;
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
		private decimal _DigitalProfileProgress;
		[CProperty(ColumnPath ="DigitalProfileProgress")]
		public decimal DigitalProfileProgress
		{
			get{return _DigitalProfileProgress;}
			set
			{
				_DigitalProfileProgress = value;
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
		private Guid _EmploymentTypeId;
		[CProperty(ColumnPath ="EmploymentTypeId")]
		public Guid EmploymentTypeId
		{
			get{return _EmploymentTypeId;}
			set
			{
				_EmploymentTypeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ExamDate;
		[CProperty(ColumnPath ="ExamDate")]
		public DateTime ExamDate
		{
			get{return _ExamDate;}
			set
			{
				_ExamDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ExamResultId;
		[CProperty(ColumnPath ="ExamResultId")]
		public Guid ExamResultId
		{
			get{return _ExamResultId;}
			set
			{
				_ExamResultId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ExpertiseLevelId;
		[CProperty(ColumnPath ="ExpertiseLevelId")]
		public Guid ExpertiseLevelId
		{
			get{return _ExpertiseLevelId;}
			set
			{
				_ExpertiseLevelId = value;
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
		private Guid _HRId;
		[CProperty(ColumnPath ="HRId")]
		public Guid HRId
		{
			get{return _HRId;}
			set
			{
				_HRId = value;
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
		private Guid _ManagerId;
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId
		{
			get{return _ManagerId;}
			set
			{
				_ManagerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MaritalStatusId;
		[CProperty(ColumnPath ="MaritalStatusId")]
		public Guid MaritalStatusId
		{
			get{return _MaritalStatusId;}
			set
			{
				_MaritalStatusId = value;
				OnPropertyChanged();
			}
		}
		private bool _MaternityLeave;
		[CProperty(ColumnPath ="MaternityLeave")]
		public bool MaternityLeave
		{
			get{return _MaternityLeave;}
			set
			{
				_MaternityLeave = value;
				OnPropertyChanged();
			}
		}
		private Guid _MentorId;
		[CProperty(ColumnPath ="MentorId")]
		public Guid MentorId
		{
			get{return _MentorId;}
			set
			{
				_MentorId = value;
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
		private Guid _OrgStructureUnitId;
		[CProperty(ColumnPath ="OrgStructureUnitId")]
		public Guid OrgStructureUnitId
		{
			get{return _OrgStructureUnitId;}
			set
			{
				_OrgStructureUnitId = value;
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
		private DateTime _ProbationDueDate;
		[CProperty(ColumnPath ="ProbationDueDate")]
		public DateTime ProbationDueDate
		{
			get{return _ProbationDueDate;}
			set
			{
				_ProbationDueDate = value;
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
		private Guid _ReasonForDismissalId;
		[CProperty(ColumnPath ="ReasonForDismissalId")]
		public Guid ReasonForDismissalId
		{
			get{return _ReasonForDismissalId;}
			set
			{
				_ReasonForDismissalId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SkillPlanId;
		[CProperty(ColumnPath ="SkillPlanId")]
		public Guid SkillPlanId
		{
			get{return _SkillPlanId;}
			set
			{
				_SkillPlanId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SMId;
		[CProperty(ColumnPath ="SMId")]
		public Guid SMId
		{
			get{return _SMId;}
			set
			{
				_SMId = value;
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
		private int _WorkExperienceDays;
		[CProperty(ColumnPath ="WorkExperienceDays")]
		public int WorkExperienceDays
		{
			get{return _WorkExperienceDays;}
			set
			{
				_WorkExperienceDays = value;
				OnPropertyChanged();
			}
		}
		private Guid _WorkExperienceId;
		[CProperty(ColumnPath ="WorkExperienceId")]
		public Guid WorkExperienceId
		{
			get{return _WorkExperienceId;}
			set
			{
				_WorkExperienceId = value;
				OnPropertyChanged();
			}
		}
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
