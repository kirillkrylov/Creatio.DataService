using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TableStatistics")]
	public class TableStatistics : BaseEntity
	{
		#region Values
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
		private int _CreatedRecords;
		[CProperty(ColumnPath ="CreatedRecords")]
		public int CreatedRecords
		{
			get{return _CreatedRecords;}
			set
			{
				_CreatedRecords = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CurrentDate;
		[CProperty(ColumnPath ="CurrentDate")]
		public DateTime CurrentDate
		{
			get{return _CurrentDate;}
			set
			{
				_CurrentDate = value;
				OnPropertyChanged();
			}
		}
		private string _DatabaseName;
		[CProperty(ColumnPath ="DatabaseName")]
		public string DatabaseName
		{
			get{return _DatabaseName;}
			set
			{
				_DatabaseName = value;
				OnPropertyChanged();
			}
		}
		private DateTime _EndDate;
		[CProperty(ColumnPath ="EndDate")]
		public DateTime EndDate
		{
			get{return _EndDate;}
			set
			{
				_EndDate = value;
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
		private int _ModifiedRecords;
		[CProperty(ColumnPath ="ModifiedRecords")]
		public int ModifiedRecords
		{
			get{return _ModifiedRecords;}
			set
			{
				_ModifiedRecords = value;
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
		private string _TableName;
		[CProperty(ColumnPath ="TableName")]
		public string TableName
		{
			get{return _TableName;}
			set
			{
				_TableName = value;
				OnPropertyChanged();
			}
		}
		private int _TotalRecords;
		[CProperty(ColumnPath ="TotalRecords")]
		public int TotalRecords
		{
			get{return _TotalRecords;}
			set
			{
				_TotalRecords = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
