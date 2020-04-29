using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountStageHistory")]
	public class AccountStageHistory : BaseEntity
	{
		#region Values
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
		private Guid _AccountOwnerId;
		[CProperty(ColumnPath ="AccountOwnerId")]
		public Guid AccountOwnerId
		{
			get{return _AccountOwnerId;}
			set
			{
				_AccountOwnerId = value;
				OnPropertyChanged();
			}
		}
		private Guid _AccountStatusId;
		[CProperty(ColumnPath ="AccountStatusId")]
		public Guid AccountStatusId
		{
			get{return _AccountStatusId;}
			set
			{
				_AccountStatusId = value;
				OnPropertyChanged();
			}
		}
		private decimal _AnnualRevenueBC;
		[CProperty(ColumnPath ="AnnualRevenueBC")]
		public decimal AnnualRevenueBC
		{
			get{return _AnnualRevenueBC;}
			set
			{
				_AnnualRevenueBC = value;
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
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
				OnPropertyChanged();
			}
		}
		private string _DuplicateNameAndOwner;
		[CProperty(ColumnPath ="DuplicateNameAndOwner")]
		public string DuplicateNameAndOwner
		{
			get{return _DuplicateNameAndOwner;}
			set
			{
				_DuplicateNameAndOwner = value;
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
		private int _ExactNoOfEmployees;
		[CProperty(ColumnPath ="ExactNoOfEmployees")]
		public int ExactNoOfEmployees
		{
			get{return _ExactNoOfEmployees;}
			set
			{
				_ExactNoOfEmployees = value;
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
		private Guid _InternaRequestId;
		[CProperty(ColumnPath ="InternaRequestId")]
		public Guid InternaRequestId
		{
			get{return _InternaRequestId;}
			set
			{
				_InternaRequestId = value;
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
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
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
		private Guid _ProductPlatformId;
		[CProperty(ColumnPath ="ProductPlatformId")]
		public Guid ProductPlatformId
		{
			get{return _ProductPlatformId;}
			set
			{
				_ProductPlatformId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentId;
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId
		{
			get{return _SegmentId;}
			set
			{
				_SegmentId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
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
