using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OpportunityTerritory")]
	public class OpportunityTerritory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CultureId")]
		public Guid CultureId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MinLicenseCount")]
		public int MinLicenseCount { get; set; }
		[CProperty(ColumnPath ="MinOrderAmount")]
		public decimal MinOrderAmount { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OrderCurrencyId")]
		public Guid OrderCurrencyId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Currency:OrderCurrencyId")]
		public Currency OrderCurrency { get; set; }
		[CProperty(Navigation ="SysCulture:CultureId")]
		public SysCulture Culture { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:TerritoryId")]
		public virtual ICollection<Account> AccountByTerritory { get; set; }
		[CProperty(Association ="BulkEmailCountLimit:TerritoryId")]
		public virtual ICollection<BulkEmailCountLimit> BulkEmailCountLimitByTerritory { get; set; }
		[CProperty(Association ="Case:TerritoryId")]
		public virtual ICollection<Case> CaseByTerritory { get; set; }
		[CProperty(Association ="Country:LanguageId")]
		public virtual ICollection<Country> CountryByLanguage { get; set; }
		[CProperty(Association ="DepartmentTypeTerritory:TerritoryId")]
		public virtual ICollection<DepartmentTypeTerritory> DepartmentTypeTerritoryByTerritory { get; set; }
		[CProperty(Association ="GlbCustomer:GlbTerritoryId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbTerritory { get; set; }
		[CProperty(Association ="KnowledgeBase:TerritoryId")]
		public virtual ICollection<KnowledgeBase> KnowledgeBaseByTerritory { get; set; }
		[CProperty(Association ="Lead:TerritoryId")]
		public virtual ICollection<Lead> LeadByTerritory { get; set; }
		[CProperty(Association ="LeadOwnerFillRule:TerritoryId")]
		public virtual ICollection<LeadOwnerFillRule> LeadOwnerFillRuleByTerritory { get; set; }
		[CProperty(Association ="MailboxForIncidentRegistration:TerritoryId")]
		public virtual ICollection<MailboxForIncidentRegistration> MailboxForIncidentRegistrationByTerritory { get; set; }
		[CProperty(Association ="Opportunity:TerritoryId")]
		public virtual ICollection<Opportunity> OpportunityByTerritory { get; set; }
		[CProperty(Association ="PortalUserRoleInRegion:RegionId")]
		public virtual ICollection<PortalUserRoleInRegion> PortalUserRoleInRegionByRegion { get; set; }
		[CProperty(Association ="Pricelist:TerritoryId")]
		public virtual ICollection<Pricelist> PricelistByTerritory { get; set; }
		[CProperty(Association ="SaaSMetrixType:TerritoryId")]
		public virtual ICollection<SaaSMetrixType> SaaSMetrixTypeByTerritory { get; set; }
		[CProperty(Association ="SalesProcessEvent:TerritoryId")]
		public virtual ICollection<SalesProcessEvent> SalesProcessEventByTerritory { get; set; }
		[CProperty(Association ="SupCloudCaseOwnerGroup:SupTerritoryId")]
		public virtual ICollection<SupCloudCaseOwnerGroup> SupCloudCaseOwnerGroupBySupTerritory { get; set; }
		[CProperty(Association ="TsSalesCareerMarket:TerritoryId")]
		public virtual ICollection<TsSalesCareerMarket> TsSalesCareerMarketByTerritory { get; set; }
		[CProperty(Association ="TsVersionSMJ:TerritoryId")]
		public virtual ICollection<TsVersionSMJ> TsVersionSMJByTerritory { get; set; }
		[CProperty(Association ="VwLead:TerritoryId")]
		public virtual ICollection<VwLead> VwLeadByTerritory { get; set; }
		[CProperty(Association ="VwSalesOperationalIndicatorsByGroupLeader:TerritoryId")]
		public virtual ICollection<VwSalesOperationalIndicatorsByGroupLeader> VwSalesOperationalIndicatorsByGroupLeaderByTerritory { get; set; }
		[CProperty(Association ="VwSalesOperationalIndicatorsByManager:TerritoryId")]
		public virtual ICollection<VwSalesOperationalIndicatorsByManager> VwSalesOperationalIndicatorsByManagerByTerritory { get; set; }
		[CProperty(Association ="VwSalesOperationalIndicatorsBySalesDirector:TerritoryId")]
		public virtual ICollection<VwSalesOperationalIndicatorsBySalesDirector> VwSalesOperationalIndicatorsBySalesDirectorByTerritory { get; set; }
		[CProperty(Association ="VwSalesOperationalIndicatorsBySalesMarket:TerritoryId")]
		public virtual ICollection<VwSalesOperationalIndicatorsBySalesMarket> VwSalesOperationalIndicatorsBySalesMarketByTerritory { get; set; }
		#endregion
	}
}
