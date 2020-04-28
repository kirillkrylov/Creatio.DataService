using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "PartnerProjectRole")]
	public class PartnerProjectRole : BaseEntity
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
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive { get; set; }
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="SysLookupId")]
		public Guid SysLookupId { get; set; }
		[CProperty(ColumnPath ="SysPageSchemaUId")]
		public Guid SysPageSchemaUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysLookup:SysLookupId")]
		public SysLookup SysLookup { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:PartnerRoleId")]
		public virtual ICollection<Account> AccountByPartnerRole { get; set; }
		[CProperty(Association ="BonusScheme:PartnerProjectRoleId")]
		public virtual ICollection<BonusScheme> BonusSchemeByPartnerProjectRole { get; set; }
		[CProperty(Association ="InternalRequest:OpportunityPartnerRoleId")]
		public virtual ICollection<InternalRequest> InternalRequestByOpportunityPartnerRole { get; set; }
		[CProperty(Association ="OppForecastWizPartners:PartnerRoleId")]
		public virtual ICollection<OppForecastWizPartners> OppForecastWizPartnersByPartnerRole { get; set; }
		[CProperty(Association ="Opportunity:PartnerProjectRoleId")]
		public virtual ICollection<Opportunity> OpportunityByPartnerProjectRole { get; set; }
		[CProperty(Association ="OpportunityPartner:PartnerProjectRoleId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByPartnerProjectRole { get; set; }
		[CProperty(Association ="OpportunityPartnerHistory:PartnerProjectRoleId")]
		public virtual ICollection<OpportunityPartnerHistory> OpportunityPartnerHistoryByPartnerProjectRole { get; set; }
		#endregion
	}
}
