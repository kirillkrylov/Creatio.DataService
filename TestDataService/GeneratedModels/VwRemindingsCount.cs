using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwRemindingsCount")]
	public class VwRemindingsCount : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="EmailsCount")]
		public int EmailsCount { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="RemindingsCount")]
		public int RemindingsCount { get; set; }
		[CProperty(ColumnPath ="SysAdminUnitId")]
		public Guid SysAdminUnitId { get; set; }
		[CProperty(ColumnPath ="VisaCount")]
		public int VisaCount { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SysAdminUnitId")]
		public SysAdminUnit SysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
