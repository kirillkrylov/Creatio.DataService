using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwAdministrativeObjects")]
	public class VwAdministrativeObjects : BaseEntity
	{
		#region Values
		private bool _AdministratedByColumns;
		[CProperty(ColumnPath ="AdministratedByColumns")]
		public bool AdministratedByColumns
		{
			get{return _AdministratedByColumns;}
			set
			{
				_AdministratedByColumns = value;
				OnPropertyChanged();
			}
		}
		private bool _AdministratedByOperations;
		[CProperty(ColumnPath ="AdministratedByOperations")]
		public bool AdministratedByOperations
		{
			get{return _AdministratedByOperations;}
			set
			{
				_AdministratedByOperations = value;
				OnPropertyChanged();
			}
		}
		private bool _AdministratedByRecords;
		[CProperty(ColumnPath ="AdministratedByRecords")]
		public bool AdministratedByRecords
		{
			get{return _AdministratedByRecords;}
			set
			{
				_AdministratedByRecords = value;
				OnPropertyChanged();
			}
		}
		private string _Caption;
		[CProperty(ColumnPath ="Caption")]
		public string Caption
		{
			get{return _Caption;}
			set
			{
				_Caption = value;
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
		private bool _IsInSSPEntitySchemaAccessList;
		[CProperty(ColumnPath ="IsInSSPEntitySchemaAccessList")]
		public bool IsInSSPEntitySchemaAccessList
		{
			get{return _IsInSSPEntitySchemaAccessList;}
			set
			{
				_IsInSSPEntitySchemaAccessList = value;
				OnPropertyChanged();
			}
		}
		private bool _IsLookup;
		[CProperty(ColumnPath ="IsLookup")]
		public bool IsLookup
		{
			get{return _IsLookup;}
			set
			{
				_IsLookup = value;
				OnPropertyChanged();
			}
		}
		private bool _IsModule;
		[CProperty(ColumnPath ="IsModule")]
		public bool IsModule
		{
			get{return _IsModule;}
			set
			{
				_IsModule = value;
				OnPropertyChanged();
			}
		}
		private bool _IsTrackChangesInDB;
		[CProperty(ColumnPath ="IsTrackChangesInDB")]
		public bool IsTrackChangesInDB
		{
			get{return _IsTrackChangesInDB;}
			set
			{
				_IsTrackChangesInDB = value;
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
		private Guid _SysWorkspaceId;
		[CProperty(ColumnPath ="SysWorkspaceId")]
		public Guid SysWorkspaceId
		{
			get{return _SysWorkspaceId;}
			set
			{
				_SysWorkspaceId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
