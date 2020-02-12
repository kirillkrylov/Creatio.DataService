using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsStaffGoal")]
	public class TsStaffGoal : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="FactGoalDate")]
		public DateTime FactGoalDate { get; set; }
		[CProperty(ColumnPath ="Goal")]
		public string Goal { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="PlanGoalDate")]
		public DateTime PlanGoalDate { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Progress")]
		public decimal Progress { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Weight")]
		public int Weight { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="TsStaffGoal:ParentId")]
		public TsStaffGoal Parent { get; set; }
		[CProperty(Navigation ="TsStaffGoalStatus:StatusId")]
		public TsStaffGoalStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TsStaffGoal:ParentId")]
		public virtual ICollection<TsStaffGoal> TsStaffGoalByParent { get; set; }
		[CProperty(Association ="TsStaffGoalFile:TsStaffGoalId")]
		public virtual ICollection<TsStaffGoalFile> TsStaffGoalFileByTsStaffGoal { get; set; }
		[CProperty(Association ="TsStaffGoalVisa:StaffGoalId")]
		public virtual ICollection<TsStaffGoalVisa> TsStaffGoalVisaByStaffGoal { get; set; }
		#endregion
	}
}
