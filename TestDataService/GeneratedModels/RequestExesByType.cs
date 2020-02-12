using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestExesByType")]
	public class RequestExesByType : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
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
		[CProperty(ColumnPath ="RequestExesId")]
		public Guid RequestExesId { get; set; }
		[CProperty(ColumnPath ="RequestExesTypeId")]
		public Guid RequestExesTypeId { get; set; }
		[CProperty(ColumnPath ="RequestTypeId")]
		public Guid RequestTypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestExes:RequestExesId")]
		public RequestExes RequestExes { get; set; }
		[CProperty(Navigation ="RequestExesType:RequestExesTypeId")]
		public RequestExesType RequestExesType { get; set; }
		[CProperty(Navigation ="RequestType:RequestTypeId")]
		public RequestType RequestType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BudgetItem:ExpenseId")]
		public virtual ICollection<BudgetItem> BudgetItemByExpense { get; set; }
		[CProperty(Association ="RequestBudgetHolderByExesType:ExpenseItemId")]
		public virtual ICollection<RequestBudgetHolderByExesType> RequestBudgetHolderByExesTypeByExpenseItem { get; set; }
		#endregion
	}
}
