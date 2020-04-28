using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwUserEmailsCount")]
	public class VwUserEmailsCount : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="EmailsCount")]
		public int EmailsCount { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
