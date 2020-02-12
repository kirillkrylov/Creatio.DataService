using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SupCaseCategoryByRole")]
	public class SupCaseCategoryByRole : BaseEntity
	{
		#region Values
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
		[CProperty(ColumnPath ="SupCaseCategoryId")]
		public Guid SupCaseCategoryId { get; set; }
		[CProperty(ColumnPath ="SupSysAdminUnitId")]
		public Guid SupSysAdminUnitId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="CaseCategory:SupCaseCategoryId")]
		public CaseCategory SupCaseCategory { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysAdminUnit:SupSysAdminUnitId")]
		public SysAdminUnit SupSysAdminUnit { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
