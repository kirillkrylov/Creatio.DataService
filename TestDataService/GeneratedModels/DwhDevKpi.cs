using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DwhDevKpi")]
	public class DwhDevKpi : BaseEntity
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
		private Guid _HodId;
		[CProperty(ColumnPath ="HodId")]
		public Guid HodId
		{
			get{return _HodId;}
			set
			{
				_HodId = value;
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
		private decimal _JiraBillingTime;
		[CProperty(ColumnPath ="JiraBillingTime")]
		public decimal JiraBillingTime
		{
			get{return _JiraBillingTime;}
			set
			{
				_JiraBillingTime = value;
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
		private DateTime _PeriodFrom;
		[CProperty(ColumnPath ="PeriodFrom")]
		public DateTime PeriodFrom
		{
			get{return _PeriodFrom;}
			set
			{
				_PeriodFrom = value;
				OnPropertyChanged();
			}
		}
		private string _PeriodName;
		[CProperty(ColumnPath ="PeriodName")]
		public string PeriodName
		{
			get{return _PeriodName;}
			set
			{
				_PeriodName = value;
				OnPropertyChanged();
			}
		}
		private DateTime _PeriodTo;
		[CProperty(ColumnPath ="PeriodTo")]
		public DateTime PeriodTo
		{
			get{return _PeriodTo;}
			set
			{
				_PeriodTo = value;
				OnPropertyChanged();
			}
		}
		private string _Position;
		[CProperty(ColumnPath ="Position")]
		public string Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
				OnPropertyChanged();
			}
		}
		private string _PracticeName;
		[CProperty(ColumnPath ="PracticeName")]
		public string PracticeName
		{
			get{return _PracticeName;}
			set
			{
				_PracticeName = value;
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
		private decimal _Productivity;
		[CProperty(ColumnPath ="Productivity")]
		public decimal Productivity
		{
			get{return _Productivity;}
			set
			{
				_Productivity = value;
				OnPropertyChanged();
			}
		}
		private decimal _RateSP;
		[CProperty(ColumnPath ="RateSP")]
		public decimal RateSP
		{
			get{return _RateSP;}
			set
			{
				_RateSP = value;
				OnPropertyChanged();
			}
		}
		private string _SkillLevel;
		[CProperty(ColumnPath ="SkillLevel")]
		public string SkillLevel
		{
			get{return _SkillLevel;}
			set
			{
				_SkillLevel = value;
				OnPropertyChanged();
			}
		}
		private decimal _SkillProgress;
		[CProperty(ColumnPath ="SkillProgress")]
		public decimal SkillProgress
		{
			get{return _SkillProgress;}
			set
			{
				_SkillProgress = value;
				OnPropertyChanged();
			}
		}
		private string _TeamName;
		[CProperty(ColumnPath ="TeamName")]
		public string TeamName
		{
			get{return _TeamName;}
			set
			{
				_TeamName = value;
				OnPropertyChanged();
			}
		}
		private decimal _TotalSP;
		[CProperty(ColumnPath ="TotalSP")]
		public decimal TotalSP
		{
			get{return _TotalSP;}
			set
			{
				_TotalSP = value;
				OnPropertyChanged();
			}
		}
		private int _WorkDays;
		[CProperty(ColumnPath ="WorkDays")]
		public int WorkDays
		{
			get{return _WorkDays;}
			set
			{
				_WorkDays = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:EmployeeId")]
		public Contact Employee { get; set; }
		[CProperty(Navigation ="Contact:HodId")]
		public Contact Hod { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
