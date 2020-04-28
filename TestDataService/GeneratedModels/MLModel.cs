using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MLModel")]
	public class MLModel : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BatchPredictedOn")]
		public DateTime BatchPredictedOn { get; set; }
		[CProperty(ColumnPath ="BatchPredictionFilterData")]
		public byte[] BatchPredictionFilterData { get; set; }
		[CProperty(ColumnPath ="BatchPredictionQuery")]
		public string BatchPredictionQuery { get; set; }
		[CProperty(ColumnPath ="BatchPredictionStartMethodId")]
		public Guid BatchPredictionStartMethodId { get; set; }
		[CProperty(ColumnPath ="ConfidentValueLowEdge")]
		public decimal ConfidentValueLowEdge { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Description")]
		public string Description { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="InstanceMetric")]
		public decimal InstanceMetric { get; set; }
		[CProperty(ColumnPath ="LastError")]
		public string LastError { get; set; }
		[CProperty(ColumnPath ="MetaData")]
		public string MetaData { get; set; }
		[CProperty(ColumnPath ="MetaDataLcz")]
		public string MetaDataLcz { get; set; }
		[CProperty(ColumnPath ="MetricThreshold")]
		public decimal MetricThreshold { get; set; }
		[CProperty(ColumnPath ="MLConfidentValueMethodId")]
		public Guid MLConfidentValueMethodId { get; set; }
		[CProperty(ColumnPath ="MLProblemTypeId")]
		public Guid MLProblemTypeId { get; set; }
		[CProperty(ColumnPath ="ModelInstanceUId")]
		public string ModelInstanceUId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="Notes")]
		public string Notes { get; set; }
		[CProperty(ColumnPath ="PredictedResultColumnUId")]
		public Guid PredictedResultColumnUId { get; set; }
		[CProperty(ColumnPath ="PredictionEnabled")]
		public bool PredictionEnabled { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="RootSchemaUId")]
		public Guid RootSchemaUId { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="TargetColumnUId")]
		public Guid TargetColumnUId { get; set; }
		[CProperty(ColumnPath ="TrainedOn")]
		public DateTime TrainedOn { get; set; }
		[CProperty(ColumnPath ="TrainFrequency")]
		public int TrainFrequency { get; set; }
		[CProperty(ColumnPath ="TrainingFilterData")]
		public byte[] TrainingFilterData { get; set; }
		[CProperty(ColumnPath ="TrainingMaxRecordsCount")]
		public int TrainingMaxRecordsCount { get; set; }
		[CProperty(ColumnPath ="TrainingMinimumRecordsCount")]
		public int TrainingMinimumRecordsCount { get; set; }
		[CProperty(ColumnPath ="TrainingOutputFilterData")]
		public byte[] TrainingOutputFilterData { get; set; }
		[CProperty(ColumnPath ="TrainingSetQuery")]
		public string TrainingSetQuery { get; set; }
		[CProperty(ColumnPath ="TrainSessionId")]
		public Guid TrainSessionId { get; set; }
		[CProperty(ColumnPath ="TriedToTrainOn")]
		public DateTime TriedToTrainOn { get; set; }
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
