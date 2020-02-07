using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysAdminOperation")]
	public class SysAdminOperation : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Code")]
		public string Code { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysFolderId")]
		public Guid SysFolderId { get; set; }
		[CProperty(ColumnPath ="UseSystemOperationRestrictions")]
		public bool UseSystemOperationRestrictions { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminOperationFolder:SysFolderId")]
		public SysAdminOperationFolder SysFolder { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SysAdminOperationGrantee:SysAdminOperationId")]
		public virtual ICollection<SysAdminOperationGrantee> SysAdminOperationGranteeBySysAdminOperation { get; set; }
		#endregion
	}
}
