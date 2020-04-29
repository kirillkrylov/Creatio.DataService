using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Product")]
	public class Product : BaseEntity
	{
		#region Values
		private bool _Active;
		[CProperty(ColumnPath ="Active")]
		public bool Active
		{
			get{return _Active;}
			set
			{
				_Active = value;
				OnPropertyChanged();
			}
		}
		private Guid _BonusCategoryId;
		[CProperty(ColumnPath ="BonusCategoryId")]
		public Guid BonusCategoryId
		{
			get{return _BonusCategoryId;}
			set
			{
				_BonusCategoryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BPMProductId;
		[CProperty(ColumnPath ="BPMProductId")]
		public Guid BPMProductId
		{
			get{return _BPMProductId;}
			set
			{
				_BPMProductId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CategoryId;
		[CProperty(ColumnPath ="CategoryId")]
		public Guid CategoryId
		{
			get{return _CategoryId;}
			set
			{
				_CategoryId = value;
				OnPropertyChanged();
			}
		}
		private string _Code;
		[CProperty(ColumnPath ="Code")]
		public string Code
		{
			get{return _Code;}
			set
			{
				_Code = value;
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
		private Guid _CurrencyId;
		[CProperty(ColumnPath ="CurrencyId")]
		public Guid CurrencyId
		{
			get{return _CurrencyId;}
			set
			{
				_CurrencyId = value;
				OnPropertyChanged();
			}
		}
		private bool _Custom;
		[CProperty(ColumnPath ="Custom")]
		public bool Custom
		{
			get{return _Custom;}
			set
			{
				_Custom = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeliveryTypeId;
		[CProperty(ColumnPath ="DeliveryTypeId")]
		public Guid DeliveryTypeId
		{
			get{return _DeliveryTypeId;}
			set
			{
				_DeliveryTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DeploymentTypeId;
		[CProperty(ColumnPath ="DeploymentTypeId")]
		public Guid DeploymentTypeId
		{
			get{return _DeploymentTypeId;}
			set
			{
				_DeploymentTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
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
		private DateTime _IntegratedOn;
		[CProperty(ColumnPath ="IntegratedOn")]
		public DateTime IntegratedOn
		{
			get{return _IntegratedOn;}
			set
			{
				_IntegratedOn = value;
				OnPropertyChanged();
			}
		}
		private bool _IsArchive;
		[CProperty(ColumnPath ="IsArchive")]
		public bool IsArchive
		{
			get{return _IsArchive;}
			set
			{
				_IsArchive = value;
				OnPropertyChanged();
			}
		}
		private bool _IsTarget;
		[CProperty(ColumnPath ="IsTarget")]
		public bool IsTarget
		{
			get{return _IsTarget;}
			set
			{
				_IsTarget = value;
				OnPropertyChanged();
			}
		}
		private Guid _KindId;
		[CProperty(ColumnPath ="KindId")]
		public Guid KindId
		{
			get{return _KindId;}
			set
			{
				_KindId = value;
				OnPropertyChanged();
			}
		}
		private decimal _MinPrice;
		[CProperty(ColumnPath ="MinPrice")]
		public decimal MinPrice
		{
			get{return _MinPrice;}
			set
			{
				_MinPrice = value;
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
		private string _NameENU;
		[CProperty(ColumnPath ="NameENU")]
		public string NameENU
		{
			get{return _NameENU;}
			set
			{
				_NameENU = value;
				OnPropertyChanged();
			}
		}
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
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
		private Guid _PartnerId;
		[CProperty(ColumnPath ="PartnerId")]
		public Guid PartnerId
		{
			get{return _PartnerId;}
			set
			{
				_PartnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PartnerOwnerId;
		[CProperty(ColumnPath ="PartnerOwnerId")]
		public Guid PartnerOwnerId
		{
			get{return _PartnerOwnerId;}
			set
			{
				_PartnerOwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PaymentModelId;
		[CProperty(ColumnPath ="PaymentModelId")]
		public Guid PaymentModelId
		{
			get{return _PaymentModelId;}
			set
			{
				_PaymentModelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PictureId;
		[CProperty(ColumnPath ="PictureId")]
		public Guid PictureId
		{
			get{return _PictureId;}
			set
			{
				_PictureId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PlatformId;
		[CProperty(ColumnPath ="PlatformId")]
		public Guid PlatformId
		{
			get{return _PlatformId;}
			set
			{
				_PlatformId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PlatformVersionId;
		[CProperty(ColumnPath ="PlatformVersionId")]
		public Guid PlatformVersionId
		{
			get{return _PlatformVersionId;}
			set
			{
				_PlatformVersionId = value;
				OnPropertyChanged();
			}
		}
		private decimal _Price;
		[CProperty(ColumnPath ="Price")]
		public decimal Price
		{
			get{return _Price;}
			set
			{
				_Price = value;
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
		private Guid _ProductSourceId;
		[CProperty(ColumnPath ="ProductSourceId")]
		public Guid ProductSourceId
		{
			get{return _ProductSourceId;}
			set
			{
				_ProductSourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RevenueRecognitionMethodId;
		[CProperty(ColumnPath ="RevenueRecognitionMethodId")]
		public Guid RevenueRecognitionMethodId
		{
			get{return _RevenueRecognitionMethodId;}
			set
			{
				_RevenueRecognitionMethodId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SupportLevelId;
		[CProperty(ColumnPath ="SupportLevelId")]
		public Guid SupportLevelId
		{
			get{return _SupportLevelId;}
			set
			{
				_SupportLevelId = value;
				OnPropertyChanged();
			}
		}
		private string _TaxCode;
		[CProperty(ColumnPath ="TaxCode")]
		public string TaxCode
		{
			get{return _TaxCode;}
			set
			{
				_TaxCode = value;
				OnPropertyChanged();
			}
		}
		private Guid _TaxId;
		[CProperty(ColumnPath ="TaxId")]
		public Guid TaxId
		{
			get{return _TaxId;}
			set
			{
				_TaxId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TradeMarkId;
		[CProperty(ColumnPath ="TradeMarkId")]
		public Guid TradeMarkId
		{
			get{return _TradeMarkId;}
			set
			{
				_TradeMarkId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _Uid1C;
		[CProperty(ColumnPath ="Uid1C")]
		public Guid Uid1C
		{
			get{return _Uid1C;}
			set
			{
				_Uid1C = value;
				OnPropertyChanged();
			}
		}
		private Guid _UnitId;
		[CProperty(ColumnPath ="UnitId")]
		public Guid UnitId
		{
			get{return _UnitId;}
			set
			{
				_UnitId = value;
				OnPropertyChanged();
			}
		}
		private string _URL;
		[CProperty(ColumnPath ="URL")]
		public string URL
		{
			get{return _URL;}
			set
			{
				_URL = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:PartnerId")]
		public Account Partner { get; set; }
		[CProperty(Navigation ="BonusCategory:BonusCategoryId")]
		public BonusCategory BonusCategory { get; set; }
		[CProperty(Navigation ="BpmonlineVersion:PlatformVersionId")]
		public BpmonlineVersion PlatformVersion { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:PartnerOwnerId")]
		public Contact PartnerOwner { get; set; }
		[CProperty(Navigation ="Currency:CurrencyId")]
		public Currency Currency { get; set; }
		[CProperty(Navigation ="DeploymentType:DeploymentTypeId")]
		public DeploymentType DeploymentType { get; set; }
		[CProperty(Navigation ="PaymentModel:PaymentModelId")]
		public PaymentModel PaymentModel { get; set; }
		[CProperty(Navigation ="Product:BPMProductId")]
		public Product BPMProduct { get; set; }
		[CProperty(Navigation ="ProductCategory:CategoryId")]
		public ProductCategory Category { get; set; }
		[CProperty(Navigation ="ProductDeliveryType:DeliveryTypeId")]
		public ProductDeliveryType DeliveryType { get; set; }
		[CProperty(Navigation ="ProductKind:KindId")]
		public ProductKind Kind { get; set; }
		[CProperty(Navigation ="ProductPlatform:PlatformId")]
		public ProductPlatform Platform { get; set; }
		[CProperty(Navigation ="ProductSource:ProductSourceId")]
		public ProductSource ProductSource { get; set; }
		[CProperty(Navigation ="ProductType:TypeId")]
		public ProductType Type { get; set; }
		[CProperty(Navigation ="RevenueRecogMethod:RevenueRecognitionMethodId")]
		public RevenueRecogMethod RevenueRecognitionMethod { get; set; }
		[CProperty(Navigation ="SupportLevel:SupportLevelId")]
		public SupportLevel SupportLevel { get; set; }
		[CProperty(Navigation ="SysImage:PictureId")]
		public SysImage Picture { get; set; }
		[CProperty(Navigation ="Tax:TaxId")]
		public Tax Tax { get; set; }
		[CProperty(Navigation ="TradeMark:TradeMarkId")]
		public TradeMark TradeMark { get; set; }
		[CProperty(Navigation ="Unit:UnitId")]
		public Unit Unit { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AttributeInSiteEvent:ProductValueId")]
		public virtual ICollection<AttributeInSiteEvent> AttributeInSiteEventByProductValue { get; set; }
		[CProperty(Association ="ContactsProductInterest:ProductId")]
		public virtual ICollection<ContactsProductInterest> ContactsProductInterestByProduct { get; set; }
		[CProperty(Association ="DocumentProduct:ProductId")]
		public virtual ICollection<DocumentProduct> DocumentProductByProduct { get; set; }
		[CProperty(Association ="EventProduct:ProductId")]
		public virtual ICollection<EventProduct> EventProductByProduct { get; set; }
		[CProperty(Association ="InvoiceProduct:ProductId")]
		public virtual ICollection<InvoiceProduct> InvoiceProductByProduct { get; set; }
		[CProperty(Association ="LeadProduct:ProductId")]
		public virtual ICollection<LeadProduct> LeadProductByProduct { get; set; }
		[CProperty(Association ="OpportunityProductInterest:ProductId")]
		public virtual ICollection<OpportunityProductInterest> OpportunityProductInterestByProduct { get; set; }
		[CProperty(Association ="OrderProduct:ProductId")]
		public virtual ICollection<OrderProduct> OrderProductByProduct { get; set; }
		[CProperty(Association ="OrderProduct:SupportSoldForId")]
		public virtual ICollection<OrderProduct> OrderProductBySupportSoldFor { get; set; }
		[CProperty(Association ="PDEClientCaseMigration:PDEOurProductId")]
		public virtual ICollection<PDEClientCaseMigration> PDEClientCaseMigrationByPDEOurProduct { get; set; }
		[CProperty(Association ="Product:BPMProductId")]
		public virtual ICollection<Product> ProductByBPMProduct { get; set; }
		[CProperty(Association ="ProductBaseProduct:ProductId")]
		public virtual ICollection<ProductBaseProduct> ProductBaseProductByProduct { get; set; }
		[CProperty(Association ="ProductBaseProduct:BaseProductId")]
		public virtual ICollection<ProductBaseProduct> ProductBaseProductByBaseProduct { get; set; }
		[CProperty(Association ="ProductCompatibility:ProductId")]
		public virtual ICollection<ProductCompatibility> ProductCompatibilityByProduct { get; set; }
		[CProperty(Association ="ProductCompatibility:CompatibleProductId")]
		public virtual ICollection<ProductCompatibility> ProductCompatibilityByCompatibleProduct { get; set; }
		[CProperty(Association ="ProductEntry:ProductId")]
		public virtual ICollection<ProductEntry> ProductEntryByProduct { get; set; }
		[CProperty(Association ="ProductEntry:CrossSalesOferringId")]
		public virtual ICollection<ProductEntry> ProductEntryByCrossSalesOferring { get; set; }
		[CProperty(Association ="ProductFile:ProductId")]
		public virtual ICollection<ProductFile> ProductFileByProduct { get; set; }
		[CProperty(Association ="ProductForecast:ProductId")]
		public virtual ICollection<ProductForecast> ProductForecastByProduct { get; set; }
		[CProperty(Association ="ProductForLicGenerator:ProductId")]
		public virtual ICollection<ProductForLicGenerator> ProductForLicGeneratorByProduct { get; set; }
		[CProperty(Association ="ProductInFolder:ProductId")]
		public virtual ICollection<ProductInFolder> ProductInFolderByProduct { get; set; }
		[CProperty(Association ="ProductInLeadType:ProductId")]
		public virtual ICollection<ProductInLeadType> ProductInLeadTypeByProduct { get; set; }
		[CProperty(Association ="ProductInServicePact:ProductId")]
		public virtual ICollection<ProductInServicePact> ProductInServicePactByProduct { get; set; }
		[CProperty(Association ="ProductInSubscription:ProductId")]
		public virtual ICollection<ProductInSubscription> ProductInSubscriptionByProduct { get; set; }
		[CProperty(Association ="ProductInTag:EntityId")]
		public virtual ICollection<ProductInTag> ProductInTagByEntity { get; set; }
		[CProperty(Association ="ProductNamebyCountry:ProductId")]
		public virtual ICollection<ProductNamebyCountry> ProductNamebyCountryByProduct { get; set; }
		[CProperty(Association ="ProductPrice:ProductId")]
		public virtual ICollection<ProductPrice> ProductPriceByProduct { get; set; }
		[CProperty(Association ="ProductRequiredLicense:ProductId")]
		public virtual ICollection<ProductRequiredLicense> ProductRequiredLicenseByProduct { get; set; }
		[CProperty(Association ="ProductRequiredLicense:LicenseProductId")]
		public virtual ICollection<ProductRequiredLicense> ProductRequiredLicenseByLicenseProduct { get; set; }
		[CProperty(Association ="ProductStockBalance:ProductId")]
		public virtual ICollection<ProductStockBalance> ProductStockBalanceByProduct { get; set; }
		[CProperty(Association ="ProductUnit:ProductId")]
		public virtual ICollection<ProductUnit> ProductUnitByProduct { get; set; }
		[CProperty(Association ="ProjectProduct:ProductId")]
		public virtual ICollection<ProjectProduct> ProjectProductByProduct { get; set; }
		[CProperty(Association ="SaaSMetrix:ProductId")]
		public virtual ICollection<SaaSMetrix> SaaSMetrixByProduct { get; set; }
		[CProperty(Association ="SpecificationInProduct:ProductId")]
		public virtual ICollection<SpecificationInProduct> SpecificationInProductByProduct { get; set; }
		[CProperty(Association ="Transaction:ProductId")]
		public virtual ICollection<Transaction> TransactionByProduct { get; set; }
		[CProperty(Association ="TransactionForecast:ProductId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByProduct { get; set; }
		[CProperty(Association ="VwDocumentProduct:ProductId")]
		public virtual ICollection<VwDocumentProduct> VwDocumentProductByProduct { get; set; }
		[CProperty(Association ="VwInvoiceProduct:ProductId")]
		public virtual ICollection<VwInvoiceProduct> VwInvoiceProductByProduct { get; set; }
		[CProperty(Association ="VwOrderProduct:ProductId")]
		public virtual ICollection<VwOrderProduct> VwOrderProductByProduct { get; set; }
		[CProperty(Association ="VwPortalOrderExpenseProduct:SupportSoldForId")]
		public virtual ICollection<VwPortalOrderExpenseProduct> VwPortalOrderExpenseProductBySupportSoldFor { get; set; }
		[CProperty(Association ="VwPortalOrderExpenseProduct:ProductId")]
		public virtual ICollection<VwPortalOrderExpenseProduct> VwPortalOrderExpenseProductByProduct { get; set; }
		[CProperty(Association ="VwProductInLeadType:ProductId")]
		public virtual ICollection<VwProductInLeadType> VwProductInLeadTypeByProduct { get; set; }
		[CProperty(Association ="VwProductSLA:ProductId")]
		public virtual ICollection<VwProductSLA> VwProductSLAByProduct { get; set; }
		[CProperty(Association ="VwProjectProduct:ProductId")]
		public virtual ICollection<VwProjectProduct> VwProjectProductByProduct { get; set; }
		[CProperty(Association ="VwTransaction:ProductId")]
		public virtual ICollection<VwTransaction> VwTransactionByProduct { get; set; }
		[CProperty(Association ="VwTSSLA:ProductId")]
		public virtual ICollection<VwTSSLA> VwTSSLAByProduct { get; set; }
		[CProperty(Association ="VwTSSLAArchive:ProductId")]
		public virtual ICollection<VwTSSLAArchive> VwTSSLAArchiveByProduct { get; set; }
		#endregion
	}
}
