using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExternalAccess")]
	public class ExternalAccess : BaseEntity
	{
		#region Values
		private string _AccessReason;
		[CProperty(ColumnPath ="AccessReason")]
		public string AccessReason
		{
			get{return _AccessReason;}
			set
			{
				_AccessReason = value;
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
		private Guid _ExternalAccessClientId;
		[CProperty(ColumnPath ="ExternalAccessClientId")]
		public Guid ExternalAccessClientId
		{
			get{return _ExternalAccessClientId;}
			set
			{
				_ExternalAccessClientId = value;
				OnPropertyChanged();
			}
		}
		private Guid _GrantorId;
		[CProperty(ColumnPath ="GrantorId")]
		public Guid GrantorId
		{
			get{return _GrantorId;}
			set
			{
				_GrantorId = value;
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
		private bool _IsActive;
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive
		{
			get{return _IsActive;}
			set
			{
				_IsActive = value;
				OnPropertyChanged();
			}
		}
		private bool _IsDataIsolationEnabled;
		[CProperty(ColumnPath ="IsDataIsolationEnabled")]
		public bool IsDataIsolationEnabled
		{
			get{return _IsDataIsolationEnabled;}
			set
			{
				_IsDataIsolationEnabled = value;
				OnPropertyChanged();
			}
		}
		private bool _IsSystemOperationsRestricted;
		[CProperty(ColumnPath ="IsSystemOperationsRestricted")]
		public bool IsSystemOperationsRestricted
		{
			get{return _IsSystemOperationsRestricted;}
			set
			{
				_IsSystemOperationsRestricted = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:GrantorId")]
		public Contact Grantor { get; set; }
		[CProperty(Navigation ="ExternalAccessClient:ExternalAccessClientId")]
		public ExternalAccessClient ExternalAccessClient { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ExternalAccessFile:ExternalAccessId")]
		public virtual ICollection<ExternalAccessFile> ExternalAccessFileByExternalAccess { get; set; }
		[CProperty(Association ="ExternalAccessInFolder:ExternalAccessId")]
		public virtual ICollection<ExternalAccessInFolder> ExternalAccessInFolderByExternalAccess { get; set; }
		[CProperty(Association ="ExternalAccessInTag:EntityId")]
		public virtual ICollection<ExternalAccessInTag> ExternalAccessInTagByEntity { get; set; }
		[CProperty(Association ="SysIsolatedRecord:ExternalAccessId")]
		public virtual ICollection<SysIsolatedRecord> SysIsolatedRecordByExternalAccess { get; set; }
		[CProperty(Association ="SysUserSession:ExternalAccessId")]
		public virtual ICollection<SysUserSession> SysUserSessionByExternalAccess { get; set; }
		[CProperty(Association ="VwIsolatedRecord:ExternalAccessId")]
		public virtual ICollection<VwIsolatedRecord> VwIsolatedRecordByExternalAccess { get; set; }
		#endregion
	}
}
