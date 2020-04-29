using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Project")]
	public class Project : BaseEntity
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
		private decimal _ActualCompletion;
		[CProperty(ColumnPath ="ActualCompletion")]
		public decimal ActualCompletion
		{
			get{return _ActualCompletion;}
			set
			{
				_ActualCompletion = value;
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
		private Guid _CloseReasonId;
		[CProperty(ColumnPath ="CloseReasonId")]
		public Guid CloseReasonId
		{
			get{return _CloseReasonId;}
			set
			{
				_CloseReasonId = value;
				OnPropertyChanged();
			}
		}
		private string _Comments;
		[CProperty(ColumnPath ="Comments")]
		public string Comments
		{
			get{return _Comments;}
			set
			{
				_Comments = value;
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
		private DateTime _Deadline;
		[CProperty(ColumnPath ="Deadline")]
		public DateTime Deadline
		{
			get{return _Deadline;}
			set
			{
				_Deadline = value;
				OnPropertyChanged();
			}
		}
		private int _Duration;
		[CProperty(ColumnPath ="Duration")]
		public int Duration
		{
			get{return _Duration;}
			set
			{
				_Duration = value;
				OnPropertyChanged();
			}
		}
		private int _DurationDays;
		[CProperty(ColumnPath ="DurationDays")]
		public int DurationDays
		{
			get{return _DurationDays;}
			set
			{
				_DurationDays = value;
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
		private decimal _ExpenseDev;
		[CProperty(ColumnPath ="ExpenseDev")]
		public decimal ExpenseDev
		{
			get{return _ExpenseDev;}
			set
			{
				_ExpenseDev = value;
				OnPropertyChanged();
			}
		}
		private decimal _ExpenseDevPerc;
		[CProperty(ColumnPath ="ExpenseDevPerc")]
		public decimal ExpenseDevPerc
		{
			get{return _ExpenseDevPerc;}
			set
			{
				_ExpenseDevPerc = value;
				OnPropertyChanged();
			}
		}
		private decimal _ExternalCostDev;
		[CProperty(ColumnPath ="ExternalCostDev")]
		public decimal ExternalCostDev
		{
			get{return _ExternalCostDev;}
			set
			{
				_ExternalCostDev = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactExpense;
		[CProperty(ColumnPath ="FactExpense")]
		public decimal FactExpense
		{
			get{return _FactExpense;}
			set
			{
				_FactExpense = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactExternalCost;
		[CProperty(ColumnPath ="FactExternalCost")]
		public decimal FactExternalCost
		{
			get{return _FactExternalCost;}
			set
			{
				_FactExternalCost = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactIncome;
		[CProperty(ColumnPath ="FactIncome")]
		public decimal FactIncome
		{
			get{return _FactIncome;}
			set
			{
				_FactIncome = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactInternalCost;
		[CProperty(ColumnPath ="FactInternalCost")]
		public decimal FactInternalCost
		{
			get{return _FactInternalCost;}
			set
			{
				_FactInternalCost = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactMargin;
		[CProperty(ColumnPath ="FactMargin")]
		public decimal FactMargin
		{
			get{return _FactMargin;}
			set
			{
				_FactMargin = value;
				OnPropertyChanged();
			}
		}
		private decimal _FactMarginPerc;
		[CProperty(ColumnPath ="FactMarginPerc")]
		public decimal FactMarginPerc
		{
			get{return _FactMarginPerc;}
			set
			{
				_FactMarginPerc = value;
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
		private decimal _IncomeDev;
		[CProperty(ColumnPath ="IncomeDev")]
		public decimal IncomeDev
		{
			get{return _IncomeDev;}
			set
			{
				_IncomeDev = value;
				OnPropertyChanged();
			}
		}
		private decimal _IncomeDevPerc;
		[CProperty(ColumnPath ="IncomeDevPerc")]
		public decimal IncomeDevPerc
		{
			get{return _IncomeDevPerc;}
			set
			{
				_IncomeDevPerc = value;
				OnPropertyChanged();
			}
		}
		private decimal _InternalCostDev;
		[CProperty(ColumnPath ="InternalCostDev")]
		public decimal InternalCostDev
		{
			get{return _InternalCostDev;}
			set
			{
				_InternalCostDev = value;
				OnPropertyChanged();
			}
		}
		private bool _IsAutoCalcCompletion;
		[CProperty(ColumnPath ="IsAutoCalcCompletion")]
		public bool IsAutoCalcCompletion
		{
			get{return _IsAutoCalcCompletion;}
			set
			{
				_IsAutoCalcCompletion = value;
				OnPropertyChanged();
			}
		}
		private decimal _MarginDev;
		[CProperty(ColumnPath ="MarginDev")]
		public decimal MarginDev
		{
			get{return _MarginDev;}
			set
			{
				_MarginDev = value;
				OnPropertyChanged();
			}
		}
		private decimal _MarginDevPerc;
		[CProperty(ColumnPath ="MarginDevPerc")]
		public decimal MarginDevPerc
		{
			get{return _MarginDevPerc;}
			set
			{
				_MarginDevPerc = value;
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
		private Guid _OpportunityId;
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId
		{
			get{return _OpportunityId;}
			set
			{
				_OpportunityId = value;
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
		private Guid _ParentProjectId;
		[CProperty(ColumnPath ="ParentProjectId")]
		public Guid ParentProjectId
		{
			get{return _ParentProjectId;}
			set
			{
				_ParentProjectId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanExpense;
		[CProperty(ColumnPath ="PlanExpense")]
		public decimal PlanExpense
		{
			get{return _PlanExpense;}
			set
			{
				_PlanExpense = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanExternalCost;
		[CProperty(ColumnPath ="PlanExternalCost")]
		public decimal PlanExternalCost
		{
			get{return _PlanExternalCost;}
			set
			{
				_PlanExternalCost = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanExternalDevPerc;
		[CProperty(ColumnPath ="PlanExternalDevPerc")]
		public decimal PlanExternalDevPerc
		{
			get{return _PlanExternalDevPerc;}
			set
			{
				_PlanExternalDevPerc = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanIncome;
		[CProperty(ColumnPath ="PlanIncome")]
		public decimal PlanIncome
		{
			get{return _PlanIncome;}
			set
			{
				_PlanIncome = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanInternalCost;
		[CProperty(ColumnPath ="PlanInternalCost")]
		public decimal PlanInternalCost
		{
			get{return _PlanInternalCost;}
			set
			{
				_PlanInternalCost = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanInternalDevPerc;
		[CProperty(ColumnPath ="PlanInternalDevPerc")]
		public decimal PlanInternalDevPerc
		{
			get{return _PlanInternalDevPerc;}
			set
			{
				_PlanInternalDevPerc = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanMargin;
		[CProperty(ColumnPath ="PlanMargin")]
		public decimal PlanMargin
		{
			get{return _PlanMargin;}
			set
			{
				_PlanMargin = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlanMarginPerc;
		[CProperty(ColumnPath ="PlanMarginPerc")]
		public decimal PlanMarginPerc
		{
			get{return _PlanMarginPerc;}
			set
			{
				_PlanMarginPerc = value;
				OnPropertyChanged();
			}
		}
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		private Guid _ProjectEntryTypeId;
		[CProperty(ColumnPath ="ProjectEntryTypeId")]
		public Guid ProjectEntryTypeId
		{
			get{return _ProjectEntryTypeId;}
			set
			{
				_ProjectEntryTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ResponsibleDepartmentId;
		[CProperty(ColumnPath ="ResponsibleDepartmentId")]
		public Guid ResponsibleDepartmentId
		{
			get{return _ResponsibleDepartmentId;}
			set
			{
				_ResponsibleDepartmentId = value;
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
		private Guid _SupplierId;
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId
		{
			get{return _SupplierId;}
			set
			{
				_SupplierId = value;
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
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:SupplierId")]
		public Account Supplier { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		[CProperty(Navigation ="OpportunityCategory:CategoryId")]
		public OpportunityCategory Category { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:ResponsibleDepartmentId")]
		public OpportunityDepartment ResponsibleDepartment { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="Project:ParentProjectId")]
		public Project ParentProject { get; set; }
		[CProperty(Navigation ="ProjectCloseReason:CloseReasonId")]
		public ProjectCloseReason CloseReason { get; set; }
		[CProperty(Navigation ="ProjectEntryType:ProjectEntryTypeId")]
		public ProjectEntryType ProjectEntryType { get; set; }
		[CProperty(Navigation ="ProjectStatus:StatusId")]
		public ProjectStatus Status { get; set; }
		[CProperty(Navigation ="ProjectType:TypeId")]
		public ProjectType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ProjectId")]
		public virtual ICollection<Activity> ActivityByProject { get; set; }
		[CProperty(Association ="Case:ProjectId")]
		public virtual ICollection<Case> CaseByProject { get; set; }
		[CProperty(Association ="Cashflow:ProjectId")]
		public virtual ICollection<Cashflow> CashflowByProject { get; set; }
		[CProperty(Association ="Document:ProjectId")]
		public virtual ICollection<Document> DocumentByProject { get; set; }
		[CProperty(Association ="InternalRequest:ProjectId")]
		public virtual ICollection<InternalRequest> InternalRequestByProject { get; set; }
		[CProperty(Association ="Invoice:ProjectId")]
		public virtual ICollection<Invoice> InvoiceByProject { get; set; }
		[CProperty(Association ="Lead:TrainingCertificationId")]
		public virtual ICollection<Lead> LeadByTrainingCertification { get; set; }
		[CProperty(Association ="Order:ProjectId")]
		public virtual ICollection<Order> OrderByProject { get; set; }
		[CProperty(Association ="Project:ParentProjectId")]
		public virtual ICollection<Project> ProjectByParentProject { get; set; }
		[CProperty(Association ="ProjectFile:ProjectId")]
		public virtual ICollection<ProjectFile> ProjectFileByProject { get; set; }
		[CProperty(Association ="ProjectInFolder:ProjectId")]
		public virtual ICollection<ProjectInFolder> ProjectInFolderByProject { get; set; }
		[CProperty(Association ="ProjectInStatus:ProjectId")]
		public virtual ICollection<ProjectInStatus> ProjectInStatusByProject { get; set; }
		[CProperty(Association ="ProjectInTag:EntityId")]
		public virtual ICollection<ProjectInTag> ProjectInTagByEntity { get; set; }
		[CProperty(Association ="ProjectPlanHistoryItem:ProjectId")]
		public virtual ICollection<ProjectPlanHistoryItem> ProjectPlanHistoryItemByProject { get; set; }
		[CProperty(Association ="ProjectProduct:ProjectId")]
		public virtual ICollection<ProjectProduct> ProjectProductByProject { get; set; }
		[CProperty(Association ="ProjectResourceElement:ProjectId")]
		public virtual ICollection<ProjectResourceElement> ProjectResourceElementByProject { get; set; }
		[CProperty(Association ="SupplyPaymentElement:ProjectId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByProject { get; set; }
		[CProperty(Association ="VwLead:TrainingCertificationId")]
		public virtual ICollection<VwLead> VwLeadByTrainingCertification { get; set; }
		[CProperty(Association ="VwProjectHierarchy:ProjectId")]
		public virtual ICollection<VwProjectHierarchy> VwProjectHierarchyByProject { get; set; }
		[CProperty(Association ="VwProjectHierarchy:BaseProjectId")]
		public virtual ICollection<VwProjectHierarchy> VwProjectHierarchyByBaseProject { get; set; }
		[CProperty(Association ="VwProjectProduct:ProjectId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByProject { get; set; }
		[CProperty(Association ="WorkResourceElement:ProjectId")]
		public virtual ICollection<WorkResourceElement> WorkResourceElementByProject { get; set; }
		#endregion
	}
}
