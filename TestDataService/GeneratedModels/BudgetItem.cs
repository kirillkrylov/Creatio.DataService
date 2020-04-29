using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "BudgetItem")]
	public class BudgetItem : BaseEntity
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
		private Guid _BudgetId;
		[CProperty(ColumnPath ="BudgetId")]
		public Guid BudgetId
		{
			get{return _BudgetId;}
			set
			{
				_BudgetId = value;
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
		private Guid _ExpenseId;
		[CProperty(ColumnPath ="ExpenseId")]
		public Guid ExpenseId
		{
			get{return _ExpenseId;}
			set
			{
				_ExpenseId = value;
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
		[CProperty(Navigation ="Budget:BudgetId")]
		public Budget Budget { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestExesByType:ExpenseId")]
		public RequestExesByType Expense { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
