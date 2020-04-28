using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeProjectReview")]
	public class EmployeeProjectReview : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ImprovementId")]
		public Guid ImprovementId { get; set; }
		[CProperty(ColumnPath ="InteractionWithManagerId")]
		public Guid InteractionWithManagerId { get; set; }
		[CProperty(ColumnPath ="ManagerComment")]
		public string ManagerComment { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Project")]
		public string Project { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CI:ImprovementId")]
		public CI Improvement { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmployeeProjectStatus:StatusId")]
		public EmployeeProjectStatus Status { get; set; }
		[CProperty(Navigation ="InteractionWithManager:InteractionWithManagerId")]
		public InteractionWithManager InteractionWithManager { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
