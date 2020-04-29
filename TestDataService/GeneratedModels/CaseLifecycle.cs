using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseLifecycle")]
	public class CaseLifecycle : BaseEntity
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
		private Guid _CaseRecordId;
		[CProperty(ColumnPath ="CaseRecordId")]
		public Guid CaseRecordId
		{
			get{return _CaseRecordId;}
			set
			{
				_CaseRecordId = value;
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
		private Guid _ProblemId;
		[CProperty(ColumnPath ="ProblemId")]
		public Guid ProblemId
		{
			get{return _ProblemId;}
			set
			{
				_ProblemId = value;
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
		private DateTime _ResponseDate;
		[CProperty(ColumnPath ="ResponseDate")]
		public DateTime ResponseDate
		{
			get{return _ResponseDate;}
			set
			{
				_ResponseDate = value;
				OnPropertyChanged();
			}
		}
		private bool _ResponseOverdue;
		[CProperty(ColumnPath ="ResponseOverdue")]
		public bool ResponseOverdue
		{
			get{return _ResponseOverdue;}
			set
			{
				_ResponseOverdue = value;
				OnPropertyChanged();
			}
		}
		private string _SatisfactionLevelComment;
		[CProperty(ColumnPath ="SatisfactionLevelComment")]
		public string SatisfactionLevelComment
		{
			get{return _SatisfactionLevelComment;}
			set
			{
				_SatisfactionLevelComment = value;
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
		private Guid _ServicePactId;
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId
		{
			get{return _ServicePactId;}
			set
			{
				_ServicePactId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SolutionDate;
		[CProperty(ColumnPath ="SolutionDate")]
		public DateTime SolutionDate
		{
			get{return _SolutionDate;}
			set
			{
				_SolutionDate = value;
				OnPropertyChanged();
			}
		}
		private bool _SolutionOverdue;
		[CProperty(ColumnPath ="SolutionOverdue")]
		public bool SolutionOverdue
		{
			get{return _SolutionOverdue;}
			set
			{
				_SolutionOverdue = value;
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
		private decimal _StateDurationInDays;
		[CProperty(ColumnPath ="StateDurationInDays")]
		public decimal StateDurationInDays
		{
			get{return _StateDurationInDays;}
			set
			{
				_StateDurationInDays = value;
				OnPropertyChanged();
			}
		}
		private decimal _StateDurationInHours;
		[CProperty(ColumnPath ="StateDurationInHours")]
		public decimal StateDurationInHours
		{
			get{return _StateDurationInHours;}
			set
			{
				_StateDurationInHours = value;
				OnPropertyChanged();
			}
		}
		private int _StateDurationInMinutes;
		[CProperty(ColumnPath ="StateDurationInMinutes")]
		public int StateDurationInMinutes
		{
			get{return _StateDurationInMinutes;}
			set
			{
				_StateDurationInMinutes = value;
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
		private Guid _SupportLevelId;
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId
		{
			get{return _SupportLevelId;}
			set
			{
				_SupportLevelId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation ="CaseCategory:CategoryId")]
		public CaseCategory Category { get; set; }
		[CProperty(Navigation ="CasePriority:PriorityId")]
		public CasePriority Priority { get; set; }
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Problem:ProblemId")]
		public Problem Problem { get; set; }
		[CProperty(Navigation ="RoleInServiceTeam:SupportLevelId")]
		public RoleInServiceTeam SupportLevel { get; set; }
		[CProperty(Navigation ="SatisfactionLevel:SatisfactionLevelId")]
		public SatisfactionLevel SatisfactionLevel { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		[CProperty(Navigation ="ServicePact:ServicePactId")]
		public ServicePact ServicePact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:GroupId")]
		public SysAdminUnit Group { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
