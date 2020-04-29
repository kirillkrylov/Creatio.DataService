using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysLookup")]
	public class SysLookup : BaseEntity
	{
		#region Values
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
		private bool _IsSimple;
		[CProperty(ColumnPath ="IsSimple")]
		public bool IsSimple
		{
			get{return _IsSimple;}
			set
			{
				_IsSimple = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSystem;
		[CProperty(ColumnPath ="IsSystem")]
		public bool IsSystem
		{
			get{return _IsSystem;}
			set
			{
				_IsSystem = value;
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
		private string _NameEN;
		[CProperty(ColumnPath ="NameEN")]
		public string NameEN
		{
			get{return _NameEN;}
			set
			{
				_NameEN = value;
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
		private Guid _SysEditPageSchemaUId;
		[CProperty(ColumnPath ="SysEditPageSchemaUId")]
		public Guid SysEditPageSchemaUId
		{
			get{return _SysEditPageSchemaUId;}
			set
			{
				_SysEditPageSchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysEntitySchemaUId;
		[CProperty(ColumnPath ="SysEntitySchemaUId")]
		public Guid SysEntitySchemaUId
		{
			get{return _SysEntitySchemaUId;}
			set
			{
				_SysEntitySchemaUId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysFolderId;
		[CProperty(ColumnPath ="SysFolderId")]
		public Guid SysFolderId
		{
			get{return _SysFolderId;}
			set
			{
				_SysFolderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysGridPageSchemaUId;
		[CProperty(ColumnPath ="SysGridPageSchemaUId")]
		public Guid SysGridPageSchemaUId
		{
			get{return _SysGridPageSchemaUId;}
			set
			{
				_SysGridPageSchemaUId = value;
				OnPropertyChanged();
			}
		}
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
		[CProperty(Association ="ContentBuilderCustomerFont:SysLookupId")]
		public virtual ICollection<ContentBuilderCustomerFont> ContentBuilderCustomerFontBySysLookup { get; set; }
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
