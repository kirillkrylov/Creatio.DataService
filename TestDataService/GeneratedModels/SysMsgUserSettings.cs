using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysMsgUserSettings")]
	public class SysMsgUserSettings : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ConnectionParams")]
		public string ConnectionParams { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysMsgLibId")]
		public Guid SysMsgLibId { get; set; }
		[CProperty(ColumnPath ="UserId")]
		public Guid UserId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:UserId")]
		public SysAdminUnit User { get; set; }
		[CProperty(Navigation ="SysMsgLib:SysMsgLibId")]
		public SysMsgLib SysMsgLib { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
