using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "EmployeeCareer")]
	public class EmployeeCareer : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountId")]
		public Guid AccountId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DismissalInitiatorId")]
		public Guid DismissalInitiatorId { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="EmployeeJobId")]
		public Guid EmployeeJobId { get; set; }
		[CProperty(ColumnPath ="EndInCompany")]
		public bool EndInCompany { get; set; }
		[CProperty(ColumnPath ="FullJobTitle")]
		public string FullJobTitle { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsCurrent")]
		public bool IsCurrent { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OrgStructureUnitId")]
		public Guid OrgStructureUnitId { get; set; }
		[CProperty(ColumnPath ="ProbationDueDate")]
		public DateTime ProbationDueDate { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReasonForDismissalId")]
		public Guid ReasonForDismissalId { get; set; }
		[CProperty(ColumnPath ="StaffUnitId")]
		public Guid StaffUnitId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="StartInCompany")]
		public bool StartInCompany { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Account:AccountId")]
		public Account Account { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="DismissalInitiator:DismissalInitiatorId")]
		public DismissalInitiator DismissalInitiator { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="EmployeeJob:EmployeeJobId")]
		public EmployeeJob EmployeeJob { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:OrgStructureUnitId")]
		public OrgStructureUnit OrgStructureUnit { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:StaffUnitId")]
		public OrgStructureUnit StaffUnit { get; set; }
		[CProperty(Navigation ="ReasonForLeaving:ReasonForDismissalId")]
		public ReasonForLeaving ReasonForDismissal { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
