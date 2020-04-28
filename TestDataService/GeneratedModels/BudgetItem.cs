using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BudgetItem")]
	public class BudgetItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualAmount")]
		public decimal ActualAmount { get; set; }
		[CProperty(ColumnPath ="ApprovalAmount")]
		public decimal ApprovalAmount { get; set; }
		[CProperty(ColumnPath ="Balance")]
		public decimal Balance { get; set; }
		[CProperty(ColumnPath ="BudgetId")]
		public Guid BudgetId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExpenseId")]
		public Guid ExpenseId { get; set; }
		[CProperty(ColumnPath ="FullYearBalance")]
		public decimal FullYearBalance { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PlannedAmount")]
		public decimal PlannedAmount { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="YTDBalance")]
		public decimal YTDBalance { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Budget:BudgetId")]
		public Budget Budget { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestExesByType:ExpenseId")]
		public RequestExesByType Expense { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
