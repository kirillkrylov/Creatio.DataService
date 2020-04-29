using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastColumn")]
	public class ForecastColumn : BaseEntity
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
		private Guid _IndicatorId;
		[CProperty(ColumnPath ="IndicatorId")]
		public Guid IndicatorId
		{
			get{return _IndicatorId;}
			set
			{
				_IndicatorId = value;
				OnPropertyChanged();
			}
		}
		private bool _IsHide;
		[CProperty(ColumnPath ="IsHide")]
		public bool IsHide
		{
			get{return _IsHide;}
			set
			{
				_IsHide = value;
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
		private int _Position;
		[CProperty(ColumnPath ="Position")]
		public int Position
		{
			get{return _Position;}
			set
			{
				_Position = value;
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
		private string _Settings;
		[CProperty(ColumnPath ="Settings")]
		public string Settings
		{
			get{return _Settings;}
			set
			{
				_Settings = value;
				OnPropertyChanged();
			}
		}
		private Guid _SheetId;
		[CProperty(ColumnPath ="SheetId")]
		public Guid SheetId
		{
			get{return _SheetId;}
			set
			{
				_SheetId = value;
				OnPropertyChanged();
			}
		}
		private string _Title;
		[CProperty(ColumnPath ="Title")]
		public string Title
		{
			get{return _Title;}
			set
			{
				_Title = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="ForecastColumnType:TypeId")]
		public ForecastColumnType Type { get; set; }
		[CProperty(Navigation ="ForecastIndicator:IndicatorId")]
		public ForecastIndicator Indicator { get; set; }
		[CProperty(Navigation ="ForecastSheet:SheetId")]
		public ForecastSheet Sheet { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="AccountForecast:ForecastColumnId")]
		public virtual ICollection<AccountForecast> AccountForecastByForecastColumn { get; set; }
		[CProperty(Association ="ContactForecast:ForecastColumnId")]
		public virtual ICollection<ContactForecast> ContactForecastByForecastColumn { get; set; }
		[CProperty(Association ="EmployeeForecast:ForecastColumnId")]
		public virtual ICollection<EmployeeForecast> EmployeeForecastByForecastColumn { get; set; }
		[CProperty(Association ="LeadTypeForecast:ForecastColumnId")]
		public virtual ICollection<LeadTypeForecast> LeadTypeForecastByForecastColumn { get; set; }
		[CProperty(Association ="OppDepartmentForecast:ForecastColumnId")]
		public virtual ICollection<OppDepartmentForecast> OppDepartmentForecastByForecastColumn { get; set; }
		[CProperty(Association ="ProductForecast:ForecastColumnId")]
		public virtual ICollection<ProductForecast> ProductForecastByForecastColumn { get; set; }
		#endregion
	}
}
