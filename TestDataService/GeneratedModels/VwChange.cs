using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwChange")]
	public class VwChange : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualLabor")]
		public int ActualLabor { get; set; }
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="ChangeId")]
		public Guid ChangeId { get; set; }
		[CProperty(ColumnPath ="ClosureDate")]
		public DateTime ClosureDate { get; set; }
		[CProperty(ColumnPath ="ComplexityId")]
		public Guid ComplexityId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="FakeColumn")]
		public int FakeColumn { get; set; }
		[CProperty(ColumnPath ="GroupId")]
		public Guid GroupId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsAutoUpdated")]
		public bool IsAutoUpdated { get; set; }
		[CProperty(ColumnPath ="IsHasRevert")]
		public bool IsHasRevert { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentChangeId")]
		public Guid ParentChangeId { get; set; }
		[CProperty(ColumnPath ="PlannedLabor")]
		public int PlannedLabor { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductFunctionId")]
		public Guid ProductFunctionId { get; set; }
		[CProperty(ColumnPath ="ProductModuleId")]
		public Guid ProductModuleId { get; set; }
		[CProperty(ColumnPath ="PurposeId")]
		public Guid PurposeId { get; set; }
		[CProperty(ColumnPath ="RegisteredOn")]
		public DateTime RegisteredOn { get; set; }
		[CProperty(ColumnPath ="ReleaseId")]
		public Guid ReleaseId { get; set; }
		[CProperty(ColumnPath ="SatisfactionComment")]
		public string SatisfactionComment { get; set; }
		[CProperty(ColumnPath ="SatisfactionLevelId")]
		public Guid SatisfactionLevelId { get; set; }
		[CProperty(ColumnPath ="ScheduledClosureDate")]
		public DateTime ScheduledClosureDate { get; set; }
		[CProperty(ColumnPath ="SolutionDescription")]
		public string SolutionDescription { get; set; }
		[CProperty(ColumnPath ="SourceId")]
		public Guid SourceId { get; set; }
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="UpdateDuration")]
		public decimal UpdateDuration { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseSubtype:ProductFunctionId")]
		public CaseSubtype ProductFunction { get; set; }
		[CProperty(Navigation ="CaseType:ProductModuleId")]
		public CaseType ProductModule { get; set; }
		[CProperty(Navigation ="Change:ParentChangeId")]
		public Change ParentChange { get; set; }
		[CProperty(Navigation ="Change:ChangeId")]
		public Change Change { get; set; }
		[CProperty(Navigation ="ChangeCategory:CategoryId")]
		public ChangeCategory Category { get; set; }
		[CProperty(Navigation ="ChangeDirectory:StageId")]
		public ChangeDirectory Stage { get; set; }
		[CProperty(Navigation ="ChangePriority:PriorityId")]
		public ChangePriority Priority { get; set; }
		[CProperty(Navigation ="ChangePurpose:PurposeId")]
		public ChangePurpose Purpose { get; set; }
		[CProperty(Navigation ="ChangeSource:SourceId")]
		public ChangeSource Source { get; set; }
		[CProperty(Navigation ="ChangeStatus:StatusId")]
		public ChangeStatus Status { get; set; }
		[CProperty(Navigation ="ChangeType:TypeId")]
		public ChangeType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ImprovementComplexity:ComplexityId")]
		public ImprovementComplexity Complexity { get; set; }
		[CProperty(Navigation ="Release:ReleaseId")]
		public Release Release { get; set; }
		[CProperty(Navigation ="SatisfactionLevel:SatisfactionLevelId")]
		public SatisfactionLevel SatisfactionLevel { get; set; }
		[CProperty(Navigation ="SysAdminUnit:GroupId")]
		public SysAdminUnit Group { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
