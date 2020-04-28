using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsStaffSkillPeriodDetails")]
	public class TsStaffSkillPeriodDetails : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="PointValue")]
		public decimal PointValue { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Progress")]
		public decimal Progress { get; set; }
		[CProperty(ColumnPath ="SkillGroupId")]
		public Guid SkillGroupId { get; set; }
		[CProperty(ColumnPath ="SkillGroupProgress")]
		public decimal SkillGroupProgress { get; set; }
		[CProperty(ColumnPath ="StaffSkillPeriodId")]
		public Guid StaffSkillPeriodId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="TsSkillGroup:SkillGroupId")]
		public TsSkillGroup SkillGroup { get; set; }
		[CProperty(Navigation ="TsStaffSkillPeriod:StaffSkillPeriodId")]
		public TsStaffSkillPeriod StaffSkillPeriod { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
