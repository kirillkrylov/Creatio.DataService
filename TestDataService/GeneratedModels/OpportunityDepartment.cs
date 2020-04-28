using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityDepartment")]
	public class OpportunityDepartment : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IndustryProgressManagerUnitId")]
		public Guid IndustryProgressManagerUnitId { get; set; }
		[CProperty(ColumnPath ="IsHidden")]
		public bool IsHidden { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="MPPGroupLeaderUnitId")]
		public Guid MPPGroupLeaderUnitId { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="PracticeDirectorUnitId")]
		public Guid PracticeDirectorUnitId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SalesDirectorId")]
		public Guid SalesDirectorId { get; set; }
		[CProperty(ColumnPath ="SalesManagerUnitId")]
		public Guid SalesManagerUnitId { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:SalesDirectorId")]
		public Contact SalesDirector { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:PracticeDirectorUnitId")]
		public SysAdminUnit PracticeDirectorUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SalesManagerUnitId")]
		public SysAdminUnit SalesManagerUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:IndustryProgressManagerUnitId")]
		public SysAdminUnit IndustryProgressManagerUnit { get; set; }
		[CProperty(Navigation ="SysAdminUnit:MPPGroupLeaderUnitId")]
		public SysAdminUnit MPPGroupLeaderUnit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:OpportunityDepartmentId")]
		public virtual ICollection<Account> AccountByOpportunityDepartment { get; set; }
		[CProperty(Association ="AccountIndustry:OpportunityDepartmentId")]
		public virtual ICollection<AccountIndustry> AccountIndustryByOpportunityDepartment { get; set; }
		[CProperty(Association ="DepartmentTypeTerritory:OpportunityDepartmentId")]
		public virtual ICollection<DepartmentTypeTerritory> DepartmentTypeTerritoryByOpportunityDepartment { get; set; }
		[CProperty(Association ="GlbCustomer:GlbDepartmentId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbDepartment { get; set; }
		[CProperty(Association ="Lead:OpportunityDepartmentId")]
		public virtual ICollection<Lead> LeadByOpportunityDepartment { get; set; }
		[CProperty(Association ="LeadOwnerFillRule:OpportunityDepartmentId")]
		public virtual ICollection<LeadOwnerFillRule> LeadOwnerFillRuleByOpportunityDepartment { get; set; }
		[CProperty(Association ="LeadType:OpportunityDepartmentId")]
		public virtual ICollection<LeadType> LeadTypeByOpportunityDepartment { get; set; }
		[CProperty(Association ="OppDepartmentForecast:OpportunityDepartmentId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByOpportunityDepartment { get; set; }
		[CProperty(Association ="Opportunity:ResponsibleDepartmentId")]
		public virtual ICollection<Opportunity> OpportunityByResponsibleDepartment { get; set; }
		[CProperty(Association ="Project:ResponsibleDepartmentId")]
		public virtual ICollection<Project> ProjectByResponsibleDepartment { get; set; }
		[CProperty(Association ="PsProjectServers:OpportunityDepartmentId")]
		public virtual ICollection<PsProjectServers> PsProjectServersByOpportunityDepartment { get; set; }
		[CProperty(Association ="TsSalesCareer:OpportunityDepartmentId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByOpportunityDepartment { get; set; }
		[CProperty(Association ="VwLead:OpportunityDepartmentId")]
		public virtual ICollection<VwLead> VwLeadByOpportunityDepartment { get; set; }
		[CProperty(Association ="VwTsSalesCareer:OpportunityDepartmentId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByOpportunityDepartment { get; set; }
		#endregion
	}
}
