using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwUserRemindingsCount")]
	public class VwUserRemindingsCount : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="RemindingsCount")]
		public int RemindingsCount { get; set; }
		[CProperty(ColumnPath ="RemindTime")]
		public DateTime RemindTime { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		[CProperty(ColumnPath ="TimeZoneId")]
		public string TimeZoneId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
