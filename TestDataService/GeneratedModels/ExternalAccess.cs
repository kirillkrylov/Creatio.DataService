using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ExternalAccess")]
	public class ExternalAccess : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccessReason")]
		public string AccessReason { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="ExternalAccessClientId")]
		public Guid ExternalAccessClientId { get; set; }
		[CProperty(ColumnPath ="GrantorId")]
		public Guid GrantorId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsActive")]
		public bool IsActive { get; set; }
		[CProperty(ColumnPath ="IsDataIsolationEnabled")]
		public bool IsDataIsolationEnabled { get; set; }
		[CProperty(ColumnPath ="IsSystemOperationsRestricted")]
		public bool IsSystemOperationsRestricted { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
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
