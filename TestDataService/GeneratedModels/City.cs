using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "City")]
	public class City : BaseEntity
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
		private Guid _RegionId;
		[CProperty(ColumnPath ="RegionId")]
		public Guid RegionId
		{
			get{return _RegionId;}
			set
			{
				_RegionId = value;
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
