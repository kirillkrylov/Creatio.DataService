using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadQualification")]
	public class LeadQualification : BaseEntity
	{
		#region Values
		private string _AccountBusinessPhone;
		[CProperty(ColumnPath ="AccountBusinessPhone")]
		public string AccountBusinessPhone
		{
			get{return _AccountBusinessPhone;}
			set
			{
				_AccountBusinessPhone = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountCategoryId;
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId
		{
			get{return _AccountCategoryId;}
			set
			{
				_AccountCategoryId = value;
				OnPropertyChanged();
			}
		}
		private string _AccountFax;
		[CProperty(ColumnPath ="AccountFax")]
		public string AccountFax
		{
			get{return _AccountFax;}
			set
			{
				_AccountFax = value;
				OnPropertyChanged();
			}
		}
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
		private string _AccountWebsite;
		[CProperty(ColumnPath ="AccountWebsite")]
		public string AccountWebsite
		{
			get{return _AccountWebsite;}
			set
			{
				_AccountWebsite = value;
				OnPropertyChanged();
			}
		}
		private Guid _AnnualRevenueId;
		[CProperty(ColumnPath ="AnnualRevenueId")]
		public Guid AnnualRevenueId
		{
			get{return _AnnualRevenueId;}
			set
			{
				_AnnualRevenueId = value;
				OnPropertyChanged();
			}
		}
		private string _ContactBusinessPhone;
		[CProperty(ColumnPath ="ContactBusinessPhone")]
		public string ContactBusinessPhone
		{
			get{return _ContactBusinessPhone;}
			set
			{
				_ContactBusinessPhone = value;
				OnPropertyChanged();
			}
		}
		private string _ContactEmail;
		[CProperty(ColumnPath ="ContactEmail")]
		public string ContactEmail
		{
			get{return _ContactEmail;}
			set
			{
				_ContactEmail = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private string _ContactMobilePhone;
		[CProperty(ColumnPath ="ContactMobilePhone")]
		public string ContactMobilePhone
		{
			get{return _ContactMobilePhone;}
			set
			{
				_ContactMobilePhone = value;
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
		private string _Dear;
		[CProperty(ColumnPath ="Dear")]
		public string Dear
		{
			get{return _Dear;}
			set
			{
				_Dear = value;
				OnPropertyChanged();
			}
		}
		private Guid _DecisionRoleId;
		[CProperty(ColumnPath ="DecisionRoleId")]
		public Guid DecisionRoleId
		{
			get{return _DecisionRoleId;}
			set
			{
				_DecisionRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DepartmentId;
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId
		{
			get{return _DepartmentId;}
			set
			{
				_DepartmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeesNumberId;
		[CProperty(ColumnPath ="EmployeesNumberId")]
		public Guid EmployeesNumberId
		{
			get{return _EmployeesNumberId;}
			set
			{
				_EmployeesNumberId = value;
				OnPropertyChanged();
			}
		}
		private string _FullJobTitle;
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle
		{
			get{return _FullJobTitle;}
			set
			{
				_FullJobTitle = value;
				OnPropertyChanged();
			}
		}
		private Guid _GenderId;
		[CProperty(ColumnPath ="GenderId")]
		public Guid GenderId
		{
			get{return _GenderId;}
			set
			{
				_GenderId = value;
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
		private Guid _IndustryId;
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId
		{
			get{return _IndustryId;}
			set
			{
				_IndustryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _JobId;
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId
		{
			get{return _JobId;}
			set
			{
				_JobId = value;
				OnPropertyChanged();
			}
		}
		private string _LeadAccountAddress;
		[CProperty(ColumnPath ="LeadAccountAddress")]
		public string LeadAccountAddress
		{
			get{return _LeadAccountAddress;}
			set
			{
				_LeadAccountAddress = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadAccountAddressTypeId;
		[CProperty(ColumnPath ="LeadAccountAddressTypeId")]
		public Guid LeadAccountAddressTypeId
		{
			get{return _LeadAccountAddressTypeId;}
			set
			{
				_LeadAccountAddressTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadAccountCityId;
		[CProperty(ColumnPath ="LeadAccountCityId")]
		public Guid LeadAccountCityId
		{
			get{return _LeadAccountCityId;}
			set
			{
				_LeadAccountCityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadAccountCountryId;
		[CProperty(ColumnPath ="LeadAccountCountryId")]
		public Guid LeadAccountCountryId
		{
			get{return _LeadAccountCountryId;}
			set
			{
				_LeadAccountCountryId = value;
				OnPropertyChanged();
			}
		}
		private string _LeadAccountName;
		[CProperty(ColumnPath ="LeadAccountName")]
		public string LeadAccountName
		{
			get{return _LeadAccountName;}
			set
			{
				_LeadAccountName = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadAccountRegionId;
		[CProperty(ColumnPath ="LeadAccountRegionId")]
		public Guid LeadAccountRegionId
		{
			get{return _LeadAccountRegionId;}
			set
			{
				_LeadAccountRegionId = value;
				OnPropertyChanged();
			}
		}
		private string _LeadAccountZip;
		[CProperty(ColumnPath ="LeadAccountZip")]
		public string LeadAccountZip
		{
			get{return _LeadAccountZip;}
			set
			{
				_LeadAccountZip = value;
				OnPropertyChanged();
			}
		}
		private string _LeadContactAddress;
		[CProperty(ColumnPath ="LeadContactAddress")]
		public string LeadContactAddress
		{
			get{return _LeadContactAddress;}
			set
			{
				_LeadContactAddress = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadContactAddressTypeId;
		[CProperty(ColumnPath ="LeadContactAddressTypeId")]
		public Guid LeadContactAddressTypeId
		{
			get{return _LeadContactAddressTypeId;}
			set
			{
				_LeadContactAddressTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadContactCityId;
		[CProperty(ColumnPath ="LeadContactCityId")]
		public Guid LeadContactCityId
		{
			get{return _LeadContactCityId;}
			set
			{
				_LeadContactCityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadContactCountryId;
		[CProperty(ColumnPath ="LeadContactCountryId")]
		public Guid LeadContactCountryId
		{
			get{return _LeadContactCountryId;}
			set
			{
				_LeadContactCountryId = value;
				OnPropertyChanged();
			}
		}
		private string _LeadContactName;
		[CProperty(ColumnPath ="LeadContactName")]
		public string LeadContactName
		{
			get{return _LeadContactName;}
			set
			{
				_LeadContactName = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadContactRegionId;
		[CProperty(ColumnPath ="LeadContactRegionId")]
		public Guid LeadContactRegionId
		{
			get{return _LeadContactRegionId;}
			set
			{
				_LeadContactRegionId = value;
				OnPropertyChanged();
			}
		}
		private string _LeadContactZip;
		[CProperty(ColumnPath ="LeadContactZip")]
		public string LeadContactZip
		{
			get{return _LeadContactZip;}
			set
			{
				_LeadContactZip = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadSourceId;
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId
		{
			get{return _LeadSourceId;}
			set
			{
				_LeadSourceId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeId;
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId
		{
			get{return _LeadTypeId;}
			set
			{
				_LeadTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _LeadTypeRipenessId;
		[CProperty(ColumnPath ="LeadTypeRipenessId")]
		public Guid LeadTypeRipenessId
		{
			get{return _LeadTypeRipenessId;}
			set
			{
				_LeadTypeRipenessId = value;
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
		private Guid _OwnershipId;
		[CProperty(ColumnPath ="OwnershipId")]
		public Guid OwnershipId
		{
			get{return _OwnershipId;}
			set
			{
				_OwnershipId = value;
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
		private Guid _SalutationId;
		[CProperty(ColumnPath ="SalutationId")]
		public Guid SalutationId
		{
			get{return _SalutationId;}
			set
			{
				_SalutationId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AccountAnnualRevenue:AnnualRevenueId")]
		public AccountAnnualRevenue AnnualRevenue { get; set; }
		[CProperty(Navigation ="AccountCategory:AccountCategoryId")]
		public AccountCategory AccountCategory { get; set; }
		[CProperty(Navigation ="AccountEmployeesNumber:EmployeesNumberId")]
		public AccountEmployeesNumber EmployeesNumber { get; set; }
		[CProperty(Navigation ="AccountIndustry:IndustryId")]
		public AccountIndustry Industry { get; set; }
		[CProperty(Navigation ="AccountOwnership:OwnershipId")]
		public AccountOwnership Ownership { get; set; }
		[CProperty(Navigation ="AddressType:LeadContactAddressTypeId")]
		public AddressType LeadContactAddressType { get; set; }
		[CProperty(Navigation ="AddressType:LeadAccountAddressTypeId")]
		public AddressType LeadAccountAddressType { get; set; }
		[CProperty(Navigation ="City:LeadContactCityId")]
		public City LeadContactCity { get; set; }
		[CProperty(Navigation ="City:LeadAccountCityId")]
		public City LeadAccountCity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="ContactDecisionRole:DecisionRoleId")]
		public ContactDecisionRole DecisionRole { get; set; }
		[CProperty(Navigation ="ContactSalutationType:SalutationId")]
		public ContactSalutationType Salutation { get; set; }
		[CProperty(Navigation ="Country:LeadContactCountryId")]
		public Country LeadContactCountry { get; set; }
		[CProperty(Navigation ="Country:LeadAccountCountryId")]
		public Country LeadAccountCountry { get; set; }
		[CProperty(Navigation ="Department:DepartmentId")]
		public Department Department { get; set; }
		[CProperty(Navigation ="Gender:GenderId")]
		public Gender Gender { get; set; }
		[CProperty(Navigation ="InformationSource:LeadSourceId")]
		public InformationSource LeadSource { get; set; }
		[CProperty(Navigation ="Job:JobId")]
		public Job Job { get; set; }
		[CProperty(Navigation ="LeadType:LeadTypeId")]
		public LeadType LeadType { get; set; }
		[CProperty(Navigation ="LeadTypeStatus:LeadTypeRipenessId")]
		public LeadTypeStatus LeadTypeRipeness { get; set; }
		[CProperty(Navigation ="Region:LeadContactRegionId")]
		public Region LeadContactRegion { get; set; }
		[CProperty(Navigation ="Region:LeadAccountRegionId")]
		public Region LeadAccountRegion { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
