using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSalesCareer")]
	public class TsSalesCareer : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="AccountManagerId")]
		public Guid AccountManagerId { get; set; }
		[CProperty(ColumnPath ="BonusPercent")]
		public decimal BonusPercent { get; set; }
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId { get; set; }
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DateEnd")]
		public DateTime DateEnd { get; set; }
		[CProperty(ColumnPath ="DateExam")]
		public DateTime DateExam { get; set; }
		[CProperty(ColumnPath ="DateStart")]
		public DateTime DateStart { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ManagerRoleId")]
		public Guid ManagerRoleId { get; set; }
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId { get; set; }
		[CProperty(ColumnPath ="PositionId")]
		public Guid PositionId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RecruitmentDate")]
		public DateTime RecruitmentDate { get; set; }
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId { get; set; }
		[CProperty(ColumnPath ="StaffTypeId")]
		public Guid StaffTypeId { get; set; }
		[CProperty(ColumnPath ="StartCalcPlanId")]
		public Guid StartCalcPlanId { get; set; }
		[CProperty(ColumnPath ="VersionSMJId")]
		public Guid VersionSMJId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation ="City:CityId")]
		public City City { get; set; }
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:AccountManagerId")]
		public Contact AccountManager { get; set; }
		[CProperty(Navigation ="Contact:ContactId")]
		public Contact Contact { get; set; }
		[CProperty(Navigation ="OpportunityDepartment:OpportunityDepartmentId")]
		public OpportunityDepartment OpportunityDepartment { get; set; }
		[CProperty(Navigation ="TsSalesCareerMarket:MarketId")]
		public TsSalesCareerMarket Market { get; set; }
		[CProperty(Navigation ="TsSalesCareerPosition:PositionId")]
		public TsSalesCareerPosition Position { get; set; }
		[CProperty(Navigation ="TsSalesCareerRole:ManagerRoleId")]
		public TsSalesCareerRole ManagerRole { get; set; }
		[CProperty(Navigation ="TsSalesCareerSchedule:StaffTypeId")]
		public TsSalesCareerSchedule StaffType { get; set; }
		[CProperty(Navigation ="TsSalesCareerSegment:SegmentId")]
		public TsSalesCareerSegment Segment { get; set; }
		[CProperty(Navigation ="TsStartCalcPlan:StartCalcPlanId")]
		public TsStartCalcPlan StartCalcPlan { get; set; }
		[CProperty(Navigation ="TsVersionSMJ:VersionSMJId")]
		public TsVersionSMJ VersionSMJ { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
