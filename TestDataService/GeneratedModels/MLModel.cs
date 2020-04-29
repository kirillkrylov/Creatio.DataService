using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MLModel")]
	public class MLModel : BaseEntity
	{
		#region Values
		private DateTime _BatchPredictedOn;
		[CProperty(ColumnPath ="BatchPredictedOn")]
		public DateTime BatchPredictedOn
		{
			get{return _BatchPredictedOn;}
			set
			{
				_BatchPredictedOn = value;
				OnPropertyChanged();
			}
		}
		private byte[] _BatchPredictionFilterData;
		[CProperty(ColumnPath ="BatchPredictionFilterData")]
		public byte[] BatchPredictionFilterData
		{
			get{return _BatchPredictionFilterData;}
			set
			{
				_BatchPredictionFilterData = value;
				OnPropertyChanged();
			}
		}
		private string _BatchPredictionQuery;
		[CProperty(ColumnPath ="BatchPredictionQuery")]
		public string BatchPredictionQuery
		{
			get{return _BatchPredictionQuery;}
			set
			{
				_BatchPredictionQuery = value;
				OnPropertyChanged();
			}
		}
		private Guid _BatchPredictionStartMethodId;
		[CProperty(ColumnPath ="BatchPredictionStartMethodId")]
		public Guid BatchPredictionStartMethodId
		{
			get{return _BatchPredictionStartMethodId;}
			set
			{
				_BatchPredictionStartMethodId = value;
				OnPropertyChanged();
			}
		}
		private decimal _ConfidentValueLowEdge;
		[CProperty(ColumnPath ="ConfidentValueLowEdge")]
		public decimal ConfidentValueLowEdge
		{
			get{return _ConfidentValueLowEdge;}
			set
			{
				_ConfidentValueLowEdge = value;
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
		private string _LastError;
		[CProperty(ColumnPath ="LastError")]
		public string LastError
		{
			get{return _LastError;}
			set
			{
				_LastError = value;
				OnPropertyChanged();
			}
		}
		private string _MetaData;
		[CProperty(ColumnPath ="MetaData")]
		public string MetaData
		{
			get{return _MetaData;}
			set
			{
				_MetaData = value;
				OnPropertyChanged();
			}
		}
		private string _MetaDataLcz;
		[CProperty(ColumnPath ="MetaDataLcz")]
		public string MetaDataLcz
		{
			get{return _MetaDataLcz;}
			set
			{
				_MetaDataLcz = value;
				OnPropertyChanged();
			}
		}
		private decimal _MetricThreshold;
		[CProperty(ColumnPath ="MetricThreshold")]
		public decimal MetricThreshold
		{
			get{return _MetricThreshold;}
			set
			{
				_MetricThreshold = value;
				OnPropertyChanged();
			}
		}
		private Guid _MLConfidentValueMethodId;
		[CProperty(ColumnPath ="MLConfidentValueMethodId")]
		public Guid MLConfidentValueMethodId
		{
			get{return _MLConfidentValueMethodId;}
			set
			{
				_MLConfidentValueMethodId = value;
				OnPropertyChanged();
			}
		}
		private Guid _MLProblemTypeId;
		[CProperty(ColumnPath ="MLProblemTypeId")]
		public Guid MLProblemTypeId
		{
			get{return _MLProblemTypeId;}
			set
			{
				_MLProblemTypeId = value;
				OnPropertyChanged();
			}
		}
		private string _ModelInstanceUId;
		[CProperty(ColumnPath ="ModelInstanceUId")]
		public string ModelInstanceUId
		{
			get{return _ModelInstanceUId;}
			set
			{
				_ModelInstanceUId = value;
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
		private string _Notes;
		[CProperty(ColumnPath ="Notes")]
		public string Notes
		{
			get{return _Notes;}
			set
			{
				_Notes = value;
				OnPropertyChanged();
			}
		}
		private Guid _PredictedResultColumnUId;
		[CProperty(ColumnPath ="PredictedResultColumnUId")]
		public Guid PredictedResultColumnUId
		{
			get{return _PredictedResultColumnUId;}
			set
			{
				_PredictedResultColumnUId = value;
				OnPropertyChanged();
			}
		}
		private bool _PredictionEnabled;
		[CProperty(ColumnPath ="PredictionEnabled")]
		public bool PredictionEnabled
		{
			get{return _PredictionEnabled;}
			set
			{
				_PredictionEnabled = value;
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
		private Guid _RootSchemaUId;
		[CProperty(ColumnPath ="RootSchemaUId")]
		public Guid RootSchemaUId
		{
			get{return _RootSchemaUId;}
			set
			{
				_RootSchemaUId = value;
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
		private Guid _TargetColumnUId;
		[CProperty(ColumnPath ="TargetColumnUId")]
		public Guid TargetColumnUId
		{
			get{return _TargetColumnUId;}
			set
			{
				_TargetColumnUId = value;
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
		private int _TrainFrequency;
		[CProperty(ColumnPath ="TrainFrequency")]
		public int TrainFrequency
		{
			get{return _TrainFrequency;}
			set
			{
				_TrainFrequency = value;
				OnPropertyChanged();
			}
		}
		private byte[] _TrainingFilterData;
		[CProperty(ColumnPath ="TrainingFilterData")]
		public byte[] TrainingFilterData
		{
			get{return _TrainingFilterData;}
			set
			{
				_TrainingFilterData = value;
				OnPropertyChanged();
			}
		}
		private int _TrainingMaxRecordsCount;
		[CProperty(ColumnPath ="TrainingMaxRecordsCount")]
		public int TrainingMaxRecordsCount
		{
			get{return _TrainingMaxRecordsCount;}
			set
			{
				_TrainingMaxRecordsCount = value;
				OnPropertyChanged();
			}
		}
		private int _TrainingMinimumRecordsCount;
		[CProperty(ColumnPath ="TrainingMinimumRecordsCount")]
		public int TrainingMinimumRecordsCount
		{
			get{return _TrainingMinimumRecordsCount;}
			set
			{
				_TrainingMinimumRecordsCount = value;
				OnPropertyChanged();
			}
		}
		private byte[] _TrainingOutputFilterData;
		[CProperty(ColumnPath ="TrainingOutputFilterData")]
		public byte[] TrainingOutputFilterData
		{
			get{return _TrainingOutputFilterData;}
			set
			{
				_TrainingOutputFilterData = value;
				OnPropertyChanged();
			}
		}
		private string _TrainingSetQuery;
		[CProperty(ColumnPath ="TrainingSetQuery")]
		public string TrainingSetQuery
		{
			get{return _TrainingSetQuery;}
			set
			{
				_TrainingSetQuery = value;
				OnPropertyChanged();
			}
		}
		private Guid _TrainSessionId;
		[CProperty(ColumnPath ="TrainSessionId")]
		public Guid TrainSessionId
		{
			get{return _TrainSessionId;}
			set
			{
				_TrainSessionId = value;
				OnPropertyChanged();
			}
		}
		private DateTime _TriedToTrainOn;
		[CProperty(ColumnPath ="TriedToTrainOn")]
		public DateTime TriedToTrainOn
		{
			get{return _TriedToTrainOn;}
			set
			{
				_TriedToTrainOn = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="MLConfidentValueMethod:MLConfidentValueMethodId")]
		public MLConfidentValueMethod MLConfidentValueMethod { get; set; }
		[CProperty(Navigation ="MLModelState:StateId")]
		public MLModelState State { get; set; }
		[CProperty(Navigation ="MLProblemType:MLProblemTypeId")]
		public MLProblemType MLProblemType { get; set; }
		[CProperty(Navigation ="MLTaskStartMethod:BatchPredictionStartMethodId")]
		public MLTaskStartMethod BatchPredictionStartMethod { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="MLClassificationResult:ModelId")]
		public virtual ICollection<MLClassificationResult> MLClassificationResultByModel { get; set; }
		[CProperty(Association ="MLModelColumn:MLModelId")]
		public virtual ICollection<MLModelColumn> MLModelColumnByMLModel { get; set; }
		[CProperty(Association ="MLModelFile:MLModelId")]
		public virtual ICollection<MLModelFile> MLModelFileByMLModel { get; set; }
		[CProperty(Association ="MLModelInFolder:MLModelId")]
		public virtual ICollection<MLModelInFolder> MLModelInFolderByMLModel { get; set; }
		[CProperty(Association ="MLModelInTag:EntityId")]
		public virtual ICollection<MLModelInTag> MLModelInTagByEntity { get; set; }
		[CProperty(Association ="MLPrediction:ModelId")]
		public virtual ICollection<MLPrediction> MLPredictionByModel { get; set; }
		[CProperty(Association ="MLTrainSession:MLModelId")]
		public virtual ICollection<MLTrainSession> MLTrainSessionByMLModel { get; set; }
		#endregion
	}
}
