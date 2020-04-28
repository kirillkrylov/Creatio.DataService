using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "HRTalks")]
	public class HRTalks : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CommonComment")]
		public string CommonComment { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId { get; set; }
		[CProperty(ColumnPath ="DevelopmentContentmentLevelId")]
		public Guid DevelopmentContentmentLevelId { get; set; }
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId { get; set; }
		[CProperty(ColumnPath ="Expectations")]
		public string Expectations { get; set; }
		[CProperty(ColumnPath ="ExpectedWage")]
		public decimal ExpectedWage { get; set; }
		[CProperty(ColumnPath ="FurtherActions")]
		public string FurtherActions { get; set; }
		[CProperty(ColumnPath ="HeadContentmentLevelId")]
		public Guid HeadContentmentLevelId { get; set; }
		[CProperty(ColumnPath ="HRBPId")]
		public Guid HRBPId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IncomeContentmentLevelId")]
		public Guid IncomeContentmentLevelId { get; set; }
		[CProperty(ColumnPath ="JobTitleId")]
		public Guid JobTitleId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OverallContentmentLevelId")]
		public Guid OverallContentmentLevelId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RoleINcompanyId")]
		public Guid RoleINcompanyId { get; set; }
		[CProperty(ColumnPath ="TalkDate")]
		public DateTime TalkDate { get; set; }
		[CProperty(ColumnPath ="TasksContentmentLevelId")]
		public Guid TasksContentmentLevelId { get; set; }
		[CProperty(ColumnPath ="TeamContentmentLevelId")]
		public Guid TeamContentmentLevelId { get; set; }
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId { get; set; }
		[CProperty(ColumnPath ="Wishes")]
		public string Wishes { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:HRBPId")]
		public Contact HRBP { get; set; }
		[CProperty(Navigation ="ContentmentLevel:TasksContentmentLevelId")]
		public ContentmentLevel TasksContentmentLevel { get; set; }
		[CProperty(Navigation ="ContentmentLevel:TeamContentmentLevelId")]
		public ContentmentLevel TeamContentmentLevel { get; set; }
		[CProperty(Navigation ="ContentmentLevel:HeadContentmentLevelId")]
		public ContentmentLevel HeadContentmentLevel { get; set; }
		[CProperty(Navigation ="ContentmentLevel:DevelopmentContentmentLevelId")]
		public ContentmentLevel DevelopmentContentmentLevel { get; set; }
		[CProperty(Navigation ="ContentmentLevel:IncomeContentmentLevelId")]
		public ContentmentLevel IncomeContentmentLevel { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="EmployeeJob:RoleINcompanyId")]
		public EmployeeJob RoleINcompany { get; set; }
		[CProperty(Navigation ="Level:OverallContentmentLevelId")]
		public Level OverallContentmentLevel { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:JobTitleId")]
		public OrgStructureUnit JobTitle { get; set; }
		[CProperty(Navigation ="OrgStructureUnit:DepartmentId")]
		public OrgStructureUnit Department { get; set; }
		[CProperty(Navigation ="TalkType:TypeId")]
		public TalkType Type { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
