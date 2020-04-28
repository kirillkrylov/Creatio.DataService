using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DismissalInitiator")]
	public class DismissalInitiator : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
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
		[CProperty(Association ="Employee:DismissalInitiatorId")]
		public virtual ICollection<Employee> EmployeeByDismissalInitiator { get; set; }
		[CProperty(Association ="EmployeeCareer:DismissalInitiatorId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByDismissalInitiator { get; set; }
		[CProperty(Association ="InteractionWithManager:DismissalInitiatorId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByDismissalInitiator { get; set; }
		[CProperty(Association ="InternalRequest:DismissalInitiatorId")]
		public virtual ICollection<InternalRequest> InternalRequestByDismissalInitiator { get; set; }
		#endregion
	}
}
