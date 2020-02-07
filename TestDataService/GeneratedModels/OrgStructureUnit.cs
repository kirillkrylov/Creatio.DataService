using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OrgStructureUnit")]
	public class OrgStructureUnit : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FullName")]
		public string FullName { get; set; }
		[CProperty(ColumnPath ="HeadId")]
		public Guid HeadId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:HeadId")]
		public Employee Head { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:ParentId")]
		public OrgStructureUnit Parent { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Employee:OrgStructureUnitId")]
		public virtual ICollection<Employee> EmployeeByOrgStructureUnit { get; set; }
		[CProperty(Association ="EmployeeCareer:OrgStructureUnitId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByOrgStructureUnit { get; set; }
		[CProperty(Association ="OrgStructureUnit:ParentId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByParent { get; set; }
		#endregion
	}
}
