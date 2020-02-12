using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TimeUnit")]
	public class TimeUnit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
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
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
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
		[CProperty(Association ="Case:ProcessingTimeUnitId")]
		public virtual ICollection<Case> CaseByProcessingTimeUnit { get; set; }
		[CProperty(Association ="CasePriority:ReactionTimeUnitId")]
		public virtual ICollection<CasePriority> CasePriorityByReactionTimeUnit { get; set; }
		[CProperty(Association ="CasePriority:SolutionTimeUnitId")]
		public virtual ICollection<CasePriority> CasePriorityBySolutionTimeUnit { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:ReactionTimeUnitId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelByReactionTimeUnit { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:SolutionTimeUnitId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelBySolutionTimeUnit { get; set; }
		[CProperty(Association ="ServiceInServicePact:ReactionTimeUnitId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByReactionTimeUnit { get; set; }
		[CProperty(Association ="ServiceInServicePact:SolutionTimeUnitId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactBySolutionTimeUnit { get; set; }
		[CProperty(Association ="ServiceItem:ReactionTimeUnitId")]
		public virtual ICollection<ServiceItem> ServiceItemByReactionTimeUnit { get; set; }
		[CProperty(Association ="ServiceItem:SolutionTimeUnitId")]
		public virtual ICollection<ServiceItem> ServiceItemBySolutionTimeUnit { get; set; }
		[CProperty(Association ="TimeToPrioritize:ReactionTimeUnitId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeByReactionTimeUnit { get; set; }
		[CProperty(Association ="TimeToPrioritize:SolutionTimeUnitId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeBySolutionTimeUnit { get; set; }
		#endregion
	}
}
