using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MLTrainSession")]
	public class MLTrainSession : BaseEntity
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
		private string _Error;
		[CProperty(ColumnPath ="Error")]
		public string Error
		{
			get{return _Error;}
			set
			{
				_Error = value;
				OnPropertyChanged();
			}
		}
		private string _FeatureImportances;
		[CProperty(ColumnPath ="FeatureImportances")]
		public string FeatureImportances
		{
			get{return _FeatureImportances;}
			set
			{
				_FeatureImportances = value;
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
		private bool _IgnoreMetricThreshold;
		[CProperty(ColumnPath ="IgnoreMetricThreshold")]
		public bool IgnoreMetricThreshold
		{
			get{return _IgnoreMetricThreshold;}
			set
			{
				_IgnoreMetricThreshold = value;
				OnPropertyChanged();
			}
		}
		private decimal _InstanceMetric;
		[CProperty(ColumnPath ="InstanceMetric")]
		public decimal InstanceMetric
		{
			get{return _InstanceMetric;}
			set
			{
				_InstanceMetric = value;
				OnPropertyChanged();
			}
		}
		private bool _InUse;
		[CProperty(ColumnPath ="InUse")]
		public bool InUse
		{
			get{return _InUse;}
			set
			{
				_InUse = value;
				OnPropertyChanged();
			}
		}
		private Guid _MLModelId;
		[CProperty(ColumnPath ="MLModelId")]
		public Guid MLModelId
		{
			get{return _MLModelId;}
			set
			{
				_MLModelId = value;
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
		private Guid _StateId;
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId
		{
			get{return _StateId;}
			set
			{
				_StateId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _TrainedOn;
		[CProperty(ColumnPath ="TrainedOn")]
		public DateTime TrainedOn
		{
			get{return _TrainedOn;}
			set
			{
				_TrainedOn = value;
				OnPropertyChanged();
			}
		}
		private int _TrainingTimeMinutes;
		[CProperty(ColumnPath ="TrainingTimeMinutes")]
		public int TrainingTimeMinutes
		{
			get{return _TrainingTimeMinutes;}
			set
			{
				_TrainingTimeMinutes = value;
				OnPropertyChanged();
			}
		}
		private int _TrainSetSize;
		[CProperty(ColumnPath ="TrainSetSize")]
		public int TrainSetSize
		{
			get{return _TrainSetSize;}
			set
			{
				_TrainSetSize = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MLModel:MLModelId")]
		public MLModel MLModel { get; set; }
		[CProperty(Navigation ="MLModelState:StateId")]
		public MLModelState State { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
