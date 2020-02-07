using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Release")]
	public class Release : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ActualDeploymentLabor")]
		public int ActualDeploymentLabor { get; set; }
		[CProperty(ColumnPath ="ActualDevelopmentLabor")]
		public int ActualDevelopmentLabor { get; set; }
		[CProperty(ColumnPath ="ActualLabor")]
		public int ActualLabor { get; set; }
		[CProperty(ColumnPath ="ActualTestingLabor")]
		public int ActualTestingLabor { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DeploymentFinishedOn")]
		public DateTime DeploymentFinishedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DevelopmentFinishedOn")]
		public DateTime DevelopmentFinishedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
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
		[CProperty(ColumnPath ="PlannedLabor")]
		public int PlannedLabor { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReleasedOn")]
		public DateTime ReleasedOn { get; set; }
		[CProperty(ColumnPath ="ScheduledReleaseDate")]
		public DateTime ScheduledReleaseDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TestingFinishedOn")]
		public DateTime TestingFinishedOn { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ReleasePriority:PriorityId")]
		public ReleasePriority Priority { get; set; }
		[CProperty(Navigation ="ReleaseStatus:StatusId")]
		public ReleaseStatus Status { get; set; }
		[CProperty(Navigation ="ReleaseType:TypeId")]
		public ReleaseType Type { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ReleaseId")]
		public virtual ICollection<Activity> ActivityByRelease { get; set; }
		[CProperty(Association ="Change:ReleaseId")]
		public virtual ICollection<Change> ChangeByRelease { get; set; }
		[CProperty(Association ="ReleaseConfItem:ReleaseId")]
		public virtual ICollection<ReleaseConfItem> ReleaseConfItemByRelease { get; set; }
		[CProperty(Association ="ReleaseFile:ReleaseId")]
		public virtual ICollection<ReleaseFile> ReleaseFileByRelease { get; set; }
		[CProperty(Association ="ReleaseInFolder:ReleaseId")]
		public virtual ICollection<ReleaseInFolder> ReleaseInFolderByRelease { get; set; }
		[CProperty(Association ="ReleaseInTag:EntityId")]
		public virtual ICollection<ReleaseInTag> ReleaseInTagByEntity { get; set; }
		[CProperty(Association ="ReleaseServiceItem:ReleaseId")]
		public virtual ICollection<ReleaseServiceItem> ReleaseServiceItemByRelease { get; set; }
		[CProperty(Association ="ReleaseTeam:ReleaseId")]
		public virtual ICollection<ReleaseTeam> ReleaseTeamByRelease { get; set; }
		[CProperty(Association ="ScheduledDate:ReleaseId")]
		public virtual ICollection<ScheduledDate> ScheduledDateByRelease { get; set; }
		#endregion
	}
}
