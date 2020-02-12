using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Budget")]
	public class Budget : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualAmount")]
		public decimal ActualAmount { get; set; }
		[CProperty(ColumnPath ="ApprovalAmount")]
		public decimal ApprovalAmount { get; set; }
		[CProperty(ColumnPath ="Balance")]
		public decimal Balance { get; set; }
		[CProperty(ColumnPath ="CostCenterId")]
		public Guid CostCenterId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FullYearBalance")]
		public decimal FullYearBalance { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId { get; set; }
		[CProperty(ColumnPath ="PlannedAmount")]
		public decimal PlannedAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="YTDBalance")]
		public decimal YTDBalance { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="CostCenter:CostCenterId")]
		public CostCenter CostCenter { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BudgetFile:BudgetId")]
		public virtual ICollection<BudgetFile> BudgetFileByBudget { get; set; }
		[CProperty(Association ="BudgetInFolder:BudgetId")]
		public virtual ICollection<BudgetInFolder> BudgetInFolderByBudget { get; set; }
		[CProperty(Association ="BudgetInTag:EntityId")]
		public virtual ICollection<BudgetInTag> BudgetInTagByEntity { get; set; }
		[CProperty(Association ="BudgetItem:BudgetId")]
		public virtual ICollection<BudgetItem> BudgetItemByBudget { get; set; }
		#endregion
	}
}
