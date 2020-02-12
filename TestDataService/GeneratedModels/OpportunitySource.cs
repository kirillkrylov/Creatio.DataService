using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunitySource")]
	public class OpportunitySource : BaseEntity
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
		[CProperty(ColumnPath ="IsPrimary")]
		public bool IsPrimary { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Lead:ClientLeadMediumId")]
		public virtual ICollection<Lead> LeadByClientLeadMedium { get; set; }
		[CProperty(Association ="Opportunity:SourceId")]
		public virtual ICollection<Opportunity> OpportunityBySource { get; set; }
		[CProperty(Association ="Opportunity:ClientLeadChannelId")]
		public virtual ICollection<Opportunity> OpportunityByClientLeadChannel { get; set; }
		[CProperty(Association ="VwLead:ClientLeadMediumId")]
		public virtual ICollection<VwLead> VwLeadByClientLeadMedium { get; set; }
		#endregion
	}
}
