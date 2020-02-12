using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "CompetencesByRoles")]
	public class CompetencesByRoles : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CompetenceId")]
		public Guid CompetenceId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EmployeeJobId")]
		public Guid EmployeeJobId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RoleId")]
		public Guid RoleId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Competence:CompetenceId")]
		public Competence Competence { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="EmployeeJob:RoleId")]
		public EmployeeJob Role { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:EmployeeJobId")]
		public OrgStructureUnit EmployeeJob { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
