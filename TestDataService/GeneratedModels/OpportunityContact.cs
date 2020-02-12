using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityContact")]
	public class OpportunityContact : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContactLoyalityId")]
		public Guid ContactLoyalityId { get; set; }
		[CProperty(ColumnPath ="ContactMotivator")]
		public string ContactMotivator { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="GlbAccountId")]
		public Guid GlbAccountId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InfluenceId")]
		public Guid InfluenceId { get; set; }
		[CProperty(ColumnPath ="IsMainContact")]
		public bool IsMainContact { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="JobTitle")]
		public string JobTitle { get; set; }
		[CProperty(ColumnPath ="LeadId")]
		public Guid LeadId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OpportunityId")]
		public Guid OpportunityId { get; set; }
		[CProperty(ColumnPath ="Pain")]
		public string Pain { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:GlbAccountId")]
		public Account GlbAccount { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Job:JobId")]
		public Job Job { get; set; }
		[CProperty(Navigation ="Lead:LeadId")]
		public Lead Lead { get; set; }
		[CProperty(Navigation ="OppContactInfluence:InfluenceId")]
		public OppContactInfluence Influence { get; set; }
		[CProperty(Navigation ="OppContactLoyality:ContactLoyalityId")]
		public OppContactLoyality ContactLoyality { get; set; }
		[CProperty(Navigation ="OppContactRole:RoleId")]
		public OppContactRole Role { get; set; }
		[CProperty(Navigation ="Opportunity:OpportunityId")]
		public Opportunity Opportunity { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="OppContactMotivator:OpportunityContactId")]
		public virtual ICollection<OppContactMotivator> OppContactMotivatorByOpportunityContact { get; set; }
		#endregion
	}
}
