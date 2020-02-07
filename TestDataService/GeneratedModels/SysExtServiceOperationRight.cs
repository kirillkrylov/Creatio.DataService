using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysExtServiceOperationRight")]
	public class SysExtServiceOperationRight : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CanAppend")]
		public bool CanAppend { get; set; }
		[CProperty(ColumnPath ="CanDelete")]
		public bool CanDelete { get; set; }
		[CProperty(ColumnPath ="CanEdit")]
		public bool CanEdit { get; set; }
		[CProperty(ColumnPath ="CanRead")]
		public bool CanRead { get; set; }
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
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="SubjectSchemaUId")]
		public Guid SubjectSchemaUId { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:SysAdminUnitId")]
		public VwSysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
