using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MarketplaceApplication")]
	public class MarketplaceApplication : BaseEntity
	{
		#region Values
		private Guid _AccountId;
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId
		{
			get{return _AccountId;}
			set
			{
				_AccountId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CertificationComDate;
		[CProperty(ColumnPath ="CertificationComDate")]
		public DateTime CertificationComDate
		{
			get{return _CertificationComDate;}
			set
			{
				_CertificationComDate = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CertificationRuDate;
		[CProperty(ColumnPath ="CertificationRuDate")]
		public DateTime CertificationRuDate
		{
			get{return _CertificationRuDate;}
			set
			{
				_CertificationRuDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _CertificationStatusComId;
		[CProperty(ColumnPath ="CertificationStatusComId")]
		public Guid CertificationStatusComId
		{
			get{return _CertificationStatusComId;}
			set
			{
				_CertificationStatusComId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CertificationStatusRuId;
		[CProperty(ColumnPath ="CertificationStatusRuId")]
		public Guid CertificationStatusRuId
		{
			get{return _CertificationStatusRuId;}
			set
			{
				_CertificationStatusRuId = value;
				OnPropertyChanged();
			}
		}
		private string _Comment;
		[CProperty(ColumnPath ="Comment")]
		public string Comment
		{
			get{return _Comment;}
			set
			{
				_Comment = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeveloperCategoryId;
		[CProperty(ColumnPath ="DeveloperCategoryId")]
		public Guid DeveloperCategoryId
		{
			get{return _DeveloperCategoryId;}
			set
			{
				_DeveloperCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeveloperId;
		[CProperty(ColumnPath ="DeveloperId")]
		public Guid DeveloperId
		{
			get{return _DeveloperId;}
			set
			{
				_DeveloperId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _MarketplaceSiteId;
		[CProperty(ColumnPath ="MarketplaceSiteId")]
		public Guid MarketplaceSiteId
		{
			get{return _MarketplaceSiteId;}
			set
			{
				_MarketplaceSiteId = value;
				OnPropertyChanged();
			}
		}
		private string _MarketplaceUrl;
		[CProperty(ColumnPath ="MarketplaceUrl")]
		public string MarketplaceUrl
		{
			get{return _MarketplaceUrl;}
			set
			{
				_MarketplaceUrl = value;
				OnPropertyChanged();
			}
		}
		private string _MarketplaceUrlCom;
		[CProperty(ColumnPath ="MarketplaceUrlCom")]
		public string MarketplaceUrlCom
		{
			get{return _MarketplaceUrlCom;}
			set
			{
				_MarketplaceUrlCom = value;
				OnPropertyChanged();
			}
		}
		private string _MarketplaceUrlUa;
		[CProperty(ColumnPath ="MarketplaceUrlUa")]
		public string MarketplaceUrlUa
		{
			get{return _MarketplaceUrlUa;}
			set
			{
				_MarketplaceUrlUa = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private Guid _ProductCategoryId;
		[CProperty(ColumnPath ="ProductCategoryId")]
		public Guid ProductCategoryId
		{
			get{return _ProductCategoryId;}
			set
			{
				_ProductCategoryId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PublicationDate;
		[CProperty(ColumnPath ="PublicationDate")]
		public DateTime PublicationDate
		{
			get{return _PublicationDate;}
			set
			{
				_PublicationDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _PublicationStatusComId;
		[CProperty(ColumnPath ="PublicationStatusComId")]
		public Guid PublicationStatusComId
		{
			get{return _PublicationStatusComId;}
			set
			{
				_PublicationStatusComId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PublicationStatusId;
		[CProperty(ColumnPath ="PublicationStatusId")]
		public Guid PublicationStatusId
		{
			get{return _PublicationStatusId;}
			set
			{
				_PublicationStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PublicationStatusRuId;
		[CProperty(ColumnPath ="PublicationStatusRuId")]
		public Guid PublicationStatusRuId
		{
			get{return _PublicationStatusRuId;}
			set
			{
				_PublicationStatusRuId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PublicationStatusUaId;
		[CProperty(ColumnPath ="PublicationStatusUaId")]
		public Guid PublicationStatusUaId
		{
			get{return _PublicationStatusUaId;}
			set
			{
				_PublicationStatusUaId = value;
				OnPropertyChanged();
			}
		}
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
