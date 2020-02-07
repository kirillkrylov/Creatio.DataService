using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Country")]
	public class Country : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BillingInfo")]
		public string BillingInfo { get; set; }
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="Image")]
		public byte[] Image { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="PhoneCode")]
		public string PhoneCode { get; set; }
		[CProperty(ColumnPath ="PhoneMask")]
		public string PhoneMask { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="TimeZoneId")]
		public Guid TimeZoneId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
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
		[CProperty(Association ="AccountOwnership:CountryId")]
		public virtual ICollection<AccountOwnership> AccountOwnershipByCountry { get; set; }
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
		[CProperty(Association ="DialingCode:CountryId")]
		public virtual ICollection<DialingCode> DialingCodeByCountry { get; set; }
		[CProperty(Association ="Lead:CountryId")]
		public virtual ICollection<Lead> LeadByCountry { get; set; }
		[CProperty(Association ="LeadAddress:CountryId")]
		public virtual ICollection<LeadAddress> LeadAddressByCountry { get; set; }
		[CProperty(Association ="LeadQualification:LeadContactCountryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadContactCountry { get; set; }
		[CProperty(Association ="LeadQualification:LeadAccountCountryId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadAccountCountry { get; set; }
		[CProperty(Association ="Region:CountryId")]
		public virtual ICollection<Region> RegionByCountry { get; set; }
		[CProperty(Association ="VwClientAddress:CountryId")]
		public virtual ICollection<VwClientAddress> VwClientAddressByCountry { get; set; }
		#endregion
	}
}
