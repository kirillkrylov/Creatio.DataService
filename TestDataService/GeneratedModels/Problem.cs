using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Problem")]
	public class Problem : BaseEntity
	{
		#region Values
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
		private Guid _CaseSubtypeId;
		[CProperty(ColumnPath ="CaseSubtypeId")]
		public Guid CaseSubtypeId
		{
			get{return _CaseSubtypeId;}
			set
			{
				_CaseSubtypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CaseTypeId;
		[CProperty(ColumnPath ="CaseTypeId")]
		public Guid CaseTypeId
		{
			get{return _CaseTypeId;}
			set
			{
				_CaseTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ChangeId;
		[CProperty(ColumnPath ="ChangeId")]
		public Guid ChangeId
		{
			get{return _ChangeId;}
			set
			{
				_ChangeId = value;
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
		private Guid _FoundInVersionId;
		[CProperty(ColumnPath ="FoundInVersionId")]
		public Guid FoundInVersionId
		{
			get{return _FoundInVersionId;}
			set
			{
				_FoundInVersionId = value;
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
		private Guid _ResolvedInVersionId;
		[CProperty(ColumnPath ="ResolvedInVersionId")]
		public Guid ResolvedInVersionId
		{
			get{return _ResolvedInVersionId;}
			set
			{
				_ResolvedInVersionId = value;
				OnPropertyChanged();
			}
		}
		private bool _ResolvedOnCommunity;
		[CProperty(ColumnPath ="ResolvedOnCommunity")]
		public bool ResolvedOnCommunity
		{
			get{return _ResolvedOnCommunity;}
			set
			{
				_ResolvedOnCommunity = value;
				OnPropertyChanged();
			}
		}
		private Guid _ServiceItemId;
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId
		{
			get{return _ServiceItemId;}
			set
			{
				_ServiceItemId = value;
				OnPropertyChanged();
			}
		}
		private string _Solution;
		[CProperty(ColumnPath ="Solution")]
		public string Solution
		{
			get{return _Solution;}
			set
			{
				_Solution = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SolutionPlanedOn;
		[CProperty(ColumnPath ="SolutionPlanedOn")]
		public DateTime SolutionPlanedOn
		{
			get{return _SolutionPlanedOn;}
			set
			{
				_SolutionPlanedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SolutionProvidedOn;
		[CProperty(ColumnPath ="SolutionProvidedOn")]
		public DateTime SolutionProvidedOn
		{
			get{return _SolutionProvidedOn;}
			set
			{
				_SolutionProvidedOn = value;
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
		private string _Symptoms;
		[CProperty(ColumnPath ="Symptoms")]
		public string Symptoms
		{
			get{return _Symptoms;}
			set
			{
				_Symptoms = value;
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
		[CProperty(Navigation ="BpmonlineVersion:FoundInVersionId")]
		public BpmonlineVersion FoundInVersion { get; set; }
		[CProperty(Navigation ="BpmonlineVersion:ResolvedInVersionId")]
		public BpmonlineVersion ResolvedInVersion { get; set; }
		[CProperty(Navigation ="CaseSubtype:CaseSubtypeId")]
		public CaseSubtype CaseSubtype { get; set; }
		[CProperty(Navigation ="CaseType:CaseTypeId")]
		public CaseType CaseType { get; set; }
		[CProperty(Navigation ="Change:ChangeId")]
		public Change Change { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ProblemPriority:PriorityId")]
		public ProblemPriority Priority { get; set; }
		[CProperty(Navigation ="ProblemStatus:StatusId")]
		public ProblemStatus Status { get; set; }
		[CProperty(Navigation ="ProblemType:TypeId")]
		public ProblemType Type { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		[CProperty(Navigation ="SysAdminUnit:GroupId")]
		public SysAdminUnit Group { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ProblemId")]
		public virtual ICollection<Activity> ActivityByProblem { get; set; }
		[CProperty(Association ="Case:ProblemId")]
		public virtual ICollection<Case> CaseByProblem { get; set; }
		[CProperty(Association ="CaseLifecycle:ProblemId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByProblem { get; set; }
		[CProperty(Association ="ProblemFile:ProblemId")]
		public virtual ICollection<ProblemFile> ProblemFileByProblem { get; set; }
		[CProperty(Association ="ProblemInCase:ProblemId")]
		public virtual ICollection<ProblemInCase> ProblemInCaseByProblem { get; set; }
		[CProperty(Association ="ProblemInFolder:ProblemId")]
		public virtual ICollection<ProblemInFolder> ProblemInFolderByProblem { get; set; }
		[CProperty(Association ="ProblemInTag:EntityId")]
		public virtual ICollection<ProblemInTag> ProblemInTagByEntity { get; set; }
		#endregion
	}
}
