using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "TableSyncColumn")]
	public class TableSyncColumn : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="BPMColumn")]
		public Guid BPMColumn { get; set; }
		[CProperty(ColumnPath ="BPMColumnName")]
		public string BPMColumnName { get; set; }
		[CProperty(ColumnPath ="ConstValue")]
		public string ConstValue { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="DefaultValue")]
		public string DefaultValue { get; set; }
		[CProperty(ColumnPath ="FillColumnTypeId")]
		public Guid FillColumnTypeId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="IntegrationObjectId")]
		public Guid IntegrationObjectId { get; set; }
		[CProperty(ColumnPath ="IsDefault")]
		public bool IsDefault { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OneCDetailColumnId")]
		public Guid OneCDetailColumnId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="FillColumnType:FillColumnTypeId")]
		public FillColumnType FillColumnType { get; set; }
		[CProperty(Navigation ="OneCObjectDetailColumn:OneCDetailColumnId")]
		public OneCObjectDetailColumn OneCDetailColumn { get; set; }
		[CProperty(Navigation ="SyncColumn:IntegrationObjectId")]
		public SyncColumn IntegrationObject { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
