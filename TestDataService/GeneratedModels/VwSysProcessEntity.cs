using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysProcessEntity")]
	public class VwSysProcessEntity : BaseEntity
	{
		#region Values
		private bool _Archived;
		[CProperty(ColumnPath ="Archived")]
		public bool Archived
		{
			get{return _Archived;}
			set
			{
				_Archived = value;
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
		private string _EntityDisplayValue;
		[CProperty(ColumnPath ="EntityDisplayValue")]
		public string EntityDisplayValue
		{
			get{return _EntityDisplayValue;}
			set
			{
				_EntityDisplayValue = value;
				OnPropertyChanged();
			}
		}
		private Guid _EntityId;
		[CProperty(ColumnPath ="EntityId")]
		public Guid EntityId
		{
			get{return _EntityId;}
			set
			{
				_EntityId = value;
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
		private string _ReferenceSchemaName;
		[CProperty(ColumnPath ="ReferenceSchemaName")]
		public string ReferenceSchemaName
		{
			get{return _ReferenceSchemaName;}
			set
			{
				_ReferenceSchemaName = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysProcessId;
		[CProperty(ColumnPath ="SysProcessId")]
		public Guid SysProcessId
		{
			get{return _SysProcessId;}
			set
			{
				_SysProcessId = value;
				OnPropertyChanged();
			}
		}
		private Guid _SysSchemaId;
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId
		{
			get{return _SysSchemaId;}
			set
			{
				_SysSchemaId = value;
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
		[CProperty(Navigation ="VwSysProcessLog:SysProcessId")]
		public VwSysProcessLog SysProcess { get; set; }
		[CProperty(Navigation ="VwSysSchemaInWorkspace:SysSchemaId")]
		public VwSysSchemaInWorkspace SysSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
