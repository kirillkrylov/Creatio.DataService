using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BonusScheme")]
	public class BonusScheme : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ArbitraryAmount")]
		public bool ArbitraryAmount { get; set; }
		[CProperty(ColumnPath ="Condition")]
		public decimal Condition { get; set; }
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
		[CProperty(ColumnPath ="PartnerProjectRoleId")]
		public Guid PartnerProjectRoleId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
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
		[CProperty(Navigation ="PartnerProjectRole:PartnerProjectRoleId")]
		public PartnerProjectRole PartnerProjectRole { get; set; }
		[CProperty(Navigation ="SysLookup:SysLookupId")]
		public SysLookup SysLookup { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Lead:BonusSchemeId")]
		public virtual ICollection<Lead> LeadByBonusScheme { get; set; }
		[CProperty(Association ="Opportunity:BonusSchemeId")]
		public virtual ICollection<Opportunity> OpportunityByBonusScheme { get; set; }
		[CProperty(Association ="OpportunityPartner:BonusSchemeId")]
		public virtual ICollection<OpportunityPartner> OpportunityPartnerByBonusScheme { get; set; }
		[CProperty(Association ="VwLead:BonusSchemeId")]
		public virtual ICollection<VwLead> VwLeadByBonusScheme { get; set; }
		#endregion
	}
}
