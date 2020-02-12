using System;
using Creatio.DataService.Attributes;
using System.Collections.Generic;
namespace Creatio.DataService.Models
{
	[CObject(RootSchemaName = "OneCObjectDetailColumn")]
	public class OneCObjectDetailColumn : BaseEntity
	{
		#region Values
		[CProperty(ColumnPath ="CreatedById")]
		public Guid CreatedById { get; set; }
		[CProperty(ColumnPath ="CreatedOn")]
		public DateTime CreatedOn { get; set; }
		[CProperty(ColumnPath="Id", IsKey=true)]
		public Guid Id { get; set; }
		[CProperty(ColumnPath ="IsCheck")]
		public bool IsCheck { get; set; }
		[CProperty(ColumnPath ="ModifiedById")]
		public Guid ModifiedById { get; set; }
		[CProperty(ColumnPath ="ModifiedOn")]
		public DateTime ModifiedOn { get; set; }
		[CProperty(ColumnPath ="Name")]
		public string Name { get; set; }
		[CProperty(ColumnPath ="OneCObjectDetailId")]
		public Guid OneCObjectDetailId { get; set; }
		[CProperty(ColumnPath ="ProcessListeners")]
		public int ProcessListeners { get; set; }
		[CProperty(ColumnPath ="Type")]
		public string Type { get; set; }
		#endregion

		#region Navigation
		[CProperty(Navigation="Contact:CreatedById")]
		public Contact CreatedBy { get; set; }
		[CProperty(Navigation="Contact:ModifiedById")]
		public Contact ModifiedBy { get; set; }
		[CProperty(Navigation ="OneCObjectDetail:OneCObjectDetailId")]
		public OneCObjectDetail OneCObjectDetail { get; set; }
		#endregion

		#region Associations
		[CProperty(Association ="SyncColumn:IdentityColumnId")]
		public virtual ICollection<SyncColumn> SyncColumnByIdentityColumn { get; set; }
		[CProperty(Association ="TableIntegrationFilter:OneCObjectColumnId")]
		public virtual ICollection<TableIntegrationFilter> TableIntegrationFilterByOneCObjectColumn { get; set; }
		[CProperty(Association ="TableIntegrationFilter:OneCObjectCompareColumnId")]
		public virtual ICollection<TableIntegrationFilter> TableIntegrationFilterByOneCObjectCompareColumn { get; set; }
		[CProperty(Association ="TableSyncColumn:OneCDetailColumnId")]
		public virtual ICollection<TableSyncColumn> TableSyncColumnByOneCDetailColumn { get; set; }
		#endregion
	}
}
