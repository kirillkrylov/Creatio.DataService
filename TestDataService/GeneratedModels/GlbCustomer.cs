using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbCustomer")]
	public class GlbCustomer : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="GlbAnnualRevenueBC")]
		public decimal GlbAnnualRevenueBC { get; set; }
		[CProperty(ColumnPath ="GlbAnnualRevenueRangeId")]
		public Guid GlbAnnualRevenueRangeId { get; set; }
		[CProperty(ColumnPath ="GlbAssignedPartnerId")]
		public Guid GlbAssignedPartnerId { get; set; }
		[CProperty(ColumnPath ="GlbCountryId")]
		public Guid GlbCountryId { get; set; }
		[CProperty(ColumnPath ="GlbCSEId")]
		public Guid GlbCSEId { get; set; }
		[CProperty(ColumnPath ="GlbCSMId")]
		public Guid GlbCSMId { get; set; }
		[CProperty(ColumnPath ="GlbCustomerAccountId")]
		public Guid GlbCustomerAccountId { get; set; }
		[CProperty(ColumnPath ="GlbCustomerStatusId")]
		public Guid GlbCustomerStatusId { get; set; }
		[CProperty(ColumnPath ="GlbDepartmentId")]
		public Guid GlbDepartmentId { get; set; }
		[CProperty(ColumnPath ="GlbDeploymentTypeId")]
		public Guid GlbDeploymentTypeId { get; set; }
		[CProperty(ColumnPath ="GlbEmployeesNumberRangeId")]
		public Guid GlbEmployeesNumberRangeId { get; set; }
		[CProperty(ColumnPath ="GlbExactNoOfEmployees")]
		public int GlbExactNoOfEmployees { get; set; }
		[CProperty(ColumnPath ="GlbFirstActivationDate")]
		public DateTime GlbFirstActivationDate { get; set; }
		[CProperty(ColumnPath ="GlbFirstOpportunityId")]
		public Guid GlbFirstOpportunityId { get; set; }
		[CProperty(ColumnPath ="GlbLastLoginDate")]
		public DateTime GlbLastLoginDate { get; set; }
		[CProperty(ColumnPath ="GlbName")]
		public string GlbName { get; set; }
		[CProperty(ColumnPath ="GlbNotes")]
		public string GlbNotes { get; set; }
		[CProperty(ColumnPath ="GlbOpportunities")]
		public string GlbOpportunities { get; set; }
		[CProperty(ColumnPath ="GlbProductPlatformId")]
		public Guid GlbProductPlatformId { get; set; }
		[CProperty(ColumnPath ="GlbProductPlatformT")]
		public string GlbProductPlatformT { get; set; }
		[CProperty(ColumnPath ="GlbRenewalDate")]
		public DateTime GlbRenewalDate { get; set; }
		[CProperty(ColumnPath ="GlbSalesExecutiveId")]
		public Guid GlbSalesExecutiveId { get; set; }
		[CProperty(ColumnPath ="GlbStageId")]
		public Guid GlbStageId { get; set; }
		[CProperty(ColumnPath ="GlbStrengths")]
		public string GlbStrengths { get; set; }
		[CProperty(ColumnPath ="GlbSystemUsageId")]
		public Guid GlbSystemUsageId { get; set; }
		[CProperty(ColumnPath ="GlbTerritoryId")]
		public Guid GlbTerritoryId { get; set; }
		[CProperty(ColumnPath ="GlbThreats")]
		public string GlbThreats { get; set; }
		[CProperty(ColumnPath ="GlbWeaknesses")]
		public string GlbWeaknesses { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:GlbAssignedPartnerId")]
		public Account GlbAssignedPartner { get; set; }
		[CProperty(Navigation ="Account:GlbCustomerAccountId")]
		public Account GlbCustomerAccount { get; set; }
		[CProperty(Navigation ="AccountAnnualRevenue:GlbAnnualRevenueRangeId")]
		public AccountAnnualRevenue GlbAnnualRevenueRange { get; set; }
		[CProperty(Navigation ="AccountEmployeesNumber:GlbEmployeesNumberRangeId")]
		public AccountEmployeesNumber GlbEmployeesNumberRange { get; set; }
		[CProperty(Navigation ="AccountStatus:GlbCustomerStatusId")]
		public AccountStatus GlbCustomerStatus { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:GlbCSMId")]
		public Contact GlbCSM { get; set; }
		[CProperty(Navigation ="Contact:GlbSalesExecutiveId")]
		public Contact GlbSalesExecutive { get; set; }
		[CProperty(Navigation ="Contact:GlbCSEId")]
		public Contact GlbCSE { get; set; }
		[CProperty(Navigation ="Country:GlbCountryId")]
		public Country GlbCountry { get; set; }
		[CProperty(Navigation ="DeploymentType:GlbDeploymentTypeId")]
		public DeploymentType GlbDeploymentType { get; set; }
		[CProperty(Navigation ="GlbCustomerStage:GlbStageId")]
		public GlbCustomerStage GlbStage { get; set; }
		[CProperty(Navigation ="GlbCustomerSystemUsage:GlbSystemUsageId")]
		public GlbCustomerSystemUsage GlbSystemUsage { get; set; }
		[CProperty(Navigation ="Opportunity:GlbFirstOpportunityId")]
		public Opportunity GlbFirstOpportunity { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:GlbDepartmentId")]
		public OpportunityDepartment GlbDepartment { get; set; }
		[CProperty(Navigation ="OpportunityTerritory:GlbTerritoryId")]
		public OpportunityTerritory GlbTerritory { get; set; }
		[CProperty(Navigation ="ProductPlatform:GlbProductPlatformId")]
		public ProductPlatform GlbProductPlatform { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Account:GlbCustomerId")]
		public virtual ICollection<Account> AccountByGlbCustomer { get; set; }
		[CProperty(Association ="Activity:GlbGlbCustomerId")]
		public virtual ICollection<Activity> ActivityByGlbGlbCustomer { get; set; }
		[CProperty(Association ="Case:PDEReferenceProviderCustomerId")]
		public virtual ICollection<Case> CaseByPDEReferenceProviderCustomer { get; set; }
		[CProperty(Association ="GlbCustomerFile:GlbCustomerId")]
		public virtual ICollection<GlbCustomerFile> GlbCustomerFileByGlbCustomer { get; set; }
		[CProperty(Association ="GlbCustomerInFolder:GlbCustomerId")]
		public virtual ICollection<GlbCustomerInFolder> GlbCustomerInFolderByGlbCustomer { get; set; }
		[CProperty(Association ="GlbCustomerInTag:EntityId")]
		public virtual ICollection<GlbCustomerInTag> GlbCustomerInTagByEntity { get; set; }
		[CProperty(Association ="KnowledgeBase:PDECustomerId")]
		public virtual ICollection<KnowledgeBase> KnowledgeBaseByPDECustomer { get; set; }
		[CProperty(Association ="PDECustomerNeedInCustomer:PDECustomerId")]
		public virtual ICollection<PDECustomerNeedInCustomer> PDECustomerNeedInCustomerByPDECustomer { get; set; }
		[CProperty(Association ="PDESuitableCustomerInOpportunity:PDECustomerId")]
		public virtual ICollection<PDESuitableCustomerInOpportunity> PDESuitableCustomerInOpportunityByPDECustomer { get; set; }
		#endregion
	}
}
