using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CI")]
	public class CI : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AuthorId")]
		public Guid AuthorId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="ComplexityId")]
		public Guid ComplexityId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="ExecutionPlan")]
		public string ExecutionPlan { get; set; }
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
		[CProperty(ColumnPath ="OfficeId")]
		public Guid OfficeId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ParentImprovementId")]
		public Guid ParentImprovementId { get; set; }
		[CProperty(ColumnPath ="PlanEndDate")]
		public DateTime PlanEndDate { get; set; }
		[CProperty(ColumnPath ="PlanStartDate")]
		public DateTime PlanStartDate { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RegistrationDate")]
		public DateTime RegistrationDate { get; set; }
		[CProperty(ColumnPath ="ReportedDate")]
		public DateTime ReportedDate { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="TerritoryId")]
		public Guid TerritoryId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CI:ParentImprovementId")]
		public CI ParentImprovement { get; set; }
		[CProperty(Navigation ="CIStatus:StatusId")]
		public CIStatus Status { get; set; }
		[CProperty(Navigation ="CIType:TypeId")]
		public CIType Type { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AuthorId")]
		public Contact Author { get; set; }
		[CProperty(Navigation ="CountryCodes:OfficeId")]
		public CountryCodes Office { get; set; }
		[CProperty(Navigation ="ImprovementCategory:CategoryId")]
		public ImprovementCategory Category { get; set; }
		[CProperty(Navigation ="ImprovementComplexity:ComplexityId")]
		public ImprovementComplexity Complexity { get; set; }
		[CProperty(Navigation ="ImprovementPriority:PriorityId")]
		public ImprovementPriority Priority { get; set; }
		[CProperty(Navigation ="ImprovementTerritory:TerritoryId")]
		public ImprovementTerritory Territory { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:CIId")]
		public virtual ICollection<Activity> ActivityByCI { get; set; }
		[CProperty(Association ="CI:ParentImprovementId")]
		public virtual ICollection<CI> CIByParentImprovement { get; set; }
		[CProperty(Association ="CIFile:CIId")]
		public virtual ICollection<CIFile> CIFileByCI { get; set; }
		[CProperty(Association ="CIInFolder:CIId")]
		public virtual ICollection<CIInFolder> CIInFolderByCI { get; set; }
		[CProperty(Association ="CIInTag:EntityId")]
		public virtual ICollection<CIInTag> CIInTagByEntity { get; set; }
		[CProperty(Association ="CIVisa:CIId")]
		public virtual ICollection<CIVisa> CIVisaByCI { get; set; }
		[CProperty(Association ="EmployeeProjectReview:ImprovementId")]
		public virtual ICollection<EmployeeProjectReview> EmployeeProjectReviewByImprovement { get; set; }
		[CProperty(Association ="ImprovementParticipant:ImprovementId")]
		public virtual ICollection<ImprovementParticipant> ImprovementParticipantByImprovement { get; set; }
		#endregion
	}
}
