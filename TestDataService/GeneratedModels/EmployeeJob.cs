using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeJob")]
	public class EmployeeJob : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Core")]
		public bool Core { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="Director")]
		public bool Director { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Phone")]
		public bool Phone { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SLA")]
		public int SLA { get; set; }
		[CProperty(ColumnPath ="VirtualMachine")]
		public bool VirtualMachine { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Applicant:JobId")]
		public virtual ICollection<Applicant> ApplicantByJob { get; set; }
		[CProperty(Association ="CompetencesByRoles:RoleId")]
		public virtual ICollection<CompetencesByRoles> CompetencesByRolesByRole { get; set; }
		[CProperty(Association ="Employee:JobId")]
		public virtual ICollection<Employee> EmployeeByJob { get; set; }
		[CProperty(Association ="EmployeeCareer:EmployeeJobId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByEmployeeJob { get; set; }
		[CProperty(Association ="HRTalks:RoleINcompanyId")]
		public virtual ICollection<HRTalks> HRTalksByRoleINcompany { get; set; }
		[CProperty(Association ="InteractionWithManager:RoleInCompanyId")]
		public virtual ICollection<InteractionWithManager> InteractionWithManagerByRoleInCompany { get; set; }
		[CProperty(Association ="InternalRequest:EmployeeJobId")]
		public virtual ICollection<InternalRequest> InternalRequestByEmployeeJob { get; set; }
		[CProperty(Association ="LeadQueueOperatorsJobs:EmployeeJobId")]
		public virtual ICollection<LeadQueueOperatorsJobs> LeadQueueOperatorsJobsByEmployeeJob { get; set; }
		[CProperty(Association ="OrgStructureUnit:JobId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByJob { get; set; }
		[CProperty(Association ="RecruitmentInStage:EmployeeJobId")]
		public virtual ICollection<RecruitmentInStage> RecruitmentInStageByEmployeeJob { get; set; }
		[CProperty(Association ="SMHealthCheck:RoleId")]
		public virtual ICollection<SMHealthCheck> SMHealthCheckByRole { get; set; }
		#endregion
	}
}
