using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Project")]
	public class Project : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="ActualCompletion")]
		public decimal ActualCompletion { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="CloseReasonId")]
		public Guid CloseReasonId { get; set; }
		[CProperty(ColumnPath ="Comments")]
		public string Comments { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Deadline")]
		public DateTime Deadline { get; set; }
		[CProperty(ColumnPath ="Duration")]
		public int Duration { get; set; }
		[CProperty(ColumnPath ="DurationDays")]
		public int DurationDays { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="ExpenseDev")]
		public decimal ExpenseDev { get; set; }
		[CProperty(ColumnPath ="ExpenseDevPerc")]
		public decimal ExpenseDevPerc { get; set; }
		[CProperty(ColumnPath ="ExternalCostDev")]
		public decimal ExternalCostDev { get; set; }
		[CProperty(ColumnPath ="FactExpense")]
		public decimal FactExpense { get; set; }
		[CProperty(ColumnPath ="FactExternalCost")]
		public decimal FactExternalCost { get; set; }
		[CProperty(ColumnPath ="FactIncome")]
		public decimal FactIncome { get; set; }
		[CProperty(ColumnPath ="FactInternalCost")]
		public decimal FactInternalCost { get; set; }
		[CProperty(ColumnPath ="FactMargin")]
		public decimal FactMargin { get; set; }
		[CProperty(ColumnPath ="FactMarginPerc")]
		public decimal FactMarginPerc { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IncomeDev")]
		public decimal IncomeDev { get; set; }
		[CProperty(ColumnPath ="IncomeDevPerc")]
		public decimal IncomeDevPerc { get; set; }
		[CProperty(ColumnPath ="InternalCostDev")]
		public decimal InternalCostDev { get; set; }
		[CProperty(ColumnPath ="IsAutoCalcCompletion")]
		public bool IsAutoCalcCompletion { get; set; }
		[CProperty(ColumnPath ="MarginDev")]
		public decimal MarginDev { get; set; }
		[CProperty(ColumnPath ="MarginDevPerc")]
		public decimal MarginDevPerc { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentProjectId")]
		public Guid ParentProjectId { get; set; }
		[CProperty(ColumnPath ="PlanExpense")]
		public decimal PlanExpense { get; set; }
		[CProperty(ColumnPath ="PlanExternalCost")]
		public decimal PlanExternalCost { get; set; }
		[CProperty(ColumnPath ="PlanExternalDevPerc")]
		public decimal PlanExternalDevPerc { get; set; }
		[CProperty(ColumnPath ="PlanIncome")]
		public decimal PlanIncome { get; set; }
		[CProperty(ColumnPath ="PlanInternalCost")]
		public decimal PlanInternalCost { get; set; }
		[CProperty(ColumnPath ="PlanInternalDevPerc")]
		public decimal PlanInternalDevPerc { get; set; }
		[CProperty(ColumnPath ="PlanMargin")]
		public decimal PlanMargin { get; set; }
		[CProperty(ColumnPath ="PlanMarginPerc")]
		public decimal PlanMarginPerc { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectEntryTypeId")]
		public Guid ProjectEntryTypeId { get; set; }
		[CProperty(ColumnPath ="ResponsibleDepartmentId")]
		public Guid ResponsibleDepartmentId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SupplierId")]
		public Guid SupplierId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
