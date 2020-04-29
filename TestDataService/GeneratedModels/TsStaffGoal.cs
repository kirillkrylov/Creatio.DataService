using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TsStaffGoal")]
	public class TsStaffGoal : BaseEntity
	{
		#region Values
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
		private string _Description;
		[CProperty(ColumnPath ="Description")]
		public string Description
		{
			get{return _Description;}
			set
			{
				_Description = value;
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
		private DateTime _FactGoalDate;
		[CProperty(ColumnPath ="FactGoalDate")]
		public DateTime FactGoalDate
		{
			get{return _FactGoalDate;}
			set
			{
				_FactGoalDate = value;
				OnPropertyChanged();
			}
		}
		private string _Goal;
		[CProperty(ColumnPath ="Goal")]
		public string Goal
		{
			get{return _Goal;}
			set
			{
				_Goal = value;
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
		private Guid _ParentId;
		[CProperty(ColumnPath ="ParentId")]
		public Guid ParentId
		{
			get{return _ParentId;}
			set
			{
				_ParentId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PlanGoalDate;
		[CProperty(ColumnPath ="PlanGoalDate")]
		public DateTime PlanGoalDate
		{
			get{return _PlanGoalDate;}
			set
			{
				_PlanGoalDate = value;
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
		private decimal _Progress;
		[CProperty(ColumnPath ="Progress")]
		public decimal Progress
		{
			get{return _Progress;}
			set
			{
				_Progress = value;
				OnPropertyChanged();
			}
		}
		private Guid _StatusId;
		[CProperty(ColumnPath ="StatusId")]
		public Guid StatusId
		{
			get{return _StatusId;}
			set
			{
				_StatusId = value;
				OnPropertyChanged();
			}
		}
		private int _Weight;
		[CProperty(ColumnPath ="Weight")]
		public int Weight
		{
			get{return _Weight;}
			set
			{
				_Weight = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Employee:EmployeeId")]
		public Employee Employee { get; set; }
		[CProperty(Navigation ="TsStaffGoal:ParentId")]
		public TsStaffGoal Parent { get; set; }
		[CProperty(Navigation ="TsStaffGoalStatus:StatusId")]
		public TsStaffGoalStatus Status { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="TsStaffGoal:ParentId")]
		public virtual ICollection<TsStaffGoal> TsStaffGoalByParent { get; set; }
		[CProperty(Association ="TsStaffGoalFile:TsStaffGoalId")]
		public virtual ICollection<TsStaffGoalFile> TsStaffGoalFileByTsStaffGoal { get; set; }
		[CProperty(Association ="TsStaffGoalVisa:StaffGoalId")]
		public virtual ICollection<TsStaffGoalVisa> TsStaffGoalVisaByStaffGoal { get; set; }
		#endregion
	}
}
