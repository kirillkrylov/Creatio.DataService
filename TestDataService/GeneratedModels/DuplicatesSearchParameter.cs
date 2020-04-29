using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DuplicatesSearchParameter")]
	public class DuplicatesSearchParameter : BaseEntity
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
		private int _Days;
		[CProperty(ColumnPath ="Days")]
		public int Days
		{
			get{return _Days;}
			set
			{
				_Days = value;
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
		private bool _PerformSearchOnSave;
		[CProperty(ColumnPath ="PerformSearchOnSave")]
		public bool PerformSearchOnSave
		{
			get{return _PerformSearchOnSave;}
			set
			{
				_PerformSearchOnSave = value;
				OnPropertyChanged();
			}
		}
		private bool _PerformSheduledSearch;
		[CProperty(ColumnPath ="PerformSheduledSearch")]
		public bool PerformSheduledSearch
		{
			get{return _PerformSheduledSearch;}
			set
			{
				_PerformSheduledSearch = value;
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
		private Guid _SchemaToSearch;
		[CProperty(ColumnPath ="SchemaToSearch")]
		public Guid SchemaToSearch
		{
			get{return _SchemaToSearch;}
			set
			{
				_SchemaToSearch = value;
				OnPropertyChanged();
			}
		}
		private string _SchemaToSearchName;
		[CProperty(ColumnPath ="SchemaToSearchName")]
		public string SchemaToSearchName
		{
			get{return _SchemaToSearchName;}
			set
			{
				_SchemaToSearchName = value;
				OnPropertyChanged();
			}
		}
		private bool _SearchByAll;
		[CProperty(ColumnPath ="SearchByAll")]
		public bool SearchByAll
		{
			get{return _SearchByAll;}
			set
			{
				_SearchByAll = value;
				OnPropertyChanged();
			}
		}
		private bool _SearchByModifiedOnly;
		[CProperty(ColumnPath ="SearchByModifiedOnly")]
		public bool SearchByModifiedOnly
		{
			get{return _SearchByModifiedOnly;}
			set
			{
				_SearchByModifiedOnly = value;
				OnPropertyChanged();
			}
		}
		private DateTime _SearchTime;
		[CProperty(ColumnPath ="SearchTime")]
		public DateTime SearchTime
		{
			get{return _SearchTime;}
			set
			{
				_SearchTime = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
