using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestBudgetHolderByExesType")]
	public class RequestBudgetHolderByExesType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BudgetHolderId")]
		public Guid BudgetHolderId { get; set; }
		[CProperty(ColumnPath ="BudgetTerritoryId")]
		public Guid BudgetTerritoryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ExpenseItemId")]
		public Guid ExpenseItemId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestExesByType:ExpenseItemId")]
		public RequestExesByType ExpenseItem { get; set; }
		[CProperty(Navigation ="SysAdminUnit:BudgetHolderId")]
		public SysAdminUnit BudgetHolder { get; set; }
		[CProperty(Navigation ="Territory:BudgetTerritoryId")]
		public Territory BudgetTerritory { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
