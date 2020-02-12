using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProjectSolution")]
	public class ProjectSolution : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BuildFolderLink")]
		public string BuildFolderLink { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsArchive")]
		public bool IsArchive { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
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
		[CProperty(Association ="ProjectSolutionFile:ProjectSolutionId")]
		public virtual ICollection<ProjectSolutionFile> ProjectSolutionFileByProjectSolution { get; set; }
		[CProperty(Association ="ProjectSolutionInFolder:ProjectSolutionId")]
		public virtual ICollection<ProjectSolutionInFolder> ProjectSolutionInFolderByProjectSolution { get; set; }
		[CProperty(Association ="ProjectSolutionInTag:EntityId")]
		public virtual ICollection<ProjectSolutionInTag> ProjectSolutionInTagByEntity { get; set; }
		[CProperty(Association ="PsDelivery:ProjectSolutionId")]
		public virtual ICollection<PsDelivery> PsDeliveryByProjectSolution { get; set; }
		[CProperty(Association ="PsJiraEpic:ProjectSolutionId")]
		public virtual ICollection<PsJiraEpic> PsJiraEpicByProjectSolution { get; set; }
		[CProperty(Association ="PsProjectEnvironment:ProjectSolutionId")]
		public virtual ICollection<PsProjectEnvironment> PsProjectEnvironmentByProjectSolution { get; set; }
		[CProperty(Association ="PsTeam:ProjectSolutionId")]
		public virtual ICollection<PsTeam> PsTeamByProjectSolution { get; set; }
		#endregion
	}
}
