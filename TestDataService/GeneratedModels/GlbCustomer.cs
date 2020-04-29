using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "GlbCustomer")]
	public class GlbCustomer : BaseEntity
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
		private decimal _GlbAnnualRevenueBC;
		[CProperty(ColumnPath ="GlbAnnualRevenueBC")]
		public decimal GlbAnnualRevenueBC
		{
			get{return _GlbAnnualRevenueBC;}
			set
			{
				_GlbAnnualRevenueBC = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbAnnualRevenueRangeId;
		[CProperty(ColumnPath ="GlbAnnualRevenueRangeId")]
		public Guid GlbAnnualRevenueRangeId
		{
			get{return _GlbAnnualRevenueRangeId;}
			set
			{
				_GlbAnnualRevenueRangeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbAssignedPartnerId;
		[CProperty(ColumnPath ="GlbAssignedPartnerId")]
		public Guid GlbAssignedPartnerId
		{
			get{return _GlbAssignedPartnerId;}
			set
			{
				_GlbAssignedPartnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbCountryId;
		[CProperty(ColumnPath ="GlbCountryId")]
		public Guid GlbCountryId
		{
			get{return _GlbCountryId;}
			set
			{
				_GlbCountryId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbCSEId;
		[CProperty(ColumnPath ="GlbCSEId")]
		public Guid GlbCSEId
		{
			get{return _GlbCSEId;}
			set
			{
				_GlbCSEId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbCSMId;
		[CProperty(ColumnPath ="GlbCSMId")]
		public Guid GlbCSMId
		{
			get{return _GlbCSMId;}
			set
			{
				_GlbCSMId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbCustomerAccountId;
		[CProperty(ColumnPath ="GlbCustomerAccountId")]
		public Guid GlbCustomerAccountId
		{
			get{return _GlbCustomerAccountId;}
			set
			{
				_GlbCustomerAccountId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbCustomerStatusId;
		[CProperty(ColumnPath ="GlbCustomerStatusId")]
		public Guid GlbCustomerStatusId
		{
			get{return _GlbCustomerStatusId;}
			set
			{
				_GlbCustomerStatusId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbDepartmentId;
		[CProperty(ColumnPath ="GlbDepartmentId")]
		public Guid GlbDepartmentId
		{
			get{return _GlbDepartmentId;}
			set
			{
				_GlbDepartmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbDeploymentTypeId;
		[CProperty(ColumnPath ="GlbDeploymentTypeId")]
		public Guid GlbDeploymentTypeId
		{
			get{return _GlbDeploymentTypeId;}
			set
			{
				_GlbDeploymentTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbEmployeesNumberRangeId;
		[CProperty(ColumnPath ="GlbEmployeesNumberRangeId")]
		public Guid GlbEmployeesNumberRangeId
		{
			get{return _GlbEmployeesNumberRangeId;}
			set
			{
				_GlbEmployeesNumberRangeId = value;
				OnPropertyChanged();
			}
		}
		private int _GlbExactNoOfEmployees;
		[CProperty(ColumnPath ="GlbExactNoOfEmployees")]
		public int GlbExactNoOfEmployees
		{
			get{return _GlbExactNoOfEmployees;}
			set
			{
				_GlbExactNoOfEmployees = value;
				OnPropertyChanged();
			}
		}
		private DateTime _GlbFirstActivationDate;
		[CProperty(ColumnPath ="GlbFirstActivationDate")]
		public DateTime GlbFirstActivationDate
		{
			get{return _GlbFirstActivationDate;}
			set
			{
				_GlbFirstActivationDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbFirstOpportunityId;
		[CProperty(ColumnPath ="GlbFirstOpportunityId")]
		public Guid GlbFirstOpportunityId
		{
			get{return _GlbFirstOpportunityId;}
			set
			{
				_GlbFirstOpportunityId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _GlbLastLoginDate;
		[CProperty(ColumnPath ="GlbLastLoginDate")]
		public DateTime GlbLastLoginDate
		{
			get{return _GlbLastLoginDate;}
			set
			{
				_GlbLastLoginDate = value;
				OnPropertyChanged();
			}
		}
		private string _GlbName;
		[CProperty(ColumnPath ="GlbName")]
		public string GlbName
		{
			get{return _GlbName;}
			set
			{
				_GlbName = value;
				OnPropertyChanged();
			}
		}
		private string _GlbNotes;
		[CProperty(ColumnPath ="GlbNotes")]
		public string GlbNotes
		{
			get{return _GlbNotes;}
			set
			{
				_GlbNotes = value;
				OnPropertyChanged();
			}
		}
		private string _GlbOpportunities;
		[CProperty(ColumnPath ="GlbOpportunities")]
		public string GlbOpportunities
		{
			get{return _GlbOpportunities;}
			set
			{
				_GlbOpportunities = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbProductPlatformId;
		[CProperty(ColumnPath ="GlbProductPlatformId")]
		public Guid GlbProductPlatformId
		{
			get{return _GlbProductPlatformId;}
			set
			{
				_GlbProductPlatformId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbProductPlatformT;
		[CProperty(ColumnPath ="GlbProductPlatformT")]
		public string GlbProductPlatformT
		{
			get{return _GlbProductPlatformT;}
			set
			{
				_GlbProductPlatformT = value;
				OnPropertyChanged();
			}
		}
		private DateTime _GlbRenewalDate;
		[CProperty(ColumnPath ="GlbRenewalDate")]
		public DateTime GlbRenewalDate
		{
			get{return _GlbRenewalDate;}
			set
			{
				_GlbRenewalDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbSalesExecutiveId;
		[CProperty(ColumnPath ="GlbSalesExecutiveId")]
		public Guid GlbSalesExecutiveId
		{
			get{return _GlbSalesExecutiveId;}
			set
			{
				_GlbSalesExecutiveId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbStageId;
		[CProperty(ColumnPath ="GlbStageId")]
		public Guid GlbStageId
		{
			get{return _GlbStageId;}
			set
			{
				_GlbStageId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbStrengths;
		[CProperty(ColumnPath ="GlbStrengths")]
		public string GlbStrengths
		{
			get{return _GlbStrengths;}
			set
			{
				_GlbStrengths = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbSystemUsageId;
		[CProperty(ColumnPath ="GlbSystemUsageId")]
		public Guid GlbSystemUsageId
		{
			get{return _GlbSystemUsageId;}
			set
			{
				_GlbSystemUsageId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GlbTerritoryId;
		[CProperty(ColumnPath ="GlbTerritoryId")]
		public Guid GlbTerritoryId
		{
			get{return _GlbTerritoryId;}
			set
			{
				_GlbTerritoryId = value;
				OnPropertyChanged();
			}
		}
		private string _GlbThreats;
		[CProperty(ColumnPath ="GlbThreats")]
		public string GlbThreats
		{
			get{return _GlbThreats;}
			set
			{
				_GlbThreats = value;
				OnPropertyChanged();
			}
		}
		private string _GlbWeaknesses;
		[CProperty(ColumnPath ="GlbWeaknesses")]
		public string GlbWeaknesses
		{
			get{return _GlbWeaknesses;}
			set
			{
				_GlbWeaknesses = value;
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
