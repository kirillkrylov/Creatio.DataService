using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CasePriority")]
	public class CasePriority : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Color")]
		public string Color { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ImageId")]
		public Guid ImageId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="Priority")]
		public int Priority { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReactionTimeUnitId")]
		public Guid ReactionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="ReactionTimeValue")]
		public int ReactionTimeValue { get; set; }
		[CProperty(ColumnPath ="SolutionTimeUnitId")]
		public Guid SolutionTimeUnitId { get; set; }
		[CProperty(ColumnPath ="SolutionTimeValue")]
		public int SolutionTimeValue { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		[CProperty(Navigation ="TimeUnit:ReactionTimeUnitId")]
		public TimeUnit ReactionTimeUnit { get; set; }
		[CProperty(Navigation ="TimeUnit:SolutionTimeUnitId")]
		public TimeUnit SolutionTimeUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:PriorityId")]
		public virtual ICollection<Case> CaseByPriority { get; set; }
		[CProperty(Association ="CaseLifecycle:PriorityId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByPriority { get; set; }
		[CProperty(Association ="PriorityInSupportLevel:CasePriorityId")]
		public virtual ICollection<PriorityInSupportLevel> PriorityInSupportLevelByCasePriority { get; set; }
		[CProperty(Association ="ServiceInServicePact:PriorityId")]
		public virtual ICollection<ServiceInServicePact> ServiceInServicePactByPriority { get; set; }
		[CProperty(Association ="TimeToPrioritize:CasePriorityId")]
		public virtual ICollection<TimeToPrioritize> TimeToPrioritizeByCasePriority { get; set; }
		#endregion
	}
}
