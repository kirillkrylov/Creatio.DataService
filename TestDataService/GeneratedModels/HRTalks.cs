using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "HRTalks")]
	public class HRTalks : BaseEntity
	{
		#region Values
		private string _CommonComment;
		[CProperty(ColumnPath ="CommonComment")]
		public string CommonComment
		{
			get{return _CommonComment;}
			set
			{
				_CommonComment = value;
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
		private Guid _DepartmentId;
		[CProperty(ColumnPath ="DepartmentId")]
		public Guid DepartmentId
		{
			get{return _DepartmentId;}
			set
			{
				_DepartmentId = value;
				OnPropertyChanged();
			}
		}
		private Guid _DevelopmentContentmentLevelId;
		[CProperty(ColumnPath ="DevelopmentContentmentLevelId")]
		public Guid DevelopmentContentmentLevelId
		{
			get{return _DevelopmentContentmentLevelId;}
			set
			{
				_DevelopmentContentmentLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _EmployeeId;
		[CProperty(ColumnPath ="EmployeeId")]
		public Guid EmployeeId
		{
			get{return _EmployeeId;}
			set
			{
				_EmployeeId = value;
				OnPropertyChanged();
			}
		}
		private string _Expectations;
		[CProperty(ColumnPath ="Expectations")]
		public string Expectations
		{
			get{return _Expectations;}
			set
			{
				_Expectations = value;
				OnPropertyChanged();
			}
		}
		private decimal _ExpectedWage;
		[CProperty(ColumnPath ="ExpectedWage")]
		public decimal ExpectedWage
		{
			get{return _ExpectedWage;}
			set
			{
				_ExpectedWage = value;
				OnPropertyChanged();
			}
		}
		private string _FurtherActions;
		[CProperty(ColumnPath ="FurtherActions")]
		public string FurtherActions
		{
			get{return _FurtherActions;}
			set
			{
				_FurtherActions = value;
				OnPropertyChanged();
			}
		}
		private Guid _HeadContentmentLevelId;
		[CProperty(ColumnPath ="HeadContentmentLevelId")]
		public Guid HeadContentmentLevelId
		{
			get{return _HeadContentmentLevelId;}
			set
			{
				_HeadContentmentLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _HRBPId;
		[CProperty(ColumnPath ="HRBPId")]
		public Guid HRBPId
		{
			get{return _HRBPId;}
			set
			{
				_HRBPId = value;
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
		private Guid _IncomeContentmentLevelId;
		[CProperty(ColumnPath ="IncomeContentmentLevelId")]
		public Guid IncomeContentmentLevelId
		{
			get{return _IncomeContentmentLevelId;}
			set
			{
				_IncomeContentmentLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _JobTitleId;
		[CProperty(ColumnPath ="JobTitleId")]
		public Guid JobTitleId
		{
			get{return _JobTitleId;}
			set
			{
				_JobTitleId = value;
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
		private string _Name;
		[CProperty(ColumnPath ="Name")]
		public string Name
		{
			get{return _Name;}
			set
			{
				_Name = value;
				OnPropertyChanged();
			}
		}
		private Guid _OverallContentmentLevelId;
		[CProperty(ColumnPath ="OverallContentmentLevelId")]
		public Guid OverallContentmentLevelId
		{
			get{return _OverallContentmentLevelId;}
			set
			{
				_OverallContentmentLevelId = value;
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
		private Guid _RoleINcompanyId;
		[CProperty(ColumnPath ="RoleINcompanyId")]
		public Guid RoleINcompanyId
		{
			get{return _RoleINcompanyId;}
			set
			{
				_RoleINcompanyId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _TalkDate;
		[CProperty(ColumnPath ="TalkDate")]
		public DateTime TalkDate
		{
			get{return _TalkDate;}
			set
			{
				_TalkDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _TasksContentmentLevelId;
		[CProperty(ColumnPath ="TasksContentmentLevelId")]
		public Guid TasksContentmentLevelId
		{
			get{return _TasksContentmentLevelId;}
			set
			{
				_TasksContentmentLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TeamContentmentLevelId;
		[CProperty(ColumnPath ="TeamContentmentLevelId")]
		public Guid TeamContentmentLevelId
		{
			get{return _TeamContentmentLevelId;}
			set
			{
				_TeamContentmentLevelId = value;
				OnPropertyChanged();
			}
		}
		private Guid _TypeId;
		[CProperty(ColumnPath ="TypeId")]
		public Guid TypeId
		{
			get{return _TypeId;}
			set
			{
				_TypeId = value;
				OnPropertyChanged();
			}
		}
		private string _Wishes;
		[CProperty(ColumnPath ="Wishes")]
		public string Wishes
		{
			get{return _Wishes;}
			set
			{
				_Wishes = value;
				OnPropertyChanged();
			}
		}
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
