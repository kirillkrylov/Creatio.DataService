using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "LeadQualification")]
	public class LeadQualification : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountBusinessPhone")]
		public string AccountBusinessPhone { get; set; }
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId { get; set; }
		[CProperty(ColumnPath ="AccountFax")]
		public string AccountFax { get; set; }
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="AccountWebsite")]
		public string AccountWebsite { get; set; }
		[CProperty(ColumnPath ="AnnualRevenueId")]
		public Guid AnnualRevenueId { get; set; }
		[CProperty(ColumnPath ="ContactBusinessPhone")]
		public string ContactBusinessPhone { get; set; }
		[CProperty(ColumnPath ="ContactEmail")]
		public string ContactEmail { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="ContactMobilePhone")]
		public string ContactMobilePhone { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Dear")]
		public string Dear { get; set; }
		[CProperty(ColumnPath ="DecisionRoleId")]
		public Guid DecisionRoleId { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="EmployeesNumberId")]
		public Guid EmployeesNumberId { get; set; }
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle { get; set; }
		[CProperty(ColumnPath ="GenderId")]
		public Guid GenderId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IndustryId")]
		public Guid IndustryId { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="LeadAccountAddress")]
		public string LeadAccountAddress { get; set; }
		[CProperty(ColumnPath ="LeadAccountAddressTypeId")]
		public Guid LeadAccountAddressTypeId { get; set; }
		[CProperty(ColumnPath ="LeadAccountCityId")]
		public Guid LeadAccountCityId { get; set; }
		[CProperty(ColumnPath ="LeadAccountCountryId")]
		public Guid LeadAccountCountryId { get; set; }
		[CProperty(ColumnPath ="LeadAccountName")]
		public string LeadAccountName { get; set; }
		[CProperty(ColumnPath ="LeadAccountRegionId")]
		public Guid LeadAccountRegionId { get; set; }
		[CProperty(ColumnPath ="LeadAccountZip")]
		public string LeadAccountZip { get; set; }
		[CProperty(ColumnPath ="LeadContactAddress")]
		public string LeadContactAddress { get; set; }
		[CProperty(ColumnPath ="LeadContactAddressTypeId")]
		public Guid LeadContactAddressTypeId { get; set; }
		[CProperty(ColumnPath ="LeadContactCityId")]
		public Guid LeadContactCityId { get; set; }
		[CProperty(ColumnPath ="LeadContactCountryId")]
		public Guid LeadContactCountryId { get; set; }
		[CProperty(ColumnPath ="LeadContactName")]
		public string LeadContactName { get; set; }
		[CProperty(ColumnPath ="LeadContactRegionId")]
		public Guid LeadContactRegionId { get; set; }
		[CProperty(ColumnPath ="LeadContactZip")]
		public string LeadContactZip { get; set; }
		[CProperty(ColumnPath ="LeadSourceId")]
		public Guid LeadSourceId { get; set; }
		[CProperty(ColumnPath ="LeadTypeId")]
		public Guid LeadTypeId { get; set; }
		[CProperty(ColumnPath ="LeadTypeRipenessId")]
		public Guid LeadTypeRipenessId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnershipId")]
		public Guid OwnershipId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SalutationId")]
		public Guid SalutationId { get; set; }
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
