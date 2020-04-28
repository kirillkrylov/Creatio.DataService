using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwSysEntitySchemaColumnRight")]
	public class VwSysEntitySchemaColumnRight : BaseEntity
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
		[CProperty(ColumnPath ="Position")]
		public int Position { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RightLevelId")]
		public Guid RightLevelId { get; set; }
		[CProperty(ColumnPath ="SubjectColumnUId")]
		public Guid SubjectColumnUId { get; set; }
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
		[CProperty(Navigation ="SysEntitySchemaColRightLevel:RightLevelId")]
		public SysEntitySchemaColRightLevel RightLevel { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:SysAdminUnitId")]
		public VwSysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
