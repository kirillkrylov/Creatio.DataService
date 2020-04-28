using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "IntegrationFilter")]
	public class IntegrationFilter : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BPMColumn")]
		public Guid BPMColumn { get; set; }
		[CProperty(ColumnPath ="BPMColumnName")]
		public string BPMColumnName { get; set; }
		[CProperty(ColumnPath ="BPMCompareColumn")]
		public Guid BPMCompareColumn { get; set; }
		[CProperty(ColumnPath ="BPMCompareColumnName")]
		public string BPMCompareColumnName { get; set; }
		[CProperty(ColumnPath ="CompareDataValueType")]
		public int CompareDataValueType { get; set; }
		[CProperty(ColumnPath ="CompareReferenceSchemaName")]
		public string CompareReferenceSchemaName { get; set; }
		[CProperty(ColumnPath ="ComparisonTypeId")]
		public Guid ComparisonTypeId { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DataValueType")]
		public int DataValueType { get; set; }
		[CProperty(ColumnPath ="DesignBPMColumnName")]
		public string DesignBPMColumnName { get; set; }
		[CProperty(ColumnPath ="DesignBPMCompareColumnName")]
		public string DesignBPMCompareColumnName { get; set; }
		[CProperty(ColumnPath ="FilterDirectionId")]
		public Guid FilterDirectionId { get; set; }
		[CProperty(ColumnPath ="FilterTypeId")]
		public Guid FilterTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationObjectId")]
		public Guid IntegrationObjectId { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OneCObjectColumnId")]
		public Guid OneCObjectColumnId { get; set; }
		[CProperty(ColumnPath ="OneCObjectCompareColumnId")]
		public Guid OneCObjectCompareColumnId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ReferenceSchemaName")]
		public string ReferenceSchemaName { get; set; }
		[CProperty(ColumnPath ="Value")]
		public string Value { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FilterDirection:FilterDirectionId")]
		public FilterDirection FilterDirection { get; set; }
		[CProperty(Navigation ="IntegrationComparisonType:ComparisonTypeId")]
		public IntegrationComparisonType ComparisonType { get; set; }
		[CProperty(Navigation ="IntegrationFilterType:FilterTypeId")]
		public IntegrationFilterType FilterType { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectColumnId")]
		public OneCObjectColumn OneCObjectColumn { get; set; }
		[CProperty(Navigation ="OneCObjectColumn:OneCObjectCompareColumnId")]
		public OneCObjectColumn OneCObjectCompareColumn { get; set; }
		[CProperty(Navigation ="SyncObject:IntegrationObjectId")]
		public SyncObject IntegrationObject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
