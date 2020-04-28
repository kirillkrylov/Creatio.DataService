using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Region")]
	public class Region : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CountryId")]
		public Guid CountryId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ISOCode")]
		public string ISOCode { get; set; }
		[CProperty(ColumnPath ="IsRestricted")]
		public bool IsRestricted { get; set; }
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
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId { get; set; }
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
