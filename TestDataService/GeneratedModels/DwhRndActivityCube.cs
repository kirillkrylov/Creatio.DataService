using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "DwhRndActivityCube")]
	public class DwhRndActivityCube : BaseEntity
	{
		#region Values
		private decimal _AvgDuration;
		[CProperty(ColumnPath ="AvgDuration")]
		public decimal AvgDuration
		{
			get{return _AvgDuration;}
			set
			{
				_AvgDuration = value;
				OnPropertyChanged();
			}
		}
		private decimal _BillingJira;
		[CProperty(ColumnPath ="BillingJira")]
		public decimal BillingJira
		{
			get{return _BillingJira;}
			set
			{
				_BillingJira = value;
				OnPropertyChanged();
			}
		}
		private decimal _BillingTotal;
		[CProperty(ColumnPath ="BillingTotal")]
		public decimal BillingTotal
		{
			get{return _BillingTotal;}
			set
			{
				_BillingTotal = value;
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
		private decimal _IncAvgDuration;
		[CProperty(ColumnPath ="IncAvgDuration")]
		public decimal IncAvgDuration
		{
			get{return _IncAvgDuration;}
			set
			{
				_IncAvgDuration = value;
				OnPropertyChanged();
			}
		}
		private int _IncidentCount;
		[CProperty(ColumnPath ="IncidentCount")]
		public int IncidentCount
		{
			get{return _IncidentCount;}
			set
			{
				_IncidentCount = value;
				OnPropertyChanged();
			}
		}
		private decimal _IncIncidentCount;
		[CProperty(ColumnPath ="IncIncidentCount")]
		public decimal IncIncidentCount
		{
			get{return _IncIncidentCount;}
			set
			{
				_IncIncidentCount = value;
				OnPropertyChanged();
			}
		}
		private decimal _IncProductivity;
		[CProperty(ColumnPath ="IncProductivity")]
		public decimal IncProductivity
		{
			get{return _IncProductivity;}
			set
			{
				_IncProductivity = value;
				OnPropertyChanged();
			}
		}
		private decimal _IncSpeed;
		[CProperty(ColumnPath ="IncSpeed")]
		public decimal IncSpeed
		{
			get{return _IncSpeed;}
			set
			{
				_IncSpeed = value;
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
		private Guid _PeriodId;
		[CProperty(ColumnPath ="PeriodId")]
		public Guid PeriodId
		{
			get{return _PeriodId;}
			set
			{
				_PeriodId = value;
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
		private decimal _Speed;
		[CProperty(ColumnPath ="Speed")]
		public decimal Speed
		{
			get{return _Speed;}
			set
			{
				_Speed = value;
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
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
