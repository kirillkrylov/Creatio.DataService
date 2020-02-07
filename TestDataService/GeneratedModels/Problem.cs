using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Problem")]
	public class Problem : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId { get; set; }
		[CProperty(ColumnPath ="ChangeId")]
		public Guid ChangeId { get; set; }
		[CProperty(ColumnPath ="ClosureDate")]
		public DateTime ClosureDate { get; set; }
		[CProperty(ColumnPath ="ConfItemId")]
		public Guid ConfItemId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="GroupId")]
		public Guid GroupId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Number")]
		public string Number { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegisteredOn")]
		public DateTime RegisteredOn { get; set; }
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId { get; set; }
		[CProperty(ColumnPath ="Solution")]
		public string Solution { get; set; }
		[CProperty(ColumnPath ="SolutionPlanedOn")]
		public DateTime SolutionPlanedOn { get; set; }
		[CProperty(ColumnPath ="SolutionProvidedOn")]
		public DateTime SolutionProvidedOn { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="Symptoms")]
		public string Symptoms { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Change:ChangeId")]
		public Change Change { get; set; }
		[CProperty(Navigation ="ConfItem:ConfItemId")]
		public ConfItem ConfItem { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="ProblemPriority:PriorityId")]
		public ProblemPriority Priority { get; set; }
		[CProperty(Navigation ="ProblemStatus:StatusId")]
		public ProblemStatus Status { get; set; }
		[CProperty(Navigation ="ProblemType:TypeId")]
		public ProblemType Type { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		[CProperty(Navigation ="SysAdminUnit:GroupId")]
		public SysAdminUnit Group { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:ProblemId")]
		public virtual ICollection<Activity> ActivityByProblem { get; set; }
		[CProperty(Association ="Case:ProblemId")]
		public virtual ICollection<Case> CaseByProblem { get; set; }
		[CProperty(Association ="ProblemFile:ProblemId")]
		public virtual ICollection<ProblemFile> ProblemFileByProblem { get; set; }
		[CProperty(Association ="ProblemInCase:ProblemId")]
		public virtual ICollection<ProblemInCase> ProblemInCaseByProblem { get; set; }
		[CProperty(Association ="ProblemInFolder:ProblemId")]
		public virtual ICollection<ProblemInFolder> ProblemInFolderByProblem { get; set; }
		[CProperty(Association ="ProblemInTag:EntityId")]
		public virtual ICollection<ProblemInTag> ProblemInTagByEntity { get; set; }
		#endregion
	}
}
