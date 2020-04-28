using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysUserSession")]
	public class SysUserSession : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Agent")]
		public string Agent { get; set; }
		[CProperty(ColumnPath ="ClientIP")]
		public string ClientIP { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="ExternalAccessId")]
		public Guid ExternalAccessId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SessionEndDate")]
		public DateTime SessionEndDate { get; set; }
		[CProperty(ColumnPath ="SessionEndMethod")]
		public int SessionEndMethod { get; set; }
		[CProperty(ColumnPath ="SessionId")]
		public string SessionId { get; set; }
		[CProperty(ColumnPath ="SessionStartDate")]
		public DateTime SessionStartDate { get; set; }
		[CProperty(ColumnPath ="SysUserId")]
		public Guid SysUserId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ExternalAccess:ExternalAccessId")]
		public ExternalAccess ExternalAccess { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysUserId")]
		public SysAdminUnit SysUser { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
