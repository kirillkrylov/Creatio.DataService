using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrderExpense")]
	public class OrderExpense : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Comments")]
		public string Comments { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderId")]
		public Guid OrderId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductId")]
		public Guid ProductId { get; set; }
		[CProperty(ColumnPath ="Rate")]
		public decimal Rate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Sum")]
		public decimal Sum { get; set; }
		[CProperty(ColumnPath ="TargetId")]
		public Guid TargetId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:TargetId")]
		public Account Target { get; set; }
		[CProperty(Navigation ="CompensationStatus:StatusId")]
		public CompensationStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="ExpenseType:TypeId")]
		public ExpenseType Type { get; set; }
		[CProperty(Navigation ="Order:OrderId")]
		public Order Order { get; set; }
		[CProperty(Navigation ="OrderProduct:ProductId")]
		public OrderProduct Product { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
