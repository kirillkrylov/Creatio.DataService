using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ProjectSolution")]
	public class ProjectSolution : BaseEntity
	{
		#region Values
		private string _BuildFolderLink;
		[CProperty(ColumnPath ="BuildFolderLink")]
		public string BuildFolderLink
		{
			get{return _BuildFolderLink;}
			set
			{
				_BuildFolderLink = value;
				OnPropertyChanged();
			}
		}
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private bool _IsArchive;
		[CProperty(ColumnPath ="IsArchive")]
		public bool IsArchive
		{
			get{return _IsArchive;}
			set
			{
				_IsArchive = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
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
