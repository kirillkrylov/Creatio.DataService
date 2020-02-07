using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseStatus")]
	public class CaseStatus : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ButtonCaption")]
		public string ButtonCaption { get; set; }
		[CProperty(ColumnPath ="ClosureCodeId")]
		public Guid ClosureCodeId { get; set; }
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
		[CProperty(ColumnPath ="IsCloseOnSave")]
		public bool IsCloseOnSave { get; set; }
		[CProperty(ColumnPath ="IsDisplayed")]
		public bool IsDisplayed { get; set; }
		[CProperty(ColumnPath ="IsFinal")]
		public bool IsFinal { get; set; }
		[CProperty(ColumnPath ="IsPaused")]
		public bool IsPaused { get; set; }
		[CProperty(ColumnPath ="IsResolved")]
		public bool IsResolved { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StageNumber")]
		public int StageNumber { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="ClosureCode:ClosureCodeId")]
		public ClosureCode ClosureCode { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysImage:ImageId")]
		public SysImage Image { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Case:StatusId")]
		public virtual ICollection<Case> CaseByStatus { get; set; }
		[CProperty(Association ="CaseLifecycle:StatusId")]
		public virtual ICollection<CaseLifecycle> CaseLifecycleByStatus { get; set; }
		[CProperty(Association ="CaseNextStatus:StatusId")]
		public virtual ICollection<CaseNextStatus> CaseNextStatusByStatus { get; set; }
		[CProperty(Association ="CaseNextStatus:NextStatusId")]
		public virtual ICollection<CaseNextStatus> CaseNextStatusByNextStatus { get; set; }
		[CProperty(Association ="CaseNotificationRule:CaseStatusId")]
		public virtual ICollection<CaseNotificationRule> CaseNotificationRuleByCaseStatus { get; set; }
		[CProperty(Association ="SatisfactionLevel:StatusId")]
		public virtual ICollection<SatisfactionLevel> SatisfactionLevelByStatus { get; set; }
		#endregion
	}
}
