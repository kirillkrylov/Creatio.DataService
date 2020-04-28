using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "RecruitmentInStage")]
	public class RecruitmentInStage : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate { get; set; }
		[CProperty(ColumnPath ="EmployeeJobId")]
		public Guid EmployeeJobId { get; set; }
		[CProperty(ColumnPath ="Historical")]
		public bool Historical { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RootEntityId")]
		public Guid RootEntityId { get; set; }
		[CProperty(ColumnPath ="StageId")]
		public Guid StageId { get; set; }
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate { get; set; }
		[CProperty(ColumnPath ="SysSchemaId")]
		public Guid SysSchemaId { get; set; }
		[CProperty(ColumnPath ="TypeOfChangeInApplicantId")]
		public Guid TypeOfChangeInApplicantId { get; set; }
		[CProperty(ColumnPath ="Value")]
		public string Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="Applicant:RootEntityId")]
		public Applicant RootEntity { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="EmployeeJob:EmployeeJobId")]
		public EmployeeJob EmployeeJob { get; set; }
		[CProperty(Navigation ="RecruitmentStage:StageId")]
		public RecruitmentStage Stage { get; set; }
		[CProperty(Navigation ="SysSchema:SysSchemaId")]
		public SysSchema SysSchema { get; set; }
		[CProperty(Navigation ="TypeOfChangeApplicant:TypeOfChangeInApplicantId")]
		public TypeOfChangeApplicant TypeOfChangeInApplicant { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
