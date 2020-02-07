using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Department")]
	public class Department : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountOrganizationChart:DepartmentId")]
		public virtual ICollection<AccountOrganizationChart> AccountOrganizationChartByDepartment { get; set; }
		[CProperty(Association ="ConfItemUser:DepartmentId")]
		public virtual ICollection<ConfItemUser> ConfItemUserByDepartment { get; set; }
		[CProperty(Association ="Contact:DepartmentId")]
		public virtual ICollection<Contact> ContactByDepartment { get; set; }
		[CProperty(Association ="ContactCareer:DepartmentId")]
		public virtual ICollection<ContactCareer> ContactCareerByDepartment { get; set; }
		[CProperty(Association ="Lead:DepartmentId")]
		public virtual ICollection<Lead> LeadByDepartment { get; set; }
		[CProperty(Association ="LeadQualification:DepartmentId")]
		public virtual ICollection<LeadQualification> LeadQualificationByDepartment { get; set; }
		[CProperty(Association ="ServiceObject:DepartmentId")]
		public virtual ICollection<ServiceObject> ServiceObjectByDepartment { get; set; }
		[CProperty(Association ="VwServiceRecepients:DepartmentId")]
		public virtual ICollection<VwServiceRecepients> VwServiceRecepientsByDepartment { get; set; }
		#endregion
	}
}
