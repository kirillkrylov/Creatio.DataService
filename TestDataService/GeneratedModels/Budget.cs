using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Budget")]
	public class Budget : BaseEntity
	{
		#region Values
		private decimal _ActualAmount;
		[CProperty(ColumnPath ="ActualAmount")]
		public decimal ActualAmount
		{
			get{return _ActualAmount;}
			set
			{
				_ActualAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _ApprovalAmount;
		[CProperty(ColumnPath ="ApprovalAmount")]
		public decimal ApprovalAmount
		{
			get{return _ApprovalAmount;}
			set
			{
				_ApprovalAmount = value;
				OnPropertyChanged();
			}
		}
		private decimal _Balance;
		[CProperty(ColumnPath ="Balance")]
		public decimal Balance
		{
			get{return _Balance;}
			set
			{
				_Balance = value;
				OnPropertyChanged();
			}
		}
		private Guid _CostCenterId;
		[CProperty(ColumnPath ="CostCenterId")]
		public Guid CostCenterId
		{
			get{return _CostCenterId;}
			set
			{
				_CostCenterId = value;
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
		private decimal _FullYearBalance;
		[CProperty(ColumnPath ="FullYearBalance")]
		public decimal FullYearBalance
		{
			get{return _FullYearBalance;}
			set
			{
				_FullYearBalance = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
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
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
				OnPropertyChanged();
			}
		}
		private decimal _PlannedAmount;
		[CProperty(ColumnPath ="PlannedAmount")]
		public decimal PlannedAmount
		{
			get{return _PlannedAmount;}
			set
			{
				_PlannedAmount = value;
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
		private decimal _YTDBalance;
		[CProperty(ColumnPath ="YTDBalance")]
		public decimal YTDBalance
		{
			get{return _YTDBalance;}
			set
			{
				_YTDBalance = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="CostCenter:CostCenterId")]
		public CostCenter CostCenter { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BudgetFile:BudgetId")]
		public virtual ICollection<BudgetFile> BudgetFileByBudget { get; set; }
		[CProperty(Association ="BudgetInFolder:BudgetId")]
		public virtual ICollection<BudgetInFolder> BudgetInFolderByBudget { get; set; }
		[CProperty(Association ="BudgetInTag:EntityId")]
		public virtual ICollection<BudgetInTag> BudgetInTagByEntity { get; set; }
		[CProperty(Association ="BudgetItem:BudgetId")]
		public virtual ICollection<BudgetItem> BudgetItemByBudget { get; set; }
		#endregion
	}
}
