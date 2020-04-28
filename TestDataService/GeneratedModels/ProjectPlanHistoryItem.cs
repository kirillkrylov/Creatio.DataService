using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProjectPlanHistoryItem")]
	public class ProjectPlanHistoryItem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualCompletion")]
		public decimal ActualCompletion { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PlanningCompletion")]
		public decimal PlanningCompletion { get; set; }
		[CProperty(ColumnPath ="PlanningWork")]
		public decimal PlanningWork { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProjectId")]
		public Guid ProjectId { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Project:ProjectId")]
		public Project Project { get; set; }
		[CProperty(Navigation ="ProjectRole:RoleId")]
		public ProjectRole Role { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
