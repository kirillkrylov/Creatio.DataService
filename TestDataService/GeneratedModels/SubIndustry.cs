using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SubIndustry")]
	public class SubIndustry : BaseEntity
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
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:SubIndustryId")]
		public virtual ICollection<Account> AccountBySubIndustry { get; set; }
		[CProperty(Association ="KnowledgeBase:PDESubIndustryId")]
		public virtual ICollection<KnowledgeBase> KnowledgeBaseByPDESubIndustry { get; set; }
		[CProperty(Association ="Lead:SubIndustryId")]
		public virtual ICollection<Lead> LeadBySubIndustry { get; set; }
		[CProperty(Association ="PDEIndustryInKnowledgeBase:PDESubindustryId")]
		public virtual ICollection<PDEIndustryInKnowledgeBase> PDEIndustryInKnowledgeBaseByPDESubindustry { get; set; }
		[CProperty(Association ="VwLead:SubIndustryId")]
		public virtual ICollection<VwLead> VwLeadBySubIndustry { get; set; }
		#endregion
	}
}
