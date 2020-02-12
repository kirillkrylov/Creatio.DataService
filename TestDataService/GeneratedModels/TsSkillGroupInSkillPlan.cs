using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSkillGroupInSkillPlan")]
	public class TsSkillGroupInSkillPlan : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="SkillGroupId")]
		public Guid SkillGroupId { get; set; }
		[CProperty(ColumnPath ="SkillPlanId")]
		public Guid SkillPlanId { get; set; }
		[CProperty(ColumnPath ="Weight")]
		public int Weight { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSkillGroup:SkillGroupId")]
		public TsSkillGroup SkillGroup { get; set; }
		[CProperty(Navigation ="TsSkillPlan:SkillPlanId")]
		public TsSkillPlan SkillPlan { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
