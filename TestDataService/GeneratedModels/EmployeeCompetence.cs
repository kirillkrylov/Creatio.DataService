using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeCompetence")]
	public class EmployeeCompetence : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Actual")]
		public decimal Actual { get; set; }
		[CProperty(ColumnPath ="CompetenceId")]
		public Guid CompetenceId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmployeeComment")]
		public string EmployeeComment { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InteractionWithManagerId")]
		public Guid InteractionWithManagerId { get; set; }
		[CProperty(ColumnPath ="ManagerComment")]
		public string ManagerComment { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Percentage")]
		public decimal Percentage { get; set; }
		[CProperty(ColumnPath ="Plan")]
		public decimal Plan { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Competence:CompetenceId")]
		public Competence Competence { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="InteractionWithManager:InteractionWithManagerId")]
		public InteractionWithManager InteractionWithManager { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
