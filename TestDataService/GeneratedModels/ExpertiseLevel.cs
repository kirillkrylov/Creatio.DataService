using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExpertiseLevel")]
	public class ExpertiseLevel : BaseEntity
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
		[CProperty(Association ="Applicant:ExpertiseLevelId")]
		public virtual ICollection<Applicant> ApplicantByExpertiseLevel { get; set; }
		[CProperty(Association ="Employee:ExpertiseLevelId")]
		public virtual ICollection<Employee> EmployeeByExpertiseLevel { get; set; }
		[CProperty(Association ="InteractionWithManager:ExpertiseLevelId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByExpertiseLevel { get; set; }
		#endregion
	}
}
