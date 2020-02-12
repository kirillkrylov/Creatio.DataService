using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadSource")]
	public class LeadSource : BaseEntity
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
		[CProperty(ColumnPath ="LeadMediumId")]
		public Guid LeadMediumId { get; set; }
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="LeadMedium:LeadMediumId")]
		public LeadMedium LeadMedium { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmRefRule:LeadSourceId")]
		public virtual ICollection<BpmRefRule> BpmRefRuleByLeadSource { get; set; }
		[CProperty(Association ="ExesInRequest:LeadSourceId")]
		public virtual ICollection<ExesInRequest> ExesInRequestByLeadSource { get; set; }
		[CProperty(Association ="Lead:LeadSourceId")]
		public virtual ICollection<Lead> LeadByLeadSource { get; set; }
		[CProperty(Association ="Lead:ClientLeadSourceId")]
		public virtual ICollection<Lead> LeadByClientLeadSource { get; set; }
		[CProperty(Association ="LeadSourceCode:LeadSourceId")]
		public virtual ICollection<LeadSourceCode> LeadSourceCodeByLeadSource { get; set; }
		[CProperty(Association ="LeadSourceUrl:LeadSourceId")]
		public virtual ICollection<LeadSourceUrl> LeadSourceUrlByLeadSource { get; set; }
		[CProperty(Association ="MktgActivityRule:LeadSourceId")]
		public virtual ICollection<MktgActivityRule> MktgActivityRuleByLeadSource { get; set; }
		[CProperty(Association ="Opportunity:LeadSourceId")]
		public virtual ICollection<Opportunity> OpportunityByLeadSource { get; set; }
		[CProperty(Association ="VwLead:LeadSourceId")]
		public virtual ICollection<VwLead> VwLeadByLeadSource { get; set; }
		[CProperty(Association ="VwLead:ClientLeadSourceId")]
		public virtual ICollection<VwLead> VwLeadByClientLeadSource { get; set; }
		#endregion
	}
}
