using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSkill")]
	public class TsSkill : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Active")]
		public bool Active { get; set; }
		[CProperty(ColumnPath ="AutoSendForApproval")]
		public bool AutoSendForApproval { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Decision")]
		public string Decision { get; set; }
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
		[CProperty(ColumnPath ="RangeRule")]
		public bool RangeRule { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SkillGroupId")]
		public Guid SkillGroupId { get; set; }
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
		#endregion

		#region Associations
		[CProperty(Association ="TsSkillPlanDefaultSkills:SkillId")]
		public virtual ICollection<TsSkillPlanDefaultSkills> TsSkillPlanDefaultSkillsBySkill { get; set; }
		[CProperty(Association ="TsSkillRangeValue:SkillId")]
		public virtual ICollection<TsSkillRangeValue> TsSkillRangeValueBySkill { get; set; }
		[CProperty(Association ="TsStaffSkillPeriodValue:SkillId")]
		public virtual ICollection<TsStaffSkillPeriodValue> TsStaffSkillPeriodValueBySkill { get; set; }
		#endregion
	}
}
