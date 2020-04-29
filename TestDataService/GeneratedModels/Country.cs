using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Country")]
	public class Country : BaseEntity
	{
		#region Values
		private string _BillingInfo;
		[CProperty(ColumnPath ="BillingInfo")]
		public string BillingInfo
		{
			get{return _BillingInfo;}
			set
			{
				_BillingInfo = value;
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
		private Guid _GlobalAreaId;
		[CProperty(ColumnPath ="GlobalAreaId")]
		public Guid GlobalAreaId
		{
			get{return _GlobalAreaId;}
			set
			{
				_GlobalAreaId = value;
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
		private byte[] _Image;
		[CProperty(ColumnPath ="Image")]
		public byte[] Image
		{
			get{return _Image;}
			set
			{
				_Image = value;
				OnPropertyChanged();
			}
		}
		private bool _IsEU;
		[CProperty(ColumnPath ="IsEU")]
		public bool IsEU
		{
			get{return _IsEU;}
			set
			{
				_IsEU = value;
				OnPropertyChanged();
			}
		}
		private bool _IsGDPR;
		[CProperty(ColumnPath ="IsGDPR")]
		public bool IsGDPR
		{
			get{return _IsGDPR;}
			set
			{
				_IsGDPR = value;
				OnPropertyChanged();
			}
		}
		private string _ISOCode;
		[CProperty(ColumnPath ="ISOCode")]
		public string ISOCode
		{
			get{return _ISOCode;}
			set
			{
				_ISOCode = value;
				OnPropertyChanged();
			}
		}
		private bool _IsRestricted;
		[CProperty(ColumnPath ="IsRestricted")]
		public bool IsRestricted
		{
			get{return _IsRestricted;}
			set
			{
				_IsRestricted = value;
				OnPropertyChanged();
			}
		}
		private Guid _LanguageId;
		[CProperty(ColumnPath ="LanguageId")]
		public Guid LanguageId
		{
			get{return _LanguageId;}
			set
			{
				_LanguageId = value;
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
		private Guid _TimeZoneId;
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId
		{
			get{return _TimeZoneId;}
			set
			{
				_TimeZoneId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="GlobalArea:GlobalAreaId")]
		public GlobalArea GlobalArea { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:LanguageId")]
		public OpportunityTerritory Language { get; set; }
		[CProperty(Navigation ="TimeZone:TimeZoneId")]
		public TimeZone TimeZone { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:CountryId")]
		public virtual ICollection<Account> AccountByCountry { get; set; }
		[CProperty(Association ="AccountAddress:CountryId")]
		public virtual ICollection<AccountAddress> AccountAddressByCountry { get; set; }
		[CProperty(Association ="AccountBillingInfo:CountryId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByCountry { get; set; }
		[CProperty(Association ="AccountDataSource:CountryId")]
		public virtual ICollection<AccountDataSource> AccountDataSourceByCountry { get; set; }
		[CProperty(Association ="AccountOwnership:CountryId")]
		public virtual ICollection<AccountOwnership> AccountOwnershipByCountry { get; set; }
		[CProperty(Association ="Bank:CountryId")]
		public virtual ICollection<Bank> BankByCountry { get; set; }
		[CProperty(Association ="City:CountryId")]
		public virtual ICollection<City> CityByCountry { get; set; }
		[CProperty(Association ="ConfItem:CountryId")]
		public virtual ICollection<ConfItem> ConfItemByCountry { get; set; }
		[CProperty(Association ="ConfItemAddress:CountryId")]
		public virtual ICollection<ConfItemAddress> ConfItemAddressByCountry { get; set; }
		[CProperty(Association ="Contact:CountryId")]
		public virtual ICollection<Contact> ContactByCountry { get; set; }
		[CProperty(Association ="ContactAddress:CountryId")]
		public virtual ICollection<ContactAddress> ContactAddressByCountry { get; set; }
		[CProperty(Association ="CountryCodes:CountryId")]
		public virtual ICollection<CountryCodes> CountryCodesByCountry { get; set; }
		[CProperty(Association ="DialingCode:CountryId")]
		public virtual ICollection<DialingCode> DialingCodeByCountry { get; set; }
		[CProperty(Association ="Employee:CitizenshipId")]
		public virtual ICollection<Employee> EmployeeByCitizenship { get; set; }
		[CProperty(Association ="GlbCustomer:GlbCountryId")]
		public virtual ICollection<GlbCustomer> GlbCustomerByGlbCountry { get; set; }
		[CProperty(Association ="InternalRequest:CountryId")]
		public virtual ICollection<InternalRequest> InternalRequestByCountry { get; set; }
		[CProperty(Association ="Lead:CountryId")]
		public virtual ICollection<Lead> LeadByCountry { get; set; }
		[CProperty(Association ="LeadAddress:CountryId")]
		public virtual ICollection<LeadAddress> LeadAddressByCountry { get; set; }
		[CProperty(Association ="LeadQualification:LeadContactCountryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadContactCountry { get; set; }
		[CProperty(Association ="LeadQualification:LeadAccountCountryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadAccountCountry { get; set; }
		[CProperty(Association ="PricelistByCountry:CountryId")]
		public virtual ICollection<PricelistByCountry> PricelistByCountryByCountry { get; set; }
		[CProperty(Association ="ProductNamebyCountry:CountryId")]
		public virtual ICollection<ProductNamebyCountry> ProductNamebyCountryByCountry { get; set; }
		[CProperty(Association ="Region:CountryId")]
		public virtual ICollection<Region> RegionByCountry { get; set; }
		[CProperty(Association ="RestrictedParties:CountryId")]
		public virtual ICollection<RestrictedParties> RestrictedPartiesByCountry { get; set; }
		[CProperty(Association ="ScreenResult:CountryId")]
		public virtual ICollection<ScreenResult> ScreenResultByCountry { get; set; }
		[CProperty(Association ="SupCommunityPostAddress:SupCountryId")]
		public virtual ICollection<SupCommunityPostAddress> SupCommunityPostAddressBySupCountry { get; set; }
		[CProperty(Association ="TaxByCountry:SupplierCountryId")]
		public virtual ICollection<TaxByCountry> TaxByCountryBySupplierCountry { get; set; }
		[CProperty(Association ="TaxByCountry:CustomerCountryId")]
		public virtual ICollection<TaxByCountry> TaxByCountryByCustomerCountry { get; set; }
		[CProperty(Association ="TripsDailyAllowance:DirectionId")]
		public virtual ICollection<TripsDailyAllowance> TripsDailyAllowanceByDirection { get; set; }
		[CProperty(Association ="VwClientAddress:CountryId")]
		public virtual ICollection<VwClientAddress> VwClientAddressByCountry { get; set; }
		[CProperty(Association ="VwEventInContact:CountryId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByCountry { get; set; }
		[CProperty(Association ="VwLead:CountryId")]
		public virtual ICollection<VwLead> VwLeadByCountry { get; set; }
		[CProperty(Association ="VwQueueItemDashboard:CountryId")]
		public virtual ICollection<VwQueueItemDashboard> VwQueueItemDashboardByCountry { get; set; }
		[CProperty(Association ="VwQueueItemDashboardC:CountryId")]
		public virtual ICollection<VwQueueItemDashboardC> VwQueueItemDashboardCByCountry { get; set; }
		[CProperty(Association ="VwWorkTripInternalRequest:CountryId")]
		public virtual ICollection<VwWorkTripInternalRequest> VwWorkTripInternalRequestByCountry { get; set; }
		#endregion
	}
}
