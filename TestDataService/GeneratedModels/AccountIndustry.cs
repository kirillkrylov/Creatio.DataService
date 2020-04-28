using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountIndustry")]
	public class AccountIndustry : BaseEntity
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
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:IndustryId")]
		public virtual ICollection<Account> AccountByIndustry { get; set; }
		[CProperty(Association ="Event:IndustryId")]
		public virtual ICollection<Event> EventByIndustry { get; set; }
		[CProperty(Association ="KnowledgeBase:PDEIndustryId")]
		public virtual ICollection<KnowledgeBase> KnowledgeBaseByPDEIndustry { get; set; }
		[CProperty(Association ="Lead:IndustryId")]
		public virtual ICollection<Lead> LeadByIndustry { get; set; }
		[CProperty(Association ="LeadQualification:IndustryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByIndustry { get; set; }
		[CProperty(Association ="Opportunity:IndustryId")]
		public virtual ICollection<Opportunity> OpportunityByIndustry { get; set; }
		[CProperty(Association ="PartnerDomain:IndustryId")]
		public virtual ICollection<PartnerDomain> PartnerDomainByIndustry { get; set; }
		[CProperty(Association ="PDEIndustryInKnowledgeBase:PDEIndustryId")]
		public virtual ICollection<PDEIndustryInKnowledgeBase> PDEIndustryInKnowledgeBaseByPDEIndustry { get; set; }
		[CProperty(Association ="SubIndustry:IndustryId")]
		public virtual ICollection<SubIndustry> SubIndustryByIndustry { get; set; }
		[CProperty(Association ="VwLead:IndustryId")]
		public virtual ICollection<VwLead> VwLeadByIndustry { get; set; }
		#endregion
	}
}
