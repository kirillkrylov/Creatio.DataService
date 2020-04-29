using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "ForecastDimension")]
	public class ForecastDimension : BaseEntity
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
		private int _Level;
		[CProperty(ColumnPath ="Level")]
		public int Level
		{
			get{return _Level;}
			set
			{
				_Level = value;
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
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="Dimension:DimensionId")]
		public Dimension Dimension { get; set; }
		[CProperty(Navigation ="Forecast:ForecastId")]
		public Forecast Forecast { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="ForecastItem:ForecastDimensionId")]
		public virtual ICollection<ForecastItem> ForecastItemByForecastDimension { get; set; }
		#endregion
	}
}
