using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "Period")]
	public class Period : BaseEntity
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
		private DateTime _DueDate;
		[CProperty(ColumnPath ="DueDate")]
		public DateTime DueDate
		{
			get{return _DueDate;}
			set
			{
				_DueDate = value;
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
		private Guid _PeriodTypeId;
		[CProperty(ColumnPath ="PeriodTypeId")]
		public Guid PeriodTypeId
		{
			get{return _PeriodTypeId;}
			set
			{
				_PeriodTypeId = value;
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
		private Guid _QuarterId;
		[CProperty(ColumnPath ="QuarterId")]
		public Guid QuarterId
		{
			get{return _QuarterId;}
			set
			{
				_QuarterId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _StartDate;
		[CProperty(ColumnPath ="StartDate")]
		public DateTime StartDate
		{
			get{return _StartDate;}
			set
			{
				_StartDate = value;
				OnPropertyChanged();
			}
		}
		private Guid _YearId;
		[CProperty(ColumnPath ="YearId")]
		public Guid YearId
		{
			get{return _YearId;}
			set
			{
				_YearId = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Period:ParentId")]
		public Period Parent { get; set; }
		[CProperty(Navigation ="Period:YearId")]
		public Period Year { get; set; }
		[CProperty(Navigation ="Period:QuarterId")]
		public Period Quarter { get; set; }
		[CProperty(Navigation ="PeriodType:PeriodTypeId")]
		public PeriodType PeriodType { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:PeriodId")]
		public virtual ICollection<AccountForecast> AccountForecastByPeriod { get; set; }
		[CProperty(Association ="Bonus:AccrualPeriodId")]
		public virtual ICollection<Bonus> BonusByAccrualPeriod { get; set; }
		[CProperty(Association ="Budget:PeriodId")]
		public virtual ICollection<Budget> BudgetByPeriod { get; set; }
		[CProperty(Association ="ClientARRInPeriod:PeriodId")]
		public virtual ICollection<ClientARRInPeriod> ClientARRInPeriodByPeriod { get; set; }
		[CProperty(Association ="ClientSaaSMetrics:PeriodId")]
		public virtual ICollection<ClientSaaSMetrics> ClientSaaSMetricsByPeriod { get; set; }
		[CProperty(Association ="ContactForecast:PeriodId")]
		public virtual ICollection<ContactForecast> ContactForecastByPeriod { get; set; }
		[CProperty(Association ="DwhRndActivityCube:PeriodId")]
		public virtual ICollection<DwhRndActivityCube> DwhRndActivityCubeByPeriod { get; set; }
		[CProperty(Association ="DwhRndActivityTagCube:PeriodId")]
		public virtual ICollection<DwhRndActivityTagCube> DwhRndActivityTagCubeByPeriod { get; set; }
		[CProperty(Association ="DwhRndActivityTaskCategoryCube:PeriodId")]
		public virtual ICollection<DwhRndActivityTaskCategoryCube> DwhRndActivityTaskCategoryCubeByPeriod { get; set; }
		[CProperty(Association ="EmployeeForecast:PeriodId")]
		public virtual ICollection<EmployeeForecast> EmployeeForecastByPeriod { get; set; }
		[CProperty(Association ="EmployeeKpi:PeriodId")]
		public virtual ICollection<EmployeeKpi> EmployeeKpiByPeriod { get; set; }
		[CProperty(Association ="InternalRequest:PeriodId")]
		public virtual ICollection<InternalRequest> InternalRequestByPeriod { get; set; }
		[CProperty(Association ="LeadTypeForecast:PeriodId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByPeriod { get; set; }
		[CProperty(Association ="OppDepartmentForecast:PeriodId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByPeriod { get; set; }
		[CProperty(Association ="Period:ParentId")]
		public virtual ICollection<Period> PeriodByParent { get; set; }
		[CProperty(Association ="Period:YearId")]
		public virtual ICollection<Period> PeriodByYear { get; set; }
		[CProperty(Association ="Period:QuarterId")]
		public virtual ICollection<Period> PeriodByQuarter { get; set; }
		[CProperty(Association ="ProductForecast:PeriodId")]
		public virtual ICollection<ProductForecast> ProductForecastByPeriod { get; set; }
		[CProperty(Association ="SaaSMetrics:PeriodId")]
		public virtual ICollection<SaaSMetrics> SaaSMetricsByPeriod { get; set; }
		[CProperty(Association ="SupplyPaymentElement:PeriodId")]
		public virtual ICollection<SupplyPaymentElement> SupplyPaymentElementByPeriod { get; set; }
		[CProperty(Association ="Transaction:PeriodId")]
		public virtual ICollection<Transaction> TransactionByPeriod { get; set; }
		[CProperty(Association ="TransactionForecast:PeriodId")]
		public virtual ICollection<TransactionForecast> TransactionForecastByPeriod { get; set; }
		[CProperty(Association ="TsStaffSkillPeriod:PeriodId")]
		public virtual ICollection<TsStaffSkillPeriod> TsStaffSkillPeriodByPeriod { get; set; }
		[CProperty(Association ="VwForecastDashboarData:PeriodId")]
		public virtual ICollection<VwForecastDashboarData> VwForecastDashboarDataByPeriod { get; set; }
		[CProperty(Association ="VwTransaction:PeriodId")]
		public virtual ICollection<VwTransaction> VwTransactionByPeriod { get; set; }
		#endregion
	}
}
