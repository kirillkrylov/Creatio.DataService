using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ReasonForLeaving")]
	public class ReasonForLeaving : BaseEntity
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Employee:ReasonForDismissalId")]
		public virtual ICollection<Employee> EmployeeByReasonForDismissal { get; set; }
		[CProperty(Association ="EmployeeCareer:ReasonForDismissalId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByReasonForDismissal { get; set; }
		[CProperty(Association ="InteractionWithManager:DissatisfactionReasonsId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByDissatisfactionReasons { get; set; }
		[CProperty(Association ="InteractionWithManager:ReasonForDismissalId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByReasonForDismissal { get; set; }
		#endregion
	}
}