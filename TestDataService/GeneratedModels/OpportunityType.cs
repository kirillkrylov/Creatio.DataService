using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityType")]
	public class OpportunityType : BaseEntity
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
		[CProperty(Association ="Lead:SalesChannelId")]
		public virtual ICollection<Lead> LeadBySalesChannel { get; set; }
		[CProperty(Association ="Lead:TypeId")]
		public virtual ICollection<Lead> LeadByType { get; set; }
		[CProperty(Association ="Opportunity:TypeId")]
		public virtual ICollection<Opportunity> OpportunityByType { get; set; }
		[CProperty(Association ="VwLead:SalesChannelId")]
		public virtual ICollection<VwLead> VwLeadBySalesChannel { get; set; }
		[CProperty(Association ="VwLead:TypeId")]
		public virtual ICollection<VwLead> VwLeadByType { get; set; }
		[CProperty(Association ="VwPortalOpportunity:TypeId")]
		public virtual ICollection<VwPortalOpportunity> VwPortalOpportunityByType { get; set; }
		#endregion
	}
}
