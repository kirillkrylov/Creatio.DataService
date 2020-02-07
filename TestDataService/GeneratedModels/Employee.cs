using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Employee")]
	public class Employee : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CareerDueDate")]
		public DateTime CareerDueDate { get; set; }
		[CProperty(ColumnPath ="CareerStartDate")]
		public DateTime CareerStartDate { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="JobId")]
		public Guid JobId { get; set; }
		[CProperty(ColumnPath ="ManagerId")]
		public Guid ManagerId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="OrgStructureUnitId")]
		public Guid OrgStructureUnitId { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProbationDueDate")]
		public DateTime ProbationDueDate { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReasonForDismissalId")]
		public Guid ReasonForDismissalId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Employee:ManagerId")]
		public Employee Manager { get; set; }
		[CProperty(Navigation ="EmployeeJob:JobId")]
		public EmployeeJob Job { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:OrgStructureUnitId")]
		public OrgStructureUnit OrgStructureUnit { get; set; }
		[CProperty(Navigation ="ReasonForLeaving:ReasonForDismissalId")]
		public ReasonForLeaving ReasonForDismissal { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="Employee:ManagerId")]
		public virtual ICollection<Employee> EmployeeByManager { get; set; }
		[CProperty(Association ="EmployeeCareer:EmployeeId")]
		public virtual ICollection<EmployeeCareer> EmployeeCareerByEmployee { get; set; }
		[CProperty(Association ="EmployeeFile:EmployeeId")]
		public virtual ICollection<EmployeeFile> EmployeeFileByEmployee { get; set; }
		[CProperty(Association ="EmployeeInFolder:EmployeeId")]
		public virtual ICollection<EmployeeInFolder> EmployeeInFolderByEmployee { get; set; }
		[CProperty(Association ="EmployeeInTag:EntityId")]
		public virtual ICollection<EmployeeInTag> EmployeeInTagByEntity { get; set; }
		[CProperty(Association ="OrgStructureUnit:HeadId")]
		public virtual ICollection<OrgStructureUnit> OrgStructureUnitByHead { get; set; }
		[CProperty(Association ="Salary:EmployeeId")]
		public virtual ICollection<Salary> SalaryByEmployee { get; set; }
		[CProperty(Association ="VwEmployeesHierarchy:EmployeeId")]
		public virtual ICollection<VwEmployeesHierarchy> VwEmployeesHierarchyByEmployee { get; set; }
		#endregion
	}
}
