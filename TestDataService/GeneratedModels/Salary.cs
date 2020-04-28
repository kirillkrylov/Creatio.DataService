using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Salary")]
	public class Salary : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SalaryBaseValue")]
		public decimal SalaryBaseValue { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="UnitForCalculationId")]
		public Guid UnitForCalculationId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="UnitForCalculation:UnitForCalculationId")]
		public UnitForCalculation UnitForCalculation { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
