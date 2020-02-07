using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysSyncMetaData")]
	public class SysSyncMetaData : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedInStoreId")]
		public Guid CreatedInStoreId { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExtraParameters")]
		public string ExtraParameters { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsLocalDeleted")]
		public bool IsLocalDeleted { get; set; }
		[CProperty(ColumnPath ="IsRemoteDeleted")]
		public bool IsRemoteDeleted { get; set; }
		[CProperty(ColumnPath ="LocalId")]
		public Guid LocalId { get; set; }
		[CProperty(ColumnPath ="LocalState")]
		public int LocalState { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedInStoreId")]
		public Guid ModifiedInStoreId { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RemoteId")]
		public string RemoteId { get; set; }
		[CProperty(ColumnPath ="RemoteItemName")]
		public string RemoteItemName { get; set; }
		[CProperty(ColumnPath ="RemoteState")]
		public int RemoteState { get; set; }
		[CProperty(ColumnPath ="RemoteStoreId")]
		public Guid RemoteStoreId { get; set; }
		[CProperty(ColumnPath ="SchemaOrder")]
		public int SchemaOrder { get; set; }
		[CProperty(ColumnPath ="SyncSchemaName")]
		public string SyncSchemaName { get; set; }
		[CProperty(ColumnPath ="Version")]
		public DateTime Version { get; set; }
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
