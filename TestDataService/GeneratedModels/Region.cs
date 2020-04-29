using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Region")]
	public class Region : BaseEntity
	{
		#region Values
		private Guid _CountryId;
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId
		{
			get{return _CountryId;}
			set
			{
				_CountryId = value;
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
		private bool _RecordInactive;
		[CProperty(ColumnPath ="RecordInactive")]
		public bool RecordInactive
		{
			get{return _RecordInactive;}
			set
			{
				_RecordInactive = value;
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
		[CProperty(Navigation ="Country:CountryId")]
		public Country Country { get; set; }
		[CProperty(Navigation ="TimeZone:TimeZoneId")]
		public TimeZone TimeZone { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:RegionId")]
		public virtual ICollection<Account> AccountByRegion { get; set; }
		[CProperty(Association ="AccountAddress:RegionId")]
		public virtual ICollection<AccountAddress> AccountAddressByRegion { get; set; }
		[CProperty(Association ="AccountBillingInfo:RegionId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByRegion { get; set; }
		[CProperty(Association ="City:RegionId")]
		public virtual ICollection<City> CityByRegion { get; set; }
		[CProperty(Association ="ConfItem:RegionId")]
		public virtual ICollection<ConfItem> ConfItemByRegion { get; set; }
		[CProperty(Association ="ConfItemAddress:RegionId")]
		public virtual ICollection<ConfItemAddress> ConfItemAddressByRegion { get; set; }
		[CProperty(Association ="Contact:RegionId")]
		public virtual ICollection<Contact> ContactByRegion { get; set; }
		[CProperty(Association ="ContactAddress:RegionId")]
		public virtual ICollection<ContactAddress> ContactAddressByRegion { get; set; }
		[CProperty(Association ="Lead:RegionId")]
		public virtual ICollection<Lead> LeadByRegion { get; set; }
		[CProperty(Association ="LeadAddress:RegionId")]
		public virtual ICollection<LeadAddress> LeadAddressByRegion { get; set; }
		[CProperty(Association ="LeadQualification:LeadContactRegionId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadContactRegion { get; set; }
		[CProperty(Association ="LeadQualification:LeadAccountRegionId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadAccountRegion { get; set; }
		[CProperty(Association ="ScreenResult:RegionId")]
		public virtual ICollection<ScreenResult> ScreenResultByRegion { get; set; }
		[CProperty(Association ="TaxByCountry:SupplierRegionId")]
		public virtual ICollection<TaxByCountry> TaxByCountryBySupplierRegion { get; set; }
		[CProperty(Association ="TaxByCountry:CustomerRegionId")]
		public virtual ICollection<TaxByCountry> TaxByCountryByCustomerRegion { get; set; }
		[CProperty(Association ="VwClientAddress:RegionId")]
		public virtual ICollection<VwClientAddress> VwClientAddressByRegion { get; set; }
		[CProperty(Association ="VwEventInContact:RegionId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByRegion { get; set; }
		[CProperty(Association ="VwLead:RegionId")]
		public virtual ICollection<VwLead> VwLeadByRegion { get; set; }
		#endregion
	}
}
