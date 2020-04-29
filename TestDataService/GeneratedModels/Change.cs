using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Change")]
	public class Change : BaseEntity
	{
		#region Values
		private int _ActualLabor;
		[CProperty(ColumnPath ="ActualLabor")]
		public int ActualLabor
		{
			get{return _ActualLabor;}
			set
			{
				_ActualLabor = value;
				OnPropertyChanged();
			}
		}
		private Guid _AuthorId;
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId
		{
			get{return _AuthorId;}
			set
			{
				_AuthorId = value;
				OnPropertyChanged();
			}
		}
		private string _Benefits;
		[CProperty(ColumnPath ="Benefits")]
		public string Benefits
		{
			get{return _Benefits;}
			set
			{
				_Benefits = value;
				OnPropertyChanged();
			}
		}
		private int _BenefitsInt;
		[CProperty(ColumnPath ="BenefitsInt")]
		public int BenefitsInt
		{
			get{return _BenefitsInt;}
			set
			{
				_BenefitsInt = value;
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
		private DateTime _ClosureDate;
		[CProperty(ColumnPath ="ClosureDate")]
		public DateTime ClosureDate
		{
			get{return _ClosureDate;}
			set
			{
				_ClosureDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _ComplexityId;
		[CProperty(ColumnPath ="ComplexityId")]
		public Guid ComplexityId
		{
			get{return _ComplexityId;}
			set
			{
				_ComplexityId = value;
				OnPropertyChanged();
			}
		}
		private string _CostOfDelay;
		[CProperty(ColumnPath ="CostOfDelay")]
		public string CostOfDelay
		{
			get{return _CostOfDelay;}
			set
			{
				_CostOfDelay = value;
				OnPropertyChanged();
			}
		}
		private int _CostOfDelayInt;
		[CProperty(ColumnPath ="CostOfDelayInt")]
		public int CostOfDelayInt
		{
			get{return _CostOfDelayInt;}
			set
			{
				_CostOfDelayInt = value;
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
		private string _Deliverables;
		[CProperty(ColumnPath ="Deliverables")]
		public string Deliverables
		{
			get{return _Deliverables;}
			set
			{
				_Deliverables = value;
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
		private int _FeatureUsersNumber;
		[CProperty(ColumnPath ="FeatureUsersNumber")]
		public int FeatureUsersNumber
		{
			get{return _FeatureUsersNumber;}
			set
			{
				_FeatureUsersNumber = value;
				OnPropertyChanged();
			}
		}
		private Guid _GroupId;
		[CProperty(ColumnPath ="GroupId")]
		public Guid GroupId
		{
			get{return _GroupId;}
			set
			{
				_GroupId = value;
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
		private string _JiraURL;
		[CProperty(ColumnPath ="JiraURL")]
		public string JiraURL
		{
			get{return _JiraURL;}
			set
			{
				_JiraURL = value;
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
		private string _Objectives;
		[CProperty(ColumnPath ="Objectives")]
		public string Objectives
		{
			get{return _Objectives;}
			set
			{
				_Objectives = value;
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
		private Guid _ParentChangeId;
		[CProperty(ColumnPath ="ParentChangeId")]
		public Guid ParentChangeId
		{
			get{return _ParentChangeId;}
			set
			{
				_ParentChangeId = value;
				OnPropertyChanged();
			}
		}
		private int _PlannedLabor;
		[CProperty(ColumnPath ="PlannedLabor")]
		public int PlannedLabor
		{
			get{return _PlannedLabor;}
			set
			{
				_PlannedLabor = value;
				OnPropertyChanged();
			}
		}
		private decimal _PriorityCoefficient;
		[CProperty(ColumnPath ="PriorityCoefficient")]
		public decimal PriorityCoefficient
		{
			get{return _PriorityCoefficient;}
			set
			{
				_PriorityCoefficient = value;
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
		private Guid _ProductFunctionId;
		[CProperty(ColumnPath ="ProductFunctionId")]
		public Guid ProductFunctionId
		{
			get{return _ProductFunctionId;}
			set
			{
				_ProductFunctionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductModuleId;
		[CProperty(ColumnPath ="ProductModuleId")]
		public Guid ProductModuleId
		{
			get{return _ProductModuleId;}
			set
			{
				_ProductModuleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PurposeId;
		[CProperty(ColumnPath ="PurposeId")]
		public Guid PurposeId
		{
			get{return _PurposeId;}
			set
			{
				_PurposeId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RegisteredOn;
		[CProperty(ColumnPath ="RegisteredOn")]
		public DateTime RegisteredOn
		{
			get{return _RegisteredOn;}
			set
			{
				_RegisteredOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _ReleaseId;
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId
		{
			get{return _ReleaseId;}
			set
			{
				_ReleaseId = value;
				OnPropertyChanged();
			}
		}
		private string _SatisfactionComment;
		[CProperty(ColumnPath ="SatisfactionComment")]
		public string SatisfactionComment
		{
			get{return _SatisfactionComment;}
			set
			{
				_SatisfactionComment = value;
				OnPropertyChanged();
			}
		}
		private Guid _SatisfactionLevelId;
		[CProperty(ColumnPath ="SatisfactionLevelId")]
		public Guid SatisfactionLevelId
		{
			get{return _SatisfactionLevelId;}
			set
			{
				_SatisfactionLevelId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ScheduledClosureDate;
		[CProperty(ColumnPath ="ScheduledClosureDate")]
		public DateTime ScheduledClosureDate
		{
			get{return _ScheduledClosureDate;}
			set
			{
				_ScheduledClosureDate = value;
				OnPropertyChanged();
			}
		}
		private string _SolutionDescription;
		[CProperty(ColumnPath ="SolutionDescription")]
		public string SolutionDescription
		{
			get{return _SolutionDescription;}
			set
			{
				_SolutionDescription = value;
				OnPropertyChanged();
			}
		}
		private Guid _SourceId;
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId
		{
			get{return _SourceId;}
			set
			{
				_SourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StageId;
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId
		{
			get{return _StageId;}
			set
			{
				_StageId = value;
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
		private string _SuccessCriteria;
		[CProperty(ColumnPath ="SuccessCriteria")]
		public string SuccessCriteria
		{
			get{return _SuccessCriteria;}
			set
			{
				_SuccessCriteria = value;
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
		[CProperty(Navigation ="CaseSubtype:ProductFunctionId")]
		public CaseSubtype ProductFunction { get; set; }
		[CProperty(Navigation ="CaseType:ProductModuleId")]
		public CaseType ProductModule { get; set; }
		[CProperty(Navigation ="Change:ParentChangeId")]
		public Change ParentChange { get; set; }
		[CProperty(Navigation ="ChangeCategory:CategoryId")]
		public ChangeCategory Category { get; set; }
		[CProperty(Navigation ="ChangeDirectory:StageId")]
		public ChangeDirectory Stage { get; set; }
		[CProperty(Navigation ="ChangePriority:PriorityId")]
		public ChangePriority Priority { get; set; }
		[CProperty(Navigation ="ChangePurpose:PurposeId")]
		public ChangePurpose Purpose { get; set; }
		[CProperty(Navigation ="ChangeSource:SourceId")]
		public ChangeSource Source { get; set; }
		[CProperty(Navigation ="ChangeStatus:StatusId")]
		public ChangeStatus Status { get; set; }
		[CProperty(Navigation ="ChangeType:TypeId")]
		public ChangeType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ImprovementComplexity:ComplexityId")]
		public ImprovementComplexity Complexity { get; set; }
		[CProperty(Navigation ="Release:ReleaseId")]
		public Release Release { get; set; }
		[CProperty(Navigation ="SatisfactionLevel:SatisfactionLevelId")]
		public SatisfactionLevel SatisfactionLevel { get; set; }
		[CProperty(Navigation ="SysAdminUnit:GroupId")]
		public SysAdminUnit Group { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ChangeId")]
		public virtual ICollection<Activity> ActivityByChange { get; set; }
		[CProperty(Association ="Case:ChangeId")]
		public virtual ICollection<Case> CaseByChange { get; set; }
		[CProperty(Association ="Change:ParentChangeId")]
		public virtual ICollection<Change> ChangeByParentChange { get; set; }
		[CProperty(Association ="ChangeConfItem:ChangeId")]
		public virtual ICollection<ChangeConfItem> ChangeConfItemByChange { get; set; }
		[CProperty(Association ="ChangeFile:ChangeId")]
		public virtual ICollection<ChangeFile> ChangeFileByChange { get; set; }
		[CProperty(Association ="ChangeInFolder:ChangeId")]
		public virtual ICollection<ChangeInFolder> ChangeInFolderByChange { get; set; }
		[CProperty(Association ="ChangeInTag:EntityId")]
		public virtual ICollection<ChangeInTag> ChangeInTagByEntity { get; set; }
		[CProperty(Association ="ChangeServiceItem:ChangeId")]
		public virtual ICollection<ChangeServiceItem> ChangeServiceItemByChange { get; set; }
		[CProperty(Association ="ChangeStageLog:ChangeId")]
		public virtual ICollection<ChangeStageLog> ChangeStageLogByChange { get; set; }
		[CProperty(Association ="ChangeVisa:ChangeId")]
		public virtual ICollection<ChangeVisa> ChangeVisaByChange { get; set; }
		[CProperty(Association ="Problem:ChangeId")]
		public virtual ICollection<Problem> ProblemByChange { get; set; }
		[CProperty(Association ="VwChange:ParentChangeId")]
		public virtual ICollection<VwChange> VwChangeByParentChange { get; set; }
		[CProperty(Association ="VwChange:ChangeId")]
		public virtual ICollection<VwChange> VwChangeByChange { get; set; }
		#endregion
	}
}
