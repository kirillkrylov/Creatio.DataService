using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "City")]
	public class City : BaseEntity
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
		public Guid Id { get; set; }
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
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId { get; set; }
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
		[CProperty(Navigation ="Region:RegionId")]
		public Region Region { get; set; }
		[CProperty(Navigation ="TimeZone:TimeZoneId")]
		public TimeZone TimeZone { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:CityId")]
		public virtual ICollection<Account> AccountByCity { get; set; }
		[CProperty(Association ="AccountAddress:CityId")]
		public virtual ICollection<AccountAddress> AccountAddressByCity { get; set; }
		[CProperty(Association ="AccountBillingInfo:CityId")]
		public virtual ICollection<AccountBillingInfo> AccountBillingInfoByCity { get; set; }
		[CProperty(Association ="Bank:CityId")]
		public virtual ICollection<Bank> BankByCity { get; set; }
		[CProperty(Association ="ConfItem:CityId")]
		public virtual ICollection<ConfItem> ConfItemByCity { get; set; }
		[CProperty(Association ="ConfItemAddress:CityId")]
		public virtual ICollection<ConfItemAddress> ConfItemAddressByCity { get; set; }
		[CProperty(Association ="Contact:CityId")]
		public virtual ICollection<Contact> ContactByCity { get; set; }
		[CProperty(Association ="ContactAddress:CityId")]
		public virtual ICollection<ContactAddress> ContactAddressByCity { get; set; }
		[CProperty(Association ="CountryCodes:CityId")]
		public virtual ICollection<CountryCodes> CountryCodesByCity { get; set; }
		[CProperty(Association ="InternalRequest:CityId")]
		public virtual ICollection<InternalRequest> InternalRequestByCity { get; set; }
		[CProperty(Association ="Lead:CityId")]
		public virtual ICollection<Lead> LeadByCity { get; set; }
		[CProperty(Association ="LeadAddress:CityId")]
		public virtual ICollection<LeadAddress> LeadAddressByCity { get; set; }
		[CProperty(Association ="LeadQualification:LeadContactCityId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadContactCity { get; set; }
		[CProperty(Association ="LeadQualification:LeadAccountCityId")]
		public virtual ICollection<LeadQualification> LeadQualificationByLeadAccountCity { get; set; }
		[CProperty(Association ="Office:CityId")]
		public virtual ICollection<Office> OfficeByCity { get; set; }
		[CProperty(Association ="OrgStructureUnit:CityId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByCity { get; set; }
		[CProperty(Association ="ScreenResult:CityId")]
		public virtual ICollection<ScreenResult> ScreenResultByCity { get; set; }
		[CProperty(Association ="SysModuleFolder:ParentId")]
		public virtual ICollection<SysModuleFolder> SysModuleFolderByParent { get; set; }
		[CProperty(Association ="TsSalesCareer:CityId")]
		public virtual ICollection<TsSalesCareer> TsSalesCareerByCity { get; set; }
		[CProperty(Association ="VwClientAddress:CityId")]
		public virtual ICollection<VwClientAddress> VwClientAddressByCity { get; set; }
		[CProperty(Association ="VwEventInContact:CityId")]
		public virtual ICollection<VwEventInContact> VwEventInContactByCity { get; set; }
		[CProperty(Association ="VwLead:CityId")]
		public virtual ICollection<VwLead> VwLeadByCity { get; set; }
		[CProperty(Association ="VwTsSalesCareer:CityId")]
		public virtual ICollection<VwTsSalesCareer> VwTsSalesCareerByCity { get; set; }
		[CProperty(Association ="VwWorkTripInternalRequest:CityId")]
		public virtual ICollection<VwWorkTripInternalRequest> VwWorkTripInternalRequestByCity { get; set; }
		#endregion
	}
}
