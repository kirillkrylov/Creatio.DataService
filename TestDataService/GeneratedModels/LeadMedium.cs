using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadMedium")]
	public class LeadMedium : BaseEntity
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
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BpmRefRule:LeadMediumId")]
		public virtual ICollection<BpmRefRule> BpmRefRuleByLeadMedium { get; set; }
		[CProperty(Association ="Lead:LeadMediumId")]
		public virtual ICollection<Lead> LeadByLeadMedium { get; set; }
		[CProperty(Association ="LeadMediumCode:LeadMediumId")]
		public virtual ICollection<LeadMediumCode> LeadMediumCodeByLeadMedium { get; set; }
		[CProperty(Association ="LeadSource:LeadMediumId")]
		public virtual ICollection<LeadSource> LeadSourceByLeadMedium { get; set; }
		[CProperty(Association ="MktgActivity:ChannelId")]
		public virtual ICollection<MktgActivity> MktgActivityByChannel { get; set; }
		[CProperty(Association ="MktgActivityRule:LeadMediumId")]
		public virtual ICollection<MktgActivityRule> MktgActivityRuleByLeadMedium { get; set; }
		[CProperty(Association ="Opportunity:LeadChannelId")]
		public virtual ICollection<Opportunity> OpportunityByLeadChannel { get; set; }
		[CProperty(Association ="VwLead:LeadMediumId")]
		public virtual ICollection<VwLead> VwLeadByLeadMedium { get; set; }
		#endregion
	}
}