using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountStageHistory")]
	public class AccountStageHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountCategoryId")]
		public Guid AccountCategoryId { get; set; }
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="AccountOwnerId")]
		public Guid AccountOwnerId { get; set; }
		[CProperty(ColumnPath ="AccountStatusId")]
		public Guid AccountStatusId { get; set; }
		[CProperty(ColumnPath ="AnnualRevenueBC")]
		public decimal AnnualRevenueBC { get; set; }
		[CProperty(ColumnPath ="AnnualRevenueId")]
		public Guid AnnualRevenueId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="DuplicateNameAndOwner")]
		public string DuplicateNameAndOwner { get; set; }
		[CProperty(ColumnPath ="EmployeesNumberId")]
		public Guid EmployeesNumberId { get; set; }
		[CProperty(ColumnPath ="ExactNoOfEmployees")]
		public int ExactNoOfEmployees { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="InternaRequestId")]
		public Guid InternaRequestId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProductPlatformId")]
		public Guid ProductPlatformId { get; set; }
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="Account:AccountOwnerId")]
		public Account AccountOwner { get; set; }
		[CProperty(Navigation ="AccountAnnualRevenue:AnnualRevenueId")]
		public AccountAnnualRevenue AnnualRevenue { get; set; }
		[CProperty(Navigation ="AccountCategory:SegmentId")]
		public AccountCategory Segment { get; set; }
		[CProperty(Navigation ="AccountEmployeesNumber:EmployeesNumberId")]
		public AccountEmployeesNumber EmployeesNumber { get; set; }
		[CProperty(Navigation ="AccountStatus:AccountStatusId")]
		public AccountStatus AccountStatus { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="InternalRequest:InternaRequestId")]
		public InternalRequest InternaRequest { get; set; }
		[CProperty(Navigation ="OpportunityCategory:AccountCategoryId")]
		public OpportunityCategory AccountCategory { get; set; }
		[CProperty(Navigation ="ProductPlatform:ProductPlatformId")]
		public ProductPlatform ProductPlatform { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountSegmentVerification:AccountHistoryId")]
		public virtual ICollection<AccountSegmentVerification> AccountSegmentVerificationByAccountHistory { get; set; }
		#endregion
	}
}
