using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TimeToPrioritize")]
	public class TimeToPrioritize : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CasePriorityId")]
		public Guid CasePriorityId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReactionTimeUnitId")]
		public Guid ReactionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="ReactionTimeValue")]
		public int ReactionTimeValue { get; set; }
		[CProperty(ColumnPath ="ServiceInServicePactId")]
		public Guid ServiceInServicePactId { get; set; }
		[CProperty(ColumnPath ="SolutionTimeUnitId")]
		public Guid SolutionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="SolutionTimeValue")]
		public int SolutionTimeValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CasePriority:CasePriorityId")]
		public CasePriority CasePriority { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ServiceInServicePact:ServiceInServicePactId")]
		public ServiceInServicePact ServiceInServicePact { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
