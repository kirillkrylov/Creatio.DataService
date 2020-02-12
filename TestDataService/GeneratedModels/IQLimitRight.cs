using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IQLimitRight")]
	public class IQLimitRight : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IQDelete")]
		public bool IQDelete { get; set; }
		[CProperty(ColumnPath ="IQEdit")]
		public bool IQEdit { get; set; }
		[CProperty(ColumnPath ="IQRead")]
		public bool IQRead { get; set; }
		[CProperty(ColumnPath ="IQRightTypeId")]
		public Guid IQRightTypeId { get; set; }
		[CProperty(ColumnPath ="IQSetRightsId")]
		public Guid IQSetRightsId { get; set; }
		[CProperty(ColumnPath ="IQUserRoleId")]
		public Guid IQUserRoleId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="IQRightType:IQRightTypeId")]
		public IQRightType IQRightType { get; set; }
		[CProperty(Navigation ="IQSetRights:IQSetRightsId")]
		public IQSetRights IQSetRights { get; set; }
		[CProperty(Navigation ="VwSysAdminUnit:IQUserRoleId")]
		public VwSysAdminUnit IQUserRole { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
