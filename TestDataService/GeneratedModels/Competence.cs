using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Competence")]
	public class Competence : BaseEntity
	{
		#region Values
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private string _Literature;
		[CProperty(ColumnPath ="Literature")]
		public string Literature
		{
			get{return _Literature;}
			set
			{
				_Literature = value;
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
		private string _OtherWays;
		[CProperty(ColumnPath ="OtherWays")]
		public string OtherWays
		{
			get{return _OtherWays;}
			set
			{
				_OtherWays = value;
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
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="CompetenceType:TypeId")]
		public CompetenceType Type { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="CompetenceFile:CompetenceId")]
		public virtual ICollection<CompetenceFile> CompetenceFileByCompetence { get; set; }
		[CProperty(Association ="CompetenceInFolder:CompetenceId")]
		public virtual ICollection<CompetenceInFolder> CompetenceInFolderByCompetence { get; set; }
		[CProperty(Association ="CompetenceInTag:EntityId")]
		public virtual ICollection<CompetenceInTag> CompetenceInTagByEntity { get; set; }
		[CProperty(Association ="CompetencesByRoles:CompetenceId")]
		public virtual ICollection<CompetencesByRoles> CompetencesByRolesByCompetence { get; set; }
		[CProperty(Association ="EmployeeCompetence:CompetenceId")]
		public virtual ICollection<EmployeeCompetence> EmployeeCompetenceByCompetence { get; set; }
		[CProperty(Association ="PDP:CompetenceId")]
		public virtual ICollection<PDP> PDPByCompetence { get; set; }
		#endregion
	}
}
