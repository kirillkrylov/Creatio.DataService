using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLookup")]
	public class SysLookup : BaseEntity
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
		[CProperty(ColumnPath ="IsSimple")]
		public bool IsSimple { get; set; }
		[CProperty(ColumnPath ="IsSystem")]
		public bool IsSystem { get; set; }
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
		[CProperty(ColumnPath ="SysEditPageSchemaUId")]
		public Guid SysEditPageSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId { get; set; }
		[CProperty(ColumnPath ="SysFolderId")]
		public Guid SysFolderId { get; set; }
		[CProperty(ColumnPath ="SysGridPageSchemaUId")]
		public Guid SysGridPageSchemaUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysLookupFolder:SysFolderId")]
		public SysLookupFolder SysFolder { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BonusScheme:SysLookupId")]
		public virtual ICollection<BonusScheme> BonusSchemeBySysLookup { get; set; }
		[CProperty(Association ="CampaignLogItemType:SysLookupId")]
		public virtual ICollection<CampaignLogItemType> CampaignLogItemTypeBySysLookup { get; set; }
		[CProperty(Association ="ContentBuilderFontSet:SysLookupId")]
		public virtual ICollection<ContentBuilderFontSet> ContentBuilderFontSetBySysLookup { get; set; }
		[CProperty(Association ="DeduplicateOperation:SysLookupId")]
		public virtual ICollection<DeduplicateOperation> DeduplicateOperationBySysLookup { get; set; }
		[CProperty(Association ="Lookup:SysLookupId")]
		public virtual ICollection<Lookup> LookupBySysLookup { get; set; }
		[CProperty(Association ="MarketplaceDeveloperCategory:SysLookupId")]
		public virtual ICollection<MarketplaceDeveloperCategory> MarketplaceDeveloperCategoryBySysLookup { get; set; }
		[CProperty(Association ="MarketplaceProductCategory:SysLookupId")]
		public virtual ICollection<MarketplaceProductCategory> MarketplaceProductCategoryBySysLookup { get; set; }
		[CProperty(Association ="MarketplaceSite:SysLookupId")]
		public virtual ICollection<MarketplaceSite> MarketplaceSiteBySysLookup { get; set; }
		[CProperty(Association ="MkpFunctionalDomain:SysLookupId")]
		public virtual ICollection<MkpFunctionalDomain> MkpFunctionalDomainBySysLookup { get; set; }
		[CProperty(Association ="OrderPayer:SysLookupId")]
		public virtual ICollection<OrderPayer> OrderPayerBySysLookup { get; set; }
		[CProperty(Association ="PartnerProjectRole:SysLookupId")]
		public virtual ICollection<PartnerProjectRole> PartnerProjectRoleBySysLookup { get; set; }
		[CProperty(Association ="PartnerSegment:SysLookupId")]
		public virtual ICollection<PartnerSegment> PartnerSegmentBySysLookup { get; set; }
		[CProperty(Association ="RuleRelationSections:SysLookupId")]
		public virtual ICollection<RuleRelationSections> RuleRelationSectionsBySysLookup { get; set; }
		[CProperty(Association ="SysLookupColumn:SysLookupId")]
		public virtual ICollection<SysLookupColumn> SysLookupColumnBySysLookup { get; set; }
		[CProperty(Association ="SysLookupSearchColumn:SysLookupId")]
		public virtual ICollection<SysLookupSearchColumn> SysLookupSearchColumnBySysLookup { get; set; }
		[CProperty(Association ="VwSysLookupInFolder:VwSysLookupId")]
		public virtual ICollection<VwSysLookupInFolder> VwSysLookupInFolderByVwSysLookup { get; set; }
		#endregion
	}
}
