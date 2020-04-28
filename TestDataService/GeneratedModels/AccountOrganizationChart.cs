using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "AccountOrganizationChart")]
	public class AccountOrganizationChart : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="CustomDepartmentName")]
		public string CustomDepartmentName { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation ="AccountOrganizationChart:ParentId")]
		public AccountOrganizationChart Parent { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ManagerId")]
		public Contact Manager { get; set; }
		[CProperty(Navigation ="Department:DepartmentId")]
		public Department Department { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountOrganizationChart:ParentId")]
		public virtual ICollection<AccountOrganizationChart> AccountOrganizationChartByParent { get; set; }
		#endregion
	}
}
