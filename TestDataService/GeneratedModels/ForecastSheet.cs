using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastSheet")]
	public class ForecastSheet : BaseEntity
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
		private Guid _ForecastEntityId;
		[CProperty(ColumnPath ="ForecastEntityId")]
		public Guid ForecastEntityId
		{
			get{return _ForecastEntityId;}
			set
			{
				_ForecastEntityId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ForecastEntityInCellUId;
		[CProperty(ColumnPath ="ForecastEntityInCellUId")]
		public Guid ForecastEntityInCellUId
		{
			get{return _ForecastEntityInCellUId;}
			set
			{
				_ForecastEntityInCellUId = value;
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
		private string _Setting;
		[CProperty(ColumnPath ="Setting")]
		public string Setting
		{
			get{return _Setting;}
			set
			{
				_Setting = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="PeriodType:PeriodTypeId")]
		public PeriodType PeriodType { get; set; }
		[CProperty(Navigation ="VwEntityObjects:ForecastEntityId")]
		public VwEntityObjects ForecastEntity { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:SheetId")]
		public virtual ICollection<AccountForecast> AccountForecastBySheet { get; set; }
		[CProperty(Association ="ContactForecast:SheetId")]
		public virtual ICollection<ContactForecast> ContactForecastBySheet { get; set; }
		[CProperty(Association ="EmployeeForecast:SheetId")]
		public virtual ICollection<EmployeeForecast> EmployeeForecastBySheet { get; set; }
		[CProperty(Association ="ForecastColumn:SheetId")]
		public virtual ICollection<ForecastColumn> ForecastColumnBySheet { get; set; }
		[CProperty(Association ="LeadTypeForecast:SheetId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastBySheet { get; set; }
		[CProperty(Association ="OppDepartmentForecast:SheetId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastBySheet { get; set; }
		[CProperty(Association ="ProductForecast:SheetId")]
		public virtual ICollection<ProductForecast> ProductForecastBySheet { get; set; }
		#endregion
	}
}
