using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CI")]
	public class CI : BaseEntity
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
		private string _ExecutionPlan;
		[CProperty(ColumnPath ="ExecutionPlan")]
		public string ExecutionPlan
		{
			get{return _ExecutionPlan;}
			set
			{
				_ExecutionPlan = value;
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
		private Guid _ParentImprovementId;
		[CProperty(ColumnPath ="ParentImprovementId")]
		public Guid ParentImprovementId
		{
			get{return _ParentImprovementId;}
			set
			{
				_ParentImprovementId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlanEndDate;
		[CProperty(ColumnPath ="PlanEndDate")]
		public DateTime PlanEndDate
		{
			get{return _PlanEndDate;}
			set
			{
				_PlanEndDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlanStartDate;
		[CProperty(ColumnPath ="PlanStartDate")]
		public DateTime PlanStartDate
		{
			get{return _PlanStartDate;}
			set
			{
				_PlanStartDate = value;
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
		private DateTime _RegistrationDate;
		[CProperty(ColumnPath ="RegistrationDate")]
		public DateTime RegistrationDate
		{
			get{return _RegistrationDate;}
			set
			{
				_RegistrationDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ReportedDate;
		[CProperty(ColumnPath ="ReportedDate")]
		public DateTime ReportedDate
		{
			get{return _ReportedDate;}
			set
			{
				_ReportedDate = value;
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
		[CProperty(Navigation ="CI:ParentImprovementId")]
		public CI ParentImprovement { get; set; }
		[CProperty(Navigation ="CIStatus:StatusId")]
		public CIStatus Status { get; set; }
		[CProperty(Navigation ="CIType:TypeId")]
		public CIType Type { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="CountryCodes:OfficeId")]
		public CountryCodes Office { get; set; }
		[CProperty(Navigation ="ImprovementCategory:CategoryId")]
		public ImprovementCategory Category { get; set; }
		[CProperty(Navigation ="ImprovementComplexity:ComplexityId")]
		public ImprovementComplexity Complexity { get; set; }
		[CProperty(Navigation ="ImprovementPriority:PriorityId")]
		public ImprovementPriority Priority { get; set; }
		[CProperty(Navigation ="ImprovementTerritory:TerritoryId")]
		public ImprovementTerritory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:CIId")]
		public virtual ICollection<Activity> ActivityByCI { get; set; }
		[CProperty(Association ="CI:ParentImprovementId")]
		public virtual ICollection<CI> CIByParentImprovement { get; set; }
		[CProperty(Association ="CIFile:CIId")]
		public virtual ICollection<CIFile> CIFileByCI { get; set; }
		[CProperty(Association ="CIInFolder:CIId")]
		public virtual ICollection<CIInFolder> CIInFolderByCI { get; set; }
		[CProperty(Association ="CIInTag:EntityId")]
		public virtual ICollection<CIInTag> CIInTagByEntity { get; set; }
		[CProperty(Association ="CIVisa:CIId")]
		public virtual ICollection<CIVisa> CIVisaByCI { get; set; }
		[CProperty(Association ="EmployeeProjectReview:ImprovementId")]
		public virtual ICollection<EmployeeProjectReview> EmployeeProjectReviewByImprovement { get; set; }
		[CProperty(Association ="ImprovementParticipant:ImprovementId")]
		public virtual ICollection<ImprovementParticipant> ImprovementParticipantByImprovement { get; set; }
		#endregion
	}
}
