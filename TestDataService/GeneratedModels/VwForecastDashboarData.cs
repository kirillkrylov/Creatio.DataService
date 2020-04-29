using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "VwForecastDashboarData")]
	public class VwForecastDashboarData : BaseEntity
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
		private Guid _DimensionId;
		[CProperty(ColumnPath ="DimensionId")]
		public Guid DimensionId
		{
			get{return _DimensionId;}
			set
			{
				_DimensionId = value;
				OnPropertyChanged();
			}
		}
		private Guid _ForecastId;
		[CProperty(ColumnPath ="ForecastId")]
		public Guid ForecastId
		{
			get{return _ForecastId;}
			set
			{
				_ForecastId = value;
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
		private Guid _OwnerId;
		[CProperty(ColumnPath ="OwnerId")]
		public Guid OwnerId
		{
			get{return _OwnerId;}
			set
			{
				_OwnerId = value;
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
		private decimal _Value;
		[CProperty(ColumnPath ="Value")]
		public decimal Value
		{
			get{return _Value;}
			set
			{
				_Value = value;
				OnPropertyChanged();
			}
		}
		private decimal _ValueWeek;
		[CProperty(ColumnPath ="ValueWeek")]
		public decimal ValueWeek
		{
			get{return _ValueWeek;}
			set
			{
				_ValueWeek = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Contact:OwnerId")]
		public Contact Owner { get; set; }
		[CProperty(Navigation ="Dimension:DimensionId")]
		public Dimension Dimension { get; set; }
		[CProperty(Navigation ="Forecast:ForecastId")]
		public Forecast Forecast { get; set; }
		[CProperty(Navigation ="ForecastIndicator:IndicatorId")]
		public ForecastIndicator Indicator { get; set; }
		[CProperty(Navigation ="Period:PeriodId")]
		public Period Period { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
