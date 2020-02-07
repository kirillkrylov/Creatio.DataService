using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "SysModuleStageHistory")]
	public class SysModuleStageHistory : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="Active")]
		public bool Active { get; set; }
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath ="EntitySchemaUId")]
		public Guid EntitySchemaUId { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="OwnerColUId")]
		public Guid OwnerColUId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="StageColUId")]
		public Guid StageColUId { get; set; }
		[CProperty(ColumnPath ="StageHistoryDueDateColUId")]
		public Guid StageHistoryDueDateColUId { get; set; }
		[CProperty(ColumnPath ="StageHistoryHistoricalColUId")]
		public Guid StageHistoryHistoricalColUId { get; set; }
		[CProperty(ColumnPath ="StageHistoryMainEntityColUId")]
		public Guid StageHistoryMainEntityColUId { get; set; }
		[CProperty(ColumnPath ="StageHistoryOwnerColUId")]
		public Guid StageHistoryOwnerColUId { get; set; }
		[CProperty(ColumnPath ="StageHistorySchemaUId")]
		public Guid StageHistorySchemaUId { get; set; }
		[CProperty(ColumnPath ="StageHistoryStageColUId")]
		public Guid StageHistoryStageColUId { get; set; }
		[CProperty(ColumnPath ="StageHistoryStartDateColUId")]
		public Guid StageHistoryStartDateColUId { get; set; }
		[CProperty(ColumnPath ="StageIsFinalColUId")]
		public Guid StageIsFinalColUId { get; set; }
		[CProperty(ColumnPath ="StageIsSuccessfulColUId")]
		public Guid StageIsSuccessfulColUId { get; set; }
		[CProperty(ColumnPath ="StageOrderColUId")]
		public Guid StageOrderColUId { get; set; }
		[CProperty(ColumnPath ="StageSchemaUId")]
		public Guid StageSchemaUId { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		#endregion

		#region Associations
		#endregion
	}
}
