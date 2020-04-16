using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MarketplaceApplication")]
	public class MarketplaceApplication : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CertificationComDate")]
		public DateTime CertificationComDate { get; set; }
		[CProperty(ColumnPath ="CertificationRuDate")]
		public DateTime CertificationRuDate { get; set; }
		[CProperty(ColumnPath ="CertificationStatusComId")]
		public Guid CertificationStatusComId { get; set; }
		[CProperty(ColumnPath ="CertificationStatusRuId")]
		public Guid CertificationStatusRuId { get; set; }
		[CProperty(ColumnPath ="Comment")]
		public string Comment { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DeveloperCategoryId")]
		public Guid DeveloperCategoryId { get; set; }
		[CProperty(ColumnPath ="DeveloperId")]
		public Guid DeveloperId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="MarketplaceSiteId")]
		public Guid MarketplaceSiteId { get; set; }
		[CProperty(ColumnPath ="MarketplaceUrl")]
		public string MarketplaceUrl { get; set; }
		[CProperty(ColumnPath ="MarketplaceUrlCom")]
		public string MarketplaceUrlCom { get; set; }
		[CProperty(ColumnPath ="MarketplaceUrlUa")]
		public string MarketplaceUrlUa { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductCategoryId")]
		public Guid ProductCategoryId { get; set; }
		[CProperty(ColumnPath ="PublicationDate")]
		public DateTime PublicationDate { get; set; }
		[CProperty(ColumnPath ="PublicationStatusComId")]
		public Guid PublicationStatusComId { get; set; }
		[CProperty(ColumnPath ="PublicationStatusId")]
		public Guid PublicationStatusId { get; set; }
		[CProperty(ColumnPath ="PublicationStatusRuId")]
		public Guid PublicationStatusRuId { get; set; }
		[CProperty(ColumnPath ="PublicationStatusUaId")]
		public Guid PublicationStatusUaId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:DeveloperId")]
		public Contact Developer { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="MarkCertificationStatus:CertificationStatusComId")]
		public MarkCertificationStatus CertificationStatusCom { get; set; }
		[CProperty(Navigation ="MarkCertificationStatus:CertificationStatusRuId")]
		public MarkCertificationStatus CertificationStatusRu { get; set; }
		[CProperty(Navigation ="MarketplaceDeveloperCategory:DeveloperCategoryId")]
		public MarketplaceDeveloperCategory DeveloperCategory { get; set; }
		[CProperty(Navigation ="MarketplaceProductCategory:ProductCategoryId")]
		public MarketplaceProductCategory ProductCategory { get; set; }
		[CProperty(Navigation ="MarketplaceSite:MarketplaceSiteId")]
		public MarketplaceSite MarketplaceSite { get; set; }
		[CProperty(Navigation ="PublicationStatus:PublicationStatusId")]
		public PublicationStatus PublicationStatus { get; set; }
		[CProperty(Navigation ="PublicationStatus:PublicationStatusRuId")]
		public PublicationStatus PublicationStatusRu { get; set; }
		[CProperty(Navigation ="PublicationStatus:PublicationStatusComId")]
		public PublicationStatus PublicationStatusCom { get; set; }
		[CProperty(Navigation ="PublicationStatus:PublicationStatusUaId")]
		public PublicationStatus PublicationStatusUa { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Activity:MarketplaceApplicationId")]
		public virtual ICollection<Activity> ActivityByMarketplaceApplication { get; set; }
		[CProperty(Association ="EmployeeScore:MarketplaceApplicationId")]
		public virtual ICollection<EmployeeScore> EmployeeScoreByMarketplaceApplication { get; set; }
		[CProperty(Association ="Lead:MarketplaceProductId")]
		public virtual ICollection<Lead> LeadByMarketplaceProduct { get; set; }
		[CProperty(Association ="MarketplaceApplicationFile:MarketplaceApplicationId")]
		public virtual ICollection<MarketplaceApplicationFile> MarketplaceApplicationFileByMarketplaceApplication { get; set; }
		[CProperty(Association ="MarketplaceApplicationInFolder:MarketplaceApplicationId")]
		public virtual ICollection<MarketplaceApplicationInFolder> MarketplaceApplicationInFolderByMarketplaceApplication { get; set; }
		[CProperty(Association ="MarketplaceApplicationInTag:EntityId")]
		public virtual ICollection<MarketplaceApplicationInTag> MarketplaceApplicationInTagByEntity { get; set; }
		[CProperty(Association ="VwLead:MarketplaceProductId")]
		public virtual ICollection<VwLead> VwLeadByMarketplaceProduct { get; set; }
		#endregion
	}
}
