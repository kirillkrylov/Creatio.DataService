using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsUserRoleForCase")]
	public class TsUserRoleForCase : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OwnerGroupForCaseId")]
		public Guid OwnerGroupForCaseId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		[CProperty(Navigation ="TsOwnerGroupForCase:OwnerGroupForCaseId")]
		public TsOwnerGroupForCase OwnerGroupForCase { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
