using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysProcessLog")]
	public class VwSysProcessLog : BaseEntity
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
		private DateTime _CompleteDate;
		[CProperty(ColumnPath ="CompleteDate")]
		public DateTime CompleteDate
		{
			get{return _CompleteDate;}
			set
			{
				_CompleteDate = value;
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
		private decimal _DurationInDays;
		[CProperty(ColumnPath ="DurationInDays")]
		public decimal DurationInDays
		{
			get{return _DurationInDays;}
			set
			{
				_DurationInDays = value;
				OnPropertyChanged();
			}
		}
		private decimal _DurationInHours;
		[CProperty(ColumnPath ="DurationInHours")]
		public decimal DurationInHours
		{
			get{return _DurationInHours;}
			set
			{
				_DurationInHours = value;
				OnPropertyChanged();
			}
		}
		private decimal _DurationInMilliseconds;
		[CProperty(ColumnPath ="DurationInMilliseconds")]
		public decimal DurationInMilliseconds
		{
			get{return _DurationInMilliseconds;}
			set
			{
				_DurationInMilliseconds = value;
				OnPropertyChanged();
			}
		}
		private decimal _DurationInMinutes;
		[CProperty(ColumnPath ="DurationInMinutes")]
		public decimal DurationInMinutes
		{
			get{return _DurationInMinutes;}
			set
			{
				_DurationInMinutes = value;
				OnPropertyChanged();
			}
		}
		private decimal _DurationInSeconds;
		[CProperty(ColumnPath ="DurationInSeconds")]
		public decimal DurationInSeconds
		{
			get{return _DurationInSeconds;}
			set
			{
				_DurationInSeconds = value;
				OnPropertyChanged();
			}
		}
		private string _ErrorDescription;
		[CProperty(ColumnPath ="ErrorDescription")]
		public string ErrorDescription
		{
			get{return _ErrorDescription;}
			set
			{
				_ErrorDescription = value;
				OnPropertyChanged();
			}
		}
		private bool _HasTraceData;
		[CProperty(ColumnPath ="HasTraceData")]
		public bool HasTraceData
		{
			get{return _HasTraceData;}
			set
			{
				_HasTraceData = value;
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
		private string _PackageName;
		[CProperty(ColumnPath ="PackageName")]
		public string PackageName
		{
			get{return _PackageName;}
			set
			{
				_PackageName = value;
				OnPropertyChanged();
			}
		}
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
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
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
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
		private int _Version;
		[CProperty(ColumnPath ="Version")]
		public int Version
		{
			get{return _Version;}
			set
			{
				_Version = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysProcessStatus:StatusId")]
		public SysProcessStatus Status { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		[CProperty(Navigation ="SysWorkspace:SysWorkspaceId")]
		public SysWorkspace SysWorkspace { get; set; }
		[CProperty(Navigation ="VwSysProcessLog:ParentId")]
		public VwSysProcessLog Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="VwSysProcessElementLog:SysProcessId")]
		public virtual ICollection<VwSysProcessElementLog> VwSysProcessElementLogBySysProcess { get; set; }
		[CProperty(Association ="VwSysProcessEntity:SysProcessId")]
		public virtual ICollection<VwSysProcessEntity> VwSysProcessEntityBySysProcess { get; set; }
		[CProperty(Association ="VwSysProcessLog:ParentId")]
		public virtual ICollection<VwSysProcessLog> VwSysProcessLogByParent { get; set; }
		#endregion
	}
}
