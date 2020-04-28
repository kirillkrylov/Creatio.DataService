using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "MLTrainSession")]
	public class MLTrainSession : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="Error")]
		public string Error { get; set; }
		[CProperty(ColumnPath ="FeatureImportances")]
		public string FeatureImportances { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IgnoreMetricThreshold")]
		public bool IgnoreMetricThreshold { get; set; }
		[CProperty(ColumnPath ="InstanceMetric")]
		public decimal InstanceMetric { get; set; }
		[CProperty(ColumnPath ="InUse")]
		public bool InUse { get; set; }
		[CProperty(ColumnPath ="MLModelId")]
		public Guid MLModelId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StateId")]
		public Guid StateId { get; set; }
		[CProperty(ColumnPath ="TrainedOn")]
		public DateTime TrainedOn { get; set; }
		[CProperty(ColumnPath ="TrainingTimeMinutes")]
		public int TrainingTimeMinutes { get; set; }
		[CProperty(ColumnPath ="TrainSetSize")]
		public int TrainSetSize { get; set; }
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
