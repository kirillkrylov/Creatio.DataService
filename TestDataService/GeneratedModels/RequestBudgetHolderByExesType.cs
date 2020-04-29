using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestBudgetHolderByExesType")]
	public class RequestBudgetHolderByExesType : BaseEntity
	{
		#region Values
		private Guid _BudgetHolderId;
		[CProperty(ColumnPath ="BudgetHolderId")]
		public Guid BudgetHolderId
		{
			get{return _BudgetHolderId;}
			set
			{
				_BudgetHolderId = value;
				OnPropertyChanged();
			}
		}
		private Guid _BudgetTerritoryId;
		[CProperty(ColumnPath ="BudgetTerritoryId")]
		public Guid BudgetTerritoryId
		{
			get{return _BudgetTerritoryId;}
			set
			{
				_BudgetTerritoryId = value;
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
		private Guid _ExpenseItemId;
		[CProperty(ColumnPath ="ExpenseItemId")]
		public Guid ExpenseItemId
		{
			get{return _ExpenseItemId;}
			set
			{
				_ExpenseItemId = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestExesByType:ExpenseItemId")]
		public RequestExesByType ExpenseItem { get; set; }
		[CProperty(Navigation ="SysAdminUnit:BudgetHolderId")]
		public SysAdminUnit BudgetHolder { get; set; }
		[CProperty(Navigation ="Territory:BudgetTerritoryId")]
		public Territory BudgetTerritory { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
