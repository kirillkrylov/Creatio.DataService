using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CaseLifecycle")]
	public class CaseLifecycle : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CaseId")]
		public Guid CaseId { get; set; }
		[CProperty(ColumnPath ="CaseRecordId")]
		public Guid CaseRecordId { get; set; }
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate { get; set; }
		[CProperty(ColumnPath ="GroupId")]
		public Guid GroupId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="PriorityId")]
		public Guid PriorityId { get; set; }
		[CProperty(ColumnPath ="ProblemId")]
		public Guid ProblemId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ResponseDate")]
		public DateTime ResponseDate { get; set; }
		[CProperty(ColumnPath ="ResponseOverdue")]
		public bool ResponseOverdue { get; set; }
		[CProperty(ColumnPath ="SatisfactionLevelComment")]
		public string SatisfactionLevelComment { get; set; }
		[CProperty(ColumnPath ="SatisfactionLevelId")]
		public Guid SatisfactionLevelId { get; set; }
		[CProperty(ColumnPath ="ServiceItemId")]
		public Guid ServiceItemId { get; set; }
		[CProperty(ColumnPath ="ServicePactId")]
		public Guid ServicePactId { get; set; }
		[CProperty(ColumnPath ="SolutionDate")]
		public DateTime SolutionDate { get; set; }
		[CProperty(ColumnPath ="SolutionOverdue")]
		public bool SolutionOverdue { get; set; }
		[CProperty(ColumnPath ="SolutionProvidedOn")]
		public DateTime SolutionProvidedOn { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StateDurationInDays")]
		public decimal StateDurationInDays { get; set; }
		[CProperty(ColumnPath ="StateDurationInHours")]
		public decimal StateDurationInHours { get; set; }
		[CProperty(ColumnPath ="StateDurationInMinutes")]
		public int StateDurationInMinutes { get; set; }
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId { get; set; }
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId { get; set; }
		[CProperty(ColumnPath ="Symptoms")]
		public string Symptoms { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Case:CaseId")]
		public Case Case { get; set; }
		[CProperty(Navigation ="CaseCategory:CategoryId")]
		public CaseCategory Category { get; set; }
		[CProperty(Navigation ="CasePriority:PriorityId")]
		public CasePriority Priority { get; set; }
		[CProperty(Navigation ="CaseStatus:StatusId")]
		public CaseStatus Status { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Problem:ProblemId")]
		public Problem Problem { get; set; }
		[CProperty(Navigation ="RoleInServiceTeam:SupportLevelId")]
		public RoleInServiceTeam SupportLevel { get; set; }
		[CProperty(Navigation ="SatisfactionLevel:SatisfactionLevelId")]
		public SatisfactionLevel SatisfactionLevel { get; set; }
		[CProperty(Navigation ="ServiceItem:ServiceItemId")]
		public ServiceItem ServiceItem { get; set; }
		[CProperty(Navigation ="ServicePact:ServicePactId")]
		public ServicePact ServicePact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:GroupId")]
		public SysAdminUnit Group { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
