using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysSyncMetaData")]
	public class SysSyncMetaData : BaseEntity
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
		private Guid _CreatedInStoreId;
		[CProperty(ColumnPath ="CreatedInStoreId")]
		public Guid CreatedInStoreId
		{
			get{return _CreatedInStoreId;}
			set
			{
				_CreatedInStoreId = value;
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
		private string _ExtraParameters;
		[CProperty(ColumnPath ="ExtraParameters")]
		public string ExtraParameters
		{
			get{return _ExtraParameters;}
			set
			{
				_ExtraParameters = value;
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
		private bool _IsLocalDeleted;
		[CProperty(ColumnPath ="IsLocalDeleted")]
		public bool IsLocalDeleted
		{
			get{return _IsLocalDeleted;}
			set
			{
				_IsLocalDeleted = value;
				OnPropertyChanged();
			}
		}
		private bool _IsRemoteDeleted;
		[CProperty(ColumnPath ="IsRemoteDeleted")]
		public bool IsRemoteDeleted
		{
			get{return _IsRemoteDeleted;}
			set
			{
				_IsRemoteDeleted = value;
				OnPropertyChanged();
			}
		}
		private Guid _LocalId;
		[CProperty(ColumnPath ="LocalId")]
		public Guid LocalId
		{
			get{return _LocalId;}
			set
			{
				_LocalId = value;
				OnPropertyChanged();
			}
		}
		private int _LocalState;
		[CProperty(ColumnPath ="LocalState")]
		public int LocalState
		{
			get{return _LocalState;}
			set
			{
				_LocalState = value;
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
		private Guid _ModifiedInStoreId;
		[CProperty(ColumnPath ="ModifiedInStoreId")]
		public Guid ModifiedInStoreId
		{
			get{return _ModifiedInStoreId;}
			set
			{
				_ModifiedInStoreId = value;
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
		private string _RemoteId;
		[CProperty(ColumnPath ="RemoteId")]
		public string RemoteId
		{
			get{return _RemoteId;}
			set
			{
				_RemoteId = value;
				OnPropertyChanged();
			}
		}
		private string _RemoteItemName;
		[CProperty(ColumnPath ="RemoteItemName")]
		public string RemoteItemName
		{
			get{return _RemoteItemName;}
			set
			{
				_RemoteItemName = value;
				OnPropertyChanged();
			}
		}
		private int _RemoteState;
		[CProperty(ColumnPath ="RemoteState")]
		public int RemoteState
		{
			get{return _RemoteState;}
			set
			{
				_RemoteState = value;
				OnPropertyChanged();
			}
		}
		private Guid _RemoteStoreId;
		[CProperty(ColumnPath ="RemoteStoreId")]
		public Guid RemoteStoreId
		{
			get{return _RemoteStoreId;}
			set
			{
				_RemoteStoreId = value;
				OnPropertyChanged();
			}
		}
		private int _SchemaOrder;
		[CProperty(ColumnPath ="SchemaOrder")]
		public int SchemaOrder
		{
			get{return _SchemaOrder;}
			set
			{
				_SchemaOrder = value;
				OnPropertyChanged();
			}
		}
		private string _SyncSchemaName;
		[CProperty(ColumnPath ="SyncSchemaName")]
		public string SyncSchemaName
		{
			get{return _SyncSchemaName;}
			set
			{
				_SyncSchemaName = value;
				OnPropertyChanged();
			}
		}
		private DateTime _Version;
		[CProperty(ColumnPath ="Version")]
		public DateTime Version
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
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
