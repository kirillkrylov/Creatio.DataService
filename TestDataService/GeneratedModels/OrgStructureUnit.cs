using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrgStructureUnit")]
	public class OrgStructureUnit : BaseEntity
	{
		#region Values
		private Guid _BranchId;
		[CProperty(ColumnPath ="BranchId")]
		public Guid BranchId
		{
			get{return _BranchId;}
			set
			{
				_BranchId = value;
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
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
				OnPropertyChanged();
			}
		}
		private string _FullName;
		[CProperty(ColumnPath ="FullName")]
		public string FullName
		{
			get{return _FullName;}
			set
			{
				_FullName = value;
				OnPropertyChanged();
			}
		}
		private Guid _HeadId;
		[CProperty(ColumnPath ="HeadId")]
		public Guid HeadId
		{
			get{return _HeadId;}
			set
			{
				_HeadId = value;
				OnPropertyChanged();
			}
		}
		private Guid _HRBPId;
		[CProperty(ColumnPath ="HRBPId")]
		public Guid HRBPId
		{
			get{return _HRBPId;}
			set
			{
				_HRBPId = value;
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
		private bool _IsManuallyEditingHead;
		[CProperty(ColumnPath ="IsManuallyEditingHead")]
		public bool IsManuallyEditingHead
		{
			get{return _IsManuallyEditingHead;}
			set
			{
				_IsManuallyEditingHead = value;
				OnPropertyChanged();
			}
		}
		private bool _IsNotUsed;
		[CProperty(ColumnPath ="IsNotUsed")]
		public bool IsNotUsed
		{
			get{return _IsNotUsed;}
			set
			{
				_IsNotUsed = value;
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
		private Guid _OrgStructureUnitLevelId;
		[CProperty(ColumnPath ="OrgStructureUnitLevelId")]
		public Guid OrgStructureUnitLevelId
		{
			get{return _OrgStructureUnitLevelId;}
			set
			{
				_OrgStructureUnitLevelId = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
				OnPropertyChanged();
			}
		}
		private Guid _RoleId;
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId
		{
			get{return _RoleId;}
			set
			{
				_RoleId = value;
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
		private Guid _ScrumMasterId;
		[CProperty(ColumnPath ="ScrumMasterId")]
		public Guid ScrumMasterId
		{
			get{return _ScrumMasterId;}
			set
			{
				_ScrumMasterId = value;
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
		private Guid _StaffUnitLevelId;
		[CProperty(ColumnPath ="StaffUnitLevelId")]
		public Guid StaffUnitLevelId
		{
			get{return _StaffUnitLevelId;}
			set
			{
				_StaffUnitLevelId = value;
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
