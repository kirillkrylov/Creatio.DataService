using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Competence")]
	public class Competence : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Literature")]
		public string Literature { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OtherWays")]
		public string OtherWays { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
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
