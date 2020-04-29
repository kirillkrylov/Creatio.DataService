using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RequestExesByType")]
	public class RequestExesByType : BaseEntity
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
		private Guid _RequestExesId;
		[CProperty(ColumnPath ="RequestExesId")]
		public Guid RequestExesId
		{
			get{return _RequestExesId;}
			set
			{
				_RequestExesId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RequestExesTypeId;
		[CProperty(ColumnPath ="RequestExesTypeId")]
		public Guid RequestExesTypeId
		{
			get{return _RequestExesTypeId;}
			set
			{
				_RequestExesTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _RequestTypeId;
		[CProperty(ColumnPath ="RequestTypeId")]
		public Guid RequestTypeId
		{
			get{return _RequestTypeId;}
			set
			{
				_RequestTypeId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="RequestExes:RequestExesId")]
		public RequestExes RequestExes { get; set; }
		[CProperty(Navigation ="RequestExesType:RequestExesTypeId")]
		public RequestExesType RequestExesType { get; set; }
		[CProperty(Navigation ="RequestType:RequestTypeId")]
		public RequestType RequestType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="BudgetItem:ExpenseId")]
		public virtual ICollection<BudgetItem> BudgetItemByExpense { get; set; }
		[CProperty(Association ="RequestBudgetHolderByExesType:ExpenseItemId")]
		public virtual ICollection<RequestBudgetHolderByExesType> RequestBudgetHolderByExesTypeByExpenseItem { get; set; }
		#endregion
	}
}
