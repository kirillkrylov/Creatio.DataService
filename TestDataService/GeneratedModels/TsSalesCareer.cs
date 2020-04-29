using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsSalesCareer")]
	public class TsSalesCareer : BaseEntity
	{
		#region Values
		private Guid _AccountManagerId;
		[CProperty(ColumnPath ="AccountManagerId")]
		public Guid AccountManagerId
		{
			get{return _AccountManagerId;}
			set
			{
				_AccountManagerId = value;
				OnPropertyChanged();
			}
		}
		private decimal _BonusPercent;
		[CProperty(ColumnPath ="BonusPercent")]
		public decimal BonusPercent
		{
			get{return _BonusPercent;}
			set
			{
				_BonusPercent = value;
				OnPropertyChanged();
			}
		}
		private Guid _CityId;
		[CProperty(ColumnPath ="CityId")]
		public Guid CityId
		{
			get{return _CityId;}
			set
			{
				_CityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ContactId;
		[CProperty(ColumnPath ="ContactId")]
		public Guid ContactId
		{
			get{return _ContactId;}
			set
			{
				_ContactId = value;
				OnPropertyChanged();
			}
		}
		private Guid _CreatedById;
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById
		{
			get{return _CreatedById;}
			set
			{
				_CreatedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _CreatedOn;
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn
		{
			get{return _CreatedOn;}
			set
			{
				_CreatedOn = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DateEnd;
		[CProperty(ColumnPath ="DateEnd")]
		public DateTime DateEnd
		{
			get{return _DateEnd;}
			set
			{
				_DateEnd = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DateExam;
		[CProperty(ColumnPath ="DateExam")]
		public DateTime DateExam
		{
			get{return _DateExam;}
			set
			{
				_DateExam = value;
				OnPropertyChanged();
			}
		}
		private DateTime _DateStart;
		[CProperty(ColumnPath ="DateStart")]
		public DateTime DateStart
		{
			get{return _DateStart;}
			set
			{
				_DateStart = value;
				OnPropertyChanged();
			}
		}
		private Guid _Id;
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id
		{
			get{return _Id;}
			set
			{
				_Id = value;
				OnPropertyChanged();
			}
		}
		private Guid _ManagerRoleId;
		[CProperty(ColumnPath ="ManagerRoleId")]
		public Guid ManagerRoleId
		{
			get{return _ManagerRoleId;}
			set
			{
				_ManagerRoleId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MarketId;
		[CProperty(ColumnPath ="MarketId")]
		public Guid MarketId
		{
			get{return _MarketId;}
			set
			{
				_MarketId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ModifiedById;
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById
		{
			get{return _ModifiedById;}
			set
			{
				_ModifiedById = value;
				OnPropertyChanged();
			}
		}
		private DateTime _ModifiedOn;
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn
		{
			get{return _ModifiedOn;}
			set
			{
				_ModifiedOn = value;
				OnPropertyChanged();
			}
		}
		private Guid _OpportunityDepartmentId;
		[CProperty(ColumnPath ="OpportunityDepartmentId")]
		public Guid OpportunityDepartmentId
		{
			get{return _OpportunityDepartmentId;}
			set
			{
				_OpportunityDepartmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _PositionId;
		[CProperty(ColumnPath ="PositionId")]
		public Guid PositionId
		{
			get{return _PositionId;}
			set
			{
				_PositionId = value;
				OnPropertyChanged();
			}
		}
		private int _ProcessListeners;
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners
		{
			get{return _ProcessListeners;}
			set
			{
				_ProcessListeners = value;
				OnPropertyChanged();
			}
		}
		private DateTime _RecruitmentDate;
		[CProperty(ColumnPath ="RecruitmentDate")]
		public DateTime RecruitmentDate
		{
			get{return _RecruitmentDate;}
			set
			{
				_RecruitmentDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _SegmentId;
		[CProperty(ColumnPath ="SegmentId")]
		public Guid SegmentId
		{
			get{return _SegmentId;}
			set
			{
				_SegmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StaffTypeId;
		[CProperty(ColumnPath ="StaffTypeId")]
		public Guid StaffTypeId
		{
			get{return _StaffTypeId;}
			set
			{
				_StaffTypeId = value;
				OnPropertyChanged();
			}
		}
		private Guid _StartCalcPlanId;
		[CProperty(ColumnPath ="StartCalcPlanId")]
		public Guid StartCalcPlanId
		{
			get{return _StartCalcPlanId;}
			set
			{
				_StartCalcPlanId = value;
				OnPropertyChanged();
			}
		}
		private Guid _VersionSMJId;
		[CProperty(ColumnPath ="VersionSMJId")]
		public Guid VersionSMJId
		{
			get{return _VersionSMJId;}
			set
			{
				_VersionSMJId = value;
				OnPropertyChanged();
			}
		}
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
