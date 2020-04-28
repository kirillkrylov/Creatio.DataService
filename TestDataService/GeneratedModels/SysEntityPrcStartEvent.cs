using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysEntityPrcStartEvent")]
	public class SysEntityPrcStartEvent : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="ChangedColumns")]
		public string ChangedColumns { get; set; }
		[CProperty(ColumnPath ="ConditionData")]
		public string ConditionData { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public override Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="ProcessSchemaElementUId")]
		public Guid ProcessSchemaElementUId { get; set; }
		[CProperty(ColumnPath ="ProcessSchemaId")]
		public Guid ProcessSchemaId { get; set; }
		[CProperty(ColumnPath ="RecordChangeType")]
		public int RecordChangeType { get; set; }
		[CProperty(ColumnPath ="Signal")]
		public string Signal { get; set; }
		[CProperty(ColumnPath ="WaitingRandomSignal")]
		public bool WaitingRandomSignal { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="SysSchema:ProcessSchemaId")]
		public SysSchema ProcessSchema { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
